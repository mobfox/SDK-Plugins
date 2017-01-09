using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class MobFox : MonoBehaviour
{
	[DllImport("__Internal")]
	public static extern void _setUseLocation (bool useLocation);

	[DllImport("__Internal")]
	public static extern int _createBanner(string invh, float originX, float originY, float sizeWidth, float sizeHeight);

	[DllImport("__Internal")]
	public static extern void _setGameObject(string gameObject);

	[DllImport("__Internal")]
	public static extern void _createInterstitial(string invh);

	[DllImport("__Internal")]
	public static extern void _showInterstitial();

	[DllImport("__Internal")]
	public static extern void _createNative(string invh);


	[SerializeField] string MobFoxBannerInventoryHash       = "8769bb5eb962eb39170fc5d8930706a9";
	[SerializeField] string MobFoxInterstitialInventoryHash = "267d72ac3f77a3f447b32cf7ebf20673";
	[SerializeField] string MobFoxNativeInventoryHash       = "80187188f458cfde788d961b6882fd53";
	[SerializeField] string MobFoxGameObjectName            = "MobFoxObject";

	bool useLocation = false;

	bool bCreateAndShowInterstitial = true;
	bool bInterstitialReady = false;

	private AndroidJavaObject mobFoxPlugin = null;
	private AndroidJavaObject activityContext = null;

	private Text nativeTxtTitle;
	private Text nativeTxtBody;
	private RawImage nativeImageIcon;
	private RawImage nativeImageMain;
	private string nativeClickUrl;

	private Canvas nativeCanvas;

	//======================================================================================
	//======  I N I T                                                                 ======
	//======================================================================================

	void Awake()
	{
		ConnectToPlugin ();

		nativeTxtTitle  = (Text)GameObject.Find("nativeTitle").GetComponent<Text>();
		nativeTxtBody   = (Text)GameObject.Find("nativeBody").GetComponent<Text>();
		nativeImageIcon = (RawImage)GameObject.Find("nativeIcon").GetComponent<RawImage>();
		nativeImageMain = (RawImage)GameObject.Find("nativeMainImage").GetComponent<RawImage>();

		nativeCanvas    = (Canvas)GameObject.Find("nativeCanvas").GetComponent<Canvas>();

		nativeClickUrl = "";
	}

	void ConnectToPlugin()
	{
		if (Application.platform == RuntimePlatform.Android) {

			if (mobFoxPlugin == null) {
				using (AndroidJavaClass activityClass = new AndroidJavaClass ("com.unity3d.player.UnityPlayer")) {
					activityContext = activityClass.GetStatic<AndroidJavaObject> ("currentActivity");
				}

				using (AndroidJavaClass pluginClass = new AndroidJavaClass ("com.mobfox.unity.plugin.MobFoxPlugin")) {
					if (pluginClass != null) {
						mobFoxPlugin = pluginClass.CallStatic<AndroidJavaObject> ("instance");
						mobFoxPlugin.Call ("setContext", activityContext);
					}
				}
			}

			if ((mobFoxPlugin != null) && (activityContext != null)) {
				activityContext.Call("runOnUiThread", new AndroidJavaRunnable(() => {
					mobFoxPlugin.Call("setGameObject", MobFoxGameObjectName);
				}));
			}
		} else {
			_setGameObject (MobFoxGameObjectName);
		}
	}

	private void ShowToast(string message)
	{
		if (Application.platform == RuntimePlatform.Android) {
			if ((mobFoxPlugin != null) && (activityContext != null)) {
				activityContext.Call("runOnUiThread", new AndroidJavaRunnable(() => {
					mobFoxPlugin.Call("showMessage", message);
				}));
			}
		} else {
		}
	}

	//======================================================================================
	//======  L O C A T I O N   C H E C K B O X                                       ======
	//======================================================================================

	public void CheckboxPressed()
	{
		Debug.Log ("### CheckboxPressed ###");

		useLocation = !useLocation;

		SetUseLocation (useLocation);
	}

	//======================================================================================

	private void SetUseLocation_iPhone(bool in_useLocation)
	{
		_setUseLocation(in_useLocation);
	}

	private void SetUseLocation_Android(bool in_useLocation)
	{
		// No longer supported on Android...
		//if ((mobFoxPlugin != null) && (activityContext != null)) {
		//	activityContext.Call("runOnUiThread", new AndroidJavaRunnable(() => {
		//		mobFoxPlugin.Call("setUseLocation", in_useLocation);
		//	}));
		//}
	}

	private void SetUseLocation(bool in_useLocation)
	{	
		ConnectToPlugin ();

		if (Application.platform == RuntimePlatform.Android)
		{
			SetUseLocation_Android (in_useLocation);
		} else {
			SetUseLocation_iPhone (in_useLocation);
		}
	}

	//======================================================================================
	//======  B A N N E R                                                             ======
	//======================================================================================

	private void ShowMobFoxBanner_iPhone()
	{
		_createBanner (MobFoxBannerInventoryHash, 0, 0, 320, 50);
	}

	private void ShowMobFoxBanner_Android()
	{
		if ((mobFoxPlugin != null) && (activityContext != null)) {
			activityContext.Call("runOnUiThread", new AndroidJavaRunnable(() => {
				mobFoxPlugin.Call("createSmartBanner", MobFoxBannerInventoryHash, 0, 0, 50);
			}));
		}
	}

	public void ShowMobFoxBanner()
	{
		Debug.Log ("### ShowMobFoxBanner ###");

		ConnectToPlugin ();

		if (Application.platform == RuntimePlatform.Android)
		{
			ShowMobFoxBanner_Android ();
		} else {
			ShowMobFoxBanner_iPhone ();
		}
	}

	//======================================================================================

	public void bannerReady(string msg)
	{
		Debug.Log ("### bannerReady ###");
		ShowToast ("### bannerReady ###");
	}

	public void bannerError(string msg)
	{
		Debug.Log ("### bannerError: "+msg);
		ShowToast ("### bannerError: "+msg);
	}

	public void bannerClosed(string msg)
	{
		Debug.Log ("### bannerClosed ###");
		ShowToast ("### bannerClosed ###");
	}

	public void bannerClicked(string msg)
	{
		Debug.Log ("### bannerClicked ###");
		ShowToast ("### bannerClicked ###");
	}

	public void bannerFinished(string msg)
	{
		Debug.Log ("### bannerFinished ###");
		ShowToast ("### bannerFinished ###");
	}

	//======================================================================================
	//======  I N T E R S T I T I A L                                                 ======
	//======================================================================================

	public void CreateAndShowMobFoxInterstitial()
	{
		Debug.Log ("### CreateMobFoxInterstitial... ###");

		bCreateAndShowInterstitial = true;
		bInterstitialReady = false;

		ConnectToPlugin ();

		if (Application.platform == RuntimePlatform.Android) {
			CreateMobFoxInterstitial_Android ();
		} else {
			CreateMobFoxInterstitial_iPhone ();
		}
	}

	//======================================================================================

	private void CreateMobFoxInterstitial_iPhone()
	{
		_createInterstitial (MobFoxInterstitialInventoryHash);
	}

	private void CreateMobFoxInterstitial_Android()
	{
		if ((mobFoxPlugin != null) && (activityContext != null)) {
			activityContext.Call("runOnUiThread", new AndroidJavaRunnable(() => {
				mobFoxPlugin.Call("createInterstitial", MobFoxInterstitialInventoryHash);
			}));
		}
	}

	public void CreateMobFoxInterstitial()
	{
		Debug.Log ("### CreateMobFoxInterstitial... ###");

		bCreateAndShowInterstitial = false;
		bInterstitialReady = false;

		ConnectToPlugin ();

		if (Application.platform == RuntimePlatform.Android) {
			CreateMobFoxInterstitial_Android ();
		} else {
			CreateMobFoxInterstitial_iPhone ();
		}
	}

	//======================================================================================

	private void ShowMobFoxInterstitial_iPhone()
	{
		_showInterstitial ();
	}

	private void ShowMobFoxInterstitial_Android()
	{
		if ((mobFoxPlugin != null) && (activityContext != null)) {
			activityContext.Call("runOnUiThread", new AndroidJavaRunnable(() => {
				mobFoxPlugin.Call("showInterstitial");
			}));
		}
	}

	public void ShowMobFoxInterstitial()
	{
		if (bInterstitialReady)
		{
			Debug.Log ("### ShowMobFoxInterstitial... ###");

			ConnectToPlugin ();

			if (Application.platform == RuntimePlatform.Android) {
				ShowMobFoxInterstitial_Android ();
			} else {
				ShowMobFoxInterstitial_iPhone ();
			}
		} else {
			Debug.Log ("### ShowMobFoxInterstitial - not ready!!! ###");
			ShowToast ("### ShowMobFoxInterstitial - not ready!!! ###");
		}
	}

	//======================================================================================

	public void interstitialReady(string msg)
	{
		Debug.Log ("### interstitialReady ###");
		ShowToast ("### interstitialReady ###");

		bInterstitialReady = true;

		if (bCreateAndShowInterstitial) {
			ShowMobFoxInterstitial ();
		}
	}

	public void interstitalError(string msg)
	{
		Debug.Log ("### interstitalError: "+msg);
		ShowToast ("### interstitalError: "+msg);
	}

	public void interstitialClosed(string msg)
	{
		Debug.Log ("### interstitialClosed ###");
		ShowToast ("### interstitialClosed ###");
	}

	public void interstitialClicked(string msg)
	{
		Debug.Log ("### interstitialClicked ###");
		ShowToast ("### interstitialClicked ###");
	}

	public void interstitialFinished(string msg)
	{
		Debug.Log ("### interstitialFinished ###");
		ShowToast ("### interstitialFinished ###");
	}

	//======================================================================================
	//======  N A T I V E                                                             ======
	//======================================================================================

	private void ShowMobFoxNative_iPhone()
	{
		_createNative (MobFoxNativeInventoryHash);
	}

	private void ShowMobFoxNative_Android()
	{
		if ((mobFoxPlugin != null) && (activityContext != null)) {
			activityContext.Call("runOnUiThread", new AndroidJavaRunnable(() => {
				mobFoxPlugin.Call("createNative", MobFoxNativeInventoryHash);
			}));
		}
	}

	public void ShowMobFoxNative()
	{
		Debug.Log ("### ShowMobFoxNative ###");

		ConnectToPlugin ();

		if (Application.platform == RuntimePlatform.Android)
		{
			ShowMobFoxNative_Android ();
		} else {
			ShowMobFoxNative_iPhone ();
		}
	}

	//======================================================================================

	public void nativePressed()
	{
		Debug.Log ("### nativePressed ###");

		if (nativeClickUrl.Length > 0) {
			Debug.Log ("### open "+nativeClickUrl);
			ShowToast ("### open "+nativeClickUrl);
			Application.OpenURL (nativeClickUrl);
		}
	}

	//======================================================================================

	public void nativeReady(string msg)
	{
		Debug.Log ("### nativeReady ###");

		string[] array = msg.Split('|');

		for (int i = 0; i < array.Length; i++) {

			string line = array [i];
			Debug.Log ("### nativeReady: Line: "+line);
			if (line.StartsWith ("<Headline>")) {
				nativeTxtTitle.text = line.Substring(10);
			}
			if (line.StartsWith ("<Description>")) {
				nativeTxtBody.text = line.Substring(13);
			}
			if (line.StartsWith ("<IconImageUrl>")) {
				StartCoroutine (LoadIconImage (line.Substring(14)));
			}
			if (line.StartsWith ("<MainImageUrl>")) {
				StartCoroutine(LoadMainImage(line.Substring(14)));
			}
			if (line.StartsWith ("<ClickUrl>")) {
				nativeClickUrl = line.Substring(10);
			}
		}
	}

	public void nativeError(string msg)
	{
		Debug.Log ("### nativeError: "+msg);
		ShowToast ("### nativeError: "+msg);
	}

	private IEnumerator LoadIconImage(string loadedURL)
	{
		yield return 0;
		WWW imgLink1;
		if (loadedURL.StartsWith ("http://creative1cdn.mobfox.com/mftext")) {
			imgLink1 = new WWW("http://www.apptrainers.com/wp-content/uploads/2016/03/Unity3_AppIcon.png");
		} else {
			imgLink1 = new WWW(loadedURL);
		}
		yield return imgLink1;
		nativeImageIcon.texture = imgLink1.texture;
		nativeImageIcon.SetAllDirty ();
	}

	private IEnumerator LoadMainImage(string loadedURL)
	{
		yield return 0;
		WWW imgLink2;
		if (loadedURL.StartsWith ("http://creative1cdn.mobfox.com/mftext")) {
			imgLink2 = new WWW("https://unity3d.com/profiles/unity3d/themes/unity/images/company/brand/logos/primary/unity-logo.png");
		} else {
			imgLink2 = new WWW(loadedURL);
		}
		yield return imgLink2;
		nativeImageMain.texture = imgLink2.texture;
		nativeImageMain.SetAllDirty ();
	}

	//======================================================================================
}
