//
//  WaterfallsManager.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 6/6/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MFSDKManager.h"
#import "MFReport.h"
#import <WebKit/WebKit.h>
#define WATERFALL_URL @"http://sdk.starbolt.io/waterfalls.json?p="
//#define SDK_URL @"http://10.0.4.59:9998/dist/index.html"

#define SDK_URL @"http://sdk.starbolt.io/dist/index.html"
#define SDK_URL_SECURE @"https://sdk.starbolt.io/dist/index.html"

#define SDK_URL_DEV @"http://sdk.starbolt.io/dev/index.html"
#define SDK_URL_SECURE_DEV @"https://sdk.starbolt.io/dev/index.html"

@interface MFSDKManager()

@end


@implementation MFSDKManager

static BOOL debug;




+ (BOOL)isDebug {
    
    return debug;
}

+ (void)setDebug:(BOOL)value {
    
    debug = value;
    
}

+ (instancetype)sharedInstance {
    
    static MFSDKManager *sharedInstance = nil;
    
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        
        sharedInstance = [[MFSDKManager alloc] init];
        
        //Class cls = [[[WKWebView new] valueForKey:@"browsingContextController"] class];
        //SEL sel = NSSelectorFromString(@"registerSchemeForCustomProtocol:");
        //[(id)cls performSelector:sel withObject:@"http"];
        //[(id)cls performSelector:sel withObject:@"https"];
        
        //NSURLSessionConfiguration *configuration = [NSURLSessionConfiguration defaultSessionConfiguration];
        //configuration.requestCachePolicy = NSURLRequestUseProtocolCachePolicy;
        //sharedInstance.session = [NSURLSession sessionWithConfiguration:configuration];
        //cache = [[NSCache alloc] init];
        //[cache setName:@"waterfall"];
        
    });
    
    return sharedInstance;
    
}



/**
 
 * Loads data for specific URL based on inventory hash, then saves data in cache.
 * @param inventoryHash added to waterfall URL for loading and caching data.
 * @param completion block to execute.
 
 */

- (void)waterfallsWithInventoryHash:(NSString *)inventoryHash completion:(void(^)(NSString *wf))completion {

    NSURL *wfURL = [NSURL URLWithString:[NSString stringWithFormat:@"%@%@", WATERFALL_URL, inventoryHash]];
    
    NSURLRequest *request = [NSURLRequest requestWithURL:wfURL];
    //NSLog(@"waterfalls>> inner waterfall url,%@", wfURL.absoluteString);
    
    [[[NSURLSession sharedSession]
      dataTaskWithRequest:request
      completionHandler:^(NSData *data, NSURLResponse *response, NSError *error) {
    
        //NSLog(@"MobFox wf load time: %f",-[reqStartTime timeIntervalSinceNow]);
        if (error) {
            NSLog(@"MobFox >> waterfalls>> inner waterfall error,%@", [error localizedDescription]);
            return;
        }
        
        NSString *wfString = @"";
        if(data){
            NSDictionary *dataDict = [NSJSONSerialization JSONObjectWithData:data options:NSJSONReadingMutableContainers error:nil];
            
            debug = [[dataDict objectForKey:@"debug"] boolValue];
            
            wfString = [[NSString alloc] initWithData:data encoding:NSUTF8StringEncoding];
        }
        
        if(completion) completion(wfString);
    
    }] resume];

}

- (void)warmUp{
    
    [self getSdk:true withCallback:nil];
    [self getSdk:false withCallback:nil];
    
}

- (NSString*) getSdkUrl:(BOOL) secure {
    
    if(secure){
        return SDK_URL_SECURE_DEV;
    }
    return SDK_URL_DEV;
     
}

- (void)getSdk:(BOOL)secure withCallback:(void(^)(NSString* sdkStr,NSError* error))completion{
    
    //NSLog(@"getSdk:withCallback:");
    
    NSURLRequest *request = [NSURLRequest requestWithURL:[NSURL URLWithString:[self getSdkUrl:secure]]];
    
    //NSLog(@"request.URL: %@", request.URL);
    

    [[[NSURLSession sharedSession] dataTaskWithRequest:request completionHandler:^(NSData *data, NSURLResponse *response, NSError *error){
        
        // NSLog(@"MobFox sdk load time: %f",-[reqStartTime timeIntervalSinceNow]);
        
        if(!completion) return;
        
        if(error){
            completion(nil,error);
            return;
        }
        
        NSString* sdkStr = [[NSString alloc] initWithData:data encoding:NSUTF8StringEncoding];
        completion(sdkStr,nil);
        
    }] resume];
}

@end
