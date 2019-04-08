namespace RepairPlanning.Forms
{
    partial class MastersForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.textBoxSpecialization = new System.Windows.Forms.TextBox();
            this.labelExpiarence = new System.Windows.Forms.Label();
            this.comboBoxExpiarence = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelPriceTo = new System.Windows.Forms.Label();
            this.textBoxPriceTo = new System.Windows.Forms.TextBox();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.labelPriceFrom = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.Location = new System.Drawing.Point(12, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(455, 377);
            this.dataGridView.TabIndex = 1;
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Location = new System.Drawing.Point(12, 9);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(86, 13);
            this.labelSpecialization.TabIndex = 2;
            this.labelSpecialization.Text = "Специализация";
            // 
            // textBoxSpecialization
            // 
            this.textBoxSpecialization.Location = new System.Drawing.Point(104, 6);
            this.textBoxSpecialization.Name = "textBoxSpecialization";
            this.textBoxSpecialization.Size = new System.Drawing.Size(180, 20);
            this.textBoxSpecialization.TabIndex = 3;
            // 
            // labelExpiarence
            // 
            this.labelExpiarence.AutoSize = true;
            this.labelExpiarence.Location = new System.Drawing.Point(290, 9);
            this.labelExpiarence.Name = "labelExpiarence";
            this.labelExpiarence.Size = new System.Drawing.Size(33, 13);
            this.labelExpiarence.TabIndex = 4;
            this.labelExpiarence.Text = "Стаж";
            // 
            // comboBoxExpiarence
            // 
            this.comboBoxExpiarence.FormattingEnabled = true;
            this.comboBoxExpiarence.Items.AddRange(new object[] {
            "Любой",
            "1",
            "2",
            "3",
            "5",
            "10",
            "20"});
            this.comboBoxExpiarence.Location = new System.Drawing.Point(329, 5);
            this.comboBoxExpiarence.Name = "comboBoxExpiarence";
            this.comboBoxExpiarence.Size = new System.Drawing.Size(57, 21);
            this.comboBoxExpiarence.TabIndex = 5;
            this.comboBoxExpiarence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxExpiarence_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(293, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(392, 32);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 23;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(392, 3);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 22;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelPriceTo
            // 
            this.labelPriceTo.AutoSize = true;
            this.labelPriceTo.Location = new System.Drawing.Point(165, 35);
            this.labelPriceTo.Name = "labelPriceTo";
            this.labelPriceTo.Size = new System.Drawing.Size(19, 13);
            this.labelPriceTo.TabIndex = 21;
            this.labelPriceTo.Text = "до";
            // 
            // textBoxPriceTo
            // 
            this.textBoxPriceTo.Location = new System.Drawing.Point(190, 32);
            this.textBoxPriceTo.Name = "textBoxPriceTo";
            this.textBoxPriceTo.Size = new System.Drawing.Size(94, 20);
            this.textBoxPriceTo.TabIndex = 20;
            this.textBoxPriceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceTo_KeyPress);
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.Location = new System.Drawing.Point(65, 32);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(94, 20);
            this.textBoxPriceFrom.TabIndex = 19;
            this.textBoxPriceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceFrom_KeyPress);
            // 
            // labelPriceFrom
            // 
            this.labelPriceFrom.AutoSize = true;
            this.labelPriceFrom.Location = new System.Drawing.Point(12, 35);
            this.labelPriceFrom.Name = "labelPriceFrom";
            this.labelPriceFrom.Size = new System.Drawing.Size(47, 13);
            this.labelPriceFrom.TabIndex = 18;
            this.labelPriceFrom.Text = "Цена от";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.detailToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.detailToolStripMenuItem.Text = "Подробнее";
            // 
            // MastersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelPriceTo);
            this.Controls.Add(this.textBoxPriceTo);
            this.Controls.Add(this.textBoxPriceFrom);
            this.Controls.Add(this.labelPriceFrom);
            this.Controls.Add(this.comboBoxExpiarence);
            this.Controls.Add(this.labelExpiarence);
            this.Controls.Add(this.textBoxSpecialization);
            this.Controls.Add(this.labelSpecialization);
            this.Controls.Add(this.dataGridView);
            this.Name = "MastersForm";
            this.Text = "Мастера";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelSpecialization;
        private System.Windows.Forms.TextBox textBoxSpecialization;
        private System.Windows.Forms.Label labelExpiarence;
        private System.Windows.Forms.ComboBox comboBoxExpiarence;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelPriceTo;
        private System.Windows.Forms.TextBox textBoxPriceTo;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.Label labelPriceFrom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
    }
}