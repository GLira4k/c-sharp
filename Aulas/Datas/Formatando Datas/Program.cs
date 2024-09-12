/*
    d = dia (Se colocar apenas o d "{0:d}" vai chamar a data de forma resumida, se colocar o D vai chamar a data de forma mais extendida)
    M = mês
    y = ano
    h = hora
    m = minuto
    s = segundo
    f = fração de segundo (se colocado sozinho "{0:f}" combina a data e o horário no formato long)
    z = time zone = horário padrão
    t = short date time (compactar o horário ao máximo)
    T = long date time (extender o horário ao máximo)
    g = combina a data e o horário no formato short
    r = traz o padrão rfc 1123
    s = vai executar um sortable date time
    u = universal date time

    {index da data:dia/mes/ano}    

    var DataFormatada = String.Format("{0:dd/MM/yyyy}", Data);
*/

using System;

namespace MeuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Data = DateTime.Now;
            
            var DataFormatada = String.Format("{0:dd/MM/yyyy}", Data);
            Console.WriteLine(DataFormatada);

        }
    }
}