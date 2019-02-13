using System;
using System.Windows.Forms;
using AsyncAndParallel.DownloadPDF;
using AsyncAndParallel.Forms;
using AsyncAndParallel.Forms.Tasks;
using AsyncAndParallel.Forms.Threads;

namespace AsyncAndParallel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowForm<F>() where F : Form, new()
        {
            using (F form = new F())
            {
                form.ShowDialog();
            }
        }

        private void btnJoinThread_Click(object sender, EventArgs e)
        {
            ShowForm<JoinThreadForm>();
        }

        private void btnAbortThreads_Click(object sender, EventArgs e)
        {
            ShowForm<AbortThreadForm>();
        }

        private void btnThreadCallback_Click(object sender, EventArgs e)
        {
            ShowForm<ThreadCallbackForm>();
        }

        private void btnBackgrounForeground_Click(object sender, EventArgs e)
        {
            ShowForm<BackgroundForegroundThreadsForm>();
        }

        private void btnUsingTasks_Click(object sender, EventArgs e)
        {
            ShowForm<UsingTasksForm>();
        }

        private void btnUsingTasksContinueWith_Click(object sender, EventArgs e)
        {
            ShowForm<UsingTasksContinueWithForm>();
        }

        private void btnBasicAsync_Click(object sender, EventArgs e)
        {
            ShowForm<BasicAsyncForm>();
        }

        private void btnTaskCompletionSource_Click(object sender, EventArgs e)
        {
            ShowForm<UsingTaskCompletionSourceForm>();
        }

        private void btnAwaitAllTasks_Click(object sender, EventArgs e)
        {
            ShowForm<AwaitAllTasksForm>();
        }

        private void btnDeadlock_Click(object sender, EventArgs e)
        {
            ShowForm<DeadlockForm>();
        }

        private void btnAwaitAnyTask_Click(object sender, EventArgs e)
        {
            ShowForm<AwaitAnyTaskForm>();
        }
    }
}
