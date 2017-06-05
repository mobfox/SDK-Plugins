//
//  MobFoxInterstitialAd.m
//  MobFoxSDKSource
//
//  Created by Itamar Nabriski on 8/12/15.
//
//

#import <Foundation/Foundation.h>
#include "MobFoxInterstitialAd.h"
#import "MobFoxInterstitialViewController.h"
#import "MFAdvertisingManager.h"

@import AdSupport.ASIdentifierManager;


@interface MobFoxInterstitialAd ()

@property (nonatomic, strong)  MobFoxInterstitialCustomEvent* customEvent;
@property (nonatomic, strong)  NSURLSessionDataTask *task;
@property (nonatomic, strong)  NSDictionary *adDict;
@property (nonatomic, strong)  MobFoxInterstitialViewController *interstitialVC;
@property (nonatomic, strong)  MobFoxAd* ad;
@property (nonatomic, strong) NSString *requestID;



@end

static BOOL locationServicesDisabled;

@implementation MobFoxInterstitialAd{
    
    NSArray* events;
    NSString* customEventPixel;
    NSString* userAgent;
   
}



- (void)setInvh:(NSString*) hash{
    self.ad.invh        = hash;
}

- (void)setAutoplay:(BOOL)autoplay{
    self.ad.autoplay        = autoplay;
}

+ (void)locationServicesDisabled:(BOOL)disabled {
    
    locationServicesDisabled = disabled;
}

- (void)appWillResignActive {
    
    [self dismissAd];
    
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdClosed)]) {
        [self.delegate MobFoxInterstitialAdClosed];
    }
}


-(id) init:(NSString*)invh{
    
    self = [super init];
    
    [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(appWillResignActive) name:UIApplicationWillResignActiveNotification object:nil];
    
    if(!locationServicesDisabled) {
        
        self.locationServicesManager = [MFLocationServicesManager sharedInstance];
        [self.locationServicesManager findLocation];
        
    } else {
        
        if(self.locationServicesManager != nil) {
            [self.locationServicesManager stopFindingLocation];
        }
    }
    
   
   // int w = (int)[UIScreen mainScreen].bounds.size.width;
   // int h = (int)[UIScreen mainScreen].bounds.size.height;
    
    
    self.ad = [[MobFoxAd alloc] init:invh withFrame:CGRectZero];
    self.ad.delegateCustomEvents = YES;
    self.ad.delegate = self;
    self.ad.adFormat = @"interstitial";
    self.ad.skip = YES;
    
    //self.ad = [[MobFoxAd alloc] init:invh withFrame:CGRectMake(0, 0, 1.0, 1.0)];
    
    // add to keyWindow to ensure it is 'active'
    //[UIApplication.sharedApplication.keyWindow addSubview:self.ad];
    
    
    self.delegate = nil;
    self.ready = NO;

    
    events = nil;
    customEventPixel = nil;
    self.rootViewController = nil;
    UIWebView* wv = [[UIWebView alloc] initWithFrame:CGRectZero];
    userAgent = [wv stringByEvaluatingJavaScriptFromString:@"navigator.userAgent"];
    return self;
    
}

-(id) init:(NSString*)invh withRootViewController:(UIViewController*)root {
    
    self = [self init:invh];
    self.rootViewController = root;
    return self;
}

- (void)MobFoxAdDidLoad:(id)banner{
    
    self.ready = YES;
    
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdDidLoad:)]) {
        [self.delegate MobFoxInterstitialAdDidLoad:self];
    }
}


- (void)MobFoxAdDidFailToReceiveAdWithError:(NSError *)error{
    
   //NSLog(@"$$$ MobFox >> error interstitial ad: %@", error);
    
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdDidFailToReceiveAdWithError:)]) {
        [self.delegate MobFoxInterstitialAdDidFailToReceiveAdWithError:error];
    }
}

- (void)MobFoxAdClosed{
    
    [self dismissAd];
    
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdClosed)]) {
        [self.delegate MobFoxInterstitialAdClosed];
    }
}

- (void)MobFoxAdClicked{
    
    //[self dismissAd];
    
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdClicked)]) {
        [self.delegate MobFoxInterstitialAdClicked];
    }
}

- (void)MobFoxAdFinished{
    
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdFinished)]) {
        [self.delegate MobFoxInterstitialAdFinished];
    }
}

- (void)MobFoxDelegateCustomEvents:(NSArray*)evts withAdDict:(NSDictionary *)adDict {
    
    events = evts;
    self.adDict = adDict;

    dispatch_async(dispatch_get_main_queue(), ^{
       [self loadCustomEvent];
    });
    
}

-(void)loadCustomEvent{
    
   // NSLog(@"MobFox >> loadCustomEvent");
    
    if(events.count == 0){
        //NSLog(@"No Custom Events Could Be Processed");
        
    __weak id weakself = self;
        
    if(self.adDict) {
            
            self.ad.hidden = NO;
            
            self.ready = YES;
            
            if ([[self.adDict valueForKey:@"type"] isEqualToString:@"video"]) {
                
                NSURLCache *URLCache = [[NSURLCache alloc] initWithMemoryCapacity:8 * 1024 * 1024 diskCapacity:80 * 1024 * 1024 diskPath:nil];
                [NSURLCache setSharedURLCache:URLCache];
                
                
                NSURL *videoUrl = [self getVideoURLFromDictionary:self.adDict];
                
                if(videoUrl == nil) {
                    
                    NSError *err = [NSError errorWithDomain:@"fetching video content has failed" code:0 userInfo:nil];
                    
                    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdDidFailToReceiveAdWithError:)]) {
                        [self.delegate MobFoxInterstitialAdDidFailToReceiveAdWithError:err];
                    }
                    return;
                    
                } else {
        
                    NSURLSession* session = [NSURLSession sessionWithConfiguration:[NSURLSessionConfiguration defaultSessionConfiguration]];
                    session.configuration.requestCachePolicy = NSURLRequestReturnCacheDataElseLoad;
                    NSURLRequest *urlRequest = [NSURLRequest requestWithURL:videoUrl
                                                              cachePolicy:NSURLRequestReturnCacheDataElseLoad
                                                          timeoutInterval:60.0];
                                        
                    NSURLSessionDataTask *dataTask = [session dataTaskWithRequest:urlRequest completionHandler:^(NSData * _Nullable data, NSURLResponse * _Nullable response, NSError * _Nullable error) {
                        
                        if (error) {
                            
                            NSLog(@"MobFox >> (loading video url) Exception %@", error);
                            
                            if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdDidFailToReceiveAdWithError:)]) {
                                [self.delegate MobFoxInterstitialAdDidFailToReceiveAdWithError:error];
                            }
                            
                            return;
                            
                        }
                        if([self.adDict objectForKey:@"vasts"] ) {

                            [self.ad renderAd:self.adDict withCB:^(id responseData) {
                                
                                MobFoxInterstitialAd *strongself = weakself;
                                if(strongself == nil) return;
                                
                                if ([strongself.delegate respondsToSelector:@selector(MobFoxInterstitialAdDidLoad:)]) {
                                    [strongself.delegate MobFoxInterstitialAdDidLoad:strongself];
                                }
                            }];
                            
                            
                        } else {
                            
                            NSError *err = [NSError errorWithDomain:@"no ad could be found for this request (no fill)" code:0 userInfo:nil];
                            
                            if ([self.delegate respondsToSelector:@selector(MobFoxAdDidFailToReceiveAdWithError:)]) {
                                [self.delegate MobFoxInterstitialAdDidFailToReceiveAdWithError:err];
                            }
                        }
                        
                    }];
                    
                    [dataTask resume];
                    
                    
                }
                
                return;
            }
            
            if([self.adDict objectForKey:@"ad"]) {
                
                
                [self.ad renderAd:self.adDict withCB:^(id responseData) {
                    
                    MobFoxInterstitialAd *strongself = weakself;
                    if(strongself == nil) return;
                    
                    if ([strongself.delegate respondsToSelector:@selector(MobFoxInterstitialAdDidLoad:)]) {
                        [strongself.delegate MobFoxInterstitialAdDidLoad:strongself];
                    }
                }];
                
            } else {
                
                NSError *err = [NSError errorWithDomain:@"no ad could be found for this request (no fill)" code:0 userInfo:nil];
                
                if ([self.delegate respondsToSelector:@selector(MobFoxAdDidFailToReceiveAdWithError:)]) {
                    [self.delegate MobFoxInterstitialAdDidFailToReceiveAdWithError:err];
                }
            }
            
        }
        return;
    }
    
   // NSString *idfaString = [MFAdvertisingManager identifier];

    NSObject* event = (NSObject*)[events objectAtIndex:0];
    NSRange range = NSMakeRange(1,events.count-1);
    events = [events subarrayWithRange:range];
    
    NSString* className = [event valueForKey:@"class"];
    NSString* networkId = [event valueForKey:@"parameter"];
    customEventPixel = [event valueForKey:@"pixel"];
    NSString* fullClassName = [@"MobFoxInterstitialCustomEvent" stringByAppendingString:className];
    
    id cname = [[NSClassFromString(fullClassName) alloc] init];
    if(cname == nil){
        NSLog(@"MobFox >> Custom Event Class Not Found: %@",fullClassName);
        dispatch_async(dispatch_get_main_queue(), ^{
            [self loadCustomEvent];
        });
        return;
    }
    self.customEvent = (MobFoxInterstitialCustomEvent*)cname;
    self.customEvent.delegate = self;
    
    NSMutableDictionary *customEventInfo = [[NSMutableDictionary alloc] init];
    
    if(self.demo_gender)[customEventInfo setValue:self.demo_gender forKey:@"demo_gender"];
    if(self.demo_age)[customEventInfo setValue:self.demo_age forKey:@"demo_age"];
    
    
        
        
    if(self.ad.locationServicesManager.longitude && self.ad.locationServicesManager.latitude && self.ad.locationServicesManager.accuracy) {
        
        self.ad.longitude = [NSString stringWithFormat:@"%f", self.ad.locationServicesManager.longitude];
        self.ad.latitude = [NSString stringWithFormat:@"%f", self.ad.locationServicesManager.latitude];
        self.ad.accuracy = [NSString stringWithFormat:@"%f", self.ad.locationServicesManager.accuracy];
    }
    
    if(self.ad.longitude) [customEventInfo setValue:self.ad.longitude forKey:@"longitude"];
    if(self.ad.latitude) [customEventInfo setValue:self.ad.latitude forKey:@"latitude"];
    if(self.ad.accuracy)[customEventInfo setValue:self.ad.accuracy forKey:@"accuracy"];
   
    if(self.ad.adspace_width)[customEventInfo setValue:self.ad.adspace_width forKey:@"adspace_width"];
    if(self.ad.adspace_height)[customEventInfo setValue:self.ad.adspace_height forKey:@"adspace_height"];

     if(self.delegate)[customEventInfo setObject:self.delegate forKey:@"viewcontroller_parent"];
    NSDictionary *customEventInfo_ = [customEventInfo copy];
    [self.customEvent requestInterstitialWithNetworkId:networkId customEventInfo:customEventInfo_];
    NSLog(@"MobFox >> Called on custom event!");

    
}

-(void) loadAd {
    
    self.ready = NO;
    self.ad.autoplay = YES;
    
    
    UIInterfaceOrientation interfaceOrientation = [[UIApplication sharedApplication] statusBarOrientation];
    
    CGSize size;
    if([UIDevice currentDevice].userInterfaceIdiom == UIUserInterfaceIdiomPhone){
        if (UIInterfaceOrientationIsPortrait(interfaceOrientation)) {
            size.width= 320.0;
            size.height= 480.0;
        }
        else{
            size.width= 480.0;
            size.height= 320.0;
        }
    } else {
        // Ad size supported for iPad: 1024x768, 768x1024, 1024x748, 768x1004
        if (UIInterfaceOrientationIsPortrait(interfaceOrientation)) {
            size.width= 768.0;
            size.height= 1024.0;
        }
        else {
            size.width= 1024.0;
            size.height= 768.0;
        }
    }
 
    
    [self.ad _setSize:size withContainer:CGSizeMake([UIScreen mainScreen].bounds.size.width, [UIScreen mainScreen].bounds.size.height)];
    if(self.demo_gender)    self.ad.demo_gender = self.demo_gender;
    if(self.demo_age)       self.ad.demo_age = self.demo_age;
    if(self.s_subid)        self.ad.s_subid = self.s_subid;
    if(self.sub_name)       self.ad.sub_name = self.sub_name;
    if(self.sub_domain)     self.ad.sub_domain= self.sub_domain;
    if(self.sub_storeurl)   self.ad.sub_storeurl= self.sub_storeurl;
    if(self.r_floor)        self.ad.r_floor= self.r_floor;
    if(self.v_dur_min)      self.ad.v_dur_min= self.v_dur_min;
    if(self.v_dur_max)      self.ad.v_dur_max = self.v_dur_max;
    [self.ad loadAd];
   
    
}

-(void) show {
    
    NSLog(@"MobFox >> show");
    
    [self.ad resume];
    
    if(!self.rootViewController){
        NSLog(@"MobFox >> Interstitial >> cannot show as root uicontroller was not provided.");
        return;
    }
    
    if(!self.ready){
        NSLog(@"MobFox >> Interstitial >> not ready.");
        return;
    }
    
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdWillShow:)]) {
        [self.delegate MobFoxInterstitialAdWillShow:self];
    }
    
    if(self.customEvent){
        NSLog(@"MobFox impression pixel: %@",customEventPixel);
        [self.customEvent presentWithRootController:self.rootViewController];
        if(!customEventPixel) return;
        
        //fire tracking pixel
        NSURLSessionConfiguration* conf = [NSURLSessionConfiguration defaultSessionConfiguration];
        [conf.HTTPAdditionalHeaders setValue:userAgent forKey:@"User-Agent"];
        NSURLSession* session = [NSURLSession sessionWithConfiguration:conf];
        self.task = [session dataTaskWithURL:[NSURL URLWithString:customEventPixel] completionHandler:
                     ^(NSData *data,NSURLResponse *response, NSError *error){
                         if(error) NSLog(@"MobFox >> err %@",[error description]);
                     }];
        [self.task resume];
    }
    else {
        
        dispatch_async(dispatch_get_main_queue(), ^{
            self.interstitialVC = [[MobFoxInterstitialViewController alloc] init];
            self.interstitialVC.modalPresentationCapturesStatusBarAppearance = YES;
            self.interstitialVC.modalPresentationStyle = UIModalPresentationOverFullScreen;
            
            
            [self.rootViewController presentViewController:self.interstitialVC animated:TRUE completion:^(){
                
                
                int w = (int)[UIScreen mainScreen].bounds.size.width;
                int h = (int)[UIScreen mainScreen].bounds.size.height;
                
                [self.ad _setFrame:CGRectMake(0,0,w,h)];
                [self.ad removeFromSuperview];
                [self.interstitialVC.view addSubview:self.ad];
           
            }];
        });
       
    }
    
}

- (void)MFInterstitialCustomEventAdDidLoad:(MobFoxInterstitialCustomEvent *)event{
    
    self.ready = YES;

    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdDidLoad:)]) {
        [self.delegate MobFoxInterstitialAdDidLoad:self];
    }
}

- (void)MFInterstitialCustomEventAdDidFailToReceiveAdWithError:(NSError *)error {
    
    dispatch_async(dispatch_get_main_queue(), ^{
        [self loadCustomEvent];
    });
}

- (void)MFInterstitialCustomEventAdClosed{
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdClosed)]) {
        [self.delegate MobFoxInterstitialAdClosed];
    }
}

- (void)MFInterstitialCustomEventMobFoxAdClicked{
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdClicked)]) {
        [self.delegate MobFoxInterstitialAdClicked];
    }
}

- (void)MFInterstitialCustomEventMobFoxAdFinished{
    if ([self.delegate respondsToSelector:@selector(MobFoxInterstitialAdFinished)]) {
        [self.delegate MobFoxInterstitialAdFinished];
    }
}

- (NSURL *)getVideoURLFromDictionary:(id)dict {
    
    NSURL *videoUrl;
    NSString *mp4_url;
    NSMutableDictionary *dict_i;
    dict_i = [[NSMutableDictionary alloc] init];
    dict_i = dict;
    
    @try {
        NSMutableArray *array = [[dict_i objectForKey:@"vasts"] mutableCopy];
        
        NSMutableDictionary *dict_lastObject = [[NSMutableDictionary alloc] init];
        dict_lastObject = [array lastObject];
        
        NSMutableDictionary *dict_VAST = [[NSMutableDictionary alloc] init];
        dict_VAST = [[dict_lastObject objectForKey:@"VAST"] mutableCopy];
        
        NSMutableDictionary *dict_Ad = [[NSMutableDictionary alloc] init];
        dict_Ad = [[dict_VAST objectForKey:@"Ad"] mutableCopy];
        
        NSMutableDictionary *dict_InLine = [[NSMutableDictionary alloc] init];
        dict_InLine = [[dict_Ad objectForKey:@"InLine"] mutableCopy];
        
        NSMutableDictionary *dict_Creatives = [[NSMutableDictionary alloc] init];
        dict_Creatives = [[dict_InLine objectForKey:@"Creatives"] mutableCopy];
        
        NSMutableDictionary *dict_Creative = [[NSMutableDictionary alloc] init];
        dict_Creative = [[dict_Creatives objectForKey:@"Creative"] mutableCopy];
        
        NSMutableDictionary *dict_Linear = [[NSMutableDictionary alloc] init];
        dict_Linear = [[dict_Creative objectForKey:@"Linear"] mutableCopy];
        
        NSMutableDictionary *dict_MediaFiles = [[NSMutableDictionary alloc] init];
        dict_MediaFiles = [[dict_Linear objectForKey:@"MediaFiles"] mutableCopy];
       
        NSMutableDictionary *dict_MediaFile = [[NSMutableDictionary alloc] init];
        dict_MediaFile = [[dict_MediaFiles objectForKey:@"MediaFile"] mutableCopy];
       
        
        mp4_url = [dict_MediaFile objectForKey:@"__cdata"];
        videoUrl = [NSURL URLWithString:mp4_url];
        
        
    } @catch (NSException *exception) {
        NSLog(@"MobFox >> SDK exception: %@", exception.description);
        
    } @finally {
        
    }
    
    return videoUrl;
    
    
}

// NSURLSessionDataDelegate Protocol Reference
- (void)URLSession:(NSURLSession *)session dataTask:(NSURLSessionDataTask *)dataTask willCacheResponse:(NSCachedURLResponse *)proposedResponse completionHandler:(void (^)(NSCachedURLResponse * _Nullable))completionHandler {
    
    //NSLog(@"URLSession:dataTask:willCacheResponse:completionHandler");

}

- (void)dismissAd {
    
    self.ready = false;
    
    if ([NSStringFromClass([[self.rootViewController presentedViewController] class]) isEqualToString:@"MobFoxInterstitialViewController"]) {
        

        [self.ad pause];
        [self.ad removeFromSuperview];
        [self.ad _setFrame:CGRectZero];
            
        
        [self.rootViewController dismissViewControllerAnimated:YES completion:nil];
    }
}

- (void)dealloc {

    [[NSNotificationCenter defaultCenter] removeObserver:self name:UIApplicationWillResignActiveNotification object:nil];


    [self.ad removeFromSuperview];
    self.ad.delegate = nil;
    self.ad = nil;

    
    self.rootViewController = nil;
    self.delegate = nil;
    self.task = nil;

}


@end
