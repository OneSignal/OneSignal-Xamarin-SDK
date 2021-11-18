using System;
namespace Com.OneSignal.Core {
    /// <summary>
    /// todo - desc
    /// </summary>
    public enum NotificationActionType {
        /// <summary>Notification was tapped on.</summary>
        Opened,

        /// <summary>User tapped on an action from the notification.</summary>
        ActionTaken
    }

    /// <summary>
    /// todo - struct?
    /// </summary>
    public class NotificationAction {
        /// <summary>todo</summary>
        public string ActionId;

        /// <summary>todo</summary>
        public NotificationActionType ActionType;
    }
}
