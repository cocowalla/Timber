using System;
using log4net.Config;
using Log4NetManager = log4net.LogManager;

namespace Timber.Log4Net
{
    /// <summary>
    /// Generates log4net logging adapters
    /// </summary>
    public class Log4NetLoggerFactory : ILoggerFactory
    {
        /// <summary>
        /// Initialises log4net from config file
        /// </summary>
        public Log4NetLoggerFactory()
        {
            XmlConfigurator.Configure();
        }

        public ILogger GetLogger(Type type)
        {
            return this.GetLogger(type.FullName);
        }

        public ILogger GetLogger(string name)
        {
            return new Log4NetLogger(Log4NetManager.GetLogger(name));
        }
    }
}
