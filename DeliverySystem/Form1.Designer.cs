namespace DeliverySystem
{
    partial class fStores
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
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.btnLogConfig = new System.Windows.Forms.Button();
            this.btnDeliverOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStores
            // 
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Location = new System.Drawing.Point(12, 21);
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.RowTemplate.Height = 24;
            this.dgvStores.Size = new System.Drawing.Size(362, 336);
            this.dgvStores.TabIndex = 0;
            // 
            // btnLogConfig
            // 
            this.btnLogConfig.Location = new System.Drawing.Point(380, 21);
            this.btnLogConfig.Name = "btnLogConfig";
            this.btnLogConfig.Size = new System.Drawing.Size(135, 31);
            this.btnLogConfig.TabIndex = 1;
            this.btnLogConfig.Text = "Log configuration";
            this.btnLogConfig.UseVisualStyleBackColor = true;
            // 
            // btnDeliverOrder
            // 
            this.btnDeliverOrder.Location = new System.Drawing.Point(399, 407);
            this.btnDeliverOrder.Name = "btnDeliverOrder";
            this.btnDeliverOrder.Size = new System.Drawing.Size(116, 31);
            this.btnDeliverOrder.TabIndex = 2;
            this.btnDeliverOrder.Text = "Deliver orders";
            this.btnDeliverOrder.UseVisualStyleBackColor = true;
            this.btnDeliverOrder.Click += new System.EventHandler(this.btnDeliverOrder_Click);
            // 
            // fStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnDeliverOrder);
            this.Controls.Add(this.btnLogConfig);
            this.Controls.Add(this.dgvStores);
            this.Name = "fStores";
            this.Text = "Stores";
            this.Load += new System.EventHandler(this.fStores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.Button btnLogConfig;
        private System.Windows.Forms.Button btnDeliverOrder;
    }
}

