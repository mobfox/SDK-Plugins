using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Runnables {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Repeater']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/runnables/Repeater", DoNotGenerateAcw=true)]
	public partial class Repeater : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/runnables/Repeater", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Repeater); }
		}

		protected Repeater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_os_Handler_JLjava_util_concurrent_Callable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Repeater']/constructor[@name='Repeater' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='long'] and parameter[4][@type='java.util.concurrent.Callable']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Handler;JLjava/util/concurrent/Callable;)V", "")]
		public unsafe Repeater (global::Android.Content.Context p0, global::Android.OS.Handler p1, long p2, global::Java.Util.Concurrent.ICallable p3)
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
				if (((object) this).GetType () != typeof (Repeater)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/os/Handler;JLjava/util/concurrent/Callable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/os/Handler;JLjava/util/concurrent/Callable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_os_Handler_JLjava_util_concurrent_Callable_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_os_Handler_JLjava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/os/Handler;JLjava/util/concurrent/Callable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_JLjava_util_concurrent_Callable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_JLjava_util_concurrent_Callable_, __args);
			} finally {
			}
		}

		static Delegate cb_setAction_Ljava_util_concurrent_Callable_;
#pragma warning disable 0169
		static Delegate GetSetAction_Ljava_util_concurrent_Callable_Handler ()
		{
			if (cb_setAction_Ljava_util_concurrent_Callable_ == null)
				cb_setAction_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAction_Ljava_util_concurrent_Callable_);
			return cb_setAction_Ljava_util_concurrent_Callable_;
		}

		static void n_SetAction_Ljava_util_concurrent_Callable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Runnables.Repeater __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.Repeater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.ICallable p0 = (global::Java.Util.Concurrent.ICallable)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAction_Ljava_util_concurrent_Callable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Repeater']/method[@name='setAction' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable']]"
		[Register ("setAction", "(Ljava/util/concurrent/Callable;)V", "GetSetAction_Ljava_util_concurrent_Callable_Handler")]
		public virtual unsafe void SetAction (global::Java.Util.Concurrent.ICallable p0)
		{
			if (id_setAction_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_setAction_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID (class_ref, "setAction", "(Ljava/util/concurrent/Callable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAction_Ljava_util_concurrent_Callable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAction", "(Ljava/util/concurrent/Callable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Runnables.Repeater __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.Repeater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Repeater']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Runnables.Repeater __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Runnables.Repeater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='Repeater']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
