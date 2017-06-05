using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Runnables {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Timeout']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/runnables/Timeout", DoNotGenerateAcw=true)]
	public partial class Timeout : global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/runnables/Timeout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Timeout); }
		}

		protected Timeout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Timeout']/constructor[@name='Timeout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.concurrent.Callable']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/concurrent/Callable;)V", "")]
		public unsafe Timeout (global::Android.Content.Context p0, global::Java.Util.Concurrent.ICallable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Timeout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/util/concurrent/Callable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/concurrent/Callable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/concurrent/Callable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_concurrent_Callable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_concurrent_Callable_, __args);
			} finally {
			}
		}

		static Delegate cb_isTimeout;
#pragma warning disable 0169
		static Delegate GetIsTimeoutHandler ()
		{
			if (cb_isTimeout == null)
				cb_isTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTimeout);
			return cb_isTimeout;
		}

		static bool n_IsTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Runnables.Timeout __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTimeout;
		}
#pragma warning restore 0169

		static IntPtr id_isTimeout;
		public virtual unsafe bool IsTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Timeout']/method[@name='isTimeout' and count(parameter)=0]"
			[Register ("isTimeout", "()Z", "GetIsTimeoutHandler")]
			get {
				if (id_isTimeout == IntPtr.Zero)
					id_isTimeout = JNIEnv.GetMethodID (class_ref, "isTimeout", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTimeout);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTimeout", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Runnables.Timeout __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Timeout']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
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
			global::Com.Mobfox.Sdk.Runnables.Timeout __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MobFoxRun ();
		}
#pragma warning restore 0169

		static IntPtr id_mobFoxRun;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Timeout']/method[@name='mobFoxRun' and count(parameter)=0]"
		[Register ("mobFoxRun", "()V", "GetMobFoxRunHandler")]
		public override unsafe void MobFoxRun ()
		{
			if (id_mobFoxRun == IntPtr.Zero)
				id_mobFoxRun = JNIEnv.GetMethodID (class_ref, "mobFoxRun", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mobFoxRun);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mobFoxRun", "()V"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Runnables.Timeout __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.Timeout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Timeout']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
