using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    class Publisher : IPublisher
    {
        List<ISubscriber> subscribers = new List<ISubscriber>();
        public void Notify(int price)
        {
            foreach (var sub in subscribers)
            {
                sub.Update(price);
            }
        }

        public void Subscribe(ISubscriber sub)
        {
            subscribers.Add(sub);
        }

        public void Unsubscribe(ISubscriber sub)
        {
            subscribers.Remove(sub);
        }

        public void CurrentStockPrice(int price)
        {
            Notify(price);
        }
    }
}
