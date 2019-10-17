using System;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class BasicAsyncForm : BaseListBoxProgressForm
    {
        public BasicAsyncForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// the number of tasks running.
        /// </summary>
        int _taskCounter = 0;

        protected override async Task OnStartAsync()
        {
            if(_taskCounter == 0)
                StartProgressBar();

            _taskCounter++;

            var task = StartRandomTaskAsync(1000, 3500);
            var timeExecuted = await task;

            _taskCounter--;

            listBoxResult.Items.Add($"task {task.Id} finished in [{timeExecuted}] milliseconds.");

            if (_taskCounter == 0)
                StopProgressBar();
        }
    }
}
