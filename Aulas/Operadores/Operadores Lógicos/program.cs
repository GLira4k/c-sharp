/*
    Operadores lógicos
    
    E - and: && <--- Necessáriamente obriga que as condições sejam verdadeiras
    Ou - or: || <--- Atende uma das condições
    Não - not: ! <--- 
    
    Usados para operações condicionais.

    Retorna sempre True ou False

*/

using System;

namespace MeuApp 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 12;

            bool entre = (x > 25) && (x < 40); 
            bool ou = (x > 25) || (x < 40);
            bool negacao = !(x < 25);

            Console.WriteLine(entre);
            Console.WriteLine(ou);
            Console.WriteLine(negacao);
        }
    }
}