using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Networking {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.networking']/interface[@name='AsyncCallbackJSON']"
	[Register ("com/mobfox/sdk/networking/AsyncCallbackJSON", "", "Com.Mobfox.Sdk.Networking.IAsyncCallbackJSONInvoker")]
	public partial interface IAsyncCallbackJSON : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/interface[@name='AsyncCallbackJSON']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register ("onComplete", "(ILorg/json/JSONObject;Ljava/util/Map;)V", "GetOnComplete_ILorg_json_JSONObject_Ljava_util_Map_Handler:Com.Mobfox.Sdk.Networking.IAsyncCallbackJSONInvoker, JarBinding")]
		void OnComplete (int p0, global::Org.Json.JSONObject p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/interface[@name='AsyncCallbackJSON']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onError", "(Ljava/lang/Exception;)V", "GetOnError_Ljava_lang_Exception_Handler:Com.Mobfox.Sdk.Networking.IAsyncCallbackJSONInvoker, JarBinding")]
		void OnError (global::Java.Lang.Exception p0);

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/networking/AsyncCallbackJSON", DoNotGenerateAcw=true)]
	internal class IAsyncCallbackJSONInvoker : global::Java.Lang.Object, IAsyncCallbackJSON {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/networking/AsyncCallbackJSON");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAsyncCallbackJSONInvoker); }
		}

		IntPtr class_ref;

		public static IAsyncCallbackJSON GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncCallbackJSON> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.networking.AsyncCallbackJSON"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncCallbackJSONInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete_ILorg_json_JSONObject_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnComplete_ILorg_json_JSONObject_Ljava_util_Map_Handler ()
		{
			if (cb_onComplete_ILorg_json_JSONObject_Ljava_util_Map_ == null)
				cb_onComplete_ILorg_json_JSONObject_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnComplete_ILorg_json_JSONObject_Ljava_util_Map_);
			return cb_onComplete_ILorg_json_JSONObject_Ljava_util_Map_;
		}

		static void n_OnComplete_ILorg_json_JSONObject_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_ILorg_json_JSONObject_Ljava_util_Map_;
		public unsafe void OnComplete (int p0, global::Org.Json.JSONObject p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2)
		{
			if (id_onComplete_ILorg_json_JSONObject_Ljava_util_Map_ == IntPtr.Zero)
				id_onComplete_ILorg_json_JSONObject_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(ILorg/json/JSONObject;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_ILorg_json_JSONObject_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Ljava_lang_Exception_ == null)
				cb_onError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Exception_);
			return cb_onError_Ljava_lang_Exception_;
		}

		static void n_OnError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Exception_;
		public unsafe void OnError (global::Java.Lang.Exception p0)
		{
			if (id_onError_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Exception_, __args);
		}

	}

}
