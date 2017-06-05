using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Interstitialads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/interstitialads/EventIterator", DoNotGenerateAcw=true)]
	public partial class EventIterator : global::Java.Lang.Object {


		static IntPtr internalListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']/field[@name='internalListener']"
		[Register ("internalListener")]
		protected global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener InternalListener {
			get {
				if (internalListener_jfieldId == IntPtr.Zero)
					internalListener_jfieldId = JNIEnv.GetFieldID (class_ref, "internalListener", "Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, internalListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (internalListener_jfieldId == IntPtr.Zero)
					internalListener_jfieldId = JNIEnv.GetFieldID (class_ref, "internalListener", "Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, internalListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/interstitialads/EventIterator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventIterator); }
		}

		protected EventIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']/constructor[@name='EventIterator' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.webview.MobFoxWebView'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;Ljava/util/Map;)V", "")]
		public unsafe EventIterator (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Webview.MobFoxWebView p1, global::Org.Json.JSONObject p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (EventIterator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mobfox/sdk/webview/MobFoxWebView;Lorg/json/JSONObject;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_webview_MobFoxWebView_Lorg_json_JSONObject_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getAd;
#pragma warning disable 0169
		static Delegate GetGetAdHandler ()
		{
			if (cb_getAd == null)
				cb_getAd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAd);
			return cb_getAd;
		}

		static IntPtr n_GetAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.EventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.EventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ad);
		}
#pragma warning restore 0169

		static IntPtr id_getAd;
		public virtual unsafe global::Org.Json.JSONObject Ad {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']/method[@name='getAd' and count(parameter)=0]"
			[Register ("getAd", "()Lorg/json/JSONObject;", "GetGetAdHandler")]
			get {
				if (id_getAd == IntPtr.Zero)
					id_getAd = JNIEnv.GetMethodID (class_ref, "getAd", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAd), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAd", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomDataList;
#pragma warning disable 0169
		static Delegate GetGetCustomDataListHandler ()
		{
			if (cb_getCustomDataList == null)
				cb_getCustomDataList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomDataList);
			return cb_getCustomDataList;
		}

		static IntPtr n_GetCustomDataList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.EventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.EventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Customevents.CustomEventData>.ToLocalJniHandle (__this.CustomDataList);
		}
#pragma warning restore 0169

		static IntPtr id_getCustomDataList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Customevents.CustomEventData> CustomDataList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']/method[@name='getCustomDataList' and count(parameter)=0]"
			[Register ("getCustomDataList", "()Ljava/util/List;", "GetGetCustomDataListHandler")]
			get {
				if (id_getCustomDataList == IntPtr.Zero)
					id_getCustomDataList = JNIEnv.GetMethodID (class_ref, "getCustomDataList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Customevents.CustomEventData>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomDataList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Customevents.CustomEventData>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomDataList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Mobfox.Sdk.Interstitialads.EventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.EventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		static IntPtr id_hasNext;
		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']/method[@name='hasNext' and count(parameter)=0]"
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

		static Delegate cb_getInterstitialEvent;
#pragma warning disable 0169
		static Delegate GetGetInterstitialEventHandler ()
		{
			if (cb_getInterstitialEvent == null)
				cb_getInterstitialEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterstitialEvent);
			return cb_getInterstitialEvent;
		}

		static IntPtr n_GetInterstitialEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.EventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.EventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InterstitialEvent);
		}
#pragma warning restore 0169

		static IntPtr id_getInterstitialEvent;
		public virtual unsafe global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent InterstitialEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']/method[@name='getInterstitialEvent' and count(parameter)=0]"
			[Register ("getInterstitialEvent", "()Lcom/mobfox/sdk/interstitialads/InterstitialEvent;", "GetGetInterstitialEventHandler")]
			get {
				if (id_getInterstitialEvent == IntPtr.Zero)
					id_getInterstitialEvent = JNIEnv.GetMethodID (class_ref, "getInterstitialEvent", "()Lcom/mobfox/sdk/interstitialads/InterstitialEvent;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInterstitialEvent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterstitialEvent", "()Lcom/mobfox/sdk/interstitialads/InterstitialEvent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_;
#pragma warning disable 0169
		static Delegate GetCallNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Handler ()
		{
			if (cb_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_ == null)
				cb_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CallNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_);
			return cb_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_;
		}

		static void n_CallNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.EventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.EventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallNextEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']/method[@name='callNextEvent' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventInterstitialListener']]"
		[Register ("callNextEvent", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;)V", "GetCallNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Handler")]
		public virtual unsafe void CallNextEvent (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener p0)
		{
			if (id_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_ == IntPtr.Zero)
				id_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_ = JNIEnv.GetMethodID (class_ref, "callNextEvent", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callNextEvent_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "callNextEvent", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyDownloaded_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyDownloaded_Ljava_lang_String_Handler ()
		{
			if (cb_notifyDownloaded_Ljava_lang_String_ == null)
				cb_notifyDownloaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyDownloaded_Ljava_lang_String_);
			return cb_notifyDownloaded_Ljava_lang_String_;
		}

		static void n_NotifyDownloaded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.EventIterator __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.EventIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDownloaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyDownloaded_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='EventIterator']/method[@name='notifyDownloaded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("notifyDownloaded", "(Ljava/lang/String;)V", "GetNotifyDownloaded_Ljava_lang_String_Handler")]
		public virtual unsafe void NotifyDownloaded (string p0)
		{
			if (id_notifyDownloaded_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyDownloaded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyDownloaded", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyDownloaded_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDownloaded", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
