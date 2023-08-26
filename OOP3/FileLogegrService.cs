using System;

namespace OOP3
{
    class FileLogegrService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
