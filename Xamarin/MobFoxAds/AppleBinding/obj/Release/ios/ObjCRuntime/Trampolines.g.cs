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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::MobFoxSDKCore.WVJBHandler))]
		internal delegate void DWVJBHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDWVJBHandler {
			static internal readonly DWVJBHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DWVJBHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MobFoxSDKCore.WVJBHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSObject> (arg0), (MobFoxSDKCore.WVJBResponseCallback) Marshal.GetDelegateForFunctionPointer (arg1, typeof (MobFoxSDKCore.WVJBResponseCallback)));
			}
		} /* class SDWVJBHandler */
		
		internal class NIDWVJBHandler {
			IntPtr blockPtr;
			DWVJBHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDWVJBHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DWVJBHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDWVJBHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::MobFoxSDKCore.WVJBHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::MobFoxSDKCore.WVJBHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDWVJBHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSObject arg0, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDWVJBResponseCallback))]global::MobFoxSDKCore.WVJBResponseCallback arg1)
			{
				BlockLiteral *block_ptr_arg1;
				BlockLiteral block_arg1;
				block_arg1 = new BlockLiteral ();
				block_ptr_arg1 = &block_arg1;
				block_arg1.SetupBlock (Trampolines.SDWVJBResponseCallback.Handler, arg1);
				
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, (IntPtr) block_ptr_arg1);
				block_ptr_arg1->CleanupBlock ();
				
			}
		} /* class NIDWVJBHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::MobFoxSDKCore.WVJBResponseCallback))]
		internal delegate void DWVJBResponseCallback (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDWVJBResponseCallback {
			static internal readonly DWVJBResponseCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DWVJBResponseCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MobFoxSDKCore.WVJBResponseCallback) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSObject> (arg0));
			}
		} /* class SDWVJBResponseCallback */
		
		internal class NIDWVJBResponseCallback {
			IntPtr blockPtr;
			DWVJBResponseCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDWVJBResponseCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DWVJBResponseCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDWVJBResponseCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::MobFoxSDKCore.WVJBResponseCallback Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::MobFoxSDKCore.WVJBResponseCallback;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDWVJBResponseCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSObject arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDWVJBResponseCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSObject>))]
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSObject>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSObject> (obj));
			}
		} /* class SDActionArity1V1 */
		
		internal class NIDActionArity1V1 {
			IntPtr blockPtr;
			DActionArity1V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSObject> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSObject>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSObject obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<bool>))]
		internal delegate void DActionArity1V0 (IntPtr block, bool obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, bool obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<bool>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<bool>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V0 */
	}
}
