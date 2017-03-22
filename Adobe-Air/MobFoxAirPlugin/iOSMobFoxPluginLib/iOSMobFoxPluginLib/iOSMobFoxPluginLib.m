#import <UIKit/UIKit.h>
#import "FlashRuntimeExtensions.h"
#import "iOSMobFoxPluginLibWrapper.h"
#import "iToast.h"

//========================================================================================

FREObject init(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] initEventContext: ctx];

    return NULL;
}

FREObject showToastText(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    uint32_t string1Length;
    const uint8_t *string1;
    FREGetObjectAsUTF8(argv[0], &string1Length, &string1);
    
    // Convert C strings to Obj-C strings
    NSString *string1ObjC = [NSString stringWithUTF8String:(char*)string1];

    [[[[[[iToast makeText:string1ObjC]
         setGravity:iToastGravityBottom]
        setDuration:iToastDurationLong]
       setCornerRadius:0.0]
      setWithAction:TRUE] show];

    return NULL;
}

FREObject createBanner(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    NSString *myHash = nil;
    int      in_x    = 0;
    int      in_y    = 0;
    int      in_w    = 0;
    int      in_h    = 0;

    if (argc>0)
    {
        uint32_t myHash8Length;
        const uint8_t *myHash8;
        FREGetObjectAsUTF8(argv[0], &myHash8Length, &myHash8);
        myHash = [NSString stringWithUTF8String:(char*)myHash8];
    }

    if (argc>1) FREGetObjectAsInt32(argv[1], &in_x);
    if (argc>2) FREGetObjectAsInt32(argv[2], &in_y);
    if (argc>3) FREGetObjectAsInt32(argv[3], &in_w);
    if (argc>4) FREGetObjectAsInt32(argv[4], &in_h);

    if (myHash!=nil)
    {
        CGFloat originX    = (CGFloat)in_x;
        CGFloat originY    = (CGFloat)in_y;
        CGFloat sizeWidth  = (CGFloat)in_w;
        CGFloat sizeHeight = (CGFloat)in_h;
        
        NSLog(@"dbg: ### MobFoxUnityPlugin >> createBanner(%@)",myHash);
        
        NSLog(@"dbg: ### MobFoxUnityPlugin >> rect x: %f", originX);
        NSLog(@"dbg: ### MobFoxUnityPlugin >> rect y: %f", originY);
        NSLog(@"dbg: ### MobFoxUnityPlugin >> rect width: %f", sizeWidth);
        NSLog(@"dbg: ### MobFoxUnityPlugin >> rect height: %f", sizeHeight);
        
        CGRect placement = CGRectMake(originX,originY,sizeWidth,sizeHeight);
        
        [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] createBanner:myHash at:placement];
    }
    
    return NULL;
}

FREObject hideBanner(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    NSLog(@"dbg: ### MobFoxUnityPlugin >> hideBanner");
    
    [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] hideBanner];
    
    return NULL;
}

FREObject unhideBanner(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    NSLog(@"dbg: ### MobFoxUnityPlugin >> unhideBanner");
    
    [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] unhideBanner];
    
    return NULL;
}

FREObject createInterstitial(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    NSString *myHash = nil;
    
    if (argc>0)
    {
        uint32_t myHash8Length;
        const uint8_t *myHash8;
        FREGetObjectAsUTF8(argv[0], &myHash8Length, &myHash8);
        myHash = [NSString stringWithUTF8String:(char*)myHash8];
    }
    
    if (myHash!=nil)
    {
        NSLog(@"dbg: ### MobFoxUnityPlugin >> createInterstitial(%@)",myHash);
        
        [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] createInterstitial:myHash];
    }
    
    return NULL;
}

FREObject showInterstitial(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    NSLog(@"dbg: ### MobFoxUnityPlugin >> showInterstitial");

    [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] showInterstitial];
    
    return NULL;
}

FREObject setUseLocation(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    uint32_t bUseLocation;
    
    if (argc>0)
    {
        FREGetObjectAsBool(argv[0], &bUseLocation);

        [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] setUseLocation:bUseLocation];
    } else {
        [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] setUseLocation:false];
    }
    
    return NULL;
}

FREObject createNative(FREContext ctx, void* funcData, uint32_t argc, FREObject argv[])
{
    NSString *myHash = nil;
    
    if (argc>0)
    {
        uint32_t myHash8Length;
        const uint8_t *myHash8;
        FREGetObjectAsUTF8(argv[0], &myHash8Length, &myHash8);
        myHash = [NSString stringWithUTF8String:(char*)myHash8];
    }
    
    if (myHash!=nil)
    {
        NSLog(@"dbg: ### MobFoxUnityPlugin >> createNative(%@)",myHash);
        
        [[iOSMobFoxPluginLibWrapper sharediOSMobFoxPluginLibWrapper] createNative:myHash];
    } else {
        [[[[[[iToast makeText:@"dbg: ### ERROR: No Param... ###"]
             setGravity:iToastGravityBottom]
            setDuration:iToastDurationLong]
           setCornerRadius:0.0]
          setWithAction:TRUE] show];
    }
    
    return NULL;
}

//################################################################################################

void PluginExtContextInitializer(void* extData, const uint8_t* ctxType, FREContext ctx, uint32_t* numFunctionsToTest, const FRENamedFunction** functionsToSet)
{
    *numFunctionsToTest = 7;
    
    FRENamedFunction* func = (FRENamedFunction*) malloc(sizeof(FRENamedFunction) * *numFunctionsToTest);
    
    func[0].name = (const uint8_t*) "init";
    func[0].functionData = NULL;
    func[0].function = &init;
    
    func[1].name = (const uint8_t*) "showToastText";
    func[1].functionData = NULL;
    func[1].function = &showToastText;
    
    func[2].name = (const uint8_t*) "createBanner";
    func[2].functionData = NULL;
    func[2].function = &createBanner;
    
    func[3].name = (const uint8_t*) "hideBanner";
    func[3].functionData = NULL;
    func[3].function = &hideBanner;
    
    func[4].name = (const uint8_t*) "unhideBanner";
    func[4].functionData = NULL;
    func[4].function = &unhideBanner;
    
    func[5].name = (const uint8_t*) "createInterstitial";
    func[5].functionData = NULL;
    func[5].function = &createInterstitial;
    
    func[6].name = (const uint8_t*) "showInterstitial";
    func[6].functionData = NULL;
    func[6].function = &showInterstitial;
    
    func[7].name = (const uint8_t*) "setUseLocation";
    func[7].functionData = NULL;
    func[7].function = &setUseLocation;
    
    func[8].name = (const uint8_t*) "createNative";
    func[8].functionData = NULL;
    func[8].function = &createNative;
    
    *functionsToSet = func;
}

void MobFoxPluginExtensionInitializer(void** extDataToSet, FREContextInitializer* ctxInitializerToSet, FREContextFinalizer* ctxFinalizerToSet)
{
    *extDataToSet = NULL;
    *ctxInitializerToSet = &PluginExtContextInitializer;
}

