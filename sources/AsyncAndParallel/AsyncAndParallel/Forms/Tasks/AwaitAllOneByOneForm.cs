using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class AwaitAllOneByOneForm : BaseListBoxProgressForm
    {
        public AwaitAllOneByOneForm()
        {
            InitializeComponent();
        }

        protected override async Task OnStartAsync()
        {
            StartProgressBar();

            List<Task<int>> tasks = new List<Task<int>>();
            for (int i = 0; i < Number; i++)
            {
                var task = StartRandomTaskAsync(1000, 6000);
                listBoxResult.Items.Add($"Started task {task.Id}.");
                tasks.Add(task);
            }

            while (tasks.Count > 0)
            {
                // awaits for any task to finish.
                var task = await Task.WhenAny(tasks);
                listBoxResult.Items.Add($"Task({task.Id}) finished in {task.Result} milliseconds.");
                tasks.Remove(task);
            }

            StopProgressBar();
        }
    }
}
