using System;

namespace Timber
{
    /// <summary>
    /// Factory methods for obtaining instances of <see cref="ILogger"/> adapters
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger GetLogger(Type type);
        ILogger GetLogger(string name);
    }
}
