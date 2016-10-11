using System;
using Foundation;
using OSNotificationDisplayType = Com.OneSignal.iOS.OSInFocusDisplayOption;

namespace Com.OneSignal.iOS
{
	// @protocol OSUserNotificationCenterDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface OSUserNotificationCenterDelegate
	{
		// @optional -(void)userNotificationCenter:(id)center willPresentNotification:(id)notification withCompletionHandler:(void (^)(NSUInteger))completionHandler;
		[Export ("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		void WillPresentNotification (NSObject center, NSObject notification, Action<nuint> completionHandler);

		// @optional -(void)userNotificationCenter:(id)center didReceiveNotificationResponse:(id)response withCompletionHandler:(void (^)())completionHandler;
		[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void DidReceiveNotificationResponse (NSObject center, NSObject response, Action completionHandler);
	}

	// @interface OSNotificationAction : NSObject
	[BaseType (typeof(NSObject))]
	interface OSNotificationAction
	{
		// @property (readonly) OSNotificationActionType type;
		[Export ("type")]
		OSNotificationActionType Type { get; }

		// @property (readonly) NSString * actionID;
		[Export ("actionID")]
		string ActionID { get; }
	}

	// @interface OSNotificationPayload : NSObject
	[BaseType (typeof(NSObject))]
	interface OSNotificationPayload
	{
		// @property (readonly) NSString * notificationID;
		[Export ("notificationID")]
		string NotificationID { get; }

		// @property (readonly) BOOL contentAvailable;
		[Export ("contentAvailable")]
		bool ContentAvailable { get; }

		// @property (readonly) NSUInteger badge;
		[Export ("badge")]
		nuint Badge { get; }

		// @property (readonly) NSString * sound;
		[Export ("sound")]
		string Sound { get; }

		// @property (readonly) NSString * title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; }

		// @property (readonly) NSString * body;
		[Export ("body")]
		string Body { get; }

		// @property (readonly) NSString * launchURL;
		[Export ("launchURL")]
		string LaunchURL { get; }

		// @property (readonly) NSDictionary * additionalData;
		[Export ("additionalData")]
		NSDictionary AdditionalData { get; }

		// @property (readonly) NSDictionary * attachments;
		[Export ("attachments")]
		NSDictionary Attachments { get; }

		// @property (readonly) NSDictionary * actionButtons;
		[Export ("actionButtons")]
		NSArray ActionButtons { get; }

		// @property (readonly) NSDictionary * rawPayload;
		[Export ("rawPayload")]
		NSDictionary RawPayload { get; }
	}

	// @interface OSNotification : NSObject
	[BaseType (typeof(NSObject))]
	interface OSNotification
	{
		// @property (readonly) OSNotificationPayload * payload;
		[Export ("payload")]
		OSNotificationPayload Payload { get; }

		// @property (readonly) OSNotificationDisplayType displayType;
		[Export ("displayType")]
		OSNotificationDisplayType DisplayType { get; }

		// @property (readonly, getter = wasShown) BOOL shown;
		[Export ("shown")]
		bool Shown { [Bind ("wasShown")] get; }

		// @property (readonly, getter = isSilentNotification) BOOL silentNotification;
		[Export ("silentNotification")]
		bool SilentNotification { [Bind ("isSilentNotification")] get; }

		// @property (readonly, getter = hasMutableContent) BOOL mutableContent;
		[Export ("mutableContent")]
		bool MutableContent { [Bind ("hasMutableContent")] get; }

		// -(NSString *)stringify;
		[Export ("stringify")]
		string Stringify { get; }
	}

	// @interface OSNotificationOpenedResult : NSObject
	[BaseType (typeof(NSObject))]
	interface OSNotificationOpenedResult
	{
		// @property (readonly) OSNotification * notification;
		[Export ("notification")]
		OSNotification Notification { get; }

		// @property (readonly) OSNotificationAction * action;
		[Export ("action")]
		OSNotificationAction Action { get; }

		// -(NSString *)stringify;
		[Export ("stringify")]
		string Stringify { get; }
	}

	// typedef void (^OSResultSuccessBlock)(NSDictionary *);
	delegate void OSResultSuccessBlock (NSDictionary arg0);

	// typedef void (^OSFailureBlock)(NSError *);
	delegate void OSFailureBlock (NSError arg0);

	// typedef void (^OSIdsAvailableBlock)(NSString *, NSString *);
	delegate void OSIdsAvailableBlock (string arg0, string arg1);

	// typedef void (^OSHandleNotificationReceivedBlock)(OSNotification *);
	delegate void OSHandleNotificationReceivedBlock (OSNotification arg0);

	// typedef void (^OSHandleNotificationActionBlock)(OSNotificationOpenedResult *);
	delegate void OSHandleNotificationActionBlock (OSNotificationOpenedResult arg0);


	partial interface Constants
	{
		[Static]
		// extern NSString *const kOSSettingsKeyAutoPrompt;
		[Field ("kOSSettingsKeyAutoPrompt", "__Internal")]
		NSString kOSSettingsKeyAutoPrompt { get; }

		[Static]
		// extern NSString *const kOSSettingsKeyInAppAlerts;
		[Field ("kOSSettingsKeyInAppAlerts", "__Internal")]
		NSString kOSSettingsKeyInAppAlerts { get; }

		[Static]
		// extern NSString *const kOSSettingsKeyInAppLaunchURL;
		[Field ("kOSSettingsKeyInAppLaunchURL", "__Internal")]
		NSString kOSSettingsKeyInAppLaunchURL { get; }


		// extern NSString *const kOSSettingsKeyInFocusDisplayOption;
		[Field ("kOSSettingsKeyInFocusDisplayOption", "__Internal")]
		NSString kOSSettingsKeyInFocusDisplayOption { get; }
	}

	// @interface OneSignal : NSObject
	[BaseType (typeof(NSObject))]
	interface OneSignal
	{
		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions appId:(NSString *)appId;
		[Static]
		[Export ("initWithLaunchOptions:appId:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string appId);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions appId:(NSString *)appId handleNotificationAction:(OSHandleNotificationActionBlock)actionCallback;
		[Static]
		[Export ("initWithLaunchOptions:appId:handleNotificationAction:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string appId, OSHandleNotificationActionBlock actionCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions appId:(NSString *)appId handleNotificationAction:(OSHandleNotificationActionBlock)actionCallback settings:(NSDictionary *)settings;
		[Static]
		[Export ("initWithLaunchOptions:appId:handleNotificationAction:settings:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string appId, OSHandleNotificationActionBlock actionCallback, NSDictionary settings);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions appId:(NSString *)appId handleNotificationReceived:(OSHandleNotificationReceivedBlock)erceivedCallback handleNotificationAction:(OSHandleNotificationActionBlock)actionCallback settings:(NSDictionary *)settings;
		[Static]
		[Export ("initWithLaunchOptions:appId:handleNotificationReceived:handleNotificationAction:settings:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string appId, OSHandleNotificationReceivedBlock erceivedCallback, OSHandleNotificationActionBlock actionCallback, NSDictionary settings);

		// +(NSString *)app_id;
		[Static]
		[Export ("app_id")]
		string App_id { get; }

		// +(void)registerForPushNotifications;
		[Static]
		[Export ("registerForPushNotifications")]
		void RegisterForPushNotifications ();

		// +(void)setLogLevel:(OneSLogLevel)logLevel visualLevel:(OneSLogLevel)visualLogLevel;
		[Static]
		[Export ("setLogLevel:visualLevel:")]
		void SetLogLevel (OneSLogLevel logLevel, OneSLogLevel visualLogLevel);

		// +(void)onesignal_Log:(OneSLogLevel)logLevel message:(NSString *)message;
		[Static]
		[Export ("onesignal_Log:message:")]
		void Onesignal_Log (OneSLogLevel logLevel, string message);

		// +(void)sendTag:(NSString *)key value:(NSString *)value onSuccess:(OSResultSuccessBlock)successBlock onFailure:(OSFailureBlock)failureBlock;
		[Static]
		[Export ("sendTag:value:onSuccess:onFailure:")]
		void SendTag (string key, string value, OSResultSuccessBlock successBlock, OSFailureBlock failureBlock);

		// +(void)sendTag:(NSString *)key value:(NSString *)value;
		[Static]
		[Export ("sendTag:value:")]
		void SendTag (string key, string value);

		// +(void)sendTags:(NSDictionary *)keyValuePair onSuccess:(OSResultSuccessBlock)successBlock onFailure:(OSFailureBlock)failureBlock;
		[Static]
		[Export ("sendTags:onSuccess:onFailure:")]
		void SendTags (NSDictionary keyValuePair, OSResultSuccessBlock successBlock, OSFailureBlock failureBlock);

		// +(void)sendTags:(NSDictionary *)keyValuePair;
		[Static]
		[Export ("sendTags:")]
		void SendTags (NSDictionary keyValuePair);

		// +(void)sendTagsWithJsonString:(NSString *)jsonString;
		[Static]
		[Export ("sendTagsWithJsonString:")]
		void SendTagsWithJsonString (string jsonString);

		// +(void)getTags:(OSResultSuccessBlock)successBlock onFailure:(OSFailureBlock)failureBlock;
		[Static]
		[Export ("getTags:onFailure:")]
		void GetTags (OSResultSuccessBlock successBlock, OSFailureBlock failureBlock);

		// +(void)getTags:(OSResultSuccessBlock)successBlock;
		[Static]
		[Export ("getTags:")]
		void GetTags (OSResultSuccessBlock successBlock);

		// +(void)deleteTag:(NSString *)key onSuccess:(OSResultSuccessBlock)successBlock onFailure:(OSFailureBlock)failureBlock;
		[Static]
		[Export ("deleteTag:onSuccess:onFailure:")]
		void DeleteTag (string key, OSResultSuccessBlock successBlock, OSFailureBlock failureBlock);

		// +(void)deleteTag:(NSString *)key;
		[Static]
		[Export ("deleteTag:")]
		void DeleteTag (string key);

		// +(void)deleteTags:(NSArray *)keys onSuccess:(OSResultSuccessBlock)successBlock onFailure:(OSFailureBlock)failureBlock;
		[Static]
		[Export ("deleteTags:onSuccess:onFailure:")]
		void DeleteTags (NSObject[] keys, OSResultSuccessBlock successBlock, OSFailureBlock failureBlock);

		// +(void)deleteTags:(NSArray *)keys;
		[Static]
		[Export ("deleteTags:")]
		void DeleteTags (NSObject[] keys);

		// +(void)deleteTagsWithJsonString:(NSString *)jsonString;
		[Static]
		[Export ("deleteTagsWithJsonString:")]
		void DeleteTagsWithJsonString (string jsonString);

		// +(void)IdsAvailable:(OSIdsAvailableBlock)idsAvailableBlock;
		[Static]
		[Export ("IdsAvailable:")]
		void IdsAvailable (OSIdsAvailableBlock idsAvailableBlock);

		// +(void)setSubscription:(BOOL)enable;
		[Static]
		[Export ("setSubscription:")]
		void SetSubscription (bool enable);

		// +(void)postNotification:(NSDictionary *)jsonData;
		[Static]
		[Export ("postNotification:")]
		void PostNotification (NSDictionary jsonData);

		// +(void)postNotification:(NSDictionary *)jsonData onSuccess:(OSResultSuccessBlock)successBlock onFailure:(OSFailureBlock)failureBlock;
		[Static]
		[Export ("postNotification:onSuccess:onFailure:")]
		void PostNotification (NSDictionary jsonData, OSResultSuccessBlock successBlock, OSFailureBlock failureBlock);

		// +(void)postNotificationWithJsonString:(NSString *)jsonData onSuccess:(OSResultSuccessBlock)successBlock onFailure:(OSFailureBlock)failureBlock;
		[Static]
		[Export ("postNotificationWithJsonString:onSuccess:onFailure:")]
		void PostNotificationWithJsonString (string jsonData, OSResultSuccessBlock successBlock, OSFailureBlock failureBlock);

		// +(void)promptLocation;
		[Static]
		[Export ("promptLocation")]
		void PromptLocation ();

		// +(void)syncHashedEmail:(NSString *)email;
		[Static]
		[Export ("syncHashedEmail:")]
		void SyncHashedEmail (string email);

		// +(id<OSUserNotificationCenterDelegate>)notificationCenterDelegate;
		// +(void)setNotificationCenterDelegate:(id<OSUserNotificationCenterDelegate>)delegate;
		[Static]
		[Export ("notificationCenterDelegate")]
		OSUserNotificationCenterDelegate NotificationCenterDelegate { get; set; }
	}

	[Static]
	partial interface Constants
	{
		// extern NSString *const ONESIGNAL_VERSION;
		[Field ("ONESIGNAL_VERSION", "__Internal")]
		NSString ONESIGNAL_VERSION { get; }
	}
}
