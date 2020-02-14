using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    class WindowsCreator : Creator
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
