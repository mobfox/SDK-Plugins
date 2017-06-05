using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Runnables {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='MobFoxRunnable']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/runnables/MobFoxRunnable", DoNotGenerateAcw=true)]
	public abstract partial class MobFoxRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/runnables/MobFoxRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxRunnable); }
		}

		protected MobFoxRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='MobFoxRunnable']/constructor[@name='MobFoxRunnable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MobFoxRunnable (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MobFoxRunnable)) {
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

		static Delegate cb_condition;
#pragma warning disable 0169
		static Delegate GetConditionHandler ()
		{
			if (cb_condition == null)
				cb_condition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Condition);
			return cb_condition;
		}

		static bool n_Condition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Condition ();
		}
#pragma warning restore 0169

		static IntPtr id_condition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='MobFoxRunnable']/method[@name='condition' and count(parameter)=0]"
		[Register ("condition", "()Z", "GetConditionHandler")]
		protected virtual unsafe bool Condition ()
		{
			if (id_condition == IntPtr.Zero)
				id_condition = JNIEnv.GetMethodID (class_ref, "condition", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_condition);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "condition", "()Z"));
			} finally {
			}
		}

		static Delegate cb_mobFoxRun;
#pragma warning disable 0169
		static Delegate GetMobFoxRunHandler ()
		{
			if (cb_mobFoxRun == null)
				cb_mobFoxRun = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MobFoxRun);
			return cb_mobFoxRun;
		}

		static void n_MobFoxRun (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MobFoxRun ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='MobFoxRunnable']/method[@name='mobFoxRun' and count(parameter)=0]"
		[Register ("mobFoxRun", "()V", "GetMobFoxRunHandler")]
		public abstract void MobFoxRun ();

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
			global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='MobFoxRunnable']/method[@name='run' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/mobfox/sdk/runnables/MobFoxRunnable", DoNotGenerateAcw=true)]
	internal partial class MobFoxRunnableInvoker : MobFoxRunnable {

		public MobFoxRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxRunnableInvoker); }
		}

		static IntPtr id_mobFoxRun;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='MobFoxRunnable']/method[@name='mobFoxRun' and count(parameter)=0]"
		[Register ("mobFoxRun", "()V", "GetMobFoxRunHandler")]
		public override unsafe void MobFoxRun ()
		{
			if (id_mobFoxRun == IntPtr.Zero)
				id_mobFoxRun = JNIEnv.GetMethodID (class_ref, "mobFoxRun", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mobFoxRun);
			} finally {
			}
		}

	}

}
