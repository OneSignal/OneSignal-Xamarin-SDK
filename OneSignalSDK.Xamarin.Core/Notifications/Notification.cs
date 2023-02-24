using System;
using System.Collections.Generic;

namespace OneSignalSDK.Xamarin.Core.Notifications;

/// <summary>
/// Represents a notification.
/// </summary>
public record Notification
{
    /// <summary>
    /// The title displayed to the user.
    /// </summary>
    public string? Title { get; }

    /// <summary>
    /// The body displayed to the user.
    /// </summary>
    public string? Body { get; }

    /// <summary>
    /// The sound information specified when creating the notification.
    /// </summary>
    public string? Sound { get; }

    /// <summary>
    /// The launch URL information specified when creating the notification.
    /// </summary>
    public string? LaunchUrl { get; }

    /// <summary>
    /// The action buttons specified when creating the notification.
    /// </summary>
    public IList<ActionButton> ActionButtons { get; } = new List<ActionButton>();

    /// <summary>
    /// The key/value custom additional data specified when creating the notification.
    /// </summary>
    public IDictionary<string, object> AdditionalData { get; } = new Dictionary<string, object>();

    /// <summary>
    /// The OneSignal notification id.
    /// </summary>
    public string? NotificationId { get; }

    /// <summary>
    /// When non-null this is a summary notification, and this contains the list of notifications this summarizes.
    /// </summary>
    public IList<Notification>? GroupedNotifications { get; }

    /// <summary>
    /// The background image layout information specified when creating the notification.
    /// </summary>
    public BackgroundImageLayout? BackgroundImageLayout { get; }

    /// <summary>
    /// The id of the OneSignal tempalte that created this notification. If no template was used,
    /// this will be null.
    /// </summary>
    public string? TemplateId { get; }

    /// <summary>
    /// The name of the OneSignal template that created this notification. If no template was
    /// used, this will be null.
    /// </summary>
    public string? TemplateName { get; }

    #region Android
    /// <summary>
    /// (Android Only) The group key information specified when creating the notification.
    /// </summary>
    public string? GroupKey { get; }

    /// <summary>
    /// (Android Only) The group message information specified when creating the notification.
    /// </summary>
    public string? GroupMessage { get; }

    /// <summary>
    /// (Android Only) The LED color information specified when creating the notification.
    /// </summary>
    public string? LedColor { get; }

    /// <summary>
    /// (Android Only) The priority information specified when creating the notification.
    /// </summary>
    public int? Priority { get; }

    /// <summary>
    /// (Android Only) The small icon information specified when creating the notification.
    /// </summary>
    public string? SmallIcon { get; }

    /// <summary>
    /// (Android Only) The large icon information specified when creating the notification.
    /// </summary>
    public string? LargeIcon { get; }

    /// <summary>
    /// (Android Only) The big picture information specified when creating the notification.
    /// </summary>
    public string? BigPicture { get; }

    /// <summary>
    /// (Android Only) The collapse ID specified when creating the notification.
    /// </summary>
    public string? CollapseId { get; }

    /// <summary>
    /// (Android Only) The from project information specified when creating the notification.
    /// </summary>
    public string? FromProjectNumber { get; }

    /// <summary>
    /// (Android Only) The accent color of the small icon specified when creating the notification.
    /// </summary>
    public string? SmallIconAccentColor { get; }

    /// <summary>
    /// (Android Only) The lock screen visibility information specified when creating the notification.
    /// </summary>
    public int? LockScreenVisibility { get; }

    /// <summary>
    /// (Android Only) Android notification id. Can later be used to dismiss the notification programmatically.
    /// </summary>
    public int? AndroidNotificationId { get; }
    #endregion Android

    #region iOS
    /// <summary>
    /// What to set the badge number to when this notification is received.
    /// </summary>
    public int? Badge { get; }

    /// <summary>
    /// How much to increment this badge number when this notification is received.
    /// </summary>
    public int? BadgeIncrement { get; }

    /// <summary>
    /// (iOS Only) Show associated actions and buttons for the category.
    /// </summary>
    public string? Category { get; }

    /// <summary>
    /// The ID of the thread (group) this notification is within.
    /// </summary>
    public string? ThreadId { get; }

    /// <summary>
    /// (iOS Only) The subtitle of the notification.
    /// </summary>
    public string? Subtitle { get; }

    /// <summary>
    /// (iOS Only) The order the notification is shown for users that have chosen to receive your notifications as part
    /// of their Scheduled Summary digest (iOS 15+).
    /// </summary>
    public float? RelevanceScore { get; }

    /// <summary>
    /// (iOS Only) Whether content is mutable.
    /// </summary>
    public bool? MutableContent { get; }

    /// <summary>
    /// (iOS Only) Whether content is available.
    /// </summary>
    public bool? ContentAvailable { get; }

    /// <summary>
    /// (iOS Only) When and how the notification is displayed.
    /// </summary>
    public string? InterruptionLevel { get; }
    #endregion iOS

   public Notification(
      string? title,
      string? body,
      string? sound,
      string? launchUrl,
      IList<ActionButton> actionButtons,
      IDictionary<string, object> additionalData,
      string? notificationId,
      IList<Notification>? groupedNotifications,
      BackgroundImageLayout? backgroundImageLayout,
      string? templateId = null,
      string? templateName = null,
      string? groupKey = null,
      string? groupMessage = null,
      string? ledColor = null,
      int? priority = null,
      string? smallIcon = null,
      string? largeIcon = null,
      string? bigPicture = null,
      string? collapseId = null,
      string? fromProjectNumber = null,
      string? smallIconAccentColor = null,
      int? lockScreenVisibility = null,
      int? androidNotificationId = null,
      int? badge = null,
      int? badgeIncrement = null,
      string? category = null,
      string? threadId = null,
      string? subtitle = null,
      float? relevanceScore = null,
      bool? mutableContent = null,
      bool? contentAvailable = null,
      string? interruptionLevel = null)
   {
      Title = title;
      Body = body;
      Sound = sound;
      LaunchUrl = launchUrl;
      ActionButtons = actionButtons;
      AdditionalData = additionalData;
      NotificationId = notificationId;
      GroupedNotifications = groupedNotifications;
      BackgroundImageLayout = backgroundImageLayout;
      TemplateId = templateId;
      TemplateName = templateName;
      GroupKey = groupKey;
      GroupMessage = groupMessage;
      LedColor = ledColor;
      Priority = priority;
      SmallIcon = smallIcon;
      LargeIcon = largeIcon;
      BigPicture = bigPicture;
      CollapseId = collapseId;
      FromProjectNumber = fromProjectNumber;
      SmallIconAccentColor = smallIconAccentColor;
      LockScreenVisibility = lockScreenVisibility;
      AndroidNotificationId = androidNotificationId;
      Badge = badge;
      BadgeIncrement = badgeIncrement;
      Category = category;
      ThreadId = threadId;
      Subtitle = subtitle;
      RelevanceScore = relevanceScore;
      MutableContent = mutableContent;
      ContentAvailable = contentAvailable;
      InterruptionLevel = interruptionLevel;
   }
}

/// <summary>
/// An action button within a <see cref="Notification"/>.
/// </summary>
public record ActionButton
{
    /// <summary>
    /// The ID of the action button specified when creating the notification.
    /// </summary>
    public string? Id { get; }

    /// <summary>
    /// The text displayed on the action button.
    /// </summary>
    public string? Text { get; }

    /// <summary>
    /// The icon displayed on the action button.
    /// </summary>
    public string? Icon { get; }

   public ActionButton(string? id, string? text, string? icon)
   {
      Id = id;
      Text = text;
      Icon = icon;
   }
}

/// <summary>
/// Background image layout information for a <see cref="Notification"/>.
/// </summary>
public record BackgroundImageLayout
{
    /// <summary>
    /// The asset file, android resource name, or URL to remote image.
    /// </summary>
    public string? Image { get; }

    /// <summary>
    /// The title text color.
    /// </summary>
    public string? TitleTextColor { get; }

    /// <summary>
    /// The body text color.
    /// </summary>
    public string? BodyTextColor { get; }

   public BackgroundImageLayout(string? image, string? titleTextColor, string? bodyTextColor)
   {
      Image = image;
      TitleTextColor = titleTextColor;
      BodyTextColor = bodyTextColor;
   }
}
