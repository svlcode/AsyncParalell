using AsyncAndParallel.Forms.BaseForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.Tasks
{
    public partial class FireAndForgetForm : BaseAsyncForm
    {
        public FireAndForgetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //StartTask(textBox1);
            //StartTask(textBox2);
            //StartTask(textBox3);

            //Boom();

            GetTask().SafeFireAndForget();
        }

        private async Task StartTask(TextBox textBox)
        {
            var result = await StartRandomTaskAsync(10000, 20000);
            textBox.Text = result.ToString();
        }

        // Bad practice: exception will never be catched.
        // Application will crash...
        private async void Boom()
        {
            await GetTask();
        }

        private async Task GetTask()
        {
            await Task.Yield();
            throw new Exception();
        }

      

    }
}
