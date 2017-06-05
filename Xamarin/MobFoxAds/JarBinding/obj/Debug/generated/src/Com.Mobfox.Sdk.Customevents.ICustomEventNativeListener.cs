using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Customevents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventNativeListener']"
	[Register ("com/mobfox/sdk/customevents/CustomEventNativeListener", "", "Com.Mobfox.Sdk.Customevents.ICustomEventNativeListenerInvoker")]
	public partial interface ICustomEventNativeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventNativeListener']/method[@name='onNativeClicked' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventNative']]"
		[Register ("onNativeClicked", "(Lcom/mobfox/sdk/customevents/CustomEventNative;)V", "GetOnNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventNativeListenerInvoker, JarBinding")]
		void OnNativeClicked (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventNativeListener']/method[@name='onNativeError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onNativeError", "(Ljava/lang/Exception;)V", "GetOnNativeError_Ljava_lang_Exception_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventNativeListenerInvoker, JarBinding")]
		void OnNativeError (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventNativeListener']/method[@name='onNativeReady' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventNative'] and parameter[2][@type='com.mobfox.sdk.nativeads.NativeAd']]"
		[Register ("onNativeReady", "(Lcom/mobfox/sdk/customevents/CustomEventNative;Lcom/mobfox/sdk/nativeads/NativeAd;)V", "GetOnNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventNativeListenerInvoker, JarBinding")]
		void OnNativeReady (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0, global::Com.Mobfox.Sdk.Nativeads.NativeAd p1);

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/customevents/CustomEventNativeListener", DoNotGenerateAcw=true)]
	internal class ICustomEventNativeListenerInvoker : global::Java.Lang.Object, ICustomEventNativeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/customevents/CustomEventNativeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICustomEventNativeListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICustomEventNativeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICustomEventNativeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.customevents.CustomEventNativeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICustomEventNativeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_;
#pragma warning disable 0169
		static Delegate GetOnNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_Handler ()
		{
			if (cb_onNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_ == null)
				cb_onNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_);
			return cb_onNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_;
		}

		static void n_OnNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNative> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_;
		public unsafe void OnNativeClicked (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0)
		{
			if (id_onNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_ == IntPtr.Zero)
				id_onNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_ = JNIEnv.GetMethodID (class_ref, "onNativeClicked", "(Lcom/mobfox/sdk/customevents/CustomEventNative;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeClicked_Lcom_mobfox_sdk_customevents_CustomEventNative_, __args);
		}

		static Delegate cb_onNativeError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnNativeError_Ljava_lang_Exception_Handler ()
		{
			if (cb_onNativeError_Ljava_lang_Exception_ == null)
				cb_onNativeError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeError_Ljava_lang_Exception_);
			return cb_onNativeError_Ljava_lang_Exception_;
		}

		static void n_OnNativeError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNativeError_Ljava_lang_Exception_;
		public unsafe void OnNativeError (global::Java.Lang.Exception p0)
		{
			if (id_onNativeError_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onNativeError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onNativeError", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeError_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_;
#pragma warning disable 0169
		static Delegate GetOnNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_Handler ()
		{
			if (cb_onNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_ == null)
				cb_onNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_);
			return cb_onNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_;
		}

		static void n_OnNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNativeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventNative> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Nativeads.NativeAd p1 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeReady (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_;
		public unsafe void OnNativeReady (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0, global::Com.Mobfox.Sdk.Nativeads.NativeAd p1)
		{
			if (id_onNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_ == IntPtr.Zero)
				id_onNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "onNativeReady", "(Lcom/mobfox/sdk/customevents/CustomEventNative;Lcom/mobfox/sdk/nativeads/NativeAd;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeReady_Lcom_mobfox_sdk_customevents_CustomEventNative_Lcom_mobfox_sdk_nativeads_NativeAd_, __args);
		}

	}

	public partial class NativeClickedEventArgs : global::System.EventArgs {

		public NativeClickedEventArgs (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0)
		{
			this.p0 = p0;
		}

		global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0;
		public global::Com.Mobfox.Sdk.Customevents.ICustomEventNative P0 {
			get { return p0; }
		}
	}

	public partial class NativeErrorEventArgs : global::System.EventArgs {

		public NativeErrorEventArgs (global::Java.Lang.Exception p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Exception p0;
		public global::Java.Lang.Exception P0 {
			get { return p0; }
		}
	}

	public partial class NativeReadyEventArgs : global::System.EventArgs {

		public NativeReadyEventArgs (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0, global::Com.Mobfox.Sdk.Nativeads.NativeAd p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0;
		public global::Com.Mobfox.Sdk.Customevents.ICustomEventNative P0 {
			get { return p0; }
		}

		global::Com.Mobfox.Sdk.Nativeads.NativeAd p1;
		public global::Com.Mobfox.Sdk.Nativeads.NativeAd P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mobfox/sdk/customevents/CustomEventNativeListenerImplementor")]
	internal sealed partial class ICustomEventNativeListenerImplementor : global::Java.Lang.Object, ICustomEventNativeListener {

		object sender;

		public ICustomEventNativeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/customevents/CustomEventNativeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<NativeClickedEventArgs> OnNativeClickedHandler;
#pragma warning restore 0649

		public void OnNativeClicked (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0)
		{
			var __h = OnNativeClickedHandler;
			if (__h != null)
				__h (sender, new NativeClickedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<NativeErrorEventArgs> OnNativeErrorHandler;
#pragma warning restore 0649

		public void OnNativeError (global::Java.Lang.Exception p0)
		{
			var __h = OnNativeErrorHandler;
			if (__h != null)
				__h (sender, new NativeErrorEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<NativeReadyEventArgs> OnNativeReadyHandler;
#pragma warning restore 0649

		public void OnNativeReady (global::Com.Mobfox.Sdk.Customevents.ICustomEventNative p0, global::Com.Mobfox.Sdk.Nativeads.NativeAd p1)
		{
			var __h = OnNativeReadyHandler;
			if (__h != null)
				__h (sender, new NativeReadyEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ICustomEventNativeListenerImplementor value)
		{
			return value.OnNativeClickedHandler == null && value.OnNativeErrorHandler == null && value.OnNativeReadyHandler == null;
		}
	}

}
