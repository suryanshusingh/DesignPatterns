using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Iterator
{
    public class JellyBean
    {
        public string Flavor { get; }
        // Constructor
        public JellyBean(string flavor)
        {
            this.Flavor = flavor;
        }
    }
}
