using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel
{
    public partial class UsingTasksContinueWithForm : BaseListBoxProgressForm
    {
        public UsingTasksContinueWithForm()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            StartProgressBar();

            string elapsedSeconds = string.Empty;

            Task worker = Task.Factory.StartNew(() =>
            {
                Stopwatch sw = Stopwatch.StartNew();

                TimeConsumingTask();

                sw.Stop();
                elapsedSeconds = $"{sw.ElapsedMilliseconds / 1000.0:#,##0.00}";
            });

            worker.ContinueWith(a =>
            {
                listBoxResult.Items.Add($"task {a.Id} finished in [{elapsedSeconds} secs]");
                StopProgressBar();
            },
                TaskScheduler.FromCurrentSynchronizationContext()
            );
        }
    }
}
