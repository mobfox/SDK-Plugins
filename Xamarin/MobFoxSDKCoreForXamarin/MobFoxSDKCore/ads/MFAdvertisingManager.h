//
//  AdIdenManager.h
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 9/15/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface MFAdvertisingManager : NSObject

+ (NSString *)identifier;
+ (NSString *)randomIDFAfinal;
+ (NSMutableString *)randomIDFApart:(NSUInteger)length;


@end
