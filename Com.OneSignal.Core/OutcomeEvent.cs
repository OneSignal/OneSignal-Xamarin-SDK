using System;
using System.Collections.Generic;

namespace Com.OneSignal.Core {
   public class OutcomeEvent {
      public enum OSSession {
         DIRECT,
         INDIRECT,
         UNATTRIBUTED,
         DISABLED
      }

      public OSSession session = OSSession.DISABLED;
      public List<string> notificationIds = new List<string>();
      public string name = "";
      public long timestamp = 0;
      public double weight = 0;

      public OutcomeEvent() { }

      public OutcomeEvent(IReadOnlyDictionary<string, object> outcomeDict) {
         // session
         if (outcomeDict.ContainsKey("session") && outcomeDict["session"] != null)
            this.session = _sessionFromString(outcomeDict["session"] as string);

         // notificationIds
         if (outcomeDict.ContainsKey("notification_ids") && outcomeDict["notification_ids"] != null) {
            List<string> notifications = new List<string>();

            if (outcomeDict["notification_ids"].GetType().Equals(typeof(string))) {
               // notificationIds come over as a string of comma seperated string ids
               notifications = new List<string> { Convert.ToString(outcomeDict["notification_ids"] as string) };
            }
            else {
               // notificationIds come over as a List<object> and should be parsed and appended to the List<string>
               List<object> idObjects = outcomeDict["notification_ids"] as List<object>;
               foreach (var id in idObjects)
                  notifications.Add(id.ToString());
            }

            this.notificationIds = notifications;
         }

         // id
         if (outcomeDict.ContainsKey("id") && outcomeDict["id"] != null)
            this.name = outcomeDict["id"] as string;

         // timestamp
         if (outcomeDict.ContainsKey("timestamp") && outcomeDict["timestamp"] != null)
            this.timestamp = (long)outcomeDict["timestamp"];

         // weight
         if (outcomeDict.ContainsKey("weight") && outcomeDict["weight"] != null)
            this.weight = double.Parse(Convert.ToString(outcomeDict["weight"]));
      }

      public static OSSession _sessionFromString(string session) {
         session = session.ToLower();
         if (session == "direct")
            return OSSession.DIRECT;
         if (session == "indirect")
            return OSSession.INDIRECT;
         if (session == "unattributed")
            return OSSession.UNATTRIBUTED;

         return OSSession.DISABLED;
      }
   }
}
