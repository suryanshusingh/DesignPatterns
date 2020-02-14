using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    class WebButton : Button
    {
        public WebButton()
        {
            Console.WriteLine("Web Button Created!!");
        }
    }
}
