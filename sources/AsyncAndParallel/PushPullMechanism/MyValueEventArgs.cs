using System;

namespace PushPullMechanism
{
    public class MyValueEventArgs : EventArgs
    {
        public int Value { get; private set; }

        public MyValueEventArgs(int value)
        {
            this.Value = value;
        }
    }
}
