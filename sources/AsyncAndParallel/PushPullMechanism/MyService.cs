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
        private CancellationTokenSource _cts;

        public event EventHandler<MyValueEventArgs> ValueUpdated;

        private bool _currentPositionRequested;

        public MyService()
        {
            _listener = new Listener();
            _listener.OnValueUpdated += Listener_OnValueUpdated;
            _dummyService = new InternalDummyService();
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
            if (_taskCompletionSource == null)
            {
                _taskCompletionSource = new TaskCompletionSource<string>();
                _cts = new CancellationTokenSource();
                const int timeoutMs = 2000;
                _cts.CancelAfter(timeoutMs); // timeout after 2 seconds.
                _cts.Token.Register(() =>
                {
                    _cts.Dispose();
                    if (_taskCompletionSource != null && !_taskCompletionSource.Task.IsCompleted)
                    {
                        _taskCompletionSource.SetException(new Exception("Timeout error."));
                        _taskCompletionSource = null;
                        if (_currentPositionRequested)
                        {
                            _currentPositionRequested = false;
                            _dummyService.Stop();
                            _dummyService.Unregister();
                        }
                    }
                }
                , useSynchronizationContext: false);

                if (!_dummyService.IsRunning)
                {
                    _dummyService.Start();
                    _dummyService.Register(_listener);
                    _currentPositionRequested = true;
                }

            }
            return await _taskCompletionSource.Task;
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
