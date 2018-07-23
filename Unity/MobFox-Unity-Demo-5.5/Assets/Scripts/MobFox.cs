#define OLD

#if !OLD
using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using System;

public class MobFox :MonoBehaviour
{
#if UNITY_IPHONE
[DllImport ( "__Internal" )]
public static extern void _setUseLocation (bool useLocation);

[DllImport ( "__Internal" )]
public static extern int _createBanner (string invh, float originX, float originY, float sizeWidth, float sizeHeight);

[DllImport ( "__Internal" )]
public static extern void _hideBanner ();

[DllImport ( "__Internal" )]
public static extern void _showBanner ();

[DllImport ( "__Internal" )]
public static extern void _setGameObject (string gameObject);

[DllImport ( "__Internal" )]
public static extern void _createInterstitial (string invh);

[DllImport ( "__Internal" )]
public static extern void _showInterstitial ();

[DllImport ( "__Internal" )]
public static extern void _createNative (string invh);
#endif

//private string MobFoxBannerInventoryHash = "fe96717d9875b9da4339ea5367eff1ec";
//private string MobFoxInterstitialInventoryHash = "267d72ac3f77a3f447b32cf7ebf20673";
//private string MobFoxNativeInventoryHash = "a764347547748896b84e0b8ccd90fd62";//"80187188f458cfde788d961b6882fd53";
//private int top = 30;
//private int left = 5;
//private int width = 320;
//private int height = 50;
//	private bool smart 								= false;
private const string MobFoxGameObjectName = "MobFoxObject";


bool bInterstitialReady = false;

#if UNITY_ANDROID
private AndroidJavaObject mobFoxPlugin = null;
private AndroidJavaObject activityContext = null;
#endif

public static Action
OnSdkReady,
OnBannerReady,
OnBannerClosed,
OnBannerClicked,
OnBannerFinished,
OnInterstitialReady,
OnInterstitialClosed,
OnInterstitialClicked,
OnInterstitialFinished;
public static Action<string>
OnBannerError,
OnInterstitalError;

private static MobFox instance;

public static MobFox Instance
{
	get
	{
		CreateSingletone ( );
		return instance;
	}
}

private static bool
debug_mode = true;

//======================================================================================
//======  I N I T                                                                 ======
//======================================================================================

public static void CreateSingletone ()
{
	if (instance == null)
	{
		GameObject e_man = new GameObject ( MobFoxGameObjectName );
		e_man.AddComponent<MobFox> ( );
	}
}


static void SetInstance (MobFox _instance)
{
	if (instance == null)
	{
		LogMessage ( "creating Instance" );
		instance = _instance;
		DontDestroyOnLoad ( instance.gameObject );
		instance.ConnectToPlugin ( );
	}
}

void Awake ()
{
	SetInstance ( this );
	if (instance == this)
	{
		ConnectToPlugin ( );
	}
	else
	{
		LogMessage ( "not allowed multiple instances", true );
		Destroy ( gameObject );
	}
}


void ConnectToPlugin ()
{
#if UNITY_ANDROID
	if (Application.platform == RuntimePlatform.Android)
	{
		if (mobFoxPlugin == null)
		{
			using (AndroidJavaClass activityClass = new AndroidJavaClass ( "com.unity3d.player.UnityPlayer" ))
			{
				activityContext = activityClass.GetStatic<AndroidJavaObject> ( "currentActivity" );
			}

			using (AndroidJavaClass pluginClass = new AndroidJavaClass ( "com.mobfox.unity.plugin.MobFoxPlugin" ))
			{
				if (pluginClass != null)
				{
					mobFoxPlugin = pluginClass.CallStatic<AndroidJavaObject> ( "instance" );
					if (activityContext != null)
					{
						activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
							{
								mobFoxPlugin.Call ( "setContext", activityContext );
							} ) );
					}
				}
			}
		}

		if ((mobFoxPlugin != null) && (activityContext != null))
		{
			activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
				{
					mobFoxPlugin.Call ( "setGameObject", MobFoxGameObjectName );
				} ) );
		}
	}
#elif UNITY_IPHONE
if (Application.platform == RuntimePlatform.IPhonePlayer)
{
_setGameObject ( MobFoxGameObjectName );
}
#endif
	if (OnSdkReady != null)
	{
		OnSdkReady ( );
	}
}

private static void LogMessage (string message, bool error = false)
{
	if (debug_mode)
	{
		if (error)
		{
			Debug.Log ( "MobFox " + message );
		}
		else
		{
			Debug.Log ( "MobFox " + message );
		}
	}
}


//======================================================================================
//======  B A N N E R                                                             ======
//======================================================================================

private void RequestMobFoxBanner_iPhone (string banner_inventory, int left, int top, int width, int height)
{
#if UNITY_IPHONE
_createBanner ( banner_inventory, left, top, width, height );
#endif
}

private void RequestMobFoxBanner_Android (string banner_inventory, int left, int top, int width, int height)
{
#if UNITY_ANDROID
	if ((mobFoxPlugin != null) && (activityContext != null))
	{
		activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
			{
				mobFoxPlugin.Call ( "createBanner", banner_inventory, left, top, width, height, false );
			} ) );
	}
#endif
}

public void RequestMobFoxBanner (string banner_inventory, int left, int top, int width, int height)
{
	LogMessage ( "### ShowMobFoxBanner ###" );

	//ConnectToPlugin ( );

	if (Application.platform == RuntimePlatform.Android)
	{
		RequestMobFoxBanner_Android ( banner_inventory, left, top, width, height );
	}
	else if (Application.platform == RuntimePlatform.IPhonePlayer)
	{
		RequestMobFoxBanner_iPhone ( banner_inventory, left, top, width, height );
	}
	HideMobFoxBanner ( );
}

//======================================================================================

private void HideMobFoxBanner_iPhone ()
{
#if UNITY_IPHONE
_hideBanner ( );
#endif
}

private void HideMobFoxBanner_Android ()
{
#if UNITY_ANDROID
	if ((mobFoxPlugin != null) && (activityContext != null))
	{
		activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
			{
				mobFoxPlugin.Call ( "hideBanner" );
			} ) );
	}
#endif
}

public void HideMobFoxBanner ()
{
	LogMessage ( "### HideMobFoxBanner ###" );

	//ConnectToPlugin ( );

	if (Application.platform == RuntimePlatform.Android)
	{
		HideMobFoxBanner_Android ( );
	}
	else if (Application.platform == RuntimePlatform.IPhonePlayer)
	{
		HideMobFoxBanner_iPhone ( );
	}
}

//======================================================================================

private void ShowMobFoxBanner_iPhone ()
{
#if UNITY_IPHONE
_showBanner ( );
#endif
}

private void ShowMobFoxBanner_Android ()
{
#if UNITY_ANDROID
	if ((mobFoxPlugin != null) && (activityContext != null))
	{
		activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
			{
				mobFoxPlugin.Call ( "showBanner" );
			} ) );
	}
#endif
}

public void ShowMobFoxBanner ()
{
	LogMessage ( "### HideMobFoxBanner ###" );

	//ConnectToPlugin ( );

	if (Application.platform == RuntimePlatform.Android)
	{
		ShowMobFoxBanner_Android ( );
	}
	else if (Application.platform == RuntimePlatform.IPhonePlayer)
	{
		ShowMobFoxBanner_iPhone ( );
	}
}

//======================================================================================

public void bannerReady (string msg)
{
	LogMessage ( "### bannerReady ###" );
}

public void bannerError (string msg)
{
	LogMessage ( "### bannerError: " + msg );
}

public void bannerClosed (string msg)
{
	LogMessage ( "### bannerClosed ###" );
}

public void bannerClicked (string msg)
{
	LogMessage ( "### bannerClicked ###" );
}

public void bannerFinished (string msg)
{
	LogMessage ( "### bannerFinished ###" );
}

//======================================================================================
//======  I N T E R S T I T I A L                                                 ======
//======================================================================================

private void RequestMobFoxInterstitial_iPhone (string interstitial_inventory)
{
#if UNITY_IPHONE
_createInterstitial ( interstitial_inventory );
#endif
}

private void RequestMobFoxInterstitial_Android (string interstitial_inventory)
{
#if UNITY_ANDROID
	if ((mobFoxPlugin != null) && (activityContext != null))
	{
		activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
			{
				mobFoxPlugin.Call ( "createInterstitial", interstitial_inventory );
			} ) );
	}
#endif
}

public void RequestMobFoxInterstitial (string interstitial_inventory)
{
	LogMessage ( "### CreateMobFoxInterstitial... ###" );

	bInterstitialReady = false;

	//ConnectToPlugin ( );

	if (Application.platform == RuntimePlatform.Android)
	{
		RequestMobFoxInterstitial_Android ( interstitial_inventory );
	}
	else if (Application.platform == RuntimePlatform.IPhonePlayer)
	{
		RequestMobFoxInterstitial_iPhone ( interstitial_inventory );
	}
}

//======================================================================================

private void ShowMobFoxInterstitial_iPhone ()
{
#if UNITY_IPHONE
_showInterstitial ( );
#endif
}

private void ShowMobFoxInterstitial_Android ()
{
#if UNITY_ANDROID
	if ((mobFoxPlugin != null) && (activityContext != null))
	{
		activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
			{
				mobFoxPlugin.Call ( "showInterstitial" );
			} ) );
	}
#endif
}

public void ShowMobFoxInterstitial ()
{
	if (bInterstitialReady)
	{
		LogMessage ( "### ShowMobFoxInterstitial... ###" );

		//ConnectToPlugin ( );

		if (Application.platform == RuntimePlatform.Android)
		{
			ShowMobFoxInterstitial_Android ( );
		}
		else if (Application.platform == RuntimePlatform.IPhonePlayer)
		{
			ShowMobFoxInterstitial_iPhone ( );
		}
	}
	else
	{
		LogMessage ( "### ShowMobFoxInterstitial - not ready!!! ###" );
	}
}

//======================================================================================

public void interstitialReady (string msg)
{
	LogMessage ( "### interstitialReady ###" );

	bInterstitialReady = true;
}

public void interstitalError (string msg)
{
	LogMessage ( "### interstitalError: " + msg );
}

public void interstitialClosed (string msg)
{
	LogMessage ( "### interstitialClosed ###" );
}

public void interstitialClicked (string msg)
{
	LogMessage ( "### interstitialClicked ###" );
}

public void interstitialFinished (string msg)
{
	LogMessage ( "### interstitialFinished ###" );
}

}

#else
using UnityEngine;
using System.Runtime.InteropServices;
using System;

public class MobFox :MonoBehaviour
{
	[DllImport ( "__Internal" )]
	public static extern void _setUseLocation (bool useLocation);

	[DllImport ( "__Internal" )]
	public static extern int _createBanner (string invh, float originX, float originY, float sizeWidth, float sizeHeight);

	[DllImport ( "__Internal" )]
	public static extern void _hideBanner ();

	[DllImport ( "__Internal" )]
	public static extern void _showBanner ();

	[DllImport ( "__Internal" )]
	public static extern void _setGameObject (string gameObject);

	[DllImport ( "__Internal" )]
	public static extern void _createInterstitial (string invh);

	[DllImport ( "__Internal" )]
	public static extern void _showInterstitial ();

	[DllImport ( "__Internal" )]
	public static extern void _createNative (string invh);


	//private string MobFoxBannerInventoryHash = "fe96717d9875b9da4339ea5367eff1ec";
	//private string MobFoxInterstitialInventoryHash = "267d72ac3f77a3f447b32cf7ebf20673";
	//private string MobFoxNativeInventoryHash = "a764347547748896b84e0b8ccd90fd62";//"80187188f458cfde788d961b6882fd53";

	private const string MobFoxGameObjectName = "MobFoxObject";


	bool InterstitialReady = false;

	private static AndroidJavaObject mobFoxPlugin = null;
	private static AndroidJavaObject activityContext = null;


	//======================================================================================
	//======  I N I T                                                                 ======
	//======================================================================================
	public static Action
	OnSdkReady,
	OnBannerReady,
	OnBannerClosed,
	OnBannerClicked,
	OnBannerFinished,
	OnInterstitialReady,
	OnInterstitialClosed,
	OnInterstitialClicked,
	OnInterstitialFinished;
	public static Action<string>
	OnBannerError,
	OnInterstitialError;

	private static bool
	debug_mode = true;

	private static MobFox instance;

	public static MobFox Instance
	{
		get
		{
			CreateSingletone ( );
			return instance;
		}
	}

	private static void LogMessage (string message, bool error = false)
	{
		if (debug_mode)
		{
			if (error)
			{
				Debug.Log ( "MobFox :: " + message );
			}
			else
			{
				Debug.Log ( "MobFox :: " + message );
			}
			ShowToast ( message );
		}
	}

	static private void ShowToast (string message)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			if ((mobFoxPlugin != null) && (activityContext != null))
			{
				activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
					{
						mobFoxPlugin.Call ( "showMessage", message );
					} ) );
			}
		}
		else
		{
		}
	}

	public static void CreateSingletone ()
	{
		if (instance == null)
		{
			GameObject e_man = new GameObject ( MobFoxGameObjectName );
			e_man.AddComponent<MobFox> ( );
		}
	}


	static void SetInstance (MobFox _instance)
	{
		if (instance == null)
		{
			LogMessage ( "creating Instance" );
			instance = _instance;
			DontDestroyOnLoad ( instance.gameObject );
			instance.ConnectToPlugin ( );
		}
	}


	void Awake ()
	{
		SetInstance ( this );
	}

	void ConnectToPlugin ()
	{
		if (Application.platform == RuntimePlatform.Android)
		{

			if (mobFoxPlugin == null)
			{
				using (AndroidJavaClass activityClass = new AndroidJavaClass ( "com.unity3d.player.UnityPlayer" ))
				{
					activityContext = activityClass.GetStatic<AndroidJavaObject> ( "currentActivity" );
				}

				using (AndroidJavaClass pluginClass = new AndroidJavaClass ( "com.mobfox.unity.plugin.MobFoxPlugin" ))
				{
					if (pluginClass != null)
					{
						mobFoxPlugin = pluginClass.CallStatic<AndroidJavaObject> ( "instance" );
						mobFoxPlugin.Call ( "setContext", activityContext );
					}
				}
			}

			if ((mobFoxPlugin != null) && (activityContext != null))
			{
				activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
					{
						mobFoxPlugin.Call ( "setGameObject", MobFoxGameObjectName );
					} ) );
			}
		}
		else
		{
			_setGameObject ( MobFoxGameObjectName );
		}

		if (OnSdkReady != null)
		{
			OnSdkReady ( );
		}
	}

	//======================================================================================
	//======  B A N N E R                                                             ======
	//======================================================================================

	private void ShowMobFoxBanner_iPhone (string banner_inventory, int left, int top, int width, int height)
	{
		_createBanner ( banner_inventory, left, top, width, height );
	}

	private void ShowMobFoxBanner_Android (string banner_inventory, int left, int top, int width, int height)
	{
		if ((mobFoxPlugin != null) && (activityContext != null))
		{
			activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
				{
					//				ShowToast("top " + top + ", left " + left);
					mobFoxPlugin.Call ( "createBanner", banner_inventory, left, top, width, height, false );
				} ) );
		}
	}
	public void RequestMobFoxBanner (string banner_inventory, int left, int top, int width, int height)
	//public void ShowMobFoxBanner ()
	{

		ConnectToPlugin ( );

		if (Application.platform == RuntimePlatform.Android)
		{
			ShowMobFoxBanner_Android ( banner_inventory, left, top, width, height );
		}
		else
		{
			ShowMobFoxBanner_iPhone ( banner_inventory, left, top, width, height );
		}
	}

	//======================================================================================

	private void HideMobFoxBanner_iPhone ()
	{
		_hideBanner ( );
	}

	private void HideMobFoxBanner_Android ()
	{
		if ((mobFoxPlugin != null) && (activityContext != null))
		{
			activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
				{
					mobFoxPlugin.Call ( "hideBanner" );
				} ) );
		}
	}

	public void HideMobFoxBanner ()
	{
		LogMessage ( "## Hide MobFox Banner ##" );

		ConnectToPlugin ( );

		if (Application.platform == RuntimePlatform.Android)
		{
			HideMobFoxBanner_Android ( );
		}
		else
		{
			HideMobFoxBanner_iPhone ( );
		}
	}

	//======================================================================================

	private void UnhideMobFoxBanner_iPhone ()
	{
		_showBanner ( );
	}

	private void UnhideMobFoxBanner_Android ()
	{
		if ((mobFoxPlugin != null) && (activityContext != null))
		{
			activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
				{
					mobFoxPlugin.Call ( "showBanner" );
				} ) );
		}
	}

	public void ShowMobFoxBanner ()
	{
		LogMessage ( "## Unhide MobFox Banner ##" );

		ConnectToPlugin ( );

		if (Application.platform == RuntimePlatform.Android)
		{
			UnhideMobFoxBanner_Android ( );
		}
		else
		{
			UnhideMobFoxBanner_iPhone ( );
		}
	}

	//======================================================================================

	public void bannerReady (string msg)
	{
		LogMessage ( "## Banner Loaded ##" );
		if (OnBannerReady != null)
		{
			OnBannerReady ( );
		}
	}

	public void bannerError (string msg)
	{
		LogMessage ( "## Banner Error: " + msg + " ##" );
		if (OnBannerError != null)
		{
			OnBannerError ( msg );
		}
	}

	public void bannerClosed (string msg)
	{
		LogMessage ( "## Banner Closed ###" );
		if (OnBannerClosed != null)
		{
			OnBannerClosed ( );
		}
	}

	public void bannerClicked (string msg)
	{
		LogMessage ( "## Banner Clicked ##" );
		if (OnBannerClicked != null)
		{
			OnBannerClicked ( );
		}
	}

	public void bannerFinished (string msg)
	{
		LogMessage ( "## Banner Finished ##" );
		if (OnBannerFinished != null)
		{
			OnBannerFinished ( );
		}
	}

	//======================================================================================
	//======  I N T E R S T I T I A L                                                 ======
	//======================================================================================

	public void RequestMobFoxInterstitial (string interstitial_inventory)
	{
		Debug.Log ( "## Load MobFox Interstitial ##" );

		//bCreateAndShowInterstitial = false;
		InterstitialReady = false;

		ConnectToPlugin ( );

		if (Application.platform == RuntimePlatform.Android)
		{
			CreateMobFoxInterstitial_Android ( interstitial_inventory );
		}
		else
		{
			CreateMobFoxInterstitial_iPhone ( interstitial_inventory );
		}
	}

	//======================================================================================

	private void CreateMobFoxInterstitial_iPhone (string interstitial_inventory)
	{
		_createInterstitial ( interstitial_inventory );
	}

	private void CreateMobFoxInterstitial_Android (string interstitial_inventory)
	{
		if ((mobFoxPlugin != null) && (activityContext != null))
		{
			activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
				{
					mobFoxPlugin.Call ( "createInterstitial", interstitial_inventory );
				} ) );
		}
	}

	//======================================================================================

	private void ShowMobFoxInterstitial_iPhone ()
	{
		_showInterstitial ( );
	}

	private void ShowMobFoxInterstitial_Android ()
	{
		if ((mobFoxPlugin != null) && (activityContext != null))
		{
			activityContext.Call ( "runOnUiThread", new AndroidJavaRunnable ( () =>
				{
					mobFoxPlugin.Call ( "showInterstitial" );
				} ) );
		}
	}

	public void ShowMobFoxInterstitial ()
	{
		if (InterstitialReady)
		{
			LogMessage ( "## MobFox Interstitial Shown ##" );

			ConnectToPlugin ( );

			if (Application.platform == RuntimePlatform.Android)
			{
				ShowMobFoxInterstitial_Android ( );
			}
			else
			{
				ShowMobFoxInterstitial_iPhone ( );
			}
		}
		else
		{
			LogMessage ( "## MobFoxInterstitial - not ready! ##" );
		}
	}

	//======================================================================================

	public void interstitialReady (string msg)
	{
		LogMessage ( "## Interstitial Ready ##" );

		InterstitialReady = true;
		if (OnInterstitialReady != null)
		{
			OnInterstitialReady ( );
		}
	}

	public void interstitalError (string msg)
	{
		LogMessage ( "## Interstital Error: " + msg + " ##");
		if (OnInterstitialError != null)
		{
			OnInterstitialError ( msg );
		}
	}

	public void interstitialClosed (string msg)
	{
		LogMessage ( "## Interstitial Closed ##" );
		if (OnInterstitialClosed != null)
		{
			OnInterstitialClosed ( );
		}
	}

	public void interstitialClicked (string msg)
	{
		LogMessage ( "## Interstitial Clicked ##" );
		if (OnInterstitialClicked != null)
		{
			OnInterstitialClicked ( );
		}
	}

	public void interstitialFinished (string msg)
	{
		LogMessage ( "## InterstitialFinished ##" );
		if (OnInterstitialFinished != null)
		{
			OnInterstitialFinished ( );
		}
	}


}
#endif