//
//  MFEventsHandler.m
//  DemoApp
//
//  Created by Shimi Sheetrit on 2/15/17.
//  Copyright © 2017 Matomy Media Group Ltd. All rights reserved.
//

#import "MFEventsHandler.h"

@interface MFEventsHandler()


@property (atomic, assign, getter=isAdReported) BOOL adReported;
@property (atomic, assign, getter=isInterstitialAdReported) BOOL interstitialAdReported;
@property (atomic, assign, getter=isNativeAdReported) BOOL nativeAdReported;



@end


@implementation MFEventsHandler


- (instancetype)init {
    
    self = [super init];
    
    if (self) {
        // initialize instance variables here
    }
    
    return self;
}

/*** reset blockers ***/
- (void)resetAdEventBlocker {
    
    [self setAdReported:false];
    
}

- (void)resetInterstitialEventBlocker {
    
    [self setInterstitialAdReported:false];
    
}

- (void)resetNativeEventBlocker {
    
    [self setNativeAdReported:false];
    
}

/*** invoke blockers ***/
- (void)invokeAdEventBlocker:(void (^)(BOOL isReported))completion{

    @synchronized (self) {
        
        if([self isAdReported]) {
            completion(YES);

        }
        
        [self setAdReported:true];
        completion(NO);
        
    }
}

- (void)invokeInterstitialAdEventBlocker:(void (^)(BOOL isReported))completion {
    
    @synchronized (self) {
        
        if([self isInterstitialAdReported]) {
            completion(YES);
        }
        
        [self setInterstitialAdReported:true];
        completion(NO);
        
    }
}

- (void)invokeNativeAdEventBlocker:(void (^)(BOOL isReported))completion {
    
    @synchronized (self) {
        
        if([self isNativeAdReported]) {
            completion(YES);
        }
        
        [self setNativeAdReported:true];
        completion(NO);
        
    }
}



@end
