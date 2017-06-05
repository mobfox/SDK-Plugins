//
//  MFTimerHandler.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 9/28/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MFTimerHandler.h"

@interface MFTimerHandler()
@property (nonatomic, strong) NSTimer *mfTimer;
@end

@implementation MFTimerHandler


- (void)startTimerWithInterval:(int)interval completion:(void(^)(bool triggered))completion {
    
        _mfTimer = [NSTimer scheduledTimerWithTimeInterval:interval repeats:YES block:^(NSTimer * _Nonnull timer) {
        
        //NSLog(@"-- startTimerWithInterval --");
        //NSLog(@"startTimerWithInterval -- interval: %d", interval);
        
        BOOL timer_triggered = true;
        completion(timer_triggered);

    }];
    
}

- (void)stopTimer:(id)sender {
    
    
    if ([_mfTimer isValid]) {
        [_mfTimer invalidate];
    }
    
    _mfTimer = nil;
}




@end
