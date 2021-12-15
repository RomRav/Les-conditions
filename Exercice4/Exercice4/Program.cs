using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = "Yop";
            string pwd = "123";
            Console.WriteLine("Identifiant:");
            string inputId = Console.ReadLine();
            Console.WriteLine("Mot de passe:");
            string inputPwd = Console.ReadLine();
            bool pwdIdOK = false;
			//Verifie que la saisie du mot de passe et de l'identifiant saisie correspond au mot de passe et identifiant.
            pwdIdOK = id == inputId && pwd == inputPwd;
			//Affichage de chaîne de caractére en fonction du résultat de la verification du mot de passe et de l'identifiant à l'aide d'un switch.
            switch (pwdIdOK)
            {
                case  true:
                    Console.WriteLine("Bienvenue à la Manu.");
                    break;

                case false:
                    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe. ");
                    break;
            }
        }
    }
}
