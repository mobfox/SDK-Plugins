using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Lzyzsd.Jsbridge {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebViewClient']"
	[global::Android.Runtime.Register ("com/github/lzyzsd/jsbridge/BridgeWebViewClient", DoNotGenerateAcw=true)]
	public partial class BridgeWebViewClient : global::Android.Webkit.WebViewClient {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/lzyzsd/jsbridge/BridgeWebViewClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BridgeWebViewClient); }
		}

		protected BridgeWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_github_lzyzsd_jsbridge_BridgeWebView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebViewClient']/constructor[@name='BridgeWebViewClient' and count(parameter)=1 and parameter[1][@type='com.github.lzyzsd.jsbridge.BridgeWebView']]"
		[Register (".ctor", "(Lcom/github/lzyzsd/jsbridge/BridgeWebView;)V", "")]
		public unsafe BridgeWebViewClient (global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BridgeWebViewClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/github/lzyzsd/jsbridge/BridgeWebView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/github/lzyzsd/jsbridge/BridgeWebView;)V", __args);
					return;
				}

				if (id_ctor_Lcom_github_lzyzsd_jsbridge_BridgeWebView_ == IntPtr.Zero)
					id_ctor_Lcom_github_lzyzsd_jsbridge_BridgeWebView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/github/lzyzsd/jsbridge/BridgeWebView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_github_lzyzsd_jsbridge_BridgeWebView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_github_lzyzsd_jsbridge_BridgeWebView_, __args);
			} finally {
			}
		}

	}
}
