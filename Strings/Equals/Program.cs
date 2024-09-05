/*
    Equals

    Tipo de comparação de Strings 
*/


using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string args)
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("EsTe tExto é um teSTe", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.Equals("Este texto é um texto"));
        }
    }
}