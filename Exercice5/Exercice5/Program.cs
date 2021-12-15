using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
			//Récupération de la saisie utilisateur et affichage d'une chaînede caractére en fonction.
            Console.WriteLine("Saisissez un mois:");
            string inputMonth = Console.ReadLine().ToLower();
            if (inputMonth == "janvier" || inputMonth == "février" || inputMonth == "mars")
            {
                Console.WriteLine("La saison du mois saisi est l'HIVER.");
            }else if (inputMonth == "avril" || inputMonth == "mai" || inputMonth == "juin")
            {
                Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
            }
            else if (inputMonth == "juillet" || inputMonth == "aout" || inputMonth == "septembre")
            {
                Console.WriteLine("La saison du mois saisi est l'ETE.");
            }
            else if (inputMonth == "octobre" || inputMonth == "novembre" || inputMonth == "decembre")
            {
                Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
            }
            else
            {
                Console.WriteLine("Le mois saisi n'a pas été reconnu.");
            }
        }
    }
}
