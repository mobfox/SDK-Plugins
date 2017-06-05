using System;

namespace Plugin.MobFoxAds.Abstractions
{
	/// <summary>
  	/// Interface for MobFoxAds
  	/// </summary>
  	public interface IMobFoxAds
  	{
		/// <summary>
		/// Event handler when connection changes
		/// </summary>
		event MobFoxBannerCallbackEventHandler MobFoxBannerCallbackHandler;

		/// <summary>
		/// Event handler when connection changes
		/// </summary>
		event MobFoxInterstitialCallbackEventHandler MobFoxInterstitialCallbackHandler;

		/// <summary>
		/// Event handler when connection changes
		/// </summary>
		event MobFoxNativeCallbackEventHandler MobFoxNativeCallbackHandler;

		/// <summary>
		/// Show toast with text
		/// </summary>
		/// <param name="text">Text to show</param>
		void ShowToast(string text);

		/// <summary>
		/// Create and show a banner ad
		/// </summary>
		/// <param name="hash">Hash of ad</param>
		/// <param name="x">X coordinate of banner, default is 0</param>
		/// <param name="y">Y coordinate of banner, default is 0</param>
		/// <param name="width">Width of banner, default is 320</param>
		/// <param name="height">Height of banner, default is 50</param>
		void CreateBanner(string hash, int x = 0, int y = 0, int width = 320, int height = 50);

		/// <summary>
		/// Hide banner
		/// </summary>
		void HideBanner();

		/// <summary>
		/// Unhide banner
		/// </summary>
		void UnideBanner();

		/// <summary>
		/// Create interstitial
		/// </summary>
		/// <param name="hash">Hash of ad</param>
		void CreateInterstitial(string hash);

		/// <summary>
		/// Show interstitial
		/// </summary>
		void ShowInterstitial();

		/// <summary>
		/// Create native
		/// </summary>
		/// <param name="hash">Hash of ad</param>
		void CreateNative(string hash);
	}



	/// <summary>
	/// Arguments to pass to event handlers
	/// </summary>
	public class MobFoxBannerCallbackEventArgs : EventArgs
	{
		/// <summary>
		/// type of event
		/// </summary>
		public string EventType { get; set; }

		/// <summary>
		/// error description
		/// </summary>
		public string ErrorDesc { get; set; }
	}

	/// <summary>
	/// MobFox ad event handlers
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void MobFoxBannerCallbackEventHandler(object sender, MobFoxBannerCallbackEventArgs e);

	/// <summary>
	/// Arguments to pass to event handlers
	/// </summary>
	public class MobFoxInterstitialCallbackEventArgs : EventArgs
	{
		/// <summary>
		/// type of event
		/// </summary>
		public string EventType { get; set; }

		/// <summary>
		/// error description
		/// </summary>
		public string ErrorDesc { get; set; }
	}

	/// <summary>
	/// MobFox ad event handlers
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void MobFoxInterstitialCallbackEventHandler(object sender, MobFoxInterstitialCallbackEventArgs e);

	/// <summary>
	/// Arguments to pass to event handlers
	/// </summary>
	public class MobFoxNativeCallbackEventArgs : EventArgs
	{
		/// <summary>
		/// type of event
		/// </summary>
		public string EventType { get; set; }

		/// <summary>
		/// error description
		/// </summary>
		public string ErrorDesc { get; set; }

		/// <summary>
		/// title text
		/// </summary>
		public string TitleText { get; set; }

		/// <summary>
		/// body text
		/// </summary>
		public string BodyText { get; set; }

		/// <summary>
		/// icon url
		/// </summary>
		public string IconUrl { get; set; }

		/// <summary>
		/// main image url
		/// </summary>
		public string MainImageUrl { get; set; }

		/// <summary>
		/// click url
		/// </summary>
		public string ClickUrl { get; set; }
	}

	/// <summary>
	/// MobFox ad event handlers
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void MobFoxNativeCallbackEventHandler(object sender, MobFoxNativeCallbackEventArgs e);
}
