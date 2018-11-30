namespace DeliverySystem
{
    partial class FLogConfiguration
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
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.btnAddlogFile = new System.Windows.Forms.Button();
            this.btnAddTextboxLog = new System.Windows.Forms.Button();
            this.btnAddDatagridViewLog = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogs
            // 
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(12, 12);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowTemplate.Height = 24;
            this.dgvLogs.Size = new System.Drawing.Size(369, 219);
            this.dgvLogs.TabIndex = 0;
            this.dgvLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogs_CellContentClick);
            // 
            // btnAddlogFile
            // 
            this.btnAddlogFile.Location = new System.Drawing.Point(12, 264);
            this.btnAddlogFile.Name = "btnAddlogFile";
            this.btnAddlogFile.Size = new System.Drawing.Size(101, 32);
            this.btnAddlogFile.TabIndex = 1;
            this.btnAddlogFile.Text = "Add File Log";
            this.btnAddlogFile.UseVisualStyleBackColor = true;
            this.btnAddlogFile.Click += new System.EventHandler(this.btnAddlogFile_Click);
            // 
            // btnAddTextboxLog
            // 
            this.btnAddTextboxLog.Location = new System.Drawing.Point(119, 264);
            this.btnAddTextboxLog.Name = "btnAddTextboxLog";
            this.btnAddTextboxLog.Size = new System.Drawing.Size(124, 32);
            this.btnAddTextboxLog.TabIndex = 2;
            this.btnAddTextboxLog.Text = "Add Textbox Log";
            this.btnAddTextboxLog.UseVisualStyleBackColor = true;
            this.btnAddTextboxLog.Click += new System.EventHandler(this.btnAddTextboxLog_Click);
            // 
            // btnAddDatagridViewLog
            // 
            this.btnAddDatagridViewLog.Location = new System.Drawing.Point(249, 264);
            this.btnAddDatagridViewLog.Name = "btnAddDatagridViewLog";
            this.btnAddDatagridViewLog.Size = new System.Drawing.Size(132, 32);
            this.btnAddDatagridViewLog.TabIndex = 3;
            this.btnAddDatagridViewLog.Text = "Add DataGrid Log";
            this.btnAddDatagridViewLog.UseVisualStyleBackColor = true;
            this.btnAddDatagridViewLog.Click += new System.EventHandler(this.btnAddDatagridViewLog_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(157, 347);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FLogConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 382);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAddDatagridViewLog);
            this.Controls.Add(this.btnAddTextboxLog);
            this.Controls.Add(this.btnAddlogFile);
            this.Controls.Add(this.dgvLogs);
            this.Name = "FLogConfiguration";
            this.Text = "FLogConfiguration";
            this.Load += new System.EventHandler(this.FLogConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Button btnAddlogFile;
        private System.Windows.Forms.Button btnAddTextboxLog;
        private System.Windows.Forms.Button btnAddDatagridViewLog;
        private System.Windows.Forms.Button btnDone;
    }
}