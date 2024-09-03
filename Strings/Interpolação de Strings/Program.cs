using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var price = 10.2;
            var text = "O preço do produto é: R$" + price + ", apenas na promoção."; // Concatenação 
            Console.WriteLine(text);

            var text2 = string.Format("O preço do produto é R${0}, \n apenas na promoção.", price); // Formata uma string, uma cadeia de caracteres
            Console.WriteLine(text2);

            var text3 = $"O preço do produto é R${price}, apenas na promoção";
            Console.WriteLine(text3);

            var text4 = @$"O preço do produto
             é R${price}, apenas na promoção";
            Console.WriteLine(text4);
        }
    }
}