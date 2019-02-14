using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class ContinueWhenAllForm : BaseListBoxProgressForm
    {
        public ContinueWhenAllForm()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            StartProgressBar();

            Stopwatch sw = Stopwatch.StartNew();
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < Number; i++)
            {
                var task = StartRandomTaskAsync(1000, 3000);
                listBoxResult.Items.Add($"Started task {task.Id}.");
                tasks.Add(task);
            }

            // this triggers a 'cross-thread' exception
            Task.Factory.ContinueWhenAll(tasks.ToArray(), (setOftasks) =>
            {
                sw.Stop();
                string taskIds = "";
                setOftasks.ToList().ForEach((t) => taskIds += t.Id + " ");

                listBoxResult.Items.Add($"All tasks ({taskIds}) finished in {sw.ElapsedMilliseconds} milliseconds.");

                StopProgressBar();
            });
        }
    }
}
