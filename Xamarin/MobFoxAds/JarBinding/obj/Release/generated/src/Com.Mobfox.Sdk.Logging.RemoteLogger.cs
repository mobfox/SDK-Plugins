using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/logging/RemoteLogger", DoNotGenerateAcw=true)]
	public partial class RemoteLogger : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/field[@name='DOMAIN']"
		[Register ("DOMAIN")]
		public const string Domain = (string) "http://sdk-logs.matomy.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/field[@name='PATHNAME']"
		[Register ("PATHNAME")]
		public const string Pathname = (string) "gelf";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/field[@name='PORT']"
		[Register ("PORT")]
		public const int Port = (int) 12201;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']"
		[global::Android.Runtime.Register ("com/mobfox/sdk/logging/RemoteLogger$Message", DoNotGenerateAcw=true)]
		public sealed partial class Message : global::Java.Lang.Enum {


			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='ERROR_INTERSTITIAL']"
			[Register ("ERROR_INTERSTITIAL")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message ErrorInterstitial {
				get {
					if (ERROR_INTERSTITIAL_jfieldId == IntPtr.Zero)
						ERROR_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_INTERSTITIAL", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOADED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='LOADED']"
			[Register ("LOADED")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message Loaded {
				get {
					if (LOADED_jfieldId == IntPtr.Zero)
						LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOADED_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='LOADED_INTERSTITIAL']"
			[Register ("LOADED_INTERSTITIAL")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message LoadedInterstitial {
				get {
					if (LOADED_INTERSTITIAL_jfieldId == IntPtr.Zero)
						LOADED_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED_INTERSTITIAL", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADED_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_FILL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='NO_FILL']"
			[Register ("NO_FILL")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message NoFill {
				get {
					if (NO_FILL_jfieldId == IntPtr.Zero)
						NO_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_FILL", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_FILL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_FILL_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='NO_FILL_INTERSTITIAL']"
			[Register ("NO_FILL_INTERSTITIAL")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message NoFillInterstitial {
				get {
					if (NO_FILL_INTERSTITIAL_jfieldId == IntPtr.Zero)
						NO_FILL_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_FILL_INTERSTITIAL", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_FILL_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='REQUEST']"
			[Register ("REQUEST")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message Request {
				get {
					if (REQUEST_jfieldId == IntPtr.Zero)
						REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUEST_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='REQUEST_INTERSTITIAL']"
			[Register ("REQUEST_INTERSTITIAL")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message RequestInterstitial {
				get {
					if (REQUEST_INTERSTITIAL_jfieldId == IntPtr.Zero)
						REQUEST_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_INTERSTITIAL", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SHOWN_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/field[@name='SHOWN_INTERSTITIAL']"
			[Register ("SHOWN_INTERSTITIAL")]
			public static global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message ShownInterstitial {
				get {
					if (SHOWN_INTERSTITIAL_jfieldId == IntPtr.Zero)
						SHOWN_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHOWN_INTERSTITIAL", "Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHOWN_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mobfox/sdk/logging/RemoteLogger$Message", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Message); }
			}

			internal Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mobfox/sdk/logging/RemoteLogger$Message;", "")]
			public static unsafe global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger.Message']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mobfox/sdk/logging/RemoteLogger$Message;", "")]
			public static unsafe global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mobfox/sdk/logging/RemoteLogger$Message;");
				try {
					return (global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mobfox.Sdk.Logging.RemoteLogger.Message));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/logging/RemoteLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RemoteLogger); }
		}

		protected RemoteLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/constructor[@name='RemoteLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RemoteLogger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RemoteLogger)) {
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

		static IntPtr id_getJSON_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/method[@name='getJSON' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("getJSON", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetJSON (global::Android.Content.Context p0, string p1, string p2, string p3, string p4)
		{
			if (id_getJSON_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getJSON_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getJSON", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJSON_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getJSON_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/method[@name='getJSON' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Exception']]"
		[Register ("getJSON", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetJSON (global::Android.Content.Context p0, string p1, string p2, string p3, string p4, global::Java.Lang.Exception p5)
		{
			if (id_getJSON_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_getJSON_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "getJSON", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)Lorg/json/JSONObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJSON_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_post_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/method[@name='post' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("post", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Post (global::Android.Content.Context p0, string p1, string p2, string p3, string p4)
		{
			if (id_post_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_post_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_post_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_post_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/method[@name='post' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Exception']]"
		[Register ("post", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static unsafe void Post (global::Android.Content.Context p0, string p1, string p2, string p3, string p4, global::Java.Lang.Exception p5)
		{
			if (id_post_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_post_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_post_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_postToGrayLog_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_networking_AsyncCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.logging']/class[@name='RemoteLogger']/method[@name='postToGrayLog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.mobfox.sdk.networking.AsyncCallback']]"
		[Register ("postToGrayLog", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/mobfox/sdk/networking/AsyncCallback;)V", "")]
		public static unsafe void PostToGrayLog (global::Android.Content.Context p0, global::Org.Json.JSONObject p1, global::Com.Mobfox.Sdk.Networking.IAsyncCallback p2)
		{
			if (id_postToGrayLog_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_networking_AsyncCallback_ == IntPtr.Zero)
				id_postToGrayLog_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_networking_AsyncCallback_ = JNIEnv.GetStaticMethodID (class_ref, "postToGrayLog", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/mobfox/sdk/networking/AsyncCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_postToGrayLog_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_networking_AsyncCallback_, __args);
			} finally {
			}
		}

	}
}
