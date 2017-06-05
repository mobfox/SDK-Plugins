using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Bannerads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='SizeUtils']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/bannerads/SizeUtils", DoNotGenerateAcw=true)]
	public partial class SizeUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='SizeUtils.Point']"
		[global::Android.Runtime.Register ("com/mobfox/sdk/bannerads/SizeUtils$Point", DoNotGenerateAcw=true)]
		public partial class Point : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mobfox/sdk/bannerads/SizeUtils$Point", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Point); }
			}

			protected Point (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='SizeUtils.Point']/constructor[@name='SizeUtils.Point' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe Point (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (Point)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
						return;
					}

					if (id_ctor_II == IntPtr.Zero)
						id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/bannerads/SizeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SizeUtils); }
		}

		protected SizeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='SizeUtils']/constructor[@name='SizeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SizeUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SizeUtils)) {
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

		static IntPtr id_SIZES;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='SizeUtils']/method[@name='SIZES' and count(parameter)=0]"
		[Register ("SIZES", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point> SIZES ()
		{
			if (id_SIZES == IntPtr.Zero)
				id_SIZES = JNIEnv.GetStaticMethodID (class_ref, "SIZES", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_SIZES), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_calcDist_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='SizeUtils']/method[@name='calcDist' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.bannerads.SizeUtils.Point'] and parameter[2][@type='com.mobfox.sdk.bannerads.SizeUtils.Point']]"
		[Register ("calcDist", "(Lcom/mobfox/sdk/bannerads/SizeUtils$Point;Lcom/mobfox/sdk/bannerads/SizeUtils$Point;)D", "")]
		public static unsafe double CalcDist (global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point p0, global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point p1)
		{
			if (id_calcDist_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_ == IntPtr.Zero)
				id_calcDist_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_ = JNIEnv.GetStaticMethodID (class_ref, "calcDist", "(Lcom/mobfox/sdk/bannerads/SizeUtils$Point;Lcom/mobfox/sdk/bannerads/SizeUtils$Point;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_calcDist_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNearest_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='SizeUtils']/method[@name='getNearest' and count(parameter)=2 and parameter[1][@type='com.mobfox.sdk.bannerads.SizeUtils.Point'] and parameter[2][@type='java.util.List&lt;com.mobfox.sdk.bannerads.SizeUtils.Point&gt;']]"
		[Register ("getNearest", "(Lcom/mobfox/sdk/bannerads/SizeUtils$Point;Ljava/util/List;)Lcom/mobfox/sdk/bannerads/SizeUtils$Point;", "")]
		public static unsafe global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point GetNearest (global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point p0, global::System.Collections.Generic.IList<global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point> p1)
		{
			if (id_getNearest_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_Ljava_util_List_ == IntPtr.Zero)
				id_getNearest_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getNearest", "(Lcom/mobfox/sdk/bannerads/SizeUtils$Point;Ljava/util/List;)Lcom/mobfox/sdk/bannerads/SizeUtils$Point;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point __ret = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.SizeUtils.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNearest_Lcom_mobfox_sdk_bannerads_SizeUtils_Point_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
