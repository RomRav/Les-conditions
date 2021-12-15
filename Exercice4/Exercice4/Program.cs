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
            Console.WriteLine("Mot de pass:");
            string inputPwd = Console.ReadLine();
            if(id==inputId && pwd == inputPwd)
            {
                Console.WriteLine("Bienvenue à la Manu.");
            }else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe. ");
            }
        }
    }
}
