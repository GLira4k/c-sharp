/*
    Structs ou estruturas

    Tipos de dado estruturado.

    Structs no C# é uma funcionalidade que permite criar Value Types personalizados, agrupando diferentes tipos de dados em uma única estrutura. Eles são usados principalmente para representar pequenos conjuntos de dados relacionados, como um produto, um ponto em um sistema de coordenadas, ou uma entrada em um sistema de vendas.

    Struct é uma funcionalidade do C# que permite a criação de novos Value Types com parâmetros para utilização, sendo esses parâmetros diferentes tipos ou não.
*/

using System;

namespace MeuApp
{
    // Definição da struct Produto
    public struct Produto
    {
        public int Id;
        public string Nome;
        public float Valor;
        public int Quantidade;

        public double PrecoEmDolar(double dolar)
        {
            return Price * dolar;
        }

        // Construtor da struct
        public Produto(int id, string nome, float valor, int quantidade)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            // Instanciando a struct Produto
            Produto banana = new Produto(1, "Banana", 7.99f, 25);

            Console.WriteLine("ID: " + banana.Id);
            Console.WriteLine("Nome do Produto : " + banana.Nome);
            Console.WriteLine("Valor: " + "R$ " + banana.Valor);
            Console.WriteLine("Quantidade: " + banana.Quantidade);
        }
    }
}