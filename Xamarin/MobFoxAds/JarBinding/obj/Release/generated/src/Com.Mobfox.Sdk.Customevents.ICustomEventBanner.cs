using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Customevents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventBanner']"
	[Register ("com/mobfox/sdk/customevents/CustomEventBanner", "", "Com.Mobfox.Sdk.Customevents.ICustomEventBannerInvoker")]
	public partial interface ICustomEventBanner : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventBanner']/method[@name='loadAd' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.customevents.CustomEventBannerListener'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("loadAd", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventBannerListener;Ljava/lang/String;Ljava/util/Map;)V", "GetLoadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventBannerInvoker, JarBinding")]
		void LoadAd (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3);

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/customevents/CustomEventBanner", DoNotGenerateAcw=true)]
	internal class ICustomEventBannerInvoker : global::Java.Lang.Object, ICustomEventBanner {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/customevents/CustomEventBanner");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICustomEventBannerInvoker); }
		}

		IntPtr class_ref;

		public static ICustomEventBanner GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICustomEventBanner> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.customevents.CustomEventBanner"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICustomEventBannerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_);
			return cb_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_LoadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventBanner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventBanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener p1 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void LoadAd (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
		{
			if (id_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventBannerListener;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventBannerListener_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

}
