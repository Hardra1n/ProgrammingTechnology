namespace View
{
    partial class StartPatientResearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPatientResearchForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startResearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateSensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skinTempLabel = new System.Windows.Forms.Label();
            this.arterialPressLabel = new System.Windows.Forms.Label();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.skinConductLabel = new System.Windows.Forms.Label();
            this.skinMoisureLabel = new System.Windows.Forms.Label();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.researchInfoLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerValueLabel = new System.Windows.Forms.Label();
            this.endMessageLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startResearchToolStripMenuItem,
            this.activateSensorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1316, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startResearchToolStripMenuItem
            // 
            this.startResearchToolStripMenuItem.Name = "startResearchToolStripMenuItem";
            this.startResearchToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.startResearchToolStripMenuItem.Text = "Начать исследование";
            this.startResearchToolStripMenuItem.Click += new System.EventHandler(this.StartResearchToolStripMenuItem_Click);
            // 
            // activateSensorsToolStripMenuItem
            // 
            this.activateSensorsToolStripMenuItem.Name = "activateSensorsToolStripMenuItem";
            this.activateSensorsToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.activateSensorsToolStripMenuItem.Text = "Активировать датчики";
            this.activateSensorsToolStripMenuItem.Click += new System.EventHandler(this.ActivateSensorsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.skinTempLabel.AutoSize = true;
            this.skinTempLabel.Location = new System.Drawing.Point(221, 140);
            this.skinTempLabel.Name = "label1";
            this.skinTempLabel.Size = new System.Drawing.Size(71, 17);
            this.skinTempLabel.TabIndex = 2;
            this.skinTempLabel.Text = "not detect";
            // 
            // label2
            // 
            this.arterialPressLabel.AutoSize = true;
            this.arterialPressLabel.Location = new System.Drawing.Point(48, 105);
            this.arterialPressLabel.Name = "label2";
            this.arterialPressLabel.Size = new System.Drawing.Size(71, 17);
            this.arterialPressLabel.TabIndex = 3;
            this.arterialPressLabel.Text = "not detect";
            // 
            // label3
            // 
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Location = new System.Drawing.Point(233, 206);
            this.pulseLabel.Name = "label3";
            this.pulseLabel.Size = new System.Drawing.Size(71, 17);
            this.pulseLabel.TabIndex = 4;
            this.pulseLabel.Text = "not detect";
            // 
            // label4
            // 
            this.skinConductLabel.AutoSize = true;
            this.skinConductLabel.Location = new System.Drawing.Point(12, 339);
            this.skinConductLabel.Name = "label4";
            this.skinConductLabel.Size = new System.Drawing.Size(71, 17);
            this.skinConductLabel.TabIndex = 5;
            this.skinConductLabel.Text = "not detect";
            // 
            // label5
            // 
            this.skinMoisureLabel.AutoSize = true;
            this.skinMoisureLabel.Location = new System.Drawing.Point(192, 372);
            this.skinMoisureLabel.Name = "label5";
            this.skinMoisureLabel.Size = new System.Drawing.Size(71, 17);
            this.skinMoisureLabel.TabIndex = 6;
            this.skinMoisureLabel.Text = "not detect";
            // 
            // panel1
            // 
            this.graphPanel.Location = new System.Drawing.Point(310, 48);
            this.graphPanel.Name = "panel1";
            this.graphPanel.Size = new System.Drawing.Size(1000, 972);
            this.graphPanel.TabIndex = 7;
            // 
            // label6
            // 
            this.researchInfoLabel.AutoSize = true;
            this.researchInfoLabel.Location = new System.Drawing.Point(9, 555);
            this.researchInfoLabel.Name = "label6";
            this.researchInfoLabel.Size = new System.Drawing.Size(102, 17);
            this.researchInfoLabel.TabIndex = 8;
            this.researchInfoLabel.Text = "-информация-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Информация об исследовании:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Время на таймере:";
            // 
            // label9
            // 
            this.timerValueLabel.AutoSize = true;
            this.timerValueLabel.Location = new System.Drawing.Point(145, 589);
            this.timerValueLabel.Name = "label9";
            this.timerValueLabel.Size = new System.Drawing.Size(42, 17);
            this.timerValueLabel.TabIndex = 11;
            this.timerValueLabel.Text = "0 min";
            // 
            // label10
            // 
            this.endMessageLabel.AutoSize = true;
            this.endMessageLabel.Location = new System.Drawing.Point(12, 626);
            this.endMessageLabel.Name = "label10";
            this.endMessageLabel.Size = new System.Drawing.Size(0, 17);
            this.endMessageLabel.TabIndex = 12;
            // 
            // StartPatientResearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1316, 1032);
            this.Controls.Add(this.endMessageLabel);
            this.Controls.Add(this.timerValueLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.researchInfoLabel);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.skinMoisureLabel);
            this.Controls.Add(this.skinConductLabel);
            this.Controls.Add(this.pulseLabel);
            this.Controls.Add(this.arterialPressLabel);
            this.Controls.Add(this.skinTempLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartPatientResearchForm";
            this.Text = "Исследование";
            this.Load += new System.EventHandler(this.StartPatientResearchForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startResearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateSensorsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label skinTempLabel;
        private System.Windows.Forms.Label arterialPressLabel;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.Label skinConductLabel;
        private System.Windows.Forms.Label skinMoisureLabel;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Label researchInfoLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timerValueLabel;
        private System.Windows.Forms.Label endMessageLabel;
    }
}