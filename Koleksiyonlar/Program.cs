using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"ali", "veli", "konya" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine("---------------");

            //isimler = new string[5];
            //isimler[3] = "cxxxx";
            //Console.WriteLine("0"+isimler[0]);
            //Console.WriteLine("1"+isimler[1]);
            //Console.WriteLine("2"+isimler[2]);
            //Console.WriteLine("3"+isimler[3]);
            //Console.WriteLine("4" + isimler[4]);

            List<string> isimler2 = new List<string> {"ali", "veli", "konya"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("hasan");
            isimler2.Add("5");

            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[5]);




        }
    }
}
