#import "iOSMobFoxPluginLibWrapper.h"
#import "iToast.h"

@implementation iOSMobFoxPluginLibWrapper

///////////////////////////////////////////////////////////////////////////////////////////////////
#pragma mark NSObject

+ (iOSMobFoxPluginLibWrapper*)sharediOSMobFoxPluginLibWrapper {
    static iOSMobFoxPluginLibWrapper *singleton;
    
    if (!singleton)
        singleton = [[iOSMobFoxPluginLibWrapper alloc] init];
    
    return singleton;
}

- (id)init {
    self = [super init];
    
    if (self) {
        self->eventContext = NULL;
    }
    
    return self;
}

- (void) dealloc {
    self->eventContext = NULL;
}

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

- (void)ShowToast:(NSString *)txt
{
    [[[[[[iToast makeText:txt]
         setGravity:iToastGravityBottom]
        setDuration:iToastDurationLong]
       setCornerRadius:0.0]
      setWithAction:TRUE] show];
}

//======================================================================================
//======  I N I T                                                                 ======
//======================================================================================

- (void)initEventContext:(FREContext)in_eventContext {
    self->eventContext = in_eventContext;
    
    mUseLocation = false;
    
    [self ShowToast:@"Plugin: init"];
}

//======================================================================================
//======  L O C A T I O N                                                         ======
//======================================================================================

- (void)setUseLocation:(BOOL)newVal
{
    mUseLocation = newVal;
    [MobFoxAd locationServicesDisabled:!mUseLocation];
}

//======================================================================================
//======  B A N N E R                                                             ======
//======================================================================================

- (void)createBanner:(NSString *)myHash at:(CGRect)placement
{
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

- (void)createInterstitial:(NSString *)myHash
{
    [MobFoxAd locationServicesDisabled:!mUseLocation];
    
    mInterstitial = [[MobFoxInterstitialAd alloc] init:myHash withRootViewController:[self vc]];
    
    mInterstitial.ad.demo_gender = @"f";
    mInterstitial.delegate = self;
    
    [mInterstitial loadAd];
    
    [self ShowToast:@"createInterstitial?"];
}

- (void)showInterstitial
{
    if (!mInterstitial){
        [self ShowToast:@"showInterstitial: not init"];
        return;
    }
    
    if (mInterstitial.ready){
        [self ShowToast:@"showInterstitial"];
        [mInterstitial show];
    }
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

- (void)createNative:(NSString *)myHash
{
    [self ShowToast:[NSString stringWithFormat:@"*** createNative: %@",myHash]];

    [MobFoxNativeAd locationServicesDisabled:!mUseLocation];
    
    mNative = [[MobFoxNativeAd alloc] init:myHash];
    
    mNative.delegate = self;
    
    mNative.invh = myHash;
    
    [mNative loadAd];
}

//======================================================================================

//called when ad response is returned
- (void)MobFoxNativeAdDidLoad:(MobFoxNativeAd *)ad withAdData:(MobFoxNativeData *)adData {
    
    NSLog(@"dbg: ### Adobe-Air Plugin >> MobFoxNativeAdDidLoad >> native loaded ###");
   
    if (adData==nil)
    {
        NSLog(@"dbg: ### Adobe-Air Plugin >> MobFoxNativeAdDidLoad >> No ad data ###");
        [self ShowToast:@"Native: MobFoxNativeAdDidLoad >> No ad data"];
        
        [self dispatchMobFoxEventWithName:@"nativeError" andData:@"No ad data"];
    } else {
        NSString *msg = [NSString stringWithFormat:@"<Headline>%@|<Description>%@|<IconImageUrl>%@|<MainImageUrl>%@|<ClickUrl>%@",
                         adData.assetHeadline,
                         adData.assetDescription,
                         adData.icon.url,
                         adData.main.url,
                         adData.clickURL];
        
        NSLog(@"dbg: ### Adobe-Air Plugin >> MobFoxNativeAdDidLoad %@",msg);
        [self ShowToast:[NSString stringWithFormat:@"Native: MobFoxNativeAdDidLoad %@",msg]];

        [self dispatchMobFoxEventWithName:@"nativeReady" andData:msg];
    }
}

//called when ad response cannot be returned
- (void)MobFoxNativeAdDidFailToReceiveAdWithError:(NSError *)error {
    
    [self ShowToast:[NSString stringWithFormat:@"ERROR: %@",[error description]]];

    NSLog(@"dbg: ### Adobe-Air Plugin >> MobFoxNativeAdDidFailToReceiveAdWithError >> %@",[error description]);
  
    [self dispatchMobFoxEventWithName:@"nativeError" andData:[error description]];
}

//################################################################################################

- (void)dispatchMobFoxEventWithName:(NSString *)eventName andData:(NSString *)eventData
{
    NSLog(@"Callback: %@ (%@)",eventName,eventData);
    
    if (eventContext == NULL)
    {
        return;
    }
    
    const uint8_t* dataCode  = (const uint8_t*) [eventData UTF8String];
    const uint8_t* eventCode = (const uint8_t*) [eventName UTF8String];
    FREDispatchStatusEventAsync(eventContext, eventCode, dataCode);
}



@end
