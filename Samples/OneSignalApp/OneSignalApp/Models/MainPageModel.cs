using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using OneSignalSDK.Xamarin;
using OneSignalSDK.Xamarin.Core.Debug;
using OneSignalSDK.Xamarin.Core.User.Subscriptions;
using Xamarin.Forms;

namespace OneSignalApp.Models
{
   public class MainPageModel : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      private string _appId = "77e32082-ea27-42e3-a898-c72e141824ef";
      public string AppId
      {
         get => _appId;
         private set
         {
            if (_appId != value)
            {
               _appId = value;
               OnPropertyChanged();
            }
         }
      }

      private bool _hasGivenPrivacyConsent;
      public bool HasGivenPrivacyConsent
      {
         get => _hasGivenPrivacyConsent;
         private set
         {
            if (_hasGivenPrivacyConsent != value)
            {
               _hasGivenPrivacyConsent = value;
               OnPropertyChanged();
            }
         }
      }

      private string _pushSubscriptionId;
      public string PushSubscriptionId
      {
         get => _pushSubscriptionId;
         private set
         {
            if (_pushSubscriptionId != value)
            {
               _pushSubscriptionId = value;
               OnPropertyChanged();
            }
         }
      }

      private bool _isPushEnabled;
      public bool IsPushEnabled
      {
         get => _isPushEnabled;
         set
         {
            if (_isPushEnabled != value)
            {
               if (value && !OneSignal.Default.User.PushSubscription.OptedIn)
               {
                  OneSignal.Default.User.PushSubscription.OptIn();
               }
               else if (!value && OneSignal.Default.User.PushSubscription.OptedIn)
               {
                  OneSignal.Default.User.PushSubscription.OptOut();
               }

               _isPushEnabled = value;
               OnPropertyChanged();
            }
         }
      }

      private bool _hasPushPermission;
      public bool HasPushPermission
      {
         get => _hasPushPermission;
         private set
         {
            if (_hasPushPermission != value)
            {
               _hasPushPermission = value;
               OnPropertyChanged();
            }
         }
      }

      private bool _isIAMPaused;
      public bool IsIAMPaused
      {
         get => _isIAMPaused;
         set
         {
            if (_isIAMPaused != value)
            {
               if (value != OneSignal.Default.InAppMessages.Paused)
               {
                  OneSignal.Default.InAppMessages.Paused = value;
               }

               _isIAMPaused = value;
               OnPropertyChanged();
            }
         }
      }

      private bool _isLocationShared;
      public bool IsLocationShared
      {
         get => _isLocationShared;
         set
         {
            if (_isLocationShared != value)
            {
               if (value != OneSignal.Default.Location.IsShared)
               {
                  OneSignal.Default.Location.IsShared = value;
               }

               _isLocationShared = value;
               OnPropertyChanged();
            }
         }
      }

      private string _liveActivityId;
      public string LiveActivityId
      {
         get => _liveActivityId;
         set
         {
            if (_liveActivityId != value)
            {
               _liveActivityId = value;
               OnPropertyChanged();
            }
         }
      }

      public ICommand GivePrivacyConsentCommand { get; }
      public ICommand RevokePrivacyConsentCommand { get; }
      public ICommand LoginUserCommand { get; }
      public ICommand LogoutUserCommand { get; }
      public ICommand AddAliasCommand { get; }
      public ICommand PromptForPushCommand { get; }
      public ICommand AddEmailCommand { get; }
      public ICommand AddSMSCommand { get; }
      public ICommand AddTagCommand { get; }
      public ICommand AddOutcomeCommand { get; }
      public ICommand AddTriggerCommand { get; }
      public ICommand PromptForLocationCommand { get; }
      public ICommand EnterLiveActivityCommand { get; }
      public ICommand ExitLiveActivityCommand { get; }
      public ICommand ValidationCommand { get; }

      private Page _page;

      public MainPageModel(Page page)
      {
         _page = page;

         GivePrivacyConsentCommand = new Command(GivePrivacyConsent);
         RevokePrivacyConsentCommand = new Command(RevokePrivacyConsent);
         LoginUserCommand = new Command(LoginUser);
         LogoutUserCommand = new Command(LogoutUser);
         AddAliasCommand = new Command(AddAlias);
         PromptForPushCommand = new Command(PromptForPush);
         AddEmailCommand = new Command(AddEmail);
         AddSMSCommand = new Command(AddSMS);
         AddTagCommand = new Command(AddTag);
         AddOutcomeCommand = new Command(AddOutcome);
         AddTriggerCommand = new Command(AddTrigger);
         PromptForLocationCommand = new Command(PromptForLocation);
         EnterLiveActivityCommand = new Command(EnterLiveActivity);
         ExitLiveActivityCommand = new Command(ExitLiveActivity);
         ValidationCommand = new Command(Validation);

         // Initialize OneSignal SDK.
         OneSignal.Default.Debug.LogLevel = LogLevel.VERBOSE;
         OneSignal.Default.Debug.AlertLevel = LogLevel.NONE;

         OneSignal.Default.RequiresPrivacyConsent = true;
         OneSignal.Default.PrivacyConsent = false;

         OneSignal.Default.Initialize(_appId);

         OneSignal.Default.User.PushSubscription.Changed += PushSubscription_Changed;
         OneSignal.Default.Notifications.PermissionChanged += Notifications_PermissionChanged;
         OneSignal.Default.Notifications.Clicked += Notifications_Clicked;
         OneSignal.Default.Notifications.WillDisplay += Notifications_WillDisplay;

         OneSignal.Default.InAppMessages.WillDisplay += InAppMessages_WillDisplay;
         OneSignal.Default.InAppMessages.DidDisplay += InAppMessages_DidDisplay;
         OneSignal.Default.InAppMessages.WillDismiss += InAppMessages_WillDismiss;
         OneSignal.Default.InAppMessages.DidDismiss += InAppMessages_DidDismiss;
         OneSignal.Default.InAppMessages.Clicked += InAppMessages_Clicked;

         IsPushEnabled = OneSignal.Default.User.PushSubscription.OptedIn;
         HasPushPermission = OneSignal.Default.Notifications.Permission;
         IsIAMPaused = OneSignal.Default.InAppMessages.Paused;
         IsLocationShared = OneSignal.Default.Location.IsShared;
         PushSubscriptionId = OneSignal.Default.User.PushSubscription.Id;
      }

      private void InAppMessages_Clicked(object sender, OneSignalSDK.Xamarin.Core.InAppMessages.InAppMessageClickedEventArgs e)
      {
         Debug.WriteLine($"IAM clicked: ${e.Action.ClickName}.");
      }

      private void InAppMessages_WillDisplay(object sender, OneSignalSDK.Xamarin.Core.InAppMessages.InAppMessageLifecycleEventArgs e)
      {
         Debug.WriteLine($"IAM ${e.Message.MessageId} will display.");
      }

      private void InAppMessages_DidDisplay(object sender, OneSignalSDK.Xamarin.Core.InAppMessages.InAppMessageLifecycleEventArgs e)
      {
         Debug.WriteLine($"IAM ${e.Message.MessageId} did display.");
      }

      private void InAppMessages_WillDismiss(object sender, OneSignalSDK.Xamarin.Core.InAppMessages.InAppMessageLifecycleEventArgs e)
      {
         Debug.WriteLine($"IAM ${e.Message.MessageId} will dismiss.");
      }

      private void InAppMessages_DidDismiss(object sender, OneSignalSDK.Xamarin.Core.InAppMessages.InAppMessageLifecycleEventArgs e)
      {
         Debug.WriteLine($"IAM ${e.Message.MessageId} did dismiss.");
      }

      private void Notifications_WillDisplay(object sender, OneSignalSDK.Xamarin.Core.Notifications.NotificationWillDisplayEventArgs e)
      {
         Debug.WriteLine($"Notification ${e.OriginalNotification.NotificationId} will display.");
      }

      private void Notifications_Clicked(object sender, OneSignalSDK.Xamarin.Core.Notifications.NotificationClickedEventArgs e)
      {
         Debug.WriteLine($"Notification ${e.Notification.NotificationId} has been clicked");
      }

      private void Notifications_PermissionChanged(object sender, OneSignalSDK.Xamarin.Core.Notifications.NotificationPermissionChangedEventArgs e)
      {
         Debug.WriteLine($"Notification Permissions has changed: ${e.Permission}");
         HasPushPermission = e.Permission;
      }

      private void PushSubscription_Changed(object sender, OneSignalSDK.Xamarin.Core.User.Subscriptions.SubscriptionChangedEventArgs e)
      {
         var pushSubscription = e.Subscription as IPushSubscription;
         Debug.WriteLine($"Push Subscription has changed: Id=${pushSubscription.Id}, Token={pushSubscription.Token}, OptedIn=${pushSubscription.OptedIn}");
         IsPushEnabled = OneSignal.Default.User.PushSubscription.OptedIn;
         PushSubscriptionId = e.Subscription.Id;
      }

      private void GivePrivacyConsent()
      {
         OneSignal.Default.PrivacyConsent = true;
         HasGivenPrivacyConsent = true;
      }

      private void RevokePrivacyConsent()
      {
         OneSignal.Default.PrivacyConsent = false;
         HasGivenPrivacyConsent = false;
      }

      private async void LoginUser()
      {
         var externalId = await _page.DisplayPromptAsync("Login User", "External ID of User", "Login");

         if (String.IsNullOrWhiteSpace(externalId))
         {
            return;
         }

         OneSignal.Default.Login(externalId);
      }

      private void LogoutUser()
      {
         OneSignal.Default.Logout();
      }

      private async void AddAlias()
      {
         var addPairModel = new AddPairPageModel("Add Alias", "Label", "ID");

         addPairModel.PageCompleted += (s, e) =>
         {
            OneSignal.Default.User.AddAlias(addPairModel.Key, addPairModel.Value);
         };

         await _page.Navigation.PushModalAsync(new AddPairPage()
         {
            BindingContext = addPairModel
         });
      }

      private async void PromptForPush()
      {
         await OneSignal.Default.Notifications.RequestPermissionAsync(true);
      }

      private async void AddEmail()
      {
         var email = await _page.DisplayPromptAsync("Add Email", "Email Address");
         OneSignal.Default.User.AddEmail(email);
      }

      private async void AddSMS()
      {
         var sms = await _page.DisplayPromptAsync("Add SMS", "Phone Number");
         OneSignal.Default.User.AddSms(sms);
      }

      private async void AddTag()
      {
         var addPairModel = new AddPairPageModel("Add Tag", "Key", "Value");
         addPairModel.PageCompleted += (s, e) =>
         {
            OneSignal.Default.User.AddTag(addPairModel.Key, addPairModel.Value);
         };

         await _page.Navigation.PushModalAsync(new AddPairPage()
         {
            BindingContext = addPairModel
         });
      }

      private async void AddOutcome()
      {
         var addOutcomeModel = new AddOutcomePageModel();
         addOutcomeModel.PageCompleted += (s, e) =>
         {
            switch (addOutcomeModel.Type)
            {
               case AddOutcomePageModel.OutcomeType.Normal:
                  OneSignal.Default.Session.AddOutcome(addOutcomeModel.Name);
                  break;
               case AddOutcomePageModel.OutcomeType.Unique:
                  OneSignal.Default.Session.AddUniqueOutcome(addOutcomeModel.Name);
                  break;
               case AddOutcomePageModel.OutcomeType.WithValue:
                  OneSignal.Default.Session.AddOutcomeWithValue(addOutcomeModel.Name, (float)addOutcomeModel.ValueAsFloat);
                  break;
            }
         };

         await _page.Navigation.PushModalAsync(new AddOutcomePage()
         {
            BindingContext = addOutcomeModel
         });
      }

      private async void AddTrigger()
      {
         var addPairModel = new AddPairPageModel("Add Trigger", "Key", "Value");

         addPairModel.PageCompleted += (s, e) =>
         {
            OneSignal.Default.InAppMessages.AddTrigger(addPairModel.Key, addPairModel.Value);
         };

         await _page.Navigation.PushModalAsync(new AddPairPage()
         {
            BindingContext = addPairModel
         });
      }

      private async void PromptForLocation()
      {
         await OneSignal.Default.Location.RequestPermissionAsync();
      }

      private void EnterLiveActivity()
      {
         string activityId = LiveActivityId;

         if (String.IsNullOrWhiteSpace(activityId))
         {
            return;
         }

#if (LIVE_ACTIVITIES && IOS)
        var onesignalLiveActivity = new OneSignalLiveActivity.Binding.OneSignalLiveActivity();
        onesignalLiveActivity.StartLiveActivityWithRecievedToken((str) =>
        {
            OneSignal.Default.EnterLiveActivity(activityId, str);
        });
#elif !IOS
         _page.DisplayAlert("NOT SUPPORTED", "Live Activities is iOS only!", "OK");
#else
        _page.DisplayAlert("NOT SUPPORTED", "Live Activities is disabled in sample app by default, follow steps in Samples/LIVE_ACTIVITES.md to try it out!", "OK");
#endif
      }

      private void ExitLiveActivity()
      {
         string activityId = LiveActivityId;

         if (String.IsNullOrWhiteSpace(activityId))
         {
            return;
         }

#if (LIVE_ACTIVITIES && IOS)
        OneSignal.Default.ExitLiveActivity(activityId);
#elif !IOS
         _page.DisplayAlert("NOT SUPPORTED", "Live Activities is iOS only!", "OK");
#else
        _page.DisplayAlert("NOT SUPPORTED", "Live Activities is disabled in sample app by default, follow steps in Samples/LIVE_ACTIVITES.md to try it out!", "OK");
#endif
      }

      private async void Validation()
      {
         var firstLoginEUID = RandomString(7);
         var firstLoginAlias = $"{firstLoginEUID}Alias";
         var firstLoginEmail = $"{firstLoginEUID}@email.com";
         var firstLoginNumber = $"+{RandomStringNumber(11)}";

         Debug.WriteLine($"Login");
         OneSignal.Default.Login(firstLoginEUID);
         await Task.Delay(2000);

         Debug.WriteLine($"User.Language = \"en\"");
         OneSignal.Default.User.Language = "en";
         await Task.Delay(2000);

         Debug.WriteLine($"User.AddAlias(\"aliasLabel1\", \"{firstLoginAlias}\")");
         OneSignal.Default.User.AddAlias("aliasLabel1", firstLoginAlias);
         await Task.Delay(2000);

         Debug.WriteLine($"User.AddEmail(\"{firstLoginEmail}\")");
         OneSignal.Default.User.AddEmail(firstLoginEmail);
         await Task.Delay(2000);

         Debug.WriteLine($"User.AddSms(\"{firstLoginNumber}\")");
         OneSignal.Default.User.AddSms(firstLoginNumber);
         await Task.Delay(2000);

         Debug.WriteLine($"User.AddTag(\"tagKey1\", \"tagValue1\")");
         OneSignal.Default.User.AddTag("tagKey1", "tagValue1");
         await Task.Delay(2000);

         Debug.WriteLine($"User.AddTag(new Dictionary<string, string> {{ {{ \"tagKey2\", \"tagValue2\" }}, {{ \"tagKey3\", \"tagValue3\" }} }})");
         OneSignal.Default.User.AddTags(new Dictionary<string, string> { { "tagKey2", "tagValue2" }, { "tagKey3", "tagValue3" } });
         await Task.Delay(2000);

         Debug.WriteLine($"User.RemoveAlias(\"aliasLabel1\")");
         OneSignal.Default.User.RemoveAlias("aliasLabel1");
         await Task.Delay(2000);

         Debug.WriteLine($"User.RemoveEmail(\"{firstLoginEmail}\")");
         OneSignal.Default.User.RemoveEmail(firstLoginEmail);
         await Task.Delay(2000);

         Debug.WriteLine($"User.RemoveSms(\"{firstLoginNumber}\")");
         OneSignal.Default.User.RemoveSms(firstLoginNumber);
         await Task.Delay(2000);

         Debug.WriteLine($"User.RemoveTag(\"tagKey1\")");
         OneSignal.Default.User.RemoveTag("tagKey1");
         await Task.Delay(2000);

         Debug.WriteLine($"User.RemoveTags(\"tagKey2\", \"tagKey3\")");
         OneSignal.Default.User.RemoveTags("tagKey2", "tagKey3");
         await Task.Delay(2000);

         Debug.WriteLine($"Logout");
         OneSignal.Default.Logout();
         await Task.Delay(2000);

         Debug.WriteLine($"OptIn, OptedIn={OneSignal.Default.User.PushSubscription.OptedIn}");
         OneSignal.Default.User.PushSubscription.OptIn();
         await Task.Delay(2000);

         Debug.WriteLine($"OptOut, OptedIn={OneSignal.Default.User.PushSubscription.OptedIn}");
         OneSignal.Default.User.PushSubscription.OptOut();
         await Task.Delay(2000);

         Debug.WriteLine($"OptIn, OptedIn={OneSignal.Default.User.PushSubscription.OptedIn}");
         OneSignal.Default.User.PushSubscription.OptIn();
         await Task.Delay(2000);

         Debug.WriteLine($"Push Subscription: Id={OneSignal.Default.User.PushSubscription.Id}, Token={OneSignal.Default.User.PushSubscription.Token}, OptedIn={OneSignal.Default.User.PushSubscription.OptedIn}");

         Debug.WriteLine($"Session.AddOutcome(\"outcomename\")");
         OneSignal.Default.Session.AddOutcome("outcomename");
         await Task.Delay(2000);

         Debug.WriteLine($"Session.AddUniqueOutcome(\"uniqueoutcomename\")");
         OneSignal.Default.Session.AddUniqueOutcome("uniqueoutcomename");
         await Task.Delay(2000);

         Debug.WriteLine($"Session.AddOutcomeWithValue(\"outcomenamewithvalue\", 1.1f)");
         OneSignal.Default.Session.AddOutcomeWithValue("outcomenamewithvalue", 1.1f);
         await Task.Delay(2000);

         Debug.WriteLine($"Notifications.Permission={OneSignal.Default.Notifications.Permission}");

         Debug.WriteLine($"Notifications.RequestPermissionAsync(true)");
         await OneSignal.Default.Notifications.RequestPermissionAsync(true);
         await Task.Delay(2000);

         Debug.WriteLine($"Location.IsShared={OneSignal.Default.Location.IsShared}");
         OneSignal.Default.Location.IsShared = false;
         await Task.Delay(2000);

         OneSignal.Default.Location.IsShared = true;
         await Task.Delay(2000);

         Debug.WriteLine($"Location.RequestPermissionAsync()");
         await OneSignal.Default.Location.RequestPermissionAsync();
         await Task.Delay(2000);

         Debug.WriteLine($"InAppMessages.Paused={OneSignal.Default.InAppMessages.Paused}");
         OneSignal.Default.InAppMessages.Paused = false;
         await Task.Delay(2000);

         OneSignal.Default.InAppMessages.Paused = true;
         await Task.Delay(2000);

         Debug.WriteLine($"InAppMessages.AddTrigger(\"triggerKey1\", \"triggerValue1\")");
         OneSignal.Default.InAppMessages.AddTrigger("triggerKey1", "triggerValue1");
         await Task.Delay(2000);

         Debug.WriteLine($"InAppMessages.AddTriggers(new Dictionary<string, object> {{ {{ \"triggerKey2\", \"triggerValue2\" }}, {{ \"triggerKey3\", \"triggerValue3\" }} }}");
         OneSignal.Default.InAppMessages.AddTriggers(new Dictionary<string, object> { { "triggerKey2", "triggerValue2" }, { "triggerKey3", "triggerValue3" } });
         await Task.Delay(2000);

         Debug.WriteLine($"InAppMessages.RemoveTrigger(\"triggerKey1\")");
         OneSignal.Default.InAppMessages.RemoveTrigger("triggerKey1");
         await Task.Delay(2000);

         Debug.WriteLine($"InAppMessages.RemoveTriggers(\"triggerKey2\", \"triggerKey3\")");
         OneSignal.Default.InAppMessages.RemoveTriggers("triggerKey2", "triggerKey3");
         await Task.Delay(2000);
      }

      private void OnPropertyChanged([CallerMemberName] string name = "") =>
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

      private static Random random = new Random();
      private static string RandomString(int length)
      {
         const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
         return new string(Enumerable.Repeat(chars, length)
             .Select(s => s[random.Next(s.Length)]).ToArray());
      }
      private static string RandomStringNumber(int length)
      {
         const string chars = "0123456789";
         return new string(Enumerable.Repeat(chars, length)
             .Select(s => s[random.Next(s.Length)]).ToArray());
      }
   }
}
