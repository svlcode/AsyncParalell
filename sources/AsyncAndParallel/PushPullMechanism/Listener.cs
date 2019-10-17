using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    public class Listener : IListener
    {
        public event EventHandler<PositionEventArgs> OnPositionUpdated;

        //public event EventHandler<PositionEventArgs> OnDemandPositionUpdated;

        //public bool IsOnDemandPositionRequired { get; set; }

        public void DidUpdateLocation(string location)
        {
            // calculate position ....
            var position = location;

            //if(IsOnDemandPositionRequired)
            //{
            //    OnDemandPositionUpdated?.Invoke(this, new PositionEventArgs(position));
            //}
            OnPositionUpdated?.Invoke(this, new PositionEventArgs(position));
        }
    }
}
