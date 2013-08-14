using System;

namespace Timber
{
    /// <summary>
    /// Generates loggers used for testing Timber
    /// </summary>
    public class TestLoggerFactory : ILoggerFactory
    {
        public ILogger GetLogger(Type type)
        {
            return this.GetLogger(type.FullName);
        }

        public ILogger GetLogger(string name)
        {
            return new TestLogger();
        }
    }
}
