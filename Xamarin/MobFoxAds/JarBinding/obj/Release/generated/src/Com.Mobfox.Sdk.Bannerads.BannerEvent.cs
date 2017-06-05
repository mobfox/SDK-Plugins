using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Bannerads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='BannerEvent']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/bannerads/BannerEvent", DoNotGenerateAcw=true)]
	public partial class BannerEvent : global::Java.Lang.Object, global::Com.Mobfox.Sdk.Customevents.ICustomEventBanner {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/bannerads/BannerEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BannerEvent); }
		}

		protected BannerEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='BannerEvent']/constructor[@name='BannerEvent' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;)V", "")]
		public unsafe BannerEvent (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Org.Json.JSONObject p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BannerEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static Delegate cb_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_);
			return cb_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_LoadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mobfox.Sdk.Bannerads.BannerEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.BannerEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener p1 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='BannerEvent']/method[@name='loadAd' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.customevents.CustomEventBannerListener'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("loadAd", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventBannerListener;Ljava/lang/String;Ljava/util/Map;)V", "GetLoadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void LoadAd (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
		{
			if (id_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventBannerListener;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAd", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventBannerListener;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
