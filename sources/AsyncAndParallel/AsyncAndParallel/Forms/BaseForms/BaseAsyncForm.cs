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

        protected async Task<int> StartRandomTaskAsync(int minValue, int maxValue)
        {
            var randomMiliseconds = new Random(DateTime.Now.Millisecond).Next(minValue, maxValue);
            await Task.Delay(randomMiliseconds);
            return randomMiliseconds;
        }
    }
}
