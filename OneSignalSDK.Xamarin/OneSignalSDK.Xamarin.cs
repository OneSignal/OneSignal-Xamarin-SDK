using System;
using System.Diagnostics;
using OneSignalSDK.Xamarin.Core;

namespace OneSignalSDK.Xamarin
{
   public class OneSignal
   {
      static readonly Lazy<OneSignalSDKInternal> Implementation = new Lazy<OneSignalSDKInternal>(CreateOneSignal);

      public static OneSignalSDKInternal Default
      {
         get
         {
            if (Implementation.Value == null)
               throw NotImplementedInReferenceAssembly();

            return Implementation.Value;
         }
      }

      static OneSignalSDKInternal CreateOneSignal()
      {
         #if PORTABLE
            Debug.WriteLine("PORTABLE Reached");
            return null;
         #else
            return new OneSignalImplementation();
         #endif
      }

      internal static Exception NotImplementedInReferenceAssembly()
      {
         return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
      }
   }
}
