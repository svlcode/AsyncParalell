namespace AsyncAndParallel
{
    partial class UsingTasksContinueWithForm
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
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Size = new System.Drawing.Size(267, 23);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Location = new System.Drawing.Point(12, 63);
            this.listBoxResult.Size = new System.Drawing.Size(348, 186);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 42);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(89, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Processes count:";
            // 
            // UsingTasksContinueWithForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 261);
            this.Controls.Add(this.lblCount);
            this.Name = "UsingTasksContinueWithForm";
            this.Text = "UsingTasksContinueWithForm";
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.Controls.SetChildIndex(this.btnStart, 0);
            this.Controls.SetChildIndex(this.listBoxResult, 0);
            this.Controls.SetChildIndex(this.lblCount, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
    }
}