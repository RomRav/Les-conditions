using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finisher = true;
            while (finisher)
            {
                Console.WriteLine("Saissez votre âge:");
                string ageInString = Console.ReadLine();
                int age;
				//Vérification que la saisie est bien convertible en entier.
                if (int.TryParse(ageInString,out age))
                {
                    Console.WriteLine("Saissez votre genre: (M/F):");
                    string gender = Console.ReadLine().ToLower();
					//Verification de la saisie et affichage de chaîne de caractére en fonction des données saisie.
                    if (age >= 18)
                    {
                        if (gender == "m")
                        {
                            Console.WriteLine("Vous êtes un homme et vous êtes majeur. ");
                            finisher = false;
                        }
                        else if(gender == "f")
                        {
                            Console.WriteLine("Vous êtes une femme et vous êtes majeure.  ");
                            finisher = false;
                        }
                        else
                        {
                            Console.WriteLine("La saisie n'est pas correct");
                        }
                    }
                    else
                    {
                        if (gender == "m")
                        {
                            Console.WriteLine("Vous êtes un homme et vous êtes mineure. ");
                            finisher = false;
                        }
                        else if(gender == "f")
                        {
                            Console.WriteLine("Vous êtes une femme et vous êtes mineure.  ");
                            finisher = false;
                        }
                        else
                        {
                            Console.WriteLine("La saisie n'est pas correct");
                        }
                    }   
                }
                else
                {
                    Console.Write("La saisie n'est pas un nombre.");
                }
            }
        }
    }
}
