using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Customevents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.customevents']/class[@name='CustomEventData']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/customevents/CustomEventData", DoNotGenerateAcw=true)]
	public partial class CustomEventData : global::Java.Lang.Object {


		static IntPtr className_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.customevents']/class[@name='CustomEventData']/field[@name='className']"
		[Register ("className")]
		public string ClassName {
			get {
				if (className_jfieldId == IntPtr.Zero)
					className_jfieldId = JNIEnv.GetFieldID (class_ref, "className", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, className_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (className_jfieldId == IntPtr.Zero)
					className_jfieldId = JNIEnv.GetFieldID (class_ref, "className", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, className_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr networkId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.customevents']/class[@name='CustomEventData']/field[@name='networkId']"
		[Register ("networkId")]
		public string NetworkId {
			get {
				if (networkId_jfieldId == IntPtr.Zero)
					networkId_jfieldId = JNIEnv.GetFieldID (class_ref, "networkId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, networkId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (networkId_jfieldId == IntPtr.Zero)
					networkId_jfieldId = JNIEnv.GetFieldID (class_ref, "networkId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, networkId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pixel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.customevents']/class[@name='CustomEventData']/field[@name='pixel']"
		[Register ("pixel")]
		public string Pixel {
			get {
				if (pixel_jfieldId == IntPtr.Zero)
					pixel_jfieldId = JNIEnv.GetFieldID (class_ref, "pixel", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, pixel_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pixel_jfieldId == IntPtr.Zero)
					pixel_jfieldId = JNIEnv.GetFieldID (class_ref, "pixel", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pixel_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/customevents/CustomEventData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventData); }
		}

		protected CustomEventData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.customevents']/class[@name='CustomEventData']/constructor[@name='CustomEventData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEventData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CustomEventData)) {
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

		static IntPtr id_parseJSON_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/class[@name='CustomEventData']/method[@name='parseJSON' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("parseJSON", "(Lorg/json/JSONObject;)Lcom/mobfox/sdk/customevents/CustomEventData;", "")]
		public static unsafe global::Com.Mobfox.Sdk.Customevents.CustomEventData ParseJSON (global::Org.Json.JSONObject p0)
		{
			if (id_parseJSON_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_parseJSON_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "parseJSON", "(Lorg/json/JSONObject;)Lcom/mobfox/sdk/customevents/CustomEventData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mobfox.Sdk.Customevents.CustomEventData __ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.CustomEventData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseJSON_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseJSONArray_Lorg_json_JSONArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/class[@name='CustomEventData']/method[@name='parseJSONArray' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("parseJSONArray", "(Lorg/json/JSONArray;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Customevents.CustomEventData> ParseJSONArray (global::Org.Json.JSONArray p0)
		{
			if (id_parseJSONArray_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_parseJSONArray_Lorg_json_JSONArray_ = JNIEnv.GetStaticMethodID (class_ref, "parseJSONArray", "(Lorg/json/JSONArray;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Customevents.CustomEventData> __ret = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Customevents.CustomEventData>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseJSONArray_Lorg_json_JSONArray_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
