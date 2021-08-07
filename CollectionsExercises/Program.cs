using System;
using System.Collections.Generic;

namespace CollectionsExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Squared Random Exercise
            Random random = new Random();
            var list = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                list.Add(random.Next(1, 50));
            }
            var sqauredList = new List<int>();
            foreach (var item in list)
            {
                sqauredList.Add(item * item);
            }
            sqauredList.RemoveAll(odd => odd % 2 != 0);

            Console.WriteLine($"Original List: {String.Join(", ", list)}");
            Console.WriteLine($"Squared List with odds removed: {String.Join(", ", sqauredList)}");

            Console.WriteLine();

            //Planets and Spaceships Exercise
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");


            var spacecraftProbes = new Dictionary<string, List<string>>();
            spacecraftProbes.Add("Mercury", new List<string> { "Mariner 10", "Messenger" });
            spacecraftProbes.Add("Venus", new List<string> { "Mariner 2", "Mariner 5", "Pioneer Venus Orbiter", "Magellan" });
            spacecraftProbes.Add("Earth", new List<string> { "Epoxi", "Stardust", "Rosetta" });
            spacecraftProbes.Add("Mars", new List<string> { "Mariner 4", "Viking", "Perseverance", "Curiosity", "Opportunity" });
            spacecraftProbes.Add("Jupiter", new List<string> { "Pioneer 10", "Voyager", "Cassini", "Juno" });
            spacecraftProbes.Add("Saturn", new List<string> { "Pioneer 11", "Voyager 1 and 2" });
            spacecraftProbes.Add("Uranus", new List<string> { "Voyager 2", "Gan De" });
            spacecraftProbes.Add("Neptune", new List<string> { "Voyager 2", "IHP-2" });

            foreach (var planet in planetList)
            {
                foreach (var (target, probes) in spacecraftProbes)
                {
                    if(target == planet)
                    {
                        Console.WriteLine($"{planet} was visited by {String.Join(", ", probes)}");
                    }
                }    
            }

            Console.WriteLine();

            //Family Dictionary Exercise
            var familyDictionary = new Dictionary<string, Dictionary<string, string>>();
            familyDictionary.Add("Brother", new Dictionary<string, string>() { { "Name", "Mike Wazowski" }, { "Age", "28" } });
            familyDictionary.Add("Big Brother", new Dictionary<string, string>() { { "Name", "James P. Sullivan" }, { "Age", "28" } });
            familyDictionary.Add("Sister", new Dictionary<string, string>() { { "Name", "Boo" }, { "Age", "2" } });
            familyDictionary.Add("Dad", new Dictionary<string, string>() { { "Name", "Bill Sullivan" }, { "Age", "60" } });
            familyDictionary.Add("Mom", new Dictionary<string, string>() { { "Name", "Mrs. Sullivan" }, { "Age", "59" } });


            foreach (var (person, details) in familyDictionary)
            {
                var names = details["Name"];
                var ages = details["Age"];
              
                Console.WriteLine($"{names} is my {person} and is {ages} years old.");
            }


            Console.WriteLine();

            //Stock Purchase Dictionary
            var stocks = new Dictionary<string, string>()
            {
                { "GM", "General Motors" },
                { "CAT", "Caterpillar" },
                { "F", "Ford" },
                { "PEP", "Pepsi" },
                { "COKE", "Coca-Cola" }
            };

            //To get value from Dictionary, can use square brackets with Key
            string gmStock = stocks["GM"];
            Console.WriteLine(gmStock);

            //Tuple
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 55.05)); //can write each type's name
            purchases.Add(("CAT", 5, 208.35));
            purchases.Add(("F", 75, 13.80));
            purchases.Add(("PEP", 125, 154.33));
            purchases.Add(("COKE", 25, 393.31));
            purchases.Add(("CSCO", 15, 55.59));
            purchases.Add(("SYY", 50, 73.92));
            purchases.Add(("ZM", 122, 383.47));

            var ownershipReport = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                var value = purchase.shares * purchase.price;
                if (ownershipReport.ContainsKey(purchase.ticker))
                {
                    ownershipReport[purchase.ticker] += value;
                    Console.WriteLine($"{purchase.ticker} ${value}");
                }
                else
                {
                    ownershipReport.Add(purchase.ticker, value);
                    Console.WriteLine($"{purchase.ticker} ${value}");
                }
            }

            Console.WriteLine("************OWNERSHIP REPORT*********************");

            foreach (var item in ownershipReport)
            {
                foreach (var stock in stocks)
                {
                    if(item.Key == stock.Key)
                    {
                        Console.WriteLine($"{stock.Value}: {item.Value}");
                    }
                }
            }
         

        }
    }
}
