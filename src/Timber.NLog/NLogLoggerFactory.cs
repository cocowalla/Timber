using System;
using NLogManager = NLog.LogManager;

namespace Timber.NLog
{
    /// <summary>
    /// Generates NLog logging adapters
    /// </summary>
    public class NLogLoggerFactory : ILoggerFactory
    {
        public ILogger GetLogger(Type type)
        {
            return this.GetLogger(type.FullName);
        }

        public ILogger GetLogger(string name)
        {
            return new NLogLogger(NLogManager.GetLogger(name));
        }
    }
}
