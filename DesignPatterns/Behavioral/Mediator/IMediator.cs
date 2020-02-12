using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    interface IMediator
    {
        void Notify(Component component, string typeofEvent);
    }
}
