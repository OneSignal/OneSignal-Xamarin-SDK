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
	public enum OSInfluenceType : ulong
	{
		Direct,
		Indirect,
		Unattributed,
		Disabled
	}

	[Native]
	public enum OSInfluenceChannel : ulong
	{
		InAppMessage,
		Notification
	}

	[Native]
	public enum OSNotificationPermission : long
	{
		NotDetermined = 0,
		Denied,
		Authorized,
		Provisional,
		Ephemeral
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