namespace View
{
    partial class AddPatientReaserchForm
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
            this.runRadioButton = new System.Windows.Forms.RadioButton();
            this.walkRadioButton = new System.Windows.Forms.RadioButton();
            this.bycicleRadioButton = new System.Windows.Forms.RadioButton();
            this.powerRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.durationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.researchTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.runRadioButton.AutoSize = true;
            this.runRadioButton.Location = new System.Drawing.Point(30, 107);
            this.runRadioButton.Name = "radioButton1";
            this.runRadioButton.Size = new System.Drawing.Size(51, 21);
            this.runRadioButton.TabIndex = 0;
            this.runRadioButton.TabStop = true;
            this.runRadioButton.Text = "Бег";
            this.runRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.walkRadioButton.AutoSize = true;
            this.walkRadioButton.Location = new System.Drawing.Point(30, 134);
            this.walkRadioButton.Name = "radioButton2";
            this.walkRadioButton.Size = new System.Drawing.Size(77, 21);
            this.walkRadioButton.TabIndex = 1;
            this.walkRadioButton.TabStop = true;
            this.walkRadioButton.Text = "Ходьба";
            this.walkRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.bycicleRadioButton.AutoSize = true;
            this.bycicleRadioButton.Location = new System.Drawing.Point(30, 161);
            this.bycicleRadioButton.Name = "radioButton3";
            this.bycicleRadioButton.Size = new System.Drawing.Size(62, 21);
            this.bycicleRadioButton.TabIndex = 2;
            this.bycicleRadioButton.TabStop = true;
            this.bycicleRadioButton.Text = "Вело";
            this.bycicleRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.powerRadioButton.AutoSize = true;
            this.powerRadioButton.Location = new System.Drawing.Point(30, 188);
            this.powerRadioButton.Name = "radioButton4";
            this.powerRadioButton.Size = new System.Drawing.Size(179, 21);
            this.powerRadioButton.TabIndex = 3;
            this.powerRadioButton.TabStop = true;
            this.powerRadioButton.Text = "Силовые упражнениия";
            this.powerRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите тип упражнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите дату исследования";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(30, 51);
            this.dateTimePicker.Name = "dateTimePicker1";
            this.dateTimePicker.Size = new System.Drawing.Size(202, 22);
            this.dateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите продолжительность исследования(в мин.)";
            // 
            // numericUpDown1
            // 
            this.durationNumericUpDown.Location = new System.Drawing.Point(30, 258);
            this.durationNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.durationNumericUpDown.Name = "numericUpDown1";
            this.durationNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.durationNumericUpDown.TabIndex = 8;
            this.durationNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите данные для измерения";
            // 
            // checkedListBox1
            // 
            this.researchTypeCheckedListBox.FormattingEnabled = true;
            this.researchTypeCheckedListBox.Items.AddRange(new object[] {
            "Кровяное давление",
            "Температура кожи",
            "Влажность кожи",
            "Электрическая проводимость кожи",
            "Частота пульса сердечного ритма"});
            this.researchTypeCheckedListBox.Location = new System.Drawing.Point(30, 324);
            this.researchTypeCheckedListBox.Name = "checkedListBox1";
            this.researchTypeCheckedListBox.Size = new System.Drawing.Size(343, 106);
            this.researchTypeCheckedListBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddResearchClick);
            // 
            // AddPatientReaserchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(535, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.researchTypeCheckedListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.durationNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powerRadioButton);
            this.Controls.Add(this.bycicleRadioButton);
            this.Controls.Add(this.walkRadioButton);
            this.Controls.Add(this.runRadioButton);
            this.MaximumSize = new System.Drawing.Size(553, 561);
            this.MinimumSize = new System.Drawing.Size(553, 561);
            this.Name = "AddPatientReaserchForm";
            this.Text = "Добавление исследования паценту";
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton runRadioButton;
        private System.Windows.Forms.RadioButton walkRadioButton;
        private System.Windows.Forms.RadioButton bycicleRadioButton;
        private System.Windows.Forms.RadioButton powerRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown durationNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox researchTypeCheckedListBox;
        private System.Windows.Forms.Button button1;
    }
}