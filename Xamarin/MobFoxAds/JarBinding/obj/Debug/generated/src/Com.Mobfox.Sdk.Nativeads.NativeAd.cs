using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/NativeAd", DoNotGenerateAcw=true)]
	public partial class NativeAd : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/interface[@name='NativeAd.FireTrackersCallback']"
		[Register ("com/mobfox/sdk/nativeads/NativeAd$FireTrackersCallback", "", "Com.Mobfox.Sdk.Nativeads.NativeAd/IFireTrackersCallbackInvoker")]
		public partial interface IFireTrackersCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/interface[@name='NativeAd.FireTrackersCallback']/method[@name='onComplete' and count(parameter)=0]"
			[Register ("onComplete", "()V", "GetOnCompleteHandler:Com.Mobfox.Sdk.Nativeads.NativeAd/IFireTrackersCallbackInvoker, JarBinding")]
			void OnComplete ();

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/NativeAd$FireTrackersCallback", DoNotGenerateAcw=true)]
		internal class IFireTrackersCallbackInvoker : global::Java.Lang.Object, IFireTrackersCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/nativeads/NativeAd$FireTrackersCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFireTrackersCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IFireTrackersCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFireTrackersCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.nativeads.NativeAd.FireTrackersCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFireTrackersCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onComplete;
#pragma warning disable 0169
			static Delegate GetOnCompleteHandler ()
			{
				if (cb_onComplete == null)
					cb_onComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnComplete);
				return cb_onComplete;
			}

			static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mobfox.Sdk.Nativeads.NativeAd.IFireTrackersCallback __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd.IFireTrackersCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete ();
			}
#pragma warning restore 0169

			IntPtr id_onComplete;
			public unsafe void OnComplete ()
			{
				if (id_onComplete == IntPtr.Zero)
					id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/interface[@name='NativeAd.ImagesLoadedListener']"
		[Register ("com/mobfox/sdk/nativeads/NativeAd$ImagesLoadedListener", "", "Com.Mobfox.Sdk.Nativeads.NativeAd/IImagesLoadedListenerInvoker")]
		public partial interface IImagesLoadedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/interface[@name='NativeAd.ImagesLoadedListener']/method[@name='onImagesLoaded' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.nativeads.NativeAd']]"
			[Register ("onImagesLoaded", "(Lcom/mobfox/sdk/nativeads/NativeAd;)V", "GetOnImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_Handler:Com.Mobfox.Sdk.Nativeads.NativeAd/IImagesLoadedListenerInvoker, JarBinding")]
			void OnImagesLoaded (global::Com.Mobfox.Sdk.Nativeads.NativeAd p0);

		}

		[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/NativeAd$ImagesLoadedListener", DoNotGenerateAcw=true)]
		internal class IImagesLoadedListenerInvoker : global::Java.Lang.Object, IImagesLoadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mobfox/sdk/nativeads/NativeAd$ImagesLoadedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IImagesLoadedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IImagesLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IImagesLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mobfox.sdk.nativeads.NativeAd.ImagesLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IImagesLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_;
#pragma warning disable 0169
			static Delegate GetOnImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_Handler ()
			{
				if (cb_onImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_ == null)
					cb_onImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_);
				return cb_onImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_;
			}

			static void n_OnImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mobfox.Sdk.Nativeads.NativeAd.IImagesLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd.IImagesLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mobfox.Sdk.Nativeads.NativeAd p0 = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnImagesLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_;
			public unsafe void OnImagesLoaded (global::Com.Mobfox.Sdk.Nativeads.NativeAd p0)
			{
				if (id_onImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_ == IntPtr.Zero)
					id_onImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "onImagesLoaded", "(Lcom/mobfox/sdk/nativeads/NativeAd;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImagesLoaded_Lcom_mobfox_sdk_nativeads_NativeAd_, __args);
			}

		}

		public partial class ImagesLoadedEventArgs : global::System.EventArgs {

			public ImagesLoadedEventArgs (global::Com.Mobfox.Sdk.Nativeads.NativeAd p0)
			{
				this.p0 = p0;
			}

			global::Com.Mobfox.Sdk.Nativeads.NativeAd p0;
			public global::Com.Mobfox.Sdk.Nativeads.NativeAd P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mobfox/sdk/nativeads/NativeAd_ImagesLoadedListenerImplementor")]
		internal sealed partial class IImagesLoadedListenerImplementor : global::Java.Lang.Object, IImagesLoadedListener {

			object sender;

			public IImagesLoadedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mobfox/sdk/nativeads/NativeAd_ImagesLoadedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ImagesLoadedEventArgs> Handler;
#pragma warning restore 0649

			public void OnImagesLoaded (global::Com.Mobfox.Sdk.Nativeads.NativeAd p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ImagesLoadedEventArgs (p0));
			}

			internal static bool __IsEmpty (IImagesLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/nativeads/NativeAd", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeAd); }
		}

		protected NativeAd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/constructor[@name='NativeAd' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NativeAd ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NativeAd)) {
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

		static Delegate cb_getImages;
#pragma warning disable 0169
		static Delegate GetGetImagesHandler ()
		{
			if (cb_getImages == null)
				cb_getImages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImages);
			return cb_getImages;
		}

		static IntPtr n_GetImages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.ImageItem>.ToLocalJniHandle (__this.Images);
		}
#pragma warning restore 0169

		static Delegate cb_setImages_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetImages_Ljava_util_List_Handler ()
		{
			if (cb_setImages_Ljava_util_List_ == null)
				cb_setImages_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImages_Ljava_util_List_);
			return cb_setImages_Ljava_util_List_;
		}

		static void n_SetImages_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.ImageItem>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Images = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImages;
		static IntPtr id_setImages_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Nativeads.ImageItem> Images {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='getImages' and count(parameter)=0]"
			[Register ("getImages", "()Ljava/util/List;", "GetGetImagesHandler")]
			get {
				if (id_getImages == IntPtr.Zero)
					id_getImages = JNIEnv.GetMethodID (class_ref, "getImages", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.ImageItem>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.ImageItem>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='setImages' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mobfox.sdk.nativeads.ImageItem&gt;']]"
			[Register ("setImages", "(Ljava/util/List;)V", "GetSetImages_Ljava_util_List_Handler")]
			set {
				if (id_setImages_Ljava_util_List_ == IntPtr.Zero)
					id_setImages_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setImages", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.ImageItem>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImages_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImages", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLink;
#pragma warning disable 0169
		static Delegate GetGetLinkHandler ()
		{
			if (cb_getLink == null)
				cb_getLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLink);
			return cb_getLink;
		}

		static IntPtr n_GetLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Link);
		}
#pragma warning restore 0169

		static Delegate cb_setLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLink_Ljava_lang_String_Handler ()
		{
			if (cb_setLink_Ljava_lang_String_ == null)
				cb_setLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLink_Ljava_lang_String_);
			return cb_setLink_Ljava_lang_String_;
		}

		static void n_SetLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Link = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLink;
		static IntPtr id_setLink_Ljava_lang_String_;
		public virtual unsafe string Link {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='getLink' and count(parameter)=0]"
			[Register ("getLink", "()Ljava/lang/String;", "GetGetLinkHandler")]
			get {
				if (id_getLink == IntPtr.Zero)
					id_getLink = JNIEnv.GetMethodID (class_ref, "getLink", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLink), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLink", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='setLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLink", "(Ljava/lang/String;)V", "GetSetLink_Ljava_lang_String_Handler")]
			set {
				if (id_setLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLink_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLink", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTexts;
#pragma warning disable 0169
		static Delegate GetGetTextsHandler ()
		{
			if (cb_getTexts == null)
				cb_getTexts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTexts);
			return cb_getTexts;
		}

		static IntPtr n_GetTexts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.TextItem>.ToLocalJniHandle (__this.Texts);
		}
#pragma warning restore 0169

		static Delegate cb_setTexts_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTexts_Ljava_util_List_Handler ()
		{
			if (cb_setTexts_Ljava_util_List_ == null)
				cb_setTexts_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTexts_Ljava_util_List_);
			return cb_setTexts_Ljava_util_List_;
		}

		static void n_SetTexts_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.TextItem>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Texts = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTexts;
		static IntPtr id_setTexts_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Nativeads.TextItem> Texts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='getTexts' and count(parameter)=0]"
			[Register ("getTexts", "()Ljava/util/List;", "GetGetTextsHandler")]
			get {
				if (id_getTexts == IntPtr.Zero)
					id_getTexts = JNIEnv.GetMethodID (class_ref, "getTexts", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.TextItem>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTexts), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.TextItem>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTexts", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='setTexts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mobfox.sdk.nativeads.TextItem&gt;']]"
			[Register ("setTexts", "(Ljava/util/List;)V", "GetSetTexts_Ljava_util_List_Handler")]
			set {
				if (id_setTexts_Ljava_util_List_ == IntPtr.Zero)
					id_setTexts_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setTexts", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.TextItem>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTexts_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTexts", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrackerList;
#pragma warning disable 0169
		static Delegate GetGetTrackerListHandler ()
		{
			if (cb_getTrackerList == null)
				cb_getTrackerList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackerList);
			return cb_getTrackerList;
		}

		static IntPtr n_GetTrackerList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.ToLocalJniHandle (__this.TrackerList);
		}
#pragma warning restore 0169

		static Delegate cb_setTrackerList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTrackerList_Ljava_util_List_Handler ()
		{
			if (cb_setTrackerList_Ljava_util_List_ == null)
				cb_setTrackerList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackerList_Ljava_util_List_);
			return cb_setTrackerList_Ljava_util_List_;
		}

		static void n_SetTrackerList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackerList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackerList;
		static IntPtr id_setTrackerList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Nativeads.Tracker> TrackerList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='getTrackerList' and count(parameter)=0]"
			[Register ("getTrackerList", "()Ljava/util/List;", "GetGetTrackerListHandler")]
			get {
				if (id_getTrackerList == IntPtr.Zero)
					id_getTrackerList = JNIEnv.GetMethodID (class_ref, "getTrackerList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackerList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackerList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='setTrackerList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mobfox.sdk.nativeads.Tracker&gt;']]"
			[Register ("setTrackerList", "(Ljava/util/List;)V", "GetSetTrackerList_Ljava_util_List_Handler")]
			set {
				if (id_setTrackerList_Ljava_util_List_ == IntPtr.Zero)
					id_setTrackerList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setTrackerList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Nativeads.Tracker>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrackerList_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackerList", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_fireTrackers_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetFireTrackers_Landroid_content_Context_Handler ()
		{
			if (cb_fireTrackers_Landroid_content_Context_ == null)
				cb_fireTrackers_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FireTrackers_Landroid_content_Context_);
			return cb_fireTrackers_Landroid_content_Context_;
		}

		static void n_FireTrackers_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FireTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fireTrackers_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='fireTrackers' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("fireTrackers", "(Landroid/content/Context;)V", "GetFireTrackers_Landroid_content_Context_Handler")]
		public virtual unsafe void FireTrackers (global::Android.Content.Context p0)
		{
			if (id_fireTrackers_Landroid_content_Context_ == IntPtr.Zero)
				id_fireTrackers_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "fireTrackers", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fireTrackers_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fireTrackers", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_;
#pragma warning disable 0169
		static Delegate GetFireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_Handler ()
		{
			if (cb_fireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_ == null)
				cb_fireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_FireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_);
			return cb_fireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_;
		}

		static void n_FireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Nativeads.NativeAd.IFireTrackersCallback p1 = (global::Com.Mobfox.Sdk.Nativeads.NativeAd.IFireTrackersCallback)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd.IFireTrackersCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.FireTrackers (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_fireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='fireTrackers' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.nativeads.NativeAd.FireTrackersCallback']]"
		[Register ("fireTrackers", "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/NativeAd$FireTrackersCallback;)V", "GetFireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_Handler")]
		public virtual unsafe void FireTrackers (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Nativeads.NativeAd.IFireTrackersCallback p1)
		{
			if (id_fireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_ == IntPtr.Zero)
				id_fireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_ = JNIEnv.GetMethodID (class_ref, "fireTrackers", "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/NativeAd$FireTrackersCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fireTrackers_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_FireTrackersCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fireTrackers", "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/NativeAd$FireTrackersCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_loadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_;
#pragma warning disable 0169
		static Delegate GetLoadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_Handler ()
		{
			if (cb_loadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_ == null)
				cb_loadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_);
			return cb_loadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_;
		}

		static void n_LoadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mobfox.Sdk.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Nativeads.NativeAd.IImagesLoadedListener p1 = (global::Com.Mobfox.Sdk.Nativeads.NativeAd.IImagesLoadedListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd.IImagesLoadedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadImages (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='loadImages' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mobfox.sdk.nativeads.NativeAd.ImagesLoadedListener']]"
		[Register ("loadImages", "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/NativeAd$ImagesLoadedListener;)V", "GetLoadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_Handler")]
		public virtual unsafe void LoadImages (global::Android.Content.Context p0, global::Com.Mobfox.Sdk.Nativeads.NativeAd.IImagesLoadedListener p1)
		{
			if (id_loadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_ == IntPtr.Zero)
				id_loadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_ = JNIEnv.GetMethodID (class_ref, "loadImages", "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/NativeAd$ImagesLoadedListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadImages_Landroid_content_Context_Lcom_mobfox_sdk_nativeads_NativeAd_ImagesLoadedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadImages", "(Landroid/content/Context;Lcom/mobfox/sdk/nativeads/NativeAd$ImagesLoadedListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_parse_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='NativeAd']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("parse", "(Lorg/json/JSONObject;)Lcom/mobfox/sdk/nativeads/NativeAd;", "")]
		public static unsafe global::Com.Mobfox.Sdk.Nativeads.NativeAd Parse (global::Org.Json.JSONObject p0)
		{
			if (id_parse_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_parse_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Lorg/json/JSONObject;)Lcom/mobfox/sdk/nativeads/NativeAd;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mobfox.Sdk.Nativeads.NativeAd __ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.NativeAd> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
