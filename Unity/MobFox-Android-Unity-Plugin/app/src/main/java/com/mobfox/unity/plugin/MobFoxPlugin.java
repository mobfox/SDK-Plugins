package com.mobfox.unity.plugin;

import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.os.Handler;
import android.util.DisplayMetrics;
import android.util.Log;
import android.view.Gravity;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.view.WindowManager;
import android.widget.FrameLayout;
import android.widget.PopupWindow;
import android.widget.RelativeLayout;
import android.widget.Toast;

import com.mobfox.sdk.bannerads.Banner;
import com.mobfox.sdk.bannerads.BannerListener;
import com.mobfox.sdk.customevents.CustomEventNative;
import com.mobfox.sdk.interstitialads.InterstitialAd;
import com.mobfox.sdk.interstitialads.InterstitialAdListener;
import com.mobfox.sdk.nativeads.Native;
import com.mobfox.sdk.nativeads.NativeAd;
import com.mobfox.sdk.nativeads.NativeListener;
import com.mobfox.sdk.nativeads.TextItem;
import com.unity3d.player.UnityPlayer;

import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.ArrayList;
import java.util.List;

public class MobFoxPlugin
{
    private static final String MYTAG = "Unity";

    private Banner         mBanner       = null;
    private InterstitialAd mInterstitial = null;
    private Native         mNative       = null;

    private static Context      mContext;
    private static MobFoxPlugin instance;
    private static String       mGameObjectId = null;

    /**
     * The {@code PopupWindow} that the banner ad be displayed in to ensure banner ads will be
     * presented over a {@code SurfaceView}.
     */
    private PopupWindow mPopupWindow;

    // removed after build 1.02: "setLocation" is done in the manifest
    //private static boolean      mUseLocation  = false;

    //#############################################################

    public static int CalcDPIToReal(Context ctx, int dp) {
        DisplayMetrics metrics = ctx.getResources().getDisplayMetrics();
        return (int)(((float)dp * metrics.density) + 0.5);
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

    public void showMessage(String message) {
        Toast.makeText(MobFoxPlugin.mContext, message, Toast.LENGTH_SHORT).show();
    }

    public void setGameObject(String gameObjectId) {
        MobFoxPlugin.mGameObjectId = gameObjectId;
    }

    //#############################################################
    //### L O C A T I O N                                       ###
    //#############################################################

    // removed after build 1.02: "setLocation" is done in the manifest
    //public void setUseLocation(boolean bUseLocation)
    //{
    //	MobFoxPlugin.mUseLocation = bUseLocation;
    //}

    //#############################################################
    //### B A N N E R                                           ###
    //#############################################################

    public void createBanner(String myHash, int in_x, int in_y, int in_w, int in_h, boolean smart)
    {
        Log.v(MYTAG,"dbg: ### createBanner ###");

        if (MobFoxPlugin.mContext==null) return;

        if (mBanner!=null)
        {
            mBanner.setVisibility(View.GONE);

            mPopupWindow.dismiss();
            ViewParent parentView = mBanner.getParent();
            if (parentView != null && parentView instanceof ViewGroup) {
                ((ViewGroup) parentView).removeView(mBanner);
            }

            mBanner = null;
        }

        int x = MobFoxPlugin.CalcDPIToReal(MobFoxPlugin.mContext, in_x);
        int y = MobFoxPlugin.CalcDPIToReal(MobFoxPlugin.mContext, in_y);
        int w = MobFoxPlugin.CalcDPIToReal(MobFoxPlugin.mContext, in_w);
        int h = MobFoxPlugin.CalcDPIToReal(MobFoxPlugin.mContext, in_h);

        mBanner = new Banner(MobFoxPlugin.mContext, in_w, in_h);

        if (mBanner!=null)
        {
            if (smart)
            {
                final ViewGroup v1 = (ViewGroup) ((ViewGroup) ((Activity) MobFoxPlugin.mContext)
                        .findViewById(android.R.id.content)).getChildAt(0);
                int scrW = v1.getWidth();

                createPopupWindow(w,h);
                showPopUpWindow((scrW-w)/2,y);
            } else {
                createPopupWindow(w,h);
                showPopUpWindow(x,y);
            }


            /*
            final ViewGroup v1 = (ViewGroup) ((ViewGroup) ((Activity) MobFoxPlugin.mContext)
                .findViewById(android.R.id.content)).getChildAt(0);

            if (v1!=null)
            {
//                showMessage("v1 type " + v1.getClass().getName());

                FrameLayout.LayoutParams params;

                if (smart) {
                    RelativeLayout rl = new RelativeLayout(mContext);
                    rl.setBackgroundColor(Color.parseColor("#000000"));
                    RelativeLayout.LayoutParams lp = new RelativeLayout.LayoutParams(v1.getWidth(), h);
                    lp.topMargin = y;
                    rl.setLayoutParams(lp);
                    v1.addView(rl);

                    RelativeLayout.LayoutParams bParams = new RelativeLayout.LayoutParams(w, h);
                    int left = (v1.getWidth() - w) / 2;

                    bParams.leftMargin = left;
                    rl.addView(mBanner, bParams);

                } else {

                    params = new FrameLayout.LayoutParams(w, h);
                    params.setMargins(x, y, 0, 0);
                    v1.addView(mBanner, params);
                }
            }
            */

            Log.v(MYTAG,"dbg: ### banner allocated ###");

            mBanner.setListener(mBannerListener);
            mBanner.setInventoryHash(myHash);
            mBanner.load();
        }
    }

    private void createPopupWindow(int width, int height)
    {
        // Workaround for issue where popUpWindow will not resize to the full width
        // of the screen to accommodate a smart banner.
        int popUpWindowWidth  = width;
        int popUpWindowHeight = height;
        mPopupWindow = new PopupWindow(mBanner, popUpWindowWidth, popUpWindowHeight);

        // Copy system UI visibility flags set on Unity player window to newly created PopUpWindow.
        int visibilityFlags = ((Activity)MobFoxPlugin.mContext).getWindow().getAttributes().flags;
        mPopupWindow.getContentView().setSystemUiVisibility(visibilityFlags);

        // Workaround to prevent ad views from losing visibility on activity changes for certain
        // devices (eg. Huawei devices).
        setPopUpWindowLayoutType(mPopupWindow,
                WindowManager.LayoutParams.TYPE_APPLICATION_SUB_PANEL);
    }

    private void showPopUpWindow(int x, int y) {
        mPopupWindow.showAtLocation(
                ((Activity)MobFoxPlugin.mContext).getWindow().getDecorView().getRootView(),
                Gravity.NO_GRAVITY, (int) x, (int)y);
    }


    public void setPopUpWindowLayoutType(PopupWindow popupWindow, int layoutType) {
        try {
            Method method = PopupWindow.class.getDeclaredMethod("setWindowLayoutType", int.class);
            method.setAccessible(true);
            method.invoke(popupWindow, layoutType);
        } catch (NoSuchMethodException exception) {
            Log.w(MYTAG, String.format("Unable to set popUpWindow window layout type: %s",
                    exception.getLocalizedMessage()));
        } catch (IllegalAccessException exception) {
            Log.w(MYTAG, String.format("Unable to set popUpWindow window layout type: %s",
                    exception.getLocalizedMessage()));
        } catch (InvocationTargetException exception) {
            Log.d(MYTAG, String.format("Unable to set popUpWindow window layout type: %s",
                    exception.getLocalizedMessage()));
        }
    }

    //=======================================================================

    public void hideBanner()
    {
        if (mBanner!=null)
        {
            mBanner.setVisibility(View.GONE);
        }
    }

    //=======================================================================

    public void showBanner()
    {
        if (mBanner!=null)
        {
            mBanner.setVisibility(View.VISIBLE);
        }
    }

    //=======================================================================

    private BannerListener mBannerListener = new BannerListener() {
        @Override
        public void onBannerError(View view, Exception e) {

            Log.e(MYTAG,"dbg: ### onBannerError: "+e.getMessage());

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "bannerError", e.getMessage());
        }

        @Override
        public void onBannerLoaded(View view) {

            Log.v(MYTAG,"dbg: ### onBannerLoaded ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "bannerReady", "");
        }

        @Override
        public void onBannerClosed(View view) {

            Log.v(MYTAG,"dbg: ### onBannerClosed ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "bannerClosed", "");
        }

        @Override
        public void onBannerClicked(View view) {

            Log.v(MYTAG,"dbg: ### onBannerClicked ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "bannerClicked", "");
        }

        @Override
        public void onBannerFinished() {
            Log.v(MYTAG,"dbg: ### onBannerFinished ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "bannerFinished", "");
        }

        @Override
        public void onNoFill(View banner) {
            Log.e(MYTAG,"dbg: ### onNoFill ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "bannerError", "No fill");
        }
    };

    //#############################################################
    //### I N T E R S T I T I A L                               ###
    //#############################################################

    public void createInterstitial(String myHash)
    {
        if (MobFoxPlugin.mContext==null) return;

        Log.v(MYTAG,"dbg: ### createInterstitial ###");

        if (mInterstitial!=null)
        {
            mInterstitial = null;
        }

        // removed after build 1.02: "setLocation" is done in the manifest
        //Banner.setGetLocation(MobFoxPlugin.mUseLocation);

        mInterstitial = new InterstitialAd(MobFoxPlugin.mContext);

        if (mInterstitial!=null)
        {
            Log.v(MYTAG,"dbg: ### Interstitial allocated ###");

            mInterstitial.setListener(mInterstitialListener);

            mInterstitial.setInventoryHash(myHash);

            mInterstitial.load();
        }
    }

    public void showInterstitial()
    {
        if (MobFoxPlugin.mContext==null) return;
        if (mInterstitial==null) return;

        Log.v(MYTAG,"dbg: ### showInterstitial ###");

        mInterstitial.show();
    }

    //=======================================================================

    private InterstitialAdListener mInterstitialListener = new InterstitialAdListener() {

        @Override
        public void onInterstitialLoaded(InterstitialAd interstitial) {
            Log.v(MYTAG,"dbg: ### onInterstitialLoaded ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "interstitialReady", "");
        }

        @Override
        public void onInterstitialFailed(InterstitialAd interstitial, Exception e) {
            Log.v(MYTAG,"dbg: ### onInterstitialFailed: "+e.getMessage());

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "interstitalError", e.getMessage());
        }

        @Override
        public void onInterstitialClosed(InterstitialAd interstitial) {
            Log.v(MYTAG,"dbg: ### onInterstitialClosed ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "interstitialClosed", "");

            mInterstitial = null;
        }

        @Override
        public void onInterstitialFinished() {
            Log.v(MYTAG,"dbg: ### onInterstitialFinished ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "interstitialFinished", "");
        }

        @Override
        public void onInterstitialClicked(InterstitialAd interstitial) {
            Log.v(MYTAG,"dbg: ### onInterstitialClicked ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "interstitialClicked", "");
        }

        @Override
        public void onInterstitialShown(InterstitialAd interstitial) {
            Log.v(MYTAG,"dbg: ### onInterstitialShown ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "interstitialShown", "");
        }
    };

    //#############################################################
    //### N A T I V E                                           ###
    //#############################################################

    public void createNative(String myHash)
    {
        Log.v(MYTAG,"dbg: ### createNative ###");

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

    private NativeListener mNativeListener = new NativeListener() {
        @Override
        public void onNativeReady(Native aNative, CustomEventNative event, NativeAd ad) {

            Log.v(MYTAG,"dbg: ### onNativeReady ###");

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
                        Log.v(MYTAG,"dbg: ### icon: "+imgUrl);
                        if (msg.length()>0) msg = msg + "|";
                        msg = msg + "<IconImageUrl>" + imgUrl;
                    }
                }
                if (img.getType().equalsIgnoreCase("main"))
                {
                    String imgUrl = img.getUrl();
                    if (imgUrl!=null)
                    {
                        Log.v(MYTAG,"dbg: ### main: "+imgUrl);
                        if (msg.length()>0) msg = msg + "|";
                        msg = msg + "<MainImageUrl>" + imgUrl;
                    }
                }
            }

            String clickUrl = ad.getLink();
            if ((clickUrl!=null) && (clickUrl.length()>0))
            {
                Log.v(MYTAG,"dbg: ### clickUrl: "+clickUrl);
                if (msg.length()>0) msg = msg + "|";
                msg = msg + "<ClickUrl>" + clickUrl;
            }

            Log.v(MYTAG,"dbg: ### msg: "+msg);

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "nativeReady", msg);

            /*
            //register custom layout click
            event.registerViewForInteraction(layout);

            ad.fireTrackers(Main.this);

            headline.setText(ad.getHeadline());

            ad.loadImages(Main.this, new NativeAd.ImagesLoadedListener() {
                @Override
                public void onImagesLoaded(NativeAd ad) {

                	Log.v(MYTAG,"dbg: ### onImagesLoaded ###");

                    nativeIcon.setImageBitmap(ad.getMain());
                    nativeMainImg.setImageBitmap(ad.getIcon());

                }
            });
			*/
        }

        @Override
        public void onNativeError(Exception e) {

            Log.v(MYTAG,"dbg: ### onNativeError: "+e.getMessage());

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "nativeError", e.getMessage());
        }

        @Override
        public void onNativeClick(NativeAd ad) {

            Log.v(MYTAG,"dbg: ### onNativeClick ###");

            if (MobFoxPlugin.mContext==null) return;

            if (MobFoxPlugin.mGameObjectId!=null) UnityPlayer.UnitySendMessage(MobFoxPlugin.mGameObjectId, "nativeClicked", "");
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