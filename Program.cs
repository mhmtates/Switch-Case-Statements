﻿using System;

namespace Switch_Case_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;
            //Expression
            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak Ayındasınız!");
                break;
                case 2:
                Console.WriteLine("Şubat Ayındasınız!");
                break;
                case 3:
                Console.WriteLine("Mart Ayındasınız!");
                break;
                case 4:
                Console.WriteLine("Nisan Ayındasınız.");
                break;
                default://Hiçbir duruma uymadığı taktirde yapılacak işlemi ifade eder.
                Console.WriteLine("Yanlış veri girmişsiniz");
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("Kış mevsimindesiniz.");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("İlkbahar mevsimindesiniz.");
                break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz mevsimindesiniz.");
                break;
                case 9:
                case 10:
                case 11:
                Console.WriteLine("Sonbahar mevsimindesiniz.");
                break;
                default:
                break;
            }
        }
    }
}
