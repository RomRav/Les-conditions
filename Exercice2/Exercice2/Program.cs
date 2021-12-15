using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qu'elle est votre âge?:");
            string userStringAge = Console.ReadLine();
            int userNumberAge = Convert.ToInt32(userStringAge);
            if (userNumberAge >= 18)
            {
                Console.WriteLine($"Vous avez {userNumberAge} ans, vous êtes donc majeur.e.");
            }
            else
            {
                Console.WriteLine($"Vous avez {userNumberAge} ans, vous êtes donc mineur.e.");
            }
        }
    }
}
