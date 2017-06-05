//
//  DeviceExtention.h
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 3/16/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface MFDeviceExtention : NSObject

+ (BOOL)isIpad;
+ (BOOL)isIphone;
+ (BOOL)isTV;
+ (NSString *)ipAddress;

@end
