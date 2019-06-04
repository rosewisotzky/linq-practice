using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {

    class Program {
        static void Main (string[] args) {

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            string L = "L";

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith (L)
            orderby fruit ascending
            select fruit;

            foreach (string fruit in LFruits) {
                Console.WriteLine ($"{fruit}");
            }
            Console.WriteLine ("               ");
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where (n => n % 4 == 0 || n % 6 == 0).OrderBy (n => n);
            foreach (int number in fourSixMultiples) {
                Console.WriteLine ($"{number}");
            }
            Console.WriteLine ("                  ");
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = names.OrderByDescending (name => name).ToList ();
            foreach (string name in descend) {
                Console.WriteLine ($"{name}");
            }
            Console.WriteLine ("       ");
            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            List<int> descendingNumbers = numbers2.OrderBy (n => n).ToList ();
            foreach (int number in descendingNumbers) {
                Console.WriteLine ($"{number}");
            }
            Console.WriteLine ("   ");
            // Output how many numbers are in this list
            List<int> numbers3 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            Console.WriteLine($"{numbers3.Count()}");
        }

    }
}