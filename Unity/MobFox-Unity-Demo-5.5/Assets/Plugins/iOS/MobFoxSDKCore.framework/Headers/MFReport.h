//
//  MFLog.h
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 12/8/16.
//  Copyright © 2016 Matomy Media Group Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface MFReport : NSObject <NSURLConnectionDataDelegate>

+ (void)log:(NSString*)facility withInventoryHash:(NSString*)hash andWithMessage:(NSString*)message requestID:(NSString*)requestID;


+ (void)reportOnErrorWithFacility:(NSString *)facility inventoryHash:(NSString*)hash message:(NSString*)message requestID:(NSString*)requestID;
    
@end
