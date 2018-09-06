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

        int _taskCounter = 0;

        protected override async Task OnStartAsync()
        {
            if(_taskCounter == 0)
                StartProgressBar();

            var task = StartRandomTaskAsync();

            var timeExecuted = await task;
           
            listBoxResult.Items.Add($"task {task.Id} finished in [{timeExecuted}] milliseconds.");

            if (_taskCounter == 0)
                StopProgressBar();
        }

        private async Task<int> StartRandomTaskAsync()
        {
            try
            {
                _taskCounter++;

                var randomMiliseconds = new Random(DateTime.Now.Millisecond).Next(1000, 3500);
                await Task.Delay(randomMiliseconds);
                return randomMiliseconds;
            }
            finally
            {
                _taskCounter--;
            }
        }
    }
}
