using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class AwaitAllTasksForm : BaseListBoxProgressForm
    {
        public AwaitAllTasksForm()
        {
            InitializeComponent();
        }

        protected override async Task OnStartAsync()
        {
            StartProgressBar();

            Stopwatch sw = Stopwatch.StartNew();
            var t1 = StartRandomTaskAsync(1000, 3000);
            var t2 = StartRandomTaskAsync(1000, 3000);
            var t3 = StartRandomTaskAsync(1000, 3000);

            await Task.WhenAll(t1, t2, t3);

            sw.Stop();
            listBoxResult.Items.Add($"task {t1.Id} finished in {t1.Result} milliseconds.");
            listBoxResult.Items.Add($"task {t2.Id} finished in {t2.Result} milliseconds.");
            listBoxResult.Items.Add($"task {t3.Id} finished in {t3.Result} milliseconds.");

            listBoxResult.Items.Add($"All tasks finished {sw.ElapsedMilliseconds} milliseconds.");

            StopProgressBar();
        }
    }
}
