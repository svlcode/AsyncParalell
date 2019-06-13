namespace AsyncAndParallel.Forms.Tasks
{
    partial class LongRunningOperationsForm
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
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Size = new System.Drawing.Size(643, 23);
            // 
            // txtNumber
            // 
            this.txtNumber.Text = "50";
            // 
            // listBoxResult
            // 
            this.listBoxResult.Size = new System.Drawing.Size(776, 368);
            // 
            // LongRunningOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "LongRunningOperationsForm";
            this.Text = "LongRunningOperationsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}