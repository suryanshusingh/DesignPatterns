using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    class WebButton : IButton
    {
        public WebButton()
        {
            Console.WriteLine("Web button created.!!");
        }
    }
}
