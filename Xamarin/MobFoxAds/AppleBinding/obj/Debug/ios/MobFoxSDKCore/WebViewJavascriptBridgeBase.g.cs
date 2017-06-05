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
	[Register("WebViewJavascriptBridgeBase", true)]
	public unsafe partial class WebViewJavascriptBridgeBase : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WebViewJavascriptBridgeBase");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WebViewJavascriptBridgeBase () : base (NSObjectFlag.Empty)
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
		protected WebViewJavascriptBridgeBase (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WebViewJavascriptBridgeBase (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		
		[Export ("flushMessageQueue:")]
		[CompilerGenerated]
		public virtual void FlushMessageQueue (string messageQueueString)
		{
			if (messageQueueString == null)
				throw new ArgumentNullException ("messageQueueString");
			var nsmessageQueueString = NSString.CreateNative (messageQueueString);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("flushMessageQueue:"), nsmessageQueueString);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("flushMessageQueue:"), nsmessageQueueString);
			}
			NSString.ReleaseNative (nsmessageQueueString);
			
		}
		
		[Export ("injectJavascriptFile")]
		[CompilerGenerated]
		public virtual void InjectJavascriptFile ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("injectJavascriptFile"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("injectJavascriptFile"));
			}
		}
		
		[Export ("isBridgeLoadedURL:")]
		[CompilerGenerated]
		public virtual bool IsBridgeLoadedURL (NSUrl urll)
		{
			if (urll == null)
				throw new ArgumentNullException ("urll");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isBridgeLoadedURL:"), urll.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isBridgeLoadedURL:"), urll.Handle);
			}
		}
		
		[Export ("isCorrectProcotocolScheme:")]
		[CompilerGenerated]
		public virtual bool IsCorrectProcotocolScheme (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isCorrectProcotocolScheme:"), url.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isCorrectProcotocolScheme:"), url.Handle);
			}
		}
		
		[Export ("isQueueMessageURL:")]
		[CompilerGenerated]
		public virtual bool IsQueueMessageURL (NSUrl urll)
		{
			if (urll == null)
				throw new ArgumentNullException ("urll");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isQueueMessageURL:"), urll.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isQueueMessageURL:"), urll.Handle);
			}
		}
		
		[Export ("logUnkownMessage:")]
		[CompilerGenerated]
		public virtual void LogUnkownMessage (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("logUnkownMessage:"), url.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("logUnkownMessage:"), url.Handle);
			}
		}
		
		[Export ("reset")]
		[CompilerGenerated]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reset"));
			}
		}
		
		[Export ("sendData:responseCallback:handlerName:")]
		[CompilerGenerated]
		public unsafe virtual void SendData (NSObject data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWVJBResponseCallback))]WVJBResponseCallback responseCallback, string handlerName)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (responseCallback == null)
				throw new ArgumentNullException ("responseCallback");
			if (handlerName == null)
				throw new ArgumentNullException ("handlerName");
			BlockLiteral *block_ptr_responseCallback;
			BlockLiteral block_responseCallback;
			block_responseCallback = new BlockLiteral ();
			block_ptr_responseCallback = &block_responseCallback;
			block_responseCallback.SetupBlock (Trampolines.SDWVJBResponseCallback.Handler, responseCallback);
			var nshandlerName = NSString.CreateNative (handlerName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendData:responseCallback:handlerName:"), data.Handle, (IntPtr) block_ptr_responseCallback, nshandlerName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendData:responseCallback:handlerName:"), data.Handle, (IntPtr) block_ptr_responseCallback, nshandlerName);
			}
			block_ptr_responseCallback->CleanupBlock ();
			NSString.ReleaseNative (nshandlerName);
			
		}
		
		[Export ("setLogMaxLength:")]
		[CompilerGenerated]
		public static void SetLogMaxLength (int length)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setLogMaxLength:"), length);
		}
		
		[CompilerGenerated]
		public WebViewJavascriptBridgeBaseDelegate Delegate {
			get {
				return WeakDelegate as WebViewJavascriptBridgeBaseDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public unsafe virtual WVJBHandler MessageHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDWVJBHandler))]
			[Export ("messageHandler", ArgumentSemantic.Retain)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageHandler"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageHandler"));
				}
				return global::ObjCRuntime.Trampolines.NIDWVJBHandler.Create (ret);
			}
			
			[Export ("setMessageHandler:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDWVJBHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageHandler:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageHandler:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSMutableDictionary MessageHandlers {
			[Export ("messageHandlers", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageHandlers")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageHandlers")));
				}
				return ret;
			}
			
			[Export ("setMessageHandlers:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageHandlers:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageHandlers:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSMutableDictionary ResponseCallbacks {
			[Export ("responseCallbacks", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responseCallbacks")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseCallbacks")));
				}
				return ret;
			}
			
			[Export ("setResponseCallbacks:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setResponseCallbacks:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setResponseCallbacks:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSMutableArray StartupMessageQueue {
			[Export ("startupMessageQueue", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("startupMessageQueue")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startupMessageQueue")));
				}
				return ret;
			}
			
			[Export ("setStartupMessageQueue:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStartupMessageQueue:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStartupMessageQueue:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string WebViewJavascriptCheckCommand {
			[Export ("webViewJavascriptCheckCommand")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("webViewJavascriptCheckCommand")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("webViewJavascriptCheckCommand")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string WebViewJavascriptFetchQueyCommand {
			[Export ("webViewJavascriptFetchQueyCommand")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("webViewJavascriptFetchQueyCommand")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("webViewJavascriptFetchQueyCommand")));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class WebViewJavascriptBridgeBase */
}
