namespace AsyncAndParallel.Forms.UpdateUI
{
    partial class ResponsiveUpdateForm
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
            this.btnStartAsync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartAsync
            // 
            this.btnStartAsync.Location = new System.Drawing.Point(187, 169);
            this.btnStartAsync.Name = "btnStartAsync";
            this.btnStartAsync.Size = new System.Drawing.Size(75, 23);
            this.btnStartAsync.TabIndex = 0;
            this.btnStartAsync.Text = "Start Async";
            this.btnStartAsync.UseVisualStyleBackColor = true;
            this.btnStartAsync.Click += new System.EventHandler(this.btnStartAsync_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // ResponsiveUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartAsync);
            this.Name = "ResponsiveUpdateForm";
            this.Text = "ResponsiveUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartAsync;
        private System.Windows.Forms.Label label1;
    }
}