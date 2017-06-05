using Plugin.MobFoxAds.Abstractions;
using System;
using System.Threading.Tasks;
using MobFoxSDKCore;

#if __UNIFIED__
using AudioToolbox;
using UIKit;
using CoreGraphics;
using Foundation;
#else
using MonoTouch.AudioToolbox;
using MonoTouch.UIKit;
#endif


namespace Plugin.MobFoxAds
{	
	/// <summary>
	/// Implementation for MobFoxAds
	/// </summary>
	public class MobFoxAdsImplementation : BaseMobFox, IMobFoxAds
  	{
		UIAlertView mToast = null;

		private void show_toast(String text)
		{
			if (mToast != null)
			{
				mToast.DismissWithClickedButtonIndex(0, false);
				mToast = null;
			}

			mToast = new UIAlertView()
			{
				Title = "alert title",
				Message = text
			};
			mToast.AddButton("OK");
			mToast.Show();

			TaskScheduler uiContext = TaskScheduler.FromCurrentSynchronizationContext();
			Task.Delay(3000).ContinueWith((task) =>
			{
				//Do UI stuff
				if (mToast != null)
				{
					mToast.DismissWithClickedButtonIndex(0, false);
					mToast = null;

					//OnMobFoxBannerCallback(new MobFoxBannerCallbackEventArgs { EventType="OnToastDone", ErrorDesc="Bla" });
				}
			}, uiContext);
		}

		//==============================================================

		/// <summary>
		/// Show toast with text
		/// </summary>
		/// <param name="text">Text to show</param>
		public void ShowToast(string text)
		{
			show_toast(text);
		}

		private UIViewController GetViewController()
		{
			var window = UIApplication.SharedApplication.KeyWindow;
			var vc = window.RootViewController;
			if (vc != null)
			{
				var vc1 = vc.PresentedViewController;
				if (vc1 != null)
				{
					return vc1;
				}
				return vc;
			}
			return null;
		}

		//######################################################################
		//##### B A N N E R                                                #####
		//######################################################################

		private static MobFoxSDKCore.MobFoxAd mBanner = null;
		private MyBannerListener mBannerListener = new MyBannerListener();

		/// <summary>
		/// Action to call when ad events happen
		/// </summary>
		public static Action<MobFoxBannerCallbackEventArgs> MobFoxBannerCallback = null;

		private void SendBannerCallbackEvent(string type, string error)
		{
			if (MobFoxBannerCallback == null)
			{
				MobFoxBannerCallback = OnMobFoxBannerCallback;
			}
			var mobFoxBannerCallbackAction = MobFoxBannerCallback;
			if (mobFoxBannerCallbackAction != null)
			{
				mobFoxBannerCallbackAction(new MobFoxBannerCallbackEventArgs { EventType = type, ErrorDesc = error });
			}
		}

		/// <summary>
		/// Listener for Banner events:
		/// </summary>
		public class MyBannerListener : MobFoxAdDelegate
		{
			/// <summary>
			/// Parent class
			/// </summary>
			private MobFoxAdsImplementation mThis;

			/// <summary>
			/// Set Parent
			/// </summary>
			public void SetParent(MobFoxAdsImplementation parent)
			{
				mThis = parent;
			}

			/// <summary>
			/// Dispose
			/// </summary>
			protected override void Dispose(bool disposing)
			{
				base.Dispose(disposing);
				if (Handle == IntPtr.Zero)
				{
					//__mt_Base_var = null;
					//__mt_Brg_var = null;
					//__mt_WeakDelegate_var = null;

				}
			}

			/// <summary>
			/// Loaded
			/// </summary>
			public override void MobFoxAdDidLoad(MobFoxAd banner)
			{
				mBanner.Hidden = false;

				mThis.SendBannerCallbackEvent("bannerReady", "ok");
			}

			/// <summary>
			/// Error
			/// </summary>
			public override void MobFoxAdDidFailToReceiveAdWithError(NSError error)
			{
				mThis.SendBannerCallbackEvent("bannerError", error.Description);
			}

			/// <summary>
			/// Closed
			/// </summary>
			public override void MobFoxAdClosed()
			{
				mThis.SendBannerCallbackEvent("bannerClosed", "ok");
			}

			/// <summary>
			/// Clicked
			/// </summary>
			public override void MobFoxAdClicked()
			{
				mThis.SendBannerCallbackEvent("bannerClicked", "ok");
			}

			/// <summary>
			/// Finished
			/// </summary>
			public override void MobFoxAdFinished()
			{
				mThis.SendBannerCallbackEvent("bannerFinished", "ok");
			}
		}

		/// <summary>
		/// Create and show a banner ad
		/// </summary>
		/// <param name="hash">Hash of ad</param>
		/// <param name="x">X coordinate of banner, default is 0</param>
		/// <param name="y">Y coordinate of banner, default is 0</param>
		/// <param name="width">Width of banner, default is 320</param>
		/// <param name="height">Height of banner, default is 50</param>
		public void CreateBanner(string hash, int x = 0, int y = 0, int width = 320, int height = 50)
		{
			//show_toast("dbg: CreateBanner(" + hash + ", " + x + ", " + y + ", " + width + ", " + height + ")...");

			if (mBanner != null)
			{
				mBanner.Hidden = true;
				mBanner = null;
			}

			//define the position and dimensions of your ad
			CGRect adRect = new CGRect(x, y, width, height);

			//init your ad
			mBanner = new MobFoxAd(hash,adRect);
			if (mBanner != null)
			{
				mBannerListener.SetParent(this);

				mBanner.Delegate = mBannerListener;

				mBanner.LoadAd();

				var vc = GetViewController();
				if (vc != null)
				{
					vc.View.AddSubview(mBanner);

					mBanner.Frame = adRect;
				}
			}
		}

		/// <summary>
		/// Hide banner
		/// </summary>
		public void HideBanner()
		{
			if (mBanner != null)
			{
				mBanner.Hidden = true;
			}
		}

		/// <summary>
		/// Unhide banner
		/// </summary>
		public void UnideBanner()
		{
			if (mBanner != null)
			{
				mBanner.Hidden = false;
			}
		}

		//######################################################################
		//##### I N T E R S T I T I A L                                    #####
		//######################################################################

		private static MobFoxSDKCore.MobFoxInterstitialAd mInterstitial = null;
		private MyInterstitialListener mInterstitialListener = new MyInterstitialListener();


		/// <summary>
		/// Action to call when ad events happen
		/// </summary>
		public static Action<MobFoxInterstitialCallbackEventArgs> MobFoxInterstitialCallback = null;

		private void SendInterstitialCallbackEvent(string type, string error)
		{
			if (MobFoxInterstitialCallback == null)
			{
				MobFoxInterstitialCallback = OnMobFoxInterstitialCallback;
			}
			var mobFoxInterstitialCallbackAction = MobFoxInterstitialCallback;
			if (mobFoxInterstitialCallbackAction != null)
			{
				mobFoxInterstitialCallbackAction(new MobFoxInterstitialCallbackEventArgs { EventType = type, ErrorDesc = error });
			}
		}

		/// <summary>
		/// Listener for Interstitial events:
		/// </summary>
		public class MyInterstitialListener : MobFoxInterstitialAdDelegate
		{
			/// <summary>
			/// Parent class
			/// </summary>
			private MobFoxAdsImplementation mThis;

			/// <summary>
			/// Set Parent
			/// </summary>
			public void SetParent(MobFoxAdsImplementation parent)
			{
				mThis = parent;
			}

			/// <summary>
			/// Interstitial loaded:
			/// </summary>
			public override void MobFoxInterstitialAdDidLoad(MobFoxInterstitialAd interstitial)
			{
				mThis.SendInterstitialCallbackEvent("onInterstitialLoaded", "ok");
			}

			/// <summary>
			/// Interstitial error:
			/// </summary>
			public override void MobFoxInterstitialAdDidFailToReceiveAdWithError(NSError error)
			{
				mThis.SendInterstitialCallbackEvent("onInterstitialError", error.Description);
			}

			/// <summary>
			/// Interstitial will show:
			/// </summary>
			public override void MobFoxInterstitialAdWillShow(MobFoxInterstitialAd interstitial)
			{
				mThis.SendInterstitialCallbackEvent("onInterstitialShown", "ok");
			}

			/// <summary>
			/// Interstitial closed:
			/// </summary>
			public override void MobFoxInterstitialAdClosed()
			{
				mThis.SendInterstitialCallbackEvent("onInterstitialClosed", "ok");
			}

			/// <summary>
			/// Interstitial clicked:
			/// </summary>
			public override void MobFoxInterstitialAdClicked()
			{
				mThis.SendInterstitialCallbackEvent("onInterstitialClicked", "ok");
			}

			/// <summary>
			/// Interstitial finished:
			/// </summary>
			public override void MobFoxInterstitialAdFinished()
			{
				mThis.SendInterstitialCallbackEvent("onInterstitialFinished", "ok");
			}
		}

		//======================================================================

		/// <summary>
		/// Create interstitial
		/// </summary>
		/// <param name="hash">Hash of ad</param>
		public void CreateInterstitial(string hash)
		{
			if (mInterstitial != null)
			{
				mInterstitial = null;
			}

			// removed after build 1.02: "setLocation" is done in the manifest
			//Banner.setGetLocation(MobFoxPlugin.mUseLocation);

			var vc = GetViewController();

			mInterstitial = new MobFoxInterstitialAd(hash, vc);

			if (mInterstitial != null)
			{
				mInterstitialListener.SetParent(this);

				mInterstitial.Delegate = mInterstitialListener;

				mInterstitial.LoadAd();
			}
		}

		/// <summary>
		/// Show interstitial
		/// </summary>
		public void ShowInterstitial()
		{
			if (mInterstitial == null) return;

			mInterstitial.Show();
		}

		//######################################################################
		//##### N A T I V E                                                #####
		//######################################################################

		/// <summary>
		/// Action to call when ad events happen
		/// </summary>
		public static Action<MobFoxNativeCallbackEventArgs> MobFoxNativeCallback = null;

		private void SendNativeCallbackEvent(string type, string error,
											string titleText = "", string bodyText = "",
											string iconUrl = "", string mainImageUrl = "",
											string clickUrl = "")
		{
			if (MobFoxNativeCallback == null)
			{
				MobFoxNativeCallback = OnMobFoxNativeCallback;
			}
			var mobFoxNativeCallbackAction = MobFoxNativeCallback;
			if (mobFoxNativeCallbackAction != null)
			{
				mobFoxNativeCallbackAction(new MobFoxNativeCallbackEventArgs
				{
					EventType = type,
					ErrorDesc = error,
					TitleText = titleText,
					BodyText = bodyText,
					IconUrl = iconUrl,
					MainImageUrl = mainImageUrl,
					ClickUrl = clickUrl
				});
			}
		}

		/// <summary>
		/// Listener for Native events:
		/// </summary>
		public class MyNativeListener : MobFoxNativeAdDelegate
		{
			/// <summary>
			/// Parent class
			/// </summary>
			private MobFoxAdsImplementation mThis;

			/// <summary>
			/// Set Parent
			/// </summary>
			public void SetParent(MobFoxAdsImplementation parent)
			{
				mThis = parent;
			}

			/// <summary>
			/// Loaded
			/// </summary>
			public override void MobFoxNativeAdDidLoad(MobFoxNativeAd ad, MobFoxNativeData adData)
			{
				string titleText = "", bodyText = "", iconUrl = "", mainImageUrl = "", clickUrl = "";

				if (adData == null)
				{
					mThis.SendInterstitialCallbackEvent("onNativeError", "No ad data");
					return;
				}

				titleText = adData.AssetHeadline;
				if (titleText == null) titleText = "";

				bodyText = adData.AssetDescription;
				if (bodyText == null) bodyText = "";

				if (adData.Icon.Url != null)
				{
					iconUrl = adData.Icon.Url.ToString();
				}
				if (adData.Main.Url != null)
				{
					mainImageUrl = adData.Main.Url.ToString();
				}

				if (adData.ClickURL != null)
				{
					clickUrl = adData.ClickURL.ToString();
				}

				mThis.SendNativeCallbackEvent("onNativeReady", "ok", titleText, bodyText, iconUrl, mainImageUrl, clickUrl);
			}

			/// <summary>
			/// Loaded
			/// </summary>
			public override void MobFoxNativeAdDidFailToReceiveAdWithError(NSError error)
			{
				mThis.SendInterstitialCallbackEvent("onNativeError", error.Description);
			}
		}

		//=============================================================

		private static MobFoxNativeAd mNative = null;
		private MyNativeListener mNativeListener = new MyNativeListener();

		/// <summary>
		/// Create native
		/// </summary>
		/// <param name="hash">Hash of ad</param>
		public void CreateNative(string hash)
		{
			if (mNative != null)
			{
				mNative = null;
			}

			//MobFoxNativeAd.SetDebug(true);

			mNative = new MobFoxNativeAd(hash);
			if (mNative != null)
			{
				mNativeListener.SetParent(this);

				mNative.Delegate = mNativeListener;

				mNative.LoadAd();
			}
		}
	}
}