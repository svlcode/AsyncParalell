using System;

namespace AsyncAndParallel.Forms.BaseForms
{
    public partial class BaseListBoxForm : BaseAsyncForm
    {
        public BaseListBoxForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            OnStart();
            await OnStartAsync();
        }
    }
}
