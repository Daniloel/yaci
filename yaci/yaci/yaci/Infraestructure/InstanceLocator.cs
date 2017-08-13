namespace yaci.Infraestructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ViewModels;

    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()//Constructor
        {
            Main = new MainViewModel();
        }
    }
}
