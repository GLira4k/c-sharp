/*
    Convesão Explícita

    Devemos informar obrigatoriamente o tipo a ser convertido, ocorre quando os tipos não são compatíveis.

    É dada pelo uso do tipo entre parênteses antes da atribuição.
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public void Main(){
            int x = 100;
            uint xSemSinal = (uint)x; // Conversão explícita
        }
    }
}