using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Services {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxAdIdService']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/services/MobFoxAdIdService", DoNotGenerateAcw=true)]
	public partial class MobFoxAdIdService : global::Com.Mobfox.Sdk.Services.MobFoxService {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.services']/interface[@name='MobFoxAdIdService.Listener']"
		[Register ("com/mobfox/sdk/services/MobFoxAdIdService$Listener", "", "Com.Mobfox.Sdk.Services.MobFoxAdIdService/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/interface[@name='MobFoxAdIdService.Listener']/method[@name='onFinish' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onFinish", "(Ljava/lang/String;)V", "GetOnFinish_Ljava_lang_String_Handler:Com.Mobfox.Sdk.Services.MobFoxAdIdService/IListenerInvoker, JarBinding")]
			void OnFinish (string p0);

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/services/MobFoxAdIdService$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/services/MobFoxAdIdService$Listener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.services.MobFoxAdIdService.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFinish_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnFinish_Ljava_lang_String_Handler ()
			{
				if (cb_onFinish_Ljava_lang_String_ == null)
					cb_onFinish_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFinish_Ljava_lang_String_);
				return cb_onFinish_Ljava_lang_String_;
			}

			static void n_OnFinish_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mobfox.Sdk.Services.MobFoxAdIdService.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxAdIdService.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFinish (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFinish_Ljava_lang_String_;
			public unsafe void OnFinish (string p0)
			{
				if (id_onFinish_Ljava_lang_String_ == IntPtr.Zero)
					id_onFinish_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFinish", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinish_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mobfox/sdk/services/MobFoxAdIdService_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/services/MobFoxAdIdService_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void OnFinish (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/services/MobFoxAdIdService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxAdIdService); }
		}

		protected MobFoxAdIdService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mobfox_sdk_services_MobFoxAdIdService_Listener_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxAdIdService']/constructor[@name='MobFoxAdIdService' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.services.MobFoxAdIdService.Listener'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lcom/mobfox/sdk/services/MobFoxAdIdService$Listener;Landroid/content/Context;)V", "")]
		public unsafe MobFoxAdIdService (global::Com.Mobfox.Sdk.Services.MobFoxAdIdService.IListener p0, global::Android.Content.Context p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MobFoxAdIdService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mobfox/sdk/services/MobFoxAdIdService$Listener;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mobfox/sdk/services/MobFoxAdIdService$Listener;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mobfox_sdk_services_MobFoxAdIdService_Listener_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_mobfox_sdk_services_MobFoxAdIdService_Listener_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mobfox/sdk/services/MobFoxAdIdService$Listener;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mobfox_sdk_services_MobFoxAdIdService_Listener_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mobfox_sdk_services_MobFoxAdIdService_Listener_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAd_id;
#pragma warning disable 0169
		static Delegate GetGetAd_idHandler ()
		{
			if (cb_getAd_id == null)
				cb_getAd_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAd_id);
			return cb_getAd_id;
		}

		static IntPtr n_GetAd_id (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxAdIdService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxAdIdService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ad_id);
		}
#pragma warning restore 0169

		static Delegate cb_setAd_id_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAd_id_Ljava_lang_String_Handler ()
		{
			if (cb_setAd_id_Ljava_lang_String_ == null)
				cb_setAd_id_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAd_id_Ljava_lang_String_);
			return cb_setAd_id_Ljava_lang_String_;
		}

		static void n_SetAd_id_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxAdIdService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxAdIdService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Ad_id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAd_id;
		static IntPtr id_setAd_id_Ljava_lang_String_;
		public virtual unsafe string Ad_id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxAdIdService']/method[@name='getAd_id' and count(parameter)=0]"
			[Register ("getAd_id", "()Ljava/lang/String;", "GetGetAd_idHandler")]
			get {
				if (id_getAd_id == IntPtr.Zero)
					id_getAd_id = JNIEnv.GetMethodID (class_ref, "getAd_id", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAd_id), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAd_id", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxAdIdService']/method[@name='setAd_id' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAd_id", "(Ljava/lang/String;)V", "GetSetAd_id_Ljava_lang_String_Handler")]
			set {
				if (id_setAd_id_Ljava_lang_String_ == IntPtr.Zero)
					id_setAd_id_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAd_id", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAd_id_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAd_id", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_callback;
#pragma warning disable 0169
		static Delegate GetCallbackHandler ()
		{
			if (cb_callback == null)
				cb_callback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Callback);
			return cb_callback;
		}

		static void n_Callback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxAdIdService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxAdIdService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Callback ();
		}
#pragma warning restore 0169

		static IntPtr id_callback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxAdIdService']/method[@name='callback' and count(parameter)=0]"
		[Register ("callback", "()V", "GetCallbackHandler")]
		public override unsafe void Callback ()
		{
			if (id_callback == IntPtr.Zero)
				id_callback = JNIEnv.GetMethodID (class_ref, "callback", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callback);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "callback", "()V"));
			} finally {
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxAdIdService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxAdIdService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxAdIdService']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

	}
}
