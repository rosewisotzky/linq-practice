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
            Console.WriteLine ($"{numbers3.Count()}");
            Console.WriteLine ("        ");
            // How much money have we made?
            List<double> purchases = new List<double> () {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            Console.WriteLine ($"The total of our numbers is {purchases.Sum()}");
            Console.WriteLine ("        ");
            // What is our most expensive product?
            List<double> prices = new List<double> () {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
            Console.WriteLine ($"Our largest number is {prices.Max()}");
            Console.WriteLine ("        ");

            /*
    Store each number in the following List until a perfect square
    is detected.

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
            List<int> wheresSquaredo = new List<int> () {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            // Here we're using TakeWhile to snag the numbers in our list and put them in a new list. We're giving it the instructions to take numbers until our boolean is true. We set our boolean to false, and it's saying ' hey, run through these numbers, slap em in a new list WHILE they are NOT perfect squares'. So when we hit a perfect square, that boolean is now a true value and we stop storing our numbers in notPerfect.
            List<int> notPerfect = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) * Math.Sqrt(n) != n).ToList();

            foreach(int number in notPerfect) {
                Console.WriteLine($"{number}");
            }

        }
    }
}