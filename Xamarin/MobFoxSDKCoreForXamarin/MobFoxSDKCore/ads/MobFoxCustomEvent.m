//
//  MobFoxCustomEvent.m
//  MobFoxSDKCore
//
//  Created by Itamar Nabriski on 10/7/15.
//  Copyright © 2015 Itamar Nabriski. All rights reserved.
//

#import "MobFoxCustomEvent.h"

@implementation MobFoxCustomEvent

- (void)requestAdWithSize:(CGSize)size networkID:(NSString*)nid customEventInfo:(NSDictionary *)info{
    
    /* implemented by sub classes */
    
}

- (void) dealloc{
    self.delegate = nil;
}

@end
