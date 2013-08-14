using System;

namespace Timber
{
    /// <summary>
    /// Default <see cref="ILoggerFactory"/> implementation that returns <see cref="NullLogger"/> 
    /// instances that silently drop all log entries
    /// 
    /// This factory is used if configuration is incomplete or invalid
    /// </summary>
    public class NullLoggerFactory : ILoggerFactory
    {
        /// <summary>Singleton, to keep null logger as lightweight as possible</summary>
        private static readonly NullLogger instance = new NullLogger();

        public ILogger GetLogger(Type type)
        {
            return instance;
        }

        public ILogger GetLogger(string name)
        {
            return instance;
        }
    }
}
