#import <Foundation/Foundation.h>
#import "FlashRuntimeExtensions.h"
#import <MobFoxSDKCore/MobFoxSDKCore.h>

@interface iOSMobFoxPluginLibWrapper : NSObject <MobFoxAdDelegate,MobFoxInterstitialAdDelegate,MobFoxNativeAdDelegate> {

    FREContext eventContext;
    
    MobFoxAd*             mBanner;
    MobFoxInterstitialAd* mInterstitial;
    MobFoxNativeAd*       mNative;

    bool                  mUseLocation;
}

+ (iOSMobFoxPluginLibWrapper*)sharediOSMobFoxPluginLibWrapper;

//----------------------------

- (void)initEventContext:(FREContext)eventContext;

//----------------------------

- (void)createBanner:(NSString *)myHash at:(CGRect)placement;

- (void)hideBanner;
- (void)unhideBanner;

//----------------------------

- (void)createInterstitial:(NSString *)myHash;

- (void)showInterstitial;

//----------------------------

- (void)createNative:(NSString *)myHash;

//----------------------------

- (void)setUseLocation:(BOOL)newVal;

//----------------------------

@end
