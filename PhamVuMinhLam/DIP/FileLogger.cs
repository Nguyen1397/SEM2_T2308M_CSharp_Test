using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class FileLogger : ILogger
    {

        void ILogger.log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
