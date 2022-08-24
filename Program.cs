using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız!");
                    break;

                case 2:
                    Console.WriteLine("Şubat ayındasınız!");
                    break;

                case 4:
                    Console.WriteLine("Nisan ayındasınız!");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayındasınız!");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız!");
                    break;

                default:
                    Console.WriteLine("Yanlış veri girdiniz!");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Kış Ayındasınız!");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("İlkbahar Ayındasınız!");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Yaz Ayındasınız!");
                    break;
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayındasınız!");
                    break;

                default:
                    Console.WriteLine("Yanlış Giriş Yaptınız!");

                    break;
            }



        }
    }
}