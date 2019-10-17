using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    public interface IListener
    {
        void DidUpdateLocation(string location);
    }
}
