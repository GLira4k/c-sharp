/*
    Replace

    Usado para trocar palavras dentro da string

    Split
    
    Usado para transformar uma string em um array, a partir de um delimilador (geralmente virgula e espaço)

    Substring

    seleciona uma cadeia de caracteres com base nos parâmetros passados no método, texto.Substring(10, 5) (a partir de qual índice, quantos caracteres selecionar)

    Trim

    exclui os espaços no início e no final das strings
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