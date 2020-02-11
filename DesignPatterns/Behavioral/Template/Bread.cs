using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template
{
    abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();
        public virtual void Slice()
        {
            Console.WriteLine($"Slicing Completed for {this.GetType().Name}!!");
        }
        //The template method
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }
}
