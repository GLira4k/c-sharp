using System;
using System.Text;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string args)
        {
            var texto = new StringBuilder();
            texto.Append("Este é um teste");
            texto.Append(" teste1 ");
            texto.Append(" teste2 ");
            texto.Append(" teste3 ");
            texto.Append(" teste4");

            texto.ToString();
            Console.WriteLine(texto);

        }
    }
}