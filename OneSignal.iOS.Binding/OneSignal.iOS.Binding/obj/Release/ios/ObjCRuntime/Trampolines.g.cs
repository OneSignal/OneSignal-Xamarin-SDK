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
using Security;
using SceneKit;
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
		internal delegate void DOneSignalHandleNotificationBlock (IntPtr block, IntPtr arg0, IntPtr arg1, bool arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOneSignalHandleNotificationBlock {
			static internal readonly DOneSignalHandleNotificationBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOneSignalHandleNotificationBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, bool arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OneSignalHandleNotificationBlock) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0),  Runtime.GetNSObject<NSDictionary> (arg1), arg2);
			}
		} /* class SDOneSignalHandleNotificationBlock */
		
		internal class NIDOneSignalHandleNotificationBlock {
			IntPtr blockPtr;
			DOneSignalHandleNotificationBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOneSignalHandleNotificationBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOneSignalHandleNotificationBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOneSignalHandleNotificationBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OneSignalHandleNotificationBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OneSignalHandleNotificationBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOneSignalHandleNotificationBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0, NSDictionary arg1, bool arg2)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (blockPtr, nsarg0, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDOneSignalHandleNotificationBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DOneSignalResultSuccessBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOneSignalResultSuccessBlock {
			static internal readonly DOneSignalResultSuccessBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOneSignalResultSuccessBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OneSignalResultSuccessBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSDictionary> (arg0));
			}
		} /* class SDOneSignalResultSuccessBlock */
		
		internal class NIDOneSignalResultSuccessBlock {
			IntPtr blockPtr;
			DOneSignalResultSuccessBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOneSignalResultSuccessBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOneSignalResultSuccessBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOneSignalResultSuccessBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OneSignalResultSuccessBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OneSignalResultSuccessBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOneSignalResultSuccessBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSDictionary arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDOneSignalResultSuccessBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DOneSignalFailureBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOneSignalFailureBlock {
			static internal readonly DOneSignalFailureBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOneSignalFailureBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OneSignalFailureBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDOneSignalFailureBlock */
		
		internal class NIDOneSignalFailureBlock {
			IntPtr blockPtr;
			DOneSignalFailureBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOneSignalFailureBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOneSignalFailureBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOneSignalFailureBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OneSignalFailureBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OneSignalFailureBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOneSignalFailureBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDOneSignalFailureBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DOneSignalIdsAvailableBlock (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOneSignalIdsAvailableBlock {
			static internal readonly DOneSignalIdsAvailableBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOneSignalIdsAvailableBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Com.OneSignal.iOS.OneSignalIdsAvailableBlock) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0), NSString.FromHandle (arg1));
			}
		} /* class SDOneSignalIdsAvailableBlock */
		
		internal class NIDOneSignalIdsAvailableBlock {
			IntPtr blockPtr;
			DOneSignalIdsAvailableBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOneSignalIdsAvailableBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOneSignalIdsAvailableBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOneSignalIdsAvailableBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Com.OneSignal.iOS.OneSignalIdsAvailableBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Com.OneSignal.iOS.OneSignalIdsAvailableBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOneSignalIdsAvailableBlock ((BlockLiteral *) block).Invoke;
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
		} /* class NIDOneSignalIdsAvailableBlock */
	}
}
