using System;
using System.Linq;

namespace FaturamentoDistribuidora
{
    public class Program
    {
        public static void Main()
        {
            decimal[] faturamentoDiario = new decimal[365];

            Random random = new Random();
            for (int i = 0; i < faturamentoDiario.Length; i++)
            {
                faturamentoDiario[i] = (decimal)(random.Next(0, 1000) + random.NextDouble());
            }

            var diasComFaturamento = faturamentoDiario.Where(f => f > 0).ToArray();

            decimal menorFaturamento = diasComFaturamento.Min();
            Console.WriteLine("Menor valor de faturamento: " + menorFaturamento);

            decimal maiorFaturamento = diasComFaturamento.Max();
            Console.WriteLine("Maior valor de faturamento: " + maiorFaturamento);

            decimal mediaFaturamento = diasComFaturamento.Average();
            Console.WriteLine("Média de faturamento: " + mediaFaturamento);

            int diasAcimaDaMedia = diasComFaturamento.Count(f => f > mediaFaturamento);
            Console.WriteLine("Dias com faturamento acima da média: " + diasAcimaDaMedia);
        }
    }
}