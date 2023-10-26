using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLTP_3_Interfaces
{

    
    public class CalcMultilaser : ICalculadora<double>
        {
            public double Adicao(double numA, double numB)
            {
                return numA + numB;
            }

            public double Subtracao(double numA, double numB)
            {
                return numA - numB;
            }

            public double Multiplicacao(double numA, double numB)
            {
                return numA * numB;
            }

            public double Divisao(double numA, double numB)
            {
                if (numB == 0)
                {
                    throw new ArgumentException("Não é possível dividir por zero.");
                }
                return numA / numB;
            }
            
        }
    }
