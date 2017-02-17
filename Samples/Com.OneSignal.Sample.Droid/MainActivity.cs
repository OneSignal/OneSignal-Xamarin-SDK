using Android.App;
using Android.Widget;
using Android.OS;
using Com.OneSignal.Sample.Shared;

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
         };
      }
   }
}

