using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace yaci.Views.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnPorosity.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Porosity());
            };
            btnFlowRate.Clicked += (sender, e) =>
            {
                DisplayAlert("Noticia", "Aun no se ha habilitado esta opción", "Aceptar");
               // Navigation.PushAsync(new FlowRate());
            };
            btnActiveopt.Clicked += (sender, e) =>
            {
                btnPorosity.IsVisible = !btnPorosity.IsVisible ? true : false;
                btnFlowRate.IsVisible = !btnFlowRate.IsVisible ? true : false;
            };
        }
    }
}