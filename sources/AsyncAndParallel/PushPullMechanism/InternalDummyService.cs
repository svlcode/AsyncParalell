using System;
using System.Threading;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    internal class InternalDummyService
    {
        public bool IsRunning { get; set; }
        private IListener _listener;
        private static Random _random = new Random();

        public void Start()
        {
            IsRunning = true;
            Task.Run(() =>
            {
                while (IsRunning)
                {
                    var timeBetweenEvents = _random.Next(500, 3500);
                    //var timeBetweenEvents = 2200;
                    Thread.Sleep(timeBetweenEvents);
                    if (_listener != null)
                    {
                        _listener.FireValueUpdate($"{timeBetweenEvents}");
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
