using AsyncAndParallel.Forms.BaseForms;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class CancelTaskForm : BaseAsyncForm
    {
        private CancellationTokenSource _cts;
        private int _sum = 0;

        public CancelTaskForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            _sum = 0;
            _cts = new CancellationTokenSource();
            var token = _cts.Token;
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
            _cts.Cancel();
        }
    }
}
