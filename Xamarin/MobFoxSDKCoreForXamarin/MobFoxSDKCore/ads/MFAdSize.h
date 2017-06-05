//
//  MFAdSize.h
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 11/23/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface MFAdSize : NSObject

#pragma mark Standard Ad Sizes

struct aCGSize {
    CGFloat width;
    CGFloat height;
    NSUInteger flags;  ///< Reserved.

};
typedef struct CGSize aCGSize;

#pragma mark Standard Sizes

/// iPhone and iPod Touch ad size. Typically 320x50.
extern aCGSize const kMFAdSizeSmartBannerPad;
extern aCGSize const kMFAdSizeSmartBannerPad;






@end
