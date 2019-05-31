using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class UsingTaskCompletionSourceForm : BaseListBoxProgressForm
    {
        private List<Task> _tasks;

        public UsingTaskCompletionSourceForm()
        {
            InitializeComponent();
            _tasks = new List<Task>();
        }

        protected override async Task OnStartAsync()
        {
            if(_tasks.All(t => t.IsCompleted))
                StartProgressBar();

            var task = ExecuteTaskCompletionSource();

            listBoxResult.Items.Add($"Task {task.Id} started.");

            _tasks.Add(task);

            var result = await task;

            listBoxResult.Items.Add($"Task {task.Id} completed in {result} milliseconds.");

            if (_tasks.All(t => t.IsCompleted))
                StopProgressBar();
        }


        /// <summary>
        /// Start a task which simulates an asynchronous operation
        /// </summary>
        /// <returns></returns>
        private Task<string> ExecuteTaskCompletionSource()
        {
            var tcs = new TaskCompletionSource<string>();
            var firstTask = StartRandomTaskAsync(1000, 5000);
            // As soon as firstTask is finished it will trigger a second task, called fireAndForget, which will set the result of the
            // TaskCompletionSource, which acts as a notification when an asynchronous operation has completed.
            var fireAndForget = firstTask.ContinueWith(a => tcs.SetResult(a.Result.ToString()));
            return tcs.Task;
        }
    }
}
