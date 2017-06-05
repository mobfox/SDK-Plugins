//
//  MobFoxClickableView.h
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 1/27/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface MobFoxClickableView : NSObject <UIGestureRecognizerDelegate>

@property (nonatomic, strong) NSURL* clickURL;

- (void)setClickableView:(UIView *)view withViewController:(UIViewController *)viewController clickURL:(NSURL *)clickURL;

@end
