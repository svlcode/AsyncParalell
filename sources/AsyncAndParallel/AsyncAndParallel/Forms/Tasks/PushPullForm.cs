using PushPullMechanism;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class PushPullForm : Form
    {
        private MyService _positionService;

        public PushPullForm()
        {
            InitializeComponent();
            _positionService = new MyService();
        }

        private async void btnOnDemand_Click(object sender, EventArgs e)
        {
            label1.Text = "Running..";
            lblOnDemandLocation.Text = "Calculating position";

            try
            {
                lblOnDemandLocation.Text = await _positionService.GetPositionAsync();
            }
            catch (Exception ex)
            {
                lblOnDemandLocation.Text = ex.Message;
            }
            label1.Text = "To be started...";
        }

        private void PositionUpdated(object sender, MyValueEventArgs e)
        {
            this.lblPollingLocation.Invoke(new Action(() => { lblPollingLocation.Text = e.Value; }));
        }

        private void btnStartPolling_Click(object sender, EventArgs e)
        {
            btnStartPolling.Enabled = false;
            btnStopPolling.Enabled = true;
            Start();
        }

        private void Start()
        {
            _positionService.ValueUpdated += PositionUpdated;
            _positionService.Start();
        }

        private void Stop()
        {
            _positionService.ValueUpdated -= PositionUpdated;
            _positionService.Stop();
        }

        private void btnStopPolling_Click(object sender, EventArgs e)
        {
            btnStartPolling.Enabled = true;
            btnStopPolling.Enabled = false;
            Stop();
        }
    }
}
