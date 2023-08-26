using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLogegrService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veri tabanına loglandı");
        }
    }
}
