using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Lzyzsd.Jsbridge {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']"
	[global::Android.Runtime.Register ("com/github/lzyzsd/jsbridge/BridgeWebView", DoNotGenerateAcw=true)]
	public partial class BridgeWebView : global::Android.Webkit.WebView, global::Com.Github.Lzyzsd.Jsbridge.IWebViewJavascriptBridge {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/field[@name='toLoadJs']"
		[Register ("toLoadJs")]
		public const string ToLoadJs = (string) "WebViewJavascriptBridge.js";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/lzyzsd/jsbridge/BridgeWebView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BridgeWebView); }
		}

		protected BridgeWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/constructor[@name='BridgeWebView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BridgeWebView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (BridgeWebView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/constructor[@name='BridgeWebView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BridgeWebView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BridgeWebView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/constructor[@name='BridgeWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BridgeWebView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BridgeWebView)) {
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

		static Delegate cb_getMessageHandlers;
#pragma warning disable 0169
		static Delegate GetGetMessageHandlersHandler ()
		{
			if (cb_getMessageHandlers == null)
				cb_getMessageHandlers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageHandlers);
			return cb_getMessageHandlers;
		}

		static IntPtr n_GetMessageHandlers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler>.ToLocalJniHandle (__this.MessageHandlers);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageHandlers;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler> MessageHandlers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='getMessageHandlers' and count(parameter)=0]"
			[Register ("getMessageHandlers", "()Ljava/util/Map;", "GetGetMessageHandlersHandler")]
			get {
				if (id_getMessageHandlers == IntPtr.Zero)
					id_getMessageHandlers = JNIEnv.GetMethodID (class_ref, "getMessageHandlers", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageHandlers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageHandlers", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartupMessage;
#pragma warning disable 0169
		static Delegate GetGetStartupMessageHandler ()
		{
			if (cb_getStartupMessage == null)
				cb_getStartupMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartupMessage);
			return cb_getStartupMessage;
		}

		static IntPtr n_GetStartupMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Github.Lzyzsd.Jsbridge.Message>.ToLocalJniHandle (__this.StartupMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setStartupMessage_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetStartupMessage_Ljava_util_List_Handler ()
		{
			if (cb_setStartupMessage_Ljava_util_List_ == null)
				cb_setStartupMessage_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartupMessage_Ljava_util_List_);
			return cb_setStartupMessage_Ljava_util_List_;
		}

		static void n_SetStartupMessage_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Github.Lzyzsd.Jsbridge.Message>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartupMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStartupMessage;
		static IntPtr id_setStartupMessage_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Github.Lzyzsd.Jsbridge.Message> StartupMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='getStartupMessage' and count(parameter)=0]"
			[Register ("getStartupMessage", "()Ljava/util/List;", "GetGetStartupMessageHandler")]
			get {
				if (id_getStartupMessage == IntPtr.Zero)
					id_getStartupMessage = JNIEnv.GetMethodID (class_ref, "getStartupMessage", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Github.Lzyzsd.Jsbridge.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStartupMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Github.Lzyzsd.Jsbridge.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartupMessage", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='setStartupMessage' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.lzyzsd.jsbridge.Message&gt;']]"
			[Register ("setStartupMessage", "(Ljava/util/List;)V", "GetSetStartupMessage_Ljava_util_List_Handler")]
			set {
				if (id_setStartupMessage_Ljava_util_List_ == IntPtr.Zero)
					id_setStartupMessage_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setStartupMessage", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Github.Lzyzsd.Jsbridge.Message>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStartupMessage_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartupMessage", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_callHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
#pragma warning disable 0169
		static Delegate GetCallHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler ()
		{
			if (cb_callHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == null)
				cb_callHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CallHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_);
			return cb_callHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		}

		static void n_CallHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p2 = (global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction)global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CallHandler (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_callHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='callHandler' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.github.lzyzsd.jsbridge.CallBackFunction']]"
		[Register ("callHandler", "(Ljava/lang/String;Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V", "GetCallHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler")]
		public virtual unsafe void CallHandler (string p0, string p1, global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p2)
		{
			if (id_callHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == IntPtr.Zero)
				id_callHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNIEnv.GetMethodID (class_ref, "callHandler", "(Ljava/lang/String;Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callHandler_Ljava_lang_String_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "callHandler", "(Ljava/lang/String;Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_generateBridgeWebViewClient;
#pragma warning disable 0169
		static Delegate GetGenerateBridgeWebViewClientHandler ()
		{
			if (cb_generateBridgeWebViewClient == null)
				cb_generateBridgeWebViewClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenerateBridgeWebViewClient);
			return cb_generateBridgeWebViewClient;
		}

		static IntPtr n_GenerateBridgeWebViewClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenerateBridgeWebViewClient ());
		}
#pragma warning restore 0169

		static IntPtr id_generateBridgeWebViewClient;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='generateBridgeWebViewClient' and count(parameter)=0]"
		[Register ("generateBridgeWebViewClient", "()Lcom/github/lzyzsd/jsbridge/BridgeWebViewClient;", "GetGenerateBridgeWebViewClientHandler")]
		protected virtual unsafe global::Com.Github.Lzyzsd.Jsbridge.BridgeWebViewClient GenerateBridgeWebViewClient ()
		{
			if (id_generateBridgeWebViewClient == IntPtr.Zero)
				id_generateBridgeWebViewClient = JNIEnv.GetMethodID (class_ref, "generateBridgeWebViewClient", "()Lcom/github/lzyzsd/jsbridge/BridgeWebViewClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebViewClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateBridgeWebViewClient), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebViewClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateBridgeWebViewClient", "()Lcom/github/lzyzsd/jsbridge/BridgeWebViewClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_loadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
#pragma warning disable 0169
		static Delegate GetLoadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler ()
		{
			if (cb_loadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == null)
				cb_loadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_);
			return cb_loadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		}

		static void n_LoadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1 = (global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction)global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='loadUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.github.lzyzsd.jsbridge.CallBackFunction']]"
		[Register ("loadUrl", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V", "GetLoadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler")]
		public virtual unsafe void LoadUrl (string p0, global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1)
		{
			if (id_loadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == IntPtr.Zero)
				id_loadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNIEnv.GetMethodID (class_ref, "loadUrl", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadUrl_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadUrl", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_;
#pragma warning disable 0169
		static Delegate GetRegisterHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_Handler ()
		{
			if (cb_registerHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ == null)
				cb_registerHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_);
			return cb_registerHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_;
		}

		static void n_RegisterHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler p1 = (global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler)global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterHandler (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_registerHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='registerHandler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.github.lzyzsd.jsbridge.BridgeHandler']]"
		[Register ("registerHandler", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/BridgeHandler;)V", "GetRegisterHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_Handler")]
		public virtual unsafe void RegisterHandler (string p0, global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler p1)
		{
			if (id_registerHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ == IntPtr.Zero)
				id_registerHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ = JNIEnv.GetMethodID (class_ref, "registerHandler", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/BridgeHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerHandler_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_BridgeHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerHandler", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/BridgeHandler;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_send_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Handler ()
		{
			if (cb_send_Ljava_lang_String_ == null)
				cb_send_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_);
			return cb_send_Ljava_lang_String_;
		}

		static void n_Send_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler")]
		public virtual unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler ()
		{
			if (cb_send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == null)
				cb_send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_);
			return cb_send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		}

		static void n_Send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1 = (global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction)global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='send' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.github.lzyzsd.jsbridge.CallBackFunction']]"
		[Register ("send", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V", "GetSend_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_Handler")]
		public virtual unsafe void Send (string p0, global::Com.Github.Lzyzsd.Jsbridge.ICallBackFunction p1)
		{
			if (id_send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ == IntPtr.Zero)
				id_send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_Lcom_github_lzyzsd_jsbridge_CallBackFunction_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/lang/String;Lcom/github/lzyzsd/jsbridge/CallBackFunction;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_;
#pragma warning disable 0169
		static Delegate GetSetDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_Handler ()
		{
			if (cb_setDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ == null)
				cb_setDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_);
			return cb_setDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_;
		}

		static void n_SetDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.BridgeWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler p0 = (global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler)global::Java.Lang.Object.GetObject<global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultHandler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeWebView']/method[@name='setDefaultHandler' and count(parameter)=1 and parameter[1][@type='com.github.lzyzsd.jsbridge.BridgeHandler']]"
		[Register ("setDefaultHandler", "(Lcom/github/lzyzsd/jsbridge/BridgeHandler;)V", "GetSetDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_Handler")]
		public virtual unsafe void SetDefaultHandler (global::Com.Github.Lzyzsd.Jsbridge.IBridgeHandler p0)
		{
			if (id_setDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ == IntPtr.Zero)
				id_setDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_ = JNIEnv.GetMethodID (class_ref, "setDefaultHandler", "(Lcom/github/lzyzsd/jsbridge/BridgeHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultHandler_Lcom_github_lzyzsd_jsbridge_BridgeHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultHandler", "(Lcom/github/lzyzsd/jsbridge/BridgeHandler;)V"), __args);
			} finally {
			}
		}

	}
}
