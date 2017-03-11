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
            this.tabPageTasks = new System.Windows.Forms.TabPage();
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
            this.btnJoinThread.Size = new System.Drawing.Size(127, 23);
            this.btnJoinThread.TabIndex = 0;
            this.btnJoinThread.Text = "Join Thread";
            this.btnJoinThread.UseVisualStyleBackColor = true;
            this.btnJoinThread.Click += new System.EventHandler(this.btnJoinThread_Click);
            // 
            // btnAbortThreads
            // 
            this.btnAbortThreads.Location = new System.Drawing.Point(8, 64);
            this.btnAbortThreads.Name = "btnAbortThreads";
            this.btnAbortThreads.Size = new System.Drawing.Size(127, 23);
            this.btnAbortThreads.TabIndex = 0;
            this.btnAbortThreads.Text = "Abort Threads";
            this.btnAbortThreads.UseVisualStyleBackColor = true;
            this.btnAbortThreads.Click += new System.EventHandler(this.btnAbortThreads_Click);
            // 
            // btnThreadCallback
            // 
            this.btnThreadCallback.Location = new System.Drawing.Point(8, 35);
            this.btnThreadCallback.Name = "btnThreadCallback";
            this.btnThreadCallback.Size = new System.Drawing.Size(127, 23);
            this.btnThreadCallback.TabIndex = 0;
            this.btnThreadCallback.Text = "Thread callback";
            this.btnThreadCallback.UseVisualStyleBackColor = true;
            this.btnThreadCallback.Click += new System.EventHandler(this.btnThreadCallback_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTasks);
            this.tabControl.Controls.Add(this.tabPageThreads);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(612, 323);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageThreads
            // 
            this.tabPageThreads.Controls.Add(this.btnJoinThread);
            this.tabPageThreads.Controls.Add(this.btnThreadCallback);
            this.tabPageThreads.Controls.Add(this.btnAbortThreads);
            this.tabPageThreads.Location = new System.Drawing.Point(4, 22);
            this.tabPageThreads.Name = "tabPageThreads";
            this.tabPageThreads.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThreads.Size = new System.Drawing.Size(604, 297);
            this.tabPageThreads.TabIndex = 0;
            this.tabPageThreads.Text = "Threads";
            this.tabPageThreads.UseVisualStyleBackColor = true;
            // 
            // tabPageTasks
            // 
            this.tabPageTasks.Controls.Add(this.btnUsingTasksContinueWith);
            this.tabPageTasks.Controls.Add(this.btnUsingTasks);
            this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTasks.Size = new System.Drawing.Size(604, 297);
            this.tabPageTasks.TabIndex = 1;
            this.tabPageTasks.Text = "Tasks";
            this.tabPageTasks.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(612, 323);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageThreads.ResumeLayout(false);
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
    }
}