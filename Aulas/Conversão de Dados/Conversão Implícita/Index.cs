/*
    Conversão Implícita

    É comum precisarmos tranformar um dado de tipo X para tipo Y. As conversões implicitas são conversões que:

    - Podem ser executadas apenas com passagem de dados.
    - Possuem tipos compatíveis
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args){
            float valor = 25.8F;
            int outro = 25;

            valor = outro;
            Console.WriteLine(outro); // Esta conversão ocorreu pois, um número real pode receber um número inteiro.
        }
    }
}