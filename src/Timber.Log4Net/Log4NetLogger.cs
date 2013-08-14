using System;
using log4net.Core;
using log4netLogLevel = log4net.Core.Level;

namespace Timber.Log4Net
{
    public class Log4NetLogger : LoggerBase
    {
        /// <summary>log4net logger that this adapter wraps</summary>
        private readonly log4net.Core.ILogger logger;

        /// <summary>Used to exclude Timber from call site information</summary>
        private readonly static Type declaringType = typeof(LoggerBase);

        /// <summary>
        /// Wrap an instance of a log4net logger
        /// </summary>
        /// <param name="logger">log4net logger to wrap</param>
        protected internal Log4NetLogger(ILoggerWrapper logger)
        {
            this.logger = logger.Logger;
        }

        /// <summary>
        /// Log to the wrapped log4net logger
        /// </summary>
        public override void Log(LogEntry entry)
        {
            var log4netLogLevel = MapLogLevel(entry.LogLevel);

            // Add Windows Event Log ID, if present in source log entry
            if (entry.EventId.HasValue)
            {
                log4net.ThreadContext.Properties["EventID"] = entry.EventId;
            }

            this.logger.Log(declaringType, log4netLogLevel, entry.Message, entry.Exception);
        }

        /// <summary>
        /// Maps an Timber log level to a log4net log level
        /// </summary>
        /// <remarks>
        /// log4net has log levels that almost correspond to the Timber log levels; the
        /// level missing fom log4net is 'Trace', which we map as 'Debug'
        /// </remarks>
        /// <param name="logLevel">Timber log level to be mapped</param>
        /// <returns>log4net log level</returns>
        private log4netLogLevel MapLogLevel(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Fatal:
                    return log4netLogLevel.Fatal;

                case LogLevel.Error:
                    return log4netLogLevel.Error;

                case LogLevel.Warn:
                    return log4netLogLevel.Warn;

                case LogLevel.Info:
                    return log4netLogLevel.Info;

                case LogLevel.Debug:
                    return log4netLogLevel.Debug;

                case LogLevel.Trace:
                    return log4netLogLevel.Debug;

                default:
                    return log4netLogLevel.Info;
            }
        }
    }
}
