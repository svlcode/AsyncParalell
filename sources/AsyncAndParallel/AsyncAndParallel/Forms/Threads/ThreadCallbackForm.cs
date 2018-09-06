using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.Threads
{
    public partial class ThreadCallbackForm : DownloadPdfForm
    {
        public ThreadCallbackForm()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            btnStart.Enabled = false;

            ThreadStart threadStart = new ThreadStart(StartDownload);
            threadStart += () =>
            {
                
                MessageBox.Show("Download finished");
            };

            Thread thread = new Thread(threadStart) { IsBackground = true };
            thread.Start();
            thread.Join();
            btnStart.Enabled = true;

        }
    }
}
