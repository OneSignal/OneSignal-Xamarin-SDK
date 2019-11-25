using System;
using System.Collections.Generic;

namespace Com.OneSignal.Abstractions
{
   public class OSOutcomeEvent
   {

      public enum OSSession
      {
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

      public OSOutcomeEvent() {}

      public OSOutcomeEvent(string session, List<string> notificationIds, string name, long timestamp, double weight)
      {
         this.session = SessionFromString(session);
         this.notificationIds = notificationIds;
         this.name = name;
         this.timestamp = timestamp;
         this.weight = weight;
      }

      public OSOutcomeEvent(Dictionary<string, object> outcomeObject)
      {
         // session;
         if (outcomeObject.ContainsKey("session"))
            this.session = SessionFromString(outcomeObject["session"] as string);

         // notificationIds
         if (outcomeObject.ContainsKey("notification_ids")) {
            List<object> idObjects = outcomeObject["notification_ids"] as List<object>;
            List<string> ids = new List<string>();
            foreach (var id in idObjects)
                  ids.Add(id.ToString());

            this.notificationIds = ids;
         }

         // id
         if (outcomeObject.ContainsKey("id"))
            this.name = outcomeObject["id"] as string;

         // timestamp
         if (outcomeObject.ContainsKey("timestamp"))
            this.timestamp = (long) outcomeObject["timestamp"];

         // weight
         if (outcomeObject.ContainsKey("weight")) {
            if (outcomeObject["weight"] is Int64)
                  this.weight = (Int64) outcomeObject["weight"];
            if (outcomeObject["weight"] is Double)
                  this.weight = (Double) outcomeObject["weight"];
         }

      }

      public static OSSession SessionFromString(string session)
      {
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
