using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = "Yop";
            const string password = "123";
            Console.WriteLine("Identifiant:");
            string inputId = Console.ReadLine();
            Console.WriteLine("Mot de passe:");
            string inputPwd = Console.ReadLine();
            bool pwdIdOk = false;
			//Verifie que la saisie du mot de passe et de l'identifiant saisie correspond au mot de passe et identifiant.
            pwdIdOk = login == inputId && password == inputPwd;
			//Affichage de chaîne de caractére en fonction du résultat de la verification du mot de passe et de l'identifiant à l'aide d'un switch.
            switch (pwdIdOk)
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
