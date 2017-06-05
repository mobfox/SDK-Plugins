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
	[Register("MFReport", true)]
	public unsafe partial class MFReport : NSObject, INSUrlConnectionDataDelegate, INSUrlConnectionDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MFReport");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MFReport () : base (NSObjectFlag.Empty)
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
		protected MFReport (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MFReport (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("log:withInventoryHash:andWithMessage:requestID:")]
		[CompilerGenerated]
		public static void Log (string facility, string hash, string message, string requestID)
		{
			if (facility == null)
				throw new ArgumentNullException ("facility");
			if (hash == null)
				throw new ArgumentNullException ("hash");
			if (message == null)
				throw new ArgumentNullException ("message");
			if (requestID == null)
				throw new ArgumentNullException ("requestID");
			var nsfacility = NSString.CreateNative (facility);
			var nshash = NSString.CreateNative (hash);
			var nsmessage = NSString.CreateNative (message);
			var nsrequestID = NSString.CreateNative (requestID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("log:withInventoryHash:andWithMessage:requestID:"), nsfacility, nshash, nsmessage, nsrequestID);
			NSString.ReleaseNative (nsfacility);
			NSString.ReleaseNative (nshash);
			NSString.ReleaseNative (nsmessage);
			NSString.ReleaseNative (nsrequestID);
			
		}
		
		[Export ("reportOnErrorWithFacility:inventoryHash:message:requestID:")]
		[CompilerGenerated]
		public static void ReportOnErrorWithFacility (string facility, string hash, string message, string requestID)
		{
			if (facility == null)
				throw new ArgumentNullException ("facility");
			if (hash == null)
				throw new ArgumentNullException ("hash");
			if (message == null)
				throw new ArgumentNullException ("message");
			if (requestID == null)
				throw new ArgumentNullException ("requestID");
			var nsfacility = NSString.CreateNative (facility);
			var nshash = NSString.CreateNative (hash);
			var nsmessage = NSString.CreateNative (message);
			var nsrequestID = NSString.CreateNative (requestID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("reportOnErrorWithFacility:inventoryHash:message:requestID:"), nsfacility, nshash, nsmessage, nsrequestID);
			NSString.ReleaseNative (nsfacility);
			NSString.ReleaseNative (nshash);
			NSString.ReleaseNative (nsmessage);
			NSString.ReleaseNative (nsrequestID);
			
		}
		
	} /* class MFReport */
}
