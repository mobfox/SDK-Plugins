//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace MobFoxSDKCore {
	[Register("MFWebViewJavascriptBridge", true)]
	public unsafe partial class MFWebViewJavascriptBridge : NSObject, global::UIKit.IUIWebViewDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MFWebViewJavascriptBridge");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MFWebViewJavascriptBridge () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MFWebViewJavascriptBridge (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MFWebViewJavascriptBridge (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("bridgeForWebView:")]
		[CompilerGenerated]
		public static MFWebViewJavascriptBridge BridgeForWebView (global::UIKit.UIWebView webView)
		{
			if (webView == null)
				throw new ArgumentNullException ("webView");
			return  Runtime.GetNSObject<MFWebViewJavascriptBridge> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("bridgeForWebView:"), webView.Handle));
		}
		
		[Export ("callHandler:")]
		[CompilerGenerated]
		public virtual void CallHandler (string handlerName)
		{
			if (handlerName == null)
				throw new ArgumentNullException ("handlerName");
			var nshandlerName = NSString.CreateNative (handlerName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("callHandler:"), nshandlerName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("callHandler:"), nshandlerName);
			}
			NSString.ReleaseNative (nshandlerName);
			
		}
		
		[Export ("callHandler:data:")]
		[CompilerGenerated]
		public virtual void CallHandler (string handlerName, NSObject data)
		{
			if (handlerName == null)
				throw new ArgumentNullException ("handlerName");
			if (data == null)
				throw new ArgumentNullException ("data");
			var nshandlerName = NSString.CreateNative (handlerName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("callHandler:data:"), nshandlerName, data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("callHandler:data:"), nshandlerName, data.Handle);
			}
			NSString.ReleaseNative (nshandlerName);
			
		}
		
		[Export ("callHandler:data:responseCallback:")]
		[CompilerGenerated]
		public unsafe virtual void CallHandler (string handlerName, NSObject data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWVJBResponseCallback))]WVJBResponseCallback responseCallback)
		{
			if (handlerName == null)
				throw new ArgumentNullException ("handlerName");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (responseCallback == null)
				throw new ArgumentNullException ("responseCallback");
			var nshandlerName = NSString.CreateNative (handlerName);
			BlockLiteral *block_ptr_responseCallback;
			BlockLiteral block_responseCallback;
			block_responseCallback = new BlockLiteral ();
			block_ptr_responseCallback = &block_responseCallback;
			block_responseCallback.SetupBlock (Trampolines.SDWVJBResponseCallback.Handler, responseCallback);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("callHandler:data:responseCallback:"), nshandlerName, data.Handle, (IntPtr) block_ptr_responseCallback);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("callHandler:data:responseCallback:"), nshandlerName, data.Handle, (IntPtr) block_ptr_responseCallback);
			}
			NSString.ReleaseNative (nshandlerName);
			block_ptr_responseCallback->CleanupBlock ();
			
		}
		
		[Export ("disableJavscriptAlertBoxSafetyTimeout")]
		[CompilerGenerated]
		public virtual void DisableJavscriptAlertBoxSafetyTimeout ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disableJavscriptAlertBoxSafetyTimeout"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableJavscriptAlertBoxSafetyTimeout"));
			}
		}
		
		[Export ("enableLogging")]
		[CompilerGenerated]
		public static void EnableLogging ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("enableLogging"));
		}
		
		[Export ("registerHandler:handler:")]
		[CompilerGenerated]
		public unsafe virtual void RegisterHandler (string handlerName, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWVJBHandler))]WVJBHandler handler)
		{
			if (handlerName == null)
				throw new ArgumentNullException ("handlerName");
			if (handler == null)
				throw new ArgumentNullException ("handler");
			var nshandlerName = NSString.CreateNative (handlerName);
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDWVJBHandler.Handler, handler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("registerHandler:handler:"), nshandlerName, (IntPtr) block_ptr_handler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("registerHandler:handler:"), nshandlerName, (IntPtr) block_ptr_handler);
			}
			NSString.ReleaseNative (nshandlerName);
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("setLogMaxLength:")]
		[CompilerGenerated]
		public static void SetLogMaxLength (int length)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setLogMaxLength:"), length);
		}
		
		[Export ("setWebViewDelegate:")]
		[CompilerGenerated]
		public virtual void SetWebViewDelegate (global::UIKit.UIWebViewDelegate webViewDelegate)
		{
			if (webViewDelegate == null)
				throw new ArgumentNullException ("webViewDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWebViewDelegate:"), webViewDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWebViewDelegate:"), webViewDelegate.Handle);
			}
		}
		
	} /* class MFWebViewJavascriptBridge */
}
