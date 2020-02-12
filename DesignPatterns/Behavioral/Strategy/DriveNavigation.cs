using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    class DriveNavigation : NavigationStrategy
    {
        public override void Navigate()
        {
            Console.WriteLine("Finding the best route to Drive.");
        }
    }
}
