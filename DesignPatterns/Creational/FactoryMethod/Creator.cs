using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    abstract class Creator
    {
        public abstract IButton CreateButton();
    }
}
 