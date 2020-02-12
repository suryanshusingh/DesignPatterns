using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template
{
    class TemplateClient
    {
        public static void TemplateDPStartup()
        {
            Bread brownBread = new BrownBread();
            brownBread.Make();

            Bread sandwich = new SandwichBread();
            sandwich.Make();

            Bread wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadKey();
        }
    }
}
