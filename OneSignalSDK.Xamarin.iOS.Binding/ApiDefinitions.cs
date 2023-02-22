using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

namespace Com.OneSignal.iOS {

	// @interface OSNotification : NSObject
	[BaseType (typeof(NSObject))]
	interface OSNotification
	{
        // @property (readonly) NSString * _Nullable notificationId;
        [NullAllowed, Export ("notificationId")]
        string NotificationId { get; }

        // @property (readonly) NSString * _Nullable templateId;
        [NullAllowed, Export ("templateId")]
        string TemplateId { get; }

        // @property (readonly) NSString * _Nullable templateName;
        [NullAllowed, Export ("templateName")]
        string TemplateName { get; }

        // @property (readonly) BOOL contentAvailable;
        [Export ("contentAvailable")]
        bool ContentAvailable { get; }

        // @property (readonly, getter = hasMutableContent) BOOL mutableContent;
        [Export ("mutableContent")]
        bool MutableContent { [Bind ("hasMutableContent")] get; }

        // @property (readonly) NSString * _Nullable category;
        [NullAllowed, Export ("category")]
        string Category { get; }

        // @property (readonly) NSInteger badge;
        [Export ("badge")]
        nint Badge { get; }

        // @property (readonly) NSInteger badgeIncrement;
        [Export ("badgeIncrement")]
        nint BadgeIncrement { get; }

        // @property (readonly) NSString * _Nullable sound;
        [NullAllowed, Export ("sound")]
        string Sound { get; }

        // @property (readonly) NSString * _Nullable title;
        [NullAllowed, Export ("title")]
        string Title { get; }

        // @property (readonly) NSString * _Nullable subtitle;
        [NullAllowed, Export ("subtitle")]
        string Subtitle { get; }

        // @property (readonly) NSString * _Nullable body;
        [NullAllowed, Export ("body")]
        string Body { get; }

        // @property (readonly) NSString * _Nullable launchURL;
        [NullAllowed, Export ("launchURL")]
        string LaunchURL { get; }

        // @property (readonly) NSDictionary * _Nullable additionalData;
        [NullAllowed, Export ("additionalData")]
        NSDictionary AdditionalData { get; }

        // @property (readonly) NSDictionary * _Nullable attachments;
        [NullAllowed, Export ("attachments")]
        NSDictionary Attachments { get; }

        // @property (readonly) NSArray * _Nullable actionButtons;
        [NullAllowed, Export ("actionButtons")]
        //[Verify (StronglyTypedNSArray)]
        NSObject[] ActionButtons { get; }

        // @property (readonly) NSDictionary * _Nonnull rawPayload;
        [Export ("rawPayload")]
        NSDictionary RawPayload { get; }

        // @property (readonly) NSString * _Nullable threadId;
        [NullAllowed, Export ("threadId")]
        string ThreadId { get; }

        // @property (readonly) NSNumber * _Nullable relevanceScore;
        [NullAllowed, Export ("relevanceScore")]
        NSNumber RelevanceScore { get; }

        // @property (readonly) NSString * _Nullable interruptionLevel;
        [NullAllowed, Export ("interruptionLevel")]
        string InterruptionLevel { get; }

        // @property (readonly) NSString * _Nullable collapseId;
        [NullAllowed, Export ("collapseId")]
        string CollapseId { get; }

        // +(instancetype _Nullable)parseWithApns:(NSDictionary * _Nonnull)message;
        [Static]
        [Export ("parseWithApns:")]
        [return: NullAllowed]
        OSNotification ParseWithApns (NSDictionary message);

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
		//[Verify (MethodToProperty)]
        NSDictionary JsonRepresentation { get; }

        // -(NSString * _Nonnull)stringify;
        [Export ("stringify")]
		//[Verify (MethodToProperty)]
        string Stringify { get; }
    }

	// typedef void (^OSNotificationDisplayResponse)(OSNotification * _Nullable);
	delegate void OSNotificationDisplayResponse ([NullAllowed] OSNotification arg0);

	// @interface OSNotificationAction : NSObject
	[BaseType (typeof(NSObject))]
	interface OSNotificationAction
	{
		// @property (readonly) OSNotificationActionType type;
		[Export ("type")]
		OSNotificationActionType Type { get; }

		// @property (readonly) NSString * _Nullable actionId;
		[NullAllowed, Export ("actionId")]
		string ActionId { get; }
	}

	// @interface OSNotificationOpenedResult : NSObject
	[BaseType (typeof(NSObject))]
	interface OSNotificationOpenedResult
	{
		// @property (readonly) OSNotification * _Nonnull notification;
		[Export ("notification")]
		OSNotification Notification { get; }

		// @property (readonly) OSNotificationAction * _Nonnull action;
		[Export ("action")]
		OSNotificationAction Action { get; }

		// -(NSString * _Nonnull)stringify;
		[Export ("stringify")]
		//[Verify (MethodToProperty)]
		string Stringify { get; }

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export ("jsonRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonRepresentation { get; }
	}

    // typedef void (^OSResultSuccessBlock)(NSDictionary *);
    delegate void OSResultSuccessBlock(NSDictionary arg0);

    // typedef void (^OSFailureBlock)(NSError *);
    delegate void OSFailureBlock(NSError arg0);

    // @protocol OSDebug <NSObject>
    [Protocol]
	[BaseType (typeof(NSObject))]
	interface OSDebug
	{
		// @required +(void)setLogLevel:(ONE_S_LOG_LEVEL)logLevel;
		//[Abstract]
		[Export ("setLogLevel:")]
		void SetLogLevel (OneSLogLevel logLevel);

        // @required +(void)setAlertLevel:(ONE_S_LOG_LEVEL)visualLogLevel;
        //[Abstract]
        [Export ("setAlertLevel:")]
		void SetAlertLevel(OneSLogLevel visualLogLevel);
	}

    // @interface OneSignalWrapper : NSObject
    [BaseType(typeof(NSObject))]
    interface OneSignalWrapper
    {
        // @property (class) NSString * _Nullable sdkType;
        [Static]
        [NullAllowed, Export("sdkType")]
        string SdkType { get; set; }

        // @property (class) NSString * _Nullable sdkVersion;
        [Static]
        [NullAllowed, Export("sdkVersion")]
        string SdkVersion { get; set; }
    }

    // @interface OSInAppMessageOutcome : NSObject
    [BaseType (typeof(NSObject))]
	interface OSInAppMessageOutcome
	{
		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull weight;
		[Export ("weight", ArgumentSemantic.Strong)]
		NSNumber Weight { get; set; }

		// @property (nonatomic) BOOL unique;
		[Export ("unique")]
		bool Unique { get; set; }

		// -(NSDictionary * _Nonnull)jsonRepresentation;
		[Export ("jsonRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary JsonRepresentation { get; }
	}

	// @protocol OSSession <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface OSSession
	{
		// @required +(void)addOutcome:(NSString * _Nonnull)name;
		//[Abstract]
		[Export ("addOutcome:")]
		void AddOutcome (string name);

		// @required +(void)addUniqueOutcome:(NSString * _Nonnull)name;
		//[Abstract]
		[Export ("addUniqueOutcome:")]
		void AddUniqueOutcome (string name);

		// @required +(void)addOutcomeWithValue:(NSString * _Nonnull)name value:(NSNumber * _Nonnull)value __attribute__((swift_private));
		//[Abstract]
		[Export ("addOutcomeWithValue:value:")]
		void AddOutcomeWithValue (string name, NSNumber value);
	}

	// @interface OSPermissionState : NSObject
	[BaseType (typeof(NSObject))]
	interface OSPermissionState
	{
        // @property (readonly, nonatomic) BOOL permission;
        [Export ("permission")]
        bool Permission { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
        NSDictionary JsonRepresentation { get; }
    }

	// @protocol OSPermissionObserver <NSObject>
	[Protocol]
	[Model]
	[BaseType (typeof(NSObject))]
	interface OSPermissionObserver
	{
        // @required -(void)onOSPermissionChanged:(OSPermissionState * _Nonnull)state;
        [Export ("onOSPermissionChanged:")]
        void OnOSPermissionChanged (OSPermissionState state);
    }

	// typedef void (^OSUserResponseBlock)(BOOL);
	delegate void OSUserResponseBlock (bool arg0);

	// typedef void (^OSNotificationWillShowInForegroundBlock)(OSNotification * _Nonnull, OSNotificationDisplayResponse _Nonnull);
	delegate void OSNotificationWillShowInForegroundBlock (OSNotification arg0, [BlockCallback] OSNotificationDisplayResponse arg1);

	// typedef void (^OSNotificationOpenedBlock)(OSNotificationOpenedResult * _Nonnull);
	delegate void OSNotificationOpenedBlock (OSNotificationOpenedResult arg0);

	// @protocol OSNotifications <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface OSNotifications
	{
        // @required +(BOOL)permission __attribute__((swift_private));
		//[Abstract]
        [Export ("permission")]
		//[Verify (MethodToProperty)]
        bool Permission { get; }

        // @required +(BOOL)canRequestPermission __attribute__((swift_private));
		//[Abstract]
        [Export ("canRequestPermission")]
		//[Verify (MethodToProperty)]
        bool CanRequestPermission { get; }

        // @required +(void)setNotificationWillShowInForegroundHandler:(OSNotificationWillShowInForegroundBlock _Nullable)block;
		//[Abstract]
        [Export ("setNotificationWillShowInForegroundHandler:")]
        void SetNotificationWillShowInForegroundHandler ([NullAllowed] OSNotificationWillShowInForegroundBlock block);

        // @required +(void)setNotificationOpenedHandler:(OSNotificationOpenedBlock _Nullable)block;
		//[Abstract]
        [Export ("setNotificationOpenedHandler:")]
        void SetNotificationOpenedHandler ([NullAllowed] OSNotificationOpenedBlock block);

        // @required +(void)requestPermission:(OSUserResponseBlock _Nullable)block;
		//[Abstract]
        [Export ("requestPermission:")]
        void RequestPermission ([NullAllowed] OSUserResponseBlock block);

        // @required +(void)requestPermission:(OSUserResponseBlock _Nullable)block fallbackToSettings:(BOOL)fallback;
		//[Abstract]
        [Export ("requestPermission:fallbackToSettings:")]
        void RequestPermission ([NullAllowed] OSUserResponseBlock block, bool fallback);

        // @required +(void)registerForProvisionalAuthorization:(OSUserResponseBlock _Nullable)block __attribute__((swift_private));
		//[Abstract]
        [Export ("registerForProvisionalAuthorization:")]
        void RegisterForProvisionalAuthorization ([NullAllowed] OSUserResponseBlock block);

        // @required +(void)addPermissionObserver:(NSObject<OSPermissionObserver> * _Nonnull)observer __attribute__((swift_private));
		//[Abstract]
        [Export ("addPermissionObserver:")]
        void AddPermissionObserver (OSPermissionObserver observer);

        // @required +(void)removePermissionObserver:(NSObject<OSPermissionObserver> * _Nonnull)observer __attribute__((swift_private));
		//[Abstract]
        [Export ("removePermissionObserver:")]
        void RemovePermissionObserver (OSPermissionObserver observer);

        // @required +(void)clearAll;
		//[Abstract]
        [Export ("clearAll")]
        void ClearAll ();
    }

    // @protocol OSPushSubscription <NSObject>
    [Protocol]
    [BaseType (typeof(NSObject))]
    interface OSPushSubscription
	{
        // @required @property (readonly, copy, nonatomic) NSString * _Nullable id;
		//[Abstract]
        [NullAllowed, Export ("id")]
        string Id { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable token;
		//[Abstract]
        [NullAllowed, Export ("token")]
        string Token { get; }

        // @required @property (readonly, nonatomic) BOOL optedIn;
		//[Abstract]
        [Export ("optedIn")]
        bool OptedIn { get; }

        // @required -(void)optIn;
		//[Abstract]
        [Export ("optIn")]
		void OptIn ();

        // @required -(void)optOut;
		//[Abstract]
        [Export ("optOut")]
		void OptOut ();

        // @required -(void)addObserver:(id<OSPushSubscriptionObserver> _Nonnull)observer;
        //[Abstract]
        [Export ("addObserver:")]
        void AddObserver (OSPushSubscriptionObserver observer);

        // @required -(void)removeObserver:(id<OSPushSubscriptionObserver> _Nonnull)observer;
		//[Abstract]
        [Export ("removeObserver:")]
        void RemoveObserver (OSPushSubscriptionObserver observer);
    }

    // @protocol OSPushSubscriptionObserver <NSObject>
    [Protocol (Name = "_TtP13OneSignalUser26OSPushSubscriptionObserver_")]
	[Model]
    [BaseType (typeof(NSObject))]
    interface OSPushSubscriptionObserver
	{
        // @required -(void)onOSPushSubscriptionChangedWithStateChanges:(OSPushSubscriptionStateChanges * _Nonnull)stateChanges;
        [Export ("onOSPushSubscriptionChangedWithStateChanges:")]
        void OnOSPushSubscriptionChangedWithStateChanges (OSPushSubscriptionStateChanges stateChanges);
    }

	// @interface OSPushSubscriptionState : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13OneSignalUser23OSPushSubscriptionState")]
	[DisableDefaultCtor]
	interface OSPushSubscriptionState
	{
        // @property (readonly, copy, nonatomic) NSString * _Nullable id;
        [NullAllowed, Export ("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable token;
        [NullAllowed, Export ("token")]
        string Token { get; }

        // @property (readonly, nonatomic) BOOL optedIn;
        [Export ("optedIn")]
        bool OptedIn { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export ("description")]
        string Description { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation __attribute__((warn_unused_result("")));
        [Export ("jsonRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

	// @interface OSPushSubscriptionStateChanges : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13OneSignalUser30OSPushSubscriptionStateChanges")]
	[DisableDefaultCtor]
	interface OSPushSubscriptionStateChanges
	{
        // @property (readonly, nonatomic, strong) OSPushSubscriptionState * _Nonnull to;
        [Export ("to", ArgumentSemantic.Strong)]
        OSPushSubscriptionState To { get; }

        // @property (readonly, nonatomic, strong) OSPushSubscriptionState * _Nonnull from;
        [Export ("from", ArgumentSemantic.Strong)]
        OSPushSubscriptionState From { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export ("description")]
        string Description { get; }

        // -(NSDictionary * _Nonnull)jsonRepresentation __attribute__((warn_unused_result("")));
        [Export ("jsonRepresentation")]
        NSDictionary JsonRepresentation { get; }
    }

    // @protocol OSUser <NSObject>
    [Protocol]
    [BaseType (typeof(NSObject))]
    interface OSUser
	{
        // @required @property (readonly, nonatomic, strong) id<OSPushSubscription> _Nonnull pushSubscription;
		//[Abstract]
        [Export ("pushSubscription", ArgumentSemantic.Strong)]
        OSPushSubscription PushSubscription { get; }

        // @required -(void)addAliasWithLabel:(NSString * _Nonnull)label id:(NSString * _Nonnull)id;
		//[Abstract]
        [Export ("addAliasWithLabel:id:")]
        void AddAliasWithLabel (string label, string id);

        // @required -(void)addAliases:(NSDictionary<NSString *,NSString *> * _Nonnull)aliases;
		//[Abstract]
        [Export ("addAliases:")]
        void AddAliases (NSDictionary<NSString, NSString> aliases);

        // @required -(void)removeAlias:(NSString * _Nonnull)label;
		//[Abstract]
        [Export ("removeAlias:")]
        void RemoveAlias (string label);

        // @required -(void)removeAliases:(NSArray<NSString *> * _Nonnull)labels;
		//[Abstract]
        [Export ("removeAliases:")]
        void RemoveAliases (string[] labels);

        // @required -(void)addTagWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		//[Abstract]
        [Export ("addTagWithKey:value:")]
        void AddTagWithKey (string key, string value);

        // @required -(void)addTags:(NSDictionary<NSString *,NSString *> * _Nonnull)tags;
		//[Abstract]
        [Export ("addTags:")]
        void AddTags (NSDictionary<NSString, NSString> tags);

        // @required -(void)removeTag:(NSString * _Nonnull)tag;
		//[Abstract]
        [Export ("removeTag:")]
        void RemoveTag (string tag);

        // @required -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags;
		//[Abstract]
        [Export ("removeTags:")]
        void RemoveTags (string[] tags);

        // @required -(void)addEmail:(NSString * _Nonnull)email;
		//[Abstract]
        [Export ("addEmail:")]
        void AddEmail (string email);

        // @required -(void)removeEmail:(NSString * _Nonnull)email;
        //[Abstract]
        [Export ("removeEmail:")]
        void RemoveEmail (string email);

        // @required -(void)addSms:(NSString * _Nonnull)number;
        //[Abstract]
        [Export ("addSms:")]
        void AddSms (string number);

        // @required -(void)removeSms:(NSString * _Nonnull)number;
        //[Abstract]
        [Export ("removeSms:")]
        void RemoveSms (string number);

        // @required -(void)setLanguage:(NSString * _Nonnull)language;
        //[Abstract]
        [Export ("setLanguage:")]
        void SetLanguage (string language);

        // @required -(void)onJwtExpiredWithExpiredHandler:(void (^ _Nonnull)(NSString * _Nonnull, __attribute__((noescape)) void (^ _Nonnull)(NSString * _Nonnull)))expiredHandler;
        //[Abstract]
        //[Export ("onJwtExpiredWithExpiredHandler:")]
        //void OnJwtExpiredWithExpiredHandler (Action<NSString, Action<NSString>> expiredHandler);
    }

	// @interface OSInAppMessage : NSObject
	[BaseType (typeof(NSObject))]
	interface OSInAppMessage
	{
        // @property (nonatomic, strong) NSString * _Nonnull messageId;
        [Export ("messageId", ArgumentSemantic.Strong)]
        string MessageId { get; set; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
		//[Verify (MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

	// @interface OSInAppMessageTag : NSObject
	[BaseType (typeof(NSObject))]
	interface OSInAppMessageTag
	{
        // @property (nonatomic, strong) NSDictionary * _Nullable tagsToAdd;
        [NullAllowed, Export ("tagsToAdd", ArgumentSemantic.Strong)]
        NSDictionary TagsToAdd { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable tagsToRemove;
        [NullAllowed, Export ("tagsToRemove", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
        NSObject[] TagsToRemove { get; set; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
		//[Verify (MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

	// @interface OSInAppMessageAction : NSObject
	[BaseType (typeof(NSObject))]
	interface OSInAppMessageAction
	{
        // @property (nonatomic, strong) NSString * _Nullable clickName;
        [NullAllowed, Export ("clickName", ArgumentSemantic.Strong)]
        string ClickName { get; set; }

        // @property (nonatomic, strong) NSURL * _Nullable clickUrl;
        [NullAllowed, Export ("clickUrl", ArgumentSemantic.Strong)]
        NSUrl ClickUrl { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable pageId;
        [NullAllowed, Export ("pageId", ArgumentSemantic.Strong)]
        string PageId { get; set; }

        // @property (nonatomic) BOOL firstClick;
        [Export ("firstClick")]
        bool FirstClick { get; set; }

        // @property (nonatomic) BOOL closesMessage;
        [Export ("closesMessage")]
        bool ClosesMessage { get; set; }

        // @property (nonatomic, strong) NSArray<OSInAppMessageOutcome *> * _Nullable outcomes;
        [NullAllowed, Export ("outcomes", ArgumentSemantic.Strong)]
        OSInAppMessageOutcome[] Outcomes { get; set; }

        // @property (nonatomic, strong) OSInAppMessageTag * _Nullable tags;
        [NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
        OSInAppMessageTag Tags { get; set; }

        // -(NSDictionary * _Nonnull)jsonRepresentation;
        [Export ("jsonRepresentation")]
		//[Verify (MethodToProperty)]
        NSDictionary JsonRepresentation { get; }
    }

	// @protocol OSInAppMessageLifecycleHandler <NSObject>
	[Protocol]
	[Model]
	[BaseType (typeof(NSObject))]
	interface OSInAppMessageLifecycleHandler
	{
        // @optional -(void)onWillDisplayInAppMessage:(OSInAppMessage * _Nonnull)message;
        [Export ("onWillDisplayInAppMessage:")]
        void OnWillDisplayInAppMessage (OSInAppMessage message);

        // @optional -(void)onDidDisplayInAppMessage:(OSInAppMessage * _Nonnull)message;
        [Export ("onDidDisplayInAppMessage:")]
        void OnDidDisplayInAppMessage (OSInAppMessage message);

        // @optional -(void)onWillDismissInAppMessage:(OSInAppMessage * _Nonnull)message;
        [Export ("onWillDismissInAppMessage:")]
        void OnWillDismissInAppMessage (OSInAppMessage message);

        // @optional -(void)onDidDismissInAppMessage:(OSInAppMessage * _Nonnull)message;
        [Export ("onDidDismissInAppMessage:")]
        void OnDidDismissInAppMessage (OSInAppMessage message);
    }

	// @protocol OSInAppMessages <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface OSInAppMessages
	{
        // @required +(void)addTrigger:(NSString * _Nonnull)key withValue:(id _Nonnull)value;
		//[Abstract]
        [Export ("addTrigger:withValue:")]
        void AddTrigger (string key, NSObject value);

        // @required +(void)addTriggers:(NSDictionary<NSString *,id> * _Nonnull)triggers;
		//[Abstract]
        [Export ("addTriggers:")]
        void AddTriggers (NSDictionary<NSString, NSObject> triggers);

        // @required +(void)removeTrigger:(NSString * _Nonnull)key;
		//[Abstract]
        [Export ("removeTrigger:")]
        void RemoveTrigger (string key);

        // @required +(void)removeTriggers:(NSArray<NSString *> * _Nonnull)keys;
		//[Abstract]
        [Export ("removeTriggers:")]
        void RemoveTriggers (string[] keys);

        // @required +(void)clearTriggers;
		//[Abstract]
        [Export ("clearTriggers")]
        void ClearTriggers ();

        // @required +(BOOL)paused __attribute__((swift_private));
		//[Abstract]
        [Export ("paused")]
		//[Verify (MethodToProperty)]
        bool IsPaused { get; }

        // @required +(void)paused:(BOOL)pause __attribute__((swift_private));
		//[Abstract]
        [Export ("paused:")]
        void SetPaused (bool pause);

        // @required +(void)setClickHandler:(OSInAppMessageClickBlock _Nullable)block;
		//[Abstract]
        [Export ("setClickHandler:")]
        void SetClickHandler ([NullAllowed] OSInAppMessageClickBlock block);

        // @required +(void)setLifecycleHandler:(NSObject<OSInAppMessageLifecycleHandler> * _Nullable)delegate;
		//[Abstract]
        [Export ("setLifecycleHandler:")]
        void SetLifecycleHandler ([NullAllowed] OSInAppMessageLifecycleHandler @delegate);
    }

	// typedef void (^OSInAppMessageClickBlock)(OSInAppMessageAction * _Nonnull);
	delegate void OSInAppMessageClickBlock (OSInAppMessageAction arg0);

	// @protocol OSLocation <NSObject>
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface OSLocation
	{
        // @required +(void)requestPermission;
		//[Abstract]
        [Export ("requestPermission")]
        void RequestPermission ();

        // @required +(void)setShared:(BOOL)enable __attribute__((swift_private));
		//[Abstract]
        [Export ("setShared:")]
        void SetShared (bool enable);

        // @required +(BOOL)isShared __attribute__((swift_private));
		//[Abstract]
        [Export ("isShared")]
		//[Verify (MethodToProperty)]
        bool IsShared { get; }
    }

	// @interface OneSignal : NSObject
	[BaseType (typeof(NSObject))]
	interface OneSignal
	{
        // +(NSString *)appId;
        [Static]
        [Export ("appId")]
		//[Verify (MethodToProperty)]
        string AppId { get; }

        // +(NSString * _Nonnull)sdkVersionRaw;
        [Static]
        [Export ("sdkVersionRaw")]
		//[Verify (MethodToProperty)]
        string SdkVersionRaw { get; }

        // +(NSString * _Nonnull)sdkSemanticVersion;
        [Static]
        [Export ("sdkSemanticVersion")]
		//[Verify (MethodToProperty)]
        string SdkSemanticVersion { get; }

        // +(id<OSUser>)User __attribute__((swift_private));
        [Static]
        [Export ("User")]
		//[Verify (MethodToProperty)]
        OSUser User { get; }

        // +(void)login:(NSString * _Nonnull)externalId;
        [Static]
        [Export ("login:")]
        void Login (string externalId);

        // +(void)login:(NSString * _Nonnull)externalId withToken:(NSString * _Nullable)token __attribute__((swift_name("login(externalId:token:)")));
        [Static]
        [Export ("login:withToken:")]
        void Login (string externalId, [NullAllowed] string token);

        // +(void)logout;
        [Static]
        [Export ("logout")]
        void Logout ();

        // +(Class<OSNotifications>)Notifications __attribute__((swift_private));
        [Static]
        [Export ("Notifications")]
		//[Verify (MethodToProperty)]
        OSNotifications Notifications { get; }

        // +(void)setLaunchOptions:(NSDictionary * _Nullable)newLaunchOptions;
        [Static]
        [Export ("setLaunchOptions:")]
        void SetLaunchOptions([NullAllowed] NSDictionary newLaunchOptions);

        // +(void)initialize:(NSString * _Nonnull)newAppId withLaunchOptions:(NSDictionary * _Nullable)launchOptions;
        [Static]
        [Export ("initialize:withLaunchOptions:")]
        void Initialize (string newAppId, [NullAllowed] NSDictionary launchOptions);

        // +(void)setLaunchURLsInApp:(BOOL)launchInApp;
        [Static]
        [Export ("setLaunchURLsInApp:")]
        void SetLaunchURLsInApp (bool launchInApp);

        // +(void)setProvidesNotificationSettingsView:(BOOL)providesView;
        [Static]
        [Export ("setProvidesNotificationSettingsView:")]
        void SetProvidesNotificationSettingsView (bool providesView);

        // +(void)enterLiveActivity:(NSString * _Nonnull)activityId withToken:(NSString * _Nonnull)token;
        [Static]
        [Export ("enterLiveActivity:withToken:")]
        void EnterLiveActivity(string activityId, string token);

        // +(void)enterLiveActivity:(NSString * _Nonnull)activityId withToken:(NSString * _Nonnull)token withSuccess:(OSResultSuccessBlock _Nullable)successBlock withFailure:(OSFailureBlock _Nullable)failureBlock;
        [Static]
        [Export ("enterLiveActivity:withToken:withSuccess:withFailure:")]
        void EnterLiveActivity(string activityId, string token, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

        // +(void)exitLiveActivity:(NSString * _Nonnull)activityId;
        [Static]
        [Export ("exitLiveActivity:")]
        void ExitLiveActivity(string activityId);

        // +(void)exitLiveActivity:(NSString * _Nonnull)activityId withSuccess:(OSResultSuccessBlock _Nullable)successBlock withFailure:(OSFailureBlock _Nullable)failureBlock;
        [Static]
        [Export ("exitLiveActivity:withSuccess:withFailure:")]
        void ExitLiveActivity(string activityId, [NullAllowed] OSResultSuccessBlock successBlock, [NullAllowed] OSFailureBlock failureBlock);

        // +(Class<OSDebug>)Debug __attribute__((swift_private));
        [Static]
        [Export ("Debug")]
		//[Verify (MethodToProperty)]
        OSDebug Debug { get; }

        // +(void)setPrivacyConsent:(BOOL)granted __attribute__((swift_private));
        [Static]
        [Export ("setPrivacyConsent:")]
        void SetPrivacyConsent (bool granted);

        // +(BOOL)getPrivacyConsent __attribute__((swift_private));
        [Static]
        [Export ("getPrivacyConsent")]
		//[Verify (MethodToProperty)]
        bool PrivacyConsent { get; }

        // +(BOOL)requiresPrivacyConsent __attribute__((swift_private));
        // +(void)setRequiresPrivacyConsent:(BOOL)required __attribute__((swift_private));
        [Static]
        [Export ("requiresPrivacyConsent")]
		//[Verify (MethodToProperty)]
        bool RequiresPrivacyConsent { get; set; }

        // +(Class<OSInAppMessages>)InAppMessages __attribute__((swift_private));
        [Static]
        [Export ("InAppMessages")]
        OSInAppMessages InAppMessages { get; }

        // +(Class<OSLocation>)Location __attribute__((swift_private));
        [Static]
        [Export ("Location")]
        OSLocation Location { get; }

        // +(Class<OSSession>)Session __attribute__((swift_private));
        [Static]
        [Export ("Session")]
        OSSession Session { get; }

        // +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent __attribute__((deprecated("Please use didReceiveNotificationExtensionRequest:withMutableNotificationContent:withContentHandler: instead.")));
        [Static]
        [Export ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:")]
        UNMutableNotificationContent DidReceiveNotificationExtensionRequest (UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent);

        // +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent withContentHandler:(void (^)(UNNotificationContent * _Nonnull))contentHandler;
        [Static]
        [Export ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:withContentHandler:")]
        UNMutableNotificationContent DidReceiveNotificationExtensionRequest (UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent, Action<UNNotificationContent> contentHandler);

        // +(UNMutableNotificationContent *)serviceExtensionTimeWillExpireRequest:(UNNotificationRequest * _Nonnull)request withMutableNotificationContent:(UNMutableNotificationContent * _Nullable)replacementContent;
        [Static]
        [Export ("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:")]
        UNMutableNotificationContent ServiceExtensionTimeWillExpireRequest (UNNotificationRequest request, [NullAllowed] UNMutableNotificationContent replacementContent);
    }
}