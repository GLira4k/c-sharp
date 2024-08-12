/*
    Operadores de Atribuição

    O operador utilizado para a atribuição é o =.

    Mas podemos usar o = com um operador aritmético para executar algo durante a atribuição:

    x += 5; é o mesmo que x = x + 5
*/


using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 5;
            
            x += 5;
            x -= 1;
            x *= 10;
            x /= 2;

            Console.WriteLine(x);
        }
    }
}