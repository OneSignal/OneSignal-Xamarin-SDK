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
		[UserDelegateType (typeof (global::Com.OneSignal.iOS.OSFailureBlock))]
		internal delegate void DOSFailureBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOSFailureBlock {
			static internal readonly DOSFailureBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOSFailureBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OSFailureBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDOSFailureBlock */
		
		internal class NIDOSFailureBlock {
			IntPtr blockPtr;
			DOSFailureBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOSFailureBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOSFailureBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOSFailureBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OSFailureBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OSFailureBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOSFailureBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDOSFailureBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Com.OneSignal.iOS.OSHandleNotificationActionBlock))]
		internal delegate void DOSHandleNotificationActionBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOSHandleNotificationActionBlock {
			static internal readonly DOSHandleNotificationActionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOSHandleNotificationActionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OSHandleNotificationActionBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Com.OneSignal.iOS.OSNotificationOpenedResult> (arg0));
			}
		} /* class SDOSHandleNotificationActionBlock */
		
		internal class NIDOSHandleNotificationActionBlock {
			IntPtr blockPtr;
			DOSHandleNotificationActionBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOSHandleNotificationActionBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOSHandleNotificationActionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOSHandleNotificationActionBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OSHandleNotificationActionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OSHandleNotificationActionBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOSHandleNotificationActionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Com.OneSignal.iOS.OSNotificationOpenedResult arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDOSHandleNotificationActionBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Com.OneSignal.iOS.OSHandleNotificationReceivedBlock))]
		internal delegate void DOSHandleNotificationReceivedBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOSHandleNotificationReceivedBlock {
			static internal readonly DOSHandleNotificationReceivedBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOSHandleNotificationReceivedBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OSHandleNotificationReceivedBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Com.OneSignal.iOS.OSNotification> (arg0));
			}
		} /* class SDOSHandleNotificationReceivedBlock */
		
		internal class NIDOSHandleNotificationReceivedBlock {
			IntPtr blockPtr;
			DOSHandleNotificationReceivedBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOSHandleNotificationReceivedBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOSHandleNotificationReceivedBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOSHandleNotificationReceivedBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OSHandleNotificationReceivedBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OSHandleNotificationReceivedBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOSHandleNotificationReceivedBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Com.OneSignal.iOS.OSNotification arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDOSHandleNotificationReceivedBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Com.OneSignal.iOS.OSIdsAvailableBlock))]
		internal delegate void DOSIdsAvailableBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOSIdsAvailableBlock {
			static internal readonly DOSIdsAvailableBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOSIdsAvailableBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OSIdsAvailableBlock) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0), NSString.FromHandle (arg1));
			}
		} /* class SDOSIdsAvailableBlock */
		
		internal class NIDOSIdsAvailableBlock {
			IntPtr blockPtr;
			DOSIdsAvailableBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOSIdsAvailableBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOSIdsAvailableBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOSIdsAvailableBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OSIdsAvailableBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OSIdsAvailableBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOSIdsAvailableBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0, string arg1)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, nsarg0, nsarg1);
				NSString.ReleaseNative (nsarg0);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDOSIdsAvailableBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Com.OneSignal.iOS.OSResultSuccessBlock))]
		internal delegate void DOSResultSuccessBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOSResultSuccessBlock {
			static internal readonly DOSResultSuccessBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOSResultSuccessBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OSResultSuccessBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSDictionary> (arg0));
			}
		} /* class SDOSResultSuccessBlock */
		
		internal class NIDOSResultSuccessBlock {
			IntPtr blockPtr;
			DOSResultSuccessBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOSResultSuccessBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOSResultSuccessBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOSResultSuccessBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OSResultSuccessBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OSResultSuccessBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOSResultSuccessBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSDictionary arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDOSResultSuccessBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::System.nuint>))]
		internal delegate void DActionArity1V0 (IntPtr block, global::System.nuint obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, global::System.nuint obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::System.nuint>) (descriptor->Target);
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
			public unsafe static global::System.Action<global::System.nuint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::System.nuint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::System.nuint obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V0 */
	}
}
