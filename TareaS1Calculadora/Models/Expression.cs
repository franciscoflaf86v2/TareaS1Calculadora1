using System;
using System.Collections.Generic;
using System.Text;

namespace TareaS1Calculadora.Models
{
    public class Expression
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double Sumar()
        {
            return Num1 + Num2;
        }

        public double Restar()
        {
            return Num1 - Num2;
        }

        public double Multiplicar()
        {
            return Num1 * Num2;
        }

        public double Dividir()
        {
            if (Num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return Num1 / Num2;
        }
    }
}
