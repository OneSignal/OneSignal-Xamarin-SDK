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

namespace Com.OneSignal.iOS {
	[Protocol (Name = "OSUserNotificationCenterDelegate", WrapperType = typeof (OSUserNotificationCenterDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPresentNotification", Selector = "userNotificationCenter:willPresentNotification:withCompletionHandler:", ParameterType = new Type [] { typeof (NSObject), typeof (NSObject), typeof (global::System.Action<global::System.nuint>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveNotificationResponse", Selector = "userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:", ParameterType = new Type [] { typeof (NSObject), typeof (NSObject), typeof (Action) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IOSUserNotificationCenterDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class OSUserNotificationCenterDelegate_Extensions {
		[CompilerGenerated]
		public unsafe static void WillPresentNotification (this IOSUserNotificationCenterDelegate This, NSObject center, NSObject notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::System.nuint> completionHandler)
		{
			if (center == null)
				throw new ArgumentNullException ("center");
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlock (Trampolines.SDActionArity1V0.Handler, completionHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("userNotificationCenter:willPresentNotification:withCompletionHandler:"), center.Handle, notification.Handle, (IntPtr) block_ptr_completionHandler);
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public unsafe static void DidReceiveNotificationResponse (this IOSUserNotificationCenterDelegate This, NSObject center, NSObject response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			if (center == null)
				throw new ArgumentNullException ("center");
			if (response == null)
				throw new ArgumentNullException ("response");
			if (completionHandler == null)
				throw new ArgumentNullException ("completionHandler");
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlock (Trampolines.SDAction.Handler, completionHandler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:"), center.Handle, response.Handle, (IntPtr) block_ptr_completionHandler);
			block_ptr_completionHandler->CleanupBlock ();
			
		}
		
	}
	
	internal sealed class OSUserNotificationCenterDelegateWrapper : BaseWrapper, IOSUserNotificationCenterDelegate {
		public OSUserNotificationCenterDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public OSUserNotificationCenterDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Com.OneSignal.iOS {
	[Protocol]
	[Register("OSUserNotificationCenterDelegate", false)]
	[Model]
	public unsafe partial class OSUserNotificationCenterDelegate : NSObject, IOSUserNotificationCenterDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public OSUserNotificationCenterDelegate () : base (NSObjectFlag.Empty)
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
		protected OSUserNotificationCenterDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal OSUserNotificationCenterDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		[CompilerGenerated]
		public unsafe virtual void DidReceiveNotificationResponse (NSObject center, NSObject response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		[CompilerGenerated]
		public unsafe virtual void WillPresentNotification (NSObject center, NSObject notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::System.nuint> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class OSUserNotificationCenterDelegate */
}
