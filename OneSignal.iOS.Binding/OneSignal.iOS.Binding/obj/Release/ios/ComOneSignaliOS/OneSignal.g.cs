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

namespace Com.OneSignal.iOS {
	[Register("OneSignal", true)]
	public unsafe partial class OneSignal : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("OneSignal");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public OneSignal () : base (NSObjectFlag.Empty)
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
		protected OneSignal (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal OneSignal (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithLaunchOptions:")]
		[CompilerGenerated]
		public OneSignal (NSDictionary launchOptions)
			: base (NSObjectFlag.Empty)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithLaunchOptions:"), launchOptions.Handle), "initWithLaunchOptions:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithLaunchOptions:"), launchOptions.Handle), "initWithLaunchOptions:");
			}
		}
		
		[Export ("initWithLaunchOptions:autoRegister:")]
		[CompilerGenerated]
		public OneSignal (NSDictionary launchOptions, bool autoRegister)
			: base (NSObjectFlag.Empty)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithLaunchOptions:autoRegister:"), launchOptions.Handle, autoRegister), "initWithLaunchOptions:autoRegister:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithLaunchOptions:autoRegister:"), launchOptions.Handle, autoRegister), "initWithLaunchOptions:autoRegister:");
			}
		}
		
		[Export ("initWithLaunchOptions:appId:")]
		[CompilerGenerated]
		public OneSignal (NSDictionary launchOptions, string appId)
			: base (NSObjectFlag.Empty)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (appId == null)
				throw new ArgumentNullException ("appId");
			var nsappId = NSString.CreateNative (appId);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithLaunchOptions:appId:"), launchOptions.Handle, nsappId), "initWithLaunchOptions:appId:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithLaunchOptions:appId:"), launchOptions.Handle, nsappId), "initWithLaunchOptions:appId:");
			}
			NSString.ReleaseNative (nsappId);
			
		}
		
		[Export ("initWithLaunchOptions:handleNotification:")]
		[CompilerGenerated]
		public unsafe OneSignal (NSDictionary launchOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalHandleNotificationBlock))]OneSignalHandleNotificationBlock callback)
			: base (NSObjectFlag.Empty)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDOneSignalHandleNotificationBlock.Handler, callback);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithLaunchOptions:handleNotification:"), launchOptions.Handle, (IntPtr) block_ptr_callback), "initWithLaunchOptions:handleNotification:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithLaunchOptions:handleNotification:"), launchOptions.Handle, (IntPtr) block_ptr_callback), "initWithLaunchOptions:handleNotification:");
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initWithLaunchOptions:appId:handleNotification:")]
		[CompilerGenerated]
		public unsafe OneSignal (NSDictionary launchOptions, string appId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalHandleNotificationBlock))]OneSignalHandleNotificationBlock callback)
			: base (NSObjectFlag.Empty)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsappId = NSString.CreateNative (appId);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDOneSignalHandleNotificationBlock.Handler, callback);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithLaunchOptions:appId:handleNotification:"), launchOptions.Handle, nsappId, (IntPtr) block_ptr_callback), "initWithLaunchOptions:appId:handleNotification:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithLaunchOptions:appId:handleNotification:"), launchOptions.Handle, nsappId, (IntPtr) block_ptr_callback), "initWithLaunchOptions:appId:handleNotification:");
			}
			NSString.ReleaseNative (nsappId);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initWithLaunchOptions:handleNotification:autoRegister:")]
		[CompilerGenerated]
		public unsafe OneSignal (NSDictionary launchOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalHandleNotificationBlock))]OneSignalHandleNotificationBlock callback, bool autoRegister)
			: base (NSObjectFlag.Empty)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDOneSignalHandleNotificationBlock.Handler, callback);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithLaunchOptions:handleNotification:autoRegister:"), launchOptions.Handle, (IntPtr) block_ptr_callback, autoRegister), "initWithLaunchOptions:handleNotification:autoRegister:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithLaunchOptions:handleNotification:autoRegister:"), launchOptions.Handle, (IntPtr) block_ptr_callback, autoRegister), "initWithLaunchOptions:handleNotification:autoRegister:");
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initWithLaunchOptions:appId:handleNotification:autoRegister:")]
		[CompilerGenerated]
		public unsafe OneSignal (NSDictionary launchOptions, string appId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalHandleNotificationBlock))]OneSignalHandleNotificationBlock callback, bool autoRegister)
			: base (NSObjectFlag.Empty)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsappId = NSString.CreateNative (appId);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDOneSignalHandleNotificationBlock.Handler, callback);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithLaunchOptions:appId:handleNotification:autoRegister:"), launchOptions.Handle, nsappId, (IntPtr) block_ptr_callback, autoRegister), "initWithLaunchOptions:appId:handleNotification:autoRegister:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithLaunchOptions:appId:handleNotification:autoRegister:"), launchOptions.Handle, nsappId, (IntPtr) block_ptr_callback, autoRegister), "initWithLaunchOptions:appId:handleNotification:autoRegister:");
			}
			NSString.ReleaseNative (nsappId);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("deleteTag:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void DeleteTag (string key, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalResultSuccessBlock))]OneSignalResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalFailureBlock))]OneSignalFailureBlock failureBlock)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOneSignalResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOneSignalFailureBlock.Handler, failureBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("deleteTag:onSuccess:onFailure:"), nskey, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteTag:onSuccess:onFailure:"), nskey, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			}
			NSString.ReleaseNative (nskey);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("deleteTag:")]
		[CompilerGenerated]
		public virtual void DeleteTag (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deleteTag:"), nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteTag:"), nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("deleteTags:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void DeleteTags (NSObject[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalResultSuccessBlock))]OneSignalResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalFailureBlock))]OneSignalFailureBlock failureBlock)
		{
			if (keys == null)
				throw new ArgumentNullException ("keys");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			var nsa_keys = NSArray.FromNSObjects (keys);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOneSignalResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOneSignalFailureBlock.Handler, failureBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("deleteTags:onSuccess:onFailure:"), nsa_keys.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteTags:onSuccess:onFailure:"), nsa_keys.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			}
			nsa_keys.Dispose ();
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("deleteTags:")]
		[CompilerGenerated]
		public virtual void DeleteTags (NSObject[] keys)
		{
			if (keys == null)
				throw new ArgumentNullException ("keys");
			var nsa_keys = NSArray.FromNSObjects (keys);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deleteTags:"), nsa_keys.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteTags:"), nsa_keys.Handle);
			}
			nsa_keys.Dispose ();
			
		}
		
		[Export ("deleteTagsWithJsonString:")]
		[CompilerGenerated]
		public virtual void DeleteTagsWithJsonString (string jsonString)
		{
			if (jsonString == null)
				throw new ArgumentNullException ("jsonString");
			var nsjsonString = NSString.CreateNative (jsonString);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deleteTagsWithJsonString:"), nsjsonString);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteTagsWithJsonString:"), nsjsonString);
			}
			NSString.ReleaseNative (nsjsonString);
			
		}
		
		[Export ("enableInAppAlertNotification:")]
		[CompilerGenerated]
		public virtual void EnableInAppAlertNotification (bool enable)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableInAppAlertNotification:"), enable);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableInAppAlertNotification:"), enable);
			}
		}
		
		[Export ("getTags:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void GetTags ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalResultSuccessBlock))]OneSignalResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalFailureBlock))]OneSignalFailureBlock failureBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOneSignalResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOneSignalFailureBlock.Handler, failureBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getTags:onFailure:"), (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("getTags:onFailure:"), (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			}
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("getTags:")]
		[CompilerGenerated]
		public unsafe virtual void GetTags ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalResultSuccessBlock))]OneSignalResultSuccessBlock successBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOneSignalResultSuccessBlock.Handler, successBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getTags:"), (IntPtr) block_ptr_successBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getTags:"), (IntPtr) block_ptr_successBlock);
			}
			block_ptr_successBlock->CleanupBlock ();
			
		}
		
		[Export ("IdsAvailable:")]
		[CompilerGenerated]
		public unsafe virtual void IdsAvailable ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalIdsAvailableBlock))]OneSignalIdsAvailableBlock idsAvailableBlock)
		{
			if (idsAvailableBlock == null)
				throw new ArgumentNullException ("idsAvailableBlock");
			BlockLiteral *block_ptr_idsAvailableBlock;
			BlockLiteral block_idsAvailableBlock;
			block_idsAvailableBlock = new BlockLiteral ();
			block_ptr_idsAvailableBlock = &block_idsAvailableBlock;
			block_idsAvailableBlock.SetupBlock (Trampolines.SDOneSignalIdsAvailableBlock.Handler, idsAvailableBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("IdsAvailable:"), (IntPtr) block_ptr_idsAvailableBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("IdsAvailable:"), (IntPtr) block_ptr_idsAvailableBlock);
			}
			block_ptr_idsAvailableBlock->CleanupBlock ();
			
		}
		
		[Export ("postNotification:")]
		[CompilerGenerated]
		public virtual void PostNotification (NSDictionary jsonData)
		{
			if (jsonData == null)
				throw new ArgumentNullException ("jsonData");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("postNotification:"), jsonData.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("postNotification:"), jsonData.Handle);
			}
		}
		
		[Export ("postNotification:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void PostNotification (NSDictionary jsonData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalResultSuccessBlock))]OneSignalResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalFailureBlock))]OneSignalFailureBlock failureBlock)
		{
			if (jsonData == null)
				throw new ArgumentNullException ("jsonData");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOneSignalResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOneSignalFailureBlock.Handler, failureBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("postNotification:onSuccess:onFailure:"), jsonData.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("postNotification:onSuccess:onFailure:"), jsonData.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			}
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("postNotificationWithJsonString:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void PostNotificationWithJsonString (string jsonData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalResultSuccessBlock))]OneSignalResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalFailureBlock))]OneSignalFailureBlock failureBlock)
		{
			if (jsonData == null)
				throw new ArgumentNullException ("jsonData");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			var nsjsonData = NSString.CreateNative (jsonData);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOneSignalResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOneSignalFailureBlock.Handler, failureBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("postNotificationWithJsonString:onSuccess:onFailure:"), nsjsonData, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("postNotificationWithJsonString:onSuccess:onFailure:"), nsjsonData, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			}
			NSString.ReleaseNative (nsjsonData);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("registerForPushNotifications")]
		[CompilerGenerated]
		public virtual void RegisterForPushNotifications ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("registerForPushNotifications"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("registerForPushNotifications"));
			}
		}
		
		[Export ("sendTag:value:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void SendTag (string key, string value, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalResultSuccessBlock))]OneSignalResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalFailureBlock))]OneSignalFailureBlock failureBlock)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (value == null)
				throw new ArgumentNullException ("value");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			var nskey = NSString.CreateNative (key);
			var nsvalue = NSString.CreateNative (value);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOneSignalResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOneSignalFailureBlock.Handler, failureBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendTag:value:onSuccess:onFailure:"), nskey, nsvalue, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendTag:value:onSuccess:onFailure:"), nskey, nsvalue, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			}
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsvalue);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("sendTag:value:")]
		[CompilerGenerated]
		public virtual void SendTag (string key, string value)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (value == null)
				throw new ArgumentNullException ("value");
			var nskey = NSString.CreateNative (key);
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendTag:value:"), nskey, nsvalue);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendTag:value:"), nskey, nsvalue);
			}
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[Export ("sendTags:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void SendTags (NSDictionary keyValuePair, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalResultSuccessBlock))]OneSignalResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOneSignalFailureBlock))]OneSignalFailureBlock failureBlock)
		{
			if (keyValuePair == null)
				throw new ArgumentNullException ("keyValuePair");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOneSignalResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOneSignalFailureBlock.Handler, failureBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendTags:onSuccess:onFailure:"), keyValuePair.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendTags:onSuccess:onFailure:"), keyValuePair.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			}
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("sendTags:")]
		[CompilerGenerated]
		public virtual void SendTags (NSDictionary keyValuePair)
		{
			if (keyValuePair == null)
				throw new ArgumentNullException ("keyValuePair");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendTags:"), keyValuePair.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendTags:"), keyValuePair.Handle);
			}
		}
		
		[Export ("sendTagsWithJsonString:")]
		[CompilerGenerated]
		public virtual void SendTagsWithJsonString (string jsonString)
		{
			if (jsonString == null)
				throw new ArgumentNullException ("jsonString");
			var nsjsonString = NSString.CreateNative (jsonString);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendTagsWithJsonString:"), nsjsonString);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendTagsWithJsonString:"), nsjsonString);
			}
			NSString.ReleaseNative (nsjsonString);
			
		}
		
		[Export ("setLogLevel:visualLevel:")]
		[CompilerGenerated]
		public static void SetLogLevel (OneSLogLevel logLevel, OneSLogLevel visualLogLevel)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_UInt64 (class_ptr, Selector.GetHandle ("setLogLevel:visualLevel:"), (UInt64)logLevel, (UInt64)visualLogLevel);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_UInt32 (class_ptr, Selector.GetHandle ("setLogLevel:visualLevel:"), (UInt32)logLevel, (UInt32)visualLogLevel);
			}
		}
		
		[Export ("setSubscription:")]
		[CompilerGenerated]
		public virtual void SetSubscription (bool enable)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSubscription:"), enable);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSubscription:"), enable);
			}
		}
		
		[CompilerGenerated]
		public virtual string App_id {
			[Export ("app_id")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("app_id")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("app_id")));
				}
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_DefaultClient_var_static;
		[CompilerGenerated]
		public static OneSignal DefaultClient {
			[Export ("defaultClient")]
			get {
				OneSignal ret;
				ret =  Runtime.GetNSObject<OneSignal> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultClient")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_DefaultClient_var_static = ret;
				return ret;
			}
			
			[Export ("setDefaultClient:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setDefaultClient:"), value.Handle);
			}
		}
		
	} /* class OneSignal */
}
