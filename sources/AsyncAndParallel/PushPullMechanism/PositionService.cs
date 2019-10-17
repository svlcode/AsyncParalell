using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    public class PositionService
    {
        private Listener _listener;
        private IndoorPositioning _indoorPositioning;
        private TaskCompletionSource<string> _taskCompletionSource;
        public event EventHandler<PositionEventArgs> PositionUpdated;

        private bool _currentPositionRequested;

        public PositionService()
        {
            _listener = new Listener();
            _listener.OnPositionUpdated += Listener_OnPositionUpdated;
            //_listener.OnDemandPositionUpdated += Listener_OnDemandPositionUpdated;
            _indoorPositioning = new IndoorPositioning();
        }

        //private void Listener_OnDemandPositionUpdated(object sender, PositionEventArgs e)
        //{
        //    if (_taskCompletionSource != null && !_taskCompletionSource.Task.IsCompleted)
        //    {
        //        _taskCompletionSource.SetResult(e.Position);

        //    }
        //}

        private void Listener_OnPositionUpdated(object sender, PositionEventArgs e)
        {
            this.PositionUpdated?.Invoke(this, e);

            if (_taskCompletionSource != null && !_taskCompletionSource.Task.IsCompleted)
            {
                _taskCompletionSource.SetResult(e.Position);
                _taskCompletionSource = null;

                if (_currentPositionRequested)
                {
                    _currentPositionRequested = false;
                    _indoorPositioning.Stop();
                    _indoorPositioning.Unregister();
                }
            }
        }

        public async Task<string> GetPositionAsync()
        {
            _taskCompletionSource = new TaskCompletionSource<string>();

            if (!_indoorPositioning.IsRunning)
            {
                _indoorPositioning.Start();
                _indoorPositioning.Register(_listener);
                _currentPositionRequested = true;
            }

            return await _taskCompletionSource.Task;
        }

        public void Start()
        {
            _indoorPositioning.Start();
            _indoorPositioning.Register(_listener);
        }

        public void Stop()
        {
            _indoorPositioning.Stop();
        }
    }
}
