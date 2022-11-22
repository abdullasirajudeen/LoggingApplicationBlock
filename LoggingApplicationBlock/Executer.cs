using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace LoggingApplicationBlock
{
    class Executer
    {
        LoggerBlock loggerBlock = new LoggerBlock();

        public static void Main()
        {
            new Executer().ReadFile();
        }

        public void ReadFile()
        {
            WriteTraceLog("Application Started!!!");

            string[] lines;
            var list = new List<string>();
            var fileStream = new FileStream(@"sample.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    WriteTraceLog(line);

                    list.Add(line);
                }
            }

            lines = list.ToArray();

            WriteTraceLog("Application Stopped!!!");
        }

        public void WriteTraceLog(String message)
        {

            Logger.Write(message, "General", 5, 2000, TraceEventType.Information);
        }
    }
}
