using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
                
            Logger log = new FileLogger();
            LogMessage(log,"application start");
        }
        static void LogMessage(Logger log, string message)
        {
            log.WriteMessage( message);
        }
    }

    abstract class Logger
    {
        public abstract void WriteMessage(string message);
    }
    class FileLogger:Logger
    {
        public override void WriteMessage(string message)
        {
            File.AppendAllText("log.txt", message);
        }
    }
    class ConsoleLogger:Logger
    {
        public override void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
