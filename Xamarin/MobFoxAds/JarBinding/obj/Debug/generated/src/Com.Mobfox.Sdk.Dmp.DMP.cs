using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Dmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/dmp/DMP", DoNotGenerateAcw=true)]
	public partial class DMP : global::Java.Lang.Object {


		static IntPtr BUNDLE_FILE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/field[@name='BUNDLE_FILE']"
		[Register ("BUNDLE_FILE")]
		public static string BundleFile {
			get {
				if (BUNDLE_FILE_jfieldId == IntPtr.Zero)
					BUNDLE_FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUNDLE_FILE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUNDLE_FILE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BUNDLE_FILE_jfieldId == IntPtr.Zero)
					BUNDLE_FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUNDLE_FILE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, BUNDLE_FILE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/field[@name='DAY']"
		[Register ("DAY")]
		protected static long Day {
			get {
				if (DAY_jfieldId == IntPtr.Zero)
					DAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DAY", "J");
				return JNIEnv.GetStaticLongField (class_ref, DAY_jfieldId);
			}
			set {
				if (DAY_jfieldId == IntPtr.Zero)
					DAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DAY", "J");
				try {
					JNIEnv.SetStaticField (class_ref, DAY_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr NEXT_BUNDLE_FILE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/field[@name='NEXT_BUNDLE_FILE']"
		[Register ("NEXT_BUNDLE_FILE")]
		public static string NextBundleFile {
			get {
				if (NEXT_BUNDLE_FILE_jfieldId == IntPtr.Zero)
					NEXT_BUNDLE_FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEXT_BUNDLE_FILE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEXT_BUNDLE_FILE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NEXT_BUNDLE_FILE_jfieldId == IntPtr.Zero)
					NEXT_BUNDLE_FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEXT_BUNDLE_FILE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, NEXT_BUNDLE_FILE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr UPDATE_FILE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/field[@name='UPDATE_FILE']"
		[Register ("UPDATE_FILE")]
		public static string UpdateFile {
			get {
				if (UPDATE_FILE_jfieldId == IntPtr.Zero)
					UPDATE_FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE_FILE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_FILE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UPDATE_FILE_jfieldId == IntPtr.Zero)
					UPDATE_FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE_FILE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, UPDATE_FILE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/dmp/DMP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DMP); }
		}

		protected DMP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/constructor[@name='DMP' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe DMP ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DMP)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Mobfox.Sdk.Dmp.DMP Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/mobfox/sdk/dmp/DMP;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/mobfox/sdk/dmp/DMP;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.DMP> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deferUpdate_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDeferUpdate_Landroid_content_Context_Handler ()
		{
			if (cb_deferUpdate_Landroid_content_Context_ == null)
				cb_deferUpdate_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeferUpdate_Landroid_content_Context_);
			return cb_deferUpdate_Landroid_content_Context_;
		}

		static bool n_DeferUpdate_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Dmp.DMP __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.DMP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeferUpdate (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deferUpdate_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/method[@name='deferUpdate' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("deferUpdate", "(Landroid/content/Context;)Z", "GetDeferUpdate_Landroid_content_Context_Handler")]
		public virtual unsafe bool DeferUpdate (global::Android.Content.Context p0)
		{
			if (id_deferUpdate_Landroid_content_Context_ == IntPtr.Zero)
				id_deferUpdate_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "deferUpdate", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deferUpdate_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deferUpdate", "(Landroid/content/Context;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPost_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetPost_Landroid_content_Context_Handler ()
		{
			if (cb_getPost_Landroid_content_Context_ == null)
				cb_getPost_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPost_Landroid_content_Context_);
			return cb_getPost_Landroid_content_Context_;
		}

		static IntPtr n_GetPost_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Dmp.DMP __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.DMP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPost (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPost_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/method[@name='getPost' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPost", "(Landroid/content/Context;)Lorg/json/JSONObject;", "GetGetPost_Landroid_content_Context_Handler")]
		public virtual unsafe global::Org.Json.JSONObject GetPost (global::Android.Content.Context p0)
		{
			if (id_getPost_Landroid_content_Context_ == IntPtr.Zero)
				id_getPost_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getPost", "(Landroid/content/Context;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Json.JSONObject __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPost_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPost", "(Landroid/content/Context;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isRipe_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetIsRipe_Ljava_util_Calendar_Handler ()
		{
			if (cb_isRipe_Ljava_util_Calendar_ == null)
				cb_isRipe_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsRipe_Ljava_util_Calendar_);
			return cb_isRipe_Ljava_util_Calendar_;
		}

		static bool n_IsRipe_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Dmp.DMP __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.DMP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRipe (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isRipe_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/method[@name='isRipe' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("isRipe", "(Ljava/util/Calendar;)Z", "GetIsRipe_Ljava_util_Calendar_Handler")]
		public virtual unsafe bool IsRipe (global::Java.Util.Calendar p0)
		{
			if (id_isRipe_Ljava_util_Calendar_ == IntPtr.Zero)
				id_isRipe_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "isRipe", "(Ljava/util/Calendar;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRipe_Ljava_util_Calendar_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRipe", "(Ljava/util/Calendar;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mobfox.Sdk.Dmp.DMP __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.DMP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMP']/method[@name='update' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("update", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Update (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "update", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
