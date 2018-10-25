using AsyncAndParallel.Forms.BaseForms;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class DeadlockForm : BaseAsyncForm
    {
        public DeadlockForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            var task = GetStringAsync();
            // task.Result or task.Wait() would result in a deadlock 
            // because the async task would wait for the UI thread to give 
            // back control and the UI thread would wait for the async task to finish.
            richTextBox1.Text = task.Result;
        }

        private async Task<string> GetStringAsync()
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync("http://www.google.com");
            }
        }
    }
}
