using System;

namespace Timber
{
    /// <summary>
    /// Container for log data that can be consumed by any <see cref="ILogger"/>
    /// </summary>
    public class LogEntry
    {
        /// <summary>Defaults to <see cref="Timber.LogLevel.Info"/></summary>
        public LogLevel LogLevel { get; set; }

        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }

        /// <summary>Windows Event Log event identifier</summary>
        public int? EventId { get; set; }

        public LogEntry()
        {
            this.LogLevel = LogLevel.Info;
            this.Timestamp = DateTime.UtcNow;
            this.Message = String.Empty;
            this.Exception = null;
            this.EventId = null;
        }
    }
}
