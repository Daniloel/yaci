namespace yaci.Infraestructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ViewModels;

    public class InstanceLocator
    {
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        public MainViewModel Main { get; set; }


    }
}
