using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Runnables {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='WebViewRunnable']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/runnables/WebViewRunnable", DoNotGenerateAcw=true)]
	public abstract partial class WebViewRunnable : global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable {


		static IntPtr CONNECTION_EXCEPTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='WebViewRunnable']/field[@name='CONNECTION_EXCEPTION']"
		[Register ("CONNECTION_EXCEPTION")]
		public static string ConnectionException {
			get {
				if (CONNECTION_EXCEPTION_jfieldId == IntPtr.Zero)
					CONNECTION_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_EXCEPTION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_EXCEPTION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONNECTION_EXCEPTION_jfieldId == IntPtr.Zero)
					CONNECTION_EXCEPTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_EXCEPTION", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CONNECTION_EXCEPTION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/runnables/WebViewRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebViewRunnable); }
		}

		protected WebViewRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='WebViewRunnable']/constructor[@name='WebViewRunnable' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V", "")]
		public unsafe WebViewRunnable (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Webview.MobFoxWebView p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (WebViewRunnable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebView;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/runnables/WebViewRunnable", DoNotGenerateAcw=true)]
	internal partial class WebViewRunnableInvoker : WebViewRunnable {

		public WebViewRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebViewRunnableInvoker); }
		}

		static IntPtr id_mobFoxRun;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='MobFoxRunnable']/method[@name='mobFoxRun' and count(parameter)=0]"
		[Register ("mobFoxRun", "()V", "GetMobFoxRunHandler")]
		public override unsafe void MobFoxRun ()
		{
			if (id_mobFoxRun == IntPtr.Zero)
				id_mobFoxRun = JNIEnv.GetMethodID (class_ref, "mobFoxRun", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mobFoxRun);
			} finally {
			}
		}

	}

}
