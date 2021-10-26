using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "chicken wings", "burger", "french fries", "salad", "chicken nuggeets" };
            string[] drinks = { "coca-cola", "fanta", "red bull", "sprite" };
            string[] movies = { "Arrow", "The vampire diearies", "Squid Game" };

            //DisplayRandomFromArray(foods);
            //DisplayRandomFromArray(drinks);
            string randomSnack = PickRandomFromArray(foods);
            string randomDrink = PickRandomFromArray(drinks);
            string randomMovie = PickRandomFromArray(movies);

            Console.WriteLine($"Computer picked {randomSnack} and {randomDrink} for a {randomMovie}");
        }


        private static string PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[RandomIndex];

            return randomElement;
        }

        private static void DisplayRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"computer has chosen {someArray[RandomIndex]}");

                

        }
    }
}
