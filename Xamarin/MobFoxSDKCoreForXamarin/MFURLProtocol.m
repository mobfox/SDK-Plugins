//
//  MFURLProtocol.m
//  DemoApp
//
//  Created by Itamar Nabriski on 16/01/2017.
//  Copyright © 2017 Matomy Media Group Ltd. All rights reserved.
//


#import "MFURLProtocol.h"
#import "TestsDefines.h"


#define METHOD_1_1 @"testNativeAdNewAPI_VER_1_1"
#define METHOD_1_2 @"testNativeAdNewAPI_VER_1_2"


@implementation MFURLProtocol
static int requestCount;
static NSMutableArray *urlsArray;


+ (void)setURLsArray:(NSMutableArray *)value {
    urlsArray = value;
}

+ (NSMutableArray *)urlsArray {
    return urlsArray;
}

+ (BOOL)canInitWithRequest:(NSURLRequest *)request {
    
    NSLog(@"canInitWithRequest -- Request #%lu: URL = %@", (unsigned long)requestCount++, request.URL);
    
    return YES;
}

+ (NSURLRequest *)canonicalRequestForRequest:(NSURLRequest *)request {
    
    NSLog(@"canonicalRequestForRequest:");
    return request;
}

+ (BOOL)requestIsCacheEquivalent:(NSURLRequest *)a toRequest:(NSURLRequest *)b {
    
    NSLog(@"requestIsCacheEquivalent:toRequest:");
    
    return NO;
    //return [super requestIsCacheEquivalent:a toRequest:b];
}

- (void) sendFile:(NSURL*)url{
    
    //NSLog(@"URL>: %@",url.absoluteString);
    
    // TODO: check for publisher id also.
    if([[url absoluteString] hasPrefix:MFURLs.GrayLog]) {
        
        [TestsDefines setGrayLogRequestReceived:true];
        NSLog(@"GRAT LOG RECEIVED!!");
        return;
    }
    
    
    NSString *fileName;
    if([[url absoluteString] hasPrefix:MFURLs.Index] || [[url absoluteString] hasPrefix:MFURLs.SecuredIndex])
    {
        fileName = @"index.html";
        
    } else if([[url absoluteString] hasPrefix:MFURLs.Index_dev] || [[url absoluteString] hasPrefix:MFURLs.SecuredIndex_dev]) {
    
            fileName = @"index_dev.html";
        
    } else if([[url absoluteString] hasPrefix:MFURLs.AdJS] || [[url absoluteString] hasPrefix:MFURLs.SecuredAdJS]) {
        
        fileName = @"sdk_video.js";
        
    } else if([[url absoluteString] hasPrefix:MFURLs.AdJS_dev] || [[url absoluteString] hasPrefix:MFURLs.SecuredAdJS_dev]) {
        
        fileName = @"sdk_video_dev.js";

    } else if([[url absoluteString] hasPrefix:MFURLs.Waterfall]) {
        
        fileName = @"waterfalls.json";
        
    } else if ([[url absoluteString] hasPrefix:MFURLs.Impression]) {
        
        fileName = @"empty_response.xml";
        
    } else if ([[url absoluteString] hasPrefix:MFURLs.Creative] || [[url absoluteString] hasPrefix:MFURLs.SecuredCreative]) {
        
        fileName = @"empty_response.xml";
        
    } else if ([[url absoluteString] hasPrefix:MFURLs.HqMy] || [[url absoluteString] hasPrefix:MFURLs.SecuredHqMy]) {
            
        fileName = @"empty_response.xml";
    
    } else if ([[url absoluteString] hasPrefix:MFURLs.Exchange]) {
        
        fileName = @"empty_response.xml";
        
    } else if ([[url absoluteString] hasPrefix:MFURLs.TokyoMy]) {
            
        fileName = @"empty_response.xml";
        
    } else if ([[url absoluteString] hasPrefix:MFURLs.Adrta]) {
            
        fileName = @"empty_response.xml";
        
    } else if ([[url absoluteString] hasPrefix:MFURLs.Store]) {
        
        fileName = @"empty_response.xml";
        
    } else if ([[url absoluteString] hasPrefix:MFURLs.Redirect]) {
        
        fileName = @"empty_response.xml";
        
    } else if([[url absoluteString] hasPrefix:MFURLs.Request] || [[url absoluteString] hasPrefix:MFURLs.SecuredRequest]) {
        
        NSLog(@"-- request.php --");
        
        if (urlsArray == nil) {
            urlsArray  = [[NSMutableArray alloc] init];
        }
        
        NSLog(@"URL>: %@",url.absoluteString);

        [urlsArray addObject:url];
        
        
        
        if([TestsDefines isNoResponse]) {
            return;
            
        } else if([TestsDefines isRenderingTimeout]) {
            
            fileName = @"rendering_timeout_response.xml";
            
        } else if([TestsDefines isAutoRedirect]) {
            
            fileName = @"banner_redirect.xml";
            
        } else if([TestsDefines isAutoRedirect2]) {
        
            fileName = @"banner_redirect2.xml";
            
        } else if([TestsDefines isStoreAutoRedirect]) {
            
            fileName = @"banner_store_redirect.xml";
            
        } else if ([TestsDefines isNoAdResponse]) {
            
            fileName = @"no_ad_response.xml";
        
        } else if ([TestsDefines isEmptyDataResponse]) {
        
            fileName = @"empty_response.xml";
            
        } else if([TestsDefines isNoCustomEventsResponse]) {
            
            fileName = @"no_customEvents_response.xml";

        }
    
        /* regular ads responses */
        
        else if ([[url absoluteString] rangeOfString:@"imp_instl=1"].location == NSNotFound) {
            
            fileName = @"banner_response.xml";

        } else {
            
            fileName = @"interstitial_response.xml";
            
        }
        
    }
    
    NSLog(@"fileName: %@", fileName);
    
    if (fileName == nil || !fileName.length) {
        return;
    }
    
    NSString* name  = [fileName componentsSeparatedByString:@"."][0];
    NSString* ext   = [fileName componentsSeparatedByString:@"."][1];
    
    
    NSString* path = [[NSBundle bundleForClass:[self class]] pathForResource:name ofType:ext];
    //NSLog(@"name: %@, path: %@",name,path);
    NSString* contents = [NSString stringWithContentsOfFile:path
                                                   encoding:NSUTF8StringEncoding
                                                      error:NULL];
    
    // NSLog(@"$contents: %@",contents);
    
    NSData* data;
    if(contents != nil) {
        data = [contents dataUsingEncoding:NSUTF8StringEncoding];
    }
    
    
    NSDictionary *extToMime =[[NSDictionary alloc] initWithObjectsAndKeys:
                              @"text/xml;charset=utf-8",@"xml",
                              @"application/json",@"json",
                              @"text/javascript",@"js",
                              @"text/html;charset=utf-8",@"html",
                              nil];
    
    //NSLog(@"url: %@,filename: %@, ext: %@, mime: %@",url.absoluteString,fileName,ext,[extToMime objectForKey:ext]);
    
    
    NSDictionary *dictHeaders = [[NSDictionary alloc] initWithObjectsAndKeys:
                                 //@"Thu, 23 Feb 2017 09:59:56 GMT", @"Date",
                                 [extToMime objectForKey:ext], @"Content-Type",
                                 @"keep-alive", @"Connection",
                                 @"Accept-Encoding", @"Vary",
                                 @"true", @"Access-Control-Allow-Credentials",
                                 @"3.795", @"X-Pricing-CPM",
                                 @"http://sdk.starbolt.io", @"Access-Control-Allow-Origin",
                                 @"X-Pricing-CPM", @"Access-Control-Expose-Headers",
                                 @"no-cache", @"no-cache, no-store, must-revalidate",
                                 // @"No-Cache", @"Pragma"
                                 @"0", @"Expires",
                                 
                                 @" {\"class\":\"Facebook\",\"parameter\":\"1451178885159938\",\"pixel\":\"http:\/\/exchange.dev:50000\/customevent.pixel.php?h=d790ead52139579f6d1a2c76bb89f7df&stack_item_id=390785&pub=47276&inv=103169\"} " , @"X-CustomEvent0",
                                 
                                 
                                 
                                 
                                 nil];
    
    //NSLog(@"dict: %@",dictHeaders);
    
    NSHTTPURLResponse *res = [[NSHTTPURLResponse alloc] initWithURL:url statusCode:200 HTTPVersion:@"HTTP/1.1" headerFields:dictHeaders];
    
    
    [self.client URLProtocol:self didReceiveResponse:res cacheStoragePolicy:NSURLCacheStorageNotAllowed];
    
    [self.client URLProtocol:self didLoadData:data];
    
    [self.client URLProtocolDidFinishLoading:self];
    
    
}

- (void)startLoading {
    
    NSURLRequest *request = [self request];
    [self sendFile:request.URL];
}

- (void)stopLoading {
    
}

/*** private methods ***/

- (NSString *)getInvhFromAdRequest:(NSString *)adRequest {
    
    NSData *jsonData = [adRequest dataUsingEncoding:NSUTF8StringEncoding];
    
    NSDictionary *jsonDic = [NSJSONSerialization JSONObjectWithData:jsonData options:NSJSONReadingAllowFragments error:nil];
    
    NSString *adType = [jsonDic objectForKey:@"r_type"];
    
    return adType;
}

@end
