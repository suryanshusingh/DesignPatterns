using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    class SeniorManager : Approver
    {
        public override void ProcessBuyRequest(int price)
        {
            if (price > 25000)
            {
                Console.WriteLine("Cannot be approved by senior manager as request is above 25000!");
                Console.WriteLine("Forwarding the request to Director!!");
                supervisor.ProcessBuyRequest(price);
            }
            else Console.WriteLine("Request approved by Senior Manager");
        }
    }
}
