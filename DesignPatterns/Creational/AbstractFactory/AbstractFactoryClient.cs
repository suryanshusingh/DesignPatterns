using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    class AbstractFactoryClient
    {
        public static void AbstractFactoryStartUp()
        {
            Console.WriteLine("Web or Windows, which controls you want?? 1. Web 2. Windows");

            int input = int.Parse(Console.ReadLine());

            IFactory factory;
            if (input == 1)
            {
                factory = new WebFactory();
            }
            else
            {
                factory = new WindowsFactory();
            }

            factory.CreateButtons();
            factory.CreateCheckBox();

            Console.Read();
        }
    }
}
