using Timber;
using Timber.NLog;

namespace NLogSample
{
    /// <summary>
    /// Sample demonstrating how to set the logger programmatically at runtime
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.InitialiseLoggerFactory<NLogLoggerFactory>();

            var someClass = new SomeClass();
            someClass.LogSomething();
        }
    }
}
