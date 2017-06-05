//
//  MFConverter.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 1/21/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "NSString+Converter.h"

@implementation NSString (Converter)

- (NSNumber *)numberValue {
    
    return [NSNumber numberWithInt:[self intValue]];
}

- (NSURL *)urlValue {
    
    return [NSURL URLWithString:self];
}



@end
