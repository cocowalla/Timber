
namespace Log4NetSample
{
    /// <summary>
    /// Sample demonstrating how to set the logger by configuration
    /// 
    /// See the App.config file to see how the logger factory is set
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var someClass = new SomeClass();
            someClass.LogSomething();
        }
    }
}
