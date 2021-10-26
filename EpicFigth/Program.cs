using System;

namespace EpicFigth
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroweapon, villainweapon;
            heroweapon = RandomWeapon();
            hero = RandomHero();
            villain = RandomVillain();
            villainweapon = RandomWeapon();
            int heroHP = GeneraterHP(hero);
            int villainHP = GeneraterHP(villain);

            
            Console.WriteLine($"{hero} ({heroHP}HP) will fight {villain} ({villainHP}HP).");
            Console.WriteLine($"{hero} will figth with {heroweapon}");
            Console.WriteLine($"{villain} will figth with {villainweapon}");
            
            while (heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hit(villain, hero, villainweapon);
                villainHP = villainHP -  Hit(hero, villain, heroweapon);
            }

            if (heroHP <= 0)
            {
                Console.WriteLine("Dark side wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }
        }


        private static int Hit(string charactorOne, string charactorTwo, string weapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, weapon.Length / 2);
            Console.WriteLine($"{charactorOne} hit {strike}.");

            if(strike == weapon.Length /2 - 1)
            {
                Console.WriteLine($"Awesome! {charactorOne} made a critical hit!");

            }
            else if (strike == 0)
            {
                Console.WriteLine($"{charactorTwo} dodged the attack!");
            }
            return strike;
        }
            

        private static int GeneraterHP(string someCharactor)
        {
            Random rnd = new Random();
            return rnd.Next(someCharactor.Length, someCharactor.Length + 10);


                
        }

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, someArray.Length);

            return RandomIndex;
        }

        private static string RandomHero()
        {
            string[] heros = { "Batman", "Spongebob", "Spiderman", "Patric" };

            return heros[RandomIndex(heros)];

        }

        private static string RandomVillain()
        {
            string[] villains = { "Pepa Pig", "Mirjam", "Sirley" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, villains.Length);

            string randomVillain = villains[RandomIndex];
            return randomVillain;

        }

        private static string RandomWeapon()
        {
            string[] weapon = { " axe", "sword", "pistol" };

            return weapon[RandomIndex(weapon)];
        }


    }
}
