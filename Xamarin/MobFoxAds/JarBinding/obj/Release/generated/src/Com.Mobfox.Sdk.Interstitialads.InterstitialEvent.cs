using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Interstitialads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialEvent']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/interstitialads/InterstitialEvent", DoNotGenerateAcw=true)]
	public partial class InterstitialEvent : global::Java.Lang.Object, global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialEvent']/field[@name='INTERSTITIAL_ACTIVITY_CLASSNAME']"
		[Register ("INTERSTITIAL_ACTIVITY_CLASSNAME")]
		public const string InterstitialActivityClassname = (string) ".interstitialads.InterstitialActivity";

		static IntPtr mMessageReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialEvent']/field[@name='mMessageReceiver']"
		[Register ("mMessageReceiver")]
		protected global::Android.Content.BroadcastReceiver MMessageReceiver {
			get {
				if (mMessageReceiver_jfieldId == IntPtr.Zero)
					mMessageReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageReceiver", "Landroid/content/BroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessageReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageReceiver_jfieldId == IntPtr.Zero)
					mMessageReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageReceiver", "Landroid/content/BroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/interstitialads/InterstitialEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InterstitialEvent); }
		}

		protected InterstitialEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialEvent']/constructor[@name='InterstitialEvent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/json/JSONObject;)V", "")]
		public unsafe InterstitialEvent (global::Android.Content.Context p0, global::Org.Json.JSONObject p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (InterstitialEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_json_JSONObject_, __args);
			} finally {
			}
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
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener p1 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadInterstitial (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialEvent']/method[@name='loadInterstitial' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.customevents.CustomEventInterstitialListener'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("loadInterstitial", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;Ljava/lang/String;Ljava/util/Map;)V", "GetLoadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void LoadInterstitial (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
		{
			if (id_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadInterstitial", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadInterstitial_Landroid_content_Context_Lcom_mobfox_sdk_customevents_CustomEventInterstitialListener_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadInterstitial", "(Landroid/content/Context;Lcom/mobfox/sdk/customevents/CustomEventInterstitialListener;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDownloaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyDownloaded_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialEvent']/method[@name='notifyDownloaded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setVideoLocalPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVideoLocalPath_Ljava_lang_String_Handler ()
		{
			if (cb_setVideoLocalPath_Ljava_lang_String_ == null)
				cb_setVideoLocalPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoLocalPath_Ljava_lang_String_);
			return cb_setVideoLocalPath_Ljava_lang_String_;
		}

		static void n_SetVideoLocalPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoLocalPath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVideoLocalPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialEvent']/method[@name='setVideoLocalPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVideoLocalPath", "(Ljava/lang/String;)V", "GetSetVideoLocalPath_Ljava_lang_String_Handler")]
		public virtual unsafe void SetVideoLocalPath (string p0)
		{
			if (id_setVideoLocalPath_Ljava_lang_String_ == IntPtr.Zero)
				id_setVideoLocalPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVideoLocalPath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoLocalPath_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoLocalPath", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitial ();
		}
#pragma warning restore 0169

		static IntPtr id_showInterstitial;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialEvent']/method[@name='showInterstitial' and count(parameter)=0]"
		[Register ("showInterstitial", "()V", "GetShowInterstitialHandler")]
		public virtual unsafe void ShowInterstitial ()
		{
			if (id_showInterstitial == IntPtr.Zero)
				id_showInterstitial = JNIEnv.GetMethodID (class_ref, "showInterstitial", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showInterstitial);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showInterstitial", "()V"));
			} finally {
			}
		}

	}
}
