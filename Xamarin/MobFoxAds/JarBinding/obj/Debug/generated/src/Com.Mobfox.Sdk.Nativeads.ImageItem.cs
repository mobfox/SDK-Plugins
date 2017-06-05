using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='ImageItem']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/nativeads/ImageItem", DoNotGenerateAcw=true)]
	public partial class ImageItem : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/nativeads/ImageItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageItem); }
		}

		protected ImageItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='ImageItem']/constructor[@name='ImageItem' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;II)V", "")]
		public unsafe ImageItem (string p0, string p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (ImageItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getImg;
#pragma warning disable 0169
		static Delegate GetGetImgHandler ()
		{
			if (cb_getImg == null)
				cb_getImg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImg);
			return cb_getImg;
		}

		static IntPtr n_GetImg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.ImageItem __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.ImageItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Img);
		}
#pragma warning restore 0169

		static Delegate cb_setImg_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImg_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImg_Landroid_graphics_Bitmap_ == null)
				cb_setImg_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImg_Landroid_graphics_Bitmap_);
			return cb_setImg_Landroid_graphics_Bitmap_;
		}

		static void n_SetImg_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Nativeads.ImageItem __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.ImageItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Img = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImg;
		static IntPtr id_setImg_Landroid_graphics_Bitmap_;
		public virtual unsafe global::Android.Graphics.Bitmap Img {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='ImageItem']/method[@name='getImg' and count(parameter)=0]"
			[Register ("getImg", "()Landroid/graphics/Bitmap;", "GetGetImgHandler")]
			get {
				if (id_getImg == IntPtr.Zero)
					id_getImg = JNIEnv.GetMethodID (class_ref, "getImg", "()Landroid/graphics/Bitmap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImg), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImg", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='ImageItem']/method[@name='setImg' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setImg", "(Landroid/graphics/Bitmap;)V", "GetSetImg_Landroid_graphics_Bitmap_Handler")]
			set {
				if (id_setImg_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_setImg_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImg", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImg_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImg", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.ImageItem __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.ImageItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='ImageItem']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.ImageItem __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.ImageItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='ImageItem']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getH;
#pragma warning disable 0169
		static Delegate GetGetHHandler ()
		{
			if (cb_getH == null)
				cb_getH = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetH);
			return cb_getH;
		}

		static int n_GetH (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.ImageItem __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.ImageItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetH ();
		}
#pragma warning restore 0169

		static IntPtr id_getH;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='ImageItem']/method[@name='getH' and count(parameter)=0]"
		[Register ("getH", "()I", "GetGetHHandler")]
		public virtual unsafe int GetH ()
		{
			if (id_getH == IntPtr.Zero)
				id_getH = JNIEnv.GetMethodID (class_ref, "getH", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getH);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getH", "()I"));
			} finally {
			}
		}

		static Delegate cb_getW;
#pragma warning disable 0169
		static Delegate GetGetWHandler ()
		{
			if (cb_getW == null)
				cb_getW = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetW);
			return cb_getW;
		}

		static int n_GetW (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Nativeads.ImageItem __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Nativeads.ImageItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetW ();
		}
#pragma warning restore 0169

		static IntPtr id_getW;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.nativeads']/class[@name='ImageItem']/method[@name='getW' and count(parameter)=0]"
		[Register ("getW", "()I", "GetGetWHandler")]
		public virtual unsafe int GetW ()
		{
			if (id_getW == IntPtr.Zero)
				id_getW = JNIEnv.GetMethodID (class_ref, "getW", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getW);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getW", "()I"));
			} finally {
			}
		}

	}
}
