//
//  MFExceptionHandler.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 9/18/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MFExceptionHandler.h"
#import "MFConstants.h"
#import "MobFoxAd.h"

@implementation MFExceptionHandler


+ (instancetype)sharedInstance {
    
    static MFExceptionHandler *sharedInstance = nil;
    
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        
        sharedInstance = [[MFExceptionHandler alloc] init];
        NSSetUncaughtExceptionHandler(&exceptionHandler);
        
    });
    
    return sharedInstance;
    
}

void exceptionHandler(NSException *exception)
{
    NSLog(@"MobFox Error >>> exception: %@",exception);
    [[MFExceptionHandler sharedInstance] saveToFile:exception];
}

- (void)saveToFile:(NSException *)exception {
    
    //NSLog(@"-- report --");

    
    @synchronized (self) {
    
        @try {
            NSString *destPath = [NSSearchPathForDirectoriesInDomains(NSDocumentDirectory, NSUserDomainMask, YES) lastObject];
            destPath = [destPath stringByAppendingPathComponent:@"exception.plist"];
            
            NSMutableDictionary* plistDict = [[NSMutableDictionary alloc] init];
            UIWebView *webView = [[UIWebView alloc]initWithFrame:CGRectZero];
            NSString *userAgent = [webView stringByEvaluatingJavaScriptFromString:@"navigator.userAgent"];
            // NSString *callStackSymbols = [[exception callStackSymbols] componentsJoinedByString:@", "];
            
            [plistDict setValue:@"#crash report#" forKey:@"message"];
            [plistDict setValue:@"MobFox.iOS" forKey:@"host"];
            [plistDict setValue:@"crash" forKey:@"facility"];
            [plistDict setValue:SDK_VERSION forKey:@"sdk_version"];
            
            
            // additional parameters:
            [plistDict setValue:exception.name  forKey:@"exception_name"];
            [plistDict setValue:exception.description forKey:@"exception_description"];
            [plistDict setValue:[exception callStackSymbols] forKey:@"stack_symbols"];
            [plistDict setValue:userAgent forKey:@"user_agent"];
            
            [plistDict writeToFile:destPath atomically: YES];
            NSLog(@"exception error report -- plistDict: %@", plistDict);

            
        } @catch (NSException *exception) {
            NSLog(@"MobFox Error >>> crash report error: %@",exception);
        }
        
    }

}

- (void)reportOnException {
    
    //NSLog(@"-- report --");
    
    @synchronized (self) {
        
        NSFileManager *fileManager = [NSFileManager defaultManager];
        NSString *destPath = [NSSearchPathForDirectoriesInDomains(NSDocumentDirectory, NSUserDomainMask, YES) lastObject];
        destPath = [destPath stringByAppendingPathComponent:@"exception.plist"];
        if(![fileManager fileExistsAtPath:destPath]) {
            
            //NSLog(@"reportOnException -- NO DATA");

            return;
        }
        
        NSMutableDictionary* plistDict_read = [[NSMutableDictionary alloc] initWithContentsOfFile:destPath];
        NSLog(@"MobFox >> exception error report -- plistDict_read: %@", plistDict_read);
        
        NSError *error;
        NSURLSessionConfiguration *configuration = [NSURLSessionConfiguration defaultSessionConfiguration];
        NSURLSession *session = [NSURLSession sessionWithConfiguration:configuration delegate:nil delegateQueue:nil];
        NSURL *url = [NSURL URLWithString:@"http://sdk-logs.matomy.com:12201/gelf"];
        
        NSMutableURLRequest *request = [NSMutableURLRequest requestWithURL:url
                                                               cachePolicy:NSURLRequestReloadIgnoringLocalCacheData
                                                           timeoutInterval:60.0];
        
        [request setValue:@"application/json" forHTTPHeaderField:@"Content-Type"];
        [request setHTTPMethod:@"POST"];
        

        NSData* jsonData = [NSJSONSerialization dataWithJSONObject:plistDict_read options:NSJSONWritingPrettyPrinted error: &error];
        
        [request setHTTPBody:jsonData];
      
        NSString *jsonLength = [NSString stringWithFormat:@"%d", (int)[jsonData length]];
        [request setValue:jsonLength forHTTPHeaderField:@"Content-Length"];
        
        [self cleanContentofFileAtPath:destPath];
        
        NSURLSessionDataTask *postDataTask = [session dataTaskWithRequest:request completionHandler:^(NSData *data, NSURLResponse *response, NSError *error) {
                
            NSLog(@"MobFox >> exception error report -- data: %@", data);
            NSLog(@"MobFox >> exception error report -- response: %@", response);
            NSLog(@"MobFox >> exception error report -- error: %@", error);
                
            if(error != nil) {
                    
                NSLog(@"MobFox Error >>> crash report error: %@",error);
            }
                
        }];
        
            [postDataTask resume];
        }
    
}

- (void)cleanContentofFileAtPath:(NSString *)filePath {
    
    NSError *error;
    NSFileManager *fileManager = [NSFileManager defaultManager];
    [fileManager removeItemAtPath:filePath error:&error];
    
}



@end

