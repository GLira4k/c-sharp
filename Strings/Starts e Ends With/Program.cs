/*
    StartsWith e EndsWith

    Tipo de comparação de strings

    Inicia com

    Termina com
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string args)
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));


            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("texto"));
        }
    }
}