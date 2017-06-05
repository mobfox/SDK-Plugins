using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Lzyzsd.Jsbridge {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='DefaultHandler']"
	[global::Android.Runtime.Register ("com/github/lzyzsd/jsbridge/DefaultHandler", DoNotGenerateAcw=true)]
	public partial class DefaultHandler : global::Java.Lang.Object, global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/lzyzsd/jsbridge/DefaultHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultHandler); }
		}

		protected DefaultHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='DefaultHandler']/constructor[@name='DefaultHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DefaultHandler)) {
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

		static Delegate cb_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
#pragma warning disable 0169
		static Delegate GetHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler ()
		{
			if (cb_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == null)
				cb_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_);
			return cb_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		}

		static void n_Handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Github.Lzyzsd.Jsbridge.DefaultHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.DefaultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1 = (global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction)global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Handler (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='DefaultHandler']/method[@name='handler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.github.lzyzsd.jsbridge.CallBackFunction']]"
		[Register ("handler", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V", "GetHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler")]
		public virtual unsafe void Handler (string p0, global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1)
		{
			if (id_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == IntPtr.Zero)
				id_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNIEnv.GetMethodID (class_ref, "handler", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handler", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
