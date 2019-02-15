using System;
using System.Windows.Forms;
using AsyncAndParallel.DownloadPDF;
using AsyncAndParallel.Forms;
using AsyncAndParallel.Forms.Tasks;
using AsyncAndParallel.Forms.Threads;
using AsyncAndParallel.Forms.UpdateUI;

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

        private void btnAwaitAllOneByOne_Click(object sender, EventArgs e)
        {
            ShowForm<AwaitAllOneByOneForm>();
        }

        private void btnFireAndForget_Click(object sender, EventArgs e)
        {
            ShowForm<FireAndForgetForm>();
        }

        private void btnContinueWhenAll_Click(object sender, EventArgs e)
        {
            ShowForm<ContinueWhenAllForm>();
        }

        private void btnHandlingExceptions_Click(object sender, EventArgs e)
        {
            ShowForm<HandlingExceptionsForm>();
        }

        private void btnCancelTask_Click(object sender, EventArgs e)
        {
            ShowForm<CancelTaskForm>();
        }

        private void btnBewareOfClosures_Click(object sender, EventArgs e)
        {
            ShowForm<BewareOfClosuresForm>();
        }

        private void btnUsingDelegate_Click(object sender, EventArgs e)
        {
            ShowForm<UpdateUIUsingDelegateForm>();
        }

        private void btnUpdateUsingMethodInvoker_Click(object sender, EventArgs e)
        {
            ShowForm<UpdateUIUsingMethodInvokerForm>();
        }

        private void btnResponsiveUpdate_Click(object sender, EventArgs e)
        {
            ShowForm<ResponsiveUpdateForm>();
        }
    }
}
