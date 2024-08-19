/*
    Métodos ou funções

    Podemos segmentar nosso programa em funções.

    Possui um retorno, um nome e parâmetros, essa composição é chamada de camada de assinatura.

    Começam sempre com letra maiúscula.
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           MeuMetodo();
           RetornaNome("Gabriel", "Lira");
        }
        static void MeuMetodo(){
            Console.WriteLine("Olá, mundo!");
        }
        static string RetornaNome(string nome, string sobrenome, int idade = 0){
            return nome + sobrenome;
        }


    }
}