using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

using OneSignalSDK.Xamarin;
using OneSignalSDK.Xamarin.Core;

namespace OneSignalApp.Sample.Shared
{
   public static class SharedPush
   {
      // Called on iOS and Android to initialize OneSignal
      public static void Initialize()
      {
         OneSignal.Default.LogLevel = LogLevel.VERBOSE;
         OneSignal.Default.AlertLevel = LogLevel.NONE;

         OneSignal.Default.RequiresPrivacyConsent = true;

         OneSignal.Default.Initialize("77e32082-ea27-42e3-a898-c72e141824ef");

         OneSignal.Default.PrivacyConsent = true;

         OneSignalInAppMessagingDemo();
         OneSignalOutcomeEventDemo();

         OneSignal.Default.InAppMessageWillDisplay += _inAppMessageWillDisplay;
         OneSignal.Default.InAppMessageDidDisplay += _inAppMessageDidDisplay;
         OneSignal.Default.InAppMessageWillDismiss += _inAppMessageWillDismiss;
         OneSignal.Default.InAppMessageDidDismiss += _inAppMessageDidDismiss;

         OneSignal.Default.InAppMessageTriggeredAction += _inAppMessageTriggeredAction;

         _ = promptForNotificationsAsync();
      }

      private static async Task promptForNotificationsAsync()
      {
         var accepted = await OneSignal.Default.PromptForPushNotificationsWithUserResponse();
         Console.WriteLine("PromptForPushResponse: " + accepted);
      }

      private static void _inAppMessageTriggeredAction(InAppMessageAction action) {
         Console.WriteLine("In-App message Triggered Action: " + action.clickName);
      }

      private static void _inAppMessageWillDisplay(InAppMessage message) {
         Console.WriteLine("In-App message will display: " + message.messageId);
      }

      private static void _inAppMessageDidDisplay(InAppMessage message) {
         Console.WriteLine("In-App message did display: " + message.messageId);
      }

      private static void _inAppMessageWillDismiss(InAppMessage message) {
         Console.WriteLine("In-App message will dismiss: " + message.messageId);
      }

      private static void _inAppMessageDidDismiss(InAppMessage message) {
         Console.WriteLine("In-App message did dismiss: " + message.messageId);
      }

      private static void OneSignalSetExternalUSerId(Dictionary<string , object> results)
      {
         Debug.WriteLine("External user id updated with results: " + Json.Serialize(results));
      }

      private static void OneSignalInAppMessagingDemo()
      {
         // Add a trigger to show an IAM
         OneSignal.Default.SetTrigger("trigger_1", "one");

         // Get the trigger value for a trigger key
         object value = OneSignal.Default.GetTrigger("trigger_1");
         Debug.WriteLine("trigger_1 value: " + value);

         // Add multiple triggers at once
         Dictionary<string, object> triggers = new Dictionary<string, object>();
         triggers.Add("trigger_2", "two");
         triggers.Add("trigger_3", "three");
         OneSignal.Default.SetTriggers(triggers);

         // Remove a trigger
         OneSignal.Default.RemoveTrigger("trigger_2");

         // Remove several triggers at once
         List<string> removeKeys = new List<string>();
         removeKeys.Add("trigger_1");
         removeKeys.Add("trigger_3");
         OneSignal.Default.RemoveTriggers(removeKeys.ToArray());

         // Toggle showing of IAMs
         OneSignal.Default.InAppMessagesArePaused = false;
      }

      private static void OneSignalOutcomeEventDemo()
      {
         // Show a normal outcome with and without a callback
         OneSignal.Default.SendOutcome("normal_1");

         //result.
         // Show a unique outcome with and without a callback
         OneSignal.Default.SendUniqueOutcome("unique_1");


         // Show an outcome with value with and without a callback
         OneSignal.Default.SendOutcomeWithValue("value_1", 3.2f);
      }

      // Just for iOS.
      // No effect on Android, device auto registers without prompting.
      public static void RegisterIOS() {
         OneSignal.Default.PromptForPushNotificationsWithUserResponse();
      }

      public static void ConsentStatusChanged(bool consent) {
         OneSignal.Default.PrivacyConsent = consent;
      }

      public static bool UserDidProvideConsent() {
         return !OneSignal.Default.RequiresPrivacyConsent;
      }

      public static void SetRequiresConsent(bool required) {
         OneSignal.Default.RequiresPrivacyConsent = required;
      }

      public static void SetExternalUserId(string externalId) {
         OneSignal.Default.SetExternalUserId(externalId);

         OneSignal.Default.SetExternalUserId(externalId, "your_auth_hash_token");
      }

      public static void RemoveExternalUserId() {
         OneSignal.Default.RemoveExternalUserId();
      }

      public static void SendOutcome(string outcomeName) {
         OneSignal.Default.SendOutcome(outcomeName);
      }

      public static void SendUniqueOutcome(string outcomeName) {
         OneSignal.Default.SendUniqueOutcome(outcomeName);
      }

      public static void SendOutcomeWithValue(string outcomeName, float value) {
         OneSignal.Default.SendOutcomeWithValue(outcomeName, value);
      }
   }
}
