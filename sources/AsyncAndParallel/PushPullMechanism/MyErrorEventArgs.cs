using System;

namespace PushPullMechanism
{
    public class MyErrorEventArgs : EventArgs 
    {
        public string Message { get; }
        public MyErrorEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
