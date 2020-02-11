using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template
{
    class SandwichBread : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking Sandwich bread!!");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mixing ingredients for sandwich bread");
        }
    }
}
