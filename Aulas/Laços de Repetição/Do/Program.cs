/*
    Laço de Repetição: Do

    do/while

    Tradução "faça", ou seja, realiza uma ação enquanto.

    Exige apenas uma condição no while.

    Checa a condição depois de executar
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            do{
                Console.WriteLine(i);
                i++;
            } while(i <= 5);
        }
    }
}