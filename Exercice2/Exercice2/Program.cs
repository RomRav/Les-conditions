using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finisher = true;
            
            int userNumberAge;
            while (finisher)
            {
                Console.WriteLine("Qu'elle est votre âge?:");
                string userStringAge = Console.ReadLine();
                if (int.TryParse(userStringAge, out userNumberAge))
                {
                    if (userNumberAge >= 18)
                    {
                        Console.WriteLine($"Vous avez {userNumberAge} ans, vous êtes donc majeur.e.");
                    }
                    else
                    {
                        Console.WriteLine($"Vous avez {userNumberAge} ans, vous êtes donc mineur.e.");
                    }
                    finisher = false;
                }
                else
                {
                    Console.WriteLine("La saisie n'est pas un nombre.");
                }
            }
           
            
        }
    }
}
