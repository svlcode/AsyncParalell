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

            task.ContinueWith((antecedent) =>
            {
                btnStart.Enabled = true;

            },
                TaskScheduler.FromCurrentSynchronizationContext());

            task.Start();
        }
    }
}
