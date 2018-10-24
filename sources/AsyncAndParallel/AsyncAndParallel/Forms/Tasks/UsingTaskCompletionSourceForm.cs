using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(AllTasksCompleted())
                StartProgressBar();

            var task = ExecuteTaskCompletionSource();

            listBoxResult.Items.Add($"Task {task.Id} started.");

            _tasks.Add(task);

            var result = await task;

            listBoxResult.Items.Add($"Task {task.Id} completed in {result} milliseconds.");

            if (AllTasksCompleted())
                StopProgressBar();
        }

        private bool AllTasksCompleted()
        {
            return _tasks.All(t => t.IsCompleted);
        }

        private Task<string> ExecuteTaskCompletionSource()
        {
            var tcs = new TaskCompletionSource<string>();

            var rndTime = new Random(DateTime.Now.Millisecond).Next(1000, 5000);
            var fireAndForget = Task.Delay(rndTime).ContinueWith(a => tcs.SetResult(rndTime.ToString()));

            return tcs.Task;
        }
    }
}
