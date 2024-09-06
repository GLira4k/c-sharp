/*
    ToLower

    Para converter uma string toda para letras minusculas


    ToUpper

    Para converter uma string toda para letras maiusculas

    Insert

    Para adicionar uma série de caracteres a uma string, indicando o índice

    Remove

    Para remover uma série de caracteres de uma string, indicando o índice

    Length

    Para printar quantos caracteres uma string tem
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var texto = "Este é um teste.";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Insert(5, "'A' "));
            Console.WriteLine(texto.Remove(6, 1));
            Console.WriteLine(texto.Length);
        }
    }
}