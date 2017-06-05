using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VASTTasks']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/video/VASTTasks", DoNotGenerateAcw=true)]
	public partial class VASTTasks : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.video']/interface[@name='VASTTasks.DoneCallback']"
		[Register ("com/mobfox/sdk/video/VASTTasks$DoneCallback", "", "Com.Mobfox.Sdk.Video.VASTTasks/IDoneCallbackInvoker")]
		public partial interface IDoneCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.video']/interface[@name='VASTTasks.DoneCallback']/method[@name='onDone' and count(parameter)=0]"
			[Register ("onDone", "()V", "GetOnDoneHandler:Com.Mobfox.Sdk.Video.VASTTasks/IDoneCallbackInvoker, JarBinding")]
			void OnDone ();

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/video/VASTTasks$DoneCallback", DoNotGenerateAcw=true)]
		internal class IDoneCallbackInvoker : global::Java.Lang.Object, IDoneCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/video/VASTTasks$DoneCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDoneCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IDoneCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDoneCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.video.VASTTasks.DoneCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDoneCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDone;
#pragma warning disable 0169
			static Delegate GetOnDoneHandler ()
			{
				if (cb_onDone == null)
					cb_onDone = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDone);
				return cb_onDone;
			}

			static void n_OnDone (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mobfox.Sdk.Video.VASTTasks.IDoneCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VASTTasks.IDoneCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDone ();
			}
#pragma warning restore 0169

			IntPtr id_onDone;
			public unsafe void OnDone ()
			{
				if (id_onDone == IntPtr.Zero)
					id_onDone = JNIEnv.GetMethodID (class_ref, "onDone", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDone);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VASTTasks.Tasks']"
		[global::Android.Runtime.Register ("com/mobfox/sdk/video/VASTTasks$Tasks", DoNotGenerateAcw=true)]
		public sealed partial class Tasks : global::Java.Lang.Enum {


			static IntPtr GET_DRAWABLES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VASTTasks.Tasks']/field[@name='GET_DRAWABLES']"
			[Register ("GET_DRAWABLES")]
			public static global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks GetDrawables {
				get {
					if (GET_DRAWABLES_jfieldId == IntPtr.Zero)
						GET_DRAWABLES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_DRAWABLES", "Lcom/mobfox/sdk/video/VASTTasks$Tasks;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_DRAWABLES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mobfox/sdk/video/VASTTasks$Tasks", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Tasks); }
			}

			internal Tasks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VASTTasks.Tasks']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mobfox/sdk/video/VASTTasks$Tasks;", "")]
			public static unsafe global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mobfox/sdk/video/VASTTasks$Tasks;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks __ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VASTTasks.Tasks']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mobfox/sdk/video/VASTTasks$Tasks;", "")]
			public static unsafe global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mobfox/sdk/video/VASTTasks$Tasks;");
				try {
					return (global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/video/VASTTasks", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VASTTasks); }
		}

		protected VASTTasks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mobfox_sdk_video_VASTTasks_DoneCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VASTTasks']/constructor[@name='VASTTasks' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.video.VASTTasks.DoneCallback']]"
		[Register (".ctor", "(Lcom/mobfox/sdk/video/VASTTasks$DoneCallback;)V", "")]
		public unsafe VASTTasks (global::Com.Mobfox.Sdk.Video.VASTTasks.IDoneCallback p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VASTTasks)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mobfox/sdk/video/VASTTasks$DoneCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mobfox/sdk/video/VASTTasks$DoneCallback;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mobfox_sdk_video_VASTTasks_DoneCallback_ == IntPtr.Zero)
					id_ctor_Lcom_mobfox_sdk_video_VASTTasks_DoneCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mobfox/sdk/video/VASTTasks$DoneCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mobfox_sdk_video_VASTTasks_DoneCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mobfox_sdk_video_VASTTasks_DoneCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_notifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_;
#pragma warning disable 0169
		static Delegate GetNotifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_Handler ()
		{
			if (cb_notifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_ == null)
				cb_notifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_);
			return cb_notifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_;
		}

		static void n_NotifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Video.VASTTasks __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VASTTasks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyTaskDone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.video']/class[@name='VASTTasks']/method[@name='notifyTaskDone' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.video.VASTTasks.Tasks']]"
		[Register ("notifyTaskDone", "(Lcom/mobfox/sdk/video/VASTTasks$Tasks;)V", "GetNotifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_Handler")]
		public virtual unsafe void NotifyTaskDone (global::Com.Mobfox.Sdk.Video.VASTTasks.Tasks p0)
		{
			if (id_notifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_ == IntPtr.Zero)
				id_notifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_ = JNIEnv.GetMethodID (class_ref, "notifyTaskDone", "(Lcom/mobfox/sdk/video/VASTTasks$Tasks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyTaskDone_Lcom_mobfox_sdk_video_VASTTasks_Tasks_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyTaskDone", "(Lcom/mobfox/sdk/video/VASTTasks$Tasks;)V"), __args);
			} finally {
			}
		}

	}
}
