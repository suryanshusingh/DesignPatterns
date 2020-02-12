using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    abstract class Component
    {
        protected IMediator mediator;
        public Component(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public abstract void OnClick();
        public abstract void OnMouseHover();
    }
}
