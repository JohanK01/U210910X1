using System;
using System.Collections.Generic;
namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kunder> myKunder = new List<Kunder>();


            while (true)
            {

                Console.WriteLine("1-Skapa ny kund, 2-Visa antal kunder, 3-Visa lista över alla kunder, 4-Avsluta");
                string orden = Console.ReadLine();

                if (orden == "1")
                {
                    Console.WriteLine("Förnamn, efternamn och ålder");
                    
                    myKunder.Add(new Kunder()
                    {
                        name = Console.ReadLine(),
                        lastname = Console.ReadLine(),
                        age = Console.ReadLine()
                    });

                    Console.WriteLine("Ny kund skapad");
                   
                }
                if (orden == "2")
                {
                    Console.WriteLine("visa antal kunder");
                    Console.WriteLine($"{myKunder.Count}");
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
    public class Kunder
    {
        public string name;
        public string lastname;
        public string age;
    }
}
