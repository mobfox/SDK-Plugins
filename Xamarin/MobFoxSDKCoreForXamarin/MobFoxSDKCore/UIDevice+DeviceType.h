//
//  UIDevice+DeviceType.h
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 1/21/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface UIDevice (DeviceType)

+ (BOOL)isIpad;
+ (BOOL)isIphone;
+ (BOOL)isTV;

@end
