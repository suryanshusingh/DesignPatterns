using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    class WindowsFactory : IFactory
    {
        public Button CreateButtons()
        {
            return new WindowsButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
