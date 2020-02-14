using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    class WindowsButton : Button
    {
        public WindowsButton()
        {
            Console.WriteLine("Windows Button Created!!");

        }
    }
}
