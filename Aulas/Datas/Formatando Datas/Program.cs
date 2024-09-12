/*
    d = dia
    M = mês
    y = ano
    h = hora
    m = minuto
    s = segundo
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Data = DateTime.Now;
            
            var DataFormatada = String.Format("{0:dd/MM/yyyy}", Data);
            Console.WriteLine(DataFormatada);

        }
    }
}