using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.Tasks
{
    // Use ConfigureAwait(false) only general purpose libraries 
    // Do not use it UI contexts
    public partial class ConfigureAwaitForm : AsyncAndParallel.Forms.BaseForms.BaseAsyncForm
    {
        public ConfigureAwaitForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TestAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private async Task TestAsync()
        {
            lblThread.Text = Thread.CurrentThread.ManagedThreadId.ToString();
            var restult = await StartRandomTaskAsync(1000, 3000).ConfigureAwait(false);

            // bad practice throws exception
            /*
             * System.InvalidOperationException: 'Cross-thread operation not valid: 
             * Control 'lblThread' accessed from a thread other than the thread it was created on.'
             */
            lblThread.Text = Thread.CurrentThread.ManagedThreadId.ToString();
            lblResult.Text = restult.ToString();
        }


        private async Task TestDelay1()
        {
            var taskId = Thread.CurrentThread.ManagedThreadId;
            await Task.Delay(50).ConfigureAwait(false);
            taskId = Thread.CurrentThread.ManagedThreadId;
            await TestDelay2();
            taskId = Thread.CurrentThread.ManagedThreadId;
        }

        private async Task TestDelay2()
        {
            var taskId = Thread.CurrentThread.ManagedThreadId;
            await Task.Delay(50);
            taskId = Thread.CurrentThread.ManagedThreadId;
        }
    }
}
