using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    class WebCreator : Creator
    {
        public override IButton CreateButton()
        {
            return new WebButton();
        }
    }
}
