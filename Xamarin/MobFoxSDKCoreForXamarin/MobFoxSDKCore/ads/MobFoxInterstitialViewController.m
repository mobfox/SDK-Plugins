//
//  MobFoxInterstitialViewController.m
//  MobFoxSDKCore
//
//  Created by Shimi Sheetrit on 1/17/16.
//  Copyright © 2016 Itamar Nabriski. All rights reserved.
//

#import "MobFoxInterstitialViewController.h"

@interface MobFoxInterstitialViewController ()

@end

@implementation MobFoxInterstitialViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    
    self.view.backgroundColor = [UIColor blackColor];
    // Do any additional setup after loading the view.
    [self setNeedsStatusBarAppearanceUpdate];
        
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}
/*
- (NSUInteger)supportedInterfaceOrientations
{
    return UIInterfaceOrientationMaskPortrait;
}*/

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

-(BOOL)shouldAutorotate {
    return NO;
}

-(BOOL)prefersStatusBarHidden{
       return YES;
}



@end
