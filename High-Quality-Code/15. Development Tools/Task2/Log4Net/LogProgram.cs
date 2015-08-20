using log4net;
using log4net.Config;

namespace Log4Net
{
    internal class LogProgram
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(LogProgram));

        private static void Main()
        {
            XmlConfigurator.Configure();
            Log.Debug("A debug message");
            Log.Error("An error message");
            Log.Fatal("A fatal message");
            Log.Info("An info message");
            Log.Warn("A warning message");
        }
    }
}