using System;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("1-Skapa ny kund, 2-Visa antal kunder, 3-Visa lista över alla kunder, 4-Avsluta");
                string orden = Console.ReadLine();

                if (orden == "1")
                {
                    Console.WriteLine("Förnamn och efternamn");
                }
                if (orden == "2")
                {
                    Console.WriteLine("visa antal kunder");
                }
                if (orden == "3")
                {

                }
                if (orden == "4")
                {
                    break;
                }
            }
        }
    }
}
