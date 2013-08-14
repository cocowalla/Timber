using System;

namespace Timber
{
    /// <summary>
    /// Interface for adapters that wrap logger implementations
    /// </summary>
    public interface ILogger
    {
        void Log(LogEntry entry);

        #region Trace
        void Trace(object message);
        void Trace(string format, params object[] args);
        void Trace(object message, Exception exception);
        void Trace(string format, Exception exception, params object[] args);
        void Trace(int eventId, object message);
        void Trace(int eventId, string format, params object[] args);
        void Trace(int eventId, object message, Exception exception);
        void Trace(int eventId, string format, Exception exception, params object[] args);
        #endregion

        #region Debug
        void Debug(object message);
        void Debug(string format, params object[] args);
        void Debug(object message, Exception exception);
        void Debug(string format, Exception exception, params object[] args);
        void Debug(int eventId, object message);
        void Debug(int eventId, string format, params object[] args);
        void Debug(int eventId, object message, Exception exception);
        void Debug(int eventId, string format, Exception exception, params object[] args);
        #endregion

        #region Info
        void Info(object message);
        void Info(string format, params object[] args);
        void Info(object message, Exception exception);
        void Info(string format, Exception exception, params object[] args);
        void Info(int eventId, object message);
        void Info(int eventId, string format, params object[] args);
        void Info(int eventId, object message, Exception exception);
        void Info(int eventId, string format, Exception exception, params object[] args);
        #endregion

        #region Warn
        void Warn(object message);
        void Warn(string format, params object[] args);
        void Warn(object message, Exception exception);
        void Warn(string format, Exception exception, params object[] args);
        void Warn(int eventId, object message);
        void Warn(int eventId, string format, params object[] args);
        void Warn(int eventId, object message, Exception exception);
        void Warn(int eventId, string format, Exception exception, params object[] args);
        #endregion

        #region Error
        void Error(object message);
        void Error(string format, params object[] args);
        void Error(object message, Exception exception);
        void Error(string format, Exception exception, params object[] args);
        void Error(int eventId, object message);
        void Error(int eventId, string format, params object[] args);
        void Error(int eventId, object message, Exception exception);
        void Error(int eventId, string format, Exception exception, params object[] args);
        #endregion

        #region Fatal
        void Fatal(object message);
        void Fatal(string format, params object[] args);
        void Fatal(object message, Exception exception);
        void Fatal(string format, Exception exception, params object[] args);
        void Fatal(int eventId, object message);
        void Fatal(int eventId, string format, params object[] args);
        void Fatal(int eventId, object message, Exception exception);
        void Fatal(int eventId, string format, Exception exception, params object[] args);
        #endregion
    }
}
