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
	[Protocol (Name = "MFExceptionHandlerDelegate", WrapperType = typeof (MFExceptionHandlerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MFExceptionHandlerDidReceivedException", Selector = "MFExceptionHandlerDidReceivedException:", ParameterType = new Type [] { typeof (NSException) }, ParameterByRef = new bool [] { false })]
	public interface IMFExceptionHandlerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MFExceptionHandlerDelegate_Extensions {
		[CompilerGenerated]
		public static void MFExceptionHandlerDidReceivedException (this IMFExceptionHandlerDelegate This, NSException exception)
		{
			if (exception == null)
				throw new ArgumentNullException ("exception");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("MFExceptionHandlerDidReceivedException:"), exception.Handle);
		}
		
	}
	
	internal sealed class MFExceptionHandlerDelegateWrapper : BaseWrapper, IMFExceptionHandlerDelegate {
		[Preserve (Conditional = true)]
		public MFExceptionHandlerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace MobFoxSDKCore {
	[Protocol]
	[Register("MFExceptionHandlerDelegate", false)]
	[Model]
	public unsafe partial class MFExceptionHandlerDelegate : NSObject, IMFExceptionHandlerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MFExceptionHandlerDelegate () : base (NSObjectFlag.Empty)
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
		protected MFExceptionHandlerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MFExceptionHandlerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("MFExceptionHandlerDidReceivedException:")]
		[CompilerGenerated]
		public virtual void MFExceptionHandlerDidReceivedException (NSException exception)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MFExceptionHandlerDelegate */
}
