using Xamarin.Forms;
using System;
using Plugin.MobFoxAds;

namespace MobFoxDemoXM
{
	public partial class MobFoxDemoXMPage : ContentPage
	{
		private bool mAutoShowInterstitial = false;
		private string mNativeClickUrl = "";

		//----------------------------------------------

		public MobFoxDemoXMPage()
		{
			InitializeComponent();

			//=== Banner callbacks: ===
			CrossMobFoxAds.Current.MobFoxBannerCallbackHandler += (sender, args) =>
			{
				CrossMobFoxAds.Current.ShowToast("##### BANNER: Type="+args.EventType+", Result="+args.ErrorDesc);
			};

			//=== Interstitial callbacks: ===
			CrossMobFoxAds.Current.MobFoxInterstitialCallbackHandler += (sender, args) =>
			{
				if (args.EventType.Equals("onInterstitialLoaded"))
				{
					if (mAutoShowInterstitial)
					{
						CrossMobFoxAds.Current.ShowInterstitial();
						return;
					}
				}

				CrossMobFoxAds.Current.ShowToast("##### INTERSTITIAL: Type="+args.EventType+", Result="+args.ErrorDesc);
			};

			//=== Native callbacks: ===
			CrossMobFoxAds.Current.MobFoxNativeCallbackHandler += (sender, args) =>
			{
				if (args.EventType.Equals("onNativeReady"))
				{
					nativeTitle.Text = args.TitleText;
					nativeBody.Text = args.BodyText;

					nativeIcon.Source = new UriImageSource
					{
						Uri = new Uri(args.IconUrl),
						CachingEnabled = true,
						CacheValidity = new TimeSpan(5, 0, 0, 0)
					};

					nativeMainIcon.Source = new UriImageSource
					{
						Uri = new Uri(args.MainImageUrl),
						CachingEnabled = true,
						CacheValidity = new TimeSpan(5, 0, 0, 0)
					};

					mNativeClickUrl = args.ClickUrl;
					return;
				}

				CrossMobFoxAds.Current.ShowToast("##### NATIVE: Type="+args.EventType+", Result="+args.ErrorDesc);
			};

			//=== Native - detect taps on elements: ===

			// Your label tap event
			var native_title_tap = new TapGestureRecognizer();
			native_title_tap.Tapped += (s, e) =>
								{
									if (mNativeClickUrl.Length > 0)
									{
										Device.OpenUri(new Uri(mNativeClickUrl));
									}
								};
			nativeTitle.GestureRecognizers.Add(native_title_tap);
			nativeBody.GestureRecognizers.Add(native_title_tap);
			nativeIcon.GestureRecognizers.Add(native_title_tap);
			nativeMainIcon.GestureRecognizers.Add(native_title_tap);
		}

		//----------------------------------------------

		void OnCreateBanner(object sender, EventArgs e)
		{
			CrossMobFoxAds.Current.CreateBanner("fe96717d9875b9da4339ea5367eff1ec",30,120,320,50);
		}

		void OnHideBanner(object sender, EventArgs e)
		{
			CrossMobFoxAds.Current.HideBanner();
		}

		void OnUnhideBanner(object sender, EventArgs e)
		{
			CrossMobFoxAds.Current.UnideBanner();
		}

		//----------------------------------------------

		void OnCreateInterstitial(object sender, EventArgs e)
		{
			mAutoShowInterstitial = true;
			CrossMobFoxAds.Current.CreateInterstitial("267d72ac3f77a3f447b32cf7ebf20673");
		}

		void OnLoadInterstitial(object sender, EventArgs e)
		{
			mAutoShowInterstitial = false;
			CrossMobFoxAds.Current.CreateInterstitial("267d72ac3f77a3f447b32cf7ebf20673");
		}

		void OnShowInterstitial(object sender, EventArgs e)
		{
			CrossMobFoxAds.Current.ShowInterstitial();
		}

		//----------------------------------------------

		void OnCreateNative(object sender, EventArgs e)
		{
			CrossMobFoxAds.Current.CreateNative("a764347547748896b84e0b8ccd90fd62");
		}
	}
}
