//
//  MobFoxNativeRequest.m
//  MobFoxSDKCore
//
//  Created by Itamar Nabriski on 9/29/15.
//  Copyright © 2015 Itamar Nabriski. All rights reserved.
//

@import AdSupport.ASIdentifierManager;
#include <ifaddrs.h>
#include <arpa/inet.h>
#import "MobFoxNativeAd.h"
#import "MFConstants.h"
#import "MFDeviceExtention.h"
#import "MFLocationServicesManager.h"
#import "MFAdvertisingManager.h"

#define SERVER_URL @"http://my.mobfox.com/request.php"



@interface MobFoxNativeAd()
@property (nonatomic, copy) NSString* userAgent;
@property (nonatomic, strong) MobFoxNativeCustomEvent* customEvent;
@property (nonatomic, strong) MFLocationServicesManager *locationServicesManager;
@property (nonatomic, strong) NSArray* events;


@end

@implementation MobFoxNativeAd
{
    BOOL errorState;
    //NSMutableArray* events;
    NSString* customEventPixel;
    NSException *exception;
}

static BOOL locationServicesDisabled;

+ (void)locationServicesDisabled:(BOOL)disabled {
    
    locationServicesDisabled = disabled;
}

- (id) init:(NSString*)invh {
    
    id notificationObserver_didBecomeActive;
    notificationObserver_didBecomeActive = [[NSNotificationCenter defaultCenter] addObserverForName:UIApplicationDidBecomeActiveNotification object:nil queue:[NSOperationQueue mainQueue] usingBlock:^(NSNotification *note) {
        
        [[MFExceptionHandler sharedInstance] reportOnException];
        
    }];
    
    /*
    [MFExceptionHandler sharedInstance];
    
    NSException* myException = [NSException
                                exceptionWithName:@"FileNotFoundException"
                                reason:@"File Not Found on System"
                                userInfo:nil];
    @throw myException;
    */

    if(!locationServicesDisabled) {
        
        self.locationServicesManager = [MFLocationServicesManager sharedInstance];
        [self.locationServicesManager findLocation];
        
    } else {
        
        if(self.locationServicesManager != nil) {
            [self.locationServicesManager stopFindingLocation];
        }
    }
 
    self = [super init];
    self.invh = invh;
    self.events = nil;
    errorState = false;
    exception = nil;
    UIWebView *webView = [[UIWebView alloc]initWithFrame:CGRectZero];
    self.userAgent = [webView stringByEvaluatingJavaScriptFromString:@"navigator.userAgent"];
    
    
    //NSLog(@"user agent: %@", self.userAgent);
        
   
    return self;
}


- (void) registerViewWithInteraction:(UIView *)view withViewController:(UIViewController *)viewController {
    
    //NSLog(@"registerViewWithInteraction:withViewController:");
    
    if (self.customEvent) {
        
        [self.customEvent registerViewWithInteraction:view withViewController:viewController];
    }

}

- (void) loadAd{
    
    //NSLog(@"MobFoxNativeAd --- loadAd");
  
    @try {
        [self _loadAd];
    }
    @catch (NSException *_exception) {
        NSLog(@"MobFox SDK (MobFoxNativeAd - loadAd) Exception: %@", _exception.reason);
        
        NSError *err;
        err = [NSError errorWithDomain:@"load ad has failed" code:0 userInfo:nil];
        
        if ([self.delegate respondsToSelector:@selector(MobFoxNativeAdDidFailToReceiveAdWithError:)]) {
            [self.delegate MobFoxNativeAdDidFailToReceiveAdWithError:err];
        }
        
    }
    @finally {
        // ..
    }
    
}

- (void) _loadAd {
    
    //NSString* rt = [UIDevice isIpad] ? @"ipad_app" : @"iphone_app";
    NSString* rt = [MFDeviceExtention isIpad] ? @"ipad_app" : @"iphone_app";
    NSString *idfaString = [MFAdvertisingManager identifier];
    NSString* customEventVal = @"1";
    
    NSString *url = self.serverURL ? self.serverURL : SERVER_URL;
    
    NSURLComponents *components = [NSURLComponents componentsWithString:url];
    
    if(self.locationServicesManager.longitude && self.locationServicesManager.latitude) {
        
        self.longitude = [NSString stringWithFormat:@"%f", self.locationServicesManager.longitude];
        self.latitude = [NSString stringWithFormat:@"%f", self.locationServicesManager.latitude];
    }
    
    NSMutableDictionary *queryDictionary = [NSMutableDictionary dictionaryWithObjectsAndKeys:
                                            
                                     #ifdef DEBUG
                                     @"test",@"m",
                                     #endif
                                            
                                     [NSNumber numberWithBool:TRUE],@"n_img_icon_req",
                                     @"80",@"n_img_icon_size",
                                     [NSNumber numberWithBool:0],@"n_img_large_req",
                                     [NSNumber numberWithInt:1200],@"n_img_large_w",
                                     [NSNumber numberWithInt:627],@"n_img_large_h",
                                     [NSNumber numberWithBool:0],@"n_title_req",
                                     @"25",@"n_title_len",
                                     [NSNumber numberWithBool:0],@"n_desc_req",
                                     @"140",@"n_desc_len",
                                     [NSNumber numberWithBool:0],@"n_rating_req",
 
                                     //self.i_ipaddress,@"i"
                                     @"content",@"n_context",
                                     @"atomic",@"n_plcmttype",
                                     self.invh,@"s",
                                     [NSString stringWithFormat:@"%@_%@", SDK_VERSION, @"static_core"],@"v",
                                     self.userAgent,@"u",
                                     @"1.1",@"n_ver",
                                     rt,@"rt",
                                     @"native",@"r_type",
                                     @"json",@"r_resp",
                                     /*@"icon",@"n_img",*/
                                     /*@"headline,description,cta,advertiser,rating",@"n_txt",*/
                                     idfaString,@"o_iosadvid",
                                     customEventVal,@"c_customevents",
                                     [[NSBundle mainBundle] bundleIdentifier],@"sub_bundle_id",
                                     self.longitude,@"longitude",
                                     self.latitude,@"latitude",
                                     self.demo_gender,@"demo_gender",
                                     self.demo_age,@"demo_age",
                                     self.s_subid,@"s_subid",
                                     self.sub_name,@"sub_name",
                                     self.sub_domain,@"sub_domain",
                                     self.sub_storeurl,@"sub_storeurl",
                                     self.v_dur_min,@"v_dur_min",
                                     self.v_dur_max,@"v_dur_max",
                                     self.r_floor,@"r_floor",
                                     nil
                                     ];
    
    
    NSMutableArray *queryItems = [NSMutableArray array];
    for (NSString *key in queryDictionary) {
        
        [queryItems addObject:[NSURLQueryItem queryItemWithName:[NSString stringWithFormat:@"%@",key] value:[NSString stringWithFormat:@"%@",queryDictionary[key]] ]];
        
    }
    

    components.queryItems = queryItems;
    NSURL *req = components.URL;
    NSLog(@"MobFox>> native ad request: %@", req);
    
    NSURLSessionConfiguration* conf = [NSURLSessionConfiguration defaultSessionConfiguration];
    conf.HTTPAdditionalHeaders = @{
                                        @"User-Agent" : self.userAgent,
                                   };
    
    NSURLSession* session = [NSURLSession sessionWithConfiguration:conf];
    
    // MARK: for testing custom events.
    /*
     NSDictionary *dict = [[NSDictionary alloc] initWithObjectsAndKeys:@"Millennial", @"class", @"203891", @"parameter", nil];
     
     events = [[NSMutableArray alloc] init];
     [events addObject:dict];
     */

    
    NSURLSessionDataTask* task = [session dataTaskWithURL:req completionHandler:
                                  ^(NSData *data,NSURLResponse *response, NSError *error){
                
                                      
                                      // update model objects on main thread
                                      // also update UI on main thread
                                      dispatch_async(dispatch_get_main_queue(), ^{
                                          
                                          NSHTTPURLResponse* resp = (NSHTTPURLResponse*)response;
                                          NSDictionary * headers = resp.allHeaderFields;
                                          NSString* prefix = @"X-CustomEvent";
                                          NSArray* names = headers.allKeys;
                                          //NSLog(@"headers: %@",[names description]);
                                          NSMutableArray* customEvents = [NSMutableArray array];
                                          for(NSString* n in names){
                                              if([n rangeOfString:prefix].location !=0) continue;
                                              
                                              NSData *data = [[headers valueForKey:n] dataUsingEncoding:NSUTF8StringEncoding];
                                              
                                              NSDictionary* evt = [NSJSONSerialization JSONObjectWithData:data options:0 error:nil];
                                              [customEvents addObject:evt];
                                          }
                                          
                                           self.events = customEvents;
                      
                                           if(self.events && self.events.count > 0){
                                              
                                              [self loadCustomEvent];
                                              return;
                                              
                                          }
                                          
                                          if(!data){

                                              NSError* err = [[NSError alloc] initWithDomain:@"MobFoxNativeAd" code:20001 userInfo:nil];
                                              NSLog(@"MobFox>> native ad error: %@", err.description);

                                              [self.delegate MobFoxNativeAdDidFailToReceiveAdWithError:err];
                                              return;
                                          };
                                          
                                          NSError *localError = nil;
                                          NSDictionary *parsedObject = [NSJSONSerialization JSONObjectWithData:data options:0 error:&localError];
                                          
                                          if(localError){
                                              
                                              // error 
                                              NSError *err = [NSError errorWithDomain:@"no ad has been return (no fill)" code:0 userInfo:nil];

                                              NSLog(@"MobFox>> native ad error: %@", localError);
                                              [self.delegate MobFoxNativeAdDidFailToReceiveAdWithError:err];
                                              return;
                                          }
                                          
                                          NSLog(@"MobFox>> native adv response: %@", parsedObject);
                                          MobFoxNativeData *mobFoxNativeData = [[MobFoxNativeData alloc] initWithDictionary:parsedObject];
                                          
                                          NSLog(@"MobFox>> native ad mobFoxNativeData.assetHeadline: %@", mobFoxNativeData.assetHeadline);
                                          NSLog(@"MobFox>> native ad mobFoxNativeData.assetDescription: %@", mobFoxNativeData.assetDescription);
                                          
                                          [self.delegate MobFoxNativeAdDidLoad:self withAdData:mobFoxNativeData];
                                          
                                      });
                                  }];
    [task resume];

        
}

-(void) loadCustomEvent{
    
    if(_events.count == 0){
        NSLog(@"MobFox>> No Custom Events Could Be Processed");
        return;
    }
    
    // FIXME: event is nil after assignment. please resolve.
    NSObject* event = (NSObject*)[_events objectAtIndex:0];
    NSRange range = NSMakeRange(1,_events.count-1);
    _events = [_events subarrayWithRange:range];
    
    NSString* className = (NSString*)[event valueForKey:@"class"];
    // Added for checking admob custom event.
    //NSString* className = @"AdMob";
    //NSString* networkId = nil;
    //customEventPixel = nil;
    NSString* networkId = [event valueForKey:@"parameter"];
    customEventPixel = [event valueForKey:@"pixel"];
    NSString* fullClassName = [@"MobFoxNativeCustomEvent" stringByAppendingString:className];
    
    id cname = [[NSClassFromString(fullClassName) alloc] init];
    if(cname == nil){
        NSLog(@"MobFox>> Custom Event Class Not Found: %@",fullClassName);
        self.customEvent = nil;
        [self loadCustomEvent];
        
        return;
    }
    self.customEvent = (MobFoxNativeCustomEvent*)cname;
    self.customEvent.delegate = self;
    
    //NSDictionary *customEventInfo = [[NSDictionary alloc] init];
    
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
    
    if(self.delegate)[customEventInfo setObject:self.delegate forKey:@"viewcontroller_parent"];

    
    [self.customEvent requestAdWithNetworkID:networkId customEventInfo:customEventInfo];
}


- (void)MFNativeCustomEventAd:(MobFoxNativeCustomEvent *)event didLoad:(MobFoxNativeData *)adData {
    
    if (customEventPixel) {
        
        if(adData == nil) {
            adData = [[MobFoxNativeData alloc] init];
        }
        
        MobFoxNativeTracker *nativeTracker = [[MobFoxNativeTracker alloc] initWithURL:[NSURL URLWithString:customEventPixel] type:@"impression"];
        
        if (adData.trackersArray == nil) {
            adData.trackersArray = [[NSMutableArray alloc] init];
        }
        [adData.trackersArray addObject:nativeTracker];
    }
    
    //NSLog(@"native data adData: %@", adData);
   
    [self.delegate MobFoxNativeAdDidLoad:self withAdData:adData];
    
}

- (void)MFNativeCustomEventAdDidFailToReceiveAdWithError:(NSError *)error{
    if(_events.count >0){
        [self loadCustomEvent];
        return;
    };
    
    if ([self.delegate respondsToSelector:@selector(MobFoxNativeAdDidFailToReceiveAdWithError:)]) {
        [self.delegate MobFoxNativeAdDidFailToReceiveAdWithError:error];
    }
}

- (void)dealloc {
    
    [[NSNotificationCenter defaultCenter] removeObserver:self name:UIApplicationDidBecomeActiveNotification object:nil];

    self.delegate = nil;
}

@end
