using System;
using System.Collections.Generic;


namespace Com.OneSignal.Core {
   public class Notification {
      public string title;
      public string body;
      public string sound;
      public string launchUrl;
      public string rawPayload;
      public List<ActionButton> actionButtons;
      public Dictionary<string, object> additionalData;
      public string notificationId;
      public List<Notification> groupedNotifications;
      public BackgroundImageLayout backgroundImageLayout;

      // android only
      public string groupKey;
      public string groupMessage;
      public string ledColor;
      public int priority;
      public string smallIcon;
      public string largeIcon;
      public string bigPicture;
      public string CollapseId;
      public string fromProjectNumber;
      public string smallIconAccentColor;
      public int lockScreenVisibility;
      public int androidNotificationId;

      //ios only
      public string badge;
      public string badgeIncrement;
      public string category;
      public string threadId;
      public string subtitle;
      public string templateId;
      public string templateName;
      public float relevanceScore;
      public bool mutableContent;
      public bool contentAvailable;
      public string interruptionLevel;
   }

   public class ActionButton {
      public string id;
      public string text;
      public string icon;

      public ActionButton(string id, string text, string icon) {
         this.id = id;
         this.text = text;
         this.icon = icon;
      }
   }

   public class BackgroundImageLayout {
      public string image;
      public string titleTextColor;
      public string bodyTextColor;

      public BackgroundImageLayout(string image, string titleTextColor, string bodyTextColor) {
         this.image = image;
         this.titleTextColor = titleTextColor;
         this.bodyTextColor = bodyTextColor;
      }
   }
}
