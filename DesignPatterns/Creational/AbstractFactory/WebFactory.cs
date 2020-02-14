using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    class WebFactory : IFactory
    {
        public Button CreateButtons()
        {
            return new WebButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new WebCheckBox();
        }
    }
}
