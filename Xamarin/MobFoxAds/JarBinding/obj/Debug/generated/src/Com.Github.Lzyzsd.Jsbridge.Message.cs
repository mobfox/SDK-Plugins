using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Lzyzsd.Jsbridge {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']"
	[global::Android.Runtime.Register ("com/github/lzyzsd/jsbridge/Message", DoNotGenerateAcw=true)]
	public partial class Message : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/lzyzsd/jsbridge/Message", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Message); }
		}

		protected Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/constructor[@name='Message' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Message ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Message)) {
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

		static Delegate cb_getCallbackId;
#pragma warning disable 0169
		static Delegate GetGetCallbackIdHandler ()
		{
			if (cb_getCallbackId == null)
				cb_getCallbackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackId);
			return cb_getCallbackId;
		}

		static IntPtr n_GetCallbackId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallbackId);
		}
#pragma warning restore 0169

		static Delegate cb_setCallbackId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCallbackId_Ljava_lang_String_Handler ()
		{
			if (cb_setCallbackId_Ljava_lang_String_ == null)
				cb_setCallbackId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallbackId_Ljava_lang_String_);
			return cb_setCallbackId_Ljava_lang_String_;
		}

		static void n_SetCallbackId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallbackId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCallbackId;
		static IntPtr id_setCallbackId_Ljava_lang_String_;
		public virtual unsafe string CallbackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='getCallbackId' and count(parameter)=0]"
			[Register ("getCallbackId", "()Ljava/lang/String;", "GetGetCallbackIdHandler")]
			get {
				if (id_getCallbackId == IntPtr.Zero)
					id_getCallbackId = JNIEnv.GetMethodID (class_ref, "getCallbackId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallbackId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallbackId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='setCallbackId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCallbackId", "(Ljava/lang/String;)V", "GetSetCallbackId_Ljava_lang_String_Handler")]
			set {
				if (id_setCallbackId_Ljava_lang_String_ == IntPtr.Zero)
					id_setCallbackId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCallbackId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallbackId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallbackId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_lang_String_Handler ()
		{
			if (cb_setData_Ljava_lang_String_ == null)
				cb_setData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_lang_String_);
			return cb_setData_Ljava_lang_String_;
		}

		static void n_SetData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_lang_String_;
		public virtual unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setData", "(Ljava/lang/String;)V", "GetSetData_Ljava_lang_String_Handler")]
			set {
				if (id_setData_Ljava_lang_String_ == IntPtr.Zero)
					id_setData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHandlerName;
#pragma warning disable 0169
		static Delegate GetGetHandlerNameHandler ()
		{
			if (cb_getHandlerName == null)
				cb_getHandlerName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHandlerName);
			return cb_getHandlerName;
		}

		static IntPtr n_GetHandlerName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HandlerName);
		}
#pragma warning restore 0169

		static Delegate cb_setHandlerName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHandlerName_Ljava_lang_String_Handler ()
		{
			if (cb_setHandlerName_Ljava_lang_String_ == null)
				cb_setHandlerName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHandlerName_Ljava_lang_String_);
			return cb_setHandlerName_Ljava_lang_String_;
		}

		static void n_SetHandlerName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandlerName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHandlerName;
		static IntPtr id_setHandlerName_Ljava_lang_String_;
		public virtual unsafe string HandlerName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='getHandlerName' and count(parameter)=0]"
			[Register ("getHandlerName", "()Ljava/lang/String;", "GetGetHandlerNameHandler")]
			get {
				if (id_getHandlerName == IntPtr.Zero)
					id_getHandlerName = JNIEnv.GetMethodID (class_ref, "getHandlerName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHandlerName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHandlerName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='setHandlerName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHandlerName", "(Ljava/lang/String;)V", "GetSetHandlerName_Ljava_lang_String_Handler")]
			set {
				if (id_setHandlerName_Ljava_lang_String_ == IntPtr.Zero)
					id_setHandlerName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHandlerName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHandlerName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHandlerName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseData;
#pragma warning disable 0169
		static Delegate GetGetResponseDataHandler ()
		{
			if (cb_getResponseData == null)
				cb_getResponseData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseData);
			return cb_getResponseData;
		}

		static IntPtr n_GetResponseData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseData);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseData_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseData_Ljava_lang_String_ == null)
				cb_setResponseData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseData_Ljava_lang_String_);
			return cb_setResponseData_Ljava_lang_String_;
		}

		static void n_SetResponseData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseData;
		static IntPtr id_setResponseData_Ljava_lang_String_;
		public virtual unsafe string ResponseData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='getResponseData' and count(parameter)=0]"
			[Register ("getResponseData", "()Ljava/lang/String;", "GetGetResponseDataHandler")]
			get {
				if (id_getResponseData == IntPtr.Zero)
					id_getResponseData = JNIEnv.GetMethodID (class_ref, "getResponseData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='setResponseData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseData", "(Ljava/lang/String;)V", "GetSetResponseData_Ljava_lang_String_Handler")]
			set {
				if (id_setResponseData_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponseData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseId;
#pragma warning disable 0169
		static Delegate GetGetResponseIdHandler ()
		{
			if (cb_getResponseId == null)
				cb_getResponseId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseId);
			return cb_getResponseId;
		}

		static IntPtr n_GetResponseId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseId);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseId_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseId_Ljava_lang_String_ == null)
				cb_setResponseId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseId_Ljava_lang_String_);
			return cb_setResponseId_Ljava_lang_String_;
		}

		static void n_SetResponseId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseId;
		static IntPtr id_setResponseId_Ljava_lang_String_;
		public virtual unsafe string ResponseId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='getResponseId' and count(parameter)=0]"
			[Register ("getResponseId", "()Ljava/lang/String;", "GetGetResponseIdHandler")]
			get {
				if (id_getResponseId == IntPtr.Zero)
					id_getResponseId = JNIEnv.GetMethodID (class_ref, "getResponseId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='setResponseId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseId", "(Ljava/lang/String;)V", "GetSetResponseId_Ljava_lang_String_Handler")]
			set {
				if (id_setResponseId_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponseId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_toArrayList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='toArrayList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toArrayList", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Github.Lzyzsd.Jsbridge.Message> ToArrayList (string p0)
		{
			if (id_toArrayList_Ljava_lang_String_ == IntPtr.Zero)
				id_toArrayList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toArrayList", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<global::Com.Github.Lzyzsd.Jsbridge.Message> __ret = global::Android.Runtime.JavaList<global::Com.Github.Lzyzsd.Jsbridge.Message>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_toArrayList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.Message __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJson ());
		}
#pragma warning restore 0169

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Ljava/lang/String;", "GetToJsonHandler")]
		public virtual unsafe string ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJson", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='Message']/method[@name='toObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toObject", "(Ljava/lang/String;)Lcom/github/lzyzsd/jsbridge/Message;", "")]
		public static unsafe global::Com.Github.Lzyzsd.Jsbridge.Message ToObject (string p0)
		{
			if (id_toObject_Ljava_lang_String_ == IntPtr.Zero)
				id_toObject_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toObject", "(Ljava/lang/String;)Lcom/github/lzyzsd/jsbridge/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Github.Lzyzsd.Jsbridge.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
