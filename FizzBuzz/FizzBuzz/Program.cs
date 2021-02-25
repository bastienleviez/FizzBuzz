using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playMain = true;
            bool playAgainValide = true;
            
            while (playMain == true)
            {
                playAgainValide = true;
                Console.WriteLine("Bienvenue sur le Fizzbuzz, veuillez écrire un chiffre:");
                var entree = Convert.ToInt32(Console.ReadLine());
                var retourFizzBuzz = FizzBuzzChecker.PlayFizzBuzz(entree);
                Console.WriteLine(retourFizzBuzz);
                while (playAgainValide == true)
                {
                    Console.WriteLine("Voulez vous rejouer ? o/n");
                    var rejouer = Console.ReadLine();
                    if (rejouer == "o")
                    {
                        playAgainValide = false;
                    }
                    if (rejouer == "n")
                    {
                        playAgainValide = false;
                        playMain = false;
                    }
                }
            }
        }
    }
}
