package ${YYAndroidPackageName};

import com.yoyogames.runner.RunnerJNILib;

import ${YYAndroidPackageName}.RunnerActivity;

import com.mobfox.sdk.bannerads.Banner;
import com.mobfox.sdk.bannerads.BannerListener;
import com.mobfox.sdk.interstitialads.InterstitialAd;
import com.mobfox.sdk.interstitialads.InterstitialAdListener;
import com.mobfox.sdk.nativeads.Native;
import com.mobfox.sdk.nativeads.NativeAd;
import com.mobfox.sdk.nativeads.NativeListener;
import com.mobfox.sdk.nativeads.TextItem;
import com.mobfox.sdk.customevents.CustomEventNative;

import android.app.Activity;
import android.content.Context;
import android.util.DisplayMetrics;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.RelativeLayout;
import android.widget.FrameLayout;
import android.widget.Toast;

import java.util.List;

public class MobFoxForGameMakerExtension {
	
	private static MobFoxForGameMakerExtension instance;
    private static Context      mContext;

	private Banner         mBanner       = null;
	private InterstitialAd mInterstitial = null;
	private Native         mNative       = null;

	private static boolean mUseLocation = false;
	
	private static final int EVENT_OTHER_SOCIAL = 70;

	//#############################################################

    public static int CalcDPIToReal(Context ctx, int dp) {
	    DisplayMetrics metrics = ctx.getResources().getDisplayMetrics();
	    return (int)(((float)dp * metrics.density) + 0.5);
	}

	//#############################################################
	//### I N I T                                               ###
	//#############################################################
	
	public MobFoxForGameMakerExtension()
	{
		MobFoxForGameMakerExtension.instance = this;
	}
	
	public static MobFoxForGameMakerExtension instance() {
		if (instance==null)
		{
			instance = new MobFoxForGameMakerExtension();
		}
		return instance;
	}
	
	public double init_plugin(){
			Log.i("yoyo", "dbg: ### init_plugin... ###");
			MobFoxForGameMakerExtension.mContext = RunnerJNILib.ms_context;
			if (MobFoxForGameMakerExtension.mContext==null)
			{
				Log.i("yoyo", "dbg: ### init_plugin, CONTEXT==NULL ###");
				return 1;
			}
			
			Log.i("yoyo", "dbg: ### init_plugin DONE ###");
			return 0;
	}

    //#############################################################
	//### C A L L B A C K S                                     ###
	//#############################################################
    
	private void SendCallbackEvent(String type, String data)
	{
		int dsMapIndex = RunnerJNILib.jCreateDsMap(null,null,null);
		RunnerJNILib.DsMapAddString(dsMapIndex,"type",type);
		RunnerJNILib.DsMapAddString(dsMapIndex,"data",data);
		RunnerJNILib.CreateAsynEventWithDSMap(dsMapIndex,EVENT_OTHER_SOCIAL);
	}
	
	public double show_toast(final String text)
	{
		if (MobFoxForGameMakerExtension.mContext!=null)
		{
			RunnerActivity.ViewHandler.post( new Runnable() {
			public void run() 
			{	
				Toast.makeText(MobFoxForGameMakerExtension.mContext,text,Toast.LENGTH_SHORT).show();
			}});
		}	
		return 0;		
	}
	
    //#############################################################
	//### L O C A T I O N                                       ###
	//#############################################################
    
	public double set_use_location(double val){
			MobFoxForGameMakerExtension.mUseLocation = (val!=0);
			if (MobFoxForGameMakerExtension.mUseLocation)
			{
				Log.i("yoyo", "dbg: ### Set use location = TRUE ###");
			} else { 
				Log.i("yoyo", "dbg: ### Set use location = FALSE ###");
			}
            return 0;
    }
    
    //#############################################################
	//### B A N N E R                                           ###
	//#############################################################

    public double create_banner(final String hash, final double x, final double y, final double w, final double h){
		Log.i("yoyo", "dbg: ### CREATE Banner... ###");
			
		RunnerActivity.ViewHandler.post( new Runnable() {
    	public void run() 
    	{	
			createBanner(hash,(int)x,(int)y,(int)w,(int)h);
    	}});
			
		Log.i("yoyo", "dbg: ### CREATE Banner done ###");
		return 0;
    }

	public void createBanner(String myHash, int in_x, int in_y, int in_w, int in_h)
	{
    	Log.i("yoyo","dbg: ### createBanner... ###");

		if (MobFoxForGameMakerExtension.mContext==null)
		{
			Log.i("yoyo", "dbg: ### createBanner, CONTEXT==NULL ###");
			return;
		}

    	int x = MobFoxForGameMakerExtension.CalcDPIToReal(MobFoxForGameMakerExtension.mContext, in_x);
    	int y = MobFoxForGameMakerExtension.CalcDPIToReal(MobFoxForGameMakerExtension.mContext, in_y);
    	int w = MobFoxForGameMakerExtension.CalcDPIToReal(MobFoxForGameMakerExtension.mContext, in_w);
    	int h = MobFoxForGameMakerExtension.CalcDPIToReal(MobFoxForGameMakerExtension.mContext, in_h);
   	
    	if (mBanner!=null)
    	{
    		mBanner = null;
    	}
    	
    	// Removed from MobFox SDK
       	//Banner.setGetLocation(MobFoxForGameMakerExtension.mUseLocation);
    	
        mBanner = new Banner(MobFoxForGameMakerExtension.mContext, in_w, in_h);
        if (mBanner!=null)
        {
    		//final View v1 = ((Activity) MobFoxForGameMakerExtension.mContext).getWindow().getDecorView().getRootView();
    		final View v1 = RunnerActivity.CurrentActivity.getWindow().getDecorView().getRootView();
    		if (v1!=null)
    		{
    	    	FrameLayout.LayoutParams bannerParameters =
        	            new FrameLayout.LayoutParams(w,h);
				bannerParameters.leftMargin=x;
				bannerParameters.topMargin=y;
    	    	//bannerParameters.addRule(RelativeLayout.ALIGN_PARENT_LEFT);
    	    	//bannerParameters.addRule(RelativeLayout.ALIGN_PARENT_BOTTOM);   
    	    	//bannerParameters.setMargins(x, y, 0, 0);

    			((FrameLayout)v1).addView(mBanner,bannerParameters);
				
				//mBanner.setLeft(x);
    		}
        	
    		if (MobFoxForGameMakerExtension.mUseLocation)
    		{
            	Log.i("yoyo","dbg: ### banner allocated (with location) ###");
    		} else {
            	Log.i("yoyo","dbg: ### banner allocated (no location) ###");
    		}

    		mBanner.setListener(mBannerListener);

    		mBanner.setInventoryHash(myHash);
    		
    		mBanner.load();
        }
	}
	
	//-----------------------------------------------------------------------
	
	public double hide_banner()
	{
		Log.i("yoyo", "dbg: ### HIDE banner ###");
			
		RunnerActivity.ViewHandler.post( new Runnable() {
    	public void run() 
    	{	
			hideBanner(true);
    	}});
        return 0;
    }

	public double unhide_banner()
	{
		Log.i("yoyo", "dbg: ### UNHIDE banner ###");
			
		RunnerActivity.ViewHandler.post( new Runnable() {
    	public void run() 
    	{	
			hideBanner(false);
    	}});
        return 0;
    }

	public void hideBanner(boolean bHide)
    {
		if (MobFoxForGameMakerExtension.mContext==null)
		{
			Log.i("yoyo", "dbg: ### hideBanner, CONTEXT==NULL ###");
			return;
		}

    	if (mBanner==null) return;
    	
    	Log.i("yoyo","dbg: ### hideBanner ###");
		
    	mBanner.setVisibility(bHide?View.GONE:View.VISIBLE);
    }


	
	//=======================================================================
	
	private BannerListener mBannerListener = new BannerListener() {
        @Override
        public void onBannerError(View view, Exception e) {

        	Log.e("yoyo","dbg: ### onBannerError: "+e.getMessage());

        	if (MobFoxForGameMakerExtension.mContext==null) return;
            
			SendCallbackEvent("bannerError",e.getMessage());
        }

        @Override
        public void onBannerLoaded(View view) {

        	Log.i("yoyo","dbg: ### onBannerLoaded ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("bannerReady","");
        }

        @Override
        public void onBannerClosed(View view) {

        	Log.i("yoyo","dbg: ### onBannerClosed ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("bannerClosed","");
        }

        @Override
        public void onBannerClicked(View view) {

        	Log.i("yoyo","dbg: ### onBannerClicked ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("bannerClicked","");
        }

		@Override
		public void onBannerFinished() {
        	Log.i("yoyo","dbg: ### onBannerFinished ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("bannerFinished","");
		}

		@Override
		public void onNoFill(View banner) {
        	Log.e("yoyo","dbg: ### onNoFill ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("bannerError","No fill");
		}
    };
	
	//#############################################################
	//### I N T E R S T I T I A L                               ###
	//#############################################################

    public double create_interstitial(final String hash){
		Log.i("yoyo", "dbg: ### CREATE Interstitial ###");
			
		RunnerActivity.ViewHandler.post( new Runnable() {
    	public void run() 
    	{	
			createInterstitial(hash);
    	}});
        return 0;
    }

    public double show_interstitial(){
		Log.i("yoyo", "dbg: ### SHOW Interstitial ###");
			
		RunnerActivity.ViewHandler.post( new Runnable() {
    	public void run() 
    	{	
			showInterstitial();
    	}});
        return 0;
    }


    public void createInterstitial(String myHash)
    {
		Log.i("yoyo", "dbg: ### createInterstitial... ###");
		if (MobFoxForGameMakerExtension.mContext==null)
		{
			Log.i("yoyo", "dbg: ### createInterstitial, CONTEXT==NULL ###");
			return;
		}
    	
		if (MobFoxForGameMakerExtension.mUseLocation)
		{
        	Log.i("yoyo","dbg: ### createInterstitial (with location) ###");
		} else {
        	Log.i("yoyo","dbg: ### createInterstitial (no location) ###");
		}
		
       	if (mInterstitial!=null)
       	{
       		mInterstitial = null;
       	}
       	  
		// Removed from MobFox SDK
       	//Banner.setGetLocation(MobFoxForGameMakerExtension.mUseLocation);

		mInterstitial = new InterstitialAd(MobFoxForGameMakerExtension.mContext);
		
		if (mInterstitial!=null)
		{
	    	Log.i("yoyo","dbg: ### Interstitial allocated ###");
			
	    	mInterstitial.setListener(mInterstitialListener);

	    	mInterstitial.setInventoryHash(myHash);

	    	mInterstitial.load();
		}
    }

    public void showInterstitial()
    {
		if (MobFoxForGameMakerExtension.mContext==null)
		{
			Log.i("yoyo", "dbg: ### createBanner, CONTEXT==NULL ###");
			return;
		}

    	if (mInterstitial==null) return;
    	
    	Log.i("yoyo","dbg: ### showInterstitial ###");
		
    	mInterstitial.show();
    }

    //=======================================================================
	
	private InterstitialAdListener mInterstitialListener = new InterstitialAdListener() {

		@Override
		public void onInterstitialLoaded(InterstitialAd interstitial) {
        	Log.i("yoyo","dbg: ### onInterstitialLoaded ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;	    	
        	
			SendCallbackEvent("interstitialReady","");

			//@@@show_interstitial();
		}

		@Override
		public void onInterstitialFailed(InterstitialAd interstitial, Exception e) {
        	Log.i("yoyo","dbg: ### onInterstitialFailed: "+e.getMessage());

        	if (MobFoxForGameMakerExtension.mContext==null) return;	    	
        	
			SendCallbackEvent("interstitalError",e.getMessage());
		}

		@Override
		public void onInterstitialClosed(InterstitialAd interstitial) {
        	Log.i("yoyo","dbg: ### onInterstitialClosed ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("interstitialClosed","");
		
        	mInterstitial = null;
		}

		@Override
		public void onInterstitialFinished() {
        	Log.i("yoyo","dbg: ### onInterstitialFinished ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("interstitialFinished","");
		}

		@Override
		public void onInterstitialClicked(InterstitialAd interstitial) {
        	Log.i("yoyo","dbg: ### onInterstitialClicked ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("interstitialClicked","");
		}

		@Override
		public void onInterstitialShown(InterstitialAd interstitial) {
        	Log.i("yoyo","dbg: ### onInterstitialShown ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("interstitialShown","");
		}
    };
    
	//#############################################################
	//### N A T I V E                                           ###
	//#############################################################

    public double create_native(final String hash){
		Log.i("yoyo", "dbg: ### CREATE Native ###");
			
		RunnerActivity.ViewHandler.post( new Runnable() {
    	public void run() 
    	{	
			createNative(hash);
		}});
		
        return 0;
    }

    public void createNative(String myHash)
    {
		Log.i("yoyo", "dbg: ### createNative... ###");
		
		if (MobFoxForGameMakerExtension.mContext==null)
		{
			Log.i("yoyo", "dbg: ### createNative, CONTEXT==NULL ###");
			return;
		}
    	
		if (MobFoxForGameMakerExtension.mUseLocation)
		{
        	Log.i("yoyo","dbg: ### createNative (with location) ###");
		} else {
        	Log.i("yoyo","dbg: ### createNative (no location) ###");
		}
		
       	if (mNative!=null)
       	{
       		mNative = null;
       	}
       	  
		// Removed from MobFox SDK
       	//Banner.setGetLocation(MobFoxForGameMakerExtension.mUseLocation);

    	Native.setDebug(true);
    	
	    mNative = new Native(MobFoxForGameMakerExtension.mContext);
	    
	    if (mNative!=null)
	    {
	        mNative.setListener(mNativeListener);

    		mNative.load(myHash);
	    }
    }
    
    //=======================================================================
	
	private NativeListener mNativeListener = new NativeListener() {
        @Override
        public void onNativeReady(Native aNative, CustomEventNative event, NativeAd ad) {

        	Log.v("yoyo","dbg: ### onNativeReady ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;	    	
        	
        	String msg = "";
        	
            List<com.mobfox.sdk.nativeads.TextItem> texts = ad.getTexts();
            for (com.mobfox.sdk.nativeads.TextItem txt:texts)
            {
            	if (txt.getType().equalsIgnoreCase("title"))
            	{
            		if (msg.length()>0) msg = msg + "|";
            		msg = msg + "<Headline>" + txt.getText();
            	}
            	if (txt.getType().equalsIgnoreCase("desc"))
            	{
            		if (msg.length()>0) msg = msg + "|";
            		msg = msg + "<Description>" + txt.getText();
            	}
            }

            List<com.mobfox.sdk.nativeads.ImageItem> images = ad.getImages();
            for (com.mobfox.sdk.nativeads.ImageItem img:images)
            {
            	if (img.getType().equalsIgnoreCase("icon"))
            	{
            		String imgUrl = img.getUrl();
            		if (imgUrl!=null)
        			{
                       	Log.v("yoyo","dbg: ### icon: "+imgUrl);
                		if (msg.length()>0) msg = msg + "|";
                		msg = msg + "<IconImageUrl>" + imgUrl;
            		}
            	}
            	if (img.getType().equalsIgnoreCase("main"))
            	{
            		String imgUrl = img.getUrl();
            		if (imgUrl!=null)
        			{
                       	Log.v("yoyo","dbg: ### main: "+imgUrl);
                		if (msg.length()>0) msg = msg + "|";
                		msg = msg + "<MainImageUrl>" + imgUrl;
            		}
            	}
            }
            
            String clickUrl = ad.getLink();
            if ((clickUrl!=null) && (clickUrl.length()>0))
            {
               	Log.v("yoyo","dbg: ### clickUrl: "+clickUrl);
        		if (msg.length()>0) msg = msg + "|";
        		msg = msg + "<ClickUrl>" + clickUrl;
            }

           	Log.v("yoyo","dbg: ### msg: "+msg);

			SendCallbackEvent("nativeReady",msg);
        }

        @Override
        public void onNativeError(Exception e) {

        	Log.v("yoyo","dbg: ### onNativeError: "+e.getMessage());

        	if (MobFoxForGameMakerExtension.mContext==null) return;	    	
        	
			SendCallbackEvent("nativeError",e.getMessage());
        }

        @Override
        public void onNativeClick(NativeAd ad) {
        	
        	Log.v("yoyo","dbg: ### onNativeClick ###");

        	if (MobFoxForGameMakerExtension.mContext==null) return;
        	
			SendCallbackEvent("nativeClicked","");
        }

    };
}
