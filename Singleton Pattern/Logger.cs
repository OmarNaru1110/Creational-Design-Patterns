using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class Logger
    {
        private List<string> messages;
        private static Logger logger;
        private Logger() { }

        private static object lockObj = new object();
        public static void AddMessage(string msg)
        {
            lock (lockObj)
            {
                if (logger == null)
                {
                    logger = new Logger();
                    logger.messages = new List<string>();
                }
                logger.messages.Add(msg);
            }
        }
        public static Logger GetLogger()
        {
            lock (lockObj)
            {
                if (logger == null)
                    return new Logger();
                return logger;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in messages)
            {
                sb.Append($"{s}\n");
            }
            return sb.ToString();
        }

    }
}
