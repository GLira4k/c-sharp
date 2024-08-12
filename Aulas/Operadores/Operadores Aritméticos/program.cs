/*
    Operadores Aritméticos

    Soma: +
    Subtração: -
    Multiplicação: *
    Divisão: /

    Ordem de prioridade (Igual a matemática)
    * ou /, + ou -, caso queira executar em outra ordem, usar parênteses igual a matemática.

    Se for valor real, vai ser arredondado.

    4.4 --> 5;

    Aceita short, int, float, double e decimal
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int soma = 25 + 22;
            int subtracao = 25 - 22;
            int multiplicacao = 25 * 22;
            int divisão = 25 / 5;

            int x = 2 * (2 + 2);
        }
    }
}