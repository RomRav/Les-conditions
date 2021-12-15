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
            pwdIdOK = id == inputId && pwd == inputPwd;
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
