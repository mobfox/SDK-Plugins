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
	[Protocol (Name = "MobFoxNativeCustomEventDelegate", WrapperType = typeof (MobFoxNativeCustomEventDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFNativeCustomEventAd", Selector = "MFNativeCustomEventAd:didLoad:", ParameterType = new Type [] { typeof (MobFoxSDKCore.MobFoxNativeCustomEvent), typeof (MobFoxSDKCore.MobFoxNativeData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MFNativeCustomEventAdDidFailToReceiveAdWithError", Selector = "MFNativeCustomEventAdDidFailToReceiveAdWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public interface IMobFoxNativeCustomEventDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("MFNativeCustomEventAd:didLoad:")]
		[Preserve (Conditional = true)]
		void MFNativeCustomEventAd (MobFoxNativeCustomEvent @event, MobFoxNativeData adData);
		
		[CompilerGenerated]
		[Export ("MFNativeCustomEventAdDidFailToReceiveAdWithError:")]
		[Preserve (Conditional = true)]
		void MFNativeCustomEventAdDidFailToReceiveAdWithError (NSError error);
		
	}
	
	internal sealed class MobFoxNativeCustomEventDelegateWrapper : BaseWrapper, IMobFoxNativeCustomEventDelegate {
		[Preserve (Conditional = true)]
		public MobFoxNativeCustomEventDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("MFNativeCustomEventAd:didLoad:")]
		[CompilerGenerated]
		public void MFNativeCustomEventAd (MobFoxNativeCustomEvent @event, MobFoxNativeData adData)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			if (adData == null)
				throw new ArgumentNullException ("adData");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("MFNativeCustomEventAd:didLoad:"), @event.Handle, adData.Handle);
		}
		
		[Export ("MFNativeCustomEventAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public void MFNativeCustomEventAdDidFailToReceiveAdWithError (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("MFNativeCustomEventAdDidFailToReceiveAdWithError:"), error.Handle);
		}
		
	}
}
namespace MobFoxSDKCore {
	[Protocol]
	[Register("MobFoxNativeCustomEventDelegate", false)]
	[Model]
	public unsafe abstract partial class MobFoxNativeCustomEventDelegate : NSObject, IMobFoxNativeCustomEventDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MobFoxNativeCustomEventDelegate () : base (NSObjectFlag.Empty)
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
		protected MobFoxNativeCustomEventDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobFoxNativeCustomEventDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("MFNativeCustomEventAd:didLoad:")]
		[CompilerGenerated]
		public abstract void MFNativeCustomEventAd (MobFoxNativeCustomEvent @event, MobFoxNativeData adData);
		[Export ("MFNativeCustomEventAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public abstract void MFNativeCustomEventAdDidFailToReceiveAdWithError (NSError error);
	} /* class MobFoxNativeCustomEventDelegate */
}
