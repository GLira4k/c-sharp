/*
    Indices / index

    indica um item dentro de uma lista, um array

    começa por 0

    sempre temos que passar o mesmo tipo
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string args)
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.IndexOf("o"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }
    }
}