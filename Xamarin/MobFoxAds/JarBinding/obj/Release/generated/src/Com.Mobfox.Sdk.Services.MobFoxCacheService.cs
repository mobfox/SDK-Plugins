using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Services {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxCacheService']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/services/MobFoxCacheService", DoNotGenerateAcw=true)]
	public partial class MobFoxCacheService : global::Com.Mobfox.Sdk.Services.MobFoxService {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxCacheService']/field[@name='EVENT_READY_INTERVAL']"
		[Register ("EVENT_READY_INTERVAL")]
		public const long EventReadyInterval = (long) 200L;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.services']/interface[@name='MobFoxCacheService.Listener']"
		[Register ("com/mobfox/sdk/services/MobFoxCacheService$Listener", "", "Com.Mobfox.Sdk.Services.MobFoxCacheService/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/interface[@name='MobFoxCacheService.Listener']/method[@name='onDownloaded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onDownloaded", "(Ljava/lang/String;)V", "GetOnDownloaded_Ljava_lang_String_Handler:Com.Mobfox.Sdk.Services.MobFoxCacheService/IListenerInvoker, JarBinding")]
			void OnDownloaded (string p0);

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/services/MobFoxCacheService$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/services/MobFoxCacheService$Listener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.services.MobFoxCacheService.Listener"));
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

			static Delegate cb_onDownloaded_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnDownloaded_Ljava_lang_String_Handler ()
			{
				if (cb_onDownloaded_Ljava_lang_String_ == null)
					cb_onDownloaded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDownloaded_Ljava_lang_String_);
				return cb_onDownloaded_Ljava_lang_String_;
			}

			static void n_OnDownloaded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mobfox.Sdk.Services.MobFoxCacheService.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxCacheService.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDownloaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDownloaded_Ljava_lang_String_;
			public unsafe void OnDownloaded (string p0)
			{
				if (id_onDownloaded_Ljava_lang_String_ == IntPtr.Zero)
					id_onDownloaded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDownloaded", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDownloaded_Ljava_lang_String_, __args);
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

		[global::Android.Runtime.Register ("mono/com/mobfox/sdk/services/MobFoxCacheService_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/services/MobFoxCacheService_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void OnDownloaded (string p0)
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
				return JNIEnv.FindClass ("com/mobfox/sdk/services/MobFoxCacheService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxCacheService); }
		}

		protected MobFoxCacheService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxCacheService']/constructor[@name='MobFoxCacheService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MobFoxCacheService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MobFoxCacheService)) {
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
			global::Com.Mobfox.Sdk.Services.MobFoxCacheService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxCacheService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Callback ();
		}
#pragma warning restore 0169

		static IntPtr id_callback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxCacheService']/method[@name='callback' and count(parameter)=0]"
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

		static IntPtr id_getLocalPath_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxCacheService']/method[@name='getLocalPath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLocalPath", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetLocalPath (global::Android.Content.Context p0, string p1)
		{
			if (id_getLocalPath_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getLocalPath_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLocalPath", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocalPath_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_handleCacheables_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_services_MobFoxCacheService_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxCacheService']/method[@name='handleCacheables' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.mobfox.sdk.services.MobFoxCacheService.Listener']]"
		[Register ("handleCacheables", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/mobfox/sdk/services/MobFoxCacheService$Listener;)V", "")]
		public static unsafe void HandleCacheables (global::Android.Content.Context p0, global::Org.Json.JSONObject p1, global::Com.Mobfox.Sdk.Services.MobFoxCacheService.IListener p2)
		{
			if (id_handleCacheables_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_services_MobFoxCacheService_Listener_ == IntPtr.Zero)
				id_handleCacheables_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_services_MobFoxCacheService_Listener_ = JNIEnv.GetStaticMethodID (class_ref, "handleCacheables", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/mobfox/sdk/services/MobFoxCacheService$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handleCacheables_Landroid_content_Context_Lorg_json_JSONObject_Lcom_mobfox_sdk_services_MobFoxCacheService_Listener_, __args);
			} finally {
			}
		}

		static IntPtr id_md5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxCacheService']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Md5 (string p0)
		{
			if (id_md5_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_videoExists_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxCacheService']/method[@name='videoExists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("videoExists", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool VideoExists (string p0)
		{
			if (id_videoExists_Ljava_lang_String_ == IntPtr.Zero)
				id_videoExists_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "videoExists", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_videoExists_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
