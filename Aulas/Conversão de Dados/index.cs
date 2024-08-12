using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.5f;

            // real = inteiro; <--- Conversão implícita
            // inteiro = (int)real;  <--- Conversão Explícita
            // string valorReal = real.ToString();
            // inteiro =  int.Parse(valorReal);

            inteiro = Convert.ToInt32(real);

            Console.WriteLine(inteiro.Convert.ToDouble);

        }
    }
}