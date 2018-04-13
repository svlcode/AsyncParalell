namespace AsyncAndParallel.Forms.Threads
{
    partial class BackgroundForegroundThreadsForm
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
            this.btnStartBackgroundThread = new System.Windows.Forms.Button();
            this.btnStartForegroundThread = new System.Windows.Forms.Button();
            this.btnAbortCurrentThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartBackgroundThread
            // 
            this.btnStartBackgroundThread.Location = new System.Drawing.Point(65, 109);
            this.btnStartBackgroundThread.Name = "btnStartBackgroundThread";
            this.btnStartBackgroundThread.Size = new System.Drawing.Size(139, 23);
            this.btnStartBackgroundThread.TabIndex = 0;
            this.btnStartBackgroundThread.Text = "Start Background Thread";
            this.btnStartBackgroundThread.UseVisualStyleBackColor = true;
            this.btnStartBackgroundThread.Click += new System.EventHandler(this.btnStartBackgroundThread_Click);
            // 
            // btnStartForegroundThread
            // 
            this.btnStartForegroundThread.Location = new System.Drawing.Point(65, 38);
            this.btnStartForegroundThread.Name = "btnStartForegroundThread";
            this.btnStartForegroundThread.Size = new System.Drawing.Size(139, 23);
            this.btnStartForegroundThread.TabIndex = 0;
            this.btnStartForegroundThread.Text = "Start Foreground Thread";
            this.btnStartForegroundThread.UseVisualStyleBackColor = true;
            this.btnStartForegroundThread.Click += new System.EventHandler(this.btnStartForegroundThread_Click);
            // 
            // btnAbortCurrentThread
            // 
            this.btnAbortCurrentThread.Location = new System.Drawing.Point(65, 180);
            this.btnAbortCurrentThread.Name = "btnAbortCurrentThread";
            this.btnAbortCurrentThread.Size = new System.Drawing.Size(139, 23);
            this.btnAbortCurrentThread.TabIndex = 1;
            this.btnAbortCurrentThread.Text = "Abort Current Thread";
            this.btnAbortCurrentThread.UseVisualStyleBackColor = true;
            this.btnAbortCurrentThread.Click += new System.EventHandler(this.btnAbortCurrentThread_Click);
            // 
            // BackgroundForegroundThreadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAbortCurrentThread);
            this.Controls.Add(this.btnStartForegroundThread);
            this.Controls.Add(this.btnStartBackgroundThread);
            this.Name = "BackgroundForegroundThreadsForm";
            this.Text = "BackgroundForegroundThreadsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartBackgroundThread;
        private System.Windows.Forms.Button btnStartForegroundThread;
        private System.Windows.Forms.Button btnAbortCurrentThread;
    }
}