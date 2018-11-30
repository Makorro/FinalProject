namespace DeliverySystem
{
    partial class FDgvLog
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
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStamp,
            this.Message});
            this.dgvLog.Enabled = false;
            this.dgvLog.Location = new System.Drawing.Point(12, 12);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowTemplate.Height = 24;
            this.dgvLog.Size = new System.Drawing.Size(821, 355);
            this.dgvLog.TabIndex = 0;
            // 
            // TimeStamp
            // 
            this.TimeStamp.HeaderText = "TimeStamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Width = 176;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            // 
            // FDgvLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 376);
            this.Controls.Add(this.dgvLog);
            this.Name = "FDgvLog";
            this.Text = "FDgvLog";
            this.Load += new System.EventHandler(this.FDgvLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    }
}