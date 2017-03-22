(function(window){
 
	var mNativeClickUrl = "";


	$( document ).ready(function() {
        if ((/(ipad|iphone|ipod|android)/i.test(navigator.userAgent))) {
			document.addEventListener('deviceready', addMobFoxCallbacks, false);
		} else {
			addMobFoxCallbacks();
		}
	});
 
    $('#show-banner').click(function(){
 		MobFoxPlugin.showBanner('fe96717d9875b9da4339ea5367eff1ec', 20, 44, 320, 50);
    });
 
    $('#hide-banner').click(function(){
 		MobFoxPlugin.hideBanner();
    });
 
    $('#unhide-banner').click(function(){
 		MobFoxPlugin.unhideBanner();
    });
 
    $('#show-interstitial').click(function(){
 		MobFoxPlugin.createInterstitial('267d72ac3f77a3f447b32cf7ebf20673');
    });
 
    $('#show-native').click(function(){
 		MobFoxPlugin.createNative('a764347547748896b84e0b8ccd90fd62');
    });
    
    $('#use-location').click(function(){    
    	var elCheckBox=document.getElementById("use-location");    
 		MobFoxPlugin.setUseLocation(elCheckBox.checked);
    });
 
    $('#native-component').click(function(){
 		nativePressed();
    });
      
 
    function addMobFoxCallbacks() {
    
        document.addEventListener('onBannerLoaded'  , onBannerLoaded, false);
        document.addEventListener('onBannerClicked' , onBannerClicked, false);
        document.addEventListener('onBannerFinished', onBannerFinished, false);
        document.addEventListener('onBannerClosed'  , onBannerClosed, false);

        document.addEventListener('onBannerFailed', function(data){
        	onBannerFailed(data); 
            });
    
    	//---------

        document.addEventListener('onInterstitialLoaded'  , onInterstitialLoaded, false);
        document.addEventListener('onInterstitialShown'   , onInterstitialShown, false);
        document.addEventListener('onInterstitialClicked' , onInterstitialClicked, false);
        document.addEventListener('onInterstitialFinished', onInterstitialFinished, false);
        document.addEventListener('onInterstitialClosed'  , onInterstitialClosed, false);
    
        document.addEventListener('onInterstitialFailed', function(data){
        	onInterstitialFailed(data); 
            });
    
    	//---------

        document.addEventListener('onNativeLoaded', function(data){
        	onNativeLoaded(data); 
            });
    
        document.addEventListener('onNativeFailed', function(data){
        	onNativeFailed(data); 
            });
	}
	
	//=====================================================
	
	function onBannerLoaded()
	{
		MobFoxPlugin.showToast('### Banner loaded ###');
	}
	
	function onBannerFailed(e)
	{
        MobFoxPlugin.showToast('### Banner error: ' + e.detail.message);
	}
	
	function onBannerClicked()
	{
		MobFoxPlugin.showToast('### Banner clicked ###');
	}
	
	function onBannerFinished()
	{
		MobFoxPlugin.showToast('### Banner finished ###');
	}
	
	function onBannerClosed()
	{
		MobFoxPlugin.showToast('### Banner closed ###');
	}
	
	//=====================================================
	
	function onInterstitialLoaded()
	{
		MobFoxPlugin.showToast('### Interstitial loaded ###');
		
		MobFoxPlugin.showInterstitial();
	}
	
	function onInterstitialFailed(e)
	{
        MobFoxPlugin.showToast('### Interstitial error: ' + e.detail.message);
	}
	
	function onInterstitialShown()
	{
		MobFoxPlugin.showToast('### Interstitial shown ###');
	}
	
	function onInterstitialClicked()
	{
		MobFoxPlugin.showToast('### Interstitial clicked ###');
	}
	
	function onInterstitialFinished()
	{
		MobFoxPlugin.showToast('### Interstitial finished ###');
	}
	
	function onInterstitialClosed()
	{
		MobFoxPlugin.showToast('### Interstitial closed ###');
	}
	
	//=====================================================
	
	function onNativeLoaded(e)
	{
		MobFoxPlugin.showToast('### Native loaded: '+e.detail.message);
		
		var array = e.detail.message.split('|');
		array.forEach(function myFunction(item, index) {
    		if (item.startsWith ("<Headline>")) {
				var x = document.getElementById("nativeTitle");
				x.textContent = item.substring(10);
			}
			if (item.startsWith ("<Description>")) {
				var x = document.getElementById("nativeBody");
				x.textContent = item.substring(13);
			}
			if (item.startsWith ("<IconImageUrl>")) {
				var x = document.getElementById("nativeIcon");
				x.src = item.substring(14);
			}
			if (item.startsWith ("<MainImageUrl>")) {
				var x = document.getElementById("nativeMain");
				x.src = item.substring(14);
			}
			if (item.startsWith ("<ClickUrl>")) {
				mNativeClickUrl = item.substring(10);
			}
			});
	}
	
	function onNativeFailed(e)
	{
        MobFoxPlugin.showToast('### Native error: ' + e.detail.message);
	}
	
	function nativePressed()
	{
		if (mNativeClickUrl.length>0)
		{
	        MobFoxPlugin.showToast('### Native pressed: '+mNativeClickUrl);

			if( navigator.app ) // Android
    			navigator.app.loadUrl( mNativeClickUrl, {openExternal:true} )
			else // iOS and others
   				 window.open( mNativeClickUrl, "_system" ) // opens in the app, not in safari
		}		
	}
  
})(window);