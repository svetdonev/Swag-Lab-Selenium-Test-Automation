using log4net;
using log4net.Config;

namespace SwagLab_Test_Automation.Loggers
{
    public class Logger
    {
        private static ILog log = LogManager.GetLogger(typeof(Logger));

        static Logger()
        {
            XmlConfigurator.Configure();
        }
        public static void Info(string message)
        {
            log.Info(message);
        }
        public static void Errored(string message)
        {
            log.Error(message);
        }
    }
}
