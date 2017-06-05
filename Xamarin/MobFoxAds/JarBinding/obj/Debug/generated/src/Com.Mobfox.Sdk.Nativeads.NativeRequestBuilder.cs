using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeRequestBuilder']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/NativeRequestBuilder", DoNotGenerateAcw=true)]
	public partial class NativeRequestBuilder : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/interface[@name='NativeRequestBuilder.ReadyListener']"
		[Register ("com/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener", "", "Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder/IReadyListenerInvoker")]
		public partial interface IReadyListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/interface[@name='NativeRequestBuilder.ReadyListener']/method[@name='onReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onReady", "(Ljava/lang/String;)V", "GetOnReady_Ljava_lang_String_Handler:Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder/IReadyListenerInvoker, JarBinding")]
			void OnReady (string p0);

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener", DoNotGenerateAcw=true)]
		internal class IReadyListenerInvoker : global::Java.Lang.Object, IReadyListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IReadyListenerInvoker); }
			}

			IntPtr class_ref;

			public static IReadyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IReadyListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.nativeads.NativeRequestBuilder.ReadyListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IReadyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onReady_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnReady_Ljava_lang_String_Handler ()
			{
				if (cb_onReady_Ljava_lang_String_ == null)
					cb_onReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReady_Ljava_lang_String_);
				return cb_onReady_Ljava_lang_String_;
			}

			static void n_OnReady_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReady_Ljava_lang_String_;
			public unsafe void OnReady (string p0)
			{
				if (id_onReady_Ljava_lang_String_ == IntPtr.Zero)
					id_onReady_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReady", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReady_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class ReadyEventArgs : global::System.EventArgs {

			public ReadyEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mobfox/sdk/nativeads/NativeRequestBuilder_ReadyListenerImplementor")]
		internal sealed partial class IReadyListenerImplementor : global::Java.Lang.Object, IReadyListener {

			object sender;

			public IReadyListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/nativeads/NativeRequestBuilder_ReadyListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ReadyEventArgs> Handler;
#pragma warning restore 0649

			public void OnReady (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ReadyEventArgs (p0));
			}

			internal static bool __IsEmpty (IReadyListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/nativeads/NativeRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeRequestBuilder); }
		}

		protected NativeRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_networking_RequestParams_ZLcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeRequestBuilder']/constructor[@name='NativeRequestBuilder' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.networking.RequestParams'] and parameter[3][@type='boolean'] and parameter[4][@type='com.mobfox.sdk.nativeads.NativeRequestBuilder.ReadyListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mobfox/sdk/networking/RequestParams;ZLcom/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener;)V", "")]
		public unsafe NativeRequestBuilder (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Networking.RequestParams p1, bool p2, global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder.IReadyListener p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (NativeRequestBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/mobfox/sdk/networking/RequestParams;ZLcom/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/mobfox/sdk/networking/RequestParams;ZLcom/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_networking_RequestParams_ZLcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_networking_RequestParams_ZLcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mobfox/sdk/networking/RequestParams;ZLcom/mobfox/sdk/nativeads/NativeRequestBuilder$ReadyListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_networking_RequestParams_ZLcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_networking_RequestParams_ZLcom_mobfox_sdk_nativeads_NativeRequestBuilder_ReadyListener_, __args);
			} finally {
			}
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Params);
		}
#pragma warning restore 0169

		static IntPtr id_getParams;
		public virtual unsafe global::Com.Mobfox.Sdk.Networking.RequestParams Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeRequestBuilder']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Lcom/mobfox/sdk/networking/RequestParams;", "GetGetParamsHandler")]
			get {
				if (id_getParams == IntPtr.Zero)
					id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Lcom/mobfox/sdk/networking/RequestParams;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.RequestParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Networking.RequestParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParams", "()Lcom/mobfox/sdk/networking/RequestParams;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static void n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Build ();
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeRequestBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()V", "GetBuildHandler")]
		public virtual unsafe void Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_build);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()V"));
			} finally {
			}
		}

	}
}
