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
            this.tabPageThreads = new System.Windows.Forms.TabPage();
            this.btnBackgrounForeground = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTasks = new System.Windows.Forms.TabPage();
            this.btnDeadlock = new System.Windows.Forms.Button();
            this.btnAwaitMultipleTasks = new System.Windows.Forms.Button();
            this.btnTaskCompletionSource = new System.Windows.Forms.Button();
            this.btnBasicAsync = new System.Windows.Forms.Button();
            this.btnUsingTasksContinueWith = new System.Windows.Forms.Button();
            this.btnUsingTasks = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageThreads.SuspendLayout();
            this.tabPageTasks.SuspendLayout();
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
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(724, 351);
            this.tabControl.TabIndex = 1;
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
            // tabPageTasks
            // 
            this.tabPageTasks.Controls.Add(this.btnDeadlock);
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
            // btnDeadlock
            // 
            this.btnDeadlock.Location = new System.Drawing.Point(185, 6);
            this.btnDeadlock.Name = "btnDeadlock";
            this.btnDeadlock.Size = new System.Drawing.Size(171, 23);
            this.btnDeadlock.TabIndex = 1;
            this.btnDeadlock.Text = "Deadlock UI Thread";
            this.btnDeadlock.UseVisualStyleBackColor = true;
            this.btnDeadlock.Click += new System.EventHandler(this.btnDeadlock_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 351);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageThreads.ResumeLayout(false);
            this.tabPageThreads.PerformLayout();
            this.tabPageTasks.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnDeadlock;
    }
}