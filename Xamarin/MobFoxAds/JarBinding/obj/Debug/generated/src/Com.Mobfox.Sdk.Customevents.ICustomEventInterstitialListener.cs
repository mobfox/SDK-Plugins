using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Customevents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitialListener']"
	[Register ("com/mobfox/sdk/customevents/CustomEventInterstitialListener", "", "Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListenerInvoker")]
	public partial interface ICustomEventInterstitialListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitialListener']/method[@name='onInterstitialClicked' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventInterstitial']]"
		[Register ("onInterstitialClicked", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;)V", "GetOnInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListenerInvoker, JarBinding")]
		void OnInterstitialClicked (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitialListener']/method[@name='onInterstitialClosed' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventInterstitial']]"
		[Register ("onInterstitialClosed", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;)V", "GetOnInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListenerInvoker, JarBinding")]
		void OnInterstitialClosed (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitialListener']/method[@name='onInterstitialFailed' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventInterstitial'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onInterstitialFailed", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;Ljava/lang/Exception;)V", "GetOnInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListenerInvoker, JarBinding")]
		void OnInterstitialFailed (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitialListener']/method[@name='onInterstitialFinished' and count(parameter)=0]"
		[Register ("onInterstitialFinished", "()V", "GetOnInterstitialFinishedHandler:Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListenerInvoker, JarBinding")]
		void OnInterstitialFinished ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitialListener']/method[@name='onInterstitialLoaded' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventInterstitial']]"
		[Register ("onInterstitialLoaded", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;)V", "GetOnInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListenerInvoker, JarBinding")]
		void OnInterstitialLoaded (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventInterstitialListener']/method[@name='onInterstitialShown' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.customevents.CustomEventInterstitial']]"
		[Register ("onInterstitialShown", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;)V", "GetOnInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListenerInvoker, JarBinding")]
		void OnInterstitialShown (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0);

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/customevents/CustomEventInterstitialListener", DoNotGenerateAcw=true)]
	internal class ICustomEventInterstitialListenerInvoker : global::Java.Lang.Object, ICustomEventInterstitialListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/customevents/CustomEventInterstitialListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICustomEventInterstitialListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICustomEventInterstitialListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICustomEventInterstitialListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.customevents.CustomEventInterstitialListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICustomEventInterstitialListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Handler ()
		{
			if (cb_onInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ == null)
				cb_onInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_);
			return cb_onInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
		}

		static void n_OnInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
		public unsafe void OnInterstitialClicked (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			if (id_onInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ == IntPtr.Zero)
				id_onInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialClicked_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_, __args);
		}

		static Delegate cb_onInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Handler ()
		{
			if (cb_onInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ == null)
				cb_onInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_);
			return cb_onInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
		}

		static void n_OnInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
		public unsafe void OnInterstitialClosed (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			if (id_onInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ == IntPtr.Zero)
				id_onInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialClosed", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialClosed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_, __args);
		}

		static Delegate cb_onInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_Handler ()
		{
			if (cb_onInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_ == null)
				cb_onInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_);
			return cb_onInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_;
		}

		static void n_OnInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_;
		public unsafe void OnInterstitialFailed (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0, global::Java.Lang.Exception p1)
		{
			if (id_onInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFailed", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialFailed_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onInterstitialFinished;
#pragma warning disable 0169
		static Delegate GetOnInterstitialFinishedHandler ()
		{
			if (cb_onInterstitialFinished == null)
				cb_onInterstitialFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialFinished);
			return cb_onInterstitialFinished;
		}

		static void n_OnInterstitialFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFinished ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialFinished;
		public unsafe void OnInterstitialFinished ()
		{
			if (id_onInterstitialFinished == IntPtr.Zero)
				id_onInterstitialFinished = JNIEnv.GetMethodID (class_ref, "onInterstitialFinished", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialFinished);
		}

		static Delegate cb_onInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Handler ()
		{
			if (cb_onInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ == null)
				cb_onInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_);
			return cb_onInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
		}

		static void n_OnInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
		public unsafe void OnInterstitialLoaded (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			if (id_onInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ == IntPtr.Zero)
				id_onInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialLoaded_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_, __args);
		}

		static Delegate cb_onInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_Handler ()
		{
			if (cb_onInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ == null)
				cb_onInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_);
			return cb_onInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
		}

		static void n_OnInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0 = (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialShown (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_;
		public unsafe void OnInterstitialShown (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			if (id_onInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ == IntPtr.Zero)
				id_onInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "(Lcom/mobfox/sdk/customevents/CustomEventInterstitial;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialShown_Lcom_mobfox_sdk_customevents_CustomEventInterstitial_, __args);
		}

	}

	public partial class InterstitialClickedEventArgs : global::System.EventArgs {

		public InterstitialClickedEventArgs (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			this.p0 = p0;
		}

		global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0;
		public global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial P0 {
			get { return p0; }
		}
	}

	public partial class InterstitialClosedEventArgs : global::System.EventArgs {

		public InterstitialClosedEventArgs (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			this.p0 = p0;
		}

		global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0;
		public global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial P0 {
			get { return p0; }
		}
	}

	public partial class InterstitialFailedEventArgs : global::System.EventArgs {

		public InterstitialFailedEventArgs (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0, global::Java.Lang.Exception p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0;
		public global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial P0 {
			get { return p0; }
		}

		global::Java.Lang.Exception p1;
		public global::Java.Lang.Exception P1 {
			get { return p1; }
		}
	}

	public partial class InterstitialLoadedEventArgs : global::System.EventArgs {

		public InterstitialLoadedEventArgs (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			this.p0 = p0;
		}

		global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0;
		public global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial P0 {
			get { return p0; }
		}
	}

	public partial class InterstitialShownEventArgs : global::System.EventArgs {

		public InterstitialShownEventArgs (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			this.p0 = p0;
		}

		global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0;
		public global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mobfox/sdk/customevents/CustomEventInterstitialListenerImplementor")]
	internal sealed partial class ICustomEventInterstitialListenerImplementor : global::Java.Lang.Object, ICustomEventInterstitialListener {

		object sender;

		public ICustomEventInterstitialListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/customevents/CustomEventInterstitialListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<InterstitialClickedEventArgs> OnInterstitialClickedHandler;
#pragma warning restore 0649

		public void OnInterstitialClicked (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			var __h = OnInterstitialClickedHandler;
			if (__h != null)
				__h (sender, new InterstitialClickedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<InterstitialClosedEventArgs> OnInterstitialClosedHandler;
#pragma warning restore 0649

		public void OnInterstitialClosed (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			var __h = OnInterstitialClosedHandler;
			if (__h != null)
				__h (sender, new InterstitialClosedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<InterstitialFailedEventArgs> OnInterstitialFailedHandler;
#pragma warning restore 0649

		public void OnInterstitialFailed (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0, global::Java.Lang.Exception p1)
		{
			var __h = OnInterstitialFailedHandler;
			if (__h != null)
				__h (sender, new InterstitialFailedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler OnInterstitialFinishedHandler;
#pragma warning restore 0649

		public void OnInterstitialFinished ()
		{
			var __h = OnInterstitialFinishedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<InterstitialLoadedEventArgs> OnInterstitialLoadedHandler;
#pragma warning restore 0649

		public void OnInterstitialLoaded (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			var __h = OnInterstitialLoadedHandler;
			if (__h != null)
				__h (sender, new InterstitialLoadedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<InterstitialShownEventArgs> OnInterstitialShownHandler;
#pragma warning restore 0649

		public void OnInterstitialShown (global::Com.Mobfox.Sdk.Customevents.ICustomEventInterstitial p0)
		{
			var __h = OnInterstitialShownHandler;
			if (__h != null)
				__h (sender, new InterstitialShownEventArgs (p0));
		}

		internal static bool __IsEmpty (ICustomEventInterstitialListenerImplementor value)
		{
			return value.OnInterstitialClickedHandler == null && value.OnInterstitialClosedHandler == null && value.OnInterstitialFailedHandler == null && value.OnInterstitialFinishedHandler == null && value.OnInterstitialLoadedHandler == null && value.OnInterstitialShownHandler == null;
		}
	}

}
