using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    public class MyService
    {
        private Listener _listener;
        private InternalDummyService _dummyService;
        private TaskCompletionSource<string> _taskCompletionSource;
        public event EventHandler<MyValueEventArgs> ValueUpdated;
        public event EventHandler<MyValueEventArgs> Error;

        private bool _currentPositionRequested;

        public MyService()
        {
            _listener = new Listener();
            _listener.OnValueUpdated += Listener_OnValueUpdated;
            _listener.OnError += Listener_OnError;
            _dummyService = new InternalDummyService();
        }

        private void Listener_OnError(object sender, MyValueEventArgs e)
        {
            this.Error?.Invoke(this, e);
            if (_taskCompletionSource != null && !_taskCompletionSource.Task.IsCompleted)
            {
                _taskCompletionSource.SetException(new Exception(e.Value));
                _taskCompletionSource = null;

                if (_currentPositionRequested)
                {
                    _currentPositionRequested = false;
                    _dummyService.Stop();
                    _dummyService.Unregister();
                }
            }
        }

        private void Listener_OnValueUpdated(object sender, MyValueEventArgs e)
        {
            this.ValueUpdated?.Invoke(this, e);

            if (_taskCompletionSource != null && !_taskCompletionSource.Task.IsCompleted)
            {
                _taskCompletionSource.SetResult(e.Value);
                _taskCompletionSource = null;

                if (_currentPositionRequested)
                {
                    _currentPositionRequested = false;
                    _dummyService.Stop();
                    _dummyService.Unregister();
                }
            }
        }

        public async Task<string> GetPositionAsync()
        {
            var task = GetPositionTaskAsync();
            if (task == await Task.WhenAny(task, Task.Delay(1000)))
                return await task;
            else
                throw new TimeoutException();
        }

        private Task<string> GetPositionTaskAsync()
        {
            if (_taskCompletionSource == null)
            {
                _taskCompletionSource = new TaskCompletionSource<string>();

                if (!_dummyService.IsRunning)
                {
                    _dummyService.Start();
                    _dummyService.Register(_listener);
                    _currentPositionRequested = true;
                }

            }
            return _taskCompletionSource.Task;
        }

        public void Start()
        {
            _dummyService.Start();
            _dummyService.Register(_listener);
        }

        public void Stop()
        {
            _dummyService.Stop();
        }
    }
}
