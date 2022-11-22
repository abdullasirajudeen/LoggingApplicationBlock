using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace LoggingApplicationBlock
{
    public class LoggerBlock
    {
        protected LogWriter logWriter;

        public LoggerBlock()
        {
            InitLogging();
        }

        private void InitLogging()
        {
            IConfigurationSource configurationSource = ConfigurationSourceFactory.Create();
            //LogWriterFactory logWriterFactory = new LogWriterFactory(configurationSource);
            //Logger.SetLogWriter(logWriterFactory.Create(), false);
            logWriter = new LogWriterFactory(configurationSource).Create();
            //  Logger.SetLogWriter(logWriter, false);
            Logger.SetLogWriter(logWriter, false);


        }

        public LogWriter LogWriter
        {
            get
            {
                return logWriter;
            }
        }
    }
}
