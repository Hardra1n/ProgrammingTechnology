namespace View
{
    partial class PatientInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addResearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientSurNameLabel = new System.Windows.Forms.Label();
            this.patientFatherNameLabel = new System.Windows.Forms.Label();
            this.patientAgeLabel = new System.Windows.Forms.Label();
            this.patientSexLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addResearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addResearchToolStripMenuItem
            // 
            this.addResearchToolStripMenuItem.Name = "addResearchToolStripMenuItem";
            this.addResearchToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.addResearchToolStripMenuItem.Text = "Добавить исследование";
            this.addResearchToolStripMenuItem.Click += new System.EventHandler(this.AddResearchToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пол";
            // 
            // label6
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(371, 63);
            this.patientNameLabel.Name = "label6";
            this.patientNameLabel.Size = new System.Drawing.Size(102, 17);
            this.patientNameLabel.TabIndex = 7;
            this.patientNameLabel.Text = "Имя пациента";
            // 
            // label7
            // 
            this.patientSurNameLabel.AutoSize = true;
            this.patientSurNameLabel.Location = new System.Drawing.Point(371, 110);
            this.patientSurNameLabel.Name = "label7";
            this.patientSurNameLabel.Size = new System.Drawing.Size(137, 17);
            this.patientSurNameLabel.TabIndex = 8;
            this.patientSurNameLabel.Text = "Фамилия пациента";
            // 
            // label8
            // 
            this.patientFatherNameLabel.AutoSize = true;
            this.patientFatherNameLabel.Location = new System.Drawing.Point(371, 157);
            this.patientFatherNameLabel.Name = "label8";
            this.patientFatherNameLabel.Size = new System.Drawing.Size(138, 17);
            this.patientFatherNameLabel.TabIndex = 9;
            this.patientFatherNameLabel.Text = "Отчество пациента";
            // 
            // label9
            // 
            this.patientAgeLabel.AutoSize = true;
            this.patientAgeLabel.Location = new System.Drawing.Point(371, 198);
            this.patientAgeLabel.Name = "label9";
            this.patientAgeLabel.Size = new System.Drawing.Size(129, 17);
            this.patientAgeLabel.TabIndex = 10;
            this.patientAgeLabel.Text = "Возраст пациента";
            // 
            // label10
            // 
            this.patientSexLabel.AutoSize = true;
            this.patientSexLabel.Location = new System.Drawing.Point(372, 242);
            this.patientSexLabel.Name = "label10";
            this.patientSexLabel.Size = new System.Drawing.Size(101, 17);
            this.patientSexLabel.TabIndex = 11;
            this.patientSexLabel.Text = "Пол пациента";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 255);
            this.panel1.TabIndex = 12;
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(555, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientSexLabel);
            this.Controls.Add(this.patientAgeLabel);
            this.Controls.Add(this.patientFatherNameLabel);
            this.Controls.Add(this.patientSurNameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientInfoForm";
            this.Text = "Информация о пациенте";
            this.Load += new System.EventHandler(this.PatientInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addResearchToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientSurNameLabel;
        private System.Windows.Forms.Label patientFatherNameLabel;
        private System.Windows.Forms.Label patientAgeLabel;
        private System.Windows.Forms.Label patientSexLabel;
        private System.Windows.Forms.Panel panel1;
    }
}