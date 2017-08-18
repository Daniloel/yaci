using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace yaci.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Properties
        public string Vol_poros { get; set; }
        public string Vol_matriz { get; set; }
        string porosity;
        public string Porosity
        {
            get
            {
                return porosity;
            }
            set
            {
                if (porosity != value)
                {
                        porosity = value;
                        PropertyChanged?.Invoke(
                            this,
                            new PropertyChangedEventArgs(nameof(Porosity)));
                    }
                }
            
        
    }

        #endregion

        #region Constructores
        public MainViewModel()
        {
        }
        #endregion

        #region Commands
        public ICommand CalcularCommand
        {
            get { return new RelayCommand(execute: Calcular); }

        }

        async void Calcular()
        {
            
             if (string.IsNullOrEmpty((Vol_poros)) || string.IsNullOrEmpty((Vol_matriz)))
             {
                 await Application.Current.MainPage.DisplayAlert("Error", "Debes ingresar un valor", "Aceptar");
                 return;
             }

             decimal volporal = 0;
             if (!decimal.TryParse(Vol_poros, out volporal)){
                 await Application.Current.MainPage.DisplayAlert("Error", "Debes ingresar un valor numerico en volumen de poros", "Aceptar");
                 return;
             }
             decimal volmatriz = 0;
             if (!decimal.TryParse(Vol_matriz, out volmatriz)){
                 await Application.Current.MainPage.DisplayAlert("Error", "Debes ingresar un valor numerico en volumen de matriz", "Aceptar");
                 return;
             }



            var Calc_porosity = ((volmatriz - volporal) / volmatriz);
            Porosity = string.Format("{0:C2}", Calc_porosity);
            await Application.Current.MainPage.DisplayAlert("Atencion", "La porosidad es de "+Porosity, "Aceptar");


        }
        #endregion

    }
}
