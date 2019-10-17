using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    public class MyValueEventArgs : EventArgs
    {
        public string Value { get; private set; }

        public MyValueEventArgs(string position)
        {
            this.Value = position;
        }
    }
}
