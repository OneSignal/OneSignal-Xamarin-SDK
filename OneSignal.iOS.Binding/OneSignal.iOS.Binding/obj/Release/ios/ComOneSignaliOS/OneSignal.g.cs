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

		[Export ("deleteTag:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe static void DeleteTag (string key, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock failureBlock)
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
			block_successBlock.SetupBlock (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("deleteTag:onSuccess:onFailure:"), nskey, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			NSString.ReleaseNative (nskey);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("deleteTag:")]
		[CompilerGenerated]
		public static void DeleteTag (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("deleteTag:"), nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("deleteTags:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe static void DeleteTags (NSObject[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock failureBlock)
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
			block_successBlock.SetupBlock (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("deleteTags:onSuccess:onFailure:"), nsa_keys.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			nsa_keys.Dispose ();
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("deleteTags:")]
		[CompilerGenerated]
		public static void DeleteTags (NSObject[] keys)
		{
			if (keys == null)
				throw new ArgumentNullException ("keys");
			var nsa_keys = NSArray.FromNSObjects (keys);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("deleteTags:"), nsa_keys.Handle);
			nsa_keys.Dispose ();
			
		}
		
		[Export ("deleteTagsWithJsonString:")]
		[CompilerGenerated]
		public static void DeleteTagsWithJsonString (string jsonString)
		{
			if (jsonString == null)
				throw new ArgumentNullException ("jsonString");
			var nsjsonString = NSString.CreateNative (jsonString);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("deleteTagsWithJsonString:"), nsjsonString);
			NSString.ReleaseNative (nsjsonString);
			
		}
		
		[Export ("getTags:onFailure:")]
		[CompilerGenerated]
		public unsafe static void GetTags ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock failureBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getTags:onFailure:"), (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("getTags:")]
		[CompilerGenerated]
		public unsafe static void GetTags ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock successBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getTags:"), (IntPtr) block_ptr_successBlock);
			block_ptr_successBlock->CleanupBlock ();
			
		}
		
		[Export ("IdsAvailable:")]
		[CompilerGenerated]
		public unsafe static void IdsAvailable ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSIdsAvailableBlock))]OSIdsAvailableBlock idsAvailableBlock)
		{
			if (idsAvailableBlock == null)
				throw new ArgumentNullException ("idsAvailableBlock");
			BlockLiteral *block_ptr_idsAvailableBlock;
			BlockLiteral block_idsAvailableBlock;
			block_idsAvailableBlock = new BlockLiteral ();
			block_ptr_idsAvailableBlock = &block_idsAvailableBlock;
			block_idsAvailableBlock.SetupBlock (Trampolines.SDOSIdsAvailableBlock.Handler, idsAvailableBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("IdsAvailable:"), (IntPtr) block_ptr_idsAvailableBlock);
			block_ptr_idsAvailableBlock->CleanupBlock ();
			
		}
		
		[Export ("initWithLaunchOptions:appId:")]
		[CompilerGenerated]
		public static NSObject InitWithLaunchOptions (NSDictionary launchOptions, string appId)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (appId == null)
				throw new ArgumentNullException ("appId");
			var nsappId = NSString.CreateNative (appId);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("initWithLaunchOptions:appId:"), launchOptions.Handle, nsappId));
			NSString.ReleaseNative (nsappId);
			
			return ret;
		}
		
		[Export ("initWithLaunchOptions:appId:handleNotificationAction:")]
		[CompilerGenerated]
		public unsafe static NSObject InitWithLaunchOptions (NSDictionary launchOptions, string appId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSHandleNotificationActionBlock))]OSHandleNotificationActionBlock actionCallback)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (actionCallback == null)
				throw new ArgumentNullException ("actionCallback");
			var nsappId = NSString.CreateNative (appId);
			BlockLiteral *block_ptr_actionCallback;
			BlockLiteral block_actionCallback;
			block_actionCallback = new BlockLiteral ();
			block_ptr_actionCallback = &block_actionCallback;
			block_actionCallback.SetupBlock (Trampolines.SDOSHandleNotificationActionBlock.Handler, actionCallback);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("initWithLaunchOptions:appId:handleNotificationAction:"), launchOptions.Handle, nsappId, (IntPtr) block_ptr_actionCallback));
			NSString.ReleaseNative (nsappId);
			block_ptr_actionCallback->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("initWithLaunchOptions:appId:handleNotificationAction:settings:")]
		[CompilerGenerated]
		public unsafe static NSObject InitWithLaunchOptions (NSDictionary launchOptions, string appId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSHandleNotificationActionBlock))]OSHandleNotificationActionBlock actionCallback, NSDictionary settings)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (actionCallback == null)
				throw new ArgumentNullException ("actionCallback");
			if (settings == null)
				throw new ArgumentNullException ("settings");
			var nsappId = NSString.CreateNative (appId);
			BlockLiteral *block_ptr_actionCallback;
			BlockLiteral block_actionCallback;
			block_actionCallback = new BlockLiteral ();
			block_ptr_actionCallback = &block_actionCallback;
			block_actionCallback.SetupBlock (Trampolines.SDOSHandleNotificationActionBlock.Handler, actionCallback);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("initWithLaunchOptions:appId:handleNotificationAction:settings:"), launchOptions.Handle, nsappId, (IntPtr) block_ptr_actionCallback, settings.Handle));
			NSString.ReleaseNative (nsappId);
			block_ptr_actionCallback->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("initWithLaunchOptions:appId:handleNotificationReceived:handleNotificationAction:settings:")]
		[CompilerGenerated]
		public unsafe static NSObject InitWithLaunchOptions (NSDictionary launchOptions, string appId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSHandleNotificationReceivedBlock))]OSHandleNotificationReceivedBlock erceivedCallback, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSHandleNotificationActionBlock))]OSHandleNotificationActionBlock actionCallback, NSDictionary settings)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (erceivedCallback == null)
				throw new ArgumentNullException ("erceivedCallback");
			if (actionCallback == null)
				throw new ArgumentNullException ("actionCallback");
			if (settings == null)
				throw new ArgumentNullException ("settings");
			var nsappId = NSString.CreateNative (appId);
			BlockLiteral *block_ptr_erceivedCallback;
			BlockLiteral block_erceivedCallback;
			block_erceivedCallback = new BlockLiteral ();
			block_ptr_erceivedCallback = &block_erceivedCallback;
			block_erceivedCallback.SetupBlock (Trampolines.SDOSHandleNotificationReceivedBlock.Handler, erceivedCallback);
			BlockLiteral *block_ptr_actionCallback;
			BlockLiteral block_actionCallback;
			block_actionCallback = new BlockLiteral ();
			block_ptr_actionCallback = &block_actionCallback;
			block_actionCallback.SetupBlock (Trampolines.SDOSHandleNotificationActionBlock.Handler, actionCallback);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("initWithLaunchOptions:appId:handleNotificationReceived:handleNotificationAction:settings:"), launchOptions.Handle, nsappId, (IntPtr) block_ptr_erceivedCallback, (IntPtr) block_ptr_actionCallback, settings.Handle));
			NSString.ReleaseNative (nsappId);
			block_ptr_erceivedCallback->CleanupBlock ();
			block_ptr_actionCallback->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("onesignal_Log:message:")]
		[CompilerGenerated]
		public static void Onesignal_Log (OneSLogLevel logLevel, string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_IntPtr (class_ptr, Selector.GetHandle ("onesignal_Log:message:"), (UInt64)logLevel, nsmessage);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr (class_ptr, Selector.GetHandle ("onesignal_Log:message:"), (UInt32)logLevel, nsmessage);
			}
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("postNotification:")]
		[CompilerGenerated]
		public static void PostNotification (NSDictionary jsonData)
		{
			if (jsonData == null)
				throw new ArgumentNullException ("jsonData");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("postNotification:"), jsonData.Handle);
		}
		
		[Export ("postNotification:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe static void PostNotification (NSDictionary jsonData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock failureBlock)
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
			block_successBlock.SetupBlock (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("postNotification:onSuccess:onFailure:"), jsonData.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("postNotificationWithJsonString:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe static void PostNotificationWithJsonString (string jsonData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock failureBlock)
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
			block_successBlock.SetupBlock (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("postNotificationWithJsonString:onSuccess:onFailure:"), nsjsonData, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			NSString.ReleaseNative (nsjsonData);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("promptLocation")]
		[CompilerGenerated]
		public static void PromptLocation ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("promptLocation"));
		}
		
		[Export ("registerForPushNotifications")]
		[CompilerGenerated]
		public static void RegisterForPushNotifications ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("registerForPushNotifications"));
		}
		
		[Export ("sendTag:value:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe static void SendTag (string key, string value, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock failureBlock)
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
			block_successBlock.SetupBlock (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sendTag:value:onSuccess:onFailure:"), nskey, nsvalue, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsvalue);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("sendTag:value:")]
		[CompilerGenerated]
		public static void SendTag (string key, string value)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (value == null)
				throw new ArgumentNullException ("value");
			var nskey = NSString.CreateNative (key);
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sendTag:value:"), nskey, nsvalue);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[Export ("sendTags:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe static void SendTags (NSDictionary keyValuePair, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSResultSuccessBlock))]OSResultSuccessBlock successBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOSFailureBlock))]OSFailureBlock failureBlock)
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
			block_successBlock.SetupBlock (Trampolines.SDOSResultSuccessBlock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDOSFailureBlock.Handler, failureBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sendTags:onSuccess:onFailure:"), keyValuePair.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("sendTags:")]
		[CompilerGenerated]
		public static void SendTags (NSDictionary keyValuePair)
		{
			if (keyValuePair == null)
				throw new ArgumentNullException ("keyValuePair");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("sendTags:"), keyValuePair.Handle);
		}
		
		[Export ("sendTagsWithJsonString:")]
		[CompilerGenerated]
		public static void SendTagsWithJsonString (string jsonString)
		{
			if (jsonString == null)
				throw new ArgumentNullException ("jsonString");
			var nsjsonString = NSString.CreateNative (jsonString);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("sendTagsWithJsonString:"), nsjsonString);
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
		public static void SetSubscription (bool enable)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setSubscription:"), enable);
		}
		
		[Export ("syncHashedEmail:")]
		[CompilerGenerated]
		public static void SyncHashedEmail (string email)
		{
			if (email == null)
				throw new ArgumentNullException ("email");
			var nsemail = NSString.CreateNative (email);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("syncHashedEmail:"), nsemail);
			NSString.ReleaseNative (nsemail);
			
		}
		
		[CompilerGenerated]
		public static string App_id {
			[Export ("app_id")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("app_id")));
			}
			
		}
		
		[CompilerGenerated]
		public static OSUserNotificationCenterDelegate NotificationCenterDelegate {
			[Export ("notificationCenterDelegate")]
			get {
				OSUserNotificationCenterDelegate ret;
				ret =  Runtime.GetNSObject<OSUserNotificationCenterDelegate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("notificationCenterDelegate")));
				return ret;
			}
			
			[Export ("setNotificationCenterDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setNotificationCenterDelegate:"), value.Handle);
			}
		}
		
	} /* class OneSignal */
}
