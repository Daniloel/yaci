using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yaci
{
    using Xamarin.Forms;
    using Views;
    public partial class App : Application
	{
		public App ()
        {
            
			MainPage = new yaci.Views.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
