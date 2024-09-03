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
            var id = Guid.NewGuid(); // Gera um novo guid
            id.ToString();

            id = new Guid("efabd429-8d8e-46b5-b8be-bedc427c565f"); // Precisa está nessa formatação para rodar

            id = new Guid(); // Irá gerar um guid só com zeros

            Console.WriteLine(id.ToString().Substring(0,8));
        }
    }
}