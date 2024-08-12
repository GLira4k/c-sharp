/* 
    Nullable Types

    Null é diferente de zero ou uma string vazia, para atribuir um null a qualquer tipo (primitivo ou complexo), é preciso colocar uma interrogação em frente ao tipo

    Void (Vazio)

*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main()
        {
            int? x = 0;
            Console.WriteLine(x);
            x = null;
            Console.WriteLine(x);
            x = 23;
            Console.WriteLine(x);
        }
    }
}