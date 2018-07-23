using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager :MonoBehaviour
{
	private string MobFoxBannerInventoryHash =
		"fe96717d9875b9da4339ea5367eff1ec";
	private string MoatBannerInventoryHash =
		"396a7ad474e81a2f15ef7da323afdb4f";
	private string MobFoxInterstitialInventoryHash =
		"267d72ac3f77a3f447b32cf7ebf20673";
	private string MoatInterstitialVidInventoryHash =
		"925cda5671815c81802bf8b7f45eec55";


	public InputField
		interstitial_inventory,
		banner_invetory;

	private void Awake ()
	{
		MobFox.CreateSingletone ( );
		SetHashes ( );
	}

	private bool use_test = true;

	public void SwitchHashes ()
	{
		use_test = !use_test;
		SetHashes ( );
	}

	void SetHashes ()
	{
		banner_invetory.text = use_test ? MobFoxBannerInventoryHash : MoatBannerInventoryHash;
		interstitial_inventory.text = use_test ? MobFoxInterstitialInventoryHash : MoatInterstitialVidInventoryHash;
	}

	public void ShowBanner ()
	{
		MobFox.Instance.RequestMobFoxBanner ( banner_invetory.text, 30, 5, 320, 50 );
	}

	public void HideBanner ()
	{
		MobFox.Instance.HideMobFoxBanner ( );
	}

	public void UnHideBanner ()
	{
		MobFox.Instance.ShowMobFoxBanner ( );
	}

	public void CreateInterstitial ()
	{
		MobFox.Instance.RequestMobFoxInterstitial ( interstitial_inventory.text );
	}

	public void ShowInterstitial ()
	{
		MobFox.Instance.ShowMobFoxInterstitial ( );
	}
}
