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

        protected override async Task OnStartAsync()
        {
            for (int i = 0; i < Number; i++)
            {
                var task = Task.Factory.StartNew<int>((arg) =>
                {
                },
                i);
            }
        }
    }
}
