using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    interface IPublisher
    {
        void Subscribe(ISubscriber sub);
        void Unsubscribe(ISubscriber sub);
        void Notify(int price);
    }
}
