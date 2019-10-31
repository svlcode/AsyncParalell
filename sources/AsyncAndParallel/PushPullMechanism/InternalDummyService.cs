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
                    var timeBetweenEvents = _random.Next(500, 1500);
                    //var error = _random.Next(1, 4) % 3 == 0;
                    var error = false;
                    if (error)
                    {
                        if (_listener != null)
                            _listener.FireError("Custom Error");
                    }
                    else
                    {
                        Thread.Sleep(timeBetweenEvents);
                        if (_listener != null)
                        {
                            _listener.FireValueUpdate(timeBetweenEvents);
                        }
                    }
                    
                }
            });
        }

        private void Run()
        {
            var timeBetweenEvents = _random.Next(500, 1500);
            Task.Delay(timeBetweenEvents).ContinueWith((task) =>
            {
                if (_listener != null)
                {
                    _listener.FireValueUpdate(timeBetweenEvents);
                }
                Run();
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
