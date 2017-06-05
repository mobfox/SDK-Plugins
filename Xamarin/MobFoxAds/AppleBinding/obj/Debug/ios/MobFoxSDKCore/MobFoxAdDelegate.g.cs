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
	[Protocol (Name = "MobFoxAdDelegate", WrapperType = typeof (MobFoxAdDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxAdDidLoad", Selector = "MobFoxAdDidLoad:", ParameterType = new Type [] { typeof (MobFoxSDKCore.MobFoxAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxAdDidFailToReceiveAdWithError", Selector = "MobFoxAdDidFailToReceiveAdWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxAdClosed", Selector = "MobFoxAdClosed")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxAdClicked", Selector = "MobFoxAdClicked")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxAdFinished", Selector = "MobFoxAdFinished")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxDelegateCustomEvents", Selector = "MobFoxDelegateCustomEvents:withAdDict:", ParameterType = new Type [] { typeof (NSObject[]), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	public interface IMobFoxAdDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MobFoxAdDelegate_Extensions {
		[CompilerGenerated]
		public static void MobFoxAdDidLoad (this IMobFoxAdDelegate This, MobFoxAd banner)
		{
			if (banner == null)
				throw new ArgumentNullException ("banner");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("MobFoxAdDidLoad:"), banner.Handle);
		}
		
		[CompilerGenerated]
		public static void MobFoxAdDidFailToReceiveAdWithError (this IMobFoxAdDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("MobFoxAdDidFailToReceiveAdWithError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void MobFoxAdClosed (this IMobFoxAdDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MobFoxAdClosed"));
		}
		
		[CompilerGenerated]
		public static void MobFoxAdClicked (this IMobFoxAdDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MobFoxAdClicked"));
		}
		
		[CompilerGenerated]
		public static void MobFoxAdFinished (this IMobFoxAdDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MobFoxAdFinished"));
		}
		
		[CompilerGenerated]
		public static void MobFoxDelegateCustomEvents (this IMobFoxAdDelegate This, NSObject[] events, NSDictionary adDict)
		{
			if (events == null)
				throw new ArgumentNullException ("events");
			if (adDict == null)
				throw new ArgumentNullException ("adDict");
			var nsa_events = NSArray.FromNSObjects (events);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("MobFoxDelegateCustomEvents:withAdDict:"), nsa_events.Handle, adDict.Handle);
			nsa_events.Dispose ();
			
		}
		
	}
	
	internal sealed class MobFoxAdDelegateWrapper : BaseWrapper, IMobFoxAdDelegate {
		[Preserve (Conditional = true)]
		public MobFoxAdDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace MobFoxSDKCore {
	[Protocol]
	[Register("MobFoxAdDelegate", false)]
	[Model]
	public unsafe partial class MobFoxAdDelegate : NSObject, IMobFoxAdDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobFoxAdDelegate () : base (NSObjectFlag.Empty)
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
		protected MobFoxAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobFoxAdDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("MobFoxAdClicked")]
		[CompilerGenerated]
		public virtual void MobFoxAdClicked ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxAdClosed")]
		[CompilerGenerated]
		public virtual void MobFoxAdClosed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public virtual void MobFoxAdDidFailToReceiveAdWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxAdDidLoad:")]
		[CompilerGenerated]
		public virtual void MobFoxAdDidLoad (MobFoxAd banner)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxAdFinished")]
		[CompilerGenerated]
		public virtual void MobFoxAdFinished ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxDelegateCustomEvents:withAdDict:")]
		[CompilerGenerated]
		public virtual void MobFoxDelegateCustomEvents (NSObject[] events, NSDictionary adDict)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MobFoxAdDelegate */
}
