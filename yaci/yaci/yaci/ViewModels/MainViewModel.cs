using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace yaci.ViewModels
{
    public class MainViewModel
    {
        #region Properties

        public string Vol_poros { get; set; }
        public string Vol_matriz { get; set; }
        public string Porosidad { get; set; }

        #endregion

        #region Constructores
        public MainViewModel()
        {
        }
        #endregion

        #region Commands
        public ICommand CalcularCommand
        {
            get { return new RelayCommand(Calcular); }

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

            var porosity = volmatriz - volporal / volmatriz;
            Porosidad = string.Format("{0:C2}", porosity);


        }
        #endregion

    }
}
