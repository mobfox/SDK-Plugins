using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Github.Lzyzsd.Jsbridge {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']"
	[global::Android.Runtime.Register ("com/github/lzyzsd/jsbridge/BridgeUtil", DoNotGenerateAcw=true)]
	public partial class BridgeUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='CALLBACK_ID_FORMAT']"
		[Register ("CALLBACK_ID_FORMAT")]
		public const string CallbackIdFormat = (string) "JAVA_CB_%s";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='EMPTY_STR']"
		[Register ("EMPTY_STR")]
		public const string EmptyStr = (string) "";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='JAVASCRIPT_STR']"
		[Register ("JAVASCRIPT_STR")]
		public const string JavascriptStr = (string) "javascript:";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='JS_FETCH_QUEUE_FROM_JAVA']"
		[Register ("JS_FETCH_QUEUE_FROM_JAVA")]
		public const string JsFetchQueueFromJava = (string) "javascript:WebViewJavascriptBridge._fetchQueue();";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='JS_HANDLE_MESSAGE_FROM_JAVA']"
		[Register ("JS_HANDLE_MESSAGE_FROM_JAVA")]
		public const string JsHandleMessageFromJava = (string) "javascript:WebViewJavascriptBridge._handleMessageFromNative('%s');";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='SPLIT_MARK']"
		[Register ("SPLIT_MARK")]
		public const string SplitMark = (string) "/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='UNDERLINE_STR']"
		[Register ("UNDERLINE_STR")]
		public const string UnderlineStr = (string) "_";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='YY_FETCH_QUEUE']"
		[Register ("YY_FETCH_QUEUE")]
		public const string YyFetchQueue = (string) "yy://return/_fetchQueue/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='YY_OVERRIDE_SCHEMA']"
		[Register ("YY_OVERRIDE_SCHEMA")]
		public const string YyOverrideSchema = (string) "yy://";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/field[@name='YY_RETURN_DATA']"
		[Register ("YY_RETURN_DATA")]
		public const string YyReturnData = (string) "yy://return/";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/github/lzyzsd/jsbridge/BridgeUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BridgeUtil); }
		}

		protected BridgeUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/constructor[@name='BridgeUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BridgeUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BridgeUtil)) {
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

		static IntPtr id_assetFile2Str_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/method[@name='assetFile2Str' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("assetFile2Str", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AssetFile2Str (global::Android.Content.Context p0, string p1)
		{
			if (id_assetFile2Str_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_assetFile2Str_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "assetFile2Str", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_assetFile2Str_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getDataFromReturnUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/method[@name='getDataFromReturnUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDataFromReturnUrl", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetDataFromReturnUrl (string p0)
		{
			if (id_getDataFromReturnUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_getDataFromReturnUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDataFromReturnUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDataFromReturnUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFunctionFromReturnUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/method[@name='getFunctionFromReturnUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFunctionFromReturnUrl", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFunctionFromReturnUrl (string p0)
		{
			if (id_getFunctionFromReturnUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_getFunctionFromReturnUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFunctionFromReturnUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFunctionFromReturnUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseFunctionName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/method[@name='parseFunctionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseFunctionName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ParseFunctionName (string p0)
		{
			if (id_parseFunctionName_Ljava_lang_String_ == IntPtr.Zero)
				id_parseFunctionName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseFunctionName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFunctionName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_webViewLoadJs_Landroid_webkit_WebView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/method[@name='webViewLoadJs' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("webViewLoadJs", "(Landroid/webkit/WebView;Ljava/lang/String;)V", "")]
		public static unsafe void WebViewLoadJs (global::Android.Webkit.WebView p0, string p1)
		{
			if (id_webViewLoadJs_Landroid_webkit_WebView_Ljava_lang_String_ == IntPtr.Zero)
				id_webViewLoadJs_Landroid_webkit_WebView_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "webViewLoadJs", "(Landroid/webkit/WebView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_webViewLoadJs_Landroid_webkit_WebView_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_webViewLoadLocalJs_Landroid_webkit_WebView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.lzyzsd.jsbridge']/class[@name='BridgeUtil']/method[@name='webViewLoadLocalJs' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("webViewLoadLocalJs", "(Landroid/webkit/WebView;Ljava/lang/String;)V", "")]
		public static unsafe void WebViewLoadLocalJs (global::Android.Webkit.WebView p0, string p1)
		{
			if (id_webViewLoadLocalJs_Landroid_webkit_WebView_Ljava_lang_String_ == IntPtr.Zero)
				id_webViewLoadLocalJs_Landroid_webkit_WebView_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "webViewLoadLocalJs", "(Landroid/webkit/WebView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_webViewLoadLocalJs_Landroid_webkit_WebView_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
