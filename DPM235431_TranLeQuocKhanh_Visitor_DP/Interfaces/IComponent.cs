using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235431_TranLeQuocKhanh_Visitor_DP.Interfaces
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
