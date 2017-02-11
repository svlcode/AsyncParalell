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

namespace AsyncAndParallel.Forms
{
    public partial class AbortThreadForm : DownloadPdfForm
    {
        public AbortThreadForm()
        {
            InitializeComponent();
            Closing += AbortThreadForm_Closing;
        }

        Thread _thread;

        protected override void OnStart()
        {
            //Solution1:
            //_thread = new Thread(TimeConsumingTask) {IsBackground = true};

            //Solution2: there is a problem when more threads are created
            _thread = new Thread(TimeConsumingTask);
            _thread.Start();
        }

        private void AbortThreadForm_Closing(object sender, CancelEventArgs e)
        {
            //there is a problem when more threads are created
            if (_thread != null)
            {
                _thread.Abort();
            }
        }

    }
}
