using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class AwaitAnyTaskForm : BaseListBoxProgressForm
    {
        public AwaitAnyTaskForm()
        {
            InitializeComponent();
        }

        protected override async Task OnStartAsync()
        {
            StartProgressBar();

            List<Task<int>> tasks = new List<Task<int>>();
            for (int i = 0; i < Number; i++)
            {
                var task = StartRandomTaskAsync(1000, 3000);
                listBoxResult.Items.Add($"Started task {task.Id}.");
                tasks.Add(task);
            }

            // awaits for any task to finish.
            var firstTask = await Task.WhenAny(tasks);


            listBoxResult.Items.Add($"First task({firstTask.Id}) finished in {firstTask.Result} milliseconds.");

            StopProgressBar();
        }
    }
}
