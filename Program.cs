using System;
using System.Collections.Generic;


namespace ASSIGNMENT3
{
    class Program
    {
        public static void Main()
        {
            Primeminister Primeminister1 = new Primeminister()
            {
                Name = "Atal Bihari Vajpayee",
                Year = 1998
            };
            Primeminister Primeminister2 = new Primeminister()
            {
                Name = "Narendra Modi",
                Year = 2014
            };
            Primeminister Primeminister3 = new Primeminister()
            {
                Name = "Manmohan Singh",
                Year = 2004
            };

            Dictionary<int, Primeminister> dictionaryPrimeminister = new Dictionary<int, Primeminister>();
            dictionaryPrimeminister.Add(Primeminister1.Year, Primeminister1);
            dictionaryPrimeminister.Add(Primeminister2.Year, Primeminister2);
            dictionaryPrimeminister.Add(Primeminister3.Year, Primeminister3);

            //Finding the Prime minister of 2004
            Primeminister PM2004 = dictionaryPrimeminister[2004];
            Console.WriteLine("\nThe Prime minister of 2004 is : " + PM2004.Name);

            //Adding current prime minister in the dictionary
            Primeminister Primeminister4 = new Primeminister()
            {
                Name = "Narendra Modi",
                Year = 2022
            };
            dictionaryPrimeminister.Add(Primeminister4.Year, Primeminister4);


            //After adding current prime minister, new dictionary
            Console.WriteLine("\nAfter adding current prime minister, new dictionary is : ");
            foreach (var item in dictionaryPrimeminister)
            {
                Primeminister PM = dictionaryPrimeminister[item.Key];
                Console.WriteLine("[" + PM.Name + ", " + item.Key + "]");
            }

            //Here Sorting the dictionary by year
            Console.WriteLine("\nAfter Sorting the dictionary by year, The sorted dictionary is : ");
            foreach (var item in dictionaryPrimeminister.OrderBy(k => k.Key))
            {
                Primeminister PM = dictionaryPrimeminister[item.Key];
                Console.WriteLine("[" + PM.Name + ", " + item.Key + "]");
            }
        }


        public class Primeminister
        {
            public string Name { get; set; }
            public int Year { get; set; }
        }
    }
}