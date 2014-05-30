Timber
======

[![Build status](https://ci.appveyor.com/api/projects/status/oipkbs16rj41a1d9)](https://ci.appveyor.com/project/cocowalla/timber)

Timber is a straightforward, lean logging framework facade for .NET that makes the Windows Event Log a first-class citizen for logging.

Why?
====

NLog and log4net make you jump through hoops to log to the Windows Event Log when you want to set event IDs on a message-by-message basis (why would you ever want to use one ID for all messages?!), and existing facade don't provide anything to make it any easier.

An example using NLog:

````
Logger Logger = LogManager.GetCurrentClassLogger();

var logEvent = new LogEventInfo(LogLevel.Warn, Logger.Name, "This is message");
logEvent.Properties.Add("EventID", 1234);
Logger.Log(logEvent);
````

...and an example using log4net:

````
ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

log4net.ThreadContext.Properties["EventID"] = 1234;
Logger.Warn("This is message");

````

...and finally an example using Timber (code is the same whether you use NLog or log4net or whatever):

````
ILogger Log = LogManager.GetLogger();

Log.Info(1234, "This is message");
````

A one-liner, as logging should be!

Of course Timber provides 'standard' methods for logging without Event Log identifiers:

````
ILogger Log = LogManager.GetLogger();

Log.Info("This is message about {0}", "logging");
````

Configuration
=============

Configuration beyond standard NLog or log4net configuration is minimal - all you need to do is set the logger factory to use. You can do this either in code or your app.config/web.config file:

Code
----

Simply specify the logger factory you want to use:

````
LogManager.InitialiseLoggerFactory<NLogLoggerFactory>();
````

Note that NLog and log4net both expect to find their own configuration in the [usual places](https://github.com/nlog/NLog/wiki/Configuration-file#wiki-configuration-file-locations) (in app.config/web.config, NLog.config etc).

See the [NLog sample](https://github.com/cocowalla/Timber/tree/master/src/Samples/NLogSample) for a full example.

Configuration File
------------------

Simply add a config section and specify the logger factory you want to use:

````
<configSections>
	<section name="timber" type="Timber.Config.TimberSection, Timber" />
</configSections>

<timber>
	<factory type="Timber.Log4Net.Log4NetLoggerFactory, Timber.Log4Net" />
</timber>
````

See the [log4net sample](https://github.com/cocowalla/Timber/tree/master/src/Samples/Log4NetSample) for a full example.

Problems?
=========

If you are trying to log to the Windows Event Log and nothing is being logged, you probably haven't created an event source in the Event Log (this is required before NLog, log4net or anything else can log to the Event Log).

You can create an event source by running the following Powershell script as an administrator:

````
if ([System.Diagnostics.EventLog]::SourceExists($source) -eq $false) {
	[System.Diagnostics.EventLog]::CreateEventSource($source, "Application")
	"Created event source $source"
} else {
	"Event source $source already exists"
}
````
There are ready-made scripts for the [samples](https://github.com/cocowalla/Timber/tree/master/src/Samples).
