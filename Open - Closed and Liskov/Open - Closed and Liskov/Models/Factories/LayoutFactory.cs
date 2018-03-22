using System;
using System.Collections.Generic;
using System.Text;
using Open___Closed_and_Liskov.Models.Contracts;

namespace Open___Closed_and_Liskov.Models.Factories
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutType)
        {
            ILayout layout = null;
            switch (layoutType)
            {
                case "SimpleLayout":
                    layout=new SimpleLayout();
                    break;
                case "XmlLayout":
                    layout=new XmlLayout();
                    break;
                default: throw new ArgumentException("Invalid Layout Type!");
            }
            return layout;
        }
    }
}
