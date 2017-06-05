using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Customevents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitial']"
	[Register ("com/mobfox/sdk/customevents/CustomEventInterstitial", "", "Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialInvoker")]
	public partial interface ICustomEventInterstitial : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitial']/method[@name='loadInterstitial' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.customevents.CustomEventInterstitialListener'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("loadInterstitial", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;Ljava/lang/String;Ljava/util/Map;)V", "GetLoadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialInvoker, JarBinding")]
		void LoadInterstitial (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitial']/method[@name='showInterstitial' and count(parameter)=0]"
		[Register ("showInterstitial", "()V", "GetShowInterstitialHandler:Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialInvoker, JarBinding")]
		void ShowInterstitial ();

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/customevents/CustomEventInterstitial", DoNotGenerateAcw=true)]
	internal class ICustomEventInterstitialInvoker : global::Java.Lang.Object, ICustomEventInterstitial {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/customevents/CustomEventInterstitial");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICustomEventInterstitialInvoker); }
		}

		IntPtr class_ref;

		public static ICustomEventInterstitial GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICustomEventInterstitial> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.customevents.CustomEventInterstitial"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICustomEventInterstitialInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_);
			return cb_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_LoadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener p1 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadInterstitial (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void LoadInterstitial (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
		{
			if (id_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadInterstitial", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_showInterstitial;
#pragma warning disable 0169
		static Delegate GetShowInterstitialHandler ()
		{
			if (cb_showInterstitial == null)
				cb_showInterstitial = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowInterstitial);
			return cb_showInterstitial;
		}

		static void n_ShowInterstitial (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitial ();
		}
#pragma warning restore 0169

		IntPtr id_showInterstitial;
		public unsafe void ShowInterstitial ()
		{
			if (id_showInterstitial == IntPtr.Zero)
				id_showInterstitial = JNIEnv.GetMethodID (class_ref, "showInterstitial", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showInterstitial);
		}

	}

}
