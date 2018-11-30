namespace DeliverySystem
{
    partial class FBoxLog
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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Enabled = false;
            this.tbLog.Location = new System.Drawing.Point(12, 12);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(311, 303);
            this.tbLog.TabIndex = 0;
            // 
            // FBoxLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 326);
            this.Controls.Add(this.tbLog);
            this.Name = "FBoxLog";
            this.Text = "FBoxLog";
            this.Load += new System.EventHandler(this.FBoxLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
    }
}