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

namespace AsyncAndParallel
{
    public partial class JoinThreadForm : DownloadPdfForm
    {
        public JoinThreadForm()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            btnStart.Enabled = false;

            Thread thread = new Thread(StartDownload) {IsBackground = true};
            thread.Start();
            thread.Join();

            btnStart.Enabled = true;
        }
    }
}
