/*
    Equals

    Tipo de comparação

    Compara o texto inteiro, case sensetive

    o conteudo tem que ser idêntico para dar true

    para comparar sempre temos que passar o mesmo tipo
*/


using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string args)
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("EsTe tExto é um teSTe", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.Equals("Este texto é um texto"));
        }
    }
}