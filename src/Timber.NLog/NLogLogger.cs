using System;
using NLog;
using NLogLogLevel = NLog.LogLevel;

namespace Timber.NLog
{
    public class NLogLogger : LoggerBase
    {
        /// <summary>NLog logger that this adapter wraps</summary>
        private readonly Logger logger;

        /// <summary>Used to exclude Timber from call site information</summary>
        private readonly static Type declaringType = typeof(LoggerBase);

        /// <summary>
        /// Wrap an instance of an NLog logger
        /// </summary>
        /// <param name="logger">NLog logger to wrap</param>
        protected internal NLogLogger(Logger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Log to the wrapped NLog logger
        /// </summary>
        public override void Log(LogEntry entry)
        {
            var nlogLogLevel = MapLogLevel(entry.LogLevel);

            var nlogEntry = new LogEventInfo()
            {
                Level = nlogLogLevel,
                TimeStamp = entry.Timestamp,
                Message = entry.Message,
                Exception = entry.Exception
            };

            // Add Windows Event Log ID, if present in source log entry
            if (entry.EventId.HasValue)
            {
                nlogEntry.Properties.Add("EventID", entry.EventId);
            }

            this.logger.Log(declaringType, nlogEntry);
        }

        /// <summary>
        /// Maps an Timber log level to an NLog log level
        /// </summary>
        /// <remarks>
        /// NLog has log levels that correspond to the Timber log levels, so 
        /// this is a 1:1 mapping
        /// </remarks>
        /// <param name="logLevel">Timber log level to be mapped</param>
        /// <returns>NLog log level</returns>
        private NLogLogLevel MapLogLevel(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Fatal:
                    return NLogLogLevel.Fatal;

                case LogLevel.Error:
                    return NLogLogLevel.Error;

                case LogLevel.Warn:
                    return NLogLogLevel.Warn;

                case LogLevel.Info:
                    return NLogLogLevel.Info;

                case LogLevel.Debug:
                    return NLogLogLevel.Debug;

                case LogLevel.Trace:
                    return NLogLogLevel.Trace;

                default:
                    return NLogLogLevel.Info;
            }
        }
    }
}
