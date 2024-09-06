/*
    Replace

    Split
    
    Substring

    Trim
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var texto = " Este é um teste. ";
            Console.WriteLine(texto.Replace("Este", "Isto"));

            var divisao = texto.Split(' ');
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(10,5);
			Console.WriteLine(resultado); 

            Console.WriteLine(texto.Trim());     

        }
    }
}