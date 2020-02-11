using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator<T>
    {
        T First();
        T Next();
        T CurrentElement { get; }
        bool IsDone { get; }
    }
}
