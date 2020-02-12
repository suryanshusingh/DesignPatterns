using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    class Subscriber : ISubscriber
    {
        private int notifyWhenPrice;
        public Subscriber(int notifyWhenPrice)
        {
            this.notifyWhenPrice = notifyWhenPrice;
        }
        public void Update(int stockPrice)
        {
            if (this.notifyWhenPrice < stockPrice)
                Console.WriteLine($"Sending Mail: StockPrice is more than you subscribed for {this.notifyWhenPrice}");
            else Console.WriteLine($"Mail not sent: StockPrice is less than you subscribed for {this.notifyWhenPrice}");
        }
    }
}
