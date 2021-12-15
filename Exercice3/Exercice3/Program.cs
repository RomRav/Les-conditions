using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saissez votre âge:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saissez votre genre: (M/F):");
            string gender = Console.ReadLine().ToLower();
            if (age >= 18)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur. ");
                }
                else
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure.  ");
                }
            }
            else
            {
                if (gender == "m")
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineure. ");
                }
                else
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure.  ");
                }
            }
        }
    }
}
