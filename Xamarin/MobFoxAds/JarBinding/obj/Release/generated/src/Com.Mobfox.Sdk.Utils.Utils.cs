using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/utils/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/utils/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Utils)) {
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

		static IntPtr id_convertDpToPixel_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='convertDpToPixel' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("convertDpToPixel", "(FLandroid/content/Context;)I", "")]
		public static unsafe int ConvertDpToPixel (float p0, global::Android.Content.Context p1)
		{
			if (id_convertDpToPixel_FLandroid_content_Context_ == IntPtr.Zero)
				id_convertDpToPixel_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "convertDpToPixel", "(FLandroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_convertDpToPixel_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decodeBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBase64", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap DecodeBase64 (string p0)
		{
			if (id_decodeBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeBase64_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeBase64", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeBase64_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getClickVideoResp_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='getClickVideoResp' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getClickVideoResp", "(Lorg/json/JSONObject;)Ljava/lang/String;", "")]
		public static unsafe string GetClickVideoResp (global::Org.Json.JSONObject p0)
		{
			if (id_getClickVideoResp_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getClickVideoResp_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getClickVideoResp", "(Lorg/json/JSONObject;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClickVideoResp_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFileSize_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='getFileSize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getFileSize", "(Ljava/io/File;)J", "")]
		public static unsafe long GetFileSize (global::Java.IO.File p0)
		{
			if (id_getFileSize_Ljava_io_File_ == IntPtr.Zero)
				id_getFileSize_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getFileSize", "(Ljava/io/File;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getFileSize_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getIPAddress_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='getIPAddress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getIPAddress", "(Z)Ljava/lang/String;", "")]
		public static unsafe string GetIPAddress (bool p0)
		{
			if (id_getIPAddress_Z == IntPtr.Zero)
				id_getIPAddress_Z = JNIEnv.GetStaticMethodID (class_ref, "getIPAddress", "(Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIPAddress_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getMediaUrl_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='getMediaUrl' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getMediaUrl", "(Lorg/json/JSONObject;)Ljava/lang/String;", "")]
		public static unsafe string GetMediaUrl (global::Org.Json.JSONObject p0)
		{
			if (id_getMediaUrl_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getMediaUrl_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getMediaUrl", "(Lorg/json/JSONObject;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMediaUrl_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_read_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='read' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("read", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Read (global::Android.Content.Context p0, string p1)
		{
			if (id_read_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_read_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_replaceAudioCached_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='replaceAudioCached' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("replaceAudioCached", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject ReplaceAudioCached (string p0, global::Org.Json.JSONObject p1)
		{
			if (id_replaceAudioCached_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_replaceAudioCached_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "replaceAudioCached", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceAudioCached_Ljava_lang_String_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_replaceToCached_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='replaceToCached' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("replaceToCached", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject ReplaceToCached (string p0, global::Org.Json.JSONObject p1)
		{
			if (id_replaceToCached_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_replaceToCached_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "replaceToCached", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_replaceToCached_Ljava_lang_String_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_write_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.utils']/class[@name='Utils']/method[@name='write' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("write", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Write (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_write_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_write_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "write", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_write_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
