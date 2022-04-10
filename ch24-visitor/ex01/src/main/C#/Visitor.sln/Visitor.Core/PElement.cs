using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Core
{
    public class PElement : HTMLElement
    {
        public PElement(): base("p")
        {
        }

        public void accept(AbstractVisitor visitor)
        {
            visitChildren(visitor);
            visitor.VisitPElement(this);
        }
    }
}
