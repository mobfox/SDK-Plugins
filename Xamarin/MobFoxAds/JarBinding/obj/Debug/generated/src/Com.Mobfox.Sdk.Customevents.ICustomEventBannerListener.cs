using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Customevents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventBannerListener']"
	[Register ("com/mobfox/sdk/customevents/CustomEventBannerListener", "", "Com.Mobfox.Sdk.Customevents.ICustomEventBannerListenerInvoker")]
	public partial interface ICustomEventBannerListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventBannerListener']/method[@name='onBannerClicked' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onBannerClicked", "(Landroid/view/View;)V", "GetOnBannerClicked_Landroid_view_View_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventBannerListenerInvoker, JarBinding")]
		void OnBannerClicked (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventBannerListener']/method[@name='onBannerClosed' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onBannerClosed", "(Landroid/view/View;)V", "GetOnBannerClosed_Landroid_view_View_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventBannerListenerInvoker, JarBinding")]
		void OnBannerClosed (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventBannerListener']/method[@name='onBannerError' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onBannerError", "(Landroid/view/View;Ljava/lang/Exception;)V", "GetOnBannerError_Landroid_view_View_Ljava_lang_Exception_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventBannerListenerInvoker, JarBinding")]
		void OnBannerError (global::Android.Views.View p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventBannerListener']/method[@name='onBannerFinished' and count(parameter)=0]"
		[Register ("onBannerFinished", "()V", "GetOnBannerFinishedHandler:Com.Mobfox.Sdk.Customevents.ICustomEventBannerListenerInvoker, JarBinding")]
		void OnBannerFinished ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.customevents']/interface[@name='CustomEventBannerListener']/method[@name='onBannerLoaded' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onBannerLoaded", "(Landroid/view/View;)V", "GetOnBannerLoaded_Landroid_view_View_Handler:Com.Mobfox.Sdk.Customevents.ICustomEventBannerListenerInvoker, JarBinding")]
		void OnBannerLoaded (global::Android.Views.View p0);

	}

	[global::Android.Runtime.Register ("com/mobfox/sdk/customevents/CustomEventBannerListener", DoNotGenerateAcw=true)]
	internal class ICustomEventBannerListenerInvoker : global::Java.Lang.Object, ICustomEventBannerListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/customevents/CustomEventBannerListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICustomEventBannerListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICustomEventBannerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICustomEventBannerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.customevents.CustomEventBannerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICustomEventBannerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBannerClicked_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnBannerClicked_Landroid_view_View_Handler ()
		{
			if (cb_onBannerClicked_Landroid_view_View_ == null)
				cb_onBannerClicked_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerClicked_Landroid_view_View_);
			return cb_onBannerClicked_Landroid_view_View_;
		}

		static void n_OnBannerClicked_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerClicked_Landroid_view_View_;
		public unsafe void OnBannerClicked (global::Android.Views.View p0)
		{
			if (id_onBannerClicked_Landroid_view_View_ == IntPtr.Zero)
				id_onBannerClicked_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerClicked_Landroid_view_View_, __args);
		}

		static Delegate cb_onBannerClosed_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnBannerClosed_Landroid_view_View_Handler ()
		{
			if (cb_onBannerClosed_Landroid_view_View_ == null)
				cb_onBannerClosed_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerClosed_Landroid_view_View_);
			return cb_onBannerClosed_Landroid_view_View_;
		}

		static void n_OnBannerClosed_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerClosed_Landroid_view_View_;
		public unsafe void OnBannerClosed (global::Android.Views.View p0)
		{
			if (id_onBannerClosed_Landroid_view_View_ == IntPtr.Zero)
				id_onBannerClosed_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onBannerClosed", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerClosed_Landroid_view_View_, __args);
		}

		static Delegate cb_onBannerError_Landroid_view_View_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnBannerError_Landroid_view_View_Ljava_lang_Exception_Handler ()
		{
			if (cb_onBannerError_Landroid_view_View_Ljava_lang_Exception_ == null)
				cb_onBannerError_Landroid_view_View_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBannerError_Landroid_view_View_Ljava_lang_Exception_);
			return cb_onBannerError_Landroid_view_View_Ljava_lang_Exception_;
		}

		static void n_OnBannerError_Landroid_view_View_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBannerError_Landroid_view_View_Ljava_lang_Exception_;
		public unsafe void OnBannerError (global::Android.Views.View p0, global::Java.Lang.Exception p1)
		{
			if (id_onBannerError_Landroid_view_View_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onBannerError_Landroid_view_View_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onBannerError", "(Landroid/view/View;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerError_Landroid_view_View_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onBannerFinished;
#pragma warning disable 0169
		static Delegate GetOnBannerFinishedHandler ()
		{
			if (cb_onBannerFinished == null)
				cb_onBannerFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerFinished);
			return cb_onBannerFinished;
		}

		static void n_OnBannerFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerFinished ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerFinished;
		public unsafe void OnBannerFinished ()
		{
			if (id_onBannerFinished == IntPtr.Zero)
				id_onBannerFinished = JNIEnv.GetMethodID (class_ref, "onBannerFinished", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerFinished);
		}

		static Delegate cb_onBannerLoaded_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnBannerLoaded_Landroid_view_View_Handler ()
		{
			if (cb_onBannerLoaded_Landroid_view_View_ == null)
				cb_onBannerLoaded_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerLoaded_Landroid_view_View_);
			return cb_onBannerLoaded_Landroid_view_View_;
		}

		static void n_OnBannerLoaded_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Customevents.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBannerLoaded_Landroid_view_View_;
		public unsafe void OnBannerLoaded (global::Android.Views.View p0)
		{
			if (id_onBannerLoaded_Landroid_view_View_ == IntPtr.Zero)
				id_onBannerLoaded_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerLoaded_Landroid_view_View_, __args);
		}

	}

	public partial class BannerClickedEventArgs : global::System.EventArgs {

		public BannerClickedEventArgs (global::Android.Views.View p0)
		{
			this.p0 = p0;
		}

		global::Android.Views.View p0;
		public global::Android.Views.View P0 {
			get { return p0; }
		}
	}

	public partial class BannerClosedEventArgs : global::System.EventArgs {

		public BannerClosedEventArgs (global::Android.Views.View p0)
		{
			this.p0 = p0;
		}

		global::Android.Views.View p0;
		public global::Android.Views.View P0 {
			get { return p0; }
		}
	}

	public partial class BannerErrorEventArgs : global::System.EventArgs {

		public BannerErrorEventArgs (global::Android.Views.View p0, global::Java.Lang.Exception p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Views.View p0;
		public global::Android.Views.View P0 {
			get { return p0; }
		}

		global::Java.Lang.Exception p1;
		public global::Java.Lang.Exception P1 {
			get { return p1; }
		}
	}

	public partial class BannerLoadedEventArgs : global::System.EventArgs {

		public BannerLoadedEventArgs (global::Android.Views.View p0)
		{
			this.p0 = p0;
		}

		global::Android.Views.View p0;
		public global::Android.Views.View P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mobfox/sdk/customevents/CustomEventBannerListenerImplementor")]
	internal sealed partial class ICustomEventBannerListenerImplementor : global::Java.Lang.Object, ICustomEventBannerListener {

		object sender;

		public ICustomEventBannerListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/customevents/CustomEventBannerListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BannerClickedEventArgs> OnBannerClickedHandler;
#pragma warning restore 0649

		public void OnBannerClicked (global::Android.Views.View p0)
		{
			var __h = OnBannerClickedHandler;
			if (__h != null)
				__h (sender, new BannerClickedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<BannerClosedEventArgs> OnBannerClosedHandler;
#pragma warning restore 0649

		public void OnBannerClosed (global::Android.Views.View p0)
		{
			var __h = OnBannerClosedHandler;
			if (__h != null)
				__h (sender, new BannerClosedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<BannerErrorEventArgs> OnBannerErrorHandler;
#pragma warning restore 0649

		public void OnBannerError (global::Android.Views.View p0, global::Java.Lang.Exception p1)
		{
			var __h = OnBannerErrorHandler;
			if (__h != null)
				__h (sender, new BannerErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler OnBannerFinishedHandler;
#pragma warning restore 0649

		public void OnBannerFinished ()
		{
			var __h = OnBannerFinishedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<BannerLoadedEventArgs> OnBannerLoadedHandler;
#pragma warning restore 0649

		public void OnBannerLoaded (global::Android.Views.View p0)
		{
			var __h = OnBannerLoadedHandler;
			if (__h != null)
				__h (sender, new BannerLoadedEventArgs (p0));
		}

		internal static bool __IsEmpty (ICustomEventBannerListenerImplementor value)
		{
			return value.OnBannerClickedHandler == null && value.OnBannerClosedHandler == null && value.OnBannerErrorHandler == null && value.OnBannerFinishedHandler == null && value.OnBannerLoadedHandler == null;
		}
	}

}
