//
//  MobFoxPlugin.h
//
//  Created by Shimon Shnitzer on 16/8/2016.
//
//

#import <Cordova/CDV.h>
#import <MobFoxSDKCore/MobFoxSDKCore.h>

@interface MobFoxPlugin : CDVPlugin <MobFoxAdDelegate, MobFoxInterstitialAdDelegate, MobFoxNativeAdDelegate>

- (void)setUseLocation:(CDVInvokedUrlCommand*)command;

- (void)showBanner:(CDVInvokedUrlCommand*)command;

- (void)hideBanner:(CDVInvokedUrlCommand*)command;

- (void)unhideBanner:(CDVInvokedUrlCommand*)command;

- (void)createInterstitial:(CDVInvokedUrlCommand*)command;

- (void)showInterstitial:(CDVInvokedUrlCommand*)command;

- (void)createNative:(CDVInvokedUrlCommand*)command;

- (void)showToast:(CDVInvokedUrlCommand*)command;

@end
