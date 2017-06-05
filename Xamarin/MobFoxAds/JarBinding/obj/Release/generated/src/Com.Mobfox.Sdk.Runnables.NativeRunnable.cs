using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Runnables {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='NativeRunnable']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/runnables/NativeRunnable", DoNotGenerateAcw=true)]
	public abstract partial class NativeRunnable : global::Com.Mobfox.Sdk.Runnables.MobFoxRunnable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/runnables/NativeRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeRunnable); }
		}

		protected NativeRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_Native_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.runnables']/class[@name='NativeRunnable']/constructor[@name='NativeRunnable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.nativeads.Native']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/Native;)V", "")]
		public unsafe NativeRunnable (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Nativeads.Native p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (NativeRunnable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/Native;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/Native;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_Native_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_Native_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/Native;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_Native_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_Native_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/runnables/NativeRunnable", DoNotGenerateAcw=true)]
	internal partial class NativeRunnableInvoker : NativeRunnable {

		public NativeRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeRunnableInvoker); }
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
