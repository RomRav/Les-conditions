using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
			//Affiche une chaîne de caractére différent en fonction d'un booléen
            bool rainy = false;
            if (rainy)
            {
                Console.WriteLine("Bonjour, il ne pleut pas aujourd’hui, bonne journée.");
            }
            else
            {
                Console.WriteLine("Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie.");
            }
            
        }
    }
}
