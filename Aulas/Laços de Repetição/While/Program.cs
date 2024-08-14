/*
    Laço de Repetição: while

    Tradução "Enquanto", ou seja, enquanto uma condição for verdadeira.

    Exige apenas uma condição

    Checa as condições antes de executar
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}