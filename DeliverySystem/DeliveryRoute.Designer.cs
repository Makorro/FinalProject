namespace DeliverySystem
{
    partial class DeliveryRoute
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
            this.lblVisitedStores = new System.Windows.Forms.Label();
            this.lblTotalEarning = new System.Windows.Forms.Label();
            this.lblRemainingStores = new System.Windows.Forms.Label();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.tbVisitedStores = new System.Windows.Forms.TextBox();
            this.tbRemainingStores = new System.Windows.Forms.TextBox();
            this.tbCurrentStore = new System.Windows.Forms.TextBox();
            this.lblCurrentStore = new System.Windows.Forms.Label();
            this.tbTotalEarning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVisitedStores
            // 
            this.lblVisitedStores.AutoSize = true;
            this.lblVisitedStores.Location = new System.Drawing.Point(12, 26);
            this.lblVisitedStores.Name = "lblVisitedStores";
            this.lblVisitedStores.Size = new System.Drawing.Size(101, 17);
            this.lblVisitedStores.TabIndex = 1;
            this.lblVisitedStores.Text = "Visited stores: ";
            // 
            // lblTotalEarning
            // 
            this.lblTotalEarning.AutoSize = true;
            this.lblTotalEarning.Location = new System.Drawing.Point(12, 151);
            this.lblTotalEarning.Name = "lblTotalEarning";
            this.lblTotalEarning.Size = new System.Drawing.Size(100, 17);
            this.lblTotalEarning.TabIndex = 2;
            this.lblTotalEarning.Text = "Total earning: ";
            // 
            // lblRemainingStores
            // 
            this.lblRemainingStores.AutoSize = true;
            this.lblRemainingStores.Location = new System.Drawing.Point(12, 70);
            this.lblRemainingStores.Name = "lblRemainingStores";
            this.lblRemainingStores.Size = new System.Drawing.Size(126, 17);
            this.lblRemainingStores.TabIndex = 3;
            this.lblRemainingStores.Text = "Remaining stores: ";
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(299, 205);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(75, 23);
            this.btnDeliver.TabIndex = 4;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // tbVisitedStores
            // 
            this.tbVisitedStores.Enabled = false;
            this.tbVisitedStores.Location = new System.Drawing.Point(145, 23);
            this.tbVisitedStores.Name = "tbVisitedStores";
            this.tbVisitedStores.Size = new System.Drawing.Size(100, 22);
            this.tbVisitedStores.TabIndex = 5;
            // 
            // tbRemainingStores
            // 
            this.tbRemainingStores.Enabled = false;
            this.tbRemainingStores.Location = new System.Drawing.Point(145, 67);
            this.tbRemainingStores.Name = "tbRemainingStores";
            this.tbRemainingStores.Size = new System.Drawing.Size(100, 22);
            this.tbRemainingStores.TabIndex = 6;
            // 
            // tbCurrentStore
            // 
            this.tbCurrentStore.Enabled = false;
            this.tbCurrentStore.Location = new System.Drawing.Point(145, 105);
            this.tbCurrentStore.Name = "tbCurrentStore";
            this.tbCurrentStore.Size = new System.Drawing.Size(144, 22);
            this.tbCurrentStore.TabIndex = 7;
            // 
            // lblCurrentStore
            // 
            this.lblCurrentStore.AutoSize = true;
            this.lblCurrentStore.Location = new System.Drawing.Point(12, 108);
            this.lblCurrentStore.Name = "lblCurrentStore";
            this.lblCurrentStore.Size = new System.Drawing.Size(95, 17);
            this.lblCurrentStore.TabIndex = 8;
            this.lblCurrentStore.Text = "Current store:";
            // 
            // tbTotalEarning
            // 
            this.tbTotalEarning.Enabled = false;
            this.tbTotalEarning.Location = new System.Drawing.Point(145, 148);
            this.tbTotalEarning.Name = "tbTotalEarning";
            this.tbTotalEarning.Size = new System.Drawing.Size(100, 22);
            this.tbTotalEarning.TabIndex = 9;
            // 
            // DeliveryRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 240);
            this.Controls.Add(this.tbTotalEarning);
            this.Controls.Add(this.lblCurrentStore);
            this.Controls.Add(this.tbCurrentStore);
            this.Controls.Add(this.tbRemainingStores);
            this.Controls.Add(this.tbVisitedStores);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.lblRemainingStores);
            this.Controls.Add(this.lblTotalEarning);
            this.Controls.Add(this.lblVisitedStores);
            this.Name = "DeliveryRoute";
            this.Text = "DeliveryRoute";
            this.Load += new System.EventHandler(this.DeliveryRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVisitedStores;
        private System.Windows.Forms.Label lblTotalEarning;
        private System.Windows.Forms.Label lblRemainingStores;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.TextBox tbVisitedStores;
        private System.Windows.Forms.TextBox tbRemainingStores;
        private System.Windows.Forms.TextBox tbCurrentStore;
        private System.Windows.Forms.Label lblCurrentStore;
        private System.Windows.Forms.TextBox tbTotalEarning;
    }
}