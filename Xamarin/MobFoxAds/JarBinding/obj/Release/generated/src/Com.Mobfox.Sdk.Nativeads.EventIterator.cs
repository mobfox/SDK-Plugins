using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='EventIterator']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/EventIterator", DoNotGenerateAcw=true)]
	public partial class EventIterator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/nativeads/EventIterator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventIterator); }
		}

		protected EventIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_mobfox_sdk_nativeads_NativeAd_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='EventIterator']/constructor[@name='EventIterator' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.mobfox.sdk.customevents.CustomEventData&gt;'] and parameter[3][@type='com.mobfox.sdk.nativeads.NativeAd'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lcom/mobfox/sdk/nativeads/NativeAd;Ljava/util/Map;)V", "")]
		public unsafe EventIterator (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Customevents.CustomEventData> p1, global::Com.Mobfox.Sdk.Nativeads.NativeAd p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Customevents.CustomEventData>.ToLocalJniHandle (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (EventIterator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/util/List;Lcom/mobfox/sdk/nativeads/NativeAd;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/List;Lcom/mobfox/sdk/nativeads/NativeAd;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_mobfox_sdk_nativeads_NativeAd_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_mobfox_sdk_nativeads_NativeAd_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;Lcom/mobfox/sdk/nativeads/NativeAd;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_mobfox_sdk_nativeads_NativeAd_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_mobfox_sdk_nativeads_NativeAd_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.EventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.EventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		static IntPtr id_hasNext;
		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='EventIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasNext", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_;
#pragma warning disable 0169
		static Delegate GetCallNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Handler ()
		{
			if (cb_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_ == null)
				cb_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CallNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_);
			return cb_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_;
		}

		static void n_CallNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.EventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.EventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallNextEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='EventIterator']/method[@name='callNextEvent' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventNativeListener']]"
		[Register ("callNextEvent", "(Lcom/mobfox/sdk/customevents/CustomEventNativeListener;)V", "GetCallNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_Handler")]
		public virtual unsafe void CallNextEvent (global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener p0)
		{
			if (id_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_ == IntPtr.Zero)
				id_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_ = JNIEnv.GetMethodID (class_ref, "callNextEvent", "(Lcom/mobfox/sdk/customevents/CustomEventNativeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventNativeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "callNextEvent", "(Lcom/mobfox/sdk/customevents/CustomEventNativeListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_parse_Landroid_content_Context_Lorg_json_JSONObject_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='EventIterator']/method[@name='parse' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("parse", "(Landroid/content/Context;Lorg/json/JSONObject;Ljava/util/Map;Ljava/util/Map;)Lcom/mobfox/sdk/nativeads/EventIterator;", "")]
		public static unsafe global::Com.Mobfox.Sdk.Nativeads.EventIterator Parse (global::Android.Content.Context p0, global::Org.Json.JSONObject p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
		{
			if (id_parse_Landroid_content_Context_Lorg_json_JSONObject_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_parse_Landroid_content_Context_Lorg_json_JSONObject_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Landroid/content/Context;Lorg/json/JSONObject;Ljava/util/Map;Ljava/util/Map;)Lcom/mobfox/sdk/nativeads/EventIterator;");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				global::Com.Mobfox.Sdk.Nativeads.EventIterator __ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.EventIterator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Landroid_content_Context_Lorg_json_JSONObject_Ljava_util_Map_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
