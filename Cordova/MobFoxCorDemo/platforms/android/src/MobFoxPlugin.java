import org.apache.cordova.CordovaWebView;
import org.apache.cordova.CallbackContext;
import org.apache.cordova.CordovaPlugin;
import org.apache.cordova.PluginResult;
import org.apache.cordova.CordovaInterface;
import android.provider.Settings;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import com.mobfox.sdk.bannerads.Banner;
import com.mobfox.sdk.bannerads.BannerListener;
import com.mobfox.sdk.customevents.CustomEventNative;
import com.mobfox.sdk.interstitialads.InterstitialAd;
import com.mobfox.sdk.interstitialads.InterstitialAdListener;
import com.mobfox.sdk.nativeads.Native;
import com.mobfox.sdk.nativeads.NativeAd;
import com.mobfox.sdk.nativeads.NativeListener;
import com.mobfox.sdk.nativeads.TextItem;

import java.util.ArrayList;
import java.util.List;

import android.app.Activity;
import android.content.Context;
import android.util.DisplayMetrics;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.RelativeLayout;
import android.widget.Toast;
import android.os.Handler;

public class MobFoxPlugin extends CordovaPlugin {

	public static final String TAG = "MobFox"; 

	private Banner         mBanner       = null;
	private InterstitialAd mInterstitial = null;
	private Native         mNative       = null;

    private static Context      mContext;
    private static MobFoxPlugin instance;
    
    private static CordovaWebView  mCordovaView;
    private CallbackContext mBannerCallback = null;
    private CallbackContext mInterstitialCallback = null;
    private CallbackContext mNativeCallback = null;
    
    private static boolean      mUseLocation = false;

	//#############################################################
	//### M I S C                                               ###
	//#############################################################

    public static int CalcDPIToReal(Context ctx, int dp) {
	    DisplayMetrics metrics = ctx.getResources().getDisplayMetrics();
	    return (int)(((float)dp * metrics.density) + 0.5);
	}

	private void MyToast(final String text)
	{
		final int duration = Toast.LENGTH_SHORT;
    	cordova.getActivity().runOnUiThread(new Runnable() {
			public void run() {
				Toast toast = Toast.makeText(cordova.getActivity().getApplicationContext(), text, Toast.LENGTH_SHORT);
				toast.show();
			}
		});
	}	
	
	//#############################################################
	//### I N I T                                               ###
	//#############################################################

	public MobFoxPlugin() {
    	MobFoxPlugin.instance = this;
	}
 
    public static MobFoxPlugin instance() {
        if(instance == null) {
            instance = new MobFoxPlugin();
        }
        return instance;
    }
 
    public void setContext(Context context) {
    	MobFoxPlugin.mContext = context;
    }

	//#############################################################
	//### C O R D O V A                                         ###
	//#############################################################

	public void initialize(CordovaInterface cordova, CordovaWebView webView) {
		super.initialize(cordova, webView);
		Log.v(TAG,"Init MobFoxPlugin");
		
		MobFoxPlugin.mContext     = cordova.getActivity();
		MobFoxPlugin.mCordovaView = webView;
		MobFoxPlugin.mUseLocation = false;
	}

	public boolean execute(final String action, JSONArray args, CallbackContext callbackContext) throws JSONException
	{
    	if (action.equals("setUseLocation")) 
    	{
    		JSONObject dict = new JSONObject(args.getString(0));
    		if (dict!=null)
    		{
    			MobFoxPlugin.mUseLocation = dict.getBoolean("useLocation"); 	
    			
    			if (MobFoxPlugin.mUseLocation)
    			{
					Log.v(TAG,"### setUseLocation=TRUE ###");
    			} else {
					Log.v(TAG,"### setUseLocation=FALSE ###");
    			}
    			
        		return true;
    		}
    	}
    	
    	if (action.equals("showBanner")) 
    	{
    		mBannerCallback = callbackContext;
    	
    		JSONObject dict = new JSONObject(args.getString(0));
    		if (dict!=null)
    		{
	        	final String hash = dict.getString("hash");
    	    	final int    x    = dict.getInt("x");
        		final int    y    = dict.getInt("y");
        		final int    w    = dict.getInt("w");
        		final int    h    = dict.getInt("h");
       
	           	cordova.getActivity().runOnUiThread(new Runnable() {
				public void run() {
	        		showBanner(hash, x, y, w, h);
					}
				});
 	
        		return true;
    		}
    	}
    	
    	if (action.equals("hideBanner")) 
    	{
    		mInterstitialCallback = callbackContext;
    	
	           	cordova.getActivity().runOnUiThread(new Runnable() {
				public void run() {
		        	hideBanner();
					}
				});
        	return true;
    	}
    	
    	if (action.equals("unhideBanner")) 
    	{
    		mInterstitialCallback = callbackContext;
    	
	           	cordova.getActivity().runOnUiThread(new Runnable() {
				public void run() {
		        	unhideBanner();
					}
				});
        	return true;
    	}
    	
    	if (action.equals("createInterstitial")) 
    	{
    		mInterstitialCallback = callbackContext;
    	
    		JSONObject dict = new JSONObject(args.getString(0));
    		if (dict!=null)
    		{
	        	final String hash = dict.getString("hash");
	        
	           	cordova.getActivity().runOnUiThread(new Runnable() {
				public void run() {
	        		createInterstitial(hash);
					}
				});
	        	return true;
	        }
    	}
    	
    	if (action.equals("showInterstitial")) 
    	{
    		mInterstitialCallback = callbackContext;
    	
	           	cordova.getActivity().runOnUiThread(new Runnable() {
				public void run() {
		        	showInterstitial();
					}
				});
        	return true;
    	}
        
    	if (action.equals("createNative")) 
    	{
    		mNativeCallback = callbackContext;
    	
    		JSONObject dict = new JSONObject(args.getString(0));
    		if (dict!=null)
    		{
	        	final String hash = dict.getString("hash");
	        
	           	cordova.getActivity().runOnUiThread(new Runnable() {
				public void run() {
	        		createNative(hash);
					}
				});
	        	return true;
	        }
    	}
    	
        if (action.equals("showToast"))
        {
            JSONObject dict = new JSONObject(args.getString(0));
            if (dict!=null)
            {
                String text = dict.getString("text");
                
                MyToast(text);
                return true;
            }
        }
	
    	return true;
	}
	
	private void SendCallback(CallbackContext trgCallback, boolean bOK, String text)
	{
		if (trgCallback!=null)
		{
			PluginResult pluginResult;
			
			if (bOK)
			{
				pluginResult = new PluginResult(PluginResult.Status.OK, text);
			} else {
				pluginResult = new PluginResult(PluginResult.Status.ERROR, text);
			}
			pluginResult.setKeepCallback(true);
			trgCallback.sendPluginResult(pluginResult);
		}
	}

    //#############################################################
	//### B A N N E R                                           ###
	//#############################################################

	private void showBanner(String myHash, int in_x, int in_y, int in_w, int in_h)
	{
		if (MobFoxPlugin.mContext==null) return;

    	int x = MobFoxPlugin.CalcDPIToReal(MobFoxPlugin.mContext, in_x);
    	int y = MobFoxPlugin.CalcDPIToReal(MobFoxPlugin.mContext, in_y);
    	int w = MobFoxPlugin.CalcDPIToReal(MobFoxPlugin.mContext, in_w);
    	int h = MobFoxPlugin.CalcDPIToReal(MobFoxPlugin.mContext, in_h);
    	
    	if (mBanner!=null)
    	{
    		mBanner = null;
    	}
    	
        // removed after build 1.02: "setLocation" is done in the manifest
    	//Banner.setGetLocation(MobFoxPlugin.mUseLocation);
    	
        mBanner = new Banner(MobFoxPlugin.mContext, in_w, in_h);
        if (mBanner!=null)
        {
    		final View v1 = ((Activity) MobFoxPlugin.mContext).getWindow().getDecorView().getRootView();
    		//final View v1 = MobFoxPlugin.mCordovaView;
    		if (v1!=null)
    		{
    	    	RelativeLayout.LayoutParams parentParameters = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.FILL_PARENT,RelativeLayout.LayoutParams.FILL_PARENT);
				RelativeLayout rel = new RelativeLayout(MobFoxPlugin.mContext);
    			((ViewGroup)v1).addView(rel,parentParameters);

    	    	RelativeLayout.LayoutParams bannerParameters = new RelativeLayout.LayoutParams(w,h);
    	    	bannerParameters.addRule(RelativeLayout.ALIGN_PARENT_LEFT);
    	    	bannerParameters.addRule(RelativeLayout.ALIGN_PARENT_TOP);   
    	    	bannerParameters.setMargins(x, y, 0, 0);

    			((ViewGroup)rel).addView(mBanner,bannerParameters);
   			}
        	
    		mBanner.setListener(mBannerListener);

    		mBanner.setInventoryHash(myHash);
  
    		mBanner.load();
        }
	}

	private void hideBanner()
	{
		Log.v(TAG,"dbg: ### CorPlugin: hideBanner ###");

    	if (MobFoxPlugin.mContext==null) return;
    	if (mBanner==null) return;
    	
    	mBanner.setVisibility(View.GONE);
	}

	private void unhideBanner()
	{
		Log.v(TAG,"dbg: ### CorPlugin: unhideBanner ###");

    	if (MobFoxPlugin.mContext==null) return;
    	if (mBanner==null) return;
    	
    	mBanner.setVisibility(View.VISIBLE);
	}

	//=======================================================================
	
	private BannerListener mBannerListener = new BannerListener() {
        @Override
        public void onBannerError(View view, Exception e) {

        	Log.e(TAG,"dbg: ### onBannerError: "+e.getMessage());

        	if (MobFoxPlugin.mContext==null) return;
            
            SendCallback(mBannerCallback, false, e.getMessage());
        }

        @Override
        public void onBannerLoaded(View view) {

        	Log.v(TAG,"dbg: ### onBannerLoaded ###");
        	
        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mBannerCallback, true, "onBannerLoaded");
        }

        @Override
        public void onBannerClosed(View view) {

        	Log.v(TAG,"dbg: ### onBannerClosed ###");

        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mBannerCallback, true, "onBannerClosed");
        }

        @Override
        public void onBannerClicked(View view) {

        	Log.v(TAG,"dbg: ### onBannerClicked ###");

        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mBannerCallback, true, "onBannerClicked");
        }

		@Override
		public void onBannerFinished() {
        	Log.v(TAG,"dbg: ### onBannerFinished ###");

        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mBannerCallback, true, "onBannerFinished");
		}

		@Override
		public void onNoFill(View banner) {
        	Log.e(TAG,"dbg: ### onNoFill ###");

        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mBannerCallback, false, "No fill");
		}
    };
	

	//#############################################################
	//### I N T E R S T I T I A L                               ###
	//#############################################################

	private void createInterstitial(String myHash)
	{
		Log.v(TAG,"dbg: ### CorPlugin: createInterstitial ###");

    	if (MobFoxPlugin.mContext==null) return;
    	
       	if (mInterstitial!=null)
       	{
       		mInterstitial = null;
       	}
    	
        // removed after build 1.02: "setLocation" is done in the manifest
    	//Banner.setGetLocation(MobFoxPlugin.mUseLocation);
       	
		mInterstitial = new InterstitialAd(MobFoxPlugin.mContext);
		
		if (mInterstitial!=null)
		{
	    	mInterstitial.setListener(mInterstitialListener);

	    	mInterstitial.setInventoryHash(myHash);

	    	mInterstitial.load();
		}
	}

	private void showInterstitial()
	{
		Log.v(TAG,"dbg: ### CorPlugin: showInterstitial ###");

    	if (MobFoxPlugin.mContext==null) return;
    	if (mInterstitial==null) return;
    	
    	mInterstitial.show();
	}

    //=======================================================================
	
	private InterstitialAdListener mInterstitialListener = new InterstitialAdListener() {

		@Override
		public void onInterstitialLoaded(InterstitialAd interstitial) {
        	Log.v(TAG,"dbg: ### onInterstitialLoaded ###");

        	if (MobFoxPlugin.mContext==null) return;	    	
        	
            SendCallback(mInterstitialCallback, true, "onInterstitialLoaded");
            
            //showInterstitial();
		}

		@Override
		public void onInterstitialFailed(InterstitialAd interstitial, Exception e) {
        	Log.v(TAG,"dbg: ### onInterstitialFailed: "+e.getMessage());

        	if (MobFoxPlugin.mContext==null) return;	    	
        	
            SendCallback(mInterstitialCallback, false, e.getMessage());
		}

		@Override
		public void onInterstitialClosed(InterstitialAd interstitial) {
        	Log.v(TAG,"dbg: ### onInterstitialClosed ###");

        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mInterstitialCallback, true, "onInterstitialClosed");
		
        	mInterstitial = null;
		}

		@Override
		public void onInterstitialFinished() {
        	Log.v(TAG,"dbg: ### onInterstitialFinished ###");

        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mInterstitialCallback, true, "onInterstitialFinished");
		}

		@Override
		public void onInterstitialClicked(InterstitialAd interstitial) {
        	Log.v(TAG,"dbg: ### onInterstitialClicked ###");

        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mInterstitialCallback, true, "onInterstitialClicked");
		}

		@Override
		public void onInterstitialShown(InterstitialAd interstitial) {
        	Log.v(TAG,"dbg: ### onInterstitialShown ###");

        	if (MobFoxPlugin.mContext==null) return;
        	
            SendCallback(mInterstitialCallback, true, "onInterstitialShown");
		}
    };


	//#############################################################
	//### N A T I V E                                           ###
	//#############################################################

    public void createNative(String myHash)
    {
    	Log.v(TAG,"dbg: ### createNative ###");

    	if (MobFoxPlugin.mContext==null) return;

    	if (mNative!=null)
    	{
    		mNative = null;
    	}
    	
    	Native.setDebug(true);
    	
	    mNative = new Native(MobFoxPlugin.mContext);
	    
        mNative.setListener(mNativeListener);

        if (myHash.startsWith("1122334455667788"))
        {
        	TriggerEmulateNativeAd();
        } else {
        	mNative.load(myHash);
        }
    }
	
    //=======================================================================
	
	private NativeListener mNativeListener = new NativeListener() {
        @Override
        public void onNativeReady(Native aNative, CustomEventNative event, NativeAd ad) {

        	Log.v(TAG,"dbg: ### onNativeReady ###");

        	if (MobFoxPlugin.mContext==null) return;	    	
        	
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
                       	Log.v(TAG,"dbg: ### icon: "+imgUrl);
                		if (msg.length()>0) msg = msg + "|";
                		msg = msg + "<IconImageUrl>" + imgUrl;
            		}
            	}
            	if (img.getType().equalsIgnoreCase("main"))
            	{
            		String imgUrl = img.getUrl();
            		if (imgUrl!=null)
        			{
                       	Log.v(TAG,"dbg: ### main: "+imgUrl);
                		if (msg.length()>0) msg = msg + "|";
                		msg = msg + "<MainImageUrl>" + imgUrl;
            		}
            	}
            }
            
            String clickUrl = ad.getLink();
            if ((clickUrl!=null) && (clickUrl.length()>0))
            {
               	Log.v(TAG,"dbg: ### clickUrl: "+clickUrl);
        		if (msg.length()>0) msg = msg + "|";
        		msg = msg + "<ClickUrl>" + clickUrl;
            }

           	Log.v(TAG,"dbg: ### msg: "+msg);

            SendCallback(mNativeCallback, true, msg);

            /*
            //register custom layout click
            event.registerViewForInteraction(layout);

            ad.fireTrackers(Main.this);

            headline.setText(ad.getHeadline());

            ad.loadImages(Main.this, new NativeAd.ImagesLoadedListener() {
                @Override
                public void onImagesLoaded(NativeAd ad) {

                	Log.v(TAG,"dbg: ### onImagesLoaded ###");

                    nativeIcon.setImageBitmap(ad.getMain());
                    nativeMainImg.setImageBitmap(ad.getIcon());

                }
            });
			*/
        }

        @Override
        public void onNativeError(Exception e) {

        	Log.v(TAG,"dbg: ### onNativeError: "+e.getMessage());

        	if (MobFoxPlugin.mContext==null) return;	    	

            SendCallback(mNativeCallback, false, e.getMessage());
        }

        @Override
        public void onNativeClick(NativeAd ad) {
        	
        	Log.v(TAG,"dbg: ### onNativeClick ###");

        	if (MobFoxPlugin.mContext==null) return;

            SendCallback(mNativeCallback, true, "nativeClicked");
        }

    };
	

    // ##########################################################################

    private Handler mEmulateNativeAdHandler   = new Handler();
    private long    mEmulateNativeAdStartTime = 0;

    private Runnable mEmulateNativeAdTask = new Runnable() {
        public void run()
        {
            mEmulateNativeAdHandler.removeCallbacks(mEmulateNativeAdTask);
            mEmulateNativeAdStartTime = 0;

            com.mobfox.sdk.nativeads.NativeAd nativeAd = new com.mobfox.sdk.nativeads.NativeAd();

            String title = "Debug native ad title";
            String body  = "Debug native ad body: bla bla bla, Lorem ipsum and so and so and so...";

            ArrayList<TextItem> texts  = new ArrayList<com.mobfox.sdk.nativeads.TextItem>();
            com.mobfox.sdk.nativeads.TextItem titleItem = new com.mobfox.sdk.nativeads.TextItem("title", title);
            com.mobfox.sdk.nativeads.TextItem descItem  = new com.mobfox.sdk.nativeads.TextItem("desc", body);
            texts.add(titleItem);
            texts.add(descItem);
            nativeAd.setTexts(texts);

            ArrayList<com.mobfox.sdk.nativeads.ImageItem> images = new ArrayList<com.mobfox.sdk.nativeads.ImageItem>();
            com.mobfox.sdk.nativeads.ImageItem iconItem = new com.mobfox.sdk.nativeads.ImageItem("icon", "http://creative1cdn.mobfox.com/mftext/80x80/315C93/fff&text=MobFoxTestAd", 80, 80);
            com.mobfox.sdk.nativeads.ImageItem mainItem = new com.mobfox.sdk.nativeads.ImageItem("main", "http://creative1cdn.mobfox.com/mftext/1200x627/315C93/fff&text=MobFoxTestAd", 627, 1200);
            images.add(iconItem);
            images.add(mainItem);
            nativeAd.setImages(images);

            String link = "http://www.shsh.com";
            nativeAd.setLink(link);

            mNativeListener.onNativeReady(null, null, nativeAd);
        }
    };

    private void TriggerEmulateNativeAd()
    {
        if (mEmulateNativeAdStartTime == 0L)
        {
            mEmulateNativeAdStartTime = System.currentTimeMillis();
            mEmulateNativeAdHandler.removeCallbacks(mEmulateNativeAdTask);
            mEmulateNativeAdHandler.postDelayed(mEmulateNativeAdTask, 1000);
        }
    }
}
