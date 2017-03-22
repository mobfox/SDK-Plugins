var exec = require('cordova/exec');

function MobFoxPlugin() { 
 	console.log("MobFoxPlugin.js: is created");
}

MobFoxPlugin.prototype.setUseLocation = function(useLocation) {
	
	if(typeof useLocation === 'undefined') useLocation = false;
	
	exec(function(result){
					var myCustomEvent = new Event(result);
					document.dispatchEvent(myCustomEvent);
   				},
  				function(result){
					var myCustomEvent = new CustomEvent("onBannerFailed",  {
						detail: {
							message: result,
							time: new Date()
						},
						bubbles: true,
						cancelable: true});
					document.dispatchEvent(myCustomEvent);
    				//alert("Error: " + result);
   				}, "MobFoxPlugin", "setUseLocation", [{useLocation:useLocation}] );
};

MobFoxPlugin.prototype.showBanner = function(hash, x, y, w, h) {
	
	if(typeof hash === 'undefined') hash = 'fe96717d9875b9da4339ea5367eff1ec';
	if(typeof x === 'undefined') x = 0;
	if(typeof y === 'undefined') y = 0;
	if(typeof w === 'undefined') w = 320;
	if(typeof h === 'undefined') h = 50;
	
	exec(function(result){
					var myCustomEvent = new Event(result);
					document.dispatchEvent(myCustomEvent);
   				},
  				function(result){
					var myCustomEvent = new CustomEvent("onBannerFailed",  {
						detail: {
							message: result,
							time: new Date()
						},
						bubbles: true,
						cancelable: true});
					document.dispatchEvent(myCustomEvent);
    				//alert("Error: " + result);
   				}, "MobFoxPlugin", "showBanner", [{hash:hash, x:x, y:y, w:w, h:h}] );
};

MobFoxPlugin.prototype.hideBanner = function() {

	exec(function(result){
   				},
  				function(result){
   				}, "MobFoxPlugin", "hideBanner", [] );
};

MobFoxPlugin.prototype.unhideBanner = function() {

	exec(function(result){
   				},
  				function(result){
   				}, "MobFoxPlugin", "unhideBanner", [] );
};

MobFoxPlugin.prototype.createInterstitial = function(hash) {

	if(typeof hash === 'undefined') hash = '267d72ac3f77a3f447b32cf7ebf20673';

	exec(function(result){
					var myCustomEvent = new Event(result);
					document.dispatchEvent(myCustomEvent);
   				},
  				function(result){
					var myCustomEvent = new CustomEvent("onInterstitialFailed",  {
						detail: {
							message: result,
							time: new Date()
						},
						bubbles: true,
						cancelable: true});
					document.dispatchEvent(myCustomEvent);
   				}, "MobFoxPlugin", "createInterstitial", [ {hash:hash} ] );
};

MobFoxPlugin.prototype.showInterstitial = function() {

	exec(function(result){
					var myCustomEvent = new Event(result);
					document.dispatchEvent(myCustomEvent);
   				},
  				function(result){
					var myCustomEvent = new CustomEvent("onInterstitialFailed",  {
						detail: {
							message: result,
							time: new Date()
						},
						bubbles: true,
						cancelable: true});
					document.dispatchEvent(myCustomEvent);
   				}, "MobFoxPlugin", "showInterstitial", [] );
};

MobFoxPlugin.prototype.createNative = function(hash) {

	if(typeof hash === 'undefined') hash = '80187188f458cfde788d961b6882fd53';

	exec(function(result){
					//var myCustomEvent = new Event(result);
					//document.dispatchEvent(myCustomEvent);
					var myCustomEvent = new CustomEvent("onNativeLoaded", {
						detail: {
							message: result,
							time: new Date()
						},
						bubbles: true,
						cancelable: true});
					document.dispatchEvent(myCustomEvent);
   				},
  				function(result){
					var myCustomEvent = new CustomEvent("onNativeFailed",  {
						detail: {
							message: result,
							time: new Date()
						},
						bubbles: true,
						cancelable: true});
					document.dispatchEvent(myCustomEvent);
   				}, "MobFoxPlugin", "createNative", [ {hash:hash} ] );
};

MobFoxPlugin.prototype.showToast = function(text) {
    
    if(typeof text === 'undefined') text = 'Hello';
    
    exec(function(result){
         },
         function(result){
         }, "MobFoxPlugin", "showToast", [ {text:text} ] );
};

var mobFoxPlugin = new MobFoxPlugin();
 module.exports = mobFoxPlugin;

