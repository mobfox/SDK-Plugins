//
//  AdIdenManager.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 9/15/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MFAdvertisingManager.h"
@import AdSupport.ASIdentifierManager;

typedef NS_ENUM(NSInteger, MFRandomStringPart) {
    MFRandomStringPartStart = -1,
    MFRandomStringPartStartMiddle , // second part of random string
    MFRandomStringPartMiddle , // third part of random string
    MFRandomStringPartMiddleEnd , // forth part of random string
    MFRandomStringPartEnd , // fifth part of random string
};

#define RANDOM_IDFA_START_LEN 8
#define RANDOM_IDFA_STARTMIDDLE_LEN 4
#define RANDOM_IDFA_MIDDLE_LEN 4
#define RANDOM_IDFA_MIDDLEEND_LEN 4
#define RANDOM_IDFA_END_LEN 12





@implementation MFAdvertisingManager


+ (NSString *)identifier {
    
    NSString *idfa;
    ASIdentifierManager *adIdentManager = [ASIdentifierManager sharedManager];

    if(!adIdentManager.advertisingTrackingEnabled && [[[UIDevice currentDevice] systemVersion] floatValue] >= 10) {
        // throw away any tracking info you may have saved before
        
        idfa = [self randomIDFAfinal];
        
    } else {
        
        idfa = [[adIdentManager advertisingIdentifier] UUIDString];

    }
    
    //NSLog(@"idfa: %@", idfa);
    return idfa ;
}

+ (NSString *)randomIDFAfinal {
    
    NSString *randomString;
    randomString = [[NSUserDefaults standardUserDefaults] stringForKey:@"idfa"];
    
    if (randomString.length > 0) {
        return randomString;
    }
    
    randomString = [NSString stringWithFormat:@"%@-%@-%@-%@-%@", [self randomIDFApart:RANDOM_IDFA_START_LEN], [self randomIDFApart:RANDOM_IDFA_STARTMIDDLE_LEN], [self randomIDFApart:RANDOM_IDFA_MIDDLE_LEN], [self randomIDFApart:RANDOM_IDFA_MIDDLEEND_LEN], [self randomIDFApart:RANDOM_IDFA_END_LEN] ];
    
    [[NSUserDefaults standardUserDefaults] setObject:randomString forKey:@"idfa"];
    [[NSUserDefaults standardUserDefaults] synchronize];
    
    return randomString;
}
    

+ (NSMutableString *)randomIDFApart:(NSUInteger)length {
    
    NSMutableString *randomString;

    randomString = [NSMutableString stringWithCapacity: length];
    NSString *alphabet = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    for (int i=0; i<length; i++) {
        NSInteger rand = arc4random() % 36;
        [randomString appendFormat: @"%C", [alphabet characterAtIndex: rand]];
    }
    
    return randomString;
}


@end

