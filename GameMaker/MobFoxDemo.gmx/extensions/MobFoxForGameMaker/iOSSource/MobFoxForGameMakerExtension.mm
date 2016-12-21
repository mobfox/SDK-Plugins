#import "MobFoxForGameMakerExtension.h"
#import "iToast.h"
#include <asl.h>
#include <stdio.h>


@implementation MobFoxForGameMakerExtension

const int EVENT_OTHER_SOCIAL = 70;
extern int CreateDsMap( int _num, ... );
extern void CreateAsynEventWithDSMap(int dsmapindex, int event_index);

- (void)dispatchMobFoxEventWithName:(NSString *)type andData:(NSString *)data
{
	//int dsMapIndex = RunnerJNILib.jCreateDsMap(null,null,null);
	//	RunnerJNILib.DsMapAddString(dsMapIndex,"type",(char*)[type UTF8String]);
	//	RunnerJNILib.DsMapAddString(dsMapIndex,"data",(char*)[data UTF8String]);
	//	RunnerJNILib.CreateAsynEventWithDSMap(dsMapIndex,EVENT_OTHER_SOCIAL);

	
	
	int dsMapIndex = CreateDsMap(2,
					"type", 0.0, (char*)[type UTF8String],
					"data", 0.0, (char*)[data UTF8String]
					);
	CreateAsynEventWithDSMap(dsMapIndex, EVENT_OTHER_SOCIAL);
}

//========================================================================================

- (UIViewController*)vc {
    UIWindow *window;
    if ([[UIApplication sharedApplication] delegate] && [[[UIApplication sharedApplication] delegate] respondsToSelector:@selector(window)] && [[[UIApplication sharedApplication] delegate] window] != nil) {
        window = [[[UIApplication sharedApplication] delegate] window];
    } else {
        window = [[UIApplication sharedApplication] keyWindow];
    }
    
    return window.rootViewController;
}

//========================================================================================

- (double) show_toast:(char *)arg0
{
	NSLog(@"yoyo: show_toast"); 
		 
	// Convert C strings to Obj-C strings
    NSString *string1ObjC = [NSString stringWithUTF8String:(char*)arg0];

	[self ShowToast:string1ObjC];

	return 0;
}

- (void)ShowToast:(NSString *)text
{
    [[[[[[iToast makeText:text]
         setGravity:iToastGravityBottom]
        setDuration:iToastDurationLong]
       setCornerRadius:0.0]
      setWithAction:TRUE] show];
}

//======================================================================================
//======  I N I T                                                                 ======
//======================================================================================

- (double) init_plugin
{
	NSLog(@"yoyo: init_plugin"); 

	mUseLocation = false;
	
    [MobFoxAd locationServicesDisabled:!mUseLocation];

	return 0;
}

//======================================================================================
//======  L O C A T I O N                                                         ======
//======================================================================================

- (double) set_use_location:(double)arg0
{
	NSLog(@"yoyo: set_use_location"); 

	mUseLocation = (arg0!=0);
	
    [MobFoxAd locationServicesDisabled:!mUseLocation];

	return 0;
}

//======================================================================================
//======  B A N N E R                                                             ======
//======================================================================================

- (double) create_banner:(char *)arg0 Arg2:(double)arg1 Arg3:(double)arg2 Arg4:(double)arg3 Arg5:(double)arg4
{
	NSLog(@"yoyo: create_banner"); 
	
	NSString *myHash = [NSString stringWithUTF8String:(char*)arg0];
    int      in_x    = (int)arg1;
    int      in_y    = (int)arg2;
    int      in_w    = (int)arg3;
    int      in_h    = (int)arg4;
        
	// mytodo: check why this is required, and fix?
    if (in_h==50)
    {
        in_h = 51;
    }

	CGFloat originX    = (CGFloat)in_x;
    CGFloat originY    = (CGFloat)in_y;
    CGFloat sizeWidth  = (CGFloat)in_w;
    CGFloat sizeHeight = (CGFloat)in_h;
        
    NSLog(@"dbg: ### yoyo >> createBanner(%@)",myHash);
        
    NSLog(@"dbg: ### yoyo >> rect x: %f", originX);
    NSLog(@"dbg: ### yoyo >> rect y: %f", originY);
    NSLog(@"dbg: ### yoyo >> rect width: %f", sizeWidth);
    NSLog(@"dbg: ### yoyo >> rect height: %f", sizeHeight);
        
    CGRect placement = CGRectMake(originX,originY,sizeWidth,sizeHeight);

    [MobFoxAd locationServicesDisabled:!mUseLocation];
    
    mBanner = [[MobFoxAd alloc] init:myHash withFrame:placement];
    mBanner.delegate = self;
    
    //UIWindow *window = [[[UIApplication sharedApplication] windows] objectAtIndex:0];
    //[window addSubview:mBanner];
    
    UIViewController *vc = [self vc];
    [vc.view addSubview:mBanner];
    
    //[[[[UIApplication sharedApplication] delegate] window] addSubview:mBanner];
    
    mBanner.hidden = TRUE;
    
    [mBanner loadAd];
    [self ShowToast:@"createBanner"];

	return 0;
}

//======================================================================================

// MobFox Ad Delegate
- (void)MobFoxAdDidLoad:(MobFoxAd *)banner{
    
    mBanner.hidden = FALSE;
    
    [self dispatchMobFoxEventWithName:@"bannerReady" andData:@""];
}

- (void)MobFoxAdDidFailToReceiveAdWithError:(NSError *)error{
    
    [self dispatchMobFoxEventWithName:@"bannerError" andData:[error description]];
}

- (void)MobFoxAdClosed{

    [self dispatchMobFoxEventWithName:@"bannerClosed" andData:@""];
}

- (void)MobFoxAdClicked{
    
    [self dispatchMobFoxEventWithName:@"bannerClicked" andData:@""];
}

- (void)MobFoxAdFinished{

    [self dispatchMobFoxEventWithName:@"bannerFinished" andData:@""];
}

//======================================================================================
//======  I N T E R S T I T I A L                                                 ======
//======================================================================================

- (double) create_interstitial:(char *)arg0
{
	NSLog(@"yoyo: create_interstitial"); 
	
	NSString *myHash = [NSString stringWithUTF8String:(char*)arg0];
	
    [MobFoxAd locationServicesDisabled:!mUseLocation];
    
    mInterstitial = [[MobFoxInterstitialAd alloc] init:myHash withRootViewController:[self vc]];
    
    mInterstitial.ad.demo_gender = @"f";
    mInterstitial.delegate = self;
    
    [mInterstitial loadAd];
    
    [self ShowToast:@"createInterstitial"];

	return 0;
}

- (double) show_interstitial
{
	NSLog(@"yoyo: show_interstitial"); 
    
	if (!mInterstitial){
        [self ShowToast:@"showInterstitial: not init"];
        return 1;
    }
    
    if (mInterstitial.ready){
        [self ShowToast:@"showInterstitial"];
        [mInterstitial show];
    }

	return 0;
}

//======================================================================================

// MobFox Interstitial Ad Delegate
- (void)MobFoxInterstitialAdDidLoad:(MobFoxInterstitialAd *)interstitial{
    
    [self dispatchMobFoxEventWithName:@"interstitialReady" andData:@""];
}

- (void)MobFoxInterstitialAdDidFailToReceiveAdWithError:(NSError *)error{
    
    [self dispatchMobFoxEventWithName:@"interstitialError" andData:[error description]];
}

- (void)MobFoxInterstitialAdClosed{
    
    [self dispatchMobFoxEventWithName:@"interstitialClosed" andData:@""];
}

- (void)MobFoxInterstitialAdClicked{
    
    [self dispatchMobFoxEventWithName:@"interstitialClicked" andData:@""];
}

- (void)MobFoxInterstitialAdFinished{
    
    [self dispatchMobFoxEventWithName:@"interstitialFinished" andData:@""];
}

//======================================================================================
//======  N A T I V E                                                             ======
//======================================================================================

- (double) create_native:(char *)arg0
{
	NSLog(@"yoyo: create_native"); 
	
	NSString *myHash = [NSString stringWithUTF8String:(char*)arg0];
	
    [MobFoxAd locationServicesDisabled:!mUseLocation];
    
    
    mobfoxNativeAd = [[MobFoxNativeAd alloc] init:myHash];
    
    mobfoxNativeAd.delegate = self;
    
    [mobfoxNativeAd loadAd];

	return 0;
}

//======================================================================================

//called when ad response is returned
- (void)MobFoxNativeAdDidLoad:(MobFoxNativeAd *)ad withAdData:(MobFoxNativeData *)adData {
    
    NSLog(@"dbg: ### yoyo >> MobFoxNativeAdDidLoad >> native loaded ###");
    
    if (adData==nil)
    {
	    NSLog(@"dbg: ### yoyo >> MobFoxNativeAdDidLoad >> No ad data ###");
    
        [self dispatchMobFoxEventWithName:@"nativeError" andData:@"No ad data"];
    } else {
		NSString *msg = [NSString stringWithFormat:@"<Headline>%@|<Description>%@|<IconImageUrl>%@|<MainImageUrl>%@|<ClickUrl>%@",
    							adData.assetHeadline,
    							adData.assetDescription,
    							adData.icon.url,
    							adData.main.url,
    							adData.clickURL];
    						
		NSLog(@"dbg: ### yoyo >> MobFoxNativeAdDidLoad %@",msg);

        [self dispatchMobFoxEventWithName:@"nativeReady" andData:msg];
    }
}

//called when ad response cannot be returned
- (void)MobFoxNativeAdDidFailToReceiveAdWithError:(NSError *)error {
    
    NSLog(@"dbg: ### yoyo >> MobFoxNativeAdDidFailToReceiveAdWithError >> %@",[error description]);

    [self dispatchMobFoxEventWithName:@"nativeError" andData:[error description]];
}

@end
