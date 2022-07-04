using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambdas and Where expressions
            List<int> nums = new List<int> { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            List<int> odds = nums.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Odds numbers:");
            odds.ForEach(odd => Console.WriteLine(odd));
            Console.WriteLine("---------------------------\n\r");



            // Select, First, Last, OrderBy, Average, Max, Min

            List<Player> players = new List<Player>
            {
                new Player { Name = "Pedro", Score = 5 },
                new Player { Name = "Jorge", Score = 8 },
                new Player { Name = "Sandra", Score = 10 },
                new Player { Name = "Pablo", Score = 4 },
                new Player { Name = "Carol", Score = 6 },
                new Player { Name = "Noe", Score = 7 },
                new Player { Name = "Rober", Score = 13 },
                new Player { Name = "Alberto", Score = 17 },
                new Player { Name = "Pepe", Score = 1 },
                new Player { Name = "Paquito", Score = 6 },
                new Player { Name = "Andres", Score = 3 }
            };

            // Players order by name
            Console.WriteLine("--== PLAYERS == --");
            players.OrderBy(p => p.Name).ToList().ForEach(x => Console.WriteLine(x.ToString()));
            
            Console.WriteLine("--== SCORES ==--\n\r");

            // Higher score
            int maxScore = players.Max(x => x.Score);
            Console.WriteLine($"Higher Score: {maxScore}");
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return "{" + Name + " | " + Score + "}";
        }
    }
}
