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
        public event EventHandler<MyErrorEventArgs> OnError;

        public void FireError(string message)
        {
            OnError?.Invoke(this, new MyErrorEventArgs(message));
        }

        public void FireValueUpdate(int value)
        {
            OnValueUpdated?.Invoke(this, new MyValueEventArgs(value));
        }
    }
}
