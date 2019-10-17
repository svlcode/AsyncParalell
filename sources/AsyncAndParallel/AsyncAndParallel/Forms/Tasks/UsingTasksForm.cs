using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.DownloadPDF
{
    public partial class UsingTasksForm : DownloadPdfForm
    {
        public UsingTasksForm()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            btnStart.Enabled = false;

            Task task = new Task(StartDownload);

            // Starts another task on the UI thread as soon as the previous task finishes.
            // This is done due to the fact that no other thread than the UI thread is allowed to update the UI (controls properties).
            task.ContinueWith((antecedent) =>
            {
                btnStart.Enabled = true;
            },
            TaskScheduler.FromCurrentSynchronizationContext());

            task.Start();
        }
    }
}
