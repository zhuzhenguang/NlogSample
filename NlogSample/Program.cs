using System;
using NLog;

namespace NlogSample
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("Aha Nlog");

            Console.ReadKey();
        }
    }
}
