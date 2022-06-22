using System;
using Foundation;
using ObjCRuntime;
using UserNotifications;

namespace Com.OneSignal.iOS {
	// @interface OSNotificationAction : NSObject
	[BaseType(typeof(NSObject))]
	interface OSNotificationAction {
		// @property (readonly) OSNotificationActionType type;
		[Export("type")]
		OSNotificationActionType Type { get; }

		// @property (readonly) NSString * _Nullable actionId;
		[NullAllowed, Export("actionId")]
		string ActionId { get; }
	}

	// @interface OSNotification : NSObject
	[BaseType(typeof(NSObject))]
	interface OSNotification {
		// @property (readonly) NSString * _Nullable notificationId;
		[NullAllowed, Export("notificationId")]
		string NotificationId { get; }

		// @property (readonly) NSString * _Nullable templateId;
		[NullAllowed, Export("templateId")]
		string TemplateId { get; }

		// @property (readonly) NSString * _Nullable templateName;
		[NullAllowed, Export("templateName")]
		string TemplateName { get; }

		// @property (readonly) BOOL contentAvailable;
		[Export("contentAvailable")]
		bool ContentAvailable { get; }

		// @property (readonly, getter = hasMutableContent) BOOL mutableContent;
		[Export("mutableContent")]
		bool MutableContent { [Bind("hasMutableContent")] get; }

		// @property (readonly) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; }

		// @property (readonly) NSInteger badge;
		[Export("badge")]
		nint Badge { get; }

		// @property (readonly) NSInteger badgeIncrement;
		[Export("badgeIncrement")]
		nint BadgeIncrement { get; }

		// @property (readonly) NSString * _Nullable sound;
		[NullAllowed, Export("sound")]
		string Sound { get; }

		// @property (readonly) NSString * _Nullable title;
		[NullAllowed, Export("title")]
		string Title { get; }

		// @property (readonly) NSString * _Nullable subtitle;
		[NullAllowed, Export("subtitle")]
		string Subtitle { get; }

		// @property (readonly) NSString * _Nullable body;
		[NullAllowed, Export("body")]
		string Body { get; }

		// @property (readonly) NSString * _Nullable launchURL;
		[NullAllowed, Export("launchURL")]
		string LaunchURL { get; }

		// @property (readonly) NSDictionary * _Nullable additionalData;
		[NullAllowed, Export("additionalData")]
		NSDictionary AdditionalData { get; }

		// @property (readonly) NSDictionary * _Nullable attachments;
		[NullAllowed, Export("attachments")]
		NSDictionary Attachments { get; }

		// @property (readonly) NSArray * _Nullable actionButtons;
		[NullAllowed, Export("actionButtons")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ActionButtons { get; }

		// @property (readonly) NSDictionary * _Nonnull rawPayload;
		[Export("rawPayload")]
		NSDictionary RawPayload { get; }

		// @property (readonly) NSString * _Nullable threadId;
		[NullAllowed, Export("threadId")]
		string ThreadId { get; }

		// @property (readonly) NSNumber * _Nullable relevanceScore;
		[NullAllowed, Export("relevanceScore")]
		NSNumber RelevanceScore { get; }

		// @property (readonly) NSString * interruptionLevel;
		[Export("interruptionLevel")]
		string InterruptionLevel { get; }

		// +(instancetype)parseWithApns:(NSDictionary * _Nonnull)message;
		[Static]
		[Export("parseWithApns:")]
		OSNotification ParseWithApns(NSDictionary message);

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export("jsonRepresentation")]
		NSDictionary JsonRepresentation();

		// -(NSString * _Nonnull)stringify;
		[Export("stringify")]
		//[Verify (MethodToProperty)]
		string Stringify();
	}

	// @interface OSNotificationOpenedResult : NSObject
	[BaseType(typeof(NSObject))]
	interface OSNotificationOpenedResult {
		// @property (readonly) OSNotification * _Nonnull notification;
		[Export("notification")]
		OSNotification Notification { get; }

		// @property (readonly) OSNotificationAction * _Nonnull action;
		[Export("action")]
		OSNotificationAction Action { get; }

		// -(NSString * _Nonnull)stringify;
		[Export("stringify")]
		//[Verify (MethodToProperty)]
		string Stringify();

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export("jsonRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonRepresentation();
	}

	// @interface OSInAppMessage : NSObject
	[BaseType(typeof(NSObject))]
	interface OSInAppMessage {
		// @property (nonatomic, strong) NSString * _Nonnull messageId;
		[Export("messageId", ArgumentSemantic.Strong)]
		string MessageId { get; set; }
	}

	// @interface OSInAppMessageOutcome : NSObject
	[BaseType(typeof(NSObject))]
	interface OSInAppMessageOutcome {
		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull weight;
		[Export("weight", ArgumentSemantic.Strong)]
		NSNumber Weight { get; set; }

		// @property (nonatomic) BOOL unique;
		[Export("unique")]
		bool Unique { get; set; }

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export("jsonRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonRepresentation();
	}

	// @interface OSInAppMessageTag : NSObject
	[BaseType(typeof(NSObject))]
	interface OSInAppMessageTag {
		// @property (nonatomic, strong) NSDictionary * _Nullable tagsToAdd;
		[NullAllowed, Export("tagsToAdd", ArgumentSemantic.Strong)]
		NSDictionary TagsToAdd { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable tagsToRemove;
		[NullAllowed, Export("tagsToRemove", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] TagsToRemove { get; set; }

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export("jsonRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonRepresentation();
	}

	// @interface OSInAppMessageAction : NSObject
	[BaseType(typeof(NSObject))]
	interface OSInAppMessageAction {
		// @property (nonatomic, strong) NSString * _Nullable clickName;
		[NullAllowed, Export("clickName", ArgumentSemantic.Strong)]
		string ClickName { get; set; }

		// @property (nonatomic, strong) NSURL * _Nullable clickUrl;
		[NullAllowed, Export("clickUrl", ArgumentSemantic.Strong)]
		NSUrl ClickUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable pageId;
		[NullAllowed, Export("pageId", ArgumentSemantic.Strong)]
		string PageId { get; set; }

		// @property (nonatomic) BOOL firstClick;
		[Export("firstClick")]
		bool FirstClick { get; set; }

		// @property (nonatomic) BOOL closesMessage;
		[Export("closesMessage")]
		bool ClosesMessage { get; set; }

		// @property (nonatomic, strong) NSArray<OSInAppMessageOutcome *> * _Nullable outcomes;
		[NullAllowed, Export("outcomes", ArgumentSemantic.Strong)]
		OSInAppMessageOutcome[] Outcomes { get; set; }

		// @property (nonatomic, strong) OSInAppMessageTag * _Nullable tags;
		[NullAllowed, Export("tags", ArgumentSemantic.Strong)]
		OSInAppMessageTag Tags { get; set; }

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export("jsonRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonRepresentation();
	}

	// @protocol OSInAppMessageDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface OSInAppMessageDelegate {
		// @optional -(void)handleMessageAction:(OSInAppMessageAction * _Nonnull)action __attribute__((swift_name("handleMessageAction(action:)")));
		[Export("handleMessageAction:")]
		void HandleMessageAction(OSInAppMessageAction action);
	}

	// @protocol OSInAppMessageLifecycleHandler <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[Model]
	[BaseType(typeof(NSObject))]
	interface OSInAppMessageLifecycleHandler {
		// @optional -(void)onWillDisplayInAppMessage:(OSInAppMessage *)message;
		[Export("onWillDisplayInAppMessage:")]
		void OnWillDisplayInAppMessage(OSInAppMessage message);

		// @optional -(void)onDidDisplayInAppMessage:(OSInAppMessage *)message;
		[Export("onDidDisplayInAppMessage:")]
		void OnDidDisplayInAppMessage(OSInAppMessage message);

		// @optional -(void)onWillDismissInAppMessage:(OSInAppMessage *)message;
		[Export("onWillDismissInAppMessage:")]
		void OnWillDismissInAppMessage(OSInAppMessage message);

		// @optional -(void)onDidDismissInAppMessage:(OSInAppMessage *)message;
		[Export("onDidDismissInAppMessage:")]
		void OnDidDismissInAppMessage(OSInAppMessage message);
	}

	// @interface OSOutcomeEvent : NSObject
	[BaseType(typeof(NSObject))]
	interface OSOutcomeEvent {
		// @property (nonatomic) OSInfluenceType session;
		[Export("session", ArgumentSemantic.Assign)]
		OSInfluenceType Session { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable notificationIds;
		[NullAllowed, Export("notificationIds", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		string[] NotificationIds { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull timestamp;
		[Export("timestamp", ArgumentSemantic.Strong)]
		NSNumber Timestamp { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nonnull weight;
		[Export("weight", ArgumentSemantic.Strong)]
		NSDecimalNumber Weight { get; set; }

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export("jsonRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonRepresentation();
	}

	// @interface OSPermissionState : NSObject
	[BaseType(typeof(NSObject))]
	interface OSPermissionState {
		// @property (readonly, nonatomic) BOOL reachable;
		[Export("reachable")]
		bool Reachable { get; }

		// @property (readonly, nonatomic) BOOL hasPrompted;
		[Export("hasPrompted")]
		bool HasPrompted { get; }

		// @property (readonly, nonatomic) BOOL providesAppNotificationSettings;
		[Export("providesAppNotificationSettings")]
		bool ProvidesAppNotificationSettings { get; }

		// @property (readonly, nonatomic) OSNotificationPermission status;
		[Export("status")]
		OSNotificationPermission Status { get; }

		// -(NSDictionary * _Nonnull)toDictionary;
		[Export("toDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary ToDictionary();
	}

	// @interface OSPermissionStateChanges : NSObject
	[BaseType(typeof(NSObject))]
	interface OSPermissionStateChanges {
		// @property (readonly) OSPermissionState * _Nonnull to;
		[Export("to")]
		OSPermissionState To { get; }

		// @property (readonly) OSPermissionState * _Nonnull from;
		[Export("from")]
		OSPermissionState From { get; }

		// -(NSDictionary * _Nonnull)toDictionary;
		[Export("toDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary ToDictionary();
	}

	// @interface OSSubscriptionState : NSObject
	[BaseType(typeof(NSObject))]
	interface OSSubscriptionState {
		// @property (readonly, nonatomic) BOOL isSubscribed;
		[Export("isSubscribed")]
		bool IsSubscribed { get; }

		// @property (readonly, nonatomic) BOOL isPushDisabled;
		[Export("isPushDisabled")]
		bool IsPushDisabled { get; }

		// @property (readonly, nonatomic) NSString * _Nullable userId;
		[NullAllowed, Export("userId")]
		string UserId { get; }

		// @property (readonly, nonatomic) NSString * _Nullable pushToken;
		[NullAllowed, Export("pushToken")]
		string PushToken { get; }

		// -(NSDictionary * _Nonnull)toDictionary;
		[Export("toDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary ToDictionary();
	}

	// @interface OSSubscriptionStateChanges : NSObject
	[BaseType(typeof(NSObject))]
	interface OSSubscriptionStateChanges {
		// @property (readonly) OSSubscriptionState * _Nonnull to;
		[Export("to")]
		OSSubscriptionState To { get; }

		// @property (readonly) OSSubscriptionState * _Nonnull from;
		[Export("from")]
		OSSubscriptionState From { get; }

		// -(NSDictionary * _Nonnull)toDictionary;
		[Export("toDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary ToDictionary();
	}

	// @interface OSEmailSubscriptionState : NSObject
	[BaseType(typeof(NSObject))]
	interface OSEmailSubscriptionState {
		// @property (readonly, nonatomic) NSString * _Nullable emailUserId;
		[NullAllowed, Export("emailUserId")]
		string EmailUserId { get; }

		// @property (readonly, nonatomic) NSString * _Nullable emailAddress;
		[NullAllowed, Export("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly, nonatomic) BOOL isSubscribed;
		[Export("isSubscribed")]
		bool IsSubscribed { get; }

		// -(NSDictionary * _Nonnull)toDictionary;
		[Export("toDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary ToDictionary();
	}

	// @interface OSEmailSubscriptionStateChanges : NSObject
	[BaseType(typeof(NSObject))]
	interface OSEmailSubscriptionStateChanges {
		// @property (readonly) OSEmailSubscriptionState * _Nonnull to;
		[Export("to")]
		OSEmailSubscriptionState To { get; }

		// @property (readonly) OSEmailSubscriptionState * _Nonnull from;
		[Export("from")]
		OSEmailSubscriptionState From { get; }

		// -(NSDictionary * _Nonnull)toDictionary;
		[Export("toDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary ToDictionary();
	}

	// @interface OSSMSSubscriptionState : NSObject
	[BaseType(typeof(NSObject))]
	interface OSSMSSubscriptionState {
		// @property (readonly, nonatomic) NSString * _Nullable smsUserId;
		[NullAllowed, Export("smsUserId")]
		string SmsUserId { get; }

		// @property (readonly, nonatomic) NSString * _Nullable smsNumber;
		[NullAllowed, Export("smsNumber")]
		string SmsNumber { get; }

		// @property (readonly, nonatomic) BOOL isSubscribed;
		[Export("isSubscribed")]
		bool IsSubscribed { get; }

		// -(NSDictionary * _Nonnull)toDictionary;
		[Export("toDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary ToDictionary();
	}

	// @interface OSSMSSubscriptionStateChanges : NSObject
	[BaseType(typeof(NSObject))]
	interface OSSMSSubscriptionStateChanges {
		// @property (readonly) OSSMSSubscriptionState * _Nonnull to;
		[Export("to")]
		OSSMSSubscriptionState To { get; }

		// @property (readonly) OSSMSSubscriptionState * _Nonnull from;
		[Export("from")]
		OSSMSSubscriptionState From { get; }

		// -(NSDictionary * _Nonnull)toDictionary;
		[Export("toDictionary")]
		//[Verify (MethodToProperty)]
		NSDictionary ToDictionary();
	}

	// @protocol OSPermissionObserver <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[Model]
	[BaseType(typeof(NSObject))]
	interface OSPermissionObserver {
		// @required -(void)onOSPermissionChanged:(OSPermissionStateChanges * _Nonnull)stateChanges;
		[Abstract]
		[Export("onOSPermissionChanged:")]
		void OnOSPermissionChanged(OSPermissionStateChanges stateChanges);
	}

	// @protocol OSSubscriptionObserver <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[Model]
	[BaseType(typeof(NSObject))]
	interface OSSubscriptionObserver {
		// @required -(void)onOSSubscriptionChanged:(OSSubscriptionStateChanges * _Nonnull)stateChanges;
		[Abstract]
		[Export("onOSSubscriptionChanged:")]
		void OnOSSubscriptionChanged(OSSubscriptionStateChanges stateChanges);
	}

	// @protocol OSEmailSubscriptionObserver <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[Model]
	[BaseType(typeof(NSObject))]
	interface OSEmailSubscriptionObserver {
		// @required -(void)onOSEmailSubscriptionChanged:(OSEmailSubscriptionStateChanges * _Nonnull)stateChanges;
		[Abstract]
		[Export("onOSEmailSubscriptionChanged:")]
		void OnOSEmailSubscriptionChanged(OSEmailSubscriptionStateChanges stateChanges);
	}

	// @protocol OSSMSSubscriptionObserver <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[Model]
	[BaseType(typeof(NSObject))]
	interface OSSMSSubscriptionObserver {
		// @required -(void)onOSSMSSubscriptionChanged:(OSSMSSubscriptionStateChanges * _Nonnull)stateChanges;
		[Abstract]
		[Export("onOSSMSSubscriptionChanged:")]
		void OnOSSMSSubscriptionChanged(OSSMSSubscriptionStateChanges stateChanges);
	}

	// @interface OSDeviceState : NSObject
	[BaseType(typeof(NSObject))]
	interface OSDeviceState {
		// @property (readonly) BOOL hasNotificationPermission;
		[Export("hasNotificationPermission")]
		bool HasNotificationPermission { get; }

		// @property (readonly) BOOL isPushDisabled;
		[Export("isPushDisabled")]
		bool IsPushDisabled { get; }

		// @property (readonly) BOOL isSubscribed;
		[Export("isSubscribed")]
		bool IsSubscribed { get; }

		// @property (readonly) OSNotificationPermission notificationPermissionStatus;
		[Export("notificationPermissionStatus")]
		OSNotificationPermission NotificationPermissionStatus { get; }

		// @property (readonly) NSString * _Nullable userId;
		[NullAllowed, Export("userId")]
		string UserId { get; }

		// @property (readonly) NSString * _Nullable pushToken;
		[NullAllowed, Export("pushToken")]
		string PushToken { get; }

		// @property (readonly) NSString * _Nullable emailUserId;
		[NullAllowed, Export("emailUserId")]
		string EmailUserId { get; }

		// @property (readonly) NSString * _Nullable emailAddress;
		[NullAllowed, Export("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly) BOOL isEmailSubscribed;
		[Export("isEmailSubscribed")]
		bool IsEmailSubscribed { get; }

		// @property (readonly) NSString * _Nullable smsUserId;
		[NullAllowed, Export("smsUserId")]
		string SmsUserId { get; }

		// @property (readonly) NSString * _Nullable smsNumber;
		[NullAllowed, Export("smsNumber")]
		string SmsNumber { get; }

		// @property (readonly) BOOL isSMSSubscribed;
		[Export("isSMSSubscribed")]
		bool IsSMSSubscribed { get; }

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export("jsonRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonRepresentation();
	}

	// typedef void (^OSWebOpenURLResultBlock)(BOOL);
	delegate void OSWebOpenURLResultBlock(bool arg0);

	// typedef void (^OSResultSuccessBlock)(NSDictionary *);
	delegate void OSResultSuccessBlock(NSDictionary arg0);

	// typedef void (^OSFailureBlock)(NSError *);
	delegate void OSFailureBlock(NSError arg0);

	// typedef void (^OSSendOutcomeSuccess)(OSOutcomeEvent *);
	delegate void OSSendOutcomeSuccess(OSOutcomeEvent arg0);

	// @interface OneSignal : NSObject
	[BaseType(typeof(NSObject))]
	interface OneSignal {
		// +(NSString *)appId;
		// +(void)setAppId:(NSString * _Nonnull)newAppId;
		[Static]
		[Export("appId")]
		//[Verify (MethodToProperty)]
		string AppId { get; set; }

		// +(NSString * _Nonnull)sdkVersionRaw;
		[Static]
		[Export("sdkVersionRaw")]
		//[Verify (MethodToProperty)]
		string SdkVersionRaw { get; }

		// +(NSString * _Nonnull)sdkSemanticVersion;
		[Static]
		[Export("sdkSemanticVersion")]
		//[Verify (MethodToProperty)]
		string SdkSemanticVersion { get; }

		// +(void)disablePush:(BOOL)disable;
		[Static]
		[Export("disablePush:")]
		void DisablePush(bool disable);

		// +(void)setMSDKType:(NSString * _Nonnull)type;
		[Static]
		[Export("setMSDKType:")]
		void SetMSDKType(string type);

		// +(void)initWithLaunchOptions:(NSDictionary * _Nullable)launchOptions;
		[Static]
		[Export("initWithLaunchOptions:")]
		void InitWithLaunchOptions([NullAllowed] NSDictionary launchOptions);

		// +(void)setLaunchURLsInApp:(BOOL)launchInApp;
		[Static]
		[Export("setLaunchURLsInApp:")]
		void SetLaunchURLsInApp(bool launchInApp);

		// +(void)setProvidesNotificationSettingsView:(BOOL)providesView;
		[Static]
		[Export("setProvidesNotificationSettingsView:")]
		void SetProvidesNotificationSettingsView(bool providesView);

		// +(void)setLogLevel:(ONE_S_LOG_LEVEL)logLevel visualLevel:(ONE_S_LOG_LEVEL)visualLogLevel;
		[Static]
		[Export("setLogLevel:visualLevel:")]
		void SetLogLevel(OneSLogLevel logLevel, OneSLogLevel visualLogLevel);

		// +(void)onesignalLog:(ONE_S_LOG_LEVEL)logLevel message:(NSString * _Nonnull)message;
		[Static]
		[Export("onesignalLog:message:")]
		void OnesignalLog(OneSLogLevel logLevel, string message);

		// +(void)promptForPushNotificationsWithUserResponse:(OSUserResponseBlock)block;
		[Static]
		[Export("promptForPushNotificationsWithUserResponse:")]
		void PromptForPushNotificationsWithUserResponse(OSUserResponseBlock block);

		// +(void)promptForPushNotificationsWithUserResponse:(OSUserResponseBlock)block fallbackToSettings:(BOOL)fallback;
		[Static]
		[Export("promptForPushNotificationsWithUserResponse:fallbackToSettings:")]
		void PromptForPushNotificationsWithUserResponse(OSUserResponseBlock block, bool fallback);

		// +(void)registerForProvisionalAuthorization:(OSUserResponseBlock)block;
		[Static]
		[Export("registerForProvisionalAuthorization:")]
		void RegisterForProvisionalAuthorization(OSUserResponseBlock block);

		//+ (void)registerForPushNotifications;
		[Static]
		[Export("registerForPushNotifications")]
		void RegisterForPushNotifications();

		// +(OSDeviceState *)getDeviceState;
		[Static]
		[Export("getDeviceState")]
		//[Verify (MethodToProperty)]
		OSDeviceState DeviceState();

		// +(void)consentGranted:(BOOL)granted;
		[Static]
		[Export("consentGranted:")]
		void ConsentGranted(bool granted);

		// +(void)setRequiresUserPrivacyConsent:(BOOL)required;
		[Static]
		[Export("setRequiresUserPrivacyConsent:")]
		void SetRequiresUserPrivacyConsent(bool required);

		// +(BOOL)requiresUserPrivacyConsent;
		[Static]
		[Export("requiresUserPrivacyConsent")]
		//[Verify (MethodToProperty)]
		bool RequiresUserPrivacyConsent();

		// +(void)setNotificationWillShowInForegroundHandler:(OSNotificationWillShowInForegroundBlock _Nullable)block;
		[Static]
		[Export("setNotificationWillShowInForegroundHandler:")]
		void SetNotificationWillShowInForegroundHandler([NullAllowed] OSNotificationWillShowInForegroundBlock block);

		// +(void)setNotificationOpenedHandler:(OSNotificationOpenedBlock _Nullable)block;
		[Static]
		[Export("setNotificationOpenedHandler:")]
		void SetNotificationOpenedHandler([NullAllowed] OSNotificationOpenedBlock block);

		// +(void)setInAppMessageClickHandler:(OSInAppMessageClickBlock _Nullable)block;
		[Static]
		[Export("setInAppMessageClickHandler:")]
		void SetInAppMessageClickHandler([NullAllowed] OSInAppMessageClickBlock block);

		// +(void)setInAppMessageLifecycleHandler:(NSObject<OSInAppMessageLifecycleHandler> * _Nullable)delegate;
		[Static]
		[Export("setInAppMessageLifecycleHandler:")]
		void SetInAppMessageLifecycleHandler([NullAllowed] OSInAppMessageLifecycleHandler @delegate);

		// +(void)postNotification:(NSDictionary * _Nonnull)jsonData;
		[Static]
		[Export("postNotification:")]
		void PostNotification(NSDictionary jsonData);

		// +(void)postNotification:(NSDictionary * _Nonnull)jsonData onSuccess:(OSResultSuccessBlock _Nullable)successBlock onFailure:(OSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("postNotification:onSuccess:onFailure:")]
		void PostNotification(NSDictionary jsonData, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

		// +(void)postNotificationWithJsonString:(NSString * _Nonnull)jsonData onSuccess:(OSResultSuccessBlock _Nullable)successBlock onFailure:(OSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("postNotificationWithJsonString:onSuccess:onFailure:")]
		void PostNotificationWithJsonString(string jsonData, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

		// +(void)promptLocation;
		[Static]
		[Export("promptLocation")]
		void PromptLocation();

		// +(void)setLocationShared:(BOOL)enable;
		[Static]
		[Export("setLocationShared:")]
		void SetLocationShared(bool enable);

		// +(BOOL)isLocationShared;
		[Static]
		[Export("isLocationShared")]
		bool IsLocationShared();

		// +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent __attribute__((deprecated("Please use didReceiveNotificationExtensionRequest:withMutableNotificationContent:withContentHandler: instead.")));
		[Static]
		[Export("didReceiveNotificationExtensionRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent DidReceiveNotificationExtensionRequest(UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent);

		// +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent withContentHandler:(void (^)(UNNotificationContent * _Nonnull))contentHandler;
		[Static]
		[Export("didReceiveNotificationExtensionRequest:withMutableNotificationContent:withContentHandler:")]
		UNMutableNotificationContent DidReceiveNotificationExtensionRequest(UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent, IosContentHandlerBlock contentHandler);

		// +(UNMutableNotificationContent *)serviceExtensionTimeWillExpireRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent;
		[Static]
		[Export("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent ServiceExtensionTimeWillExpireRequest(UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent);

		// +(void)sendTag:(NSString * _Nonnull)key value:(NSString * _Nonnull)value onSuccess:(OSResultSuccessBlock _Nullable)successBlock onFailure:(OSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("sendTag:value:onSuccess:onFailure:")]
		void SendTag(string key, string value, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

		// +(void)sendTag:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Static]
		[Export("sendTag:value:")]
		void SendTag(string key, string value);

		// +(void)sendTags:(NSDictionary * _Nonnull)keyValuePair onSuccess:(OSResultSuccessBlock _Nullable)successBlock onFailure:(OSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("sendTags:onSuccess:onFailure:")]
		void SendTags(NSDictionary keyValuePair, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

		// +(void)sendTags:(NSDictionary * _Nonnull)keyValuePair;
		[Static]
		[Export("sendTags:")]
		void SendTags(NSDictionary keyValuePair);

		// +(void)sendTagsWithJsonString:(NSString * _Nonnull)jsonString;
		[Static]
		[Export("sendTagsWithJsonString:")]
		void SendTagsWithJsonString(string jsonString);

		// +(void)getTags:(OSResultSuccessBlock _Nullable)successBlock onFailure:(OSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("getTags:onFailure:")]
		void GetTags([NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

		// +(void)getTags:(OSResultSuccessBlock _Nullable)successBlock;
		[Static]
		[Export("getTags:")]
		void GetTags([NullAllowed] OSResultSuccessBlock successBlock);

		// +(void)deleteTag:(NSString * _Nonnull)key onSuccess:(OSResultSuccessBlock _Nullable)successBlock onFailure:(OSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("deleteTag:onSuccess:onFailure:")]
		void DeleteTag(string key, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

		// +(void)deleteTag:(NSString * _Nonnull)key;
		[Static]
		[Export("deleteTag:")]
		void DeleteTag(string key);

		// +(void)deleteTags:(NSArray * _Nonnull)keys onSuccess:(OSResultSuccessBlock _Nullable)successBlock onFailure:(OSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("deleteTags:onSuccess:onFailure:")]
		//[Verify (StronglyTypedNSArray)]
		void DeleteTags(NSObject[] keys, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

		// +(void)deleteTags:(NSArray<NSString *> * _Nonnull)keys;
		[Static]
		[Export("deleteTags:")]
		void DeleteTags(string[] keys);

		// +(void)deleteTagsWithJsonString:(NSString * _Nonnull)jsonString;
		[Static]
		[Export("deleteTagsWithJsonString:")]
		void DeleteTagsWithJsonString(string jsonString);

		// +(void)addPermissionObserver:(NSObject<OSPermissionObserver> * _Nonnull)observer;
		[Static]
		[Export("addPermissionObserver:")]
		void AddPermissionObserver(OSPermissionObserver observer);

		// +(void)removePermissionObserver:(NSObject<OSPermissionObserver> * _Nonnull)observer;
		[Static]
		[Export("removePermissionObserver:")]
		void RemovePermissionObserver(OSPermissionObserver observer);

		// +(void)addSubscriptionObserver:(NSObject<OSSubscriptionObserver> * _Nonnull)observer;
		[Static]
		[Export("addSubscriptionObserver:")]
		void AddSubscriptionObserver(OSSubscriptionObserver observer);

		// +(void)removeSubscriptionObserver:(NSObject<OSSubscriptionObserver> * _Nonnull)observer;
		[Static]
		[Export("removeSubscriptionObserver:")]
		void RemoveSubscriptionObserver(OSSubscriptionObserver observer);

		// +(void)addEmailSubscriptionObserver:(NSObject<OSEmailSubscriptionObserver> * _Nonnull)observer;
		[Static]
		[Export("addEmailSubscriptionObserver:")]
		void AddEmailSubscriptionObserver(OSEmailSubscriptionObserver observer);

		// +(void)removeEmailSubscriptionObserver:(NSObject<OSEmailSubscriptionObserver> * _Nonnull)observer;
		[Static]
		[Export("removeEmailSubscriptionObserver:")]
		void RemoveEmailSubscriptionObserver(OSEmailSubscriptionObserver observer);

		// +(void)addSMSSubscriptionObserver:(NSObject<OSSMSSubscriptionObserver> * _Nonnull)observer;
		[Static]
		[Export("addSMSSubscriptionObserver:")]
		void AddSMSSubscriptionObserver(OSSMSSubscriptionObserver observer);

		// +(void)removeSMSSubscriptionObserver:(NSObject<OSSMSSubscriptionObserver> * _Nonnull)observer;
		[Static]
		[Export("removeSMSSubscriptionObserver:")]
		void RemoveSMSSubscriptionObserver(OSSMSSubscriptionObserver observer);

		// +(void)setEmail:(NSString * _Nonnull)email withEmailAuthHashToken:(NSString * _Nullable)hashToken;
		[Static]
		[Export("setEmail:withEmailAuthHashToken:")]
		void SetEmail(string email, [NullAllowed] string hashToken);

		// +(void)setEmail:(NSString * _Nonnull)email withEmailAuthHashToken:(NSString * _Nullable)hashToken withSuccess:(OSEmailSuccessBlock _Nullable)successBlock withFailure:(OSEmailFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("setEmail:withEmailAuthHashToken:withSuccess:withFailure:")]
		void SetEmail(string email, [NullAllowed] string hashToken, [NullAllowed] OSEmailSuccessBlock successBlock, [NullAllowed] OSEmailFailureBlock failureBlock);

		// +(void)setEmail:(NSString * _Nonnull)email;
		[Static]
		[Export("setEmail:")]
		void SetEmail(string email);

		// +(void)setEmail:(NSString * _Nonnull)email withSuccess:(OSEmailSuccessBlock _Nullable)successBlock withFailure:(OSEmailFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("setEmail:withSuccess:withFailure:")]
		void SetEmail(string email, [NullAllowed] OSEmailSuccessBlock successBlock, [NullAllowed] OSEmailFailureBlock failureBlock);

		// +(void)logoutEmail;
		[Static]
		[Export("logoutEmail")]
		void LogoutEmail();

		// +(void)logoutEmailWithSuccess:(OSEmailSuccessBlock _Nullable)successBlock withFailure:(OSEmailFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("logoutEmailWithSuccess:withFailure:")]
		void LogoutEmailWithSuccess([NullAllowed] OSEmailSuccessBlock successBlock, [NullAllowed] OSEmailFailureBlock failureBlock);

		// +(void)setSMSNumber:(NSString * _Nonnull)smsNumber withSMSAuthHashToken:(NSString * _Nullable)hashToken;
		[Static]
		[Export("setSMSNumber:withSMSAuthHashToken:")]
		void SetSMSNumber(string smsNumber, [NullAllowed] string hashToken);

		// +(void)setSMSNumber:(NSString * _Nonnull)smsNumber withSMSAuthHashToken:(NSString * _Nullable)hashToken withSuccess:(OSSMSSuccessBlock _Nullable)successBlock withFailure:(OSSMSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("setSMSNumber:withSMSAuthHashToken:withSuccess:withFailure:")]
		void SetSMSNumber(string smsNumber, [NullAllowed] string hashToken, [NullAllowed] OSSMSSuccessBlock successBlock, [NullAllowed] OSSMSFailureBlock failureBlock);

		// +(void)setSMSNumber:(NSString * _Nonnull)smsNumber;
		[Static]
		[Export("setSMSNumber:")]
		void SetSMSNumber(string smsNumber);

		// +(void)setSMSNumber:(NSString * _Nonnull)smsNumber withSuccess:(OSSMSSuccessBlock _Nullable)successBlock withFailure:(OSSMSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("setSMSNumber:withSuccess:withFailure:")]
		void SetSMSNumber(string smsNumber, [NullAllowed] OSSMSSuccessBlock successBlock, [NullAllowed] OSSMSFailureBlock failureBlock);

		// +(void)logoutSMSNumber;
		[Static]
		[Export("logoutSMSNumber")]
		void LogoutSMSNumber();

		// +(void)logoutSMSNumberWithSuccess:(OSSMSSuccessBlock _Nullable)successBlock withFailure:(OSSMSFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("logoutSMSNumberWithSuccess:withFailure:")]
		void LogoutSMSNumberWithSuccess([NullAllowed] OSSMSSuccessBlock successBlock, [NullAllowed] OSSMSFailureBlock failureBlock);

		// +(void)setLanguage:(NSString * _Nonnull)language;
		[Static]
		[Export("setLanguage:")]
		void SetLanguage(string language);

		// +(void)setLanguage:(NSString * _Nonnull)language withSuccess:(OSUpdateLanguageSuccessBlock _Nullable)successBlock withFailure:(OSUpdateLanguageFailureBlock)failureBlock;
		[Static]
		[Export("setLanguage:withSuccess:withFailure:")]
		void SetLanguage(string language, [NullAllowed] OSUpdateLanguageSuccessBlock successBlock, OSUpdateLanguageFailureBlock failureBlock);

		// +(void)setExternalUserId:(NSString * _Nonnull)externalId;
		[Static]
		[Export("setExternalUserId:")]
		void SetExternalUserId(string externalId);

		// +(void)setExternalUserId:(NSString * _Nonnull)externalId withSuccess:(OSUpdateExternalUserIdSuccessBlock _Nullable)successBlock withFailure:(OSUpdateExternalUserIdFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("setExternalUserId:withSuccess:withFailure:")]
		void SetExternalUserId(string externalId, [NullAllowed] OSUpdateExternalUserIdSuccessBlock successBlock, [NullAllowed] OSUpdateExternalUserIdFailureBlock failureBlock);

		// +(void)setExternalUserId:(NSString *)externalId withExternalIdAuthHashToken:(NSString *)hashToken withSuccess:(OSUpdateExternalUserIdSuccessBlock _Nullable)successBlock withFailure:(OSUpdateExternalUserIdFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("setExternalUserId:withExternalIdAuthHashToken:withSuccess:withFailure:")]
		void SetExternalUserId(string externalId, string hashToken, [NullAllowed] OSUpdateExternalUserIdSuccessBlock successBlock, [NullAllowed] OSUpdateExternalUserIdFailureBlock failureBlock);

		// +(void)removeExternalUserId;
		[Static]
		[Export("removeExternalUserId")]
		void RemoveExternalUserId();

		// +(void)removeExternalUserId:(OSUpdateExternalUserIdSuccessBlock _Nullable)successBlock withFailure:(OSUpdateExternalUserIdFailureBlock _Nullable)failureBlock;
		[Static]
		[Export("removeExternalUserId:withFailure:")]
		void RemoveExternalUserId([NullAllowed] OSUpdateExternalUserIdSuccessBlock successBlock, [NullAllowed] OSUpdateExternalUserIdFailureBlock failureBlock);

		// +(BOOL)isInAppMessagingPaused;
		[Static]
		[Export("isInAppMessagingPaused")]
		bool IsInAppMessagingPaused();

		// +(void)pauseInAppMessages:(BOOL)pause;
		[Static]
		[Export("pauseInAppMessages:")]
		void PauseInAppMessages(bool pause);

		// +(void)addTrigger:(NSString * _Nonnull)key withValue:(id _Nonnull)value;
		[Static]
		[Export("addTrigger:withValue:")]
		void AddTrigger(string key, NSObject value);

		// +(void)addTriggers:(NSDictionary<NSString *,id> * _Nonnull)triggers;
		[Static]
		[Export("addTriggers:")]
		void AddTriggers(NSDictionary triggers);

		// +(void)removeTriggerForKey:(NSString * _Nonnull)key;
		[Static]
		[Export("removeTriggerForKey:")]
		void RemoveTriggerForKey(string key);

		// +(void)removeTriggersForKeys:(NSArray<NSString *> * _Nonnull)keys;
		[Static]
		[Export("removeTriggersForKeys:")]
		void RemoveTriggersForKeys(string[] keys);

		// +(NSDictionary<NSString *,id> * _Nonnull)getTriggers;
		[Static]
		[Export("getTriggers")]
		NSDictionary<NSString, NSObject> GetTriggers();

		// +(id _Nullable)getTriggerValueForKey:(NSString * _Nonnull)key;
		[Static]
		[Export("getTriggerValueForKey:")]
		[return: NullAllowed]
		NSObject GetTriggerValueForKey(string key);

		// +(void)sendOutcome:(NSString * _Nonnull)name;
		[Static]
		[Export("sendOutcome:")]
		void SendOutcome(string name);

		// +(void)sendOutcome:(NSString * _Nonnull)name onSuccess:(OSSendOutcomeSuccess _Nullable)success;
		[Static]
		[Export("sendOutcome:onSuccess:")]
		void SendOutcome(string name, [NullAllowed] OSSendOutcomeSuccess success);

		// +(void)sendUniqueOutcome:(NSString * _Nonnull)name;
		[Static]
		[Export("sendUniqueOutcome:")]
		void SendUniqueOutcome(string name);

		// +(void)sendUniqueOutcome:(NSString * _Nonnull)name onSuccess:(OSSendOutcomeSuccess _Nullable)success;
		[Static]
		[Export("sendUniqueOutcome:onSuccess:")]
		void SendUniqueOutcome(string name, [NullAllowed] OSSendOutcomeSuccess success);

		// +(void)sendOutcomeWithValue:(NSString * _Nonnull)name value:(NSNumber * _Nonnull)value;
		[Static]
		[Export("sendOutcomeWithValue:value:")]
		void SendOutcomeWithValue(string name, NSNumber value);

		// +(void)sendOutcomeWithValue:(NSString * _Nonnull)name value:(NSNumber * _Nonnull)value onSuccess:(OSSendOutcomeSuccess _Nullable)success;
		[Static]
		[Export("sendOutcomeWithValue:value:onSuccess:")]
		void SendOutcomeWithValue(string name, NSNumber value, [NullAllowed] OSSendOutcomeSuccess success);
	}

	//[Static]
	////[Verify (ConstantsInterfaceAssociation)]
	//partial interface Constants {
	//	// extern NSString *const ONESIGNAL_VERSION;
	//	[Field("ONESIGNAL_VERSION", "__Internal")]
	//	NSString ONESIGNAL_VERSION { get; }
	//}

	// typedef void (^OSUserResponseBlock)(BOOL);
	delegate void OSUserResponseBlock(bool arg0);

	// typedef void (^OSNotificationDisplayResponse)(OSNotification * _Nullable);
	delegate void OSNotificationDisplayResponse([NullAllowed] OSNotification arg0);

	// typedef void (^OSNotificationWillShowInForegroundBlock)(OSNotification * _Nonnull, OSNotificationDisplayResponse _Nonnull);
	delegate void OSNotificationWillShowInForegroundBlock(OSNotification arg0, [BlockCallback] OSNotificationDisplayResponse arg1);

	// typedef void (^OSNotificationOpenedBlock)(OSNotificationOpenedResult * _Nonnull);
	delegate void OSNotificationOpenedBlock(OSNotificationOpenedResult arg0);

	// typedef void (^OSInAppMessageClickBlock)(OSInAppMessageAction * _Nonnull);
	delegate void OSInAppMessageClickBlock(OSInAppMessageAction arg0);

	// typedef void (^OSEmailFailureBlock)(NSError *);
	delegate void OSEmailFailureBlock(NSError arg0);

	// typedef void (^OSEmailSuccessBlock)();
	delegate void OSEmailSuccessBlock();

	// typedef void (^OSSMSFailureBlock)(NSError *);
	delegate void OSSMSFailureBlock(NSError arg0);

	// typedef void (^OSSMSSuccessBlock)(NSDictionary *);
	delegate void OSSMSSuccessBlock(NSDictionary arg0);

	// typedef void (^OSUpdateLanguageFailureBlock)(NSError *);
	delegate void OSUpdateLanguageFailureBlock(NSError arg0);

	// typedef void (^OSUpdateLanguageSuccessBlock)();
	delegate void OSUpdateLanguageSuccessBlock();

	// typedef void (^OSUpdateExternalUserIdFailureBlock)(NSError *);
	delegate void OSUpdateExternalUserIdFailureBlock(NSError arg0);

	// typedef void (^OSUpdateExternalUserIdSuccessBlock)(NSDictionary *);
	delegate void OSUpdateExternalUserIdSuccessBlock(NSDictionary arg0);

	// typedef (void (^)(UNNotificationContent *_Nonnull))contentHandler
	delegate void IosContentHandlerBlock(UNNotificationContent arg0);
}