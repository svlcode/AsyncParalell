using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class BewareOfClosuresForm : BaseListBoxProgressForm
    {
        public BewareOfClosuresForm()
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

                    listBoxResult.Invoke(new MethodInvoker(() => { listBoxResult.Items.Add($"Started task {taskId}"); }));
                });
            }
        }
    }
}
