using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MobFoxSDKCore
{
	// @interface MFEventsHandler : NSObject
	[BaseType (typeof(NSObject))]
	interface MFEventsHandler
	{
		// -(void)resetAdEventBlocker;
		[Export ("resetAdEventBlocker")]
		void ResetAdEventBlocker ();

		// -(void)resetInterstitialEventBlocker;
		[Export ("resetInterstitialEventBlocker")]
		void ResetInterstitialEventBlocker ();

		// -(void)resetNativeEventBlocker;
		[Export ("resetNativeEventBlocker")]
		void ResetNativeEventBlocker ();

		// -(void)invokeAdEventBlocker:(void (^)(BOOL))completion;
		[Export ("invokeAdEventBlocker:")]
		void InvokeAdEventBlocker (Action<bool> completion);

		// -(void)invokeInterstitialAdEventBlocker:(void (^)(BOOL))completion;
		[Export ("invokeInterstitialAdEventBlocker:")]
		void InvokeInterstitialAdEventBlocker (Action<bool> completion);

		// -(void)invokeNativeAdEventBlocker:(void (^)(BOOL))completion;
		[Export ("invokeNativeAdEventBlocker:")]
		void InvokeNativeAdEventBlocker (Action<bool> completion);
	}

	// typedef void (^completion)(BOOL);
	delegate void completion (bool arg0);


	public interface IMFExceptionHandlerDelegate { }

	// @protocol MFExceptionHandlerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MFExceptionHandlerDelegate
	{
		// @optional -(void)MFExceptionHandlerDidReceivedException:(NSException *)exception;
		[Export ("MFExceptionHandlerDidReceivedException:")]
		void MFExceptionHandlerDidReceivedException (NSException exception);
	}

	// @interface MFExceptionHandler : NSObject
	[BaseType (typeof(NSObject))]
	interface MFExceptionHandler
	{
		[Wrap ("WeakDelegate")]
		MFExceptionHandlerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MFExceptionHandlerDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		MFExceptionHandler SharedInstance ();

		// -(void)reportOnException;
		[Export ("reportOnException")]
		void ReportOnException ();
	}

	// @interface MFLocationServicesManager : NSObject <CLLocationManagerDelegate, UIAlertViewDelegate>
	[BaseType (typeof(NSObject))]
	interface MFLocationServicesManager : ICLLocationManagerDelegate, IUIAlertViewDelegate
	{
		// @property (nonatomic) double latitude;
		[Export ("latitude")]
		double Latitude { get; set; }

		// @property (nonatomic) double longitude;
		[Export ("longitude")]
		double Longitude { get; set; }

		// @property (nonatomic) double accuracy;
		[Export ("accuracy")]
		double Accuracy { get; set; }

		// @property (nonatomic, strong) CLLocationManager * locationManager;
		[Export ("locationManager", ArgumentSemantic.Strong)]
		CLLocationManager LocationManager { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		MFLocationServicesManager SharedInstance ();

		// -(void)findLocation;
		[Export ("findLocation")]
		void FindLocation ();

		// -(void)stopFindingLocation;
		[Export ("stopFindingLocation")]
		void StopFindingLocation ();
	}

	// @interface MFReport : NSObject <NSURLConnectionDataDelegate>
	[BaseType (typeof(NSObject))]
	interface MFReport : INSUrlConnectionDataDelegate
	{
		// +(void)log:(NSString *)facility withInventoryHash:(NSString *)hash andWithMessage:(NSString *)message requestID:(NSString *)requestID;
		[Static]
		[Export ("log:withInventoryHash:andWithMessage:requestID:")]
		void Log (string facility, string hash, string message, string requestID);

		// +(void)reportOnErrorWithFacility:(NSString *)facility inventoryHash:(NSString *)hash message:(NSString *)message requestID:(NSString *)requestID;
		[Static]
		[Export ("reportOnErrorWithFacility:inventoryHash:message:requestID:")]
		void ReportOnErrorWithFacility (string facility, string hash, string message, string requestID);
	}

	// typedef void (^WVJBResponseCallback)(id);
	delegate void WVJBResponseCallback (NSObject arg0);

	// typedef void (^WVJBHandler)(id, WVJBResponseCallback);
	delegate void WVJBHandler (NSObject arg0, WVJBResponseCallback arg1);


	public interface IWebViewJavascriptBridgeBaseDelegate { }

	// @protocol WebViewJavascriptBridgeBaseDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface WebViewJavascriptBridgeBaseDelegate
	{
		// @required -(NSString *)_evaluateJavascript:(NSString *)javascriptCommand;
		[Abstract]
		[Export ("_evaluateJavascript:")]
		string _evaluateJavascript (string javascriptCommand);
	}

	// @interface WebViewJavascriptBridgeBase : NSObject
	[BaseType (typeof(NSObject))]
	interface WebViewJavascriptBridgeBase
	{
		[Wrap ("WeakDelegate")]
		WebViewJavascriptBridgeBaseDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<WebViewJavascriptBridgeBaseDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) NSMutableArray * startupMessageQueue;
		[Export ("startupMessageQueue", ArgumentSemantic.Strong)]
		NSMutableArray StartupMessageQueue { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * responseCallbacks;
		[Export ("responseCallbacks", ArgumentSemantic.Strong)]
		NSMutableDictionary ResponseCallbacks { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * messageHandlers;
		[Export ("messageHandlers", ArgumentSemantic.Strong)]
		NSMutableDictionary MessageHandlers { get; set; }

		// @property (nonatomic, strong) WVJBHandler messageHandler;
		[Export ("messageHandler", ArgumentSemantic.Strong)]
		WVJBHandler MessageHandler { get; set; }

		// +(void)enableLogging;
		[Static]
		[Export ("enableLogging")]
		void EnableLogging ();

		// +(void)setLogMaxLength:(int)length;
		[Static]
		[Export ("setLogMaxLength:")]
		void SetLogMaxLength (int length);

		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(void)sendData:(id)data responseCallback:(WVJBResponseCallback)responseCallback handlerName:(NSString *)handlerName;
		[Export ("sendData:responseCallback:handlerName:")]
		void SendData (NSObject data, WVJBResponseCallback responseCallback, string handlerName);

		// -(void)flushMessageQueue:(NSString *)messageQueueString;
		[Export ("flushMessageQueue:")]
		void FlushMessageQueue (string messageQueueString);

		// -(void)injectJavascriptFile;
		[Export ("injectJavascriptFile")]
		void InjectJavascriptFile ();

		// -(BOOL)isCorrectProcotocolScheme:(NSURL *)url;
		[Export ("isCorrectProcotocolScheme:")]
		bool IsCorrectProcotocolScheme (NSUrl url);

		// -(BOOL)isQueueMessageURL:(NSURL *)urll;
		[Export ("isQueueMessageURL:")]
		bool IsQueueMessageURL (NSUrl urll);

		// -(BOOL)isBridgeLoadedURL:(NSURL *)urll;
		[Export ("isBridgeLoadedURL:")]
		bool IsBridgeLoadedURL (NSUrl urll);

		// -(void)logUnkownMessage:(NSURL *)url;
		[Export ("logUnkownMessage:")]
		void LogUnkownMessage (NSUrl url);

		// -(NSString *)webViewJavascriptCheckCommand;
		[Export ("webViewJavascriptCheckCommand")]
		//@@@[Verify (MethodToProperty)]
		string WebViewJavascriptCheckCommand { get; }

		// -(NSString *)webViewJavascriptFetchQueyCommand;
		[Export ("webViewJavascriptFetchQueyCommand")]
		//@@@[Verify (MethodToProperty)]
		string WebViewJavascriptFetchQueyCommand { get; }

		// -(void)disableJavscriptAlertBoxSafetyTimeout;
		[Export ("disableJavscriptAlertBoxSafetyTimeout")]
		void DisableJavscriptAlertBoxSafetyTimeout ();
	}

	// @interface MFWebViewJavascriptBridge : NSObject <UIWebViewDelegate, WebViewJavascriptBridgeBaseDelegate>
	[BaseType (typeof(NSObject))]
	interface MFWebViewJavascriptBridge : IUIWebViewDelegate, IWebViewJavascriptBridgeBaseDelegate
	{
		// +(instancetype)bridgeForWebView:(UIWebView *)webView;
		[Static]
		[Export ("bridgeForWebView:")]
		MFWebViewJavascriptBridge BridgeForWebView (UIWebView webView);

		// +(void)enableLogging;
		[Static]
		[Export ("enableLogging")]
		void EnableLogging ();

		// +(void)setLogMaxLength:(int)length;
		[Static]
		[Export ("setLogMaxLength:")]
		void SetLogMaxLength (int length);

		// -(void)registerHandler:(NSString *)handlerName handler:(WVJBHandler)handler;
		[Export ("registerHandler:handler:")]
		void RegisterHandler (string handlerName, WVJBHandler handler);

		// -(void)callHandler:(NSString *)handlerName;
		[Export ("callHandler:")]
		void CallHandler (string handlerName);

		// -(void)callHandler:(NSString *)handlerName data:(id)data;
		[Export ("callHandler:data:")]
		void CallHandler (string handlerName, NSObject data);

		// -(void)callHandler:(NSString *)handlerName data:(id)data responseCallback:(WVJBResponseCallback)responseCallback;
		[Export ("callHandler:data:responseCallback:")]
		void CallHandler (string handlerName, NSObject data, WVJBResponseCallback responseCallback);

		// -(void)setWebViewDelegate:(NSObject<UIWebViewDelegate> *)webViewDelegate;
		[Export ("setWebViewDelegate:")]
		void SetWebViewDelegate (UIWebViewDelegate webViewDelegate);

		// -(void)disableJavscriptAlertBoxSafetyTimeout;
		[Export ("disableJavscriptAlertBoxSafetyTimeout")]
		void DisableJavscriptAlertBoxSafetyTimeout ();
	}


	public interface IMobFoxCustomEventDelegate { }

	// @protocol MobFoxCustomEventDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MobFoxCustomEventDelegate
	{
		// @required -(void)MFCustomEventAd:(MobFoxCustomEvent *)event didLoad:(UIView *)ad;
		[Abstract]
		[Export ("MFCustomEventAd:didLoad:")]
		void MFCustomEventAd (MobFoxCustomEvent @event, UIView ad);

		// @required -(void)MFCustomEventAdDidFailToReceiveAdWithError:(NSError *)error;
		[Abstract]
		[Export ("MFCustomEventAdDidFailToReceiveAdWithError:")]
		void MFCustomEventAdDidFailToReceiveAdWithError (NSError error);

		// @optional -(void)MFCustomEventAdClosed;
		[Export ("MFCustomEventAdClosed")]
		void MFCustomEventAdClosed ();

		// @optional -(void)MFCustomEventMobFoxAdClicked;
		[Export ("MFCustomEventMobFoxAdClicked")]
		void MFCustomEventMobFoxAdClicked ();

		// @optional -(void)MFCustomEventMobFoxAdFinished;
		[Export ("MFCustomEventMobFoxAdFinished")]
		void MFCustomEventMobFoxAdFinished ();
	}

	// @interface MobFoxCustomEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface MobFoxCustomEvent
	{
		// -(void)requestAdWithSize:(CGSize)size networkID:(NSString *)nid customEventInfo:(NSDictionary *)info;
		[Export ("requestAdWithSize:networkID:customEventInfo:")]
		void RequestAdWithSize (CGSize size, string nid, NSDictionary info);

		[Wrap ("WeakDelegate")]
		MobFoxCustomEventDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MobFoxCustomEventDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}


	public interface IMobFoxAdDelegate { }

	// @protocol MobFoxAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MobFoxAdDelegate
	{
		// @optional -(void)MobFoxAdDidLoad:(MobFoxAd *)banner;
		[Export ("MobFoxAdDidLoad:")]
		void MobFoxAdDidLoad (MobFoxAd banner);

		// @optional -(void)MobFoxAdDidFailToReceiveAdWithError:(NSError *)error;
		[Export ("MobFoxAdDidFailToReceiveAdWithError:")]
		void MobFoxAdDidFailToReceiveAdWithError (NSError error);

		// @optional -(void)MobFoxAdClosed;
		[Export ("MobFoxAdClosed")]
		void MobFoxAdClosed ();

		// @optional -(void)MobFoxAdClicked;
		[Export ("MobFoxAdClicked")]
		void MobFoxAdClicked ();

		// @optional -(void)MobFoxAdFinished;
		[Export ("MobFoxAdFinished")]
		void MobFoxAdFinished ();

		// @optional -(void)MobFoxDelegateCustomEvents:(NSArray *)events withAdDict:(NSDictionary *)adDict;
		[Export ("MobFoxDelegateCustomEvents:withAdDict:")]
		//@@@[Verify (StronglyTypedNSArray)]
		void MobFoxDelegateCustomEvents (NSObject[] events, NSDictionary adDict);
	}

	// @interface MobFoxAd : UIView <UIWebViewDelegate, MobFoxCustomEventDelegate, UIGestureRecognizerDelegate, MFExceptionHandlerDelegate>
	[BaseType (typeof(UIView))]
	interface MobFoxAd : IUIWebViewDelegate, IMobFoxCustomEventDelegate, IUIGestureRecognizerDelegate, IMFExceptionHandlerDelegate
	{
		[Wrap ("WeakDelegate")]
		MobFoxAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MobFoxAdDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) MFWebViewJavascriptBridge * bridge;
		[Export ("bridge", ArgumentSemantic.Strong)]
		MFWebViewJavascriptBridge Bridge { get; set; }

		// @property (nonatomic, strong) MFLocationServicesManager * locationServicesManager;
		[Export ("locationServicesManager", ArgumentSemantic.Strong)]
		MFLocationServicesManager LocationServicesManager { get; set; }

		// @property (nonatomic) MFWebViewJavascriptBridge * brg;
		[Export ("brg", ArgumentSemantic.Assign)]
		MFWebViewJavascriptBridge Brg { get; set; }

		// @property (nonatomic) WebViewJavascriptBridgeBase * base;
		[Export ("base", ArgumentSemantic.Assign)]
		WebViewJavascriptBridgeBase Base { get; set; }

		// @property (copy, nonatomic) NSString * position;
		[Export ("position")]
		string Position { get; set; }

		// @property (copy, nonatomic) NSString * longitude;
		[Export ("longitude")]
		string Longitude { get; set; }

		// @property (copy, nonatomic) NSString * latitude;
		[Export ("latitude")]
		string Latitude { get; set; }

		// @property (copy, nonatomic) NSString * accuracy;
		[Export ("accuracy")]
		string Accuracy { get; set; }

		// @property (copy, nonatomic) NSString * demo_gender;
		[Export ("demo_gender")]
		string Demo_gender { get; set; }

		// @property (copy, nonatomic) NSString * demo_age;
		[Export ("demo_age")]
		string Demo_age { get; set; }

		// @property (copy, nonatomic) NSString * s_subid;
		[Export ("s_subid")]
		string S_subid { get; set; }

		// @property (copy, nonatomic) NSString * sub_name;
		[Export ("sub_name")]
		string Sub_name { get; set; }

		// @property (copy, nonatomic) NSString * sub_domain;
		[Export ("sub_domain")]
		string Sub_domain { get; set; }

		// @property (copy, nonatomic) NSString * sub_storeurl;
		[Export ("sub_storeurl")]
		string Sub_storeurl { get; set; }

		// @property (copy, nonatomic) NSString * r_floor;
		[Export ("r_floor")]
		string R_floor { get; set; }

		// @property (copy, nonatomic) NSString * type;
		[Export ("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSString * adFormat;
		[Export ("adFormat")]
		string AdFormat { get; set; }

		// @property (copy, nonatomic) NSNumber * adspace_width;
		[Export ("adspace_width", ArgumentSemantic.Copy)]
		NSNumber Adspace_width { get; set; }

		// @property (copy, nonatomic) NSNumber * adspace_height;
		[Export ("adspace_height", ArgumentSemantic.Copy)]
		NSNumber Adspace_height { get; set; }

		// @property (copy, nonatomic) NSNumber * v_dur_min;
		[Export ("v_dur_min", ArgumentSemantic.Copy)]
		NSNumber V_dur_min { get; set; }

		// @property (copy, nonatomic) NSNumber * v_dur_max;
		[Export ("v_dur_max", ArgumentSemantic.Copy)]
		NSNumber V_dur_max { get; set; }

		// @property (nonatomic, strong) NSString * invh;
		[Export ("invh", ArgumentSemantic.Strong)]
		string Invh { get; set; }

		// @property (nonatomic, strong) NSNumber * refresh;
		[Export ("refresh", ArgumentSemantic.Strong)]
		NSNumber Refresh { get; set; }

		// @property (assign, nonatomic) BOOL autoplay;
		[Export ("autoplay")]
		bool Autoplay { get; set; }

		// @property (assign, nonatomic) BOOL skip;
		[Export ("skip")]
		bool Skip { get; set; }

		// @property (assign, nonatomic) BOOL no_markup;
		[Export ("no_markup")]
		bool No_markup { get; set; }

		// @property (getter = isUnitTesting, assign, nonatomic) BOOL unit_testing;
		[Export ("unit_testing")]
		bool Unit_testing { [Bind ("isUnitTesting")] get; set; }

		// @property (getter = isDelegateCustomEvents, assign, nonatomic) BOOL delegateCustomEvents;
		[Export ("delegateCustomEvents")]
		bool DelegateCustomEvents { [Bind ("isDelegateCustomEvents")] get; set; }

		// @property (getter = isAdspace_strict, assign, nonatomic) BOOL adspace_strict;
		[Export ("adspace_strict")]
		bool Adspace_strict { [Bind ("isAdspace_strict")] get; set; }

		// -(id)init:(NSString *)invh;
		[Export ("init:")]
		IntPtr Constructor (string invh);

		// -(id)init:(NSString *)invh withFrame:(CGRect)aRect;
		[Export ("init:withFrame:")]
		IntPtr Constructor (string invh, CGRect aRect);

		// -(void)loadAd;
		[Export ("loadAd")]
		void LoadAd ();

		// -(void)webViewDidStartLoad:(UIWebView *)webView;
		[Export ("webViewDidStartLoad:")]
		void WebViewDidStartLoad (UIWebView webView);

		// -(void)webViewDidFinishLoad:(UIWebView *)webView;
		[Export ("webViewDidFinishLoad:")]
		void WebViewDidFinishLoad (UIWebView webView);

		// -(void)webViewdidFailLoadWithError:(NSError *)error;
		[Export ("webViewdidFailLoadWithError:")]
		void WebViewdidFailLoadWithError (NSError error);

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)resume;
		[Export ("resume")]
		void Resume ();

		// +(void)locationServicesDisabled:(BOOL)disabled;
		[Static]
		[Export ("locationServicesDisabled:")]
		void LocationServicesDisabled (bool disabled);

		// -(void)renderAd:(NSDictionary *)adDict withCB:(void (^)(id))cb;
		[Export ("renderAd:withCB:")]
		void RenderAd (NSDictionary adDict, Action<NSObject> cb);

		// -(BOOL)isViewVisible;
		[Export ("isViewVisible")]
		//@@@[Verify (MethodToProperty)]
		bool IsViewVisible { get; }

		// -(void)_changeWidth:(float)newWidth;
		[Export ("_changeWidth:")]
		void _changeWidth (float newWidth);

		// -(void)_setSize:(CGSize)size withContainer:(CGSize)container;
		[Export ("_setSize:withContainer:")]
		void _setSize (CGSize size, CGSize container);

		// -(void)_setFrame:(CGRect)aRect;
		[Export ("_setFrame:")]
		void _setFrame (CGRect aRect);
	}


	public interface IMobFoxInterstitialCustomEventDelegate { }

	// @protocol MobFoxInterstitialCustomEventDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MobFoxInterstitialCustomEventDelegate
	{
		// @required -(void)MFInterstitialCustomEventAdDidLoad:(MobFoxInterstitialCustomEvent *)event;
		[Abstract]
		[Export ("MFInterstitialCustomEventAdDidLoad:")]
		void MFInterstitialCustomEventAdDidLoad (MobFoxInterstitialCustomEvent @event);

		// @required -(void)MFInterstitialCustomEventAdDidFailToReceiveAdWithError:(NSError *)error;
		[Abstract]
		[Export ("MFInterstitialCustomEventAdDidFailToReceiveAdWithError:")]
		void MFInterstitialCustomEventAdDidFailToReceiveAdWithError (NSError error);

		// @required -(void)MFInterstitialCustomEventAdClosed;
		[Abstract]
		[Export ("MFInterstitialCustomEventAdClosed")]
		void MFInterstitialCustomEventAdClosed ();

		// @required -(void)MFInterstitialCustomEventMobFoxAdClicked;
		[Abstract]
		[Export ("MFInterstitialCustomEventMobFoxAdClicked")]
		void MFInterstitialCustomEventMobFoxAdClicked ();

		// @required -(void)MFInterstitialCustomEventMobFoxAdFinished;
		[Abstract]
		[Export ("MFInterstitialCustomEventMobFoxAdFinished")]
		void MFInterstitialCustomEventMobFoxAdFinished ();
	}

	// @interface MobFoxInterstitialCustomEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface MobFoxInterstitialCustomEvent
	{
		// -(void)requestInterstitialWithNetworkId:(NSString *)networkId customEventInfo:(NSDictionary *)info;
		[Export ("requestInterstitialWithNetworkId:customEventInfo:")]
		void RequestInterstitialWithNetworkId (string networkId, NSDictionary info);

		// -(void)presentWithRootController:(UIViewController *)rootViewController;
		[Export ("presentWithRootController:")]
		void PresentWithRootController (UIViewController rootViewController);

		[Wrap ("WeakDelegate")]
		MobFoxInterstitialCustomEventDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MobFoxInterstitialCustomEventDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}


	public interface IMobFoxInterstitialAdDelegate { }

	// @protocol MobFoxInterstitialAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MobFoxInterstitialAdDelegate
	{
		// @required -(void)MobFoxInterstitialAdDidLoad:(MobFoxInterstitialAd *)interstitial;
		[Abstract]
		[Export ("MobFoxInterstitialAdDidLoad:")]
		void MobFoxInterstitialAdDidLoad (MobFoxInterstitialAd interstitial);

		// @optional -(void)MobFoxInterstitialAdDidFailToReceiveAdWithError:(NSError *)error;
		[Export ("MobFoxInterstitialAdDidFailToReceiveAdWithError:")]
		void MobFoxInterstitialAdDidFailToReceiveAdWithError (NSError error);

		// @optional -(void)MobFoxInterstitialAdWillShow:(MobFoxInterstitialAd *)interstitial;
		[Export ("MobFoxInterstitialAdWillShow:")]
		void MobFoxInterstitialAdWillShow (MobFoxInterstitialAd interstitial);

		// @optional -(void)MobFoxInterstitialAdClosed;
		[Export ("MobFoxInterstitialAdClosed")]
		void MobFoxInterstitialAdClosed ();

		// @optional -(void)MobFoxInterstitialAdClicked;
		[Export ("MobFoxInterstitialAdClicked")]
		void MobFoxInterstitialAdClicked ();

		// @optional -(void)MobFoxInterstitialAdFinished;
		[Export ("MobFoxInterstitialAdFinished")]
		void MobFoxInterstitialAdFinished ();
	}

	// @interface MobFoxInterstitialAd : NSObject <MobFoxAdDelegate, MobFoxInterstitialCustomEventDelegate, NSURLSessionDelegate, NSURLSessionDataDelegate, NSURLSessionTaskDelegate>
	[BaseType (typeof(NSObject))]
	interface MobFoxInterstitialAd : IMobFoxAdDelegate, IMobFoxInterstitialCustomEventDelegate, INSUrlSessionDelegate, INSUrlSessionDataDelegate, INSUrlSessionTaskDelegate
	{
		[Wrap ("WeakDelegate")]
		MobFoxInterstitialAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MobFoxInterstitialAdDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) UIViewController * rootViewController;
		[Export ("rootViewController", ArgumentSemantic.Weak)]
		UIViewController RootViewController { get; set; }

		// @property BOOL ready;
		[Export ("ready")]
		bool Ready { get; set; }

		// @property (nonatomic, strong) MFLocationServicesManager * locationServicesManager;
		[Export ("locationServicesManager", ArgumentSemantic.Strong)]
		MFLocationServicesManager LocationServicesManager { get; set; }

		// -(id)init:(NSString *)invh;
		[Export ("init:")]
		IntPtr Constructor (string invh);

		// -(id)init:(NSString *)invh withRootViewController:(UIViewController *)root;
		[Export ("init:withRootViewController:")]
		IntPtr Constructor (string invh, UIViewController root);

		// -(void)loadAd;
		[Export ("loadAd")]
		void LoadAd ();

		// -(void)show;
		[Export ("show")]
		void Show ();

		// +(void)locationServicesDisabled:(BOOL)disabled;
		[Static]
		[Export ("locationServicesDisabled:")]
		void LocationServicesDisabled (bool disabled);

		// -(void)dismissAd;
		[Export ("dismissAd")]
		void DismissAd ();

		// @property (nonatomic, strong) NSString * invh;
		[Export ("invh", ArgumentSemantic.Strong)]
		string Invh { get; set; }

		// @property (copy, nonatomic) NSString * longitude;
		[Export ("longitude")]
		string Longitude { get; set; }

		// @property (copy, nonatomic) NSString * latitude;
		[Export ("latitude")]
		string Latitude { get; set; }

		// @property (copy, nonatomic) NSString * demo_gender;
		[Export ("demo_gender")]
		string Demo_gender { get; set; }

		// @property (copy, nonatomic) NSString * demo_age;
		[Export ("demo_age")]
		string Demo_age { get; set; }

		// @property (copy, nonatomic) NSString * s_subid;
		[Export ("s_subid")]
		string S_subid { get; set; }

		// @property (copy, nonatomic) NSString * sub_name;
		[Export ("sub_name")]
		string Sub_name { get; set; }

		// @property (copy, nonatomic) NSString * sub_domain;
		[Export ("sub_domain")]
		string Sub_domain { get; set; }

		// @property (copy, nonatomic) NSString * sub_storeurl;
		[Export ("sub_storeurl")]
		string Sub_storeurl { get; set; }

		// @property (copy, nonatomic) NSString * r_floor;
		[Export ("r_floor")]
		string R_floor { get; set; }

		// @property (copy, nonatomic) NSNumber * v_dur_min;
		[Export ("v_dur_min", ArgumentSemantic.Copy)]
		NSNumber V_dur_min { get; set; }

		// @property (copy, nonatomic) NSNumber * v_dur_max;
		[Export ("v_dur_max", ArgumentSemantic.Copy)]
		NSNumber V_dur_max { get; set; }

		// @property (assign, nonatomic) BOOL autoplay;
		[Export ("autoplay")]
		bool Autoplay { get; set; }
	}

	// @interface MobFoxNativeTracker : NSObject
	[BaseType (typeof(NSObject))]
	interface MobFoxNativeTracker
	{
		// @property (copy, nonatomic) NSString * type;
		[Export ("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSURL * url;
		[Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// -(instancetype)initWithURL:(NSURL *)url type:(NSString *)type;
		[Export ("initWithURL:type:")]
		IntPtr Constructor (NSUrl url, string type);
	}

	// @interface MobFoxNativeImage : NSObject
	[BaseType (typeof(NSObject))]
	interface MobFoxNativeImage
	{
		// @property (copy, nonatomic) NSURL * url;
		[Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// @property (copy, nonatomic) NSNumber * width;
		[Export ("width", ArgumentSemantic.Copy)]
		NSNumber Width { get; set; }

		// @property (copy, nonatomic) NSNumber * height;
		[Export ("height", ArgumentSemantic.Copy)]
		NSNumber Height { get; set; }

		// -(instancetype)initWithURL:(NSURL *)url width:(NSNumber *)width height:(NSNumber *)height;
		[Export ("initWithURL:width:height:")]
		IntPtr Constructor (NSUrl url, NSNumber width, NSNumber height);
	}

	// @interface MobFoxNativeData : NSObject
	[BaseType (typeof(NSObject))]
	interface MobFoxNativeData
	{
		// @property (nonatomic, strong) MobFoxNativeImage * icon;
		[Export ("icon", ArgumentSemantic.Strong)]
		MobFoxNativeImage Icon { get; set; }

		// @property (nonatomic, strong) MobFoxNativeImage * main;
		[Export ("main", ArgumentSemantic.Strong)]
		MobFoxNativeImage Main { get; set; }

		// @property (copy, nonatomic) NSString * assetHeadline;
		[Export ("assetHeadline")]
		string AssetHeadline { get; set; }

		// @property (copy, nonatomic) NSString * assetDescription;
		[Export ("assetDescription")]
		string AssetDescription { get; set; }

		// @property (copy, nonatomic) NSString * callToActionText;
		[Export ("callToActionText")]
		string CallToActionText { get; set; }

		// @property (copy, nonatomic) NSString * sponsored;
		[Export ("sponsored")]
		string Sponsored { get; set; }

		// @property (copy, nonatomic) NSString * advertiserName;
		[Export ("advertiserName")]
		string AdvertiserName { get; set; }

		// @property (copy, nonatomic) NSString * socialContext;
		[Export ("socialContext")]
		string SocialContext { get; set; }

		// @property (copy, nonatomic) NSNumber * rating;
		[Export ("rating", ArgumentSemantic.Copy)]
		NSNumber Rating { get; set; }

		// @property (copy, nonatomic) NSURL * clickURL;
		[Export ("clickURL", ArgumentSemantic.Copy)]
		NSUrl ClickURL { get; set; }

		// @property (nonatomic, strong) NSMutableArray * trackersArray;
		[Export ("trackersArray", ArgumentSemantic.Strong)]
		NSMutableArray TrackersArray { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dictionary);
	}


	public interface IMobFoxNativeCustomEventDelegate { }

	// @protocol MobFoxNativeCustomEventDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MobFoxNativeCustomEventDelegate
	{
		// @required -(void)MFNativeCustomEventAd:(MobFoxNativeCustomEvent *)event didLoad:(MobFoxNativeData *)adData;
		[Abstract]
		[Export ("MFNativeCustomEventAd:didLoad:")]
		void MFNativeCustomEventAd (MobFoxNativeCustomEvent @event, MobFoxNativeData adData);

		// @required -(void)MFNativeCustomEventAdDidFailToReceiveAdWithError:(NSError *)error;
		[Abstract]
		[Export ("MFNativeCustomEventAdDidFailToReceiveAdWithError:")]
		void MFNativeCustomEventAdDidFailToReceiveAdWithError (NSError error);
	}

	// @interface MobFoxNativeCustomEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface MobFoxNativeCustomEvent
	{
		// -(void)registerViewWithInteraction:(UIView *)view withViewController:(UIViewController *)viewController;
		[Export ("registerViewWithInteraction:withViewController:")]
		void RegisterViewWithInteraction (UIView view, UIViewController viewController);

		// -(void)requestAdWithNetworkID:(NSString *)nid customEventInfo:(NSDictionary *)info;
		[Export ("requestAdWithNetworkID:customEventInfo:")]
		void RequestAdWithNetworkID (string nid, NSDictionary info);

		[Wrap ("WeakDelegate")]
		MobFoxNativeCustomEventDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MobFoxNativeCustomEventDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}


	public interface IMobFoxNativeAdDelegate { }

	// @protocol MobFoxNativeAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MobFoxNativeAdDelegate
	{
		// @required -(void)MobFoxNativeAdDidLoad:(MobFoxNativeAd *)ad withAdData:(MobFoxNativeData *)adData;
		[Abstract]
		[Export ("MobFoxNativeAdDidLoad:withAdData:")]
		void MobFoxNativeAdDidLoad (MobFoxNativeAd ad, MobFoxNativeData adData);

		// @optional -(void)MobFoxNativeAdDidFailToReceiveAdWithError:(NSError *)error;
		[Export ("MobFoxNativeAdDidFailToReceiveAdWithError:")]
		void MobFoxNativeAdDidFailToReceiveAdWithError (NSError error);
	}

	// @interface MobFoxNativeAd : NSObject <MobFoxNativeCustomEventDelegate>
	[BaseType (typeof(NSObject))]
	interface MobFoxNativeAd : IMobFoxNativeCustomEventDelegate
	{
		[Wrap ("WeakDelegate")]
		MobFoxNativeAdDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MobFoxNativeAdDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) NSString * longitude;
		[Export ("longitude")]
		string Longitude { get; set; }

		// @property (copy, nonatomic) NSString * latitude;
		[Export ("latitude")]
		string Latitude { get; set; }

		// @property (copy, nonatomic) NSString * accuracy;
		[Export ("accuracy")]
		string Accuracy { get; set; }

		// @property (copy, nonatomic) NSString * demo_gender;
		[Export ("demo_gender")]
		string Demo_gender { get; set; }

		// @property (copy, nonatomic) NSString * demo_age;
		[Export ("demo_age")]
		string Demo_age { get; set; }

		// @property (copy, nonatomic) NSString * s_subid;
		[Export ("s_subid")]
		string S_subid { get; set; }

		// @property (copy, nonatomic) NSString * sub_name;
		[Export ("sub_name")]
		string Sub_name { get; set; }

		// @property (copy, nonatomic) NSString * sub_domain;
		[Export ("sub_domain")]
		string Sub_domain { get; set; }

		// @property (copy, nonatomic) NSString * sub_storeurl;
		[Export ("sub_storeurl")]
		string Sub_storeurl { get; set; }

		// @property (copy, nonatomic) NSString * v_dur_min;
		[Export ("v_dur_min")]
		string V_dur_min { get; set; }

		// @property (copy, nonatomic) NSString * v_dur_max;
		[Export ("v_dur_max")]
		string V_dur_max { get; set; }

		// @property (copy, nonatomic) NSString * r_floor;
		[Export ("r_floor")]
		string R_floor { get; set; }

		// @property (nonatomic, strong) NSString * invh;
		[Export ("invh", ArgumentSemantic.Strong)]
		string Invh { get; set; }

		// @property (nonatomic, strong) NSString * serverURL;
		[Export ("serverURL", ArgumentSemantic.Strong)]
		string ServerURL { get; set; }

		// -(id)init:(NSString *)invh;
		[Export ("init:")]
		IntPtr Constructor (string invh);

		// -(void)loadAd;
		[Export ("loadAd")]
		void LoadAd ();

		// -(void)registerViewWithInteraction:(UIView *)view withViewController:(UIViewController *)viewController;
		[Export ("registerViewWithInteraction:withViewController:")]
		void RegisterViewWithInteraction (UIView view, UIViewController viewController);

		// +(void)locationServicesDisabled:(BOOL)disabled;
		[Static]
		[Export ("locationServicesDisabled:")]
		void LocationServicesDisabled (bool disabled);
	}
}
