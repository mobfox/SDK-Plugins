using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Webview {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewLoadAdListener']"
	[Register ("com/mobfox/sdk/webview/MobFoxWebViewLoadAdListener", "", "Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerInvoker")]
	public partial interface IMobFoxWebViewLoadAdListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewLoadAdListener']/method[@name='onAdResponse' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("onAdResponse", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;)V", "GetOnAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerInvoker, JarBinding")]
		void OnAdResponse (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Org.Json.JSONObject p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewLoadAdListener']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onError", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/Exception;)V", "GetonLoadAdError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerInvoker, JarBinding")]
		void onLoadAdError (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewLoadAdListener']/method[@name='onNoAd' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView']]"
		[Register ("onNoAd", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V", "GetOnNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerInvoker, JarBinding")]
		void OnNoAd (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0);

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/webview/MobFoxWebViewLoadAdListener", DoNotGenerateAcw=true)]
	internal class IMobFoxWebViewLoadAdListenerInvoker : global::Java.Lang.Object, IMobFoxWebViewLoadAdListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/webview/MobFoxWebViewLoadAdListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMobFoxWebViewLoadAdListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMobFoxWebViewLoadAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMobFoxWebViewLoadAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.webview.MobFoxWebViewLoadAdListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMobFoxWebViewLoadAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetOnAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_Handler ()
		{
			if (cb_onAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_ == null)
				cb_onAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_);
			return cb_onAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_;
		}

		static void n_OnAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_;
		public unsafe void OnAdResponse (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Org.Json.JSONObject p1)
		{
			if (id_onAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_onAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onAdResponse", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdResponse_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_, __args);
		}

		static Delegate cb_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetonLoadAdError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ == null)
				cb_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_onLoadAdError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_);
			return cb_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_;
		}

		static void n_onLoadAdError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.onLoadAdError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_;
		public unsafe void onLoadAdError (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Java.Lang.Exception p1)
		{
			if (id_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_;
#pragma warning disable 0169
		static Delegate GetOnNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_Handler ()
		{
			if (cb_onNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_ == null)
				cb_onNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_);
			return cb_onNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_;
		}

		static void n_OnNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNoAd (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_;
		public unsafe void OnNoAd (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			if (id_onNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_ == IntPtr.Zero)
				id_onNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_ = JNIEnv.GetMethodID (class_ref, "onNoAd", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNoAd_Lcom_mobfox_sdk_webview_MobFoxWebView_, __args);
		}

	}

	public partial class AdResponseEventArgs : global::System.EventArgs {

		public AdResponseEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Org.Json.JSONObject p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0;
		public global::Com.Mobfox.Sdk.Webview.MobFoxWebView P0 {
			get { return p0; }
		}

		global::Org.Json.JSONObject p1;
		public global::Org.Json.JSONObject P1 {
			get { return p1; }
		}
	}

	public partial class LoadAdEventArgs : global::System.EventArgs {

		public LoadAdEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Java.Lang.Exception p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0;
		public global::Com.Mobfox.Sdk.Webview.MobFoxWebView P0 {
			get { return p0; }
		}

		global::Java.Lang.Exception p1;
		public global::Java.Lang.Exception P1 {
			get { return p1; }
		}
	}

	public partial class NoAdEventArgs : global::System.EventArgs {

		public NoAdEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			this.p0 = p0;
		}

		global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0;
		public global::Com.Mobfox.Sdk.Webview.MobFoxWebView P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mobfox/sdk/webview/MobFoxWebViewLoadAdListenerImplementor")]
	internal sealed partial class IMobFoxWebViewLoadAdListenerImplementor : global::Java.Lang.Object, IMobFoxWebViewLoadAdListener {

		object sender;

		public IMobFoxWebViewLoadAdListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/webview/MobFoxWebViewLoadAdListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdResponseEventArgs> OnAdResponseHandler;
#pragma warning restore 0649

		public void OnAdResponse (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Org.Json.JSONObject p1)
		{
			var __h = OnAdResponseHandler;
			if (__h != null)
				__h (sender, new AdResponseEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<LoadAdEventArgs> onLoadAdErrorHandler;
#pragma warning restore 0649

		public void onLoadAdError (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Java.Lang.Exception p1)
		{
			var __h = onLoadAdErrorHandler;
			if (__h != null)
				__h (sender, new LoadAdEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<NoAdEventArgs> OnNoAdHandler;
#pragma warning restore 0649

		public void OnNoAd (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			var __h = OnNoAdHandler;
			if (__h != null)
				__h (sender, new NoAdEventArgs (p0));
		}

		internal static bool __IsEmpty (IMobFoxWebViewLoadAdListenerImplementor value)
		{
			return value.OnAdResponseHandler == null && value.onLoadAdErrorHandler == null && value.OnNoAdHandler == null;
		}
	}

}
