using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VideoBridge']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/video/VideoBridge", DoNotGenerateAcw=true)]
	public partial class VideoBridge : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/video/VideoBridge", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoBridge); }
		}

		protected VideoBridge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VideoBridge']/constructor[@name='VideoBridge' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoBridge ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VideoBridge)) {
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

		static Delegate cb_playCreative_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPlayCreative_Ljava_lang_String_Handler ()
		{
			if (cb_playCreative_Ljava_lang_String_ == null)
				cb_playCreative_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PlayCreative_Ljava_lang_String_);
			return cb_playCreative_Ljava_lang_String_;
		}

		static void n_PlayCreative_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Video.VideoBridge __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VideoBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlayCreative (p0);
		}
#pragma warning restore 0169

		static IntPtr id_playCreative_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VideoBridge']/method[@name='playCreative' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("playCreative", "(Ljava/lang/String;)V", "GetPlayCreative_Ljava_lang_String_Handler")]
		public virtual unsafe void PlayCreative (string p0)
		{
			if (id_playCreative_Ljava_lang_String_ == IntPtr.Zero)
				id_playCreative_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "playCreative", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playCreative_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playCreative", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_videoProgressRequest;
#pragma warning disable 0169
		static Delegate GetVideoProgressRequestHandler ()
		{
			if (cb_videoProgressRequest == null)
				cb_videoProgressRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VideoProgressRequest);
			return cb_videoProgressRequest;
		}

		static void n_VideoProgressRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Video.VideoBridge __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VideoBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoProgressRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_videoProgressRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VideoBridge']/method[@name='videoProgressRequest' and count(parameter)=0]"
		[Register ("videoProgressRequest", "()V", "GetVideoProgressRequestHandler")]
		public virtual unsafe void VideoProgressRequest ()
		{
			if (id_videoProgressRequest == IntPtr.Zero)
				id_videoProgressRequest = JNIEnv.GetMethodID (class_ref, "videoProgressRequest", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_videoProgressRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "videoProgressRequest", "()V"));
			} finally {
			}
		}

	}
}
