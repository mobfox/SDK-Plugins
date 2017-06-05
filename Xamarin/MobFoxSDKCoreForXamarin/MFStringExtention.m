//
//  StringExtention.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 3/16/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MFStringExtention.h"

@implementation MFStringExtention

+ (NSNumber *)numberValue:(NSString*)str {
    
    return [NSNumber numberWithInt:[str intValue]];
}

+ (NSURL *)urlValue:(NSString*)str {
    
    return [NSURL URLWithString:str];
}

@end
