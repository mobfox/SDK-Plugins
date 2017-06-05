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
	[Protocol (Name = "MobFoxInterstitialCustomEventDelegate", WrapperType = typeof (MobFoxInterstitialCustomEventDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFInterstitialCustomEventAdDidLoad", Selector = "MFInterstitialCustomEventAdDidLoad:", ParameterType = new Type [] { typeof (MobFoxSDKCore.MobFoxInterstitialCustomEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFInterstitialCustomEventAdDidFailToReceiveAdWithError", Selector = "MFInterstitialCustomEventAdDidFailToReceiveAdWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFInterstitialCustomEventAdClosed", Selector = "MFInterstitialCustomEventAdClosed")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFInterstitialCustomEventMobFoxAdClicked", Selector = "MFInterstitialCustomEventMobFoxAdClicked")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFInterstitialCustomEventMobFoxAdFinished", Selector = "MFInterstitialCustomEventMobFoxAdFinished")]
	public interface IMobFoxInterstitialCustomEventDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("MFInterstitialCustomEventAdDidLoad:")]
		[Preserve (Conditional = true)]
		void MFInterstitialCustomEventAdDidLoad (MobFoxInterstitialCustomEvent @event);
		
		[CompilerGenerated]
		[Export ("MFInterstitialCustomEventAdDidFailToReceiveAdWithError:")]
		[Preserve (Conditional = true)]
		void MFInterstitialCustomEventAdDidFailToReceiveAdWithError (NSError error);
		
		[CompilerGenerated]
		[Export ("MFInterstitialCustomEventAdClosed")]
		[Preserve (Conditional = true)]
		void MFInterstitialCustomEventAdClosed ();
		
		[CompilerGenerated]
		[Export ("MFInterstitialCustomEventMobFoxAdClicked")]
		[Preserve (Conditional = true)]
		void MFInterstitialCustomEventMobFoxAdClicked ();
		
		[CompilerGenerated]
		[Export ("MFInterstitialCustomEventMobFoxAdFinished")]
		[Preserve (Conditional = true)]
		void MFInterstitialCustomEventMobFoxAdFinished ();
		
	}
	
	internal sealed class MobFoxInterstitialCustomEventDelegateWrapper : BaseWrapper, IMobFoxInterstitialCustomEventDelegate {
		[Preserve (Conditional = true)]
		public MobFoxInterstitialCustomEventDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("MFInterstitialCustomEventAdDidLoad:")]
		[CompilerGenerated]
		public void MFInterstitialCustomEventAdDidLoad (MobFoxInterstitialCustomEvent @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("MFInterstitialCustomEventAdDidLoad:"), @event.Handle);
		}
		
		[Export ("MFInterstitialCustomEventAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public void MFInterstitialCustomEventAdDidFailToReceiveAdWithError (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("MFInterstitialCustomEventAdDidFailToReceiveAdWithError:"), error.Handle);
		}
		
		[Export ("MFInterstitialCustomEventAdClosed")]
		[CompilerGenerated]
		public void MFInterstitialCustomEventAdClosed ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("MFInterstitialCustomEventAdClosed"));
		}
		
		[Export ("MFInterstitialCustomEventMobFoxAdClicked")]
		[CompilerGenerated]
		public void MFInterstitialCustomEventMobFoxAdClicked ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("MFInterstitialCustomEventMobFoxAdClicked"));
		}
		
		[Export ("MFInterstitialCustomEventMobFoxAdFinished")]
		[CompilerGenerated]
		public void MFInterstitialCustomEventMobFoxAdFinished ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("MFInterstitialCustomEventMobFoxAdFinished"));
		}
		
	}
}
namespace MobFoxSDKCore {
	[Protocol]
	[Register("MobFoxInterstitialCustomEventDelegate", false)]
	[Model]
	public unsafe abstract partial class MobFoxInterstitialCustomEventDelegate : NSObject, IMobFoxInterstitialCustomEventDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MobFoxInterstitialCustomEventDelegate () : base (NSObjectFlag.Empty)
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
		protected MobFoxInterstitialCustomEventDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobFoxInterstitialCustomEventDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("MFInterstitialCustomEventAdClosed")]
		[CompilerGenerated]
		public abstract void MFInterstitialCustomEventAdClosed ();
		[Export ("MFInterstitialCustomEventAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public abstract void MFInterstitialCustomEventAdDidFailToReceiveAdWithError (NSError error);
		[Export ("MFInterstitialCustomEventAdDidLoad:")]
		[CompilerGenerated]
		public abstract void MFInterstitialCustomEventAdDidLoad (MobFoxInterstitialCustomEvent @event);
		[Export ("MFInterstitialCustomEventMobFoxAdClicked")]
		[CompilerGenerated]
		public abstract void MFInterstitialCustomEventMobFoxAdClicked ();
		[Export ("MFInterstitialCustomEventMobFoxAdFinished")]
		[CompilerGenerated]
		public abstract void MFInterstitialCustomEventMobFoxAdFinished ();
	} /* class MobFoxInterstitialCustomEventDelegate */
}
