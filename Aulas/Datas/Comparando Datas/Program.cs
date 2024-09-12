using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // DateTime? data = null;
            
            var data = DateTime.Now;

            if(data.Date == DateTime.Now.Date) // é melhor comparar apenas a data, se considerarmos as horas, vai ter uma diferença entre os milissegundos e nunca vai dar true
            {
                Console.WriteLine("é igual");
            }

            Console.WriteLine(data);
        }
    }
}