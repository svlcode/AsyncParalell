using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    public class IndoorPositioning
    {

        public bool IsRunning { get; set; }
        private IListener _listener;
        private static Random _random = new Random();

        public IndoorPositioning()
        {

        }

        public void Start()
        {
            IsRunning = true;
            Task.Run(() =>
            {
                while (IsRunning)
                {
                    Thread.Sleep(350);
                    if (_listener != null)
                    {
                        _listener.DidUpdateLocation($"{_random.Next(1, 100)},{_random.Next(1, 100)}");
                    }
                }
            });
        }

        public void Register(IListener listener)
        {
            _listener = listener;

        }

        public void Unregister()
        {
            _listener = null;
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }
}
