//
//  MobFoxInterstitialCustomEvent.m
//  MobFoxSDKCore
//
//  Created by Itamar Nabriski on 10/8/15.
//  Copyright © 2015 Itamar Nabriski. All rights reserved.
//

#import "MobFoxInterstitialCustomEvent.h"

@implementation MobFoxInterstitialCustomEvent

-(void)requestInterstitialWithNetworkId:(NSString*)networkId customEventInfo:(NSDictionary *)info{
     //implemented by sub class
}

-(void)presentWithRootController:(UIViewController *)rootViewController{
    //implemented by sub class
}

- (void) dealloc{
    self.delegate = nil;
}

@end
