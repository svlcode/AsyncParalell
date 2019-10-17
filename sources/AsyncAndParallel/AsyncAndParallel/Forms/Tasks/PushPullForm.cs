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
        private PositionService _positionService;

        public PushPullForm()
        {
            InitializeComponent();
            _positionService = new PositionService();
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
                lblOnDemandLocation.Text = "Error";
            }
            label1.Text = "To be started...";
        }

        private void PositionUpdated(object sender, PositionEventArgs e)
        {
            this.lblPollingLocation.Invoke(new Action(() => { lblPollingLocation.Text = e.Position; }));
        }

        private void btnStartPolling_Click(object sender, EventArgs e)
        {
            btnStartPolling.Enabled = false;
            btnStopPolling.Enabled = true;
            Start();
        }

        private void Start()
        {
            _positionService.PositionUpdated += PositionUpdated;
            _positionService.Start();
        }

        private void Stop()
        {
            _positionService.PositionUpdated -= PositionUpdated;
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
