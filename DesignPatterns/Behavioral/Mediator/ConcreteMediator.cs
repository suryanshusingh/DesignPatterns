using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    class ConcreteMediator : IMediator
    {
        public void Notify(Component component, string typeofEvent)
        {
            if (component is LoginButton && typeofEvent == "Click")
            {
                Console.WriteLine("Trying to login");
                Console.WriteLine("Hiding registration form");
                Console.WriteLine("Hiding forgot password button");
            }
            else if (component is RegisterButton && typeofEvent == "Click")
            {
                Console.WriteLine("SHowing registration form");
                Console.WriteLine("Hiding login form");
                Console.WriteLine("Hiding forgot password button");
            }
        }
    }
}
