using System;

namespace OneSignalSDK.Xamarin.Core.InAppMessages; 

public record InAppMessage
{
    /// <summary>
    /// The unique identifier for this in-app message
    /// </summary>
    public string MessageId { get; } = "";

   public InAppMessage(string messageId)
   {
      MessageId = messageId;
   }
}
