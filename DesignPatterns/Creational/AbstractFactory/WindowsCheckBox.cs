using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    class WindowsCheckBox : CheckBox
    {
        public WindowsCheckBox()
        {
            Console.WriteLine("Windows CheckBox Created!!");
        }
    }
}
