using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Interstitialads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialActivity']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/interstitialads/InterstitialActivity", DoNotGenerateAcw=true)]
	public partial class InterstitialActivity : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/interstitialads/InterstitialActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InterstitialActivity); }
		}

		protected InterstitialActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialActivity']/constructor[@name='InterstitialActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InterstitialActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InterstitialActivity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_sendMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialActivity']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void SendMessage (string p0, string p1)
		{
			if (id_sendMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_;
#pragma warning disable 0169
		static Delegate GetSetWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_Handler ()
		{
			if (cb_setWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_ == null)
				cb_setWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_);
			return cb_setWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_;
		}

		static void n_SetWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWebView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialActivity']/method[@name='setWebView' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebView']]"
		[Register ("setWebView", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V", "GetSetWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_Handler")]
		public virtual unsafe void SetWebView (global::Com.Mobfox.Sdk.Webview.MobFoxWebView p0)
		{
			if (id_setWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_ == IntPtr.Zero)
				id_setWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_ = JNIEnv.GetMethodID (class_ref, "setWebView", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWebView_Lcom_mobfox_sdk_webview_MobFoxWebView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWebView", "(Lcom/mobfox/sdk/webview/MobFoxWebView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_useWebView;
#pragma warning disable 0169
		static Delegate GetUseWebViewHandler ()
		{
			if (cb_useWebView == null)
				cb_useWebView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UseWebView);
			return cb_useWebView;
		}

		static void n_UseWebView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseWebView ();
		}
#pragma warning restore 0169

		static IntPtr id_useWebView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialActivity']/method[@name='useWebView' and count(parameter)=0]"
		[Register ("useWebView", "()V", "GetUseWebViewHandler")]
		protected virtual unsafe void UseWebView ()
		{
			if (id_useWebView == IntPtr.Zero)
				id_useWebView = JNIEnv.GetMethodID (class_ref, "useWebView", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_useWebView);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "useWebView", "()V"));
			} finally {
			}
		}

	}
}
