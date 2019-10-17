namespace AsyncAndParallel
{
    partial class DownloadPdfForm
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxResult
            // 
            this.listBoxResult.Location = new System.Drawing.Point(12, 37);
            this.listBoxResult.Size = new System.Drawing.Size(260, 264);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(196, 10);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(178, 20);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.Text = "http://www.introprogramming.info/wp-content/uploads/2013/07/Books/CSharpEn/Fundam" +
    "entals-of-Computer-Programming-with-CSharp-Nakov-eBook-v2013.pdf";
            // 
            // DownloadPdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.txtUrl);
            this.Name = "DownloadPdfForm";
            this.Text = "DownloadPDF";
            this.Controls.SetChildIndex(this.btnStart, 0);
            this.Controls.SetChildIndex(this.listBoxResult, 0);
            this.Controls.SetChildIndex(this.txtUrl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
    }
}

