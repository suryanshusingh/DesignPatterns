using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    class ObserverClient
    {
        public static void ObserverDPStartup()
        {
            Publisher publisher = new Publisher();
            ISubscriber sub1 = new Subscriber(12);
            ISubscriber sub2 = new Subscriber(18);
            ISubscriber sub3 = new Subscriber(35);
            publisher.Subscribe(sub1);
            publisher.Subscribe(sub2);
            publisher.Subscribe(sub3);

            publisher.CurrentStockPrice(10);
            publisher.CurrentStockPrice(15);
            publisher.CurrentStockPrice(20);

            publisher.Unsubscribe(sub2);
            publisher.Unsubscribe(sub1);
            publisher.CurrentStockPrice(40);

            Console.ReadKey();

        }
    }
}
