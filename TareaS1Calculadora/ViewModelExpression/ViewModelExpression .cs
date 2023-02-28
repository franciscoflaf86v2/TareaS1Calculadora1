using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TareaS1Calculadora.Models;
using Xamarin.Forms;

namespace TareaS1Calculadora.ViewModelExpression
{
    public class ViewModelExpression : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Expression _expression;
        public Expression Expression
        {
            get { return _expression; }
            set
            {
                _expression = value;
                RaisePropertyChanged(nameof(Expression));
            }
        }

        private double _resultado;
        public double Resultado
        {
            get { return _resultado; }
            set
            {
                _resultado = value;
                RaisePropertyChanged(nameof(Resultado));
            }
        }

        public ICommand CalcularCommand => new Command<string>(Calcular);

        public ViewModelExpression()
        {
            Expression = new Expression();
        }

        public void Calcular(string operacion)
        {
            try
            {
                switch (operacion)
                {
                    case "Sumar":
                        Resultado = Expression.Sumar();
                        break;
                    case "Restar":
                        Resultado = Expression.Restar();
                        break;
                    case "Multiplicar":
                        Resultado = Expression.Multiplicar();
                        break;
                    case "Dividir":
                        Resultado = Expression.Dividir();
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                Resultado = Double.NaN;
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}