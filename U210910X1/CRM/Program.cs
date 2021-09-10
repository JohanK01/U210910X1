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
                    Console.WriteLine("Förnamn och efternamn");
                    myKunder.Add(new Kunder() { name = "johan", lastname = "Klausen", age = "20" });

                    foreach (Kunder k in myKunder)
                    {
                        Console.WriteLine($"{k.name} {k.lastname} {k.age}");
                    }
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
    public class Kunder
    {
        public string name;
        public string lastname;
        public string age;
    }
}
