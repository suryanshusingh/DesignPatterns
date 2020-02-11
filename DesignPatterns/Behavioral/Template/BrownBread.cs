using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template
{
    class BrownBread : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking brown bread!!");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mixing ingredients for brown bread");
        }
    }
}
