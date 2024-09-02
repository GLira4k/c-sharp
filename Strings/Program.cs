/*
    Guids 

    Global Unic Identifier

    É um identificador unico.

    Ele gera um hash, um identificador único a cada execução.

    Ele é frequentemente usado para identificar objetos de forma única em um sistema.
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("efabd429-8d8e-46b5-b8be-bedc427c565f");

            Console.WriteLine(id.ToString().Substring(0,8));
        }
    }
}