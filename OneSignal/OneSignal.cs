using System;
using System.Diagnostics;
using OneSignal.Core;

namespace OneSignal
{
   public class OneSignal
   {
      static readonly Lazy<OneSignalSDK> Implementation = new Lazy<OneSignalSDK>(CreateOneSignal);

      public static OneSignalSDK Default
      {
         get
         {
            if (Implementation.Value == null)
               throw NotImplementedInReferenceAssembly();

            return Implementation.Value;
         }
      }

      static OneSignalSDK CreateOneSignal()
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
