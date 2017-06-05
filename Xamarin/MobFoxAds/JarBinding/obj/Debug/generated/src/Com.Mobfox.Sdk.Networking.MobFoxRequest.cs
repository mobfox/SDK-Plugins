using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Networking {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/networking/MobFoxRequest", DoNotGenerateAcw=true)]
	public partial class MobFoxRequest : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest.DefaultResponseFormatter']"
		[global::Android.Runtime.Register ("com/mobfox/sdk/networking/MobFoxRequest$DefaultResponseFormatter", DoNotGenerateAcw=true)]
		public partial class DefaultResponseFormatter : global::Java.Lang.Object, global::Com.Mobfox.Sdk.Networking.MobFoxRequest.IResponseFormatter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mobfox/sdk/networking/MobFoxRequest$DefaultResponseFormatter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultResponseFormatter); }
			}

			protected DefaultResponseFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_format_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetFormat_Ljava_io_InputStream_Handler ()
			{
				if (cb_format_Ljava_io_InputStream_ == null)
					cb_format_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Format_Ljava_io_InputStream_);
				return cb_format_Ljava_io_InputStream_;
			}

			static IntPtr n_Format_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mobfox.Sdk.Networking.MobFoxRequest.DefaultResponseFormatter __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest.DefaultResponseFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_format_Ljava_io_InputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest.DefaultResponseFormatter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("format", "(Ljava/io/InputStream;)Ljava/lang/Object;", "GetFormat_Ljava_io_InputStream_Handler")]
			public virtual unsafe global::Java.Lang.Object Format (global::System.IO.Stream p0)
			{
				if (id_format_Ljava_io_InputStream_ == IntPtr.Zero)
					id_format_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/io/InputStream;)Ljava/lang/Object;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/io/InputStream;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.networking']/interface[@name='MobFoxRequest.ResponseFormatter']"
		[Register ("com/mobfox/sdk/networking/MobFoxRequest$ResponseFormatter", "", "Com.Mobfox.Sdk.Networking.MobFoxRequest/IResponseFormatterInvoker")]
		public partial interface IResponseFormatter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/interface[@name='MobFoxRequest.ResponseFormatter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("format", "(Ljava/io/InputStream;)Ljava/lang/Object;", "GetFormat_Ljava_io_InputStream_Handler:Com.Mobfox.Sdk.Networking.MobFoxRequest/IResponseFormatterInvoker, JarBinding")]
			global::Java.Lang.Object Format (global::System.IO.Stream p0);

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/networking/MobFoxRequest$ResponseFormatter", DoNotGenerateAcw=true)]
		internal class IResponseFormatterInvoker : global::Java.Lang.Object, IResponseFormatter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/networking/MobFoxRequest$ResponseFormatter");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IResponseFormatterInvoker); }
			}

			IntPtr class_ref;

			public static IResponseFormatter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResponseFormatter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.networking.MobFoxRequest.ResponseFormatter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResponseFormatterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_format_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetFormat_Ljava_io_InputStream_Handler ()
			{
				if (cb_format_Ljava_io_InputStream_ == null)
					cb_format_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Format_Ljava_io_InputStream_);
				return cb_format_Ljava_io_InputStream_;
			}

			static IntPtr n_Format_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mobfox.Sdk.Networking.MobFoxRequest.IResponseFormatter __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest.IResponseFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Format (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_format_Ljava_io_InputStream_;
			public unsafe global::Java.Lang.Object Format (global::System.IO.Stream p0)
			{
				if (id_format_Ljava_io_InputStream_ == IntPtr.Zero)
					id_format_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/io/InputStream;)Ljava/lang/Object;");
				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/networking/MobFoxRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxRequest); }
		}

		protected MobFoxRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/constructor[@name='MobFoxRequest' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe MobFoxRequest (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (MobFoxRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_get_Lcom_mobfox_sdk_networking_AsyncCallback_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_mobfox_sdk_networking_AsyncCallback_Handler ()
		{
			if (cb_get_Lcom_mobfox_sdk_networking_AsyncCallback_ == null)
				cb_get_Lcom_mobfox_sdk_networking_AsyncCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Get_Lcom_mobfox_sdk_networking_AsyncCallback_);
			return cb_get_Lcom_mobfox_sdk_networking_AsyncCallback_;
		}

		static void n_Get_Lcom_mobfox_sdk_networking_AsyncCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Networking.IAsyncCallback p0 = (global::Com.Mobfox.Sdk.Networking.IAsyncCallback)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0);
		}
#pragma warning restore 0169

		static IntPtr id_get_Lcom_mobfox_sdk_networking_AsyncCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.networking.AsyncCallback']]"
		[Register ("get", "(Lcom/mobfox/sdk/networking/AsyncCallback;)V", "GetGet_Lcom_mobfox_sdk_networking_AsyncCallback_Handler")]
		public virtual unsafe void Get (global::Com.Mobfox.Sdk.Networking.IAsyncCallback p0)
		{
			if (id_get_Lcom_mobfox_sdk_networking_AsyncCallback_ == IntPtr.Zero)
				id_get_Lcom_mobfox_sdk_networking_AsyncCallback_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/mobfox/sdk/networking/AsyncCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_get_Lcom_mobfox_sdk_networking_AsyncCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Lcom/mobfox/sdk/networking/AsyncCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_;
#pragma warning disable 0169
		static Delegate GetGetBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_Handler ()
		{
			if (cb_getBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_ == null)
				cb_getBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_);
			return cb_getBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_;
		}

		static void n_GetBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Networking.IAsyncCallbackBitmap p0 = (global::Com.Mobfox.Sdk.Networking.IAsyncCallbackBitmap)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallbackBitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetBitmap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.networking.AsyncCallbackBitmap']]"
		[Register ("getBitmap", "(Lcom/mobfox/sdk/networking/AsyncCallbackBitmap;)V", "GetGetBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_Handler")]
		public virtual unsafe void GetBitmap (global::Com.Mobfox.Sdk.Networking.IAsyncCallbackBitmap p0)
		{
			if (id_getBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_ == IntPtr.Zero)
				id_getBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_ = JNIEnv.GetMethodID (class_ref, "getBitmap", "(Lcom/mobfox/sdk/networking/AsyncCallbackBitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBitmap_Lcom_mobfox_sdk_networking_AsyncCallbackBitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmap", "(Lcom/mobfox/sdk/networking/AsyncCallbackBitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_;
#pragma warning disable 0169
		static Delegate GetGetDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_Handler ()
		{
			if (cb_getDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_ == null)
				cb_getDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_);
			return cb_getDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_;
		}

		static void n_GetDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Networking.IAsyncCallbackDrawable p0 = (global::Com.Mobfox.Sdk.Networking.IAsyncCallbackDrawable)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallbackDrawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.networking.AsyncCallbackDrawable']]"
		[Register ("getDrawable", "(Lcom/mobfox/sdk/networking/AsyncCallbackDrawable;)V", "GetGetDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_Handler")]
		public virtual unsafe void GetDrawable (global::Com.Mobfox.Sdk.Networking.IAsyncCallbackDrawable p0)
		{
			if (id_getDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_ == IntPtr.Zero)
				id_getDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_ = JNIEnv.GetMethodID (class_ref, "getDrawable", "(Lcom/mobfox/sdk/networking/AsyncCallbackDrawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getDrawable_Lcom_mobfox_sdk_networking_AsyncCallbackDrawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawable", "(Lcom/mobfox/sdk/networking/AsyncCallbackDrawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_;
#pragma warning disable 0169
		static Delegate GetGetJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_Handler ()
		{
			if (cb_getJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ == null)
				cb_getJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_);
			return cb_getJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_;
		}

		static void n_GetJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON p0 = (global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetJSON (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='getJSON' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.networking.AsyncCallbackJSON']]"
		[Register ("getJSON", "(Lcom/mobfox/sdk/networking/AsyncCallbackJSON;)V", "GetGetJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_Handler")]
		public virtual unsafe void GetJSON (global::Com.Mobfox.Sdk.Networking.IAsyncCallbackJSON p0)
		{
			if (id_getJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ == IntPtr.Zero)
				id_getJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_ = JNIEnv.GetMethodID (class_ref, "getJSON", "(Lcom/mobfox/sdk/networking/AsyncCallbackJSON;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getJSON_Lcom_mobfox_sdk_networking_AsyncCallbackJSON_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSON", "(Lcom/mobfox/sdk/networking/AsyncCallbackJSON;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_post_Lcom_mobfox_sdk_networking_AsyncCallback_;
#pragma warning disable 0169
		static Delegate GetPost_Lcom_mobfox_sdk_networking_AsyncCallback_Handler ()
		{
			if (cb_post_Lcom_mobfox_sdk_networking_AsyncCallback_ == null)
				cb_post_Lcom_mobfox_sdk_networking_AsyncCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Post_Lcom_mobfox_sdk_networking_AsyncCallback_);
			return cb_post_Lcom_mobfox_sdk_networking_AsyncCallback_;
		}

		static void n_Post_Lcom_mobfox_sdk_networking_AsyncCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Networking.IAsyncCallback p0 = (global::Com.Mobfox.Sdk.Networking.IAsyncCallback)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.IAsyncCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0);
		}
#pragma warning restore 0169

		static IntPtr id_post_Lcom_mobfox_sdk_networking_AsyncCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='post' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.networking.AsyncCallback']]"
		[Register ("post", "(Lcom/mobfox/sdk/networking/AsyncCallback;)V", "GetPost_Lcom_mobfox_sdk_networking_AsyncCallback_Handler")]
		public virtual unsafe void Post (global::Com.Mobfox.Sdk.Networking.IAsyncCallback p0)
		{
			if (id_post_Lcom_mobfox_sdk_networking_AsyncCallback_ == IntPtr.Zero)
				id_post_Lcom_mobfox_sdk_networking_AsyncCallback_ = JNIEnv.GetMethodID (class_ref, "post", "(Lcom/mobfox/sdk/networking/AsyncCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_post_Lcom_mobfox_sdk_networking_AsyncCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Lcom/mobfox/sdk/networking/AsyncCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setData_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetData_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setData_Lorg_json_JSONObject_ == null)
				cb_setData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetData_Lorg_json_JSONObject_);
			return cb_setData_Lorg_json_JSONObject_;
		}

		static IntPtr n_SetData_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setData_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setData", "(Lorg/json/JSONObject;)Lcom/mobfox/sdk/networking/MobFoxRequest;", "GetSetData_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.Mobfox.Sdk.Networking.MobFoxRequest SetData (global::Org.Json.JSONObject p0)
		{
			if (id_setData_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setData_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setData", "(Lorg/json/JSONObject;)Lcom/mobfox/sdk/networking/MobFoxRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mobfox.Sdk.Networking.MobFoxRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setData_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Lorg/json/JSONObject;)Lcom/mobfox/sdk/networking/MobFoxRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_setHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mobfox/sdk/networking/MobFoxRequest;", "GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mobfox.Sdk.Networking.MobFoxRequest SetHeader (string p0, string p1)
		{
			if (id_setHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mobfox/sdk/networking/MobFoxRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mobfox.Sdk.Networking.MobFoxRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHeader_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mobfox/sdk/networking/MobFoxRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParam_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setParam_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParam_Ljava_lang_String_Ljava_lang_String_);
			return cb_setParam_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetParam (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setParam_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='setParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mobfox/sdk/networking/MobFoxRequest;", "GetSetParam_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mobfox.Sdk.Networking.MobFoxRequest SetParam (string p0, string p1)
		{
			if (id_setParam_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setParam_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mobfox/sdk/networking/MobFoxRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mobfox.Sdk.Networking.MobFoxRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setParam_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/mobfox/sdk/networking/MobFoxRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setTestMode_Z;
#pragma warning disable 0169
		static Delegate GetSetTestMode_ZHandler ()
		{
			if (cb_setTestMode_Z == null)
				cb_setTestMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTestMode_Z);
			return cb_setTestMode_Z;
		}

		static void n_SetTestMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTestMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTestMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='setTestMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTestMode", "(Z)V", "GetSetTestMode_ZHandler")]
		public virtual unsafe void SetTestMode (bool p0)
		{
			if (id_setTestMode_Z == IntPtr.Zero)
				id_setTestMode_Z = JNIEnv.GetMethodID (class_ref, "setTestMode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTestMode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTestMode", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static IntPtr n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mobfox.Sdk.Networking.MobFoxRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTimeout (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.networking']/class[@name='MobFoxRequest']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)Lcom/mobfox/sdk/networking/MobFoxRequest;", "GetSetTimeout_IHandler")]
		public virtual unsafe global::Com.Mobfox.Sdk.Networking.MobFoxRequest SetTimeout (int p0)
		{
			if (id_setTimeout_I == IntPtr.Zero)
				id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)Lcom/mobfox/sdk/networking/MobFoxRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTimeout_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.MobFoxRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)Lcom/mobfox/sdk/networking/MobFoxRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
