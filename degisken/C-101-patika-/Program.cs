
using System;
using System.Globalization;

namespace degisken
{
    class Program
    {
        private static void Main(string[] args)
        {
            byte a = 8; // 1 bayt	0, ..., 255 (tam sayı)
            Console.WriteLine(a);
            sbyte b = 12; // 1 bayt	-128, ..., 127 (tam sayı)
            Console.WriteLine(b);
            short c = 400; // 2 bayt	-32768, ..., 32767 (tam sayı)
            Console.WriteLine(c);
            ushort d = 10142; // 0, ..., 65535 (tam sayı)
            Console.WriteLine(d);
            int e = 788; //	4 bayt	-2147483648, ..., 2147483647 (tam sayı)
            Console.WriteLine(e);
            long f = 96542; // 8 bayt	-9223372036854775808, ..., 9223372036854775807 (tam sayı)
            Console.WriteLine(f);
            float g = 45.8554f; // 4 bayt	±1.5*10-45, ..., ±3.4*1038 (reel sayı)
            Console.WriteLine(g);
            double h = 9.548785; //8 bayt	±5.0*10-324, ..., ±1.7*10308 (reel sayı)
            Console.WriteLine(h);

            //Boolean Expressions
            bool ı1 = 10 > 5;
            Console.WriteLine(ı1);
            bool ı2 = 5 > 12;
            Console.WriteLine(ı2);

            //Object 
            object i5 = 19;
            Console.WriteLine(i5);
            object i6 = "gulfidecaliskan";
            Console.WriteLine(i6);
            object i7 = 45.89654;
            Console.WriteLine(i7);

            int degiskenimint = 5;
            string degiskenim = "32";
            int intparsed = int.Parse(degiskenim);
            Console.WriteLine(degiskenim);
            Console.WriteLine(intparsed);
            

            string dt = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dt);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            string dt2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dt2);


            int num1 = 6;
            int num2 = 8;
            //Addition
            Console.WriteLine(num1 + num2);
            //Substraction
            Console.WriteLine(num1-num2);
            //Multiplication
            Console.WriteLine(num1 * num2);
            // Division
            Console.WriteLine(num1 / num2);
        }
    }
}
