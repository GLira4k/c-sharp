/*
    Estrutura Condicional

    Switch

    Utilizado quando temos muitas decisões, executamos em cascata.

    Devemos parar manualmente a execução com o comando break
*/


using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string valor = "gabriel";
            switch (valor)
            {
                case "joao":Console.WriteLine("1"); break;
                case "gabriel":Console.WriteLine("2"); break;
                case "mateus":Console.WriteLine("3"); break;
                default:Console.WriteLine("4"); break;

            }

            bool? valor = false;
            switch (valor)
            {
                case true:Console.WriteLine("1"); break;
                case false:Console.WriteLine("2"); break;
                default:Console.WriteLine("4"); break;

            }
        }
    }
}