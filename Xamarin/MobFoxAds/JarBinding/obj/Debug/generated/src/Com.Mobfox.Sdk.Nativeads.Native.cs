using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/Native", DoNotGenerateAcw=true)]
	public partial class Native : global::Java.Lang.Object {


		static IntPtr loc_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/field[@name='loc']"
		[Register ("loc")]
		public static bool Loc {
			get {
				if (loc_jfieldId == IntPtr.Zero)
					loc_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "loc", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, loc_jfieldId);
			}
			set {
				if (loc_jfieldId == IntPtr.Zero)
					loc_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "loc", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, loc_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr params_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/field[@name='params']"
		[Register ("params")]
		public global::Com.Mobfox.Sdk.Networking.RequestParams Params {
			get {
				if (params_jfieldId == IntPtr.Zero)
					params_jfieldId = JNIEnv.GetFieldID (class_ref, "params", "Lcom/mobfox/sdk/networking/RequestParams;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, params_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.RequestParams> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (params_jfieldId == IntPtr.Zero)
					params_jfieldId = JNIEnv.GetFieldID (class_ref, "params", "Lcom/mobfox/sdk/networking/RequestParams;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, params_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/nativeads/Native", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Native); }
		}

		protected Native (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/constructor[@name='Native' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Native (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Native)) {
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

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static Delegate cb_setListener_Lcom_mobfox_sdk_nativeads_NativeListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_mobfox_sdk_nativeads_NativeListener_Handler ()
		{
			if (cb_setListener_Lcom_mobfox_sdk_nativeads_NativeListener_ == null)
				cb_setListener_Lcom_mobfox_sdk_nativeads_NativeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_mobfox_sdk_nativeads_NativeListener_);
			return cb_setListener_Lcom_mobfox_sdk_nativeads_NativeListener_;
		}

		static void n_SetListener_Lcom_mobfox_sdk_nativeads_NativeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Nativeads.INativeListener p0 = (global::Com.Mobfox.Sdk.Nativeads.INativeListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.INativeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Listener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getListener;
		static IntPtr id_setListener_Lcom_mobfox_sdk_nativeads_NativeListener_;
		public virtual unsafe global::Com.Mobfox.Sdk.Nativeads.INativeListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/mobfox/sdk/nativeads/NativeListener;", "GetGetListenerHandler")]
			get {
				if (id_getListener == IntPtr.Zero)
					id_getListener = JNIEnv.GetMethodID (class_ref, "getListener", "()Lcom/mobfox/sdk/nativeads/NativeListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.INativeListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.INativeListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListener", "()Lcom/mobfox/sdk/nativeads/NativeListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.nativeads.NativeListener']]"
			[Register ("setListener", "(Lcom/mobfox/sdk/nativeads/NativeListener;)V", "GetSetListener_Lcom_mobfox_sdk_nativeads_NativeListener_Handler")]
			set {
				if (id_setListener_Lcom_mobfox_sdk_nativeads_NativeListener_ == IntPtr.Zero)
					id_setListener_Lcom_mobfox_sdk_nativeads_NativeListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/mobfox/sdk/nativeads/NativeListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_mobfox_sdk_nativeads_NativeListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/mobfox/sdk/nativeads/NativeListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRespHandler;
#pragma warning disable 0169
		static Delegate GetGetRespHandlerHandler ()
		{
			if (cb_getRespHandler == null)
				cb_getRespHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRespHandler);
			return cb_getRespHandler;
		}

		static IntPtr n_GetRespHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RespHandler);
		}
#pragma warning restore 0169

		static Delegate cb_setRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_;
#pragma warning disable 0169
		static Delegate GetSetRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_Handler ()
		{
			if (cb_setRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ == null)
				cb_setRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_);
			return cb_setRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_;
		}

		static void n_SetRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON p0 = (global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RespHandler = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRespHandler;
		static IntPtr id_setRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_;
		public virtual unsafe global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON RespHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='getRespHandler' and count(parameter)=0]"
			[Register ("getRespHandler", "()Lcom/mobfox/sdk/networking/AsyncCallbackJSON;", "GetGetRespHandlerHandler")]
			get {
				if (id_getRespHandler == IntPtr.Zero)
					id_getRespHandler = JNIEnv.GetMethodID (class_ref, "getRespHandler", "()Lcom/mobfox/sdk/networking/AsyncCallbackJSON;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRespHandler), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRespHandler", "()Lcom/mobfox/sdk/networking/AsyncCallbackJSON;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='setRespHandler' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.networking.AsyncCallbackJSON']]"
			[Register ("setRespHandler", "(Lcom/mobfox/sdk/networking/AsyncCallbackJSON;)V", "GetSetRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_Handler")]
			set {
				if (id_setRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ == IntPtr.Zero)
					id_setRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ = JNIEnv.GetMethodID (class_ref, "setRespHandler", "(Lcom/mobfox/sdk/networking/AsyncCallbackJSON;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRespHandler_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRespHandler", "(Lcom/mobfox/sdk/networking/AsyncCallbackJSON;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static void n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='getLocation' and count(parameter)=0]"
		[Register ("getLocation", "()V", "GetGetLocationHandler")]
		protected virtual unsafe void GetLocation ()
		{
			if (id_getLocation == IntPtr.Zero)
				id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLocation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()V"));
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_load_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_;
		}

		static void n_Load_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0);
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)V", "GetLoad_Ljava_lang_String_Handler")]
		public virtual unsafe void Load (string p0)
		{
			if (id_load_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI);
			return cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnRequestPermissionsResult (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
		[Register ("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe void OnRequestPermissionsResult (int p0, string[] p1, int[] p2)
		{
			if (id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_setDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "")]
		public static unsafe void SetDebug (bool p0)
		{
			if (id_setDebug_Z == IntPtr.Zero)
				id_setDebug_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebug", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebug_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setLoc_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='setLoc' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoc", "(Z)V", "")]
		public static unsafe void SetLoc (bool p0)
		{
			if (id_setLoc_Z == IntPtr.Zero)
				id_setLoc_Z = JNIEnv.GetStaticMethodID (class_ref, "setLoc", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLoc_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
		public virtual unsafe void SetLocation (global::Android.Locations.Location p0)
		{
			if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setParams_Lcom_mobfox_sdk_networking_RequestParams_;
#pragma warning disable 0169
		static Delegate GetSetParams_Lcom_mobfox_sdk_networking_RequestParams_Handler ()
		{
			if (cb_setParams_Lcom_mobfox_sdk_networking_RequestParams_ == null)
				cb_setParams_Lcom_mobfox_sdk_networking_RequestParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParams_Lcom_mobfox_sdk_networking_RequestParams_);
			return cb_setParams_Lcom_mobfox_sdk_networking_RequestParams_;
		}

		static void n_SetParams_Lcom_mobfox_sdk_networking_RequestParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Networking.RequestParams p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.RequestParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetParams (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setParams_Lcom_mobfox_sdk_networking_RequestParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='setParams' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.networking.RequestParams']]"
		[Register ("setParams", "(Lcom/mobfox/sdk/networking/RequestParams;)V", "GetSetParams_Lcom_mobfox_sdk_networking_RequestParams_Handler")]
		public virtual unsafe void SetParams (global::Com.Mobfox.Sdk.Networking.RequestParams p0)
		{
			if (id_setParams_Lcom_mobfox_sdk_networking_RequestParams_ == IntPtr.Zero)
				id_setParams_Lcom_mobfox_sdk_networking_RequestParams_ = JNIEnv.GetMethodID (class_ref, "setParams", "(Lcom/mobfox/sdk/networking/RequestParams;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParams_Lcom_mobfox_sdk_networking_RequestParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParams", "(Lcom/mobfox/sdk/networking/RequestParams;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_;
#pragma warning disable 0169
		static Delegate GetSetReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_Handler ()
		{
			if (cb_setReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_ == null)
				cb_setReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_);
			return cb_setReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_;
		}

		static void n_SetReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener p0 = (global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetReadyListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='setReadyListener' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.nativeads.NativeRequestBuilder.ReadyListener']]"
		[Register ("setReadyListener", "(Lcom/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener;)V", "GetSetReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_Handler")]
		public virtual unsafe void SetReadyListener (global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener p0)
		{
			if (id_setReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_ == IntPtr.Zero)
				id_setReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_ = JNIEnv.GetMethodID (class_ref, "setReadyListener", "(Lcom/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReadyListener_Lcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadyListener", "(Lcom/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSecure_Z;
#pragma warning disable 0169
		static Delegate GetSetSecure_ZHandler ()
		{
			if (cb_setSecure_Z == null)
				cb_setSecure_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSecure_Z);
			return cb_setSecure_Z;
		}

		static void n_SetSecure_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.Native __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.Native> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSecure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSecure_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='Native']/method[@name='setSecure' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSecure", "(Z)V", "GetSetSecure_ZHandler")]
		public virtual unsafe void SetSecure (bool p0)
		{
			if (id_setSecure_Z == IntPtr.Zero)
				id_setSecure_Z = JNIEnv.GetMethodID (class_ref, "setSecure", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecure_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecure", "(Z)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener"
		public event EventHandler<global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.ReadyEventArgs> Ready {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener, global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListenerImplementor>(
						ref weak_implementor_SetReadyListener,
						__CreateIReadyListenerImplementor,
						SetReadyListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener, global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListenerImplementor>(
						ref weak_implementor_SetReadyListener,
						global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListenerImplementor.__IsEmpty,
						__v => SetReadyListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetReadyListener;

		global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListenerImplementor __CreateIReadyListenerImplementor ()
		{
			return new global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mobfox.Sdk.Nativeads.INativeListener"

		global::Com.Mobfox.Sdk.Nativeads.INativeListenerImplementor __CreateINativeListenerImplementor ()
		{
			return new global::Com.Mobfox.Sdk.Nativeads.INativeListenerImplementor (this);
		}
#endregion
	}
}
