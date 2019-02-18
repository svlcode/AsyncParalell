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
    public partial class PassingArgumentsForm : BaseListBoxProgressForm
    {
        public PassingArgumentsForm()
        {
            InitializeComponent();
        }

        // If value may change, pass task parameters instead of using closures.
        protected override async Task OnStartAsync()
        {
            for (int i = 0; i < Number; i++)
            {
                await Task.Factory.StartNew((arg) =>
                {
                    int taskId = (int)arg;
                    AddLine($"started task: {taskId}");
                },i);
            }
        }

        private void AddLine(string text)
        {
            this.listBoxResult.Invoke(new MethodInvoker(() => { this.listBoxResult.Items.Add(text); }));
        }
    }
}
