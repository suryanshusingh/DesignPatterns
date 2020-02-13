using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    class Manager : Approver
    {
        public override void ProcessBuyRequest(int price)
        {
           if (price > 5000)
            {
                Console.WriteLine("Cannot be approved by manager as request is above 5000!");
                Console.WriteLine("Forwarding the request to Senior Manager!!");
                supervisor.ProcessBuyRequest(price);
            }               
            else Console.WriteLine("Request approved by Manager");
        }
    }
}
