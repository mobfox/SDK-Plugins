using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Webview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/webview/MobFoxWebView", DoNotGenerateAcw=true)]
	public partial class MobFoxWebView : global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='DEFAULT_WATERFALLS']"
		[Register ("DEFAULT_WATERFALLS")]
		public const string DefaultWaterfalls = (string) "";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='DOMAIN']"
		[Register ("DOMAIN")]
		public const string Domain = (string) "sdk.starbolt.io";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='LOAD_AD_LISTENER']"
		[Register ("LOAD_AD_LISTENER")]
		public const string LoadAdListener = (string) "loadAdListener";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='MOBFOX_BRIDGE']"
		[Register ("MOBFOX_BRIDGE")]
		public const string MobfoxBridge = (string) "http://sdk.starbolt.io/dist/WebViewJavascriptBridge.js";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='MOBFOX_JS']"
		[Register ("MOBFOX_JS")]
		public const string MobfoxJs = (string) "http://sdk.starbolt.io/dist/sdk_videoAndroid.js";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='MOBFOX_URL']"
		[Register ("MOBFOX_URL")]
		public const string MobfoxUrl = (string) "http://sdk.starbolt.io/dist/mobfox.html";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='MOBFOX_URL_HTTPS']"
		[Register ("MOBFOX_URL_HTTPS")]
		public const string MobfoxUrlHttps = (string) "https://sdk.starbolt.io/dist/mobfox.html";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='WATERFALL_CONNECTION_EXCEPTION']"
		[Register ("WATERFALL_CONNECTION_EXCEPTION")]
		public const string WaterfallConnectionException = (string) "failed to connect to sdk.starbolt.io";

		static IntPtr loadBannerStarted_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/field[@name='loadBannerStarted']"
		[Register ("loadBannerStarted")]
		public long LoadBannerStarted {
			get {
				if (loadBannerStarted_jfieldId == IntPtr.Zero)
					loadBannerStarted_jfieldId = JNIEnv.GetFieldID (class_ref, "loadBannerStarted", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, loadBannerStarted_jfieldId);
			}
			set {
				if (loadBannerStarted_jfieldId == IntPtr.Zero)
					loadBannerStarted_jfieldId = JNIEnv.GetFieldID (class_ref, "loadBannerStarted", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, loadBannerStarted_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/webview/MobFoxWebView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxWebView); }
		}

		protected MobFoxWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/constructor[@name='MobFoxWebView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.webview.MobFoxWebViewLoadAdListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V", "")]
		public unsafe MobFoxWebView (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MobFoxWebView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_, __args);
			} finally {
			}
		}

		static Delegate cb_getRenderAdListener;
#pragma warning disable 0169
		static Delegate GetGetRenderAdListenerHandler ()
		{
			if (cb_getRenderAdListener == null)
				cb_getRenderAdListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRenderAdListener);
			return cb_getRenderAdListener;
		}

		static IntPtr n_GetRenderAdListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RenderAdListener);
		}
#pragma warning restore 0169

		static Delegate cb_setRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_;
#pragma warning disable 0169
		static Delegate GetSetRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_Handler ()
		{
			if (cb_setRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_ == null)
				cb_setRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_);
			return cb_setRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_;
		}

		static void n_SetRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener p0 = (global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderAdListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRenderAdListener;
		static IntPtr id_setRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_;
		public virtual unsafe global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener RenderAdListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='getRenderAdListener' and count(parameter)=0]"
			[Register ("getRenderAdListener", "()Lcom/mobfox/sdk/webview/MobFoxWebViewRenderAdListener;", "GetGetRenderAdListenerHandler")]
			get {
				if (id_getRenderAdListener == IntPtr.Zero)
					id_getRenderAdListener = JNIEnv.GetMethodID (class_ref, "getRenderAdListener", "()Lcom/mobfox/sdk/webview/MobFoxWebViewRenderAdListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRenderAdListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRenderAdListener", "()Lcom/mobfox/sdk/webview/MobFoxWebViewRenderAdListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='setRenderAdListener' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebViewRenderAdListener']]"
			[Register ("setRenderAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewRenderAdListener;)V", "GetSetRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_Handler")]
			set {
				if (id_setRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_ == IntPtr.Zero)
					id_setRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_ = JNIEnv.GetMethodID (class_ref, "setRenderAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewRenderAdListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRenderAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewRenderAdListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRenderAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewRenderAdListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoBridge;
#pragma warning disable 0169
		static Delegate GetGetVideoBridgeHandler ()
		{
			if (cb_getVideoBridge == null)
				cb_getVideoBridge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoBridge);
			return cb_getVideoBridge;
		}

		static IntPtr n_GetVideoBridge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoBridge);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoBridge;
		public virtual unsafe global::Com.Mobfox.Sdk.Video.VideoBridge VideoBridge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='getVideoBridge' and count(parameter)=0]"
			[Register ("getVideoBridge", "()Lcom/mobfox/sdk/video/VideoBridge;", "GetGetVideoBridgeHandler")]
			get {
				if (id_getVideoBridge == IntPtr.Zero)
					id_getVideoBridge = JNIEnv.GetMethodID (class_ref, "getVideoBridge", "()Lcom/mobfox/sdk/video/VideoBridge;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VideoBridge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoBridge), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VideoBridge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoBridge", "()Lcom/mobfox/sdk/video/VideoBridge;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_loadAd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadAd_Ljava_lang_String_Handler ()
		{
			if (cb_loadAd_Ljava_lang_String_ == null)
				cb_loadAd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadAd_Ljava_lang_String_);
			return cb_loadAd_Ljava_lang_String_;
		}

		static void n_LoadAd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadAd_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='loadAd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadAd", "(Ljava/lang/String;)V", "GetLoadAd_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadAd (string p0)
		{
			if (id_loadAd_Ljava_lang_String_ == IntPtr.Zero)
				id_loadAd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAd", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_renderAd_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetRenderAd_Lorg_json_JSONObject_Handler ()
		{
			if (cb_renderAd_Lorg_json_JSONObject_ == null)
				cb_renderAd_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderAd_Lorg_json_JSONObject_);
			return cb_renderAd_Lorg_json_JSONObject_;
		}

		static void n_RenderAd_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderAd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_renderAd_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='renderAd' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("renderAd", "(Lorg/json/JSONObject;)V", "GetRenderAd_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void RenderAd (global::Org.Json.JSONObject p0)
		{
			if (id_renderAd_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_renderAd_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "renderAd", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_renderAd_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renderAd", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_;
#pragma warning disable 0169
		static Delegate GetSetLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_Handler ()
		{
			if (cb_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ == null)
				cb_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_);
			return cb_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_;
		}

		static void n_SetLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener p0 = (global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLoadAdListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='setLoadAdListener' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebViewLoadAdListener']]"
		[Register ("setLoadAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V", "GetSetLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_Handler")]
		public virtual unsafe void SetLoadAdListener (global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener p0)
		{
			if (id_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ == IntPtr.Zero)
				id_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ = JNIEnv.GetMethodID (class_ref, "setLoadAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoadAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setReady_Z;
#pragma warning disable 0169
		static Delegate GetSetReady_ZHandler ()
		{
			if (cb_setReady_Z == null)
				cb_setReady_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReady_Z);
			return cb_setReady_Z;
		}

		static void n_SetReady_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReady (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setReady_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='setReady' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setReady", "(Z)V", "GetSetReady_ZHandler")]
		public virtual unsafe void SetReady (bool p0)
		{
			if (id_setReady_Z == IntPtr.Zero)
				id_setReady_Z = JNIEnv.GetMethodID (class_ref, "setReady", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReady_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReady", "(Z)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setSecure_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='setSecure' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSecure", "(Z)V", "")]
		public static unsafe void SetSecure (bool p0)
		{
			if (id_setSecure_Z == IntPtr.Zero)
				id_setSecure_Z = JNIEnv.GetStaticMethodID (class_ref, "setSecure", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSecure_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setUserInteraction_Z;
#pragma warning disable 0169
		static Delegate GetSetUserInteraction_ZHandler ()
		{
			if (cb_setUserInteraction_Z == null)
				cb_setUserInteraction_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUserInteraction_Z);
			return cb_setUserInteraction_Z;
		}

		static void n_SetUserInteraction_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUserInteraction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserInteraction_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='setUserInteraction' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUserInteraction", "(Z)V", "GetSetUserInteraction_ZHandler")]
		public virtual unsafe void SetUserInteraction (bool p0)
		{
			if (id_setUserInteraction_Z == IntPtr.Zero)
				id_setUserInteraction_Z = JNIEnv.GetMethodID (class_ref, "setUserInteraction", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserInteraction_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserInteraction", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setWaterfalls_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWaterfalls_Ljava_lang_String_Handler ()
		{
			if (cb_setWaterfalls_Ljava_lang_String_ == null)
				cb_setWaterfalls_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWaterfalls_Ljava_lang_String_);
			return cb_setWaterfalls_Ljava_lang_String_;
		}

		static void n_SetWaterfalls_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWaterfalls (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWaterfalls_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/class[@name='MobFoxWebView']/method[@name='setWaterfalls' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setWaterfalls", "(Ljava/lang/String;)V", "GetSetWaterfalls_Ljava_lang_String_Handler")]
		public virtual unsafe void SetWaterfalls (string p0)
		{
			if (id_setWaterfalls_Ljava_lang_String_ == IntPtr.Zero)
				id_setWaterfalls_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWaterfalls", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWaterfalls_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWaterfalls", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

#region "Event implementation for Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener"
		public event EventHandler<global::Com.Mobfox.Sdk.Webview.AdResponseEventArgs> AdResponse {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor_SetLoadAdListener,
						__CreateIMobFoxWebViewLoadAdListenerImplementor,
						SetLoadAdListener,
						__h => __h.OnAdResponseHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor_SetLoadAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor.__IsEmpty,
						__v => SetLoadAdListener (null),
						__h => __h.OnAdResponseHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.LoadAdEventArgs> onLoadAdError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor_SetLoadAdListener,
						__CreateIMobFoxWebViewLoadAdListenerImplementor,
						SetLoadAdListener,
						__h => __h.onLoadAdErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor_SetLoadAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor.__IsEmpty,
						__v => SetLoadAdListener (null),
						__h => __h.onLoadAdErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.NoAdEventArgs> NoAd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor_SetLoadAdListener,
						__CreateIMobFoxWebViewLoadAdListenerImplementor,
						SetLoadAdListener,
						__h => __h.OnNoAdHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor_SetLoadAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor.__IsEmpty,
						__v => SetLoadAdListener (null),
						__h => __h.OnNoAdHandler -= value);
			}
		}

		WeakReference weak_implementor_SetLoadAdListener;

		global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor __CreateIMobFoxWebViewLoadAdListenerImplementor ()
		{
			return new global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener"
		public event EventHandler<global::Com.Mobfox.Sdk.Webview.AdClickEventArgs> AdClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						__CreateIMobFoxWebViewRenderAdListenerImplementor,
						__v => RenderAdListener = __v,
						__h => __h.OnAdClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor.__IsEmpty,
						__v => RenderAdListener = null,
						__h => __h.OnAdClickHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.AdClosedEventArgs> AdClosed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						__CreateIMobFoxWebViewRenderAdListenerImplementor,
						__v => RenderAdListener = __v,
						__h => __h.OnAdClosedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor.__IsEmpty,
						__v => RenderAdListener = null,
						__h => __h.OnAdClosedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.AutoRedirectEventArgs> AutoRedirect {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						__CreateIMobFoxWebViewRenderAdListenerImplementor,
						__v => RenderAdListener = __v,
						__h => __h.OnAutoRedirectHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor.__IsEmpty,
						__v => RenderAdListener = null,
						__h => __h.OnAutoRedirectHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.RenderAdEventArgs> onRenderAdError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						__CreateIMobFoxWebViewRenderAdListenerImplementor,
						__v => RenderAdListener = __v,
						__h => __h.onRenderAdErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor.__IsEmpty,
						__v => RenderAdListener = null,
						__h => __h.onRenderAdErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.RenderedEventArgs> Rendered {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						__CreateIMobFoxWebViewRenderAdListenerImplementor,
						__v => RenderAdListener = __v,
						__h => __h.OnRenderedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor.__IsEmpty,
						__v => RenderAdListener = null,
						__h => __h.OnRenderedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.VideoAdFinishedEventArgs> VideoAdFinished {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						__CreateIMobFoxWebViewRenderAdListenerImplementor,
						__v => RenderAdListener = __v,
						__h => __h.OnVideoAdFinishedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor>(
						ref weak_implementor___SetRenderAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor.__IsEmpty,
						__v => RenderAdListener = null,
						__h => __h.OnVideoAdFinishedHandler -= value);
			}
		}

		WeakReference weak_implementor___SetRenderAdListener;

		global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor __CreateIMobFoxWebViewRenderAdListenerImplementor ()
		{
			return new global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerImplementor (this);
		}
#endregion
	}
}
