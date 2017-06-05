//
//  MobFoxNativeCustomEvent.m
//  MobFoxSDKCore
//
//  Created by Itamar Nabriski on 10/11/15.
//  Copyright © 2015 Itamar Nabriski. All rights reserved.
//

#import "MobFoxNativeCustomEvent.h"

@implementation MobFoxNativeCustomEvent

- (void)registerViewWithInteraction:(UIView *)view withViewController:(UIViewController *)viewController{
    //implemented by subclasses
}

- (void)requestAdWithNetworkID:(NSString*)nid customEventInfo:(NSDictionary *)info{
    //implemented by subclasses
}

- (void) dealloc{
    self.delegate = nil;
}

@end
