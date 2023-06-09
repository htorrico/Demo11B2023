using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo11B2023.ViewModels
{
    public class OperacionesViewModel
    {
        public int ValorA { get; set; }
        public int ValorB { get; set; }
        public int Resultado { get; set;}

        public ICommand Sumar { get; set; }
        public ICommand Restar { get; set; }

        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                Resultado = ValorA + ValorB;
            });


            Restar = new Command(() =>
            {
                Resultado = ValorA + ValorB;
            });
        }

    }
}
