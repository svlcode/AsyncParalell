using System;
using System.Threading;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.Threads
{
    public partial class BackgroundForegroundThreadsForm : Form
    {
        Thread _currentThread;


        public BackgroundForegroundThreadsForm()
        {
            InitializeComponent();
        }


        /// Creates a Foreground thread (the default value of IsBackground is false).
        private void btnStartForegroundThread_Click(object sender, EventArgs e)
        {
            if (_currentThread == null || !_currentThread.IsAlive)
            {
                _currentThread = new Thread(() =>
                {
                    Thread.Sleep(10000);
                });
                _currentThread.Start();
            }
        }

        /// Unlike a Forground thread, a Background thread will not impose restrictions to the process which needs terminate.
        /// Therefore, the process will terminate without waiting for the Background thread to complete. 
        private void btnStartBackgroundThread_Click(object sender, EventArgs e)
        {
            if (_currentThread == null || !_currentThread.IsAlive)
            {
                _currentThread = new Thread(() =>
                {
                    Thread.Sleep(10000);
                });
                _currentThread.IsBackground = true;
                _currentThread.Start();
            }
        }

        private void btnAbortCurrentThread_Click(object sender, EventArgs e)
        {
            if(_currentThread != null)
            {
                _currentThread.Abort();
            }
        }
    }
}
