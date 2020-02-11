using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Iterator
{
    class JellyBeanCollection : ICollection<JellyBean>
    {
        private List<JellyBean> items = new List<JellyBean>();
        public int Count { get { return items.Count; } }
        public IIterator<JellyBean> CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        public JellyBean this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }

    }
}
