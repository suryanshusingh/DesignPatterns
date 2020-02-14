using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    interface IFactory
    {
        Button CreateButtons();
        CheckBox CreateCheckBox();
    }
}
