using Timber;

namespace NLogSample
{
    public class SomeClass
    {
        private readonly static ILogger Log = LogManager.GetLogger();

        public void LogSomething()
        {
            Log.Trace("Logging a {0} level message", LogLevel.Trace);
            Log.Debug("Logging a {0} level message", LogLevel.Debug);
            Log.Info("Logging a {0} level message", LogLevel.Info);
            Log.Warn("Logging a {0} level message", LogLevel.Warn);
            Log.Error("Logging a {0} level message", LogLevel.Error);
            Log.Fatal("Logging a {0} level message", LogLevel.Fatal);

            Log.Info(1234, "Logging a {0} level message that will also be written to the Event Log", LogLevel.Info);
        }
    }
}
