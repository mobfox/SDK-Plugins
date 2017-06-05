using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Interstitialads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/interstitialads/InterstitialAd", DoNotGenerateAcw=true)]
	public partial class InterstitialAd : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/interstitialads/InterstitialAd", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InterstitialAd); }
		}

		protected InterstitialAd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/constructor[@name='InterstitialAd' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe InterstitialAd (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (InterstitialAd)) {
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

		static Delegate cb_getBanner;
#pragma warning disable 0169
		static Delegate GetGetBannerHandler ()
		{
			if (cb_getBanner == null)
				cb_getBanner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBanner);
			return cb_getBanner;
		}

		static IntPtr n_GetBanner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Banner);
		}
#pragma warning restore 0169

		static IntPtr id_getBanner;
		public virtual unsafe global::Com.Mobfox.Sdk.Bannerads.Banner Banner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='getBanner' and count(parameter)=0]"
			[Register ("getBanner", "()Lcom/mobfox/sdk/bannerads/Banner;", "GetGetBannerHandler")]
			get {
				if (id_getBanner == IntPtr.Zero)
					id_getBanner = JNIEnv.GetMethodID (class_ref, "getBanner", "()Lcom/mobfox/sdk/bannerads/Banner;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBanner), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBanner", "()Lcom/mobfox/sdk/bannerads/Banner;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReady);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReady", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getIterator;
#pragma warning disable 0169
		static Delegate GetGetIteratorHandler ()
		{
			if (cb_getIterator == null)
				cb_getIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIterator);
			return cb_getIterator;
		}

		static IntPtr n_GetIterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator);
		}
#pragma warning restore 0169

		static IntPtr id_getIterator;
		public virtual unsafe global::Com.Mobfox.Sdk.Interstitialads.EventIterator Iterator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='getIterator' and count(parameter)=0]"
			[Register ("getIterator", "()Lcom/mobfox/sdk/interstitialads/EventIterator;", "GetGetIteratorHandler")]
			get {
				if (id_getIterator == IntPtr.Zero)
					id_getIterator = JNIEnv.GetMethodID (class_ref, "getIterator", "()Lcom/mobfox/sdk/interstitialads/EventIterator;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.EventIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIterator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.EventIterator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIterator", "()Lcom/mobfox/sdk/interstitialads/EventIterator;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createAd_Landroid_content_Context_II;
#pragma warning disable 0169
		static Delegate GetCreateAd_Landroid_content_Context_IIHandler ()
		{
			if (cb_createAd_Landroid_content_Context_II == null)
				cb_createAd_Landroid_content_Context_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_CreateAd_Landroid_content_Context_II);
			return cb_createAd_Landroid_content_Context_II;
		}

		static IntPtr n_CreateAd_Landroid_content_Context_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAd (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAd_Landroid_content_Context_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='createAd' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("createAd", "(Landroid/content/Context;II)Lcom/mobfox/sdk/bannerads/Banner;", "GetCreateAd_Landroid_content_Context_IIHandler")]
		protected virtual unsafe global::Com.Mobfox.Sdk.Bannerads.Banner CreateAd (global::Android.Content.Context p0, int p1, int p2)
		{
			if (id_createAd_Landroid_content_Context_II == IntPtr.Zero)
				id_createAd_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "createAd", "(Landroid/content/Context;II)Lcom/mobfox/sdk/bannerads/Banner;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Mobfox.Sdk.Bannerads.Banner __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAd_Landroid_content_Context_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAd", "(Landroid/content/Context;II)Lcom/mobfox/sdk/bannerads/Banner;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLocation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='getLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getLocation", "(Z)V", "")]
		public static unsafe void GetLocation (bool p0)
		{
			if (id_getLocation_Z == IntPtr.Zero)
				id_getLocation_Z = JNIEnv.GetStaticMethodID (class_ref, "getLocation", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getLocation_Z, __args);
			} finally {
			}
		}

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler")]
		public virtual unsafe void Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetMethodID (class_ref, "load", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "()V"));
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
			} finally {
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
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
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

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_setInventoryHash_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInventoryHash_Ljava_lang_String_Handler ()
		{
			if (cb_setInventoryHash_Ljava_lang_String_ == null)
				cb_setInventoryHash_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInventoryHash_Ljava_lang_String_);
			return cb_setInventoryHash_Ljava_lang_String_;
		}

		static void n_SetInventoryHash_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInventoryHash (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInventoryHash_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='setInventoryHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInventoryHash", "(Ljava/lang/String;)V", "GetSetInventoryHash_Ljava_lang_String_Handler")]
		public virtual unsafe void SetInventoryHash (string p0)
		{
			if (id_setInventoryHash_Ljava_lang_String_ == IntPtr.Zero)
				id_setInventoryHash_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInventoryHash", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInventoryHash_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInventoryHash", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_Handler ()
		{
			if (cb_setListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_ == null)
				cb_setListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_);
			return cb_setListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_;
		}

		static void n_SetListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Interstitialads.IInterstitialAdListener p0 = (global::Com.Mobfox.Sdk.Interstitialads.IInterstitialAdListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.IInterstitialAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.interstitialads.InterstitialAdListener']]"
		[Register ("setListener", "(Lcom/mobfox/sdk/interstitialads/InterstitialAdListener;)V", "GetSetListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Mobfox.Sdk.Interstitialads.IInterstitialAdListener p0)
		{
			if (id_setListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_ == IntPtr.Zero)
				id_setListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/mobfox/sdk/interstitialads/InterstitialAdListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_mobfox_sdk_interstitialads_InterstitialAdListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/mobfox/sdk/interstitialads/InterstitialAdListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOrientation_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetSetOrientation_Landroid_content_Context_IHandler ()
		{
			if (cb_setOrientation_Landroid_content_Context_I == null)
				cb_setOrientation_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetOrientation_Landroid_content_Context_I);
			return cb_setOrientation_Landroid_content_Context_I;
		}

		static void n_SetOrientation_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOrientation_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='setOrientation' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setOrientation", "(Landroid/content/Context;I)V", "GetSetOrientation_Landroid_content_Context_IHandler")]
		protected virtual unsafe void SetOrientation (global::Android.Content.Context p0, int p1)
		{
			if (id_setOrientation_Landroid_content_Context_I == IntPtr.Zero)
				id_setOrientation_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setOrientation", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOrientation_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setSecure_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='setSecure' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSecure", "(Z)V", "")]
		public static unsafe void SetSecure (bool p0)
		{
			if (id_setSecure_Z == IntPtr.Zero)
				id_setSecure_Z = JNIEnv.GetStaticMethodID (class_ref, "setSecure", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSecure_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setSkip_Z;
#pragma warning disable 0169
		static Delegate GetSetSkip_ZHandler ()
		{
			if (cb_setSkip_Z == null)
				cb_setSkip_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSkip_Z);
			return cb_setSkip_Z;
		}

		static void n_SetSkip_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSkip (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSkip_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='setSkip' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSkip", "(Z)V", "GetSetSkip_ZHandler")]
		public virtual unsafe void SetSkip (bool p0)
		{
			if (id_setSkip_Z == IntPtr.Zero)
				id_setSkip_Z = JNIEnv.GetMethodID (class_ref, "setSkip", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSkip_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSkip", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStart_muted_Z;
#pragma warning disable 0169
		static Delegate GetSetStart_muted_ZHandler ()
		{
			if (cb_setStart_muted_Z == null)
				cb_setStart_muted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetStart_muted_Z);
			return cb_setStart_muted_Z;
		}

		static void n_SetStart_muted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStart_muted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStart_muted_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='setStart_muted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStart_muted", "(Z)V", "GetSetStart_muted_ZHandler")]
		public virtual unsafe void SetStart_muted (bool p0)
		{
			if (id_setStart_muted_Z == IntPtr.Zero)
				id_setStart_muted_Z = JNIEnv.GetMethodID (class_ref, "setStart_muted", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStart_muted_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStart_muted", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
		public virtual unsafe void SetType (string p0)
		{
			if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
				id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setup;
#pragma warning disable 0169
		static Delegate GetSetupHandler ()
		{
			if (cb_setup == null)
				cb_setup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Setup);
			return cb_setup;
		}

		static void n_Setup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Setup ();
		}
#pragma warning restore 0169

		static IntPtr id_setup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='setup' and count(parameter)=0]"
		[Register ("setup", "()V", "GetSetupHandler")]
		protected virtual unsafe void Setup ()
		{
			if (id_setup == IntPtr.Zero)
				id_setup = JNIEnv.GetMethodID (class_ref, "setup", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setup);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setup", "()V"));
			} finally {
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Interstitialads.InterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.interstitialads']/class[@name='InterstitialAd']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public virtual unsafe void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Mobfox.Sdk.Interstitialads.IInterstitialAdListener"

		global::Com.Mobfox.Sdk.Interstitialads.IInterstitialAdListenerImplementor __CreateIInterstitialAdListenerImplementor ()
		{
			return new global::Com.Mobfox.Sdk.Interstitialads.IInterstitialAdListenerImplementor (this);
		}
#endregion
	}
}
