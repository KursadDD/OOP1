using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            BasvuruManager basvuruManager = new BasvuruManager(); 
            ILoggerService dbLoggerService1 = new DatabaseLogegrService();
            ILoggerService fileLoggerService1 = new FileLogegrService();

            List<ILoggerService> loglar = new List<ILoggerService>() { dbLoggerService1, fileLoggerService1 };

            basvuruManager.BasvuruYap(ihtiyacKrediManager, loglar);
            basvuruManager.BasvuruYap(tasitKrediManager, loglar);
            basvuruManager.BasvuruYap(esnafKrediManager, loglar);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
