using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    class MediatorClient
    {
        public static void MediatorDPStartUp()
        {
            var mediator = new ConcreteMediator();
            var loginbutton = new LoginButton(mediator);
            var registerbutton = new RegisterButton(mediator);
            var forgotbutton = new RegisterButton(mediator);

            loginbutton.OnClick();

            registerbutton.OnClick();

            Console.Read();
        }
    }
}
