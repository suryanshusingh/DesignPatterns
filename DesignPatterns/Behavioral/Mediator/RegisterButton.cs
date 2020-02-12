using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    class RegisterButton : Component
    {
        public RegisterButton(IMediator mediator) : base(mediator)
        {

        }
        public override void OnClick()
        {
            this.mediator.Notify(this, "Click");
        }

        public override void OnMouseHover()
        {
            throw new NotImplementedException();
        }
    }
}
