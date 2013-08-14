using System.Collections.Generic;

namespace Timber
{
    public class TestLogger : LoggerBase
    {
        /// <summary>All log entries that have been consumed by this logger</summary>
        public List<LogEntry> LogEntries { get; private set; }

        public TestLogger()
            : base()
        {
            this.LogEntries = new List<LogEntry>();
        }

        /// <summary>
        /// Adds the specified log entry to <see cref="LogEntries"/>
        /// </summary>
        /// <param name="entry">Entry to log</param>
        public override void Log(LogEntry entry)
        {
            this.LogEntries.Add(entry);
        }

        /// <summary>Clear the list of log entries</summary>
        public void Clear()
        {
            this.LogEntries.Clear();
        }
    }
}
