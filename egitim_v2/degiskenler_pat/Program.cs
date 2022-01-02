using System;

namespace degiskenler_pat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte a = 4; //1 byte yer
            sbyte b = -5; //üst aynı
            short c = 44; //2 byte yer -32768
            ushort d = 365; //üst aynı 365000

            Int16 i16 = 16; //2
            int i = 4; //4
            Int32 i32 = 4; //4
            Int64 i64 = 8; //8

            uint ui = 4; //4
            long l = 8; //8
            ulong ul = 8; //8
            float f = 4; //4
            double de = 8; //8
            decimal dec = 16; //16


            char ch = '2'; //2
            string sg = "str"; //infinite
            bool bl = true;
            bool bl2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 5;
            object o4 = 8.7;

            string str1 = string.Empty;
            str1 = "deneme";
            string ad = "Adın";
            string soyad = " Soyadın";
            string tamIsim = ad + soyad;

            int q1 = 3;
            int q2 = 1;
            int q3 = q1 + q2;

            bool bool1 = 58 > 3;

            string str55 = "55";
            int int55 = 55;
            string ydeger = str55 + int55.ToString();
            Console.WriteLine(ydeger);

            int int56 = int55 + Convert.ToInt32(str55);
            Console.WriteLine(int56);

            int int57 = int55 + int.Parse(str55); //parse string alır.

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string saat = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(saat);


        }
    }
}
