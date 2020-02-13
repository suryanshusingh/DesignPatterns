using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    class CORClient
    {
        public static void CORStartup()
        {
            Approver manager = new Manager();
            Approver seniormanager = new SeniorManager();
            Approver director = new Director();

            manager.SetSupervisor(seniormanager);
            seniormanager.SetSupervisor(director);

            manager.ProcessBuyRequest(25001);

        }
    }
}
