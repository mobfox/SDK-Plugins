using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Webview {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewRenderAdListener']"
	[Register ("com/mobfox/sdk/webview/MobFoxWebViewRenderAdListener", "", "Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerInvoker")]
	public partial interface IMobFoxWebViewRenderAdListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewRenderAdListener']/method[@name='onAdClick' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAdClick", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V", "GetOnAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerInvoker, JarBinding")]
		void OnAdClick (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewRenderAdListener']/method[@name='onAdClosed' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView']]"
		[Register ("onAdClosed", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V", "GetOnAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerInvoker, JarBinding")]
		void OnAdClosed (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewRenderAdListener']/method[@name='onAutoRedirect' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAutoRedirect", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V", "GetOnAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerInvoker, JarBinding")]
		void OnAutoRedirect (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewRenderAdListener']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onError", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/Exception;)V", "GetonRenderAdError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerInvoker, JarBinding")]
		void onRenderAdError (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewRenderAdListener']/method[@name='onRendered' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRendered", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V", "GetOnRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerInvoker, JarBinding")]
		void OnRendered (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.webview']/interface[@name='MobFoxWebViewRenderAdListener']/method[@name='onVideoAdFinished' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView']]"
		[Register ("onVideoAdFinished", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V", "GetOnVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_Handler:Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListenerInvoker, JarBinding")]
		void OnVideoAdFinished (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0);

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/webview/MobFoxWebViewRenderAdListener", DoNotGenerateAcw=true)]
	internal class IMobFoxWebViewRenderAdListenerInvoker : global::Java.Lang.Object, IMobFoxWebViewRenderAdListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/webview/MobFoxWebViewRenderAdListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMobFoxWebViewRenderAdListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMobFoxWebViewRenderAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMobFoxWebViewRenderAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.webview.MobFoxWebViewRenderAdListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMobFoxWebViewRenderAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_Handler ()
		{
			if (cb_onAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ == null)
				cb_onAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_);
			return cb_onAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
		}

		static void n_OnAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClick (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
		public unsafe void OnAdClick (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			if (id_onAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ == IntPtr.Zero)
				id_onAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdClick", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClick_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_;
#pragma warning disable 0169
		static Delegate GetOnAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_Handler ()
		{
			if (cb_onAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_ == null)
				cb_onAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_);
			return cb_onAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_;
		}

		static void n_OnAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_;
		public unsafe void OnAdClosed (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			if (id_onAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_ == IntPtr.Zero)
				id_onAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_ = JNIEnv.GetMethodID (class_ref, "onAdClosed", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClosed_Lcom_mobfox_sdk_webview_MobFoxWebView_, __args);
		}

		static Delegate cb_onAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_Handler ()
		{
			if (cb_onAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ == null)
				cb_onAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_);
			return cb_onAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
		}

		static void n_OnAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAutoRedirect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
		public unsafe void OnAutoRedirect (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			if (id_onAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ == IntPtr.Zero)
				id_onAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAutoRedirect", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAutoRedirect_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetonRenderAdError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ == null)
				cb_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_onRenderAdError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_);
			return cb_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_;
		}

		static void n_onRenderAdError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.onRenderAdError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_;
		public unsafe void onRenderAdError (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Java.Lang.Exception p1)
		{
			if (id_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_Handler ()
		{
			if (cb_onRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ == null)
				cb_onRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_);
			return cb_onRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
		}

		static void n_OnRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRendered (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
		public unsafe void OnRendered (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			if (id_onRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ == IntPtr.Zero)
				id_onRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRendered", "(Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRendered_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_;
#pragma warning disable 0169
		static Delegate GetOnVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_Handler ()
		{
			if (cb_onVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_ == null)
				cb_onVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_);
			return cb_onVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_;
		}

		static void n_OnVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewRenderAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoAdFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_;
		public unsafe void OnVideoAdFinished (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			if (id_onVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_ == IntPtr.Zero)
				id_onVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_ = JNIEnv.GetMethodID (class_ref, "onVideoAdFinished", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoAdFinished_Lcom_mobfox_sdk_webview_MobFoxWebView_, __args);
		}

	}

	public partial class AdClickEventArgs : global::System.EventArgs {

		public AdClickEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0;
		public global::Com.Mobfox.Sdk.Webview.MobFoxWebView P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class AdClosedEventArgs : global::System.EventArgs {

		public AdClosedEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			this.p0 = p0;
		}

		global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0;
		public global::Com.Mobfox.Sdk.Webview.MobFoxWebView P0 {
			get { return p0; }
		}
	}

	public partial class AutoRedirectEventArgs : global::System.EventArgs {

		public AutoRedirectEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0;
		public global::Com.Mobfox.Sdk.Webview.MobFoxWebView P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class RenderAdEventArgs : global::System.EventArgs {

		public RenderAdEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Java.Lang.Exception p1)
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

	public partial class RenderedEventArgs : global::System.EventArgs {

		public RenderedEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0;
		public global::Com.Mobfox.Sdk.Webview.MobFoxWebView P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class VideoAdFinishedEventArgs : global::System.EventArgs {

		public VideoAdFinishedEventArgs (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			this.p0 = p0;
		}

		global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0;
		public global::Com.Mobfox.Sdk.Webview.MobFoxWebView P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mobfox/sdk/webview/MobFoxWebViewRenderAdListenerImplementor")]
	internal sealed partial class IMobFoxWebViewRenderAdListenerImplementor : global::Java.Lang.Object, IMobFoxWebViewRenderAdListener {

		object sender;

		public IMobFoxWebViewRenderAdListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/webview/MobFoxWebViewRenderAdListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdClickEventArgs> OnAdClickHandler;
#pragma warning restore 0649

		public void OnAdClick (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			var __h = OnAdClickHandler;
			if (__h != null)
				__h (sender, new AdClickEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<AdClosedEventArgs> OnAdClosedHandler;
#pragma warning restore 0649

		public void OnAdClosed (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			var __h = OnAdClosedHandler;
			if (__h != null)
				__h (sender, new AdClosedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AutoRedirectEventArgs> OnAutoRedirectHandler;
#pragma warning restore 0649

		public void OnAutoRedirect (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			var __h = OnAutoRedirectHandler;
			if (__h != null)
				__h (sender, new AutoRedirectEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RenderAdEventArgs> onRenderAdErrorHandler;
#pragma warning restore 0649

		public void onRenderAdError (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, global::Java.Lang.Exception p1)
		{
			var __h = onRenderAdErrorHandler;
			if (__h != null)
				__h (sender, new RenderAdEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RenderedEventArgs> OnRenderedHandler;
#pragma warning restore 0649

		public void OnRendered (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0, string p1)
		{
			var __h = OnRenderedHandler;
			if (__h != null)
				__h (sender, new RenderedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<VideoAdFinishedEventArgs> OnVideoAdFinishedHandler;
#pragma warning restore 0649

		public void OnVideoAdFinished (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			var __h = OnVideoAdFinishedHandler;
			if (__h != null)
				__h (sender, new VideoAdFinishedEventArgs (p0));
		}

		internal static bool __IsEmpty (IMobFoxWebViewRenderAdListenerImplementor value)
		{
			return value.OnAdClickHandler == null && value.OnAdClosedHandler == null && value.OnAutoRedirectHandler == null && value.onRenderAdErrorHandler == null && value.OnRenderedHandler == null && value.OnVideoAdFinishedHandler == null;
		}
	}

}
