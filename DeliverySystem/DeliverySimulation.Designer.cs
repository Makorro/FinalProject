namespace DeliverySystem
{
    partial class DeliverySimulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliverySimulation));
            this.pbBread = new System.Windows.Forms.PictureBox();
            this.pbVegetables = new System.Windows.Forms.PictureBox();
            this.pbDrinks = new System.Windows.Forms.PictureBox();
            this.nudBread = new System.Windows.Forms.NumericUpDown();
            this.nudVegetables = new System.Windows.Forms.NumericUpDown();
            this.nudDrinks = new System.Windows.Forms.NumericUpDown();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.btnStartDelivery = new System.Windows.Forms.Button();
            this.lblSimulationAns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVegetables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVegetables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBread
            // 
            this.pbBread.Image = ((System.Drawing.Image)(resources.GetObject("pbBread.Image")));
            this.pbBread.Location = new System.Drawing.Point(42, 276);
            this.pbBread.Name = "pbBread";
            this.pbBread.Size = new System.Drawing.Size(65, 64);
            this.pbBread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBread.TabIndex = 0;
            this.pbBread.TabStop = false;
            // 
            // pbVegetables
            // 
            this.pbVegetables.Image = ((System.Drawing.Image)(resources.GetObject("pbVegetables.Image")));
            this.pbVegetables.Location = new System.Drawing.Point(42, 38);
            this.pbVegetables.Name = "pbVegetables";
            this.pbVegetables.Size = new System.Drawing.Size(65, 64);
            this.pbVegetables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVegetables.TabIndex = 1;
            this.pbVegetables.TabStop = false;
            // 
            // pbDrinks
            // 
            this.pbDrinks.Image = ((System.Drawing.Image)(resources.GetObject("pbDrinks.Image")));
            this.pbDrinks.Location = new System.Drawing.Point(42, 150);
            this.pbDrinks.Name = "pbDrinks";
            this.pbDrinks.Size = new System.Drawing.Size(65, 64);
            this.pbDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrinks.TabIndex = 2;
            this.pbDrinks.TabStop = false;
            // 
            // nudBread
            // 
            this.nudBread.Location = new System.Drawing.Point(151, 302);
            this.nudBread.Name = "nudBread";
            this.nudBread.ReadOnly = true;
            this.nudBread.Size = new System.Drawing.Size(120, 22);
            this.nudBread.TabIndex = 3;
            this.nudBread.ValueChanged += new System.EventHandler(this.nudBread_ValueChanged);
            // 
            // nudVegetables
            // 
            this.nudVegetables.Location = new System.Drawing.Point(151, 64);
            this.nudVegetables.Name = "nudVegetables";
            this.nudVegetables.ReadOnly = true;
            this.nudVegetables.Size = new System.Drawing.Size(120, 22);
            this.nudVegetables.TabIndex = 4;
            this.nudVegetables.ValueChanged += new System.EventHandler(this.nudVegetables_ValueChanged);
            // 
            // nudDrinks
            // 
            this.nudDrinks.Location = new System.Drawing.Point(151, 172);
            this.nudDrinks.Name = "nudDrinks";
            this.nudDrinks.ReadOnly = true;
            this.nudDrinks.Size = new System.Drawing.Size(120, 22);
            this.nudDrinks.TabIndex = 5;
            this.nudDrinks.ValueChanged += new System.EventHandler(this.nudDrinks_ValueChanged);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(508, 326);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(103, 23);
            this.btnSimulate.TabIndex = 6;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // btnStartDelivery
            // 
            this.btnStartDelivery.Enabled = false;
            this.btnStartDelivery.Location = new System.Drawing.Point(508, 364);
            this.btnStartDelivery.Name = "btnStartDelivery";
            this.btnStartDelivery.Size = new System.Drawing.Size(103, 23);
            this.btnStartDelivery.TabIndex = 7;
            this.btnStartDelivery.Text = "Start delivery";
            this.btnStartDelivery.UseVisualStyleBackColor = true;
            this.btnStartDelivery.Click += new System.EventHandler(this.btnStartDelivery_Click);
            // 
            // lblSimulationAns
            // 
            this.lblSimulationAns.AutoSize = true;
            this.lblSimulationAns.Location = new System.Drawing.Point(299, 38);
            this.lblSimulationAns.Name = "lblSimulationAns";
            this.lblSimulationAns.Size = new System.Drawing.Size(46, 17);
            this.lblSimulationAns.TabIndex = 8;
            this.lblSimulationAns.Text = "label1";
            this.lblSimulationAns.Visible = false;
            // 
            // DeliverySimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 399);
            this.Controls.Add(this.lblSimulationAns);
            this.Controls.Add(this.btnStartDelivery);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.nudDrinks);
            this.Controls.Add(this.nudVegetables);
            this.Controls.Add(this.nudBread);
            this.Controls.Add(this.pbDrinks);
            this.Controls.Add(this.pbVegetables);
            this.Controls.Add(this.pbBread);
            this.Name = "DeliverySimulation";
            this.Text = "DeliverySimulation";
            this.Load += new System.EventHandler(this.DeliverySimulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVegetables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVegetables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBread;
        private System.Windows.Forms.PictureBox pbVegetables;
        private System.Windows.Forms.PictureBox pbDrinks;
        private System.Windows.Forms.NumericUpDown nudBread;
        private System.Windows.Forms.NumericUpDown nudVegetables;
        private System.Windows.Forms.NumericUpDown nudDrinks;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Button btnStartDelivery;
        private System.Windows.Forms.Label lblSimulationAns;
    }
}