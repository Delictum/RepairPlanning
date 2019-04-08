namespace RepairPlanning.Forms
{
    partial class EditRepairForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRepairForm));
            this.labelNameRepair = new System.Windows.Forms.Label();
            this.textBoxNameRepair = new System.Windows.Forms.TextBox();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.comboBoxTypeRepair = new System.Windows.Forms.ComboBox();
            this.labelTypeRepair = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.dateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameRepair
            // 
            this.labelNameRepair.AutoSize = true;
            this.labelNameRepair.BackColor = System.Drawing.SystemColors.Info;
            this.labelNameRepair.Location = new System.Drawing.Point(12, 20);
            this.labelNameRepair.Name = "labelNameRepair";
            this.labelNameRepair.Size = new System.Drawing.Size(103, 13);
            this.labelNameRepair.TabIndex = 0;
            this.labelNameRepair.Text = "Название ремонта";
            // 
            // textBoxNameRepair
            // 
            this.textBoxNameRepair.Location = new System.Drawing.Point(121, 17);
            this.textBoxNameRepair.Name = "textBoxNameRepair";
            this.textBoxNameRepair.Size = new System.Drawing.Size(209, 20);
            this.textBoxNameRepair.TabIndex = 1;
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(336, 17);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(209, 99);
            this.richTextBoxNotes.TabIndex = 2;
            this.richTextBoxNotes.Text = "";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.BackColor = System.Drawing.SystemColors.Info;
            this.labelNotes.Location = new System.Drawing.Point(279, 46);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(51, 13);
            this.labelNotes.TabIndex = 3;
            this.labelNotes.Text = "Заметки";
            // 
            // comboBoxTypeRepair
            // 
            this.comboBoxTypeRepair.FormattingEnabled = true;
            this.comboBoxTypeRepair.Location = new System.Drawing.Point(121, 43);
            this.comboBoxTypeRepair.Name = "comboBoxTypeRepair";
            this.comboBoxTypeRepair.Size = new System.Drawing.Size(152, 21);
            this.comboBoxTypeRepair.TabIndex = 4;
            this.comboBoxTypeRepair.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTypeRepair_KeyPress);
            // 
            // labelTypeRepair
            // 
            this.labelTypeRepair.AutoSize = true;
            this.labelTypeRepair.BackColor = System.Drawing.SystemColors.Info;
            this.labelTypeRepair.Location = new System.Drawing.Point(43, 46);
            this.labelTypeRepair.Name = "labelTypeRepair";
            this.labelTypeRepair.Size = new System.Drawing.Size(72, 13);
            this.labelTypeRepair.TabIndex = 5;
            this.labelTypeRepair.Text = "Тип ремонта";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(121, 70);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 6;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.BackColor = System.Drawing.SystemColors.Info;
            this.labelStartDate.Location = new System.Drawing.Point(25, 76);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(90, 13);
            this.labelStartDate.TabIndex = 7;
            this.labelStartDate.Text = "Начало ремонта";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.BackColor = System.Drawing.SystemColors.Info;
            this.labelExpirationDate.Location = new System.Drawing.Point(7, 102);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(108, 13);
            this.labelExpirationDate.TabIndex = 9;
            this.labelExpirationDate.Text = "Окончание ремонта";
            // 
            // dateTimePickerExpirationDate
            // 
            this.dateTimePickerExpirationDate.Location = new System.Drawing.Point(121, 96);
            this.dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            this.dateTimePickerExpirationDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerExpirationDate.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSave.Location = new System.Drawing.Point(226, 135);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(558, 170);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.dateTimePickerExpirationDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelTypeRepair);
            this.Controls.Add(this.comboBoxTypeRepair);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.richTextBoxNotes);
            this.Controls.Add(this.textBoxNameRepair);
            this.Controls.Add(this.labelNameRepair);
            this.Name = "EditRepairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditRepairForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameRepair;
        private System.Windows.Forms.TextBox textBoxNameRepair;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.ComboBox comboBoxTypeRepair;
        private System.Windows.Forms.Label labelTypeRepair;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpirationDate;
        private System.Windows.Forms.Button buttonSave;
    }
}