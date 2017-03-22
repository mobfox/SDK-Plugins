#import <MobFoxSDKCore/MobFoxSDKCore.h>

@interface MobFoxForGameMakerExtension : NSObject <MobFoxAdDelegate,MobFoxInterstitialAdDelegate,MobFoxNativeAdDelegate>
{
    MobFoxAd*             mBanner;
    MobFoxInterstitialAd* mInterstitial;
    MobFoxNativeAd*       mobfoxNativeAd;
	
	UIAlertView*          mToast;
    
    bool                  mUseLocation;
}

- (double) init_plugin;
- (double) show_toast:(char *)arg0;
- (double) set_use_location:(double)arg0;
- (double) create_banner:(char *)arg0 Arg2:(double)arg1 Arg3:(double)arg2 Arg4:(double)arg3 Arg5:(double)arg4;
- (double) hide_banner;
- (double) unhide_banner;
- (double) create_interstitial:(char *)arg0;
- (double) create_native:(char *)arg0;
- (double) show_interstitial;

@end