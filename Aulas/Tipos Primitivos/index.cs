/* Tipos Primitivos (Também conhecidos como *built-in types*)

    Eles defivam do tipo base chamado system

    São classificados em:

    - Tipos Simple (Simple Types)
    - Enumeradores (Enums)
    - Estruturas (Structs)
    - Tipos Nulos (Nullable Types)

*/

using System;

namespace MeuApp {

    public class program
    {
        public static void Main()
        {
            // byte (8-bit) também chamado de byte array, é utilizado para representar um byte de fato 0 até 255.
            byte x = 1; 
            // sbyte (8-bit) sbyte significa "Signed Byte" byte com sinal, permite valores negativos de -128 até 127.
            sbyte x = -1;
            // números inteiros, sem pontuação, podem ser definidos pelos seguintes tipos: short (16-bit), int (32-bit), e long (64-bit), adicionando a letra "u" no inicio de cada um (ex.: ushort) tranformo ele em "Unsigned" para não receber valores negativos.
            short x = 1;
            int x = 1; 
            long x = 1;
            // números reais, com pontuação, podem ser definidos pelos seguintes tipos: float (Precisa da notação "f", 32-bits), double(64-bit) e decimal(Precisa da notação "m", 128-bit). Aceita números negativos e positivos.
            float x = 1.100f;
            double x = 1.200;
            decimal x = 13.000m;
            //boolean (8-bit)
            bool x = true;
            //char (16-bit), utilizado para armazenar apenas um caractere no formato Unicode, atribuição de um valor é dada por aspas simples.
            char x = 'G'; 
            // string, utilizado para armazenar uma lista de char, a atribuição é dada por aspas duplas.
            string x = "Gabriel Xavier Lira";
            // var, substitui o nome de um tipo, atribuindo o tipo do primeiro valor.
            var x = 25;
            var y = 2.1;
            var z = "Gabriel";
            var k = 'G';
            // object, tipo genérico que recebe qualquer valor ou objeto, não atribui um tipo do valor.
            object x = 1;
            object y = "Gabriel";
            object z;
        }
    }
}