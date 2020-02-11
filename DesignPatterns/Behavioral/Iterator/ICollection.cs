using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Iterator
{
    public interface ICollection<T>
    {
        IIterator<T> CreateIterator();
    }
}
