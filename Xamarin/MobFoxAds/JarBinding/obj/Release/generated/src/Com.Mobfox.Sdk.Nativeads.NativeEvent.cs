using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeEvent']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/NativeEvent", DoNotGenerateAcw=true)]
	public partial class NativeEvent : global::Java.Lang.Object, global::Com.Mobfox.Sdk.Customevents.ICustomEventNative {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/nativeads/NativeEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeEvent); }
		}

		protected NativeEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mobfox_sdk_nativeads_NativeAd_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeEvent']/constructor[@name='NativeEvent' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.nativeads.NativeAd']]"
		[Register (".ctor", "(Lcom/mobfox/sdk/nativeads/NativeAd;)V", "")]
		public unsafe NativeEvent (global::Com.Mobfox.Sdk.Nativeads.NativeAd p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (NativeEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mobfox/sdk/nativeads/NativeAd;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mobfox/sdk/nativeads/NativeAd;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mobfox_sdk_nativeads_NativeAd_ == IntPtr.Zero)
					id_ctor_Lcom_mobfox_sdk_nativeads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mobfox/sdk/nativeads/NativeAd;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mobfox_sdk_nativeads_NativeAd_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mobfox_sdk_nativeads_NativeAd_, __args);
			} finally {
			}
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
			global::Com.Mobfox.Sdk.Nativeads.NativeEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener p1 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeEvent']/method[@name='load' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.customevents.CustomEventNativeListener'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;com.mobfox.sdk.nativeads.Tracker&gt;'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("load", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventNativeListener;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V", "GetLoad_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_Handler")]
		public virtual unsafe void Load (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener p1, string p2, global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Nativeads.Tracker> p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p4)
		{
			if (id_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ == IntPtr.Zero)
				id_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "load", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventNativeListener;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventNativeListener;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
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
			global::Com.Mobfox.Sdk.Nativeads.NativeEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterViewForInteraction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerViewForInteraction_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeEvent']/method[@name='registerViewForInteraction' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("registerViewForInteraction", "(Landroid/view/View;)V", "GetRegisterViewForInteraction_Landroid_view_View_Handler")]
		public virtual unsafe void RegisterViewForInteraction (global::Android.Views.View p0)
		{
			if (id_registerViewForInteraction_Landroid_view_View_ == IntPtr.Zero)
				id_registerViewForInteraction_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "registerViewForInteraction", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerViewForInteraction_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerViewForInteraction", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

	}
}
