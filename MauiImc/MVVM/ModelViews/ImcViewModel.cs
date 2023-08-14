using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiImc.MVVM.ModelViews
{
    public class ImcViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        private void AtualizaImc()
        {
            RaisePropertyChanged(nameof(Imc));
            RaisePropertyChanged(nameof(Classificacao));
        }

        private double peso = 70;
        private double altura = 150;

        public double Altura
        {
            get => altura;
            set
            {
                altura = value;
                AtualizaImc();
            }
        }

        public double Peso
        {
            get => peso;
            set
            {
                peso = value;
                AtualizaImc();
            }
        }

        public double Imc => Math.Round(Peso / Math.Pow(Altura / 100, 2), 2);

        public string Classificacao
        {
            get
            {
                if (Imc < 18.5)
                    return "Abaixo do peso";
                else if (Imc < 25)
                    return "Peso normal";
                else if (Imc < 30)
                    return "Sobrepeso";
                else
                    return "Obesidade";
            }
        }
    }
}
