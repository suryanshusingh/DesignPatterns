using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template
{
    class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking whole wheat bread!!");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Mixing ingredients for whole wheat bread");
        }
    }
}
