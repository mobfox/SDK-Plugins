using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Dmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='Bundle']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/dmp/Bundle", DoNotGenerateAcw=true)]
	public partial class Bundle : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/dmp/Bundle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Bundle); }
		}

		protected Bundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='Bundle']/constructor[@name='Bundle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Bundle (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (Bundle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBundleObj;
#pragma warning disable 0169
		static Delegate GetGetBundleObjHandler ()
		{
			if (cb_getBundleObj == null)
				cb_getBundleObj = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBundleObj);
			return cb_getBundleObj;
		}

		static IntPtr n_GetBundleObj (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Dmp.Bundle __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.Bundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BundleObj);
		}
#pragma warning restore 0169

		static IntPtr id_getBundleObj;
		public virtual unsafe global::Org.Json.JSONObject BundleObj {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='Bundle']/method[@name='getBundleObj' and count(parameter)=0]"
			[Register ("getBundleObj", "()Lorg/json/JSONObject;", "GetGetBundleObjHandler")]
			get {
				if (id_getBundleObj == IntPtr.Zero)
					id_getBundleObj = JNIEnv.GetMethodID (class_ref, "getBundleObj", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBundleObj), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBundleObj", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_);
			return cb_addData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mobfox.Sdk.Dmp.Bundle __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.Bundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<int[]>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.AddData (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_addData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='Bundle']/method[@name='addData' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;int[]&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("addData", "(Landroid/content/Context;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)V", "GetAddData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddData (global::Android.Content.Context p0, global::System.Collections.Generic.IList<int[]> p1, string p2, string p3)
		{
			if (id_addData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addData", "(Landroid/content/Context;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addData_Landroid_content_Context_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addData", "(Landroid/content/Context;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_parse_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='Bundle']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("parse", "([I)Ljava/lang/String;", "")]
		protected static unsafe string Parse (int[] p0)
		{
			if (id_parse_arrayI == IntPtr.Zero)
				id_parse_arrayI = JNIEnv.GetStaticMethodID (class_ref, "parse", "([I)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_prepare_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='Bundle']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("prepare", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string Prepare (string p0)
		{
			if (id_prepare_Ljava_lang_String_ == IntPtr.Zero)
				id_prepare_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "prepare", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_prepare_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
