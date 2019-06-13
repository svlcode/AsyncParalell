using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class LongRunningOperationsForm : BaseListBoxProgressForm
    {
        public LongRunningOperationsForm()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            for (int i = 0; i < Number; i++)
            {
                Task.Factory.StartNew((arg) =>
                {
                    int taskId = (int)arg;
                    AddLine($"started task: {taskId}");

                    var sw = Stopwatch.StartNew();
                    long count = 0;

                    while (sw.ElapsedMilliseconds < 5 * 60 * 1000)
                    {
                        count++;
                        if (count == 1_000_000_000)
                            count = 0;
                    }
                    AddLine($"task: {taskId} finished.");
                }, i, TaskCreationOptions.LongRunning);
            }
        }

        private void AddLine(string text)
        {
            this.listBoxResult.Invoke(new Action(() => { this.listBoxResult.Items.Add(text); }));
        }
    }
}
