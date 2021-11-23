using Android.App;
using Android.Widget;
using Android.OS;
using Com.OneSignal.Sample.Shared;
using System;

namespace Com.OneSignal.Sample.Droid
{
   [Activity(Label = "Com.OneSignal.Sample.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
   public class MainActivity : Activity
   {
      int count = 1;

      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);

         // Set our view from the "main" layout resource
         SetContentView(Resource.Layout.Main);

         SharedPush.Initialize();

         // Get our button from the layout resource,
         // and attach an event to it
         Button button = FindViewById<Button>(Resource.Id.myButton);

         button.Click += delegate
         {
            button.Text = $"{count++} clicks!";
            System.Diagnostics.Debug.WriteLine("Button clicked");
         };

         Switch consentButton = FindViewById<Switch>(Resource.Id.consentSwitch);
         consentButton.CheckedChange += (o, e) =>
         {
            //SharedPush.ConsentStatusChanged(consentButton.Checked);

            System.Diagnostics.Debug.WriteLine("Changing consent state");
         };

         consentButton.Checked = OneSignal.Default.PrivacyConsent;

         Button setExternalIdButton = FindViewById<Button>(Resource.Id.setExternalIdButton);

         TextView externalIdField = FindViewById<TextView>(Resource.Id.externalIdField);
         
         setExternalIdButton.Click += delegate
         {
            OneSignal.Default.SetExternalUserId(externalIdField.Text);
         };

         Button removeExternalIdButton = FindViewById<Button>(Resource.Id.removeExternalIdButton);

         removeExternalIdButton.Click += delegate
         {
            OneSignal.Default.RemoveExternalUserId();
         };
      }

      private void SetAltText(String text)
      {
         TextView altTextView = FindViewById<TextView>(Resource.Id.altText);
         altTextView.Text = text;
      }
   }
}

