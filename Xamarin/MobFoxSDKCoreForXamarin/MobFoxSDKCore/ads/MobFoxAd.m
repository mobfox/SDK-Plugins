

//
//  MobFoxAd.m
//  Test
//
//  Created by Itamar Nabriski on 6/4/15.
//  Copyright (c) 2015 Itamar Nabriski. All rights reserved.
//

#import "MobFoxAd.h"
#import "MFConstants.h"
#import <arpa/inet.h>
#import "MFDeviceExtention.h"
#import "MFSDKManager.h"
#import "MFAdvertisingManager.h"
#import "MFExceptionHandler.h"
#import "MFReport.h"
#import "MFTimerHandler.h"

@import AdSupport.ASIdentifierManager;


#define AUTO_REDIRECT_TEST 0
#define MOVIE_URL_TESTING @"http://creative2cdn.mobfox.com/cc45f6b75301d1ed27ae4b9d8d8e3058.mp4"

static const float RESPONSE_TIMEOUT = 3.0;


@interface MobFoxAd()

    @property (nonatomic, strong) NSDictionary *dataDict;
    @property (nonatomic, strong) NSMutableDictionary *adDict;
    @property (nonatomic, strong) UIWebView *webView;
    @property (nonatomic, strong) NSString *waterfall;
    @property (nonatomic, strong) NSString *idfaString;

    @property (nonatomic, assign) BOOL isAdLoaded;
    @property (nonatomic, assign) BOOL isAdHidden;
    @property (nonatomic, assign) BOOL isAdInitiated;
	@property (nonatomic, assign) BOOL isReady;
    @property (nonatomic, assign) BOOL isResponseTimeout;
    @property (nonatomic, assign) BOOL secure;

    @property (nonatomic, strong) NSDate *reqStartTime;
    @property (nonatomic, strong) NSLock *responseLock;
    @property (nonatomic, strong) NSTimer *responseTimeoutTimer;
    @property (nonatomic, strong) NSCondition *readyCond;
    @property (nonatomic, strong) NSArray *events;
    @property (nonatomic, strong) MFTimerHandler *timer;
    @property (nonatomic, strong) NSString *requestID;


@end

static BOOL locationServicesDisabled;
static NSURL *indexUrl;


@implementation MobFoxAd
{
    UIView *customEventView;
    NSString *customEventPixel;
    MobFoxCustomEvent *customEvent;
    BOOL isInit;
    BOOL isAdTouched;
    
}

+ (void)locationServicesDisabled:(BOOL)disabled {
    
    locationServicesDisabled = disabled;
    
}


/*
// Only override drawRect: if you perform custom drawing.
// An empty implementation adversely affects performance during animation.
- (void)drawRect:(CGRect)rect {
    // Drawing code
}
*/

// 
- (BOOL)handleATS {
    
    BOOL secureResult = NO;
    
    if (OS_VERSION >= 9.0) {
        
        NSDictionary *dict = [[NSBundle mainBundle] objectForInfoDictionaryKey:@"NSAppTransportSecurity"];
        //NSLog(@"dict: %@", dict);
        
        if (dict != nil) {
            
            BOOL isATSDisabled = [[dict objectForKey:@"NSAllowsArbitraryLoads"] boolValue];
            //NSLog(@"isATSDisabled: %d", isATSDisabled);
            
            if (!isATSDisabled) {
                
                secureResult = YES;
            }
            
        } else {
            
            secureResult = YES;
        }
    }
    
    return secureResult;
    
}

- (void)_setFrame:(CGRect)aRect {
    
    self.webView.frame = aRect;
    self.frame = aRect;
}

- (void)_setSize:(CGSize)size withContainer:(CGSize)container {
    
    self.adspace_width = [NSNumber numberWithInt:(int)size.width];
    self.adspace_height = [NSNumber numberWithInt:(int)size.height];
    
    self.frame = CGRectMake(self.frame.origin.x, self.frame.origin.y, container.width, container.height);
    self.webView.frame = self.bounds;
    
}


/*************** initialization ***************/

- (void)_init:(NSString*)invh {
    
    
    [[MFSDKManager sharedInstance] warmUp];
    
    __weak id weakself = self;
    
    id notificationObserver_didEnterBackground;
    notificationObserver_didEnterBackground = [[NSNotificationCenter defaultCenter] addObserverForName:UIApplicationDidEnterBackgroundNotification object:nil queue:[NSOperationQueue mainQueue] usingBlock:^(NSNotification *note) {
        
        [self->_timer stopTimer:self];
        
        MobFoxAd *strongself = weakself;

        
        // NOTE: avoids from multithreading crash when self already released.
        if (strongself) {
            
            if(strongself.responseTimeoutTimer){
                [strongself.responseTimeoutTimer invalidate];
                strongself.responseTimeoutTimer = nil;
            }
            // removing webview to avoid ad rendering (crash)
            if([strongself.adFormat isEqualToString:@"banner"]) {
                strongself.isAdHidden = strongself.hidden;
                
                [strongself cleanupWebView];
                
            }
        }
        
    }];
    
    id notificationObserver_didFinishLaunching;
    notificationObserver_didFinishLaunching = [[NSNotificationCenter defaultCenter] addObserverForName:UIApplicationDidFinishLaunchingNotification object:nil queue:[NSOperationQueue mainQueue] usingBlock:^(NSNotification *note) {
        
        
    }];
    id notificationObserver_didBecomeActive;
    notificationObserver_didBecomeActive = [[NSNotificationCenter defaultCenter] addObserverForName:UIApplicationDidBecomeActiveNotification object:nil queue:[NSOperationQueue mainQueue] usingBlock:^(NSNotification *note) {
        
        //NSLog(@"notificationObserver_didBecomeActive");
        
        [[MFExceptionHandler sharedInstance] reportOnException];
        
    }];
    
    id notificationObserver_willEnterForeground;
    notificationObserver_willEnterForeground = [[NSNotificationCenter defaultCenter] addObserverForName:UIApplicationWillEnterForegroundNotification object:nil queue:[NSOperationQueue mainQueue] usingBlock:^(NSNotification *note) {
        
        MobFoxAd* strongself = (MobFoxAd *)weakself;

        if([strongself.adFormat isEqualToString:@"banner"]) {
            
            [strongself initWebView];
            [strongself initBridge];
            
            if(strongself.isAdLoaded && !strongself.isAdHidden) {
                
                [strongself loadAd];
            }
            
        }
        
    }];
    
    
    self.idfaString = [MFAdvertisingManager identifier];
    MFSDKManager *sdkManager = [MFSDKManager sharedInstance];
    
    [sdkManager waterfallsWithInventoryHash:invh completion:^(NSString *wf) {
        MobFoxAd *strongself = weakself;
        strongself.waterfall = wf;
    }];
    
    if(!locationServicesDisabled) {
        
        self.locationServicesManager = [MFLocationServicesManager sharedInstance];
        [self.locationServicesManager findLocation];
        
    } else {
        
        if(self.locationServicesManager != nil) {
            [self.locationServicesManager stopFindingLocation];
        }
    }
    
    self.isAdLoaded = false;
    self.isReady = false;
    self.isResponseTimeout = false;
    self.responseTimeoutTimer = nil;
    self.responseLock = [[NSLock alloc ] init];
    
    isInit = NO;
    self.invh = invh;
    self.readyCond = [[NSCondition alloc] init];
    
    customEventView = nil;
    customEventPixel = nil;
    customEvent = nil;
    self.delegateCustomEvents = NO;
    
    UITapGestureRecognizer *tapRecognizer = [[UITapGestureRecognizer alloc] initWithTarget:self action:nil];
    [self addGestureRecognizer:tapRecognizer];
    self.userInteractionEnabled = YES;
    tapRecognizer.delegate = self;
    
   
    self.opaque = NO;
    self.backgroundColor = [UIColor clearColor];
    
    self.hidden = YES;
    self.autoplay = YES;
    self.skip = NO;
    
    if([[[NSProcessInfo processInfo] environment] objectForKey:@"TEST"]) {
        
        self.secure = false;
        //NSLog(@"TEST !!!!!!!!!!!!!!");
        
        /*?????
        if([MFTestsDefines isATSEnabled]) {
            
            self.secure = true;
            //NSLog(@"ATS Enabled !!!!!!!!!!!!!!");

        }
         */


    } else {
        //NSLog(@"NO-TEST !!!!!!!!!!!!!!");

        self.secure = [self handleATS];

    }
    
    self.type = @"waterfall";
    self.adFormat = @"banner";
    //self.refresh = @0;
    self.delegate = nil;
    
    
    [self initWebView];
    [self initBridge];
    
    isInit = YES;
    
    
}

-(id) init:(NSString*)invh{
    self = [super init];
    [self _init:invh];
    return self;
}

-(id) init:(NSString*)invh withFrame:(CGRect)aRect
{
    self = [super initWithFrame:aRect];
    [self _init:invh];
    return self;
}

- (void)initWebView {
    
    self.webView = [[UIWebView alloc] init];
    self.webView.frame = self.bounds;
    
    self.webView.scrollView.scrollEnabled = NO;
    self.webView.scrollView.bounces = NO;
    
    NSURL *url = [[NSURL alloc] initWithString:[[MFSDKManager sharedInstance] getSdkUrl:self.secure]];
    //NSLog(@"sdk url: %@", url);
    [self.webView loadRequest:[NSURLRequest requestWithURL:url]];
    self.webView.allowsInlineMediaPlayback = true;
    self.webView.mediaPlaybackRequiresUserAction = false;
    self.webView.opaque = NO;
    self.webView.backgroundColor = [UIColor clearColor];
    
    [self addSubview:self.webView];
    
}

- (void)initBridge {
    
    self.isReady = false;
    self.bridge = [MFWebViewJavascriptBridge bridgeForWebView:self.webView];
    [self.bridge setWebViewDelegate:self];
    
    ////
    __weak id weakself = self;
    ////
    
    // video click detected.
    [self.bridge registerHandler:@"click" handler:^(id data, WVJBResponseCallback responseCallback) {
        
        //NSLog(@"click Log: %@", data);
        
        MobFoxAd* strongself = (MobFoxAd *)weakself;
        
        
        if (strongself != nil) {
            
            [[UIApplication sharedApplication] openURL:[NSURL URLWithString:data]];
            
            if ([strongself.delegate respondsToSelector:@selector(MobFoxAdClicked)]) {
                [strongself.delegate MobFoxAdClicked];
            }
        }
        
    }];
    
    // video finished.
    [self.bridge registerHandler:@"finished" handler:^(id data, WVJBResponseCallback responseCallback) {
        
        MobFoxAd* strongself = (MobFoxAd *)weakself;
        
        if (strongself == nil) {
            return;
        }
        
        if ([strongself.delegate respondsToSelector:@selector(MobFoxAdFinished)]) {
            [strongself.delegate MobFoxAdFinished];
        }
        
        
    }];
    
    [self.bridge registerHandler:@"error" handler:^(id data, WVJBResponseCallback responseCallback) {
        
        MobFoxAd* strongself = (MobFoxAd *)weakself;
        
        if (strongself == nil) return;
        
        NSError* err;
        NSDictionary *dict = (NSDictionary*)data;
        NSDictionary *dict_e = [dict objectForKey:@"error"];
        NSNumber *no_ad = [dict_e objectForKey:@"noAd"];
        
        
        if([no_ad intValue] == 1) {
            
            err = [NSError errorWithDomain:@"no ad could be found for this request (no fill)" code:0 userInfo:nil];
            //NSLog(@"##error (no ad): %@", err);
            
        } else {
            
            err = [NSError errorWithDomain:[data description] code:0 userInfo:nil];
        }
        
        [strongself removeTimeout];
        
        if ([strongself.delegate respondsToSelector:@selector(MobFoxAdDidFailToReceiveAdWithError:)]) {
            [strongself.delegate MobFoxAdDidFailToReceiveAdWithError:err];
        }
        
    }];
    
    [self.bridge registerHandler:@"close" handler:^(id data, WVJBResponseCallback responseCallback) {
        
        //NSLog(@"close Log: %@", data);
        //[self removeFromSuperview];
        
        MobFoxAd* strongself = (MobFoxAd *)weakself;
        
        if (strongself != nil) {
            
            strongself.hidden = YES;
            
            if ([strongself.delegate respondsToSelector:@selector(MobFoxAdClosed)]) {
                [strongself.delegate MobFoxAdClosed];
            }
        }
    }];
    
    [self.bridge registerHandler:@"console" handler:^(id data, WVJBResponseCallback responseCallback) {
        
        NSLog(@"console.log: %@", data);
        
    }];
    
    [self.bridge registerHandler:@"ready" handler:^(id data, WVJBResponseCallback responseCallback) {
        
        NSLog(@"-- ready --");
        
        MobFoxAd* strongself = (MobFoxAd *)weakself;
        
        if (strongself) {
            
            [strongself.readyCond lock];
            strongself.isReady = true;
            [strongself.readyCond signal];
            [strongself.readyCond unlock];
        }
        
        if([[[NSProcessInfo processInfo] environment] objectForKey:@"TEST"]) {
            NSLog(@"-- TEST --");
            [strongself.webView stringByEvaluatingJavaScriptFromString:@"window.localStorage.clear()"];
        }

        
    }];
    
    [self.bridge registerHandler:@"loadAdResponse" handler:^(id responseData, WVJBResponseCallback responseCallback) {
        

        
        MobFoxAd* strongself = (MobFoxAd *)weakself;
        
        if (strongself == nil) return;
        
        //NSLog(@"MobFox ad load time: %f",-[strongself.reqStartTime timeIntervalSinceNow]);
        NSLog(@"MobFox ad response: %@", responseData);
        
        
        //handle timeout
        [strongself.responseLock lock];
        if(strongself.isResponseTimeout){
            [strongself.responseLock unlock];
            return;
        }
        [strongself.responseLock unlock];
        
        
        if(responseData == nil) {
            NSError *err = [NSError errorWithDomain:@"empty response" code:0 userInfo:nil];
            
            [strongself removeTimeout];
            
            if ([strongself.delegate respondsToSelector:@selector(MobFoxAdDidFailToReceiveAdWithError:)]) {
                [strongself.delegate MobFoxAdDidFailToReceiveAdWithError:err];
            }
            
            return;
            
        }
        
        NSMutableDictionary *dict = [responseData mutableCopy];
        
        strongself.hidden = YES;
        //self.webView.hidden = YES;
        
        if ([responseData isKindOfClass:[NSDictionary class]]) {
            
            NSMutableDictionary *dict = (NSMutableDictionary *)responseData;
            strongself.adDict = dict;
            
            if([self.adDict objectForKey:@"requestID"]) {
                NSDictionary *requestID_dict = [self.adDict objectForKey:@"requestID"];
                
                NSLog(@"requestID_dict: %@", requestID_dict);

                self->_requestID = [requestID_dict objectForKey:@"__cdata"];
                
                NSLog(@"_requestID: %@", self->_requestID);
            }

            
            // In case of Interstitial ad.
            if(strongself.delegateCustomEvents && [strongself.delegate respondsToSelector:@selector(MobFoxDelegateCustomEvents:withAdDict:)]){
                
                [strongself.responseLock lock];
                if(strongself.isResponseTimeout){
                    [strongself.responseLock unlock];
                    return;
                }
                [strongself.responseTimeoutTimer invalidate];
                strongself.responseTimeoutTimer = nil;
                [strongself.responseLock unlock];
                
                [strongself.delegate MobFoxDelegateCustomEvents:(NSArray*)[dict objectForKey:@"customEvents"] withAdDict:strongself.adDict];
                
                return;
            }
            
            strongself->_events = (NSArray*)[dict objectForKey:@"customEvents"];
            // if ad key exist. and save dictionary.
            dispatch_async(dispatch_get_main_queue(), ^{
                [strongself loadCustomEvent];
            });
            
            return;
        }
        
        //failure
        NSError* err;
        id dict_e = [dict objectForKey:@"error"];
        if([dict_e isKindOfClass:[NSDictionary class]]) {
            NSNumber *no_ad = [dict_e objectForKey:@"noAd"];
            NSLog(@"##error no_ad: %@", no_ad);
            
            if([no_ad intValue] == 1) {
                
                err = [NSError errorWithDomain:@"no ad could be found for this request (no fill)" code:0 userInfo:nil];
                NSLog(@"##error (no ad): %@", err);
                
            } else {
                
                err = [NSError errorWithDomain:[responseData description] code:0 userInfo:nil];
            }
        } else {
            
            err = [NSError errorWithDomain:[responseData description] code:0 userInfo:nil];
        }
        
        
        [strongself removeTimeout];
        
        if ([strongself.delegate respondsToSelector:@selector(MobFoxAdDidFailToReceiveAdWithError:)]) {
            [strongself.delegate MobFoxAdDidFailToReceiveAdWithError:err];
        }
        
    }];
    
}

- (void)removeTimeout {
    
    [self.responseLock lock];
    if(self.isResponseTimeout){
        [self.responseLock unlock];
        return;
    }
    [self.responseTimeoutTimer invalidate];
    self.responseTimeoutTimer = nil;
    [self.responseLock unlock];
}


- (void)onResponseTimeout:(NSTimer *)timer {
    
    // NSLog(@"onResponseTimeout:");
    
    [self.responseLock lock];
    [self.responseTimeoutTimer invalidate];
    self.responseTimeoutTimer = nil;
    
    self.isResponseTimeout = true;
    [self.responseLock unlock];
    [self.readyCond signal];

     __weak id weakself = self;
    
    dispatch_async(dispatch_get_main_queue(), ^{
        NSError* err = [NSError errorWithDomain:@"request timeout out" code:0 userInfo:nil];
        
        MobFoxAd* strongself = (MobFoxAd *)weakself;
        if(strongself == nil) return;
        
        
        if ([strongself.delegate respondsToSelector:@selector(MobFoxAdDidFailToReceiveAdWithError:)]) {
            [strongself.delegate MobFoxAdDidFailToReceiveAdWithError:err];
        }
        
    });
    

}

- (void) loadAd {
    
    [self __loadAd];

    int interval_int = [self.refresh intValue];
    
    if(interval_int > RESPONSE_TIMEOUT) {
        
    if(_timer) [_timer stopTimer:self];
    _timer = [[MFTimerHandler alloc] init];
    [_timer startTimerWithInterval:interval_int completion:^(bool triggered) {
        
        if (triggered) {
            [self __loadAd];
        }
    }];
    }
    
}

- (void) __loadAd {
    
    NSLog(@"MobFoxAd --- loadAd");

    self.reqStartTime = [NSDate date];
    
	[self.responseLock lock];
    self.isResponseTimeout = false;
    [self.responseLock unlock];
    
     __weak id weakself = self;
    
    self.responseTimeoutTimer = [NSTimer scheduledTimerWithTimeInterval:RESPONSE_TIMEOUT
                                     target:weakself
                                   selector:@selector(onResponseTimeout:)
                                   userInfo:nil
                                    repeats:NO];
    
    
    dispatch_async(dispatch_get_global_queue(DISPATCH_QUEUE_PRIORITY_DEFAULT, 0), ^{
        
            MobFoxAd *strongself = weakself;
            if(strongself == nil) return;

            //NSLog(@"MobFox re-thread: %f",-[strongself.reqStartTime timeIntervalSinceNow]);
            //NSLog(@"self.isReady: %d", strongself.isReady);
        
            [strongself.readyCond lock];
            while (!strongself.isReady && !strongself.isResponseTimeout) {
                
                //NSLog(@"loop -- self.isReady: %d", strongself.isReady);
                [strongself.readyCond wait];
            }
            [strongself.readyCond unlock];
        
            // NSLog(@"MobFox readinnes: %f",-[strongself.reqStartTime timeIntervalSinceNow]);
        
            if(strongself.isResponseTimeout) return;
        
            // stopped or ending the task outright.
            //[[UIApplication sharedApplication] endBackgroundTask:bgTask];
        
          //  NSLog(@"MobFox --- IS READY!");

        
            dispatch_async(dispatch_get_main_queue(), ^{
               //NSLog(@"MobFoxAd --- set wf");
               [strongself.bridge callHandler:@"setWaterfallsJson" data:strongself.waterfall];
				
					@try {
                        [strongself _loadAd];
                        
		            }
		            @catch (NSException *exception) {
		                NSLog(@"MobFox SDK (MobFoxAd - loadAd) Exception: %@", exception.reason);
		                
		            }
		            @finally {
		                // ..
		            }
            });
    });
   
  
}

- (BOOL)isViewVisible {
    
    BOOL isVisible = true;
    UIView *subview = self;
    UIView *superview = subview.superview;
    
    if(superview == nil) return false;
        
    
    /*
    if(![subview isDescendantOfView:superview]) {
        return false;
    }*/
    
    CGRect absolutePosition = [self convertRect:self.bounds toView:nil];
    
    float screenW = [[UIScreen mainScreen] bounds].size.width;
    float screenH = [[UIScreen mainScreen] bounds].size.height;
    CGRect windowRect = CGRectMake(0, 0, screenW, screenH);
    
    //UIScrollView *scrollView = superview;
    
    
    // Checks ad isn't inside a scroll view.
    if([superview isKindOfClass:[UIScrollView class]]) {
        
        CGRect visibleRect;
        UIScrollView *scrollView = (UIScrollView*)superview;
        visibleRect.size = scrollView.bounds.size;
        visibleRect.origin = scrollView.contentOffset;
        //CGRect containedViewRect = self.bounds;
        
        if(self.frame.origin.y > scrollView.contentOffset.y + screenH || self.frame.origin.y < scrollView.contentOffset.y) {
            //NSLog(@"rect isn't contained!!");
            return false;
        }

    }
    
    // Checks for absolute position.
    if (!CGRectContainsRect(windowRect, absolutePosition)) {
        //NSLog(@"rect isn't contained!!");
        return false;
    }

    
    
    // checks if self or its parents are hidden.
    if (subview.isHidden) {
        //return false;
    }
    
    UIView* topView = subview;

    while(topView.superview != nil){
        topView = topView.superview;
        
        if(!(topView && ![topView isHidden])) {
            
            isVisible = false;
            break;
        }
    }

    return isVisible;
    
}

- (void)_loadAd {
    
    NSLog(@"_loadAd");
    

    
    self.isAdLoaded = true;
    
    if(!isInit){
        NSLog(@"MobFox Error >>> Ad was not initialized successfully.");
        return;
    }
    
    isAdTouched = NO;
    self.hidden = YES;
    
    if(customEventView != nil){
        [customEventView removeFromSuperview];
        customEventView = nil;
        customEventPixel = nil;
    }
    
    NSMutableDictionary* params = [[NSMutableDictionary alloc] init];
    
    if([self.adFormat isEqualToString:@"interstitial"]) {
        [params setObject:@"7" forKey:@"banner_pos"];
    } else {
        [params setObject:[self isViewVisible] ? @"1" : @"3" forKey:@"banner_pos"];
    }

    if(self.type) [params setObject:self.type forKey:@"type"];
    [params setObject:self.autoplay ? @"true" : @"false" forKey:@"autoplay"];
    [params setObject:self.skip ? @"true" : @"" forKey:@"skip"];
    if(self.secure) [params setObject:self.secure ? @"true" : @"" forKey:@"secure"];
    //if(self.refresh) [params setObject:self.refresh forKey:@"refresh"];
    if(self.invh) [params setObject:self.invh forKey:@"s"];
    if(SDK_VERSION) [params setObject:[NSString stringWithFormat:@"%@_%@", SDK_VERSION, @"static_core"] forKey:@"v"];
    [params setObject:@"true" forKey:@"hide_mute"];
    if(!self.autoplay){
        [params setObject:@"true" forKey:@"hide_play"];
    }
    if(self.idfaString) [params setObject:self.idfaString forKey:@"o_iosadvid"];
    [params setObject:self.no_markup ? @"true" : @"false" forKey:@"no_markup"];
    [params setObject:[self isAdspace_strict] ? [NSNumber numberWithInt:1] : [NSNumber numberWithInt:0] forKey:@"adspace_strict"];
    
    //[params setObject:[[NSBundle mainBundle] bundleIdentifier] forKey:@"sub_bundle_id"];
    
    [params setObject:@"com.mobfox.-" forKey:@"sub_bundle_id"];

    //NSLog(@"bundle identifier: %@", [[NSBundle mainBundle] bundleIdentifier]);
    
    NSString* rt = [MFDeviceExtention isIpad] ? @"ipad_app" : @"iphone_app";
    [params setObject:rt forKey:@"rt"];
    
    
    if(self.adspace_width){
        [params setObject:[NSString stringWithFormat:@"%d", self.adspace_width.intValue] forKey:@"adspace_width"];
    }else{
        [params setObject:[NSString stringWithFormat:@"%d", (int)self.frame.size.width] forKey:@"adspace_width"];
    }
    
    if(self.adspace_height){
        [params setObject:[NSString stringWithFormat:@"%d", self.adspace_height.intValue] forKey:@"adspace_height"];
    }
    else{
        [params setObject:[NSString stringWithFormat:@"%d", (int)self.frame.size.height] forKey:@"adspace_height"];
    }
    
    
    if(self.adFormat) [params setObject:self.adFormat forKey:@"adFormat"];
    if(self.demo_gender) [params setObject:self.demo_gender forKey:@"demo_gender"];
    if(self.demo_age) [params setObject:self.demo_age forKey:@"demo_age"];
    if(self.s_subid) [params setObject:self.s_subid forKey:@"s_subid"];
    if(self.sub_name) [params setObject:self.sub_name forKey:@"sub_name"];
    if(self.sub_domain) [params setObject:self.sub_domain forKey:@"sub_domain"];
    if(self.sub_storeurl) [params setObject:self.sub_storeurl forKey:@"sub_storeurl"];
    if(self.v_dur_max) [params setObject:self.v_dur_max forKey:@"v_dur_max"];
    if(self.r_floor) [params setObject:self.r_floor forKey:@"r_floor"];
    
    if(self.locationServicesManager.longitude && self.locationServicesManager.latitude) {
        
        self.longitude = [NSString stringWithFormat:@"%f", self.locationServicesManager.longitude];
        self.latitude = [NSString stringWithFormat:@"%f", self.locationServicesManager.latitude];
    }
    
    if(self.longitude) [params setObject:self.longitude forKey:@"longitude"];
    if(self.latitude) [params setObject:self.latitude forKey:@"latitude"];

    
     // NSLog(@"*** load it!");
    //NSLog(@"MobFox ready to load ad part 2: %f",-[self.reqStartTime timeIntervalSinceNow]);
    [self.bridge callHandler:@"loadAd" data:params];
    
    
    //#ifdef DEBUG
    NSLog(@"MobFox Ad Request >>> : %@", [params description]);
    //#endif
    

    
    
}


- (void)renderAd:(NSDictionary *)adDict withCB:(void (^)(id responseData)) cb{
    [self.bridge callHandler:@"renderAd" data:self.adDict responseCallback:cb];
}

-(void) loadCustomEvent{
    
    NSLog(@"-- loadCustomEvent --");
    
    
    if(self.events.count == 0){

        // Display MobFox ad if exists.
            
        __weak id weakself = self;
           
        if([self.adDict objectForKey:@"ad"] || [self.adDict objectForKey:@"vasts"] ) {
            self.hidden = NO;
           
            [self renderAd:self.adDict withCB:^(id responseData) {
                
                MobFoxAd *strongself = weakself;
                if(strongself == nil) return;
                
                [strongself.responseLock lock];
                if(strongself.isResponseTimeout){
                    [strongself.responseLock unlock];
                    return;
                }
                [strongself.responseTimeoutTimer invalidate];
                strongself.responseTimeoutTimer = nil;
                [strongself.responseLock unlock];
                
                if ([strongself.delegate respondsToSelector:@selector(MobFoxAdDidLoad:)]) {
                    [strongself.delegate MobFoxAdDidLoad:strongself];
                }
            }];

        } else {
            
            NSError *err = [NSError errorWithDomain:@"no ad could be found for this request (no fill)" code:0 userInfo:nil];
            
            [self removeTimeout];
            
            if ([self.delegate respondsToSelector:@selector(MobFoxAdDidFailToReceiveAdWithError:)]) {
                [self.delegate MobFoxAdDidFailToReceiveAdWithError:err];
            }
        }
        
        return;
    }
    
    NSString *idfaString = [MFAdvertisingManager identifier];
    
    NSObject* event = (NSObject*)[_events objectAtIndex:0];
    NSRange range = NSMakeRange(1,_events.count-1);
    _events = [_events subarrayWithRange:range];
    

    NSString* className = [event valueForKey:@"class"];
    NSString* networkId = [event valueForKey:@"parameter"];
    customEventPixel = [event valueForKey:@"pixel"];
    
    NSString* fullClassName = [@"MobFoxCustomEvent" stringByAppendingString:className];
    
    id cname = [[NSClassFromString(fullClassName) alloc] init];
    if(cname == nil){
        NSLog(@"MobFox>> Custom Event Class Not Found: %@",fullClassName);
        dispatch_async(dispatch_get_main_queue(), ^{
            [self loadCustomEvent];
        });
        return;
    }
    customEvent = (MobFoxCustomEvent*)cname;
    customEvent.delegate = self;
    
    NSMutableDictionary *customEventInfo = [[NSMutableDictionary alloc] init];
    
    if(self.demo_gender)[customEventInfo setValue:self.demo_gender forKey:@"demo_gender"];
    if(self.demo_age)[customEventInfo setValue:self.demo_age forKey:@"demo_age"];
    
    if(self.locationServicesManager.longitude && self.locationServicesManager.latitude && self.locationServicesManager.accuracy) {
        
        self.longitude = [NSString stringWithFormat:@"%f", self.locationServicesManager.longitude];
        self.latitude = [NSString stringWithFormat:@"%f", self.locationServicesManager.latitude];
        self.accuracy = [NSString stringWithFormat:@"%f", self.locationServicesManager.accuracy];
    }
    
    if(self.longitude) [customEventInfo setValue:self.longitude forKey:@"longitude"];
    if(self.latitude) [customEventInfo setValue:self.latitude forKey:@"latitude"];
    if(self.accuracy)[customEventInfo setValue:self.accuracy forKey:@"accuracy"];
    if(idfaString)[customEventInfo setValue:idfaString forKey:@"o_iosadvid"];
    
    if(self.delegate)[customEventInfo setObject:self.delegate forKey:@"viewcontroller_parent"];

    NSDictionary *customEventInfo_ = [customEventInfo copy];
    [customEvent requestAdWithSize:self.frame.size networkID:networkId customEventInfo:customEventInfo_];
    
    return;
    
}

#pragma mark - UIWebViewDelegate


// banner click detected.
- (BOOL)webView:(UIWebView *)_webView
shouldStartLoadWithRequest:(NSURLRequest *)request
 navigationType:(UIWebViewNavigationType)navigationType{
    
    NSString* url   = [request.URL absoluteString];
    NSString* docURL = [request.mainDocumentURL absoluteString];
    
    //NSLog(@"shouldStartLoadWithRequest -- url:>> %@",url);
    
    // js bridge - let it pass
    NSRange bridgeRange = [url rangeOfString:@"wvjbscheme://"];
    if(bridgeRange.location == 0 ) return YES;
    
    //our domain- let it pass
    NSRange sdkDomain = [url rangeOfString:@"://sdk.starbolt.io"];
    if(sdkDomain.location != NSNotFound) return YES;
   
    if(isAdTouched){
         //legitimate click, hand it over to safari / app store etc.
        if(navigationType == UIWebViewNavigationTypeLinkClicked){
            [[UIApplication sharedApplication] openURL:request.URL];
            if (self.webView.delegate && [self.delegate respondsToSelector:@selector(MobFoxAdClicked)]) {
                [self.delegate MobFoxAdClicked];
            }
            return NO;

        }
        else return YES;
    }
    
    
    //synthetic click - block it
    
    //NSLog(@"url: %@, doc: %@",url,docURL);
    
    if(navigationType== UIWebViewNavigationTypeLinkClicked || ([url isEqualToString:docURL] && navigationType == UIWebViewNavigationTypeOther)) {
        
        if([[[NSProcessInfo processInfo] environment] objectForKey:@"TEST"]) {
            NSError *err = [NSError errorWithDomain:@"auto redirect has been found Code" code:0 userInfo:nil];
            
            [self removeTimeout];
            
            [MFReport reportOnErrorWithFacility:@"Auto Redirect" inventoryHash:self.invh message:@"auto redirect has been found" requestID:_requestID];
            
            double delayInSeconds = 1.0;
            dispatch_time_t popTime = dispatch_time(DISPATCH_TIME_NOW, (int64_t)(delayInSeconds * NSEC_PER_SEC));
            dispatch_after(popTime, dispatch_get_main_queue(), ^(void){
                
                if ([self.delegate respondsToSelector:@selector(MobFoxAdDidFailToReceiveAdWithError:)]) {
                    [self.delegate MobFoxAdDidFailToReceiveAdWithError:err];
                }
            });

            
            return NO;
        }
        
        [MFReport reportOnErrorWithFacility:@"Auto Redirect" inventoryHash:self.invh message:@"auto redirect has been found" requestID:_requestID];
        
        return NO;
    }
    
    //trying to open some app without a user touch! we don't allow this
    
    NSRange itunesRange = [url rangeOfString:@"itunes.apple.com"];
    // trying to open app store web site without a user touch
    if(itunesRange.location != NSNotFound){
        
        [MFReport reportOnErrorWithFacility:@"Auto Redirect" inventoryHash:self.invh message:@"trying to open app store web site without a user touch" requestID:_requestID];
        
        return NO;
    }
  
    NSRange httpRange   = [url rangeOfString:@"http"];
    NSRange protocolRange    = [url rangeOfString:@"://"];
    //not an 'http/https' request but has some protocol --> trying to open an app - block it!
    if(httpRange.location != 0 && protocolRange.location != NSNotFound) {
        
        [MFReport reportOnErrorWithFacility:@"Auto Redirect" inventoryHash:self.invh message:@"not an 'http/https' request but has some protocol" requestID:_requestID];
        
        return NO;
    }
    
    
    return YES;
}

- (void)webViewDidStartLoad:(UIWebView *)webView {
    
    //NSLog(@"-- webViewDidStartLoad --");
}
- (void)webViewDidFinishLoad:(UIWebView *)webView {
    
    //NSLog(@"-- webViewDidFinishLoad --");

}
- (void)webViewdidFailLoadWithError:(NSError *)error{
    
    //NSLog(@"-- webViewdidFailLoadWithError --");

}

#pragma mark - MobFoxCustomEventDelegate

- (void)MFCustomEventAd:(MobFoxCustomEvent *)event didLoad:(UIView *)ad{
    
    //NSLog(@"MFCustomEventAd:didLoad:");
    
    self.hidden = NO;
    customEventView = ad;
    [self addSubview:customEventView];
    

    
    if ([self.delegate respondsToSelector:@selector(MobFoxAdDidLoad:)]) {
        [self.delegate MobFoxAdDidLoad:self];
    }
    
    //NSLog(@"pixel: %@",customEventPixel);
    if(!customEventPixel) return;
    
    //fire tracking pixel
    
    UIWebView* wv = [[UIWebView alloc] initWithFrame:CGRectZero];
    NSString* userAgent = [wv stringByEvaluatingJavaScriptFromString:@"navigator.userAgent"];
    NSURLSessionConfiguration* conf = [NSURLSessionConfiguration defaultSessionConfiguration];
    [conf.HTTPAdditionalHeaders setValue:userAgent forKey:@"User-Agent"];
    NSURLSession* session = [NSURLSession sessionWithConfiguration:conf];
    NSURLSessionDataTask* task = [session dataTaskWithURL:[NSURL URLWithString:customEventPixel] completionHandler:
                                  ^(NSData *data,NSURLResponse *response, NSError *error){
                                      if(error) NSLog(@"MobFox>> err %@",[error description]);
                                  }];
    [task resume];
    
}

- (void)MFCustomEventAdDidFailToReceiveAdWithError:(NSError *)error{
    
    NSLog(@"MFCustomEventAdDidFailToReceiveAdWithError: %@", error);
    
    __weak id weakself = self;
    
    dispatch_async(dispatch_get_main_queue(), ^{
        MobFoxAd *strongself = weakself;
        if(strongself == nil) return;
        [strongself loadCustomEvent];
    });
    return;
    
}

- (void)MFCustomEventAdClosed{
    
    //  [self removeFromSuperview];
    self.hidden = YES;
    if ([self.delegate respondsToSelector:@selector(MobFoxAdClosed)]) {
        [self.delegate MobFoxAdClosed];
    }
}

- (void)MFCustomEventMobFoxAdClicked{
    if ([self.delegate respondsToSelector:@selector(MobFoxAdClicked)]) {
        [self.delegate MobFoxAdClicked];
    }
}

- (void)MFCustomEventMobFoxAdFinished{
    if ([self.delegate respondsToSelector:@selector(MobFoxAdFinished)]) {
        [self.delegate MobFoxAdFinished];
    }
}

- (void)play {
    
    [self.bridge callHandler:@"play"];

}

- (void)pause {
    
    [self.bridge callHandler:@"pause"];

}

- (void)resume {
        
    [self.bridge callHandler:@"resume"];
    
}
/*
- (void)setRefresh:(NSNumber *)refresh {
    
    [self.bridge callHandler:@"refresh" data:refresh];
    
}*/

#pragma mark - UIGestureRecognizerDelegate


-(BOOL)gestureRecognizer:(UIGestureRecognizer *)gestureRecognizer shouldReceiveTouch:(UITouch *)touch
{
    
    isAdTouched = YES;
    return YES;
    
}

-(void)cleanupWebView {
    
    if([self.webView isLoading]){
        [self.webView stopLoading];
    }
    self.webView.delegate = nil;
    
    self.webView.hidden = true;
    [self.bridge setWebViewDelegate:nil];
    self.bridge = nil;
   
    [self.webView removeFromSuperview];
    self.webView = nil;
}


- (void)_changeWidth:(float)newWidth {
    
    self.frame = CGRectMake(self.frame.origin.x, self.frame.origin.y,newWidth ,self.frame.size.height);
    self.webView.frame = CGRectMake(self.frame.origin.x, self.frame.origin.y,newWidth ,self.frame.size.height);
    self.backgroundColor = [UIColor blackColor];
}

-(BOOL)shouldAutorotateToInterfaceOrientation:(UIInterfaceOrientation)interfaceOrientation {
    return NO;
}

- (void)dealloc {
    
    NSLog(@"-- MobFox dealloc --");
    
    [self cleanupWebView];
    [self pause];

}


@end
