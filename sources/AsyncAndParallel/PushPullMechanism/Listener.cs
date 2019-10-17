using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    internal class Listener : IListener
    {
        public event EventHandler<MyValueEventArgs> OnValueUpdated;

        //public event EventHandler<PositionEventArgs> OnDemandPositionUpdated;

        //public bool IsOnDemandPositionRequired { get; set; }

        public void FireValueUpdate(string location)
        {
            // calculate position ....
            var position = location;

            //if(IsOnDemandPositionRequired)
            //{
            //    OnDemandPositionUpdated?.Invoke(this, new PositionEventArgs(position));
            //}
            OnValueUpdated?.Invoke(this, new MyValueEventArgs(position));
        }
    }
}
