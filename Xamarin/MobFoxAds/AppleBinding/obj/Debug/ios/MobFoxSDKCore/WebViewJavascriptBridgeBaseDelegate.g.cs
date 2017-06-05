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
	[Protocol (Name = "WebViewJavascriptBridgeBaseDelegate", WrapperType = typeof (WebViewJavascriptBridgeBaseDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "_evaluateJavascript", Selector = "_evaluateJavascript:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface IWebViewJavascriptBridgeBaseDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("_evaluateJavascript:")]
		[Preserve (Conditional = true)]
		string _evaluateJavascript (string javascriptCommand);
		
	}
	
	internal sealed class WebViewJavascriptBridgeBaseDelegateWrapper : BaseWrapper, IWebViewJavascriptBridgeBaseDelegate {
		[Preserve (Conditional = true)]
		public WebViewJavascriptBridgeBaseDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("_evaluateJavascript:")]
		[CompilerGenerated]
		public string _evaluateJavascript (string javascriptCommand)
		{
			if (javascriptCommand == null)
				throw new ArgumentNullException ("javascriptCommand");
			var nsjavascriptCommand = NSString.CreateNative (javascriptCommand);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("_evaluateJavascript:"), nsjavascriptCommand));
			NSString.ReleaseNative (nsjavascriptCommand);
			
			return ret;
		}
		
	}
}
namespace MobFoxSDKCore {
	[Protocol]
	[Register("WebViewJavascriptBridgeBaseDelegate", false)]
	[Model]
	public unsafe abstract partial class WebViewJavascriptBridgeBaseDelegate : NSObject, IWebViewJavascriptBridgeBaseDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected WebViewJavascriptBridgeBaseDelegate () : base (NSObjectFlag.Empty)
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
		protected WebViewJavascriptBridgeBaseDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WebViewJavascriptBridgeBaseDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("_evaluateJavascript:")]
		[CompilerGenerated]
		public abstract string _evaluateJavascript (string javascriptCommand);
	} /* class WebViewJavascriptBridgeBaseDelegate */
}
