using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mobfox.Sdk.Bannerads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']"
	[global::Android.Runtime.Register ("com/mobfox/sdk/bannerads/Banner", DoNotGenerateAcw=true)]
	public partial class Banner : global::Android.Widget.RelativeLayout {


		static IntPtr DEBUG_MODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/field[@name='DEBUG_MODE']"
		[Register ("DEBUG_MODE")]
		public static bool DebugMode {
			get {
				if (DEBUG_MODE_jfieldId == IntPtr.Zero)
					DEBUG_MODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG_MODE", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_MODE_jfieldId);
			}
			set {
				if (DEBUG_MODE_jfieldId == IntPtr.Zero)
					DEBUG_MODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG_MODE", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, DEBUG_MODE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr LOAD_START_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/field[@name='LOAD_START']"
		[Register ("LOAD_START")]
		public static string LoadStart {
			get {
				if (LOAD_START_jfieldId == IntPtr.Zero)
					LOAD_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOAD_START", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOAD_START_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LOAD_START_jfieldId == IntPtr.Zero)
					LOAD_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOAD_START", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, LOAD_START_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr loc_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/field[@name='loc']"
		[Register ("loc")]
		public static bool Loc {
			get {
				if (loc_jfieldId == IntPtr.Zero)
					loc_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "loc", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, loc_jfieldId);
			}
			set {
				if (loc_jfieldId == IntPtr.Zero)
					loc_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "loc", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, loc_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr smart_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/field[@name='smart']"
		[Register ("smart")]
		public bool Smart {
			get {
				if (smart_jfieldId == IntPtr.Zero)
					smart_jfieldId = JNIEnv.GetFieldID (class_ref, "smart", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, smart_jfieldId);
			}
			set {
				if (smart_jfieldId == IntPtr.Zero)
					smart_jfieldId = JNIEnv.GetFieldID (class_ref, "smart", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, smart_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mobfox/sdk/bannerads/Banner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Banner); }
		}

		protected Banner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/constructor[@name='Banner' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe Banner (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Banner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/constructor[@name='Banner' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Banner (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Banner)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/constructor[@name='Banner' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe Banner (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Banner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/constructor[@name='Banner' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public unsafe Banner (global::Android.Content.Context p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Banner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_II, __args);
			} finally {
			}
		}

		static Delegate cb_getDemo_age;
#pragma warning disable 0169
		static Delegate GetGetDemo_ageHandler ()
		{
			if (cb_getDemo_age == null)
				cb_getDemo_age = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDemo_age);
			return cb_getDemo_age;
		}

		static int n_GetDemo_age (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Demo_age;
		}
#pragma warning restore 0169

		static Delegate cb_setDemo_age_I;
#pragma warning disable 0169
		static Delegate GetSetDemo_age_IHandler ()
		{
			if (cb_setDemo_age_I == null)
				cb_setDemo_age_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDemo_age_I);
			return cb_setDemo_age_I;
		}

		static void n_SetDemo_age_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Demo_age = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDemo_age;
		static IntPtr id_setDemo_age_I;
		public virtual unsafe int Demo_age {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getDemo_age' and count(parameter)=0]"
			[Register ("getDemo_age", "()I", "GetGetDemo_ageHandler")]
			get {
				if (id_getDemo_age == IntPtr.Zero)
					id_getDemo_age = JNIEnv.GetMethodID (class_ref, "getDemo_age", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDemo_age);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDemo_age", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setDemo_age' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDemo_age", "(I)V", "GetSetDemo_age_IHandler")]
			set {
				if (id_setDemo_age_I == IntPtr.Zero)
					id_setDemo_age_I = JNIEnv.GetMethodID (class_ref, "setDemo_age", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDemo_age_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDemo_age", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDemo_gender;
#pragma warning disable 0169
		static Delegate GetGetDemo_genderHandler ()
		{
			if (cb_getDemo_gender == null)
				cb_getDemo_gender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDemo_gender);
			return cb_getDemo_gender;
		}

		static IntPtr n_GetDemo_gender (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Demo_gender);
		}
#pragma warning restore 0169

		static Delegate cb_setDemo_gender_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDemo_gender_Ljava_lang_String_Handler ()
		{
			if (cb_setDemo_gender_Ljava_lang_String_ == null)
				cb_setDemo_gender_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDemo_gender_Ljava_lang_String_);
			return cb_setDemo_gender_Ljava_lang_String_;
		}

		static void n_SetDemo_gender_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Demo_gender = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDemo_gender;
		static IntPtr id_setDemo_gender_Ljava_lang_String_;
		public virtual unsafe string Demo_gender {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getDemo_gender' and count(parameter)=0]"
			[Register ("getDemo_gender", "()Ljava/lang/String;", "GetGetDemo_genderHandler")]
			get {
				if (id_getDemo_gender == IntPtr.Zero)
					id_getDemo_gender = JNIEnv.GetMethodID (class_ref, "getDemo_gender", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDemo_gender), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDemo_gender", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setDemo_gender' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDemo_gender", "(Ljava/lang/String;)V", "GetSetDemo_gender_Ljava_lang_String_Handler")]
			set {
				if (id_setDemo_gender_Ljava_lang_String_ == IntPtr.Zero)
					id_setDemo_gender_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDemo_gender", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDemo_gender_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDemo_gender", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDemo_keywords;
#pragma warning disable 0169
		static Delegate GetGetDemo_keywordsHandler ()
		{
			if (cb_getDemo_keywords == null)
				cb_getDemo_keywords = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDemo_keywords);
			return cb_getDemo_keywords;
		}

		static IntPtr n_GetDemo_keywords (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Demo_keywords);
		}
#pragma warning restore 0169

		static Delegate cb_setDemo_keywords_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDemo_keywords_Ljava_lang_String_Handler ()
		{
			if (cb_setDemo_keywords_Ljava_lang_String_ == null)
				cb_setDemo_keywords_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDemo_keywords_Ljava_lang_String_);
			return cb_setDemo_keywords_Ljava_lang_String_;
		}

		static void n_SetDemo_keywords_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Demo_keywords = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDemo_keywords;
		static IntPtr id_setDemo_keywords_Ljava_lang_String_;
		public virtual unsafe string Demo_keywords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getDemo_keywords' and count(parameter)=0]"
			[Register ("getDemo_keywords", "()Ljava/lang/String;", "GetGetDemo_keywordsHandler")]
			get {
				if (id_getDemo_keywords == IntPtr.Zero)
					id_getDemo_keywords = JNIEnv.GetMethodID (class_ref, "getDemo_keywords", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDemo_keywords), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDemo_keywords", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setDemo_keywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDemo_keywords", "(Ljava/lang/String;)V", "GetSetDemo_keywords_Ljava_lang_String_Handler")]
			set {
				if (id_setDemo_keywords_Ljava_lang_String_ == IntPtr.Zero)
					id_setDemo_keywords_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDemo_keywords", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDemo_keywords_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDemo_keywords", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isTimeout;
#pragma warning disable 0169
		static Delegate GetIsTimeoutHandler ()
		{
			if (cb_isTimeout == null)
				cb_isTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTimeout);
			return cb_isTimeout;
		}

		static bool n_IsTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTimeout;
		}
#pragma warning restore 0169

		static IntPtr id_isTimeout;
		public virtual unsafe bool IsTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='isTimeout' and count(parameter)=0]"
			[Register ("isTimeout", "()Z", "GetIsTimeoutHandler")]
			get {
				if (id_isTimeout == IntPtr.Zero)
					id_isTimeout = JNIEnv.GetMethodID (class_ref, "isTimeout", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTimeout);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTimeout", "()Z"));
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator);
		}
#pragma warning restore 0169

		static IntPtr id_getIterator;
		public virtual unsafe global::Com.Mobfox.Sdk.Bannerads.EventIterator Iterator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getIterator' and count(parameter)=0]"
			[Register ("getIterator", "()Lcom/mobfox/sdk/bannerads/EventIterator;", "GetGetIteratorHandler")]
			get {
				if (id_getIterator == IntPtr.Zero)
					id_getIterator = JNIEnv.GetMethodID (class_ref, "getIterator", "()Lcom/mobfox/sdk/bannerads/EventIterator;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.EventIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIterator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.EventIterator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIterator", "()Lcom/mobfox/sdk/bannerads/EventIterator;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLoadAdListener;
#pragma warning disable 0169
		static Delegate GetGetLoadAdListenerHandler ()
		{
			if (cb_getLoadAdListener == null)
				cb_getLoadAdListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLoadAdListener);
			return cb_getLoadAdListener;
		}

		static IntPtr n_GetLoadAdListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoadAdListener);
		}
#pragma warning restore 0169

		static Delegate cb_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_;
#pragma warning disable 0169
		static Delegate GetSetLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_Handler ()
		{
			if (cb_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ == null)
				cb_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_);
			return cb_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_;
		}

		static void n_SetLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener p0 = (global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadAdListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLoadAdListener;
		static IntPtr id_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_;
		public virtual unsafe global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener LoadAdListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getLoadAdListener' and count(parameter)=0]"
			[Register ("getLoadAdListener", "()Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;", "GetGetLoadAdListenerHandler")]
			get {
				if (id_getLoadAdListener == IntPtr.Zero)
					id_getLoadAdListener = JNIEnv.GetMethodID (class_ref, "getLoadAdListener", "()Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoadAdListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoadAdListener", "()Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setLoadAdListener' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.webview.MobFoxWebViewLoadAdListener']]"
			[Register ("setLoadAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V", "GetSetLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_Handler")]
			set {
				if (id_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ == IntPtr.Zero)
					id_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_ = JNIEnv.GetMethodID (class_ref, "setLoadAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLoadAdListener_Lcom_mobfox_sdk_webview_MobFoxWebViewLoadAdListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoadAdListener", "(Lcom/mobfox/sdk/webview/MobFoxWebViewLoadAdListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMobFoxWebView;
#pragma warning disable 0169
		static Delegate GetGetMobFoxWebViewHandler ()
		{
			if (cb_getMobFoxWebView == null)
				cb_getMobFoxWebView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMobFoxWebView);
			return cb_getMobFoxWebView;
		}

		static IntPtr n_GetMobFoxWebView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MobFoxWebView);
		}
#pragma warning restore 0169

		static IntPtr id_getMobFoxWebView;
		public virtual unsafe global::Com.Mobfox.Sdk.Webview.MobFoxWebView MobFoxWebView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getMobFoxWebView' and count(parameter)=0]"
			[Register ("getMobFoxWebView", "()Lcom/mobfox/sdk/webview/MobFoxWebView;", "GetGetMobFoxWebViewHandler")]
			get {
				if (id_getMobFoxWebView == IntPtr.Zero)
					id_getMobFoxWebView = JNIEnv.GetMethodID (class_ref, "getMobFoxWebView", "()Lcom/mobfox/sdk/webview/MobFoxWebView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMobFoxWebView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Webview.MobFoxWebView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMobFoxWebView", "()Lcom/mobfox/sdk/webview/MobFoxWebView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getO_andadvid;
#pragma warning disable 0169
		static Delegate GetGetO_andadvidHandler ()
		{
			if (cb_getO_andadvid == null)
				cb_getO_andadvid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetO_andadvid);
			return cb_getO_andadvid;
		}

		static IntPtr n_GetO_andadvid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.O_andadvid);
		}
#pragma warning restore 0169

		static IntPtr id_getO_andadvid;
		public virtual unsafe string O_andadvid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getO_andadvid' and count(parameter)=0]"
			[Register ("getO_andadvid", "()Ljava/lang/String;", "GetGetO_andadvidHandler")]
			get {
				if (id_getO_andadvid == IntPtr.Zero)
					id_getO_andadvid = JNIEnv.GetMethodID (class_ref, "getO_andadvid", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getO_andadvid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getO_andadvid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScreenHeight;
#pragma warning disable 0169
		static Delegate GetGetScreenHeightHandler ()
		{
			if (cb_getScreenHeight == null)
				cb_getScreenHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScreenHeight);
			return cb_getScreenHeight;
		}

		static int n_GetScreenHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScreenHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getScreenHeight;
		protected virtual unsafe int ScreenHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getScreenHeight' and count(parameter)=0]"
			[Register ("getScreenHeight", "()I", "GetGetScreenHeightHandler")]
			get {
				if (id_getScreenHeight == IntPtr.Zero)
					id_getScreenHeight = JNIEnv.GetMethodID (class_ref, "getScreenHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScreenHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getScreenWidth;
#pragma warning disable 0169
		static Delegate GetGetScreenWidthHandler ()
		{
			if (cb_getScreenWidth == null)
				cb_getScreenWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScreenWidth);
			return cb_getScreenWidth;
		}

		static int n_GetScreenWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScreenWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getScreenWidth;
		protected virtual unsafe int ScreenWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getScreenWidth' and count(parameter)=0]"
			[Register ("getScreenWidth", "()I", "GetGetScreenWidthHandler")]
			get {
				if (id_getScreenWidth == IntPtr.Zero)
					id_getScreenWidth = JNIEnv.GetMethodID (class_ref, "getScreenWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScreenWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenWidth", "()I"));
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_aboveTheFold;
#pragma warning disable 0169
		static Delegate GetAboveTheFoldHandler ()
		{
			if (cb_aboveTheFold == null)
				cb_aboveTheFold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AboveTheFold);
			return cb_aboveTheFold;
		}

		static bool n_AboveTheFold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AboveTheFold ();
		}
#pragma warning restore 0169

		static IntPtr id_aboveTheFold;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='aboveTheFold' and count(parameter)=0]"
		[Register ("aboveTheFold", "()Z", "GetAboveTheFoldHandler")]
		protected virtual unsafe bool AboveTheFold ()
		{
			if (id_aboveTheFold == IntPtr.Zero)
				id_aboveTheFold = JNIEnv.GetMethodID (class_ref, "aboveTheFold", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_aboveTheFold);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "aboveTheFold", "()Z"));
			} finally {
			}
		}

		static Delegate cb_cancelTimeout;
#pragma warning disable 0169
		static Delegate GetCancelTimeoutHandler ()
		{
			if (cb_cancelTimeout == null)
				cb_cancelTimeout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelTimeout);
			return cb_cancelTimeout;
		}

		static void n_CancelTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelTimeout ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelTimeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='cancelTimeout' and count(parameter)=0]"
		[Register ("cancelTimeout", "()V", "GetCancelTimeoutHandler")]
		public virtual unsafe void CancelTimeout ()
		{
			if (id_cancelTimeout == IntPtr.Zero)
				id_cancelTimeout = JNIEnv.GetMethodID (class_ref, "cancelTimeout", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelTimeout);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelTimeout", "()V"));
			} finally {
			}
		}

		static Delegate cb_getAdvId;
#pragma warning disable 0169
		static Delegate GetGetAdvIdHandler ()
		{
			if (cb_getAdvId == null)
				cb_getAdvId = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetAdvId);
			return cb_getAdvId;
		}

		static void n_GetAdvId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetAdvId ();
		}
#pragma warning restore 0169

		static IntPtr id_getAdvId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getAdvId' and count(parameter)=0]"
		[Register ("getAdvId", "()V", "GetGetAdvIdHandler")]
		protected virtual unsafe void GetAdvId ()
		{
			if (id_getAdvId == IntPtr.Zero)
				id_getAdvId = JNIEnv.GetMethodID (class_ref, "getAdvId", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAdvId);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdvId", "()V"));
			} finally {
			}
		}

		static Delegate cb_getAttrs_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetGetAttrs_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_getAttrs_Landroid_util_AttributeSet_ == null)
				cb_getAttrs_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetAttrs_Landroid_util_AttributeSet_);
			return cb_getAttrs_Landroid_util_AttributeSet_;
		}

		static void n_GetAttrs_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.IAttributeSet p0 = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetAttrs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getAttrs_Landroid_util_AttributeSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getAttrs' and count(parameter)=1 and parameter[1][@type='android.util.AttributeSet']]"
		[Register ("getAttrs", "(Landroid/util/AttributeSet;)V", "GetGetAttrs_Landroid_util_AttributeSet_Handler")]
		public virtual unsafe void GetAttrs (global::Android.Util.IAttributeSet p0)
		{
			if (id_getAttrs_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_getAttrs_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "getAttrs", "(Landroid/util/AttributeSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAttrs_Landroid_util_AttributeSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttrs", "(Landroid/util/AttributeSet;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBannerPosition;
#pragma warning disable 0169
		static Delegate GetGetBannerPositionHandler ()
		{
			if (cb_getBannerPosition == null)
				cb_getBannerPosition = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetBannerPosition);
			return cb_getBannerPosition;
		}

		static void n_GetBannerPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetBannerPosition ();
		}
#pragma warning restore 0169

		static IntPtr id_getBannerPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getBannerPosition' and count(parameter)=0]"
		[Register ("getBannerPosition", "()V", "GetGetBannerPositionHandler")]
		protected virtual unsafe void GetBannerPosition ()
		{
			if (id_getBannerPosition == IntPtr.Zero)
				id_getBannerPosition = JNIEnv.GetMethodID (class_ref, "getBannerPosition", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBannerPosition);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBannerPosition", "()V"));
			} finally {
			}
		}

		static Delegate cb_getBundleId_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetBundleId_Landroid_content_Context_Handler ()
		{
			if (cb_getBundleId_Landroid_content_Context_ == null)
				cb_getBundleId_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBundleId_Landroid_content_Context_);
			return cb_getBundleId_Landroid_content_Context_;
		}

		static IntPtr n_GetBundleId_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetBundleId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBundleId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getBundleId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getBundleId", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetBundleId_Landroid_content_Context_Handler")]
		protected virtual unsafe string GetBundleId (global::Android.Content.Context p0)
		{
			if (id_getBundleId_Landroid_content_Context_ == IntPtr.Zero)
				id_getBundleId_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getBundleId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBundleId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBundleId", "(Landroid/content/Context;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetLayout);
			return cb_getLayout;
		}

		static void n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetLayout ();
		}
#pragma warning restore 0169

		static IntPtr id_getLayout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getLayout' and count(parameter)=0]"
		[Register ("getLayout", "()V", "GetGetLayoutHandler")]
		protected virtual unsafe void GetLayout ()
		{
			if (id_getLayout == IntPtr.Zero)
				id_getLayout = JNIEnv.GetMethodID (class_ref, "getLayout", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLayout);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayout", "()V"));
			} finally {
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static void n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getLocation' and count(parameter)=0]"
		[Register ("getLocation", "()V", "GetGetLocationHandler")]
		protected virtual unsafe void GetLocation ()
		{
			if (id_getLocation == IntPtr.Zero)
				id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLocation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()V"));
			} finally {
			}
		}

		static Delegate cb_getWaterfalls_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetWaterfalls_Ljava_lang_String_Handler ()
		{
			if (cb_getWaterfalls_Ljava_lang_String_ == null)
				cb_getWaterfalls_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetWaterfalls_Ljava_lang_String_);
			return cb_getWaterfalls_Ljava_lang_String_;
		}

		static void n_GetWaterfalls_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetWaterfalls (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getWaterfalls_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='getWaterfalls' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getWaterfalls", "(Ljava/lang/String;)V", "GetGetWaterfalls_Ljava_lang_String_Handler")]
		protected virtual unsafe void GetWaterfalls (string p0)
		{
			if (id_getWaterfalls_Ljava_lang_String_ == IntPtr.Zero)
				id_getWaterfalls_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getWaterfalls", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getWaterfalls_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWaterfalls", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		protected virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='load' and count(parameter)=0]"
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

		static Delegate cb_load_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_;
		}

		static void n_Load_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Load (p0);
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)V", "GetLoad_Ljava_lang_String_Handler")]
		protected virtual unsafe void Load (string p0)
		{
			if (id_load_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadBanner_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetLoadBanner_Lorg_json_JSONObject_Handler ()
		{
			if (cb_loadBanner_Lorg_json_JSONObject_ == null)
				cb_loadBanner_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadBanner_Lorg_json_JSONObject_);
			return cb_loadBanner_Lorg_json_JSONObject_;
		}

		static void n_LoadBanner_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadBanner (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadBanner_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='loadBanner' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("loadBanner", "(Lorg/json/JSONObject;)V", "GetLoadBanner_Lorg_json_JSONObject_Handler")]
		protected virtual unsafe void LoadBanner (global::Org.Json.JSONObject p0)
		{
			if (id_loadBanner_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_loadBanner_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "loadBanner", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadBanner_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadBanner", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_loadJs;
#pragma warning disable 0169
		static Delegate GetLoadJsHandler ()
		{
			if (cb_loadJs == null)
				cb_loadJs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadJs);
			return cb_loadJs;
		}

		static void n_LoadJs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadJs ();
		}
#pragma warning restore 0169

		static IntPtr id_loadJs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='loadJs' and count(parameter)=0]"
		[Register ("loadJs", "()V", "GetLoadJsHandler")]
		protected virtual unsafe void LoadJs ()
		{
			if (id_loadJs == IntPtr.Zero)
				id_loadJs = JNIEnv.GetMethodID (class_ref, "loadJs", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadJs);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadJs", "()V"));
			} finally {
			}
		}

		static IntPtr id_logTime_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='logTime' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("logTime", "(Ljava/lang/String;J)V", "")]
		public static unsafe void LogTime (string p0, long p1)
		{
			if (id_logTime_Ljava_lang_String_J == IntPtr.Zero)
				id_logTime_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "logTime", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logTime_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_makeParams;
#pragma warning disable 0169
		static Delegate GetMakeParamsHandler ()
		{
			if (cb_makeParams == null)
				cb_makeParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MakeParams);
			return cb_makeParams;
		}

		static IntPtr n_MakeParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MakeParams ());
		}
#pragma warning restore 0169

		static IntPtr id_makeParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='makeParams' and count(parameter)=0]"
		[Register ("makeParams", "()Lorg/json/JSONObject;", "GetMakeParamsHandler")]
		protected virtual unsafe global::Org.Json.JSONObject MakeParams ()
		{
			if (id_makeParams == IntPtr.Zero)
				id_makeParams = JNIEnv.GetMethodID (class_ref, "makeParams", "()Lorg/json/JSONObject;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_makeParams), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeParams", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='onPause' and count(parameter)=0]"
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='onResume' and count(parameter)=0]"
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

		static Delegate cb_postDMP;
#pragma warning disable 0169
		static Delegate GetPostDMPHandler ()
		{
			if (cb_postDMP == null)
				cb_postDMP = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostDMP);
			return cb_postDMP;
		}

		static void n_PostDMP (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostDMP ();
		}
#pragma warning restore 0169

		static IntPtr id_postDMP;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='postDMP' and count(parameter)=0]"
		[Register ("postDMP", "()V", "GetPostDMPHandler")]
		protected virtual unsafe void PostDMP ()
		{
			if (id_postDMP == IntPtr.Zero)
				id_postDMP = JNIEnv.GetMethodID (class_ref, "postDMP", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postDMP);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postDMP", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAdFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setAdFormat_Ljava_lang_String_ == null)
				cb_setAdFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdFormat_Ljava_lang_String_);
			return cb_setAdFormat_Ljava_lang_String_;
		}

		static void n_SetAdFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdFormat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdFormat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setAdFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAdFormat", "(Ljava/lang/String;)V", "GetSetAdFormat_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAdFormat (string p0)
		{
			if (id_setAdFormat_Ljava_lang_String_ == IntPtr.Zero)
				id_setAdFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdFormat", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdFormat_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdFormat", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAdspace_height_I;
#pragma warning disable 0169
		static Delegate GetSetAdspace_height_IHandler ()
		{
			if (cb_setAdspace_height_I == null)
				cb_setAdspace_height_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAdspace_height_I);
			return cb_setAdspace_height_I;
		}

		static void n_SetAdspace_height_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAdspace_height (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdspace_height_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setAdspace_height' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAdspace_height", "(I)V", "GetSetAdspace_height_IHandler")]
		public virtual unsafe void SetAdspace_height (int p0)
		{
			if (id_setAdspace_height_I == IntPtr.Zero)
				id_setAdspace_height_I = JNIEnv.GetMethodID (class_ref, "setAdspace_height", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdspace_height_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdspace_height", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAdspace_strict_I;
#pragma warning disable 0169
		static Delegate GetSetAdspace_strict_IHandler ()
		{
			if (cb_setAdspace_strict_I == null)
				cb_setAdspace_strict_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAdspace_strict_I);
			return cb_setAdspace_strict_I;
		}

		static void n_SetAdspace_strict_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAdspace_strict (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdspace_strict_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setAdspace_strict' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAdspace_strict", "(I)V", "GetSetAdspace_strict_IHandler")]
		public virtual unsafe void SetAdspace_strict (int p0)
		{
			if (id_setAdspace_strict_I == IntPtr.Zero)
				id_setAdspace_strict_I = JNIEnv.GetMethodID (class_ref, "setAdspace_strict", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdspace_strict_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdspace_strict", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAdspace_width_I;
#pragma warning disable 0169
		static Delegate GetSetAdspace_width_IHandler ()
		{
			if (cb_setAdspace_width_I == null)
				cb_setAdspace_width_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAdspace_width_I);
			return cb_setAdspace_width_I;
		}

		static void n_SetAdspace_width_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAdspace_width (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdspace_width_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setAdspace_width' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAdspace_width", "(I)V", "GetSetAdspace_width_IHandler")]
		public virtual unsafe void SetAdspace_width (int p0)
		{
			if (id_setAdspace_width_I == IntPtr.Zero)
				id_setAdspace_width_I = JNIEnv.GetMethodID (class_ref, "setAdspace_width", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdspace_width_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdspace_width", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAuto_pilot_Z;
#pragma warning disable 0169
		static Delegate GetSetAuto_pilot_ZHandler ()
		{
			if (cb_setAuto_pilot_Z == null)
				cb_setAuto_pilot_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAuto_pilot_Z);
			return cb_setAuto_pilot_Z;
		}

		static void n_SetAuto_pilot_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAuto_pilot (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAuto_pilot_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setAuto_pilot' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAuto_pilot", "(Z)V", "GetSetAuto_pilot_ZHandler")]
		public virtual unsafe void SetAuto_pilot (bool p0)
		{
			if (id_setAuto_pilot_Z == IntPtr.Zero)
				id_setAuto_pilot_Z = JNIEnv.GetMethodID (class_ref, "setAuto_pilot", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuto_pilot_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuto_pilot", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAutoplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAutoplay_Ljava_lang_String_Handler ()
		{
			if (cb_setAutoplay_Ljava_lang_String_ == null)
				cb_setAutoplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAutoplay_Ljava_lang_String_);
			return cb_setAutoplay_Ljava_lang_String_;
		}

		static void n_SetAutoplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAutoplay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAutoplay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setAutoplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAutoplay", "(Ljava/lang/String;)V", "GetSetAutoplay_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAutoplay (string p0)
		{
			if (id_setAutoplay_Ljava_lang_String_ == IntPtr.Zero)
				id_setAutoplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAutoplay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoplay_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoplay", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDebug_Z;
#pragma warning disable 0169
		static Delegate GetSetDebug_ZHandler ()
		{
			if (cb_setDebug_Z == null)
				cb_setDebug_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebug_Z);
			return cb_setDebug_Z;
		}

		static void n_SetDebug_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebug (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "GetSetDebug_ZHandler")]
		public virtual unsafe void SetDebug (bool p0)
		{
			if (id_setDebug_Z == IntPtr.Zero)
				id_setDebug_Z = JNIEnv.GetMethodID (class_ref, "setDebug", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDebug_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebug", "(Z)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setDev_js_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setDev_js' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDev_js", "(I)V", "")]
		public static unsafe void SetDev_js (int p0)
		{
			if (id_setDev_js_I == IntPtr.Zero)
				id_setDev_js_I = JNIEnv.GetStaticMethodID (class_ref, "setDev_js", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDev_js_I, __args);
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInventoryHash (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInventoryHash_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setInventoryHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setListener_Lcom_mobfox_sdk_bannerads_BannerListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_mobfox_sdk_bannerads_BannerListener_Handler ()
		{
			if (cb_setListener_Lcom_mobfox_sdk_bannerads_BannerListener_ == null)
				cb_setListener_Lcom_mobfox_sdk_bannerads_BannerListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_mobfox_sdk_bannerads_BannerListener_);
			return cb_setListener_Lcom_mobfox_sdk_bannerads_BannerListener_;
		}

		static void n_SetListener_Lcom_mobfox_sdk_bannerads_BannerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mobfox.Sdk.Bannerads.IBannerListener p0 = (global::Com.Mobfox.Sdk.Bannerads.IBannerListener)global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.IBannerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_mobfox_sdk_bannerads_BannerListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.mobfox.sdk.bannerads.BannerListener']]"
		[Register ("setListener", "(Lcom/mobfox/sdk/bannerads/BannerListener;)V", "GetSetListener_Lcom_mobfox_sdk_bannerads_BannerListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Mobfox.Sdk.Bannerads.IBannerListener p0)
		{
			if (id_setListener_Lcom_mobfox_sdk_bannerads_BannerListener_ == IntPtr.Zero)
				id_setListener_Lcom_mobfox_sdk_bannerads_BannerListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/mobfox/sdk/bannerads/BannerListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_mobfox_sdk_bannerads_BannerListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/mobfox/sdk/bannerads/BannerListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setLoc_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setLoc' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoc", "(Z)V", "")]
		public static unsafe void SetLoc (bool p0)
		{
			if (id_setLoc_Z == IntPtr.Zero)
				id_setLoc_Z = JNIEnv.GetStaticMethodID (class_ref, "setLoc", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLoc_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
		public virtual unsafe void SetLocation (global::Android.Locations.Location p0)
		{
			if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setR_floor_F;
#pragma warning disable 0169
		static Delegate GetSetR_floor_FHandler ()
		{
			if (cb_setR_floor_F == null)
				cb_setR_floor_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetR_floor_F);
			return cb_setR_floor_F;
		}

		static void n_SetR_floor_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetR_floor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setR_floor_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setR_floor' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setR_floor", "(F)V", "GetSetR_floor_FHandler")]
		public virtual unsafe void SetR_floor (float p0)
		{
			if (id_setR_floor_F == IntPtr.Zero)
				id_setR_floor_F = JNIEnv.GetMethodID (class_ref, "setR_floor", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setR_floor_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setR_floor", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRefresh_I;
#pragma warning disable 0169
		static Delegate GetSetRefresh_IHandler ()
		{
			if (cb_setRefresh_I == null)
				cb_setRefresh_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRefresh_I);
			return cb_setRefresh_I;
		}

		static void n_SetRefresh_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRefresh (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRefresh_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setRefresh' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRefresh", "(I)V", "GetSetRefresh_IHandler")]
		public virtual unsafe void SetRefresh (int p0)
		{
			if (id_setRefresh_I == IntPtr.Zero)
				id_setRefresh_I = JNIEnv.GetMethodID (class_ref, "setRefresh", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRefresh_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRefresh", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRt_Ljava_lang_String_Handler ()
		{
			if (cb_setRt_Ljava_lang_String_ == null)
				cb_setRt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRt_Ljava_lang_String_);
			return cb_setRt_Ljava_lang_String_;
		}

		static void n_SetRt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setRt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRt", "(Ljava/lang/String;)V", "GetSetRt_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRt (string p0)
		{
			if (id_setRt_Ljava_lang_String_ == IntPtr.Zero)
				id_setRt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRt", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRt_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRt", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setSecure_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setSecure' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSkip (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSkip_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setSkip' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setSmart_Z;
#pragma warning disable 0169
		static Delegate GetSetSmart_ZHandler ()
		{
			if (cb_setSmart_Z == null)
				cb_setSmart_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSmart_Z);
			return cb_setSmart_Z;
		}

		static void n_SetSmart_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSmart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSmart_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setSmart' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSmart", "(Z)V", "GetSetSmart_ZHandler")]
		public virtual unsafe void SetSmart (bool p0)
		{
			if (id_setSmart_Z == IntPtr.Zero)
				id_setSmart_Z = JNIEnv.GetMethodID (class_ref, "setSmart", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmart_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmart", "(Z)V"), __args);
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
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStart_muted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStart_muted_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setStart_muted' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setUp;
#pragma warning disable 0169
		static Delegate GetSetUpHandler ()
		{
			if (cb_setUp == null)
				cb_setUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetUp);
			return cb_setUp;
		}

		static void n_SetUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUp ();
		}
#pragma warning restore 0169

		static IntPtr id_setUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setUp' and count(parameter)=0]"
		[Register ("setUp", "()V", "GetSetUpHandler")]
		protected virtual unsafe void SetUp ()
		{
			if (id_setUp == IntPtr.Zero)
				id_setUp = JNIEnv.GetMethodID (class_ref, "setUp", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUp);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUp", "()V"));
			} finally {
			}
		}

		static Delegate cb_setV_dur_max_I;
#pragma warning disable 0169
		static Delegate GetSetV_dur_max_IHandler ()
		{
			if (cb_setV_dur_max_I == null)
				cb_setV_dur_max_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetV_dur_max_I);
			return cb_setV_dur_max_I;
		}

		static void n_SetV_dur_max_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetV_dur_max (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setV_dur_max_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setV_dur_max' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setV_dur_max", "(I)V", "GetSetV_dur_max_IHandler")]
		public virtual unsafe void SetV_dur_max (int p0)
		{
			if (id_setV_dur_max_I == IntPtr.Zero)
				id_setV_dur_max_I = JNIEnv.GetMethodID (class_ref, "setV_dur_max", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setV_dur_max_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setV_dur_max", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setV_dur_min_I;
#pragma warning disable 0169
		static Delegate GetSetV_dur_min_IHandler ()
		{
			if (cb_setV_dur_min_I == null)
				cb_setV_dur_min_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetV_dur_min_I);
			return cb_setV_dur_min_I;
		}

		static void n_SetV_dur_min_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetV_dur_min (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setV_dur_min_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='setV_dur_min' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setV_dur_min", "(I)V", "GetSetV_dur_min_IHandler")]
		public virtual unsafe void SetV_dur_min (int p0)
		{
			if (id_setV_dur_min_I == IntPtr.Zero)
				id_setV_dur_min_I = JNIEnv.GetMethodID (class_ref, "setV_dur_min", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setV_dur_min_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setV_dur_min", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_show_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_view_View_Handler ()
		{
			if (cb_show_Landroid_view_View_ == null)
				cb_show_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Show_Landroid_view_View_);
			return cb_show_Landroid_view_View_;
		}

		static void n_Show_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mobfox.Sdk.Bannerads.Banner __this = global::Java.Lang.Object.GetObject<global::Com.Mobfox.Sdk.Bannerads.Banner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0);
		}
#pragma warning restore 0169

		static IntPtr id_show_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("show", "(Landroid/view/View;)V", "GetShow_Landroid_view_View_Handler")]
		protected virtual unsafe void Show (global::Android.Views.View p0)
		{
			if (id_show_Landroid_view_View_ == IntPtr.Zero)
				id_show_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "show", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_warmUp_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mobfox.sdk.bannerads']/class[@name='Banner']/method[@name='warmUp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("warmUp", "(Landroid/content/Context;)V", "")]
		public static unsafe void WarmUp (global::Android.Content.Context p0)
		{
			if (id_warmUp_Landroid_content_Context_ == IntPtr.Zero)
				id_warmUp_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "warmUp", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warmUp_Landroid_content_Context_, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mobfox.Sdk.Bannerads.IBannerListener"

		global::Com.Mobfox.Sdk.Bannerads.IBannerListenerImplementor __CreateIBannerListenerImplementor ()
		{
			return new global::Com.Mobfox.Sdk.Bannerads.IBannerListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener"
		public event EventHandler<global::Com.Mobfox.Sdk.Webview.AdResponseEventArgs> AdResponse {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor___SetLoadAdListener,
						__CreateIMobFoxWebViewLoadAdListenerImplementor,
						__v => LoadAdListener = __v,
						__h => __h.OnAdResponseHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor___SetLoadAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor.__IsEmpty,
						__v => LoadAdListener = null,
						__h => __h.OnAdResponseHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.LoadAdEventArgs> onLoadAdError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor___SetLoadAdListener,
						__CreateIMobFoxWebViewLoadAdListenerImplementor,
						__v => LoadAdListener = __v,
						__h => __h.onLoadAdErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor___SetLoadAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor.__IsEmpty,
						__v => LoadAdListener = null,
						__h => __h.onLoadAdErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mobfox.Sdk.Webview.NoAdEventArgs> NoAd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor___SetLoadAdListener,
						__CreateIMobFoxWebViewLoadAdListenerImplementor,
						__v => LoadAdListener = __v,
						__h => __h.OnNoAdHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListener, global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor>(
						ref weak_implementor___SetLoadAdListener,
						global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor.__IsEmpty,
						__v => LoadAdListener = null,
						__h => __h.OnNoAdHandler -= value);
			}
		}

		WeakReference weak_implementor___SetLoadAdListener;

		global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor __CreateIMobFoxWebViewLoadAdListenerImplementor ()
		{
			return new global::Com.Mobfox.Sdk.Webview.IMobFoxWebViewLoadAdListenerImplementor (this);
		}
#endregion
	}
}
