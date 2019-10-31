using System;
using System.Threading.Tasks;

namespace PushPullMechanism
{
    public class MyService
    {
        private Listener _listener;
        private InternalDummyService _dummyService;
        private TaskCompletionSource<int> _taskCompletionSource;
        public event EventHandler<MyValueEventArgs> ValueUpdated;
        public event EventHandler<MyErrorEventArgs> Error;

        private bool _currentPositionRequested;

        public MyService()
        {
            _listener = new Listener();
            _listener.OnValueUpdated += Listener_OnValueUpdated;
            _listener.OnError += Listener_OnError;
            _dummyService = new InternalDummyService();
        }

        private void Listener_OnError(object sender, MyErrorEventArgs e)
        {
            this.Error?.Invoke(this, e);
            if (_taskCompletionSource != null && !_taskCompletionSource.Task.IsCompleted)
            {
                _taskCompletionSource.SetException(new Exception(e.Message));
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

            if (IsPrimeNumber(e.Value))
            {
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
        }

        private bool IsPrimeNumber(int value)
        {
            for (int i = 2; i <= value/2; i++)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }

        public async Task<int> GetValueOnDemandAsync(int timeout)
        {
            var task = GetPositionTaskAsync();
            if (task == await Task.WhenAny(task, Task.Delay(timeout)))
                return await task;
            else
            {
                throw new TimeoutException();
            }
        }

        private Task<int> GetPositionTaskAsync()
        {
            if (_taskCompletionSource == null)
            {
                _taskCompletionSource = new TaskCompletionSource<int>();

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
