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

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class CancelTaskForm : BaseAsyncForm
    {
        public CancelTaskForm()
        {
            InitializeComponent();
        }
        CancellationTokenSource cts;
        private int _sum = 0;
        private async void btnStart_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            _sum = 0;
            cts = new CancellationTokenSource();
            var token = cts.Token;
            try
            {
                await Task.Run(() =>
                    {
                        for (int i = 1; i < 1000; i++)
                        {
                            if (token.IsCancellationRequested)
                            {
                                token.ThrowIfCancellationRequested();
                            }
                            else
                            {
                                _sum += i;
                                Thread.Sleep(10);
                            }
                        }
                        
                    }, token);
                textBox1.Text = _sum.ToString();
            }
            catch (OperationCanceledException oce)
            {
                textBox1.Text = _sum.ToString();
            }
            catch (AggregateException ae)
            {

            }
            catch (Exception ex)
            {
                throw;
            }

            btnStart.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            cts.Cancel();
        }
    }
}
