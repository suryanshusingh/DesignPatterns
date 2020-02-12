using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    class WalkNavigation : NavigationStrategy
    {
        public override void Navigate()
        {
            Console.WriteLine("Finding the best route to Walk.");
        }
    }
}
