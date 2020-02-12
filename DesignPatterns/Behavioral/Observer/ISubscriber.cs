using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    interface ISubscriber
    {
        void Update(int stockPrice);
    }
}
