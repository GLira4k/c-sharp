/*
    Estruturas Condicionais

    if
    else
    else if

    Utilizado para tomada de decisões

    Utiliza os operadores lógicos

*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 30;

            if(x < 30){
                Console.WriteLine("x é menor que 30");
            } else{
                Console.WriteLine("x é maior ou igual a 30");
            }
        }
    }
}