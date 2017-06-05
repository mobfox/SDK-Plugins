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
	[Protocol (Name = "MobFoxNativeAdDelegate", WrapperType = typeof (MobFoxNativeAdDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MobFoxNativeAdDidLoad", Selector = "MobFoxNativeAdDidLoad:withAdData:", ParameterType = new Type [] { typeof (MobFoxSDKCore.MobFoxNativeAd), typeof (MobFoxSDKCore.MobFoxNativeData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxNativeAdDidFailToReceiveAdWithError", Selector = "MobFoxNativeAdDidFailToReceiveAdWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	public interface IMobFoxNativeAdDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("MobFoxNativeAdDidLoad:withAdData:")]
		[Preserve (Conditional = true)]
		void MobFoxNativeAdDidLoad (MobFoxNativeAd ad, MobFoxNativeData adData);
		
	}
	
	public static partial class MobFoxNativeAdDelegate_Extensions {
		[CompilerGenerated]
		public static void MobFoxNativeAdDidFailToReceiveAdWithError (this IMobFoxNativeAdDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("MobFoxNativeAdDidFailToReceiveAdWithError:"), error.Handle);
		}
		
	}
	
	internal sealed class MobFoxNativeAdDelegateWrapper : BaseWrapper, IMobFoxNativeAdDelegate {
		[Preserve (Conditional = true)]
		public MobFoxNativeAdDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("MobFoxNativeAdDidLoad:withAdData:")]
		[CompilerGenerated]
		public void MobFoxNativeAdDidLoad (MobFoxNativeAd ad, MobFoxNativeData adData)
		{
			if (ad == null)
				throw new ArgumentNullException ("ad");
			if (adData == null)
				throw new ArgumentNullException ("adData");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("MobFoxNativeAdDidLoad:withAdData:"), ad.Handle, adData.Handle);
		}
		
	}
}
namespace MobFoxSDKCore {
	[Protocol]
	[Register("MobFoxNativeAdDelegate", false)]
	[Model]
	public unsafe abstract partial class MobFoxNativeAdDelegate : NSObject, IMobFoxNativeAdDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MobFoxNativeAdDelegate () : base (NSObjectFlag.Empty)
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
		protected MobFoxNativeAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobFoxNativeAdDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("MobFoxNativeAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public virtual void MobFoxNativeAdDidFailToReceiveAdWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxNativeAdDidLoad:withAdData:")]
		[CompilerGenerated]
		public abstract void MobFoxNativeAdDidLoad (MobFoxNativeAd ad, MobFoxNativeData adData);
	} /* class MobFoxNativeAdDelegate */
}
