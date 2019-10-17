namespace AsyncAndParallel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJoinThread = new System.Windows.Forms.Button();
            this.btnAbortThreads = new System.Windows.Forms.Button();
            this.btnThreadCallback = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTasks = new System.Windows.Forms.TabPage();
            this.btnLongRunning = new System.Windows.Forms.Button();
            this.btnPassingArguments = new System.Windows.Forms.Button();
            this.btnBewareOfClosures = new System.Windows.Forms.Button();
            this.btnCancelTask = new System.Windows.Forms.Button();
            this.btnHandlingExceptions = new System.Windows.Forms.Button();
            this.btnContinueWhenAll = new System.Windows.Forms.Button();
            this.btnFireAndForget = new System.Windows.Forms.Button();
            this.btnAwaitAllOneByOne = new System.Windows.Forms.Button();
            this.btnAwaitAnyTask = new System.Windows.Forms.Button();
            this.btnAwaitMultipleTasks = new System.Windows.Forms.Button();
            this.btnTaskCompletionSource = new System.Windows.Forms.Button();
            this.btnBasicAsync = new System.Windows.Forms.Button();
            this.btnUsingTasksContinueWith = new System.Windows.Forms.Button();
            this.btnUsingTasks = new System.Windows.Forms.Button();
            this.tabPageThreads = new System.Windows.Forms.TabPage();
            this.btnBackgrounForeground = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeadlock = new System.Windows.Forms.Button();
            this.btnResponsiveUpdate = new System.Windows.Forms.Button();
            this.btnUpdateUsingMethodInvoker = new System.Windows.Forms.Button();
            this.btnUsingDelegate = new System.Windows.Forms.Button();
            this.btnPushPullMechanism = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageTasks.SuspendLayout();
            this.tabPageThreads.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJoinThread
            // 
            this.btnJoinThread.Location = new System.Drawing.Point(8, 6);
            this.btnJoinThread.Name = "btnJoinThread";
            this.btnJoinThread.Size = new System.Drawing.Size(147, 23);
            this.btnJoinThread.TabIndex = 0;
            this.btnJoinThread.Text = "Join Thread";
            this.btnJoinThread.UseVisualStyleBackColor = true;
            this.btnJoinThread.Click += new System.EventHandler(this.btnJoinThread_Click);
            // 
            // btnAbortThreads
            // 
            this.btnAbortThreads.Location = new System.Drawing.Point(8, 64);
            this.btnAbortThreads.Name = "btnAbortThreads";
            this.btnAbortThreads.Size = new System.Drawing.Size(147, 23);
            this.btnAbortThreads.TabIndex = 0;
            this.btnAbortThreads.Text = "Abort Threads";
            this.btnAbortThreads.UseVisualStyleBackColor = true;
            this.btnAbortThreads.Click += new System.EventHandler(this.btnAbortThreads_Click);
            // 
            // btnThreadCallback
            // 
            this.btnThreadCallback.Location = new System.Drawing.Point(8, 35);
            this.btnThreadCallback.Name = "btnThreadCallback";
            this.btnThreadCallback.Size = new System.Drawing.Size(147, 23);
            this.btnThreadCallback.TabIndex = 0;
            this.btnThreadCallback.Text = "Thread callback";
            this.btnThreadCallback.UseVisualStyleBackColor = true;
            this.btnThreadCallback.Click += new System.EventHandler(this.btnThreadCallback_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTasks);
            this.tabControl.Controls.Add(this.tabPageThreads);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(724, 351);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageTasks
            // 
            this.tabPageTasks.Controls.Add(this.btnPushPullMechanism);
            this.tabPageTasks.Controls.Add(this.btnLongRunning);
            this.tabPageTasks.Controls.Add(this.btnPassingArguments);
            this.tabPageTasks.Controls.Add(this.btnBewareOfClosures);
            this.tabPageTasks.Controls.Add(this.btnCancelTask);
            this.tabPageTasks.Controls.Add(this.btnHandlingExceptions);
            this.tabPageTasks.Controls.Add(this.btnContinueWhenAll);
            this.tabPageTasks.Controls.Add(this.btnFireAndForget);
            this.tabPageTasks.Controls.Add(this.btnAwaitAllOneByOne);
            this.tabPageTasks.Controls.Add(this.btnAwaitAnyTask);
            this.tabPageTasks.Controls.Add(this.btnAwaitMultipleTasks);
            this.tabPageTasks.Controls.Add(this.btnTaskCompletionSource);
            this.tabPageTasks.Controls.Add(this.btnBasicAsync);
            this.tabPageTasks.Controls.Add(this.btnUsingTasksContinueWith);
            this.tabPageTasks.Controls.Add(this.btnUsingTasks);
            this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTasks.Size = new System.Drawing.Size(716, 325);
            this.tabPageTasks.TabIndex = 1;
            this.tabPageTasks.Text = "Tasks";
            this.tabPageTasks.UseVisualStyleBackColor = true;
            // 
            // btnLongRunning
            // 
            this.btnLongRunning.Location = new System.Drawing.Point(185, 64);
            this.btnLongRunning.Name = "btnLongRunning";
            this.btnLongRunning.Size = new System.Drawing.Size(171, 23);
            this.btnLongRunning.TabIndex = 1;
            this.btnLongRunning.Text = "Long Running Operations";
            this.btnLongRunning.UseVisualStyleBackColor = true;
            this.btnLongRunning.Click += new System.EventHandler(this.btnLongRunning_Click);
            // 
            // btnPassingArguments
            // 
            this.btnPassingArguments.Location = new System.Drawing.Point(185, 35);
            this.btnPassingArguments.Name = "btnPassingArguments";
            this.btnPassingArguments.Size = new System.Drawing.Size(171, 23);
            this.btnPassingArguments.TabIndex = 1;
            this.btnPassingArguments.Text = "Passing Arguments";
            this.btnPassingArguments.UseVisualStyleBackColor = true;
            this.btnPassingArguments.Click += new System.EventHandler(this.btnPassingArguments_Click);
            // 
            // btnBewareOfClosures
            // 
            this.btnBewareOfClosures.Location = new System.Drawing.Point(185, 6);
            this.btnBewareOfClosures.Name = "btnBewareOfClosures";
            this.btnBewareOfClosures.Size = new System.Drawing.Size(171, 23);
            this.btnBewareOfClosures.TabIndex = 1;
            this.btnBewareOfClosures.Text = "Beware of Closures";
            this.btnBewareOfClosures.UseVisualStyleBackColor = true;
            this.btnBewareOfClosures.Click += new System.EventHandler(this.btnBewareOfClosures_Click);
            // 
            // btnCancelTask
            // 
            this.btnCancelTask.Location = new System.Drawing.Point(8, 296);
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Size = new System.Drawing.Size(171, 23);
            this.btnCancelTask.TabIndex = 1;
            this.btnCancelTask.Text = "Cancel Task";
            this.btnCancelTask.UseVisualStyleBackColor = true;
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // btnHandlingExceptions
            // 
            this.btnHandlingExceptions.Location = new System.Drawing.Point(8, 267);
            this.btnHandlingExceptions.Name = "btnHandlingExceptions";
            this.btnHandlingExceptions.Size = new System.Drawing.Size(171, 23);
            this.btnHandlingExceptions.TabIndex = 1;
            this.btnHandlingExceptions.Text = "Handling Exceptions";
            this.btnHandlingExceptions.UseVisualStyleBackColor = true;
            this.btnHandlingExceptions.Click += new System.EventHandler(this.btnHandlingExceptions_Click);
            // 
            // btnContinueWhenAll
            // 
            this.btnContinueWhenAll.Location = new System.Drawing.Point(8, 238);
            this.btnContinueWhenAll.Name = "btnContinueWhenAll";
            this.btnContinueWhenAll.Size = new System.Drawing.Size(171, 23);
            this.btnContinueWhenAll.TabIndex = 1;
            this.btnContinueWhenAll.Text = "Continue When All";
            this.btnContinueWhenAll.UseVisualStyleBackColor = true;
            this.btnContinueWhenAll.Click += new System.EventHandler(this.btnContinueWhenAll_Click);
            // 
            // btnFireAndForget
            // 
            this.btnFireAndForget.Location = new System.Drawing.Point(8, 209);
            this.btnFireAndForget.Name = "btnFireAndForget";
            this.btnFireAndForget.Size = new System.Drawing.Size(171, 23);
            this.btnFireAndForget.TabIndex = 1;
            this.btnFireAndForget.Text = "Fire And Forget";
            this.btnFireAndForget.UseVisualStyleBackColor = true;
            this.btnFireAndForget.Click += new System.EventHandler(this.btnFireAndForget_Click);
            // 
            // btnAwaitAllOneByOne
            // 
            this.btnAwaitAllOneByOne.Location = new System.Drawing.Point(8, 180);
            this.btnAwaitAllOneByOne.Name = "btnAwaitAllOneByOne";
            this.btnAwaitAllOneByOne.Size = new System.Drawing.Size(171, 23);
            this.btnAwaitAllOneByOne.TabIndex = 1;
            this.btnAwaitAllOneByOne.Text = "Await All Tasks One By One";
            this.btnAwaitAllOneByOne.UseVisualStyleBackColor = true;
            this.btnAwaitAllOneByOne.Click += new System.EventHandler(this.btnAwaitAllOneByOne_Click);
            // 
            // btnAwaitAnyTask
            // 
            this.btnAwaitAnyTask.Location = new System.Drawing.Point(8, 151);
            this.btnAwaitAnyTask.Name = "btnAwaitAnyTask";
            this.btnAwaitAnyTask.Size = new System.Drawing.Size(171, 23);
            this.btnAwaitAnyTask.TabIndex = 1;
            this.btnAwaitAnyTask.Text = "Await Any Task";
            this.btnAwaitAnyTask.UseVisualStyleBackColor = true;
            this.btnAwaitAnyTask.Click += new System.EventHandler(this.btnAwaitAnyTask_Click);
            // 
            // btnAwaitMultipleTasks
            // 
            this.btnAwaitMultipleTasks.Location = new System.Drawing.Point(8, 122);
            this.btnAwaitMultipleTasks.Name = "btnAwaitMultipleTasks";
            this.btnAwaitMultipleTasks.Size = new System.Drawing.Size(171, 23);
            this.btnAwaitMultipleTasks.TabIndex = 1;
            this.btnAwaitMultipleTasks.Text = "Await All Tasks";
            this.btnAwaitMultipleTasks.UseVisualStyleBackColor = true;
            this.btnAwaitMultipleTasks.Click += new System.EventHandler(this.btnAwaitAllTasks_Click);
            // 
            // btnTaskCompletionSource
            // 
            this.btnTaskCompletionSource.Location = new System.Drawing.Point(8, 93);
            this.btnTaskCompletionSource.Name = "btnTaskCompletionSource";
            this.btnTaskCompletionSource.Size = new System.Drawing.Size(171, 23);
            this.btnTaskCompletionSource.TabIndex = 1;
            this.btnTaskCompletionSource.Text = "Using TaskCompletionSource";
            this.btnTaskCompletionSource.UseVisualStyleBackColor = true;
            this.btnTaskCompletionSource.Click += new System.EventHandler(this.btnTaskCompletionSource_Click);
            // 
            // btnBasicAsync
            // 
            this.btnBasicAsync.Location = new System.Drawing.Point(8, 64);
            this.btnBasicAsync.Name = "btnBasicAsync";
            this.btnBasicAsync.Size = new System.Drawing.Size(171, 23);
            this.btnBasicAsync.TabIndex = 1;
            this.btnBasicAsync.Text = "Basic Async";
            this.btnBasicAsync.UseVisualStyleBackColor = true;
            this.btnBasicAsync.Click += new System.EventHandler(this.btnBasicAsync_Click);
            // 
            // btnUsingTasksContinueWith
            // 
            this.btnUsingTasksContinueWith.Location = new System.Drawing.Point(8, 35);
            this.btnUsingTasksContinueWith.Name = "btnUsingTasksContinueWith";
            this.btnUsingTasksContinueWith.Size = new System.Drawing.Size(171, 23);
            this.btnUsingTasksContinueWith.TabIndex = 1;
            this.btnUsingTasksContinueWith.Text = "Using Tasks ContinueWith";
            this.btnUsingTasksContinueWith.UseVisualStyleBackColor = true;
            this.btnUsingTasksContinueWith.Click += new System.EventHandler(this.btnUsingTasksContinueWith_Click);
            // 
            // btnUsingTasks
            // 
            this.btnUsingTasks.Location = new System.Drawing.Point(8, 6);
            this.btnUsingTasks.Name = "btnUsingTasks";
            this.btnUsingTasks.Size = new System.Drawing.Size(171, 23);
            this.btnUsingTasks.TabIndex = 1;
            this.btnUsingTasks.Text = "Using Tasks";
            this.btnUsingTasks.UseVisualStyleBackColor = true;
            this.btnUsingTasks.Click += new System.EventHandler(this.btnUsingTasks_Click);
            // 
            // tabPageThreads
            // 
            this.tabPageThreads.Controls.Add(this.btnBackgrounForeground);
            this.tabPageThreads.Controls.Add(this.label2);
            this.tabPageThreads.Controls.Add(this.label3);
            this.tabPageThreads.Controls.Add(this.label1);
            this.tabPageThreads.Controls.Add(this.btnJoinThread);
            this.tabPageThreads.Controls.Add(this.btnThreadCallback);
            this.tabPageThreads.Controls.Add(this.btnAbortThreads);
            this.tabPageThreads.Location = new System.Drawing.Point(4, 22);
            this.tabPageThreads.Name = "tabPageThreads";
            this.tabPageThreads.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThreads.Size = new System.Drawing.Size(716, 325);
            this.tabPageThreads.TabIndex = 0;
            this.tabPageThreads.Text = "Threads";
            this.tabPageThreads.UseVisualStyleBackColor = true;
            // 
            // btnBackgrounForeground
            // 
            this.btnBackgrounForeground.Location = new System.Drawing.Point(8, 93);
            this.btnBackgrounForeground.Name = "btnBackgrounForeground";
            this.btnBackgrounForeground.Size = new System.Drawing.Size(147, 23);
            this.btnBackgrounForeground.TabIndex = 2;
            this.btnBackgrounForeground.Text = "Background vs. Foreground";
            this.btnBackgrounForeground.UseVisualStyleBackColor = true;
            this.btnBackgrounForeground.Click += new System.EventHandler(this.btnBackgrounForeground_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This will demonstrate how to stop an executing thread.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "This will demonstrate the difference between Background and Foreground threads an" +
    "d how to abort them.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This will block the current UI Thread.";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeadlock);
            this.tabPage1.Controls.Add(this.btnResponsiveUpdate);
            this.tabPage1.Controls.Add(this.btnUpdateUsingMethodInvoker);
            this.tabPage1.Controls.Add(this.btnUsingDelegate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 325);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "UI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeadlock
            // 
            this.btnDeadlock.Location = new System.Drawing.Point(6, 6);
            this.btnDeadlock.Name = "btnDeadlock";
            this.btnDeadlock.Size = new System.Drawing.Size(171, 23);
            this.btnDeadlock.TabIndex = 3;
            this.btnDeadlock.Text = "Deadlock UI Thread";
            this.btnDeadlock.UseVisualStyleBackColor = true;
            // 
            // btnResponsiveUpdate
            // 
            this.btnResponsiveUpdate.Location = new System.Drawing.Point(6, 93);
            this.btnResponsiveUpdate.Name = "btnResponsiveUpdate";
            this.btnResponsiveUpdate.Size = new System.Drawing.Size(171, 23);
            this.btnResponsiveUpdate.TabIndex = 2;
            this.btnResponsiveUpdate.Text = "Responsive Update UI";
            this.btnResponsiveUpdate.UseVisualStyleBackColor = true;
            this.btnResponsiveUpdate.Click += new System.EventHandler(this.btnResponsiveUpdate_Click);
            // 
            // btnUpdateUsingMethodInvoker
            // 
            this.btnUpdateUsingMethodInvoker.Location = new System.Drawing.Point(6, 64);
            this.btnUpdateUsingMethodInvoker.Name = "btnUpdateUsingMethodInvoker";
            this.btnUpdateUsingMethodInvoker.Size = new System.Drawing.Size(171, 23);
            this.btnUpdateUsingMethodInvoker.TabIndex = 2;
            this.btnUpdateUsingMethodInvoker.Text = "Using MethodInvoker";
            this.btnUpdateUsingMethodInvoker.UseVisualStyleBackColor = true;
            this.btnUpdateUsingMethodInvoker.Click += new System.EventHandler(this.btnUpdateUsingMethodInvoker_Click);
            // 
            // btnUsingDelegate
            // 
            this.btnUsingDelegate.Location = new System.Drawing.Point(6, 35);
            this.btnUsingDelegate.Name = "btnUsingDelegate";
            this.btnUsingDelegate.Size = new System.Drawing.Size(171, 23);
            this.btnUsingDelegate.TabIndex = 2;
            this.btnUsingDelegate.Text = "Using Delegate";
            this.btnUsingDelegate.UseVisualStyleBackColor = true;
            this.btnUsingDelegate.Click += new System.EventHandler(this.btnUsingDelegate_Click);
            // 
            // btnPushPullMechanism
            // 
            this.btnPushPullMechanism.Location = new System.Drawing.Point(185, 93);
            this.btnPushPullMechanism.Name = "btnPushPullMechanism";
            this.btnPushPullMechanism.Size = new System.Drawing.Size(171, 23);
            this.btnPushPullMechanism.TabIndex = 1;
            this.btnPushPullMechanism.Text = "Push / Pull Mechanism";
            this.btnPushPullMechanism.UseVisualStyleBackColor = true;
            this.btnPushPullMechanism.Click += new System.EventHandler(this.btnPushPullMechanism_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 351);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageTasks.ResumeLayout(false);
            this.tabPageThreads.ResumeLayout(false);
            this.tabPageThreads.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJoinThread;
        private System.Windows.Forms.Button btnAbortThreads;
        private System.Windows.Forms.Button btnThreadCallback;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageThreads;
        private System.Windows.Forms.TabPage tabPageTasks;
        private System.Windows.Forms.Button btnUsingTasks;
        private System.Windows.Forms.Button btnUsingTasksContinueWith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackgrounForeground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBasicAsync;
        private System.Windows.Forms.Button btnTaskCompletionSource;
        private System.Windows.Forms.Button btnAwaitMultipleTasks;
        private System.Windows.Forms.Button btnAwaitAnyTask;
        private System.Windows.Forms.Button btnAwaitAllOneByOne;
        private System.Windows.Forms.Button btnFireAndForget;
        private System.Windows.Forms.Button btnContinueWhenAll;
        private System.Windows.Forms.Button btnHandlingExceptions;
        private System.Windows.Forms.Button btnCancelTask;
        private System.Windows.Forms.Button btnBewareOfClosures;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUsingDelegate;
        private System.Windows.Forms.Button btnUpdateUsingMethodInvoker;
        private System.Windows.Forms.Button btnResponsiveUpdate;
        private System.Windows.Forms.Button btnPassingArguments;
        private System.Windows.Forms.Button btnDeadlock;
        private System.Windows.Forms.Button btnLongRunning;
        private System.Windows.Forms.Button btnPushPullMechanism;
    }
}