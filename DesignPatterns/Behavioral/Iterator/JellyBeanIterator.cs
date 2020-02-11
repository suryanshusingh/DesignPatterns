using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Iterator
{
    class JellyBeanIterator : IIterator<JellyBean>
    {
        private JellyBeanCollection jellyBeans;
        private int current = 0;

        // Constructor
        public JellyBeanIterator(JellyBeanCollection jellyBeans)
        {
            this.jellyBeans = jellyBeans;
        }

        public JellyBean CurrentElement
        {
            get
            {
                return jellyBeans[current];
            }
        }

        public JellyBean First()
        {
            return jellyBeans[0];
        }

        public JellyBean Next()
        {
            current++;
            if (current >= jellyBeans.Count)
                return null;
            
            return jellyBeans[current];
        }

        public bool IsDone
        {
            get { return current >= jellyBeans.Count; }
        }

    }
}
