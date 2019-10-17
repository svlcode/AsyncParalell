using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    public class PositionEventArgs : EventArgs
    {
        public string Position { get; private set; }

        public PositionEventArgs(string position)
        {
            this.Position = position;
        }
    }
}
