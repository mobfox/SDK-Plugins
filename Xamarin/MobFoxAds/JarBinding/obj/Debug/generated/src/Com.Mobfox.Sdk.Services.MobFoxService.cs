using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Services {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxService']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/services/MobFoxService", DoNotGenerateAcw=true)]
	public abstract partial class MobFoxService : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/services/MobFoxService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxService); }
		}

		protected MobFoxService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxService']/constructor[@name='MobFoxService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MobFoxService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MobFoxService)) {
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
			global::Com.Mobfox.Sdk.Services.MobFoxService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Callback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxService']/method[@name='callback' and count(parameter)=0]"
		[Register ("callback", "()V", "GetCallbackHandler")]
		public abstract void Callback ();

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxService']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/services/MobFoxService", DoNotGenerateAcw=true)]
	internal partial class MobFoxServiceInvoker : MobFoxService {

		public MobFoxServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxServiceInvoker); }
		}

		static IntPtr id_callback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxService']/method[@name='callback' and count(parameter)=0]"
		[Register ("callback", "()V", "GetCallbackHandler")]
		public override unsafe void Callback ()
		{
			if (id_callback == IntPtr.Zero)
				id_callback = JNIEnv.GetMethodID (class_ref, "callback", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callback);
			} finally {
			}
		}

	}

}
