using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finisher = true;          
            int userNumberAge;
			//Boucle qui demande la saisie de l'âge tant que la saisie n'est pas un entier.
            while (finisher)
            {
				//Demande de l'âge et récupération des données saisie
                Console.WriteLine("Qu'elle est votre âge?:");
                string userStringAge = Console.ReadLine();
				//Vérification que la saisie est bien convertible en entier.
                if (int.TryParse(userStringAge, out userNumberAge))
                {
					//Affichage d'une chaîne de caractére en fonction de l'âge saisie.
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
