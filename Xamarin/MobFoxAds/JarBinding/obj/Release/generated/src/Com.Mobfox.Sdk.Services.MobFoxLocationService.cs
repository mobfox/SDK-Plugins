using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Services {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/services/MobFoxLocationService", DoNotGenerateAcw=true)]
	public partial class MobFoxLocationService : global::Com.Mobfox.Sdk.Services.MobFoxService, global::Android.Locations.ILocationListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/field[@name='DEFAULT_ERROR']"
		[Register ("DEFAULT_ERROR")]
		public const string DefaultError = (string) "location not available";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.services']/interface[@name='MobFoxLocationService.Listener']"
		[Register ("com/mobfox/sdk/services/MobFoxLocationService$Listener", "", "Com.Mobfox.Sdk.Services.MobFoxLocationService/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/interface[@name='MobFoxLocationService.Listener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Mobfox.Sdk.Services.MobFoxLocationService/IListenerInvoker, JarBinding")]
			void OnError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/interface[@name='MobFoxLocationService.Listener']/method[@name='onLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("onLocation", "(Landroid/location/Location;)V", "GetOnLocation_Landroid_location_Location_Handler:Com.Mobfox.Sdk.Services.MobFoxLocationService/IListenerInvoker, JarBinding")]
			void OnLocation (global::Android.Locations.Location p0);

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/services/MobFoxLocationService$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/services/MobFoxLocationService$Listener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.services.MobFoxLocationService.Listener"));
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

			static Delegate cb_onError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_String_Handler ()
			{
				if (cb_onError_Ljava_lang_String_ == null)
					cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_String_);
				return cb_onError_Ljava_lang_String_;
			}

			static void n_OnError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mobfox.Sdk.Services.MobFoxLocationService.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_String_;
			public unsafe void OnError (string p0)
			{
				if (id_onError_Ljava_lang_String_ == IntPtr.Zero)
					id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onLocation_Landroid_location_Location_;
#pragma warning disable 0169
			static Delegate GetOnLocation_Landroid_location_Location_Handler ()
			{
				if (cb_onLocation_Landroid_location_Location_ == null)
					cb_onLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocation_Landroid_location_Location_);
				return cb_onLocation_Landroid_location_Location_;
			}

			static void n_OnLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mobfox.Sdk.Services.MobFoxLocationService.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLocation (p0);
			}
#pragma warning restore 0169

			IntPtr id_onLocation_Landroid_location_Location_;
			public unsafe void OnLocation (global::Android.Locations.Location p0)
			{
				if (id_onLocation_Landroid_location_Location_ == IntPtr.Zero)
					id_onLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocation", "(Landroid/location/Location;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocation_Landroid_location_Location_, __args);
			}

		}

		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		public partial class LocationEventArgs : global::System.EventArgs {

			public LocationEventArgs (global::Android.Locations.Location p0)
			{
				this.p0 = p0;
			}

			global::Android.Locations.Location p0;
			public global::Android.Locations.Location P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mobfox/sdk/services/MobFoxLocationService_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/services/MobFoxLocationService_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

			public void OnError (string p0)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<LocationEventArgs> OnLocationHandler;
#pragma warning restore 0649

			public void OnLocation (global::Android.Locations.Location p0)
			{
				var __h = OnLocationHandler;
				if (__h != null)
					__h (sender, new LocationEventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnErrorHandler == null && value.OnLocationHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/services/MobFoxLocationService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobFoxLocationService); }
		}

		protected MobFoxLocationService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mobfox_sdk_services_MobFoxLocationService_Listener_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/constructor[@name='MobFoxLocationService' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.services.MobFoxLocationService.Listener'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lcom/mobfox/sdk/services/MobFoxLocationService$Listener;Landroid/content/Context;)V", "")]
		public unsafe MobFoxLocationService (global::Com.Mobfox.Sdk.Services.MobFoxLocationService.IListener p0, global::Android.Content.Context p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MobFoxLocationService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mobfox/sdk/services/MobFoxLocationService$Listener;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mobfox/sdk/services/MobFoxLocationService$Listener;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mobfox_sdk_services_MobFoxLocationService_Listener_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_mobfox_sdk_services_MobFoxLocationService_Listener_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mobfox/sdk/services/MobFoxLocationService$Listener;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mobfox_sdk_services_MobFoxLocationService_Listener_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mobfox_sdk_services_MobFoxLocationService_Listener_Landroid_content_Context_, __args);
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
			global::Com.Mobfox.Sdk.Services.MobFoxLocationService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Callback ();
		}
#pragma warning restore 0169

		static IntPtr id_callback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/method[@name='callback' and count(parameter)=0]"
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

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxLocationService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

		static Delegate cb_initLocationDialog;
#pragma warning disable 0169
		static Delegate GetInitLocationDialogHandler ()
		{
			if (cb_initLocationDialog == null)
				cb_initLocationDialog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitLocationDialog);
			return cb_initLocationDialog;
		}

		static void n_InitLocationDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxLocationService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitLocationDialog ();
		}
#pragma warning restore 0169

		static IntPtr id_initLocationDialog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/method[@name='initLocationDialog' and count(parameter)=0]"
		[Register ("initLocationDialog", "()V", "GetInitLocationDialogHandler")]
		protected virtual unsafe void InitLocationDialog ()
		{
			if (id_initLocationDialog == IntPtr.Zero)
				id_initLocationDialog = JNIEnv.GetMethodID (class_ref, "initLocationDialog", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initLocationDialog);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initLocationDialog", "()V"));
			} finally {
			}
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxLocationService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
		public virtual unsafe void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onProviderDisabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderDisabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderDisabled_Ljava_lang_String_ == null)
				cb_onProviderDisabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderDisabled_Ljava_lang_String_);
			return cb_onProviderDisabled_Ljava_lang_String_;
		}

		static void n_OnProviderDisabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxLocationService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderDisabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderDisabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/method[@name='onProviderDisabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderDisabled", "(Ljava/lang/String;)V", "GetOnProviderDisabled_Ljava_lang_String_Handler")]
		public virtual unsafe void OnProviderDisabled (string p0)
		{
			if (id_onProviderDisabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderDisabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderDisabled", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProviderDisabled_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderDisabled", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onProviderEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderEnabled_Ljava_lang_String_ == null)
				cb_onProviderEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderEnabled_Ljava_lang_String_);
			return cb_onProviderEnabled_Ljava_lang_String_;
		}

		static void n_OnProviderEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxLocationService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderEnabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/method[@name='onProviderEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderEnabled", "(Ljava/lang/String;)V", "GetOnProviderEnabled_Ljava_lang_String_Handler")]
		public virtual unsafe void OnProviderEnabled (string p0)
		{
			if (id_onProviderEnabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderEnabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderEnabled", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProviderEnabled_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderEnabled", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI);
			return cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxLocationService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnRequestPermissionsResult (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
		[Register ("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe void OnRequestPermissionsResult (int p0, string[] p1, int[] p2)
		{
			if (id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == null)
				cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_);
			return cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		}

		static void n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, IntPtr native_p2)
		{
			global::Com.Mobfox.Sdk.Services.MobFoxLocationService __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Services.MobFoxLocationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Availability p1 = (global::Android.Locations.Availability) native_p1;
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.services']/class[@name='MobFoxLocationService']/method[@name='onStatusChanged' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", "GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
		public virtual unsafe void OnStatusChanged (string p0, [global::Android.Runtime.GeneratedEnum] global::Android.Locations.Availability p1, global::Android.OS.Bundle p2)
		{
			if (id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
