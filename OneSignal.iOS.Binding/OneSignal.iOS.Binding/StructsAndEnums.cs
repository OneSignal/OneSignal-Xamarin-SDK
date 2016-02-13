using System;
using ObjCRuntime;

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