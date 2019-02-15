using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.UpdateUI
{
    public partial class UpdateUIUsingMethodInvokerForm : BaseListBoxProgressForm
    {
        public UpdateUIUsingMethodInvokerForm()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            for (int i = 0; i < Number; i++)
            {
                // the task will make a closure over the variable 'i'
                // this is not the propery way of passing data to a task.
                Task.Run(() =>
                {
                    // taskId will have the same value for all tasks due to the fact 
                    // that there is a small delay between the task is started and the value 'i' is read
                    var taskId = i;

                    AddLine($"Started task {taskId}");
                });
            }
        }

        private void AddLine(string text)
        {
            this.listBoxResult.Invoke(new MethodInvoker(() => { this.listBoxResult.Items.Add(text); }));
        }
    }
}
