using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Customevents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventNative']"
	[Register ("com/mobfox/sdk/customevents/CustomEventNative", "", "Com.Mobfox.Sdk.Customevents.ICustomEventNativeInvoker")]
	public partial interface ICustomEventNative : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventNative']/method[@name='load' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.customevents.CustomEventNativeListener'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;com.mobfox.sdk.nativeads.Tracker&gt;'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("load", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventNativeListener;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V", "GetLoad_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventNativeInvoker, JarBinding")]
		void Load (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener p1, string p2, global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Nativeads.Tracker> p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventNative']/method[@name='registerViewForInteraction' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("registerViewForInteraction", "(Landroid/view/View;)V", "GetRegisterViewForInteraction_Landroid_view_View_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventNativeInvoker, JarBinding")]
		void RegisterViewForInteraction (global::Android.Views.View p0);

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/customevents/CustomEventNative", DoNotGenerateAcw=true)]
	internal class ICustomEventNativeInvoker : global::Java.Lang.Object, ICustomEventNative {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/customevents/CustomEventNative");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICustomEventNativeInvoker); }
		}

		IntPtr class_ref;

		public static ICustomEventNative GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICustomEventNative> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.customevents.CustomEventNative"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICustomEventNativeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoad_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_Handler ()
		{
			if (cb_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ == null)
				cb_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_);
			return cb_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_;
		}

		static void n_Load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNative __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener p1 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_;
		public unsafe void Load (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener p1, string p2, global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Nativeads.Tracker> p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p4)
		{
			if (id_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ == IntPtr.Zero)
				id_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "load", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventNativeListener;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_registerViewForInteraction_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRegisterViewForInteraction_Landroid_view_View_Handler ()
		{
			if (cb_registerViewForInteraction_Landroid_view_View_ == null)
				cb_registerViewForInteraction_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterViewForInteraction_Landroid_view_View_);
			return cb_registerViewForInteraction_Landroid_view_View_;
		}

		static void n_RegisterViewForInteraction_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNative __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterViewForInteraction (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerViewForInteraction_Landroid_view_View_;
		public unsafe void RegisterViewForInteraction (global::Android.Views.View p0)
		{
			if (id_registerViewForInteraction_Landroid_view_View_ == IntPtr.Zero)
				id_registerViewForInteraction_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "registerViewForInteraction", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerViewForInteraction_Landroid_view_View_, __args);
		}

	}

}
