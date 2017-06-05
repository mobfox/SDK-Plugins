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
	[Protocol (Name = "MobFoxInterstitialAdDelegate", WrapperType = typeof (MobFoxInterstitialAdDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MobFoxInterstitialAdDidLoad", Selector = "MobFoxInterstitialAdDidLoad:", ParameterType = new Type [] { typeof (MobFoxSDKCore.MobFoxInterstitialAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxInterstitialAdDidFailToReceiveAdWithError", Selector = "MobFoxInterstitialAdDidFailToReceiveAdWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxInterstitialAdWillShow", Selector = "MobFoxInterstitialAdWillShow:", ParameterType = new Type [] { typeof (MobFoxSDKCore.MobFoxInterstitialAd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxInterstitialAdClosed", Selector = "MobFoxInterstitialAdClosed")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxInterstitialAdClicked", Selector = "MobFoxInterstitialAdClicked")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MobFoxInterstitialAdFinished", Selector = "MobFoxInterstitialAdFinished")]
	public interface IMobFoxInterstitialAdDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("MobFoxInterstitialAdDidLoad:")]
		[Preserve (Conditional = true)]
		void MobFoxInterstitialAdDidLoad (MobFoxInterstitialAd interstitial);
		
	}
	
	public static partial class MobFoxInterstitialAdDelegate_Extensions {
		[CompilerGenerated]
		public static void MobFoxInterstitialAdDidFailToReceiveAdWithError (this IMobFoxInterstitialAdDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("MobFoxInterstitialAdDidFailToReceiveAdWithError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void MobFoxInterstitialAdWillShow (this IMobFoxInterstitialAdDelegate This, MobFoxInterstitialAd interstitial)
		{
			if (interstitial == null)
				throw new ArgumentNullException ("interstitial");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("MobFoxInterstitialAdWillShow:"), interstitial.Handle);
		}
		
		[CompilerGenerated]
		public static void MobFoxInterstitialAdClosed (this IMobFoxInterstitialAdDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MobFoxInterstitialAdClosed"));
		}
		
		[CompilerGenerated]
		public static void MobFoxInterstitialAdClicked (this IMobFoxInterstitialAdDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MobFoxInterstitialAdClicked"));
		}
		
		[CompilerGenerated]
		public static void MobFoxInterstitialAdFinished (this IMobFoxInterstitialAdDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("MobFoxInterstitialAdFinished"));
		}
		
	}
	
	internal sealed class MobFoxInterstitialAdDelegateWrapper : BaseWrapper, IMobFoxInterstitialAdDelegate {
		[Preserve (Conditional = true)]
		public MobFoxInterstitialAdDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("MobFoxInterstitialAdDidLoad:")]
		[CompilerGenerated]
		public void MobFoxInterstitialAdDidLoad (MobFoxInterstitialAd interstitial)
		{
			if (interstitial == null)
				throw new ArgumentNullException ("interstitial");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("MobFoxInterstitialAdDidLoad:"), interstitial.Handle);
		}
		
	}
}
namespace MobFoxSDKCore {
	[Protocol]
	[Register("MobFoxInterstitialAdDelegate", false)]
	[Model]
	public unsafe abstract partial class MobFoxInterstitialAdDelegate : NSObject, IMobFoxInterstitialAdDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MobFoxInterstitialAdDelegate () : base (NSObjectFlag.Empty)
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
		protected MobFoxInterstitialAdDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobFoxInterstitialAdDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("MobFoxInterstitialAdClicked")]
		[CompilerGenerated]
		public virtual void MobFoxInterstitialAdClicked ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxInterstitialAdClosed")]
		[CompilerGenerated]
		public virtual void MobFoxInterstitialAdClosed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxInterstitialAdDidFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public virtual void MobFoxInterstitialAdDidFailToReceiveAdWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxInterstitialAdDidLoad:")]
		[CompilerGenerated]
		public abstract void MobFoxInterstitialAdDidLoad (MobFoxInterstitialAd interstitial);
		[Export ("MobFoxInterstitialAdFinished")]
		[CompilerGenerated]
		public virtual void MobFoxInterstitialAdFinished ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("MobFoxInterstitialAdWillShow:")]
		[CompilerGenerated]
		public virtual void MobFoxInterstitialAdWillShow (MobFoxInterstitialAd interstitial)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MobFoxInterstitialAdDelegate */
}
