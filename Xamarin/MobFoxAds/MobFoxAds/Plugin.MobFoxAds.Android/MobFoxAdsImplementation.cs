using Plugin.MobFoxAds.Abstractions;
using Plugin.CurrentActivity;
using System;
using Android.Util;
using Android.Content;
using Android.Widget;
using Android.Views;
using Java.Util;
using System.Collections.Generic;


using Com.Mobfox.Sdk;
using Com.Mobfox.Sdk.Bannerads;
using Com.Mobfox.Sdk.Interstitialads;
using Com.Mobfox.Sdk.Nativeads;
using Com.Mobfox.Sdk.Customevents;

namespace Plugin.MobFoxAds
{
	/// <summary>
	/// Implementation for Feature
	/// </summary>
	public class MobFoxAdsImplementation : BaseMobFox, IMobFoxAds
	{
		//######################################################################

		public int CalcDPIToReal(int dp)
		{
			var metrics = Android.App.Application.Context.Resources.DisplayMetrics;
			return (int)(((float)dp * metrics.Density) + 0.5);
		}

		private void show_toast(string text)
		{
			Toast.MakeText(Android.App.Application.Context, text, ToastLength.Long).Show();
		}

		/// <summary>
		/// Show toast with text
		/// </summary>
		/// <param name="text">Text to show</param>
		public void ShowToast(string text)
		{
			show_toast(text);
		}

		//######################################################################
		//##### B A N N E R                                                #####
		//######################################################################

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
		public class MyBannerListener : Java.Lang.Object, IBannerListener
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
			/// Banner error:
			/// </summary>
			public void OnBannerError(Android.Views.View v, Java.Lang.Exception e)
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendBannerCallbackEvent("onBannerError", e.ToString());
			}

			/// <summary>
			/// Banner Loaded:
			/// </summary>
			public void OnBannerLoaded(Android.Views.View v)
			{
				//string txt = "dbg: onBannerLoaded";
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendBannerCallbackEvent("onBannerLoaded", "ok");
			}

			/// <summary>
			/// Banner closed:
			/// </summary>
			public void OnBannerClosed(Android.Views.View v)
			{
				mThis.SendBannerCallbackEvent("onBannerClosed", "ok");
			}

			/// <summary>
			/// Banner clicked:
			/// </summary>
			public void OnBannerClicked(Android.Views.View v)
			{
				mThis.SendBannerCallbackEvent("OnBannerClicked", "ok");
			}

			/// <summary>
			/// Banner clicked:
			/// </summary>
			public void OnBannerFinished()
			{
				mThis.SendBannerCallbackEvent("onBannerFinished", "ok");
			}

			/// <summary>
			/// Banner clicked:
			/// </summary>
			public void OnNoFill(Android.Views.View banner)
			{
				mThis.SendBannerCallbackEvent("onNoFill", "ok");
			}
		}

		//======================================================================

		private static Com.Mobfox.Sdk.Bannerads.Banner mBanner = null;
		private MyBannerListener mBannerListener = new MyBannerListener();

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
			//show_toast("dbg: CreateBanner("+hash+", "+x+", "+y+", "+width+", "+height+")...");

			if (mBanner != null)
			{
				Android.Views.View v = mBanner;
				v.Visibility = ViewStates.Gone;

				mBanner = null;
			}

			int scrX = CalcDPIToReal(x);
			int scrY = CalcDPIToReal(y);
			int scrW = CalcDPIToReal(width);
			int scrH = CalcDPIToReal(height);

			mBanner = new Com.Mobfox.Sdk.Bannerads.Banner(Android.App.Application.Context, width, height);
			if (mBanner != null)
			{
				mBannerListener.SetParent(this);

				var varActivity = CrossCurrentActivity.Current.Activity;

				ViewGroup.LayoutParams bannerParameters = new FrameLayout.LayoutParams(scrW, scrH);

				varActivity.AddContentView(mBanner, bannerParameters);

				mBanner.SetX(scrX);
				mBanner.SetY(scrY);

				mBanner.SetListener(mBannerListener);
				mBanner.SetInventoryHash(hash);
				mBanner.Load();
			}
		}

		/// <summary>
		/// Hide banner
		/// </summary>
		public void HideBanner()
		{
			if (mBanner != null)
			{
				Android.Views.View v = mBanner;
				v.Visibility = ViewStates.Gone;
			}
		}

		/// <summary>
		/// Unhide banner
		/// </summary>
		public void UnideBanner()
		{
			if (mBanner != null)
			{
				Android.Views.View v = mBanner;
				v.Visibility = ViewStates.Visible;
			}
		}


		//######################################################################
		//##### I N T E R S T I T I A L                                    #####
		//######################################################################

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
		public class MyInterstitialListener : Java.Lang.Object, IInterstitialAdListener
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
			/// Banner clicked:
			/// </summary>
			public void OnInterstitialFailed(InterstitialAd interstitial, Java.Lang.Exception e)
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendInterstitialCallbackEvent("onInterstitialError", e.ToString());
			}

			/// <summary>
			/// Interstitial loaded:
			/// </summary>
			public void OnInterstitialLoaded(InterstitialAd interstitial)
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendInterstitialCallbackEvent("onInterstitialLoaded", "ok");
			}

			/// <summary>
			/// Interstitial closed:
			/// </summary>
			public void OnInterstitialClosed(InterstitialAd interstitial)
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendInterstitialCallbackEvent("onInterstitialClosed", "ok");

				mInterstitial = null;
			}

			/// <summary>
			/// Interstitial finished:
			/// </summary>
			public void OnInterstitialFinished()
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendInterstitialCallbackEvent("onInterstitialFinished", "ok");
			}

			/// <summary>
			/// Interstitial clicked:
			/// </summary>
			public void OnInterstitialClicked(InterstitialAd interstitial)
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendInterstitialCallbackEvent("onInterstitialClicked", "ok");
			}

			/// <summary>
			/// Interstitial shown:
			/// </summary>
			public void OnInterstitialShown(InterstitialAd interstitial)
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendInterstitialCallbackEvent("onInterstitialShown", "ok");
			}
		}

		//======================================================================

		private static InterstitialAd mInterstitial = null;
		private MyInterstitialListener mInterstitialListener = new MyInterstitialListener();

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

			mInterstitial = new InterstitialAd(Android.App.Application.Context);

			if (mInterstitial != null)
			{
				mInterstitialListener.SetParent(this);

				mInterstitial.SetListener(mInterstitialListener);

				mInterstitial.SetInventoryHash(hash);

				mInterstitial.Load();
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
		public class MyNativeListener : Java.Lang.Object, INativeListener
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
			/// Native error:
			/// </summary>
			public void OnNativeError(Java.Lang.Exception e)
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendNativeCallbackEvent("onNativeError", e.ToString());
			}

			/// <summary>
			/// Native clicked:
			/// </summary>
			public void OnNativeClick(NativeAd ad)
			{
				//string txt = "dbg: onBannerError: "+e.ToString();
				//Toast.MakeText(Android.App.Application.Context, txt, ToastLength.Long).Show();

				mThis.SendNativeCallbackEvent("onNativeClick", "ok");
			}

			/// <summary>
			/// Native loaded:
			/// </summary>
			public void OnNativeReady(Native aNative, ICustomEventNative custEvent, NativeAd ad)
			{
				string titleText = "", bodyText = "", iconUrl = "", mainImageUrl = "", clickUrl = "";

				IList<Com.Mobfox.Sdk.Nativeads.TextItem> texts = ad.Texts;
				IEnumerator<TextItem> e = texts.GetEnumerator();
				while (e.MoveNext())
				{
					TextItem txt = e.Current;
					if (txt.GetType().Equals("title"))
					{
						titleText = txt.Text;
					}
					if (txt.Type.Equals("desc"))
					{
						bodyText = txt.Text;
					}
				}

				IList<Com.Mobfox.Sdk.Nativeads.ImageItem> images = ad.Images;
				IEnumerator<ImageItem> e1 = images.GetEnumerator();
				while (e1.MoveNext())
				{
					ImageItem img = e1.Current;
					if (img.Type.Equals("icon"))
					{
						string imgUrl = img.Url;
						if (imgUrl != null)
						{
							iconUrl = imgUrl;
						}
					}
					if (img.Type.Equals("main"))
					{
						string imgUrl = img.Url;
						if (imgUrl != null)
						{
							mainImageUrl = imgUrl;
						}
					}
				}

				if ((ad.Link != null) && (ad.Link.Length > 0))
				{
					clickUrl = ad.Link;
				}

				mThis.SendNativeCallbackEvent("onNativeReady", "ok", titleText, bodyText, iconUrl, mainImageUrl, clickUrl);
			}
		}

		//=============================================================

		private static Native mNative = null;
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

			Native.SetDebug(true);

			mNative = new Native(Android.App.Application.Context);
			if (mNative != null)
			{
				mNativeListener.SetParent(this);

				mNative.Listener = mNativeListener;

				mNative.Load(hash);
			}
		}
	}
}