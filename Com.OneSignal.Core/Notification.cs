using System;
using System.Collections.Generic;

//using Org.Json;


namespace Com.OneSignal.Core {
   public class Notification {
      public int androidNotificationId;
      public List<Notification> groupedNotifications;
      public string notificationId;
      public string templateName;
      public string templateId;
      public string title;
      public string body;
      //public JSONObject additionalData;
      public string smallIcon;
      public string largeIcon;
      public string bigPicture;
      public string smallIconAccentColor;
      public string launchUrl;
      public string sound;
      public string ledColor;
      public int lockScreenVisibility;
      public string groupKey;
      public string groupMessage;
      public List<ActionButton> actionButtons;
      public string fromProjectNumber;
      public BackgroundImageLayout backgroundImageLayout;
      public string CollapseId;
      public int priority;
      public string rawPayload;
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
