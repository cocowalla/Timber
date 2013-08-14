using System;

namespace Timber
{
    public abstract class LoggerBase : ILogger
    {
        public abstract void Log(LogEntry entry);

        private void LogInternal(LogLevel level, object message = null, 
            Exception exception = null, int? eventId = null)
        {
            var entry = new LogEntry()
            {
                LogLevel = level, 
                Message = message != null ? message.ToString() : String.Empty, 
                Exception = exception,
                EventId = eventId
            };

            this.Log(entry);
        }

        #region Trace
        public void Trace(object message)
        {
            this.LogInternal(LogLevel.Trace, message);
        }

        public virtual void Trace(string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Trace, message);
        }

        public virtual void Trace(object message, Exception exception)
        {
            this.LogInternal(LogLevel.Trace, message, exception);
        }

        public virtual void Trace(string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Trace, message, exception);
        }

        public virtual void Trace(int eventId, object message)
        {
            this.LogInternal(LogLevel.Trace, message, null, eventId);
        }

        public virtual void Trace(int eventId, string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Trace, message, null, eventId);
        }

        public virtual void Trace(int eventId, object message, Exception exception)
        {
            this.LogInternal(LogLevel.Trace, message, exception, eventId);
        }

        public virtual void Trace(int eventId, string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Trace, message, exception, eventId);
        }
        #endregion

        #region Debug
        public void Debug(object message)
        {
            this.LogInternal(LogLevel.Debug, message);
        }

        public virtual void Debug(string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Debug, message);
        }

        public virtual void Debug(object message, Exception exception)
        {
            this.LogInternal(LogLevel.Debug, message, exception);
        }

        public virtual void Debug(string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Debug, message, exception);
        }

        public virtual void Debug(int eventId, object message)
        {
            this.LogInternal(LogLevel.Debug, message, null, eventId);
        }

        public virtual void Debug(int eventId, string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Debug, message, null, eventId);
        }

        public virtual void Debug(int eventId, object message, Exception exception)
        {
            this.LogInternal(LogLevel.Debug, message, exception, eventId);
        }

        public virtual void Debug(int eventId, string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Debug, message, exception, eventId);
        }
        #endregion

        #region Info
        public void Info(object message)
        {
            this.LogInternal(LogLevel.Info, message);
        }

        public virtual void Info(string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Info, message);
        }

        public virtual void Info(object message, Exception exception)
        {
            this.LogInternal(LogLevel.Info, message, exception);
        }

        public virtual void Info(string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Info, message, exception);
        }

        public virtual void Info(int eventId, object message)
        {
            this.LogInternal(LogLevel.Info, message, null, eventId);
        }

        public virtual void Info(int eventId, string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Info, message, null, eventId);
        }

        public virtual void Info(int eventId, object message, Exception exception)
        {
            this.LogInternal(LogLevel.Info, message, exception, eventId);
        }

        public virtual void Info(int eventId, string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Info, message, exception, eventId);
        }
        #endregion

        #region Warn
        public void Warn(object message)
        {
            this.LogInternal(LogLevel.Warn, message);
        }

        public virtual void Warn(string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Warn, message);
        }

        public virtual void Warn(object message, Exception exception)
        {
            this.LogInternal(LogLevel.Warn, message, exception);
        }

        public virtual void Warn(string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Warn, message, exception);
        }

        public virtual void Warn(int eventId, object message)
        {
            this.LogInternal(LogLevel.Warn, message, null, eventId);
        }

        public virtual void Warn(int eventId, string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Warn, message, null, eventId);
        }

        public virtual void Warn(int eventId, object message, Exception exception)
        {
            this.LogInternal(LogLevel.Warn, message, exception, eventId);
        }

        public virtual void Warn(int eventId, string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Warn, message, exception, eventId);
        }
        #endregion

        #region Error
        public void Error(object message)
        {
            this.LogInternal(LogLevel.Error, message);
        }

        public virtual void Error(string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Error, message);
        }

        public virtual void Error(object message, Exception exception)
        {
            this.LogInternal(LogLevel.Error, message, exception);
        }

        public virtual void Error(string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Error, message, exception);
        }

        public virtual void Error(int eventId, object message)
        {
            this.LogInternal(LogLevel.Error, message, null, eventId);
        }

        public virtual void Error(int eventId, string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Error, message, null, eventId);
        }

        public virtual void Error(int eventId, object message, Exception exception)
        {
            this.LogInternal(LogLevel.Error, message, exception, eventId);
        }

        public virtual void Error(int eventId, string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Error, message, exception, eventId);
        }
        #endregion

        #region Fatal
        public void Fatal(object message)
        {
            this.LogInternal(LogLevel.Fatal, message);
        }

        public virtual void Fatal(string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Fatal, message);
        }

        public virtual void Fatal(object message, Exception exception)
        {
            this.LogInternal(LogLevel.Fatal, message, exception);
        }

        public virtual void Fatal(string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Fatal, message, exception);
        }

        public virtual void Fatal(int eventId, object message)
        {
            this.LogInternal(LogLevel.Fatal, message, null, eventId);
        }

        public virtual void Fatal(int eventId, string format, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Fatal, message, null, eventId);
        }

        public virtual void Fatal(int eventId, object message, Exception exception)
        {
            this.LogInternal(LogLevel.Fatal, message, exception, eventId);
        }

        public virtual void Fatal(int eventId, string format, Exception exception, params object[] args)
        {
            var message = String.Format(format, args);
            this.LogInternal(LogLevel.Fatal, message, exception, eventId);
        }
        #endregion
    }
}
