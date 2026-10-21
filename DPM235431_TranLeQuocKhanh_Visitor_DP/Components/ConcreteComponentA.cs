using DPM235431_TranLeQuocKhanh_Visitor_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235431_TranLeQuocKhanh_Visitor_DP.Components
{
    public class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}
