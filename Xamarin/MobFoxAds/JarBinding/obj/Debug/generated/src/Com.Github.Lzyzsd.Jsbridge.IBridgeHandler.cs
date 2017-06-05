using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Lzyzsd.Jsbridge {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/interface[@name='BridgeHandler']"
	[Register ("com/github/lzyzsd/jsbridge/BridgeHandler", "", "Com.Github.Lzyzsd.Jsbridge.IBridgeHandlerInvoker")]
	public partial interface IBridgeHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/interface[@name='BridgeHandler']/method[@name='handler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.github.lzyzsd.jsbridge.CallBackFunction']]"
		[Register ("handler", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V", "GetHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler:Com.Github.Lzyzsd.Jsbridge.IBridgeHandlerInvoker, JarBinding")]
		void Handler (string p0, global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1);

	}

	[global::Android.Runtime.Register ("com/github/lzyzsd/jsbridge/BridgeHandler", DoNotGenerateAcw=true)]
	internal class IBridgeHandlerInvoker : global::Java.Lang.Object, IBridgeHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/github/lzyzsd/jsbridge/BridgeHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBridgeHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IBridgeHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBridgeHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.lzyzsd.jsbridge.BridgeHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBridgeHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1 = (global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction)global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Handler (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		public unsafe void Handler (string p0, global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1)
		{
			if (id_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == IntPtr.Zero)
				id_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNIEnv.GetMethodID (class_ref, "handler", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
