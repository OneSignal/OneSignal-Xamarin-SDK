using System;
using ObjCRuntime;

namespace Com.OneSignal.iOS
{
	[Native]
	public enum OSNotificationActionType : ulong
	{
		Opened,
		ActionTaken
	}

	[Native]
	public enum OSInFocusDisplayOption : ulong
	{
		None,
		InAppAlert,
		Notification
	}



	[Native]
	public enum OneSLogLevel : ulong
	{
		None,
		Fatal,
		Error,
		Warn,
		Info,
		Debug,
		Verbose
	}
}
