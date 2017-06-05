//
//  WaterfallsManager.h
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 6/6/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface MFSDKManager : NSObject <NSURLSessionDataDelegate, NSURLSessionDelegate>
    
//@property (assign, atomic, getter=isDebug) BOOL debug;



+ (instancetype) sharedInstance;
//- (BOOL)isCacheContainsWaterfallDataForInventoryHash:(NSString *)inventoryHash;
- (void)waterfallsWithInventoryHash:(NSString *)inventoryHash completion:(void(^)(NSString *wf))completion;
- (void)warmUp;

- (NSString*) getSdkUrl:(BOOL) secure;
//- (void)reloadData:(NSString*)inventoryHash completion:(void(^)(NSData *data))completion;

- (void) getSdk:(BOOL)secure withCallback:(void(^)(NSString* sdkStr,NSError* error))completion;
+ (BOOL)isDebug;
+ (void)setDebug:(BOOL)value;

@end
