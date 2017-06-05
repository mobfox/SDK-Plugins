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
	[Protocol (Name = "MobFoxCustomEventDelegate", WrapperType = typeof (MobFoxCustomEventDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFCustomEventAd", Selector = "MFCustomEventAd:didLoad:", ParameterType = new Type [] { typeof (MobFoxSDKCore.MobFoxCustomEvent), typeof (UIView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFCustomEventAdDidFailToReceiveAdWithError", Selector = "MFCustomEventAdDidFailToReceiveAdWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MFCustomEventAdClosed", Selector = "MFCustomEventAdClosed")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MFCustomEventMobFoxAdClicked", Selector = "MFCustomEventMobFoxAdClicked")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MFCustomEventMobFoxAdFinished", Selector = "MFCustomEventMobFoxAdFinished")]
	public interface IMobFoxCustomEventDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("MFCustomEventAd:didLoad:")]
		[Preserve (Conditional = true)]
		void MFCustomEventAd (MobFoxCustomEvent @event, global::UIKit.UIView ad);
		
		[CompilerGenerated]
		[Export ("MFCustomEventAdDidFailToReceiveAdWithError:")]
		[Preserve (Conditional = true)]
		void MFCustomEventAdDidFailToReceiveAdWithError (NSError error);
		
	}
	
	public static partial class MobFoxCustomEventDelegate_Extensions {
		[CompilerGenerated]
		public static void MFCustomEventAdClosed (this IMobFoxCustomEventDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MFCustomEventAdClosed"));
		}
		
		[CompilerGenerated]
		public static void MFCustomEventMobFoxAdClicked (this IMobFoxCustomEventDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MFCustomEventMobFoxAdClicked"));
		}
		
		[CompilerGenerated]
		public static void MFCustomEventMobFoxAdFinished (this IMobFoxCustomEventDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MFCustomEventMobFoxAdFinished"));
		}
		
	}
	
	internal sealed class MobFoxCustomEventDelegateWrapper : BaseWrapper, IMobFoxCustomEventDelegate {
		[Preserve (Conditional = true)]
		public MobFoxCustomEventDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("MFCustomEventAd:didLoad:")]
		[CompilerGenerated]
		public void MFCustomEventAd (MobFoxCustomEvent @event, global::UIKit.UIView ad)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			if (ad == null)
				throw new ArgumentNullException ("ad");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("MFCustomEventAd:didLoad:"), @event.Handle, ad.Handle);
		}
		
		[Export ("MFCustomEventAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public void MFCustomEventAdDidFailToReceiveAdWithError (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("MFCustomEventAdDidFailToReceiveAdWithError:"), error.Handle);
		}
		
	}
}
namespace MobFoxSDKCore {
	[Protocol]
	[Register("MobFoxCustomEventDelegate", false)]
	[Model]
	public unsafe abstract partial class MobFoxCustomEventDelegate : NSObject, IMobFoxCustomEventDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MobFoxCustomEventDelegate () : base (NSObjectFlag.Empty)
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
		protected MobFoxCustomEventDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobFoxCustomEventDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("MFCustomEventAd:didLoad:")]
		[CompilerGenerated]
		public abstract void MFCustomEventAd (MobFoxCustomEvent @event, global::UIKit.UIView ad);
		[Export ("MFCustomEventAdClosed")]
		[CompilerGenerated]
		public virtual void MFCustomEventAdClosed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MFCustomEventAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public abstract void MFCustomEventAdDidFailToReceiveAdWithError (NSError error);
		[Export ("MFCustomEventMobFoxAdClicked")]
		[CompilerGenerated]
		public virtual void MFCustomEventMobFoxAdClicked ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MFCustomEventMobFoxAdFinished")]
		[CompilerGenerated]
		public virtual void MFCustomEventMobFoxAdFinished ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MobFoxCustomEventDelegate */
}
