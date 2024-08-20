/*
    Enums ou enumeradores

    Usado para fornecer uma melhor visualização do código.

    Subtituem o uso dos inteiros
    
    Enums (Enumeradores) são uma funcionalidade do C# que permite definir um conjunto de valores nomeados e constantes, facilitando a representação de um grupo fixo de opções ou estados relacionados. Eles ajudam a melhorar a clareza e a manutenção do código ao substituir números mágicos ou valores arbitrários por nomes descritivos.
         É necessário esse "E".
    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3,
        Viúvo = 4
    }

*/

using System;

namespace MeuApp
{

    public enum EProductType 
    {
        // Definindo os valores do enum
        Produto = 1,
        Servico= 2,
    }

    public struct Produto
    {
        public int Id;
        public string Nome;
        public float Valor;
        public int Quantidade;
        public EProductType Type;

        public double PrecoEmDolar(double dolar)
        {
            return Valor * dolar;
        }

        // Construtor da struct
        public Produto(int id, string nome, float valor, int quantidade, EProductType tipo)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            Type = tipo;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Produto gas = new Produto(1, "Gás", 120f, 25, EProductType.Produto);

            Produto taxaEntrega = new Produto(2, "Entrega", 5.50f, 1, EProductType.Servico);

            Console.WriteLine("ID: " + gas.Id);
            Console.WriteLine("Nome do Produto : " + gas.Nome);
            Console.WriteLine("Valor: " + "R$ " + gas.Valor);
            Console.WriteLine("Quantidade: " + gas.Quantidade);
            Console.WriteLine("Tipo de Produto: " + gas.Type);

            Console.WriteLine("ID: " + taxaEntrega.Id);
            Console.WriteLine("Nome do Produto: " + taxaEntrega.Nome);
            Console.WriteLine("Valor: " + "R$ " + taxaEntrega.Valor);
            Console.WriteLine("Quantidade: " + taxaEntrega.Quantidade);
            Console.WriteLine("Tipo de Produto: " + taxaEntrega.Type);
        }
    }
}