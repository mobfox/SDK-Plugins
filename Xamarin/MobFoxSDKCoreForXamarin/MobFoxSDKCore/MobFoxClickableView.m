//
//  MobFoxClickableView.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 1/27/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MobFoxClickableView.h"

@implementation MobFoxClickableView

- (void)setClickableView:(UIView *)view withViewController:(UIViewController *)viewController clickURL:(NSURL *)clickURL {
    

    NSLog(@"setClickableView:withURL:");
    
    self.clickURL = clickURL;

    UITapGestureRecognizer *singleTap = [[UITapGestureRecognizer alloc] initWithTarget:viewController action:@selector(handleSingleTap:)];
    [view addGestureRecognizer:singleTap];
    viewController.view.userInteractionEnabled = YES;
    view.userInteractionEnabled = YES;
    singleTap.delegate = self;

}

-(BOOL)gestureRecognizer:(UIGestureRecognizer *)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer *)otherGestureRecognizer {
    
    NSLog(@"gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:");

    // return
    return true;
}

- (void)handleSingleTap:(UITapGestureRecognizer *)recognizer {
    
    NSLog(@"handleSingleTap:");
    
    [[UIApplication sharedApplication] openURL:self.clickURL];

}


@end
