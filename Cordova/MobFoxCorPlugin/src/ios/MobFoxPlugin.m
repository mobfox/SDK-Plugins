//
//  MobFoxPlugin.m
//
//  Created by Shimon Shnitzer on 16/8/2016.
//
//

#import "MobFoxPlugin.h"
#import <Cordova/CDV.h>
#import <MobFoxSDKCore/MobFoxSDKCore.h>

@interface MobFoxPlugin()

    @property NSMutableDictionary* ads;
    @property int nextId;
    @property (nonatomic,strong) MobFoxAd* banner;
    @property (nonatomic,strong) MobFoxInterstitialAd* inter;
    @property (nonatomic,strong) MobFoxNativeAd* mobfoxNativeAd;

@end

@implementation MobFoxPlugin

CDVInvokedUrlCommand *mBannerCommand       = nil;
CDVInvokedUrlCommand *mInterstitialCommand = nil;
CDVInvokedUrlCommand *mNativeCommand       = nil;

bool mUseLocation = false;

//======================================================================================
//======  G E N E R A L                                                           ======
//======================================================================================

- (void)sendMobFoxCallback:(CDVInvokedUrlCommand *)command 
               withSuccess:(BOOL)bOk 
                   andText:(NSString *)msg
{
    CDVPluginResult* pluginResult;
    
	if (bOk)
    {
		pluginResult = [CDVPluginResult resultWithStatus:CDVCommandStatus_OK messageAsString:msg];
    } else {
    	pluginResult = [CDVPluginResult resultWithStatus:CDVCommandStatus_ERROR messageAsString:msg];
    }
    
    pluginResult.keepCallback = [NSNumber numberWithBool:TRUE];

    [self.commandDelegate sendPluginResult:pluginResult callbackId:command.callbackId];
}

//======================================================================================
//======  T O A S T                                                               ======
//======================================================================================

- (void)showToast:(CDVInvokedUrlCommand*)command
{
    NSMutableDictionary* dict = [command.arguments objectAtIndex:0];

    if (dict != nil && [dict count] > 0)
    {
    	NSString *text = [dict objectForKey:@"text"];
    	
    	[self MyShowToast:text];
    }
}

- (void)MyShowToast:(NSString *)text
{
		UIAlertView *toast = [[UIAlertView alloc] initWithTitle:nil
                                                message:text
                                               delegate:nil
                                      cancelButtonTitle:nil
                                      otherButtonTitles:nil, nil];
		[toast show];

		int duration = 2; // duration in seconds

		dispatch_after(dispatch_time(DISPATCH_TIME_NOW, duration * NSEC_PER_SEC), dispatch_get_main_queue(), ^{
    		[toast dismissWithClickedButtonIndex:0 animated:YES];
		});
}

//======================================================================================
//======  L O C A T I O N                                                         ======
//======================================================================================

- (void)setUseLocation:(CDVInvokedUrlCommand*)command
{
    NSMutableDictionary* dict = [command.arguments objectAtIndex:0];

    if (dict != nil && [dict count] > 0)
    {
    	NSNumber *numUseLocation = [dict objectForKey:@"useLocation"];
    	if (numUseLocation!=nil)
    	{
    		mUseLocation = [numUseLocation boolValue];
    		
    		if (mUseLocation)
    		{
    			NSLog(@"dbg: ### setUseLocation: TRUE ###");
    		} else {
    			NSLog(@"dbg: ### setUseLocation: FALSE ###");
    		}
    	}
    }
}

//======================================================================================
//======  B A N N E R                                                             ======
//======================================================================================

- (void)showBanner:(CDVInvokedUrlCommand*)command
{
    NSMutableDictionary* dict = [command.arguments objectAtIndex:0];

    if (dict != nil && [dict count] > 0)
    {
    	NSString *invh = [dict objectForKey:@"hash"];
    	NSNumber *x    = [dict objectForKey:@"x"];
    	NSNumber *y    = [dict objectForKey:@"y"];
    	NSNumber *w    = [dict objectForKey:@"w"];
    	NSNumber *h    = [dict objectForKey:@"h"];
    	NSNumber *r    = [dict objectForKey:@"refresh"];
		
    	if ((invh!=nil) && (x!=nil) && (y!=nil) && (w!=nil) && (h!=nil) && (r!=nil))
    	{
    		mBannerCommand = command;
    	
    		dispatch_async(dispatch_get_main_queue(), ^{
    			// Your code to run on the main queue/thread
	    		[self createBanner:invh 
						   originX:[x floatValue]
						   originY:[y floatValue]
						 sizeWidth:[w floatValue]
						sizeHeight:[h floatValue]
						   refresh:r];
			});
					
        	return;
    	}
    }

	[self sendMobFoxCallback:command withSuccess:FALSE andText:@"No params"];
}

//======================================================================================

- (void)hideBanner:(CDVInvokedUrlCommand*)command
{
    NSLog(@"dbg: ### MobFoxCorPlugin >> hideBanner");

    if(!self.banner){
        NSLog(@"dbg: ### MobFoxCorPlugin >> hideBanner >> banner not init");
        return;
    }
    
    self.banner.hidden = TRUE;
}

//======================================================================================

- (void)unhideBanner:(CDVInvokedUrlCommand*)command
{
    NSLog(@"dbg: ### MobFoxCorPlugin >> unhideBanner");

    if(!self.banner){
        NSLog(@"dbg: ### MobFoxCorPlugin >> unhideBanner >> banner not init");
        return;
    }
    
    self.banner.hidden = FALSE;
}

//======================================================================================

- (int)createBanner:(NSString*)invh 
			originX:(CGFloat)originX 
			originY:(CGFloat)originY
          sizeWidth:(CGFloat)sizeWidth
         sizeHeight:(CGFloat)sizeHeight
			refresh:(NSNumber *)refresh
{
    NSLog(@"dbg: ### MobFoxCorPlugin >> createBanner(%@)",invh);
    
    NSLog(@"dbg: ### MobFoxCorPlugin >> rect x: %f", originX);
    NSLog(@"dbg: ### MobFoxCorPlugin >> rect y: %f", originY);
    NSLog(@"dbg: ### MobFoxCorPlugin >> rect width: %f", sizeWidth);
    NSLog(@"dbg: ### MobFoxCorPlugin >> rect height: %f", sizeHeight);
    NSLog(@"dbg: ### MobFoxCorPlugin >> refresh: %d", [refresh intValue]);
    
    CGRect placement = CGRectMake(originX,originY,sizeWidth,sizeHeight);
  		
    if (mUseLocation)
    {
    	NSLog(@"dbg: ### useLocation: TRUE ###");
    } else {
    	NSLog(@"dbg: ### useLocation: FALSE ###");
    }
    [MobFoxAd locationServicesDisabled:!mUseLocation];
    
    if (self.banner!=nil)
    {
    	[self.banner removeFromSuperview];
    }

    self.banner = [[MobFoxAd alloc] init:invh withFrame:placement];
    
    self.banner.delegate = self;
    self.banner.refresh = refresh;
    
    NSString* key = [NSString stringWithFormat:@"key-%d",self.nextId];
    [self.ads setValue:self.banner forKey:key];
    int cur = self.nextId;
    self.nextId= self.nextId + 1;

    [self.banner loadAd];

    return cur;
}

//======================================================================================

// MobFox Ad Delegate
- (void)MobFoxAdDidLoad:(MobFoxAd *)banner{
    //show banner
    [self.viewController.view addSubview:self.banner];
    
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxAdDidLoad:");
    [self sendMobFoxCallback:mBannerCommand withSuccess:TRUE andText:@"onBannerLoaded"];
    
}

- (void)MobFoxAdDidFailToReceiveAdWithError:(NSError *)error{
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxAdDidFailToReceiveAdWithError: %@",[error description]);
    NSString *msg;
    
    msg = [NSString stringWithFormat:@"Unknown error"];
    if ((error!=nil) && (error.userInfo!=nil))
    {
    	NSDictionary *errDict = [error.userInfo objectForKey:@"error"];
    	if (errDict!=nil)
    	{
    		msg = [NSString stringWithFormat:@"%@", errDict];
    	}
    }
    
    //[self MyShowToast:msg];

    [self sendMobFoxCallback:mBannerCommand withSuccess:FALSE andText:msg];
}

- (void)MobFoxAdClosed{
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxAdClosed:");
    [self sendMobFoxCallback:mBannerCommand withSuccess:TRUE andText:@"onBannerClosed"];
}

- (void)MobFoxAdClicked{
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxAdClicked:");
    [self sendMobFoxCallback:mBannerCommand withSuccess:TRUE andText:@"onBannerClicked"];
}

- (void)MobFoxAdFinished{
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxAdFinished:");
    [self sendMobFoxCallback:mBannerCommand withSuccess:TRUE andText:@"onBannerFinished"];
}

//======================================================================================
//======  I N T E R S T I T I A L                                                 ======
//======================================================================================

- (void)createInterstitial:(CDVInvokedUrlCommand*)command
{
    NSMutableDictionary* dict = [command.arguments objectAtIndex:0];

    if (dict != nil && [dict count] > 0)
    {
    	NSString *invh = [dict objectForKey:@"hash"];
    	
    	if (invh!=nil)
    	{
    		mInterstitialCommand = command;

    		if (mUseLocation)
    		{
    			NSLog(@"dbg: ### useLocation: TRUE ###");
    		} else {
    			NSLog(@"dbg: ### useLocation: FALSE ###");
    		}
    		[MobFoxAd locationServicesDisabled:!mUseLocation];
    
    		self.inter = [[MobFoxInterstitialAd alloc] init:invh
                             withRootViewController:self.viewController];//UnityGetGLViewController()];
    
    		self.inter.delegate = self;
    
    		[self.inter loadAd];
					
        	return;
    	}
    }

	[self sendMobFoxCallback:command withSuccess:FALSE andText:@"No params"];
}

- (void)showInterstitial:(CDVInvokedUrlCommand*)command
{
    NSLog(@"dbg: ### MobFoxCorPlugin >> showInterstitial");

    if(!self.inter){
        NSLog(@"dbg: ### MobFoxCorPlugin >> showInterstitial >> inter not init");
        return;
    }
    
    if(self.inter.ready){
        NSLog(@"dbg: ### MobFoxCorPlugin >> showInterstitial >> inter ready - show");
        [self.inter show];
    }
}

//======================================================================================

// MobFox Interstitial Ad Delegate
- (void)MobFoxInterstitialAdDidLoad:(MobFoxInterstitialAd *)interstitial{
    
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxInterstitialAdDidLoad >> inter loaded");
    
    //@@@interstitial.rootViewController = UnityGetGLViewController();

    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxAdDidLoad:");
    [self sendMobFoxCallback:mInterstitialCommand withSuccess:TRUE andText:@"onInterstitialLoaded"];
}

- (void)MobFoxInterstitialAdDidFailToReceiveAdWithError:(NSError *)error{

    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxInterstitialAdDidFailToReceiveAdWithError >> %@",[error description]);
    
    NSString *msg;
    
    msg = [NSString stringWithFormat:@"Unknown error"];
    if ((error!=nil) && (error.userInfo!=nil))
    {
    	NSDictionary *errDict = [error.userInfo objectForKey:@"error"];
    	if (errDict!=nil)
    	{
    		msg = [NSString stringWithFormat:@"%@", errDict];
    	}
    }
    
	[self sendMobFoxCallback:mInterstitialCommand withSuccess:FALSE andText:msg];
}

- (void)MobFoxInterstitialAdClosed{
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxInterstitialAdClosed:");
    [self sendMobFoxCallback:mInterstitialCommand withSuccess:TRUE andText:@"onInterstitialClosed"];
}


- (void)MobFoxInterstitialAdClicked{
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxInterstitialAdClicked:");
    [self sendMobFoxCallback:mInterstitialCommand withSuccess:TRUE andText:@"onInterstitialClicked"];
}


- (void)MobFoxInterstitialAdFinished{
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxInterstitialAdFinished:");
    [self sendMobFoxCallback:mInterstitialCommand withSuccess:TRUE andText:@"onInterstitialFinished"];
}

//======================================================================================
//======  N A T I V E                                                             ======
//======================================================================================

- (void)createNative:(CDVInvokedUrlCommand*)command
{
    NSMutableDictionary* dict = [command.arguments objectAtIndex:0];

    if (dict != nil && [dict count] > 0)
    {
    	NSString *invh = [dict objectForKey:@"hash"];
    	
    	if (invh!=nil)
    	{
    		mNativeCommand = command;

    		if (mUseLocation)
    		{
    			NSLog(@"dbg: ### useLocation: TRUE ###");
    		} else {
    			NSLog(@"dbg: ### useLocation: FALSE ###");
    		}
    		[MobFoxAd locationServicesDisabled:!mUseLocation];
    
    		self.mobfoxNativeAd = [[MobFoxNativeAd alloc] init:invh];
    
    		self.mobfoxNativeAd.delegate = self;
    
    		[self.mobfoxNativeAd loadAd];
					
        	return;
    	}
    }

	[self sendMobFoxCallback:command withSuccess:FALSE andText:@"No params"];
}

//======================================================================================

//called when ad response is returned
- (void)MobFoxNativeAdDidLoad:(MobFoxNativeAd *)ad withAdData:(MobFoxNativeData *)adData {
    
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxNativeAdDidLoad >> native loaded ###");
    
    if (adData==nil)
    {
	    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxNativeAdDidLoad >> No ad data ###");
    
		[self sendMobFoxCallback:mNativeCommand withSuccess:FALSE andText:@"No ad data"];
    } else {
	    NSString *msg = [NSString stringWithFormat:@"<Headline>%@|<Description>%@|<IconImageUrl>%@|<MainImageUrl>%@|<ClickUrl>%@",
    						adData.assetHeadline,
    						adData.assetDescription,
    						adData.icon.url,
    						adData.main.url,
    						adData.clickURL];

		NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxNativeAdDidLoad %@",msg);
    
    	[self sendMobFoxCallback:mNativeCommand withSuccess:TRUE andText:msg];
    }
}

//called when ad response cannot be returned
- (void)MobFoxNativeAdDidFailToReceiveAdWithError:(NSError *)error {
    
    NSLog(@"dbg: ### MobFoxCorPlugin >> MobFoxNativeAdDidFailToReceiveAdWithError >> %@",[error description]);

	[self sendMobFoxCallback:mNativeCommand withSuccess:FALSE andText:[error description]];
}

@end
