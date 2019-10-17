using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.BaseForms
{
    public partial class BaseAsyncForm : Form
    {
        public BaseAsyncForm()
        {
            InitializeComponent();
        }

        protected virtual void OnStart()
        {
        }

        protected virtual async Task OnStartAsync()
        {
            await Task.Yield();
        }

        protected void StartTimeConsumingTask()
        {
            long sum = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                sum += i;
            }
        }

        /// <summary>
        /// Starts a tasks that completes after a time delay between min and max values.
        /// </summary>
        /// <param name="minValue">the minimum number of miliseconds after the task completes.</param>
        /// <param name="maxValue">the maximum number of miliseconds after the task completes.</param>
        /// <returns>the number of miliseconds in which the task completed..</returns>
        protected async Task<int> StartRandomTaskAsync(int minValue, int maxValue)
        {
            var randomMiliseconds = new Random(DateTime.Now.Millisecond).Next(minValue, maxValue);
            await Task.Delay(randomMiliseconds);
            return randomMiliseconds;
        }
    }
}
