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
        Thread _thread;

        public AbortThreadForm()
        {
            InitializeComponent();
            Closing += AbortThreadForm_Closing;
        }

        /// <summary>
        /// Unlike a Forground thread, a Background thread will not impose restrictions to the process which needs terminate.
        /// Therefore, the process will terminate without waiting for the Background thread to complete.
        /// </summary>
        protected override void OnStart()
        {
            // Creates a Foreground thread (the default value of IsBackground is false).
            _thread = new Thread(()=>
            {
                Thread.Sleep(10000);
            });
            
            // Sets the a flag which indicates that this is a Background thread.
            //_thread.IsBackground = true;

            _thread.Start();
        }

        /// <summary>
        /// In case multiple threads are created, this will terminte only the last created thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AbortThreadForm_Closing(object sender, CancelEventArgs e)
        {
            if (_thread != null)
            {
                _thread.Abort();
            }
        }

    }
}
