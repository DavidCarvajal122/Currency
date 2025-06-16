using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Currency.ViewModels
{
    internal class CambioDivisasViewModel : INotifyPropertyChanged
    {
        private string _valorUSD;
        private string _valorEUR;

        public string ValorUSD
        {
            get => _valorUSD;
            set {
                if (_valorUSD != value)
                {
                    _valorUSD = value;
                    OnPropertyChanged();
                    CambiarDeDolaresAEuros();
                }
            }
        }
        public string ValorEUR
        {
            get => _valorEUR;
            set
            {
                if (_valorEUR != value)
                {
                    _valorEUR = value;
                    OnPropertyChanged();
                    //CambiarDeEurosADolares();
                }
            }
        }
        public ICommand ComandoReiniciaValores { get; set; }

        public CambioDivisasViewModel()
        {
            ComandoReiniciaValores = new Command(async() => await ReiniciarValores());
        }
        public async Task ReiniciarValores()
        {
            ValorUSD = "0";
            ValorEUR = "0";
        }


        public void CambiarDeDolaresAEuros() {

            //Error
            double euros = Double.Parse(ValorUSD) * 0.87;
            _valorEUR = euros.ToString();
        }

        public void CambiarDeEurosADolares()
        {
            double dolares = Double.Parse(ValorEUR) * 1.15;
            _valorUSD = dolares.ToString();
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        
    }
}
