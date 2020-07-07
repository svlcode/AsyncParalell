using AsyncAndParallel.Forms.BaseForms;
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

namespace AsyncAndParallel.Forms.UpdateUI
{
    public partial class ResponsiveUpdateForm : BaseAsyncForm
    {
        private readonly SynchronizationContext _synchronizationContext;
        private DateTime previousTime = DateTime.Now;

        public ResponsiveUpdateForm()
        {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;
        }

        private async void btnStartAsync_Click(object sender, EventArgs e)
        {
            btnStartAsync.Enabled = false;
            var count = 0;

            await Task.Run(() =>
            {
                for (var i = 0; i <= 5_000_000; i++)
                {
                    UpdateUI(i);
                    count = i;
                }
            });

            label1.Text = @"Counter " + count;
            btnStartAsync.Enabled = true;
        }

        public void UpdateUI(int value)
        {
            var timeNow = DateTime.Now;

            if ((timeNow - previousTime).Milliseconds <= 50) return;

            _synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                label1.Text = @"Counter " + (int)o;
            }), value);

            //label1.Invoke(new MethodInvoker(() => { label1.Text = @"Counter " + value; }));

            previousTime = timeNow;
        }
    }
}
