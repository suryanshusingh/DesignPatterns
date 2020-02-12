using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    class NavigationMethod
    {
        private NavigationStrategy navigationStrategy;
        public void SetNavigationStrategy(NavigationStrategy navigationStrategy)
        {
            this.navigationStrategy = navigationStrategy;
        }

        public void StartNavigation()
        {
            navigationStrategy.Navigate();
        }
    }
}
