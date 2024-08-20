/*
    Tipos de Referência e Tipos de Valor

    A memória é divida em duas partes, HEAP e STACK.

    - HEAP: armazena os dados;
    - STACK: armazena as referências para os dados;

    Qualquer tipo no .NET é tratado como 
    - Tipo de referência (Reference Type);
    - Tipo de valor (Value Type);

    STACK: Armazena valores diretos e referências a objetos na HEAP.
    HEAP: Armazena dados complexos e permite alocação dinâmica de memória.
    Tipos de Valor: Dados armazenados diretamente na STACK.
    Tipos de Referência: Referências armazenadas na STACK e dados reais na HEAP 


    Value Types: Criam uma cópia do valor diretamente na memória. Não afetam outras variáveis ao modificar seu valor.

    Ex.: Tipos primitivos, tipos padrões.

    Reference Types: Criam uma cópia da referência que aponta para os dados na memória. Alterar o valor através de uma variável afeta todas as variáveis que compartilham a mesma referência.

    Ex.: Classes, arrays, objects
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 25;

            int y = x;

            Console.WriteLine(x);
			Console.WriteLine(y);

            x = 32;

            Console.WriteLine(x);
			Console.WriteLine(y);  // valor não muda


            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]); // valor alterou

        }
    }
}