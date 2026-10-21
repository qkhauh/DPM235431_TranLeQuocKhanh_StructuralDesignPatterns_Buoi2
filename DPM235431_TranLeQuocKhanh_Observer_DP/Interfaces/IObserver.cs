using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235431_TranLeQuocKhanh_Observer_DP.Interfaces
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
