using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    class WindowsButton : IButton
    {
        public WindowsButton()
        {
            Console.WriteLine("Windows button created!!");
        }
    }
}
