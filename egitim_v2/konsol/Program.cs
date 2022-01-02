using System;

namespace konsol
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("İsminizi yazınız:");
            string name_sur = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz " + name_sur);
        }
    }
}
