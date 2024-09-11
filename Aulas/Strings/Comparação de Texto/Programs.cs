using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            var texto = "Testando";

            Console.WriteLine(texto.CompareTo("Testando")); // retorna 0 por não ter nenhum erro 
            Console.WriteLine(texto.CompareTo("testando")); // retorna um por ter um erro

            var texto2 = "estamos em fase de teste";

            Console.WriteLine(texto2.Contains("teste")); // verifica se a palavra em parênteses está na string
            Console.WriteLine(texto2.Contains("teste", StringComparison.OrdinalIgnoreCase)); // Para ignorar o case sensitive em uma comparação


        }
    }
}