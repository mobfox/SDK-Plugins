using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Dmp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMPManager']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/dmp/DMPManager", DoNotGenerateAcw=true)]
	public partial class DMPManager : global::Java.Lang.Object {


		static IntPtr dmpURL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMPManager']/field[@name='dmpURL']"
		[Register ("dmpURL")]
		public static string DmpURL {
			get {
				if (dmpURL_jfieldId == IntPtr.Zero)
					dmpURL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dmpURL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, dmpURL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dmpURL_jfieldId == IntPtr.Zero)
					dmpURL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dmpURL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, dmpURL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.dmp']/interface[@name='DMPManager.DMPCallback']"
		[Register ("com/mobfox/sdk/dmp/DMPManager$DMPCallback", "", "Com.Mobfox.Sdk.Dmp.DMPManager/IDMPCallbackInvoker")]
		public partial interface IDMPCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/interface[@name='DMPManager.DMPCallback']/method[@name='onPostCompleted' and count(parameter)=0]"
			[Register ("onPostCompleted", "()V", "GetOnPostCompletedHandler:Com.Mobfox.Sdk.Dmp.DMPManager/IDMPCallbackInvoker, JarBinding")]
			void OnPostCompleted ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/interface[@name='DMPManager.DMPCallback']/method[@name='onPostError' and count(parameter)=0]"
			[Register ("onPostError", "()V", "GetOnPostErrorHandler:Com.Mobfox.Sdk.Dmp.DMPManager/IDMPCallbackInvoker, JarBinding")]
			void OnPostError ();

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/dmp/DMPManager$DMPCallback", DoNotGenerateAcw=true)]
		internal class IDMPCallbackInvoker : global::Java.Lang.Object, IDMPCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/dmp/DMPManager$DMPCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDMPCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IDMPCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDMPCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.dmp.DMPManager.DMPCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDMPCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPostCompleted;
#pragma warning disable 0169
			static Delegate GetOnPostCompletedHandler ()
			{
				if (cb_onPostCompleted == null)
					cb_onPostCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPostCompleted);
				return cb_onPostCompleted;
			}

			static void n_OnPostCompleted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mobfox.Sdk.Dmp.DMPManager.IDMPCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.DMPManager.IDMPCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPostCompleted ();
			}
#pragma warning restore 0169

			IntPtr id_onPostCompleted;
			public unsafe void OnPostCompleted ()
			{
				if (id_onPostCompleted == IntPtr.Zero)
					id_onPostCompleted = JNIEnv.GetMethodID (class_ref, "onPostCompleted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostCompleted);
			}

			static Delegate cb_onPostError;
#pragma warning disable 0169
			static Delegate GetOnPostErrorHandler ()
			{
				if (cb_onPostError == null)
					cb_onPostError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPostError);
				return cb_onPostError;
			}

			static void n_OnPostError (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mobfox.Sdk.Dmp.DMPManager.IDMPCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Dmp.DMPManager.IDMPCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPostError ();
			}
#pragma warning restore 0169

			IntPtr id_onPostError;
			public unsafe void OnPostError ()
			{
				if (id_onPostError == IntPtr.Zero)
					id_onPostError = JNIEnv.GetMethodID (class_ref, "onPostError", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostError);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/dmp/DMPManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DMPManager); }
		}

		protected DMPManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMPManager']/constructor[@name='DMPManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DMPManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DMPManager)) {
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

		static IntPtr id_postDMP_Landroid_content_Context_Lcom_mobfox_sdk_dmp_DMPManager_DMPCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMPManager']/method[@name='postDMP' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.dmp.DMPManager.DMPCallback']]"
		[Register ("postDMP", "(Landroid/content/Context;Lcom/mobfox/sdk/dmp/DMPManager$DMPCallback;)V", "")]
		public static unsafe void PostDMP (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Dmp.DMPManager.IDMPCallback p1)
		{
			if (id_postDMP_Landroid_content_Context_Lcom_mobfox_sdk_dmp_DMPManager_DMPCallback_ == IntPtr.Zero)
				id_postDMP_Landroid_content_Context_Lcom_mobfox_sdk_dmp_DMPManager_DMPCallback_ = JNIEnv.GetStaticMethodID (class_ref, "postDMP", "(Landroid/content/Context;Lcom/mobfox/sdk/dmp/DMPManager$DMPCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_postDMP_Landroid_content_Context_Lcom_mobfox_sdk_dmp_DMPManager_DMPCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_updateDMP_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.dmp']/class[@name='DMPManager']/method[@name='updateDMP' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("updateDMP", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void UpdateDMP (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_updateDMP_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDMP_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "updateDMP", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateDMP_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
