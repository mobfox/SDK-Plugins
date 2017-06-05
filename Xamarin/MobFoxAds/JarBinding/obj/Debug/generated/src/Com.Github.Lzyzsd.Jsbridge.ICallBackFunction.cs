using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Lzyzsd.Jsbridge {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/interface[@name='CallBackFunction']"
	[Register ("com/github/lzyzsd/jsbridge/CallBackFunction", "", "Com.Github.Lzyzsd.Jsbridge.ICallBackFunctionInvoker")]
	public partial interface ICallBackFunction : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/interface[@name='CallBackFunction']/method[@name='onCallBack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCallBack", "(Ljava/lang/String;)V", "GetOnCallBack_Ljava_lang_String_Handler:Com.Github.Lzyzsd.Jsbridge.ICallBackFunctionInvoker, JarBinding")]
		void OnCallBack (string p0);

	}

	[global::Android.Runtime.Register ("com/github/lzyzsd/jsbridge/CallBackFunction", DoNotGenerateAcw=true)]
	internal class ICallBackFunctionInvoker : global::Java.Lang.Object, ICallBackFunction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/github/lzyzsd/jsbridge/CallBackFunction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICallBackFunctionInvoker); }
		}

		IntPtr class_ref;

		public static ICallBackFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallBackFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.lzyzsd.jsbridge.CallBackFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallBackFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCallBack_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCallBack_Ljava_lang_String_Handler ()
		{
			if (cb_onCallBack_Ljava_lang_String_ == null)
				cb_onCallBack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCallBack_Ljava_lang_String_);
			return cb_onCallBack_Ljava_lang_String_;
		}

		static void n_OnCallBack_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCallBack (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCallBack_Ljava_lang_String_;
		public unsafe void OnCallBack (string p0)
		{
			if (id_onCallBack_Ljava_lang_String_ == IntPtr.Zero)
				id_onCallBack_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCallBack", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCallBack_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
