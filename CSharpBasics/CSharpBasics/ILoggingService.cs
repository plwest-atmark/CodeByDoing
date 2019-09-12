using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public enum LogLevel
    {
        Warning,
        Error,
        Debug,
        Information
    }
    public interface ILoggingService
    {
        void LogMessage(string message, LogLevel level);
    }

    public class ConsoleLogger : ILoggingService
    {
        public void LogMessage(string message, LogLevel level)
        {

            if (level == LogLevel.Information)
            Console.WriteLine(message);

        }
    }

    public class DatabaseLogger : ILoggingService
    {
        public void LogMessage(string message, LogLevel level)
        {

            if (level == LogLevel.Information)
            {
                /// SOME CODE TO LOG TO A DATABAE
            }

        }
    }
}
