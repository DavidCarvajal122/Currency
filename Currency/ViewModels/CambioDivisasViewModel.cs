using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
                }
            }
        }

        public void CambiarDeDolaresAEuros { 

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        
    }
}
