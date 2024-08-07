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
            // byte (8-bit) também chamado de byte array, é utilizado para representar um byte de fato 0 até 255
            byte x = 1; 
            // sbyte (8-bit) sbyte significa "Signed Byte" byte com sinal, permite valores negativos de -128 até 127
            sbyte x = -1;
            // números inteiros, sem pontuação, podem ser definidos pelos seguintes tipos: short (16-bit), int (32-bit), e long (64-bit), adicionando a letra "u" no inicio de cada um (ex.: ushort) tranformo ele em "Unsigned" para não receber valores negativos.
            short x = 1;
            int x = 1; 
            long x = 1;

        }
    }
}