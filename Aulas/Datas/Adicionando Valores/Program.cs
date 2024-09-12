/*
    A depender dos casos, vamos precisar acrescentar dias, ou meses

    variavel.AddDays(qtd de dias a adicionar)
    variavel.AddMonths(qtd de meses a adicionar)
    variavel.AddYears(qtd de anos a adicionar)

    é possível subtrair, basta colocar o número negativo
    

*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = DateTime.Now;

            Console.WriteLine(data.AddDays(12));
            
            Console.WriteLine(data.AddMonths(1));

            Console.WriteLine(data.AddYears(1));
        }
    }
}