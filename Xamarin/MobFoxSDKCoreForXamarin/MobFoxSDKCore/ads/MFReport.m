//
//  MFLog.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 12/8/16.
//  Copyright © 2016 Matomy Media Group Ltd. All rights reserved.
//

#import "MFReport.h"
#import "MFConstants.h"
#import "MFSDKManager.h"
#import "MFAdvertisingManager.h"


@implementation MFReport : NSObject



+ (void)log:(NSString*)facility withInventoryHash:(NSString*)hash andWithMessage:(NSString*)message requestID:(NSString*)requestID {
    
    //NSLog(@"-- report --");
    
    if(![MFSDKManager isDebug]) {
        return;
    }
    
    [self reportOnErrorWithFacility:facility inventoryHash:hash message:message requestID:requestID];
        
}

+ (void)reportOnErrorWithFacility:(NSString *)facility inventoryHash:(NSString*)hash message:(NSString*)message requestID:(NSString*)requestID {
    
    //NSLog(@"-- report --");

    
    UIWebView *wv = [[UIWebView alloc] initWithFrame:CGRectZero];
    NSString *userAgent = [wv stringByEvaluatingJavaScriptFromString:@"navigator.userAgent"];
    NSString *idfa = [MFAdvertisingManager identifier];
    
    NSMutableDictionary* reportDict = [[NSMutableDictionary alloc] init];
    [reportDict setObject:userAgent forKey:@"UserAgent"];
    [reportDict setObject:idfa forKey:@"IDFA"];
    [reportDict setObject:message forKey:@"message"];
    if(requestID)[reportDict setObject:requestID forKey:@"requestID"];
    
    [reportDict setValue:@"MobFox.iOS" forKey:@"host"];
    [reportDict setValue:facility forKey:@"facility"];
    [reportDict setValue:SDK_VERSION forKey:@"sdk_version"];
    [reportDict setValue:hash forKey:@"invh"];
    NSLog(@"hash: %@", hash);
    
    NSError *error;
    NSURLSessionConfiguration *configuration = [NSURLSessionConfiguration defaultSessionConfiguration];
    NSURLSession *session = [NSURLSession sessionWithConfiguration:configuration delegate:nil delegateQueue:nil];
    NSURL *url = [NSURL URLWithString:@"http://sdk-logs.matomy.com:12201/gelf"];
    
    NSMutableURLRequest *request = [NSMutableURLRequest requestWithURL:url
                                                           cachePolicy:NSURLRequestReloadIgnoringLocalCacheData
                                                       timeoutInterval:60.0];
    
    [request setValue:@"application/json" forHTTPHeaderField:@"Content-Type"];
    [request setHTTPMethod:@"POST"];
    
    NSData* jsonData = [NSJSONSerialization dataWithJSONObject:reportDict options:NSJSONWritingPrettyPrinted error: &error];
    
    [request setHTTPBody:jsonData];
    
    NSString *jsonLength = [NSString stringWithFormat:@"%d", (int)[jsonData length]];
    [request setValue:jsonLength forHTTPHeaderField:@"Content-Length"];
    
    // TODO: URLConnection.
    
    NSURL *url_c = [NSURL URLWithString:[NSString stringWithFormat:@"http://sdk-logs.matomy.com:12201/gelf"]];
    NSMutableURLRequest *request_c = [[NSMutableURLRequest alloc] initWithURL:url_c];
    NSOperationQueue *queue_c = [[NSOperationQueue alloc] init];
    
    [NSURLConnection sendAsynchronousRequest:request_c queue:queue_c completionHandler:^(NSURLResponse * _Nullable response, NSData * _Nullable data, NSError * _Nullable connectionError) {
        
        NSLog(@"MobFox REPORT !! >>> data report");
        
        if(error != nil) {
            
            NSLog(@"MobFox Error >>> data report error: %@",error);
        }
    }];
    
    
}

- (void)connection:(NSURLConnection *)connection didReceiveResponse:(NSURLResponse *)response {
    
    NSLog(@"connection:didReceiveResponse:");

}

- (void)connection:(NSURLConnection *)connection didReceiveData:(NSData *)data {
    // Append the new data to the instance variable you declared
    
    NSLog(@"connection:didReceiveData:");


}

@end
