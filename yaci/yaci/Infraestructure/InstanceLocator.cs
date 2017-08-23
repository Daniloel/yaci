namespace yaci.Infraestructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ViewModels;

    public class InstanceLocator
    {
        public PorosityViewModel Porosity { get; set; }
        //public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Porosity = new PorosityViewModel();
          //  Main = new MainViewModel();
        }
    }
}