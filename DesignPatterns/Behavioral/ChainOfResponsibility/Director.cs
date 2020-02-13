using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    class Director : Approver
    {
        public override void ProcessBuyRequest(int price)
        {
            Console.WriteLine("Approved by director!!");
        }
    }
}
