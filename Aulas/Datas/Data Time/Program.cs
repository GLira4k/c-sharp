/*
    DateTime é um ValueType

    DateTime é um Struct

    os structs são sempre inicializados com valores padrão 
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = new DateTime();
            Console.WriteLine(data);

            var data2 = DateTime.Now;
            Console.WriteLine(data2);
        }
    }
}