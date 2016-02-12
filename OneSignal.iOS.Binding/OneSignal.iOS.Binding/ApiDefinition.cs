using System;
using Foundation;

// typedef void (^OneSignalResultSuccessBlock)(NSDictionary *);
delegate void OneSignalResultSuccessBlock (NSDictionary arg0);

// typedef void (^OneSignalFailureBlock)(NSError *);
delegate void OneSignalFailureBlock (NSError arg0);

// typedef void (^OneSignalIdsAvailableBlock)(NSString *, NSString *);
delegate void OneSignalIdsAvailableBlock (string arg0, string arg1);

// typedef void (^OneSignalHandleNotificationBlock)(NSString *, NSDictionary *, BOOL);
delegate void OneSignalHandleNotificationBlock (string arg0, NSDictionary arg1, bool arg2);

// @interface OneSignal : NSObject
[BaseType (typeof(NSObject))]
interface OneSignal
{
	// @property (readonly, copy, nonatomic) NSString * app_id;
	[Export ("app_id")]
	string App_id { get; }

	// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions;
	[Export ("initWithLaunchOptions:")]
	IntPtr Constructor (NSDictionary launchOptions);

	// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions autoRegister:(BOOL)autoRegister;
	[Export ("initWithLaunchOptions:autoRegister:")]
	IntPtr Constructor (NSDictionary launchOptions, bool autoRegister);

	// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleNotification:(OneSignalHandleNotificationBlock)callback;
	[Export ("initWithLaunchOptions:handleNotification:")]
	IntPtr Constructor (NSDictionary launchOptions, OneSignalHandleNotificationBlock callback);

	// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions appId:(NSString *)appId handleNotification:(OneSignalHandleNotificationBlock)callback;
	[Export ("initWithLaunchOptions:appId:handleNotification:")]
	IntPtr Constructor (NSDictionary launchOptions, string appId, OneSignalHandleNotificationBlock callback);

	// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions appId:(NSString *)appId handleNotification:(OneSignalHandleNotificationBlock)callback autoRegister:(BOOL)autoRegister;
	[Export ("initWithLaunchOptions:appId:handleNotification:autoRegister:")]
	IntPtr Constructor (NSDictionary launchOptions, string appId, OneSignalHandleNotificationBlock callback, bool autoRegister);

	// -(void)registerForPushNotifications;
	[Export ("registerForPushNotifications")]
	void RegisterForPushNotifications ();

	// +(void)setLogLevel:(ONE_S_LOG_LEVEL)logLevel visualLevel:(ONE_S_LOG_LEVEL)visualLogLevel;
	[Static]
	[Export ("setLogLevel:visualLevel:")]
	void SetLogLevel (OneSLogLevel logLevel, OneSLogLevel visualLogLevel);

	// +(OneSignal *)defaultClient;
	// +(void)setDefaultClient:(OneSignal *)client;
	[Static]
	[Export ("defaultClient")]
	OneSignal DefaultClient { get; set; }

	// -(void)sendTag:(NSString *)key value:(NSString *)value onSuccess:(OneSignalResultSuccessBlock)successBlock onFailure:(OneSignalFailureBlock)failureBlock;
	[Export ("sendTag:value:onSuccess:onFailure:")]
	void SendTag (string key, string value, OneSignalResultSuccessBlock successBlock, OneSignalFailureBlock failureBlock);

	// -(void)sendTag:(NSString *)key value:(NSString *)value;
	[Export ("sendTag:value:")]
	void SendTag (string key, string value);

	// -(void)sendTags:(NSDictionary *)keyValuePair onSuccess:(OneSignalResultSuccessBlock)successBlock onFailure:(OneSignalFailureBlock)failureBlock;
	[Export ("sendTags:onSuccess:onFailure:")]
	void SendTags (NSDictionary keyValuePair, OneSignalResultSuccessBlock successBlock, OneSignalFailureBlock failureBlock);

	// -(void)sendTags:(NSDictionary *)keyValuePair;
	[Export ("sendTags:")]
	void SendTags (NSDictionary keyValuePair);

	// -(void)sendTagsWithJsonString:(NSString *)jsonString;
	[Export ("sendTagsWithJsonString:")]
	void SendTagsWithJsonString (string jsonString);

	// -(void)getTags:(OneSignalResultSuccessBlock)successBlock onFailure:(OneSignalFailureBlock)failureBlock;
	[Export ("getTags:onFailure:")]
	void GetTags (OneSignalResultSuccessBlock successBlock, OneSignalFailureBlock failureBlock);

	// -(void)getTags:(OneSignalResultSuccessBlock)successBlock;
	[Export ("getTags:")]
	void GetTags (OneSignalResultSuccessBlock successBlock);

	// -(void)deleteTag:(NSString *)key onSuccess:(OneSignalResultSuccessBlock)successBlock onFailure:(OneSignalFailureBlock)failureBlock;
	[Export ("deleteTag:onSuccess:onFailure:")]
	void DeleteTag (string key, OneSignalResultSuccessBlock successBlock, OneSignalFailureBlock failureBlock);

	// -(void)deleteTag:(NSString *)key;
	[Export ("deleteTag:")]
	void DeleteTag (string key);

	// -(void)deleteTags:(NSArray *)keys onSuccess:(OneSignalResultSuccessBlock)successBlock onFailure:(OneSignalFailureBlock)failureBlock;
	[Export ("deleteTags:onSuccess:onFailure:")]
	void DeleteTags (NSObject[] keys, OneSignalResultSuccessBlock successBlock, OneSignalFailureBlock failureBlock);

	// -(void)deleteTags:(NSArray *)keys;
	[Export ("deleteTags:")]
	void DeleteTags (NSObject[] keys);

	// -(void)deleteTagsWithJsonString:(NSString *)jsonString;
	[Export ("deleteTagsWithJsonString:")]
	void DeleteTagsWithJsonString (string jsonString);

	// -(void)IdsAvailable:(OneSignalIdsAvailableBlock)idsAvailableBlock;
	[Export ("IdsAvailable:")]
	void IdsAvailable (OneSignalIdsAvailableBlock idsAvailableBlock);

	// -(void)enableInAppAlertNotification:(BOOL)enable;
	[Export ("enableInAppAlertNotification:")]
	void EnableInAppAlertNotification (bool enable);

	// -(void)setSubscription:(BOOL)enable;
	[Export ("setSubscription:")]
	void SetSubscription (bool enable);

	// -(void)postNotification:(NSDictionary *)jsonData;
	[Export ("postNotification:")]
	void PostNotification (NSDictionary jsonData);

	// -(void)postNotification:(NSDictionary *)jsonData onSuccess:(OneSignalResultSuccessBlock)successBlock onFailure:(OneSignalFailureBlock)failureBlock;
	[Export ("postNotification:onSuccess:onFailure:")]
	void PostNotification (NSDictionary jsonData, OneSignalResultSuccessBlock successBlock, OneSignalFailureBlock failureBlock);

	// -(void)postNotificationWithJsonString:(NSString *)jsonData onSuccess:(OneSignalResultSuccessBlock)successBlock onFailure:(OneSignalFailureBlock)failureBlock;
	[Export ("postNotificationWithJsonString:onSuccess:onFailure:")]
	void PostNotificationWithJsonString (string jsonData, OneSignalResultSuccessBlock successBlock, OneSignalFailureBlock failureBlock);
}

[Static]
partial interface Constants
{
	// extern NSString *const ONESIGNAL_VERSION;
	[Field ("ONESIGNAL_VERSION", "__Internal")]
	NSString ONESIGNAL_VERSION { get; }
}
