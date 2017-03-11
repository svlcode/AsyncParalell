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

        private int _counter = 0;

        protected override void OnStart()
        {
            StartProgressBar();

            string elapsedSeconds = string.Empty;

            _counter++;
            lblCount.Text = $"Processes count :{_counter}";

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

                _counter--;
                lblCount.Text = $"Processes count :{_counter}";

                if (_counter == 0)
                    StopProgressBar();
            },
                TaskScheduler.FromCurrentSynchronizationContext()
            );
        }
    }
}
