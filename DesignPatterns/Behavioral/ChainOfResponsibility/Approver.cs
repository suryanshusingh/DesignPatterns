using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    abstract class Approver
    {
        protected Approver supervisor;
        
        public void SetSupervisor(Approver supervisor)
        {
            this.supervisor = supervisor;
        }
        public abstract void ProcessBuyRequest(int price);
    }
}
