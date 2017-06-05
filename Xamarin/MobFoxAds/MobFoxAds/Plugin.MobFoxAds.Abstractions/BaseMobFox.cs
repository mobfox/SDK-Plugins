using System;

namespace Plugin.MobFoxAds.Abstractions
{
	/// <summary>
	/// Base class for all MobFoxAds classes
	/// </summary>
	public abstract class BaseMobFox
	{
		//public BaseMobFox()
		//{
		//}

		//===================================================================

		/// <summary>
		/// When MobFox ads fires
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnMobFoxBannerCallback(MobFoxBannerCallbackEventArgs e) =>
			MobFoxBannerCallbackHandler?.Invoke(this, e);


		/// <summary>
		/// MobFox ad event
		/// </summary>
		public event MobFoxBannerCallbackEventHandler MobFoxBannerCallbackHandler;

		//===================================================================

		/// <summary>
		/// When MobFox ads fires
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnMobFoxInterstitialCallback(MobFoxInterstitialCallbackEventArgs e) =>
				MobFoxInterstitialCallbackHandler?.Invoke(this, e);


		/// <summary>
		/// MobFox ad event
		/// </summary>
		public event MobFoxInterstitialCallbackEventHandler MobFoxInterstitialCallbackHandler;

		//===================================================================

		/// <summary>
		/// When MobFox ads fires
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnMobFoxNativeCallback(MobFoxNativeCallbackEventArgs e) =>
				MobFoxNativeCallbackHandler?.Invoke(this, e);


		/// <summary>
		/// MobFox ad event
		/// </summary>
		public event MobFoxNativeCallbackEventHandler MobFoxNativeCallbackHandler;

		//===================================================================
	}
}
