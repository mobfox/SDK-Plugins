//
//  UIDevice+DeviceType.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 1/21/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "UIDevice+DeviceType.h"

@implementation UIDevice (DeviceType)

+ (BOOL)isIpad {
        
    return [UIDevice currentDevice].userInterfaceIdiom == UIUserInterfaceIdiomPad;
}

+ (BOOL)isIphone {
    
    return [UIDevice currentDevice].userInterfaceIdiom == UIUserInterfaceIdiomPhone;
}

+ (BOOL)isTV {
    
    return [UIDevice currentDevice].userInterfaceIdiom == UIUserInterfaceIdiomTV;
}


@end
