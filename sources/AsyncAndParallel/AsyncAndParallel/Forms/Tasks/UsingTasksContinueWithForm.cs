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

        int _taskCounter = 0;

        protected override void OnStart()
        {
            if(_taskCounter == 0)
                StartProgressBar();

            // This is a shared variable used by both tasks. This could be a potential conflict. 
            // However, since the second task will execute after the first one finishes, the race condition will not occur.
            
            Task<string> worker = Task.Run(() =>
            {
                _taskCounter++;
                Stopwatch sw = Stopwatch.StartNew();

                TimeConsumingTask();

                sw.Stop();
                return $"{sw.ElapsedMilliseconds / 1000.0:#,##0.00}";
            });

            // Update the UI as soon as the worker task is completed. In this case the continuation task will run on the UI thread.
            Task secondTask = worker.ContinueWith(a =>
            {
                _taskCounter--;
                listBoxResult.Items.Add($"task {a.Id} finished in [{a.Result} secs]");
                if(_taskCounter == 0)
                    StopProgressBar();
            },
                TaskScheduler.FromCurrentSynchronizationContext()
            );
        }
    }
}
