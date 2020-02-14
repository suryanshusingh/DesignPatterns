using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    class FactoryClient
    {
        public static void FactoryDPStartup()
        {
            Console.WriteLine("Web or Windows, which button you want?? 1. Web 2. Windows");

            int input = int.Parse(Console.ReadLine());

            Creator creator;
            if (input == 1)
            {
                creator = new WebCreator();
            }
            else
            {
                creator = new WindowsCreator();
            }
            creator.CreateButton();
            Console.Read();
        }
    }
}
