namespace AsyncAndParallel.Forms.Tasks
{
    partial class PushPullForm
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
            this.btnStopPolling = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPollingLocation = new System.Windows.Forms.Label();
            this.lblOnDemandLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartPolling = new System.Windows.Forms.Button();
            this.btnOnDemand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStopPolling
            // 
            this.btnStopPolling.Enabled = false;
            this.btnStopPolling.Location = new System.Drawing.Point(512, 276);
            this.btnStopPolling.Name = "btnStopPolling";
            this.btnStopPolling.Size = new System.Drawing.Size(75, 23);
            this.btnStopPolling.TabIndex = 5;
            this.btnStopPolling.Text = "Stop Polling";
            this.btnStopPolling.UseVisualStyleBackColor = true;
            this.btnStopPolling.Click += new System.EventHandler(this.btnStopPolling_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Continous Retrieval of Location";
            // 
            // lblPollingLocation
            // 
            this.lblPollingLocation.AutoSize = true;
            this.lblPollingLocation.Location = new System.Drawing.Point(509, 203);
            this.lblPollingLocation.Name = "lblPollingLocation";
            this.lblPollingLocation.Size = new System.Drawing.Size(48, 13);
            this.lblPollingLocation.TabIndex = 7;
            this.lblPollingLocation.Text = "Location";
            // 
            // lblOnDemandLocation
            // 
            this.lblOnDemandLocation.AutoSize = true;
            this.lblOnDemandLocation.Location = new System.Drawing.Point(180, 203);
            this.lblOnDemandLocation.Name = "lblOnDemandLocation";
            this.lblOnDemandLocation.Size = new System.Drawing.Size(48, 13);
            this.lblOnDemandLocation.TabIndex = 8;
            this.lblOnDemandLocation.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "On Demand Location";
            // 
            // btnStartPolling
            // 
            this.btnStartPolling.Location = new System.Drawing.Point(512, 233);
            this.btnStartPolling.Name = "btnStartPolling";
            this.btnStartPolling.Size = new System.Drawing.Size(75, 23);
            this.btnStartPolling.TabIndex = 4;
            this.btnStartPolling.Text = "Start Polling";
            this.btnStartPolling.UseVisualStyleBackColor = true;
            this.btnStartPolling.Click += new System.EventHandler(this.btnStartPolling_Click);
            // 
            // btnOnDemand
            // 
            this.btnOnDemand.Location = new System.Drawing.Point(163, 233);
            this.btnOnDemand.Name = "btnOnDemand";
            this.btnOnDemand.Size = new System.Drawing.Size(174, 23);
            this.btnOnDemand.TabIndex = 9;
            this.btnOnDemand.Text = "GetLocationOnDemand";
            this.btnOnDemand.UseVisualStyleBackColor = true;
            this.btnOnDemand.Click += new System.EventHandler(this.btnOnDemand_Click);
            // 
            // PushPullForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopPolling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPollingLocation);
            this.Controls.Add(this.lblOnDemandLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartPolling);
            this.Controls.Add(this.btnOnDemand);
            this.Name = "PushPullForm";
            this.Text = "PushPullForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStopPolling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPollingLocation;
        private System.Windows.Forms.Label lblOnDemandLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartPolling;
        private System.Windows.Forms.Button btnOnDemand;
    }
}