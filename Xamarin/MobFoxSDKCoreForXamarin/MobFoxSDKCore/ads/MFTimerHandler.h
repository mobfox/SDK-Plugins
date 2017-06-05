//
//  MFTimerHandler.h
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 9/28/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface MFTimerHandler : NSObject

- (void)startTimerWithInterval:(int)interval completion:(void(^)(bool triggered))completion;
- (void)stopTimer:(id)sender;

@end
