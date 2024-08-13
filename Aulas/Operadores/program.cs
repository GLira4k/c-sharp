using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 2;
            // x += 3;
            // x = 2 * (2 + 2);
            // x++;
            //x--;
            // Console.WriteLine(x < 3);

            int idade = 18;
            int maioridade = 21;
            int idadeMaxima = 65;

            if(idade >= maioridade && idade < idadeMaxima){
                Console.WriteLine("Você é adulto");
            } else if(idade > idadeMaxima){
                Console.WriteLine("Você é um idoso");
            } else{
                Console.WriteLine("Você é um jovem");
            }

            Console.WriteLine("Finalizou o Programa");
        }
    }
}