using System;
using TrabalhoLTP_3_Interfaces;

namespace TrabalhoLTP_3_Interfaces
{
    class Program
    {
        static void Main()
        {
            CalcMultilaser multilaser = new CalcMultilaser();
            Console.Write(multilaser);
            double resultadoAdicao = multilaser.Adicao(5.0, 2.0);
            double resultadoSubtracao = multilaser.Subtracao(8.0, 3.0);
            double resultadoMultiplicacao = multilaser.Multiplicacao(4.0, 2.5);
            double resultadoDivisao = multilaser.Divisao(10.0, 3.0);
            Console.WriteLine(resultadoAdicao);
            Console.WriteLine(resultadoSubtracao);
            Console.WriteLine(resultadoMultiplicacao);
            Console.WriteLine(resultadoDivisao);
        }
    }
}










