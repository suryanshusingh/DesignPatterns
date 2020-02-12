using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    class StrategyClient
    {
        public static void StrategyDPStartup()
        {
            var navigate = new NavigationMethod();
            Console.WriteLine("Which vehicle you are using?");
            Console.WriteLine("1.Car");
            Console.WriteLine("2.Bike");
            Console.WriteLine("3.Walk");
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1:
                    navigate.SetNavigationStrategy(new DriveNavigation());
                    navigate.StartNavigation();
                    break;
                case 2:
                    navigate.SetNavigationStrategy(new RideNavigation());
                    navigate.StartNavigation();
                    break;
                case 3:
                    navigate.SetNavigationStrategy(new WalkNavigation());
                    navigate.StartNavigation();
                    break;
            }
            Console.Read();
        }
    }
}
