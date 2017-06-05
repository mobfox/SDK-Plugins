using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/logging/MobFoxReport", DoNotGenerateAcw=true)]
	public partial class MobFoxReport : global::Java.Lang.Object, global::Java.Lang.Thread.IUncaughtExceptionHandler {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/field[@name='DOMAIN']"
		[Register ("DOMAIN")]
		public const string Domain = (string) "http://sdk-logs.matomy.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/field[@name='PATHNAME']"
		[Register ("PATHNAME")]
		public const string Pathname = (string) "gelf";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/field[@name='PORT']"
		[Register ("PORT")]
		public const int Port = (int) 12201;

		static IntPtr isRegistered_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/field[@name='isRegistered']"
		[Register ("isRegistered")]
		protected static bool IsRegistered {
			get {
				if (isRegistered_jfieldId == IntPtr.Zero)
					isRegistered_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isRegistered", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isRegistered_jfieldId);
			}
			set {
				if (isRegistered_jfieldId == IntPtr.Zero)
					isRegistered_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isRegistered", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isRegistered_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport.SHORT_MESSAGE']"
		[global::Android.Runtime.Register ("com/mobfox/sdk/logging/MobFoxReport$SHORT_MESSAGE", DoNotGenerateAcw=true)]
		public sealed partial class SHORT_MESSAGE : global::Java.Lang.Enum {


			static IntPtr ANDROID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport.SHORT_MESSAGE']/field[@name='ANDROID']"
			[Register ("ANDROID")]
			public static global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE Android {
				get {
					if (ANDROID_jfieldId == IntPtr.Zero)
						ANDROID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANDROID", "Lcom/mobfox/sdk/logging/MobFoxReport$SHORT_MESSAGE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANDROID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CRASH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport.SHORT_MESSAGE']/field[@name='CRASH']"
			[Register ("CRASH")]
			public static global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE Crash {
				get {
					if (CRASH_jfieldId == IntPtr.Zero)
						CRASH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRASH", "Lcom/mobfox/sdk/logging/MobFoxReport$SHORT_MESSAGE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRASH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mobfox/sdk/logging/MobFoxReport$SHORT_MESSAGE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SHORT_MESSAGE); }
			}

			internal SHORT_MESSAGE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport.SHORT_MESSAGE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mobfox/sdk/logging/MobFoxReport$SHORT_MESSAGE;", "")]
			public static unsafe global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mobfox/sdk/logging/MobFoxReport$SHORT_MESSAGE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE __ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport.SHORT_MESSAGE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mobfox/sdk/logging/MobFoxReport$SHORT_MESSAGE;", "")]
			public static unsafe global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mobfox/sdk/logging/MobFoxReport$SHORT_MESSAGE;");
				try {
					return (global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mobfox.Sdk.Logging.MobFoxReport.SHORT_MESSAGE));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/logging/MobFoxReport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxReport); }
		}

		protected MobFoxReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/constructor[@name='MobFoxReport' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe MobFoxReport (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MobFoxReport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getCurrentThreadName;
		public static unsafe string CurrentThreadName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='getCurrentThreadName' and count(parameter)=0]"
			[Register ("getCurrentThreadName", "()Ljava/lang/String;", "GetGetCurrentThreadNameHandler")]
			get {
				if (id_getCurrentThreadName == IntPtr.Zero)
					id_getCurrentThreadName = JNIEnv.GetStaticMethodID (class_ref, "getCurrentThreadName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentThreadName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCause_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='getCause' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("getCause", "(Ljava/lang/Exception;)Ljava/lang/String;", "")]
		public static unsafe string GetCause (global::Java.Lang.Exception p0)
		{
			if (id_getCause_Ljava_lang_Exception_ == IntPtr.Zero)
				id_getCause_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "getCause", "(Ljava/lang/Exception;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCause_Ljava_lang_Exception_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getErrorMessage_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='getErrorMessage' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("getErrorMessage", "(Ljava/lang/Exception;)Ljava/lang/String;", "")]
		public static unsafe string GetErrorMessage (global::Java.Lang.Exception p0)
		{
			if (id_getErrorMessage_Ljava_lang_Exception_ == IntPtr.Zero)
				id_getErrorMessage_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "getErrorMessage", "(Ljava/lang/Exception;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorMessage_Ljava_lang_Exception_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getErrorStack_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='getErrorStack' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("getErrorStack", "(Ljava/lang/Exception;)Lorg/json/JSONArray;", "")]
		public static unsafe global::Org.Json.JSONArray GetErrorStack (global::Java.Lang.Exception p0)
		{
			if (id_getErrorStack_Ljava_lang_Exception_ == IntPtr.Zero)
				id_getErrorStack_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "getErrorStack", "(Ljava/lang/Exception;)Lorg/json/JSONArray;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Json.JSONArray __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorStack_Ljava_lang_Exception_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLogJson_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='getLogJson' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLogJson", "(Landroid/content/Context;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetLogJson (global::Android.Content.Context p0)
		{
			if (id_getLogJson_Landroid_content_Context_ == IntPtr.Zero)
				id_getLogJson_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLogJson", "(Landroid/content/Context;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogJson_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPublisherPackage_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='getPublisherPackage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPublisherPackage", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetPublisherPackage (global::Android.Content.Context p0)
		{
			if (id_getPublisherPackage_Landroid_content_Context_ == IntPtr.Zero)
				id_getPublisherPackage_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPublisherPackage", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPublisherPackage_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUserAgent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='getUserAgent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUserAgent", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUserAgent (global::Android.Content.Context p0)
		{
			if (id_getUserAgent_Landroid_content_Context_ == IntPtr.Zero)
				id_getUserAgent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUserAgent", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserAgent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_post_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_networking_AsyncCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='post' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.mobfox.sdk.networking.AsyncCallback']]"
		[Register ("post", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/mobfox/sdk/networking/AsyncCallback;)V", "")]
		public static unsafe void Post (global::Android.Content.Context p0, global::Org.Json.JSONObject p1, global::Com.Mobfox.Sdk.Networking.IAsyncCallback p2)
		{
			if (id_post_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_networking_AsyncCallback_ == IntPtr.Zero)
				id_post_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_networking_AsyncCallback_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/mobfox/sdk/networking/AsyncCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_post_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_networking_AsyncCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_postCrash_Landroid_content_Context_Ljava_lang_Throwable_Lcom_mobfox_sdk_networking_AsyncCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='postCrash' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='com.mobfox.sdk.networking.AsyncCallback']]"
		[Register ("postCrash", "(Landroid/content/Context;Ljava/lang/Throwable;Lcom/mobfox/sdk/networking/AsyncCallback;)V", "")]
		public static unsafe void PostCrash (global::Android.Content.Context p0, global::Java.Lang.Throwable p1, global::Com.Mobfox.Sdk.Networking.IAsyncCallback p2)
		{
			if (id_postCrash_Landroid_content_Context_Ljava_lang_Throwable_Lcom_mobfox_sdk_networking_AsyncCallback_ == IntPtr.Zero)
				id_postCrash_Landroid_content_Context_Ljava_lang_Throwable_Lcom_mobfox_sdk_networking_AsyncCallback_ = JNIEnv.GetStaticMethodID (class_ref, "postCrash", "(Landroid/content/Context;Ljava/lang/Throwable;Lcom/mobfox/sdk/networking/AsyncCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_postCrash_Landroid_content_Context_Ljava_lang_Throwable_Lcom_mobfox_sdk_networking_AsyncCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_postException_Landroid_content_Context_Ljava_lang_Throwable_Lcom_mobfox_sdk_networking_AsyncCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='postException' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='com.mobfox.sdk.networking.AsyncCallback']]"
		[Register ("postException", "(Landroid/content/Context;Ljava/lang/Throwable;Lcom/mobfox/sdk/networking/AsyncCallback;)V", "")]
		public static unsafe void PostException (global::Android.Content.Context p0, global::Java.Lang.Throwable p1, global::Com.Mobfox.Sdk.Networking.IAsyncCallback p2)
		{
			if (id_postException_Landroid_content_Context_Ljava_lang_Throwable_Lcom_mobfox_sdk_networking_AsyncCallback_ == IntPtr.Zero)
				id_postException_Landroid_content_Context_Ljava_lang_Throwable_Lcom_mobfox_sdk_networking_AsyncCallback_ = JNIEnv.GetStaticMethodID (class_ref, "postException", "(Landroid/content/Context;Ljava/lang/Throwable;Lcom/mobfox/sdk/networking/AsyncCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_postException_Landroid_content_Context_Ljava_lang_Throwable_Lcom_mobfox_sdk_networking_AsyncCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_register_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("register", "(Landroid/content/Context;)V", "")]
		public static unsafe void Register (global::Android.Content.Context p0)
		{
			if (id_register_Landroid_content_Context_ == IntPtr.Zero)
				id_register_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_;
#pragma warning disable 0169
		static Delegate GetSetDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_Handler ()
		{
			if (cb_setDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ == null)
				cb_setDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_);
			return cb_setDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_;
		}

		static void n_SetDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Logging.MobFoxReport __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.MobFoxReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread.IUncaughtExceptionHandler p0 = (global::Java.Lang.Thread.IUncaughtExceptionHandler)global::Java.Lang.Object.GetObject<global::Java.Lang.Thread.IUncaughtExceptionHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultHandler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='setDefaultHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Thread.UncaughtExceptionHandler']]"
		[Register ("setDefaultHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V", "GetSetDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_Handler")]
		protected virtual unsafe void SetDefaultHandler (global::Java.Lang.Thread.IUncaughtExceptionHandler p0)
		{
			if (id_setDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ == IntPtr.Zero)
				id_setDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ = JNIEnv.GetMethodID (class_ref, "setDefaultHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultHandler_Ljava_lang_Thread_UncaughtExceptionHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler ()
		{
			if (cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_);
			return cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Logging.MobFoxReport __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.MobFoxReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UncaughtException (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='MobFoxReport']/method[@name='uncaughtException' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void UncaughtException (global::Java.Lang.Thread p0, global::Java.Lang.Throwable p1)
		{
			if (id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

	}
}
