/*
    Laço de repetição: for

    Tradução "para", ou seja, para cada item em um valor

    Executa uma determinada ação várias vezes

    Exige 3 parâmetros:

    - Contador;
    - Condição;
    - Incremento;
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[]args)
        {
            //  Contador, condição e incemento 
            for(var i = 0; i <= 5; i++)
                Console.WriteLine(i);
        }
    }
}