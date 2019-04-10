namespace RepairPlanning.Forms
{
    partial class ItemsForm
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNameItem = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.labelShop = new System.Windows.Forms.Label();
            this.labelWarrantyUpTo = new System.Windows.Forms.Label();
            this.comboBoxWarrantyUpTo = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelPriceFrom = new System.Windows.Forms.Label();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.textBoxPriceTo = new System.Windows.Forms.TextBox();
            this.labelPriceTo = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.Location = new System.Drawing.Point(12, 87);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.Size = new System.Drawing.Size(776, 351);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(127, 26);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelNameItem
            // 
            this.labelNameItem.AutoSize = true;
            this.labelNameItem.Location = new System.Drawing.Point(12, 9);
            this.labelNameItem.Name = "labelNameItem";
            this.labelNameItem.Size = new System.Drawing.Size(57, 13);
            this.labelNameItem.TabIndex = 1;
            this.labelNameItem.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(78, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(307, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(448, 5);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(108, 21);
            this.comboBoxShop.TabIndex = 3;
            this.comboBoxShop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxWarrantyUpTo_KeyPress);
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(391, 9);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(51, 13);
            this.labelShop.TabIndex = 4;
            this.labelShop.Text = "Магазин";
            // 
            // labelWarrantyUpTo
            // 
            this.labelWarrantyUpTo.AutoSize = true;
            this.labelWarrantyUpTo.Location = new System.Drawing.Point(562, 9);
            this.labelWarrantyUpTo.Name = "labelWarrantyUpTo";
            this.labelWarrantyUpTo.Size = new System.Drawing.Size(95, 13);
            this.labelWarrantyUpTo.TabIndex = 6;
            this.labelWarrantyUpTo.Text = "Гарантия (в мес.)";
            // 
            // comboBoxWarrantyUpTo
            // 
            this.comboBoxWarrantyUpTo.FormattingEnabled = true;
            this.comboBoxWarrantyUpTo.Items.AddRange(new object[] {
            "Любая",
            "3",
            "6",
            "9",
            "12",
            "18",
            "24",
            "30",
            "36",
            "60"});
            this.comboBoxWarrantyUpTo.Location = new System.Drawing.Point(663, 6);
            this.comboBoxWarrantyUpTo.Name = "comboBoxWarrantyUpTo";
            this.comboBoxWarrantyUpTo.Size = new System.Drawing.Size(44, 21);
            this.comboBoxWarrantyUpTo.TabIndex = 5;
            this.comboBoxWarrantyUpTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxWarrantyUpTo_KeyPress);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 35);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 8;
            this.labelCategory.Text = "Категория";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(78, 32);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(133, 21);
            this.comboBoxCategory.TabIndex = 7;
            this.comboBoxCategory.SelectedValueChanged += new System.EventHandler(this.comboBoxCategory_SelectedValueChanged);
            this.comboBoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxWarrantyUpTo_KeyPress);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(217, 35);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 10;
            this.labelType.Text = "Тип";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Enabled = false;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(249, 32);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(136, 21);
            this.comboBoxType.TabIndex = 9;
            this.comboBoxType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxWarrantyUpTo_KeyPress);
            // 
            // labelPriceFrom
            // 
            this.labelPriceFrom.AutoSize = true;
            this.labelPriceFrom.Location = new System.Drawing.Point(391, 35);
            this.labelPriceFrom.Name = "labelPriceFrom";
            this.labelPriceFrom.Size = new System.Drawing.Size(47, 13);
            this.labelPriceFrom.TabIndex = 11;
            this.labelPriceFrom.Text = "Цена от";
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.Location = new System.Drawing.Point(448, 32);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(108, 20);
            this.textBoxPriceFrom.TabIndex = 12;
            this.textBoxPriceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceFrom_KeyPress);
            // 
            // textBoxPriceTo
            // 
            this.textBoxPriceTo.Location = new System.Drawing.Point(608, 31);
            this.textBoxPriceTo.Name = "textBoxPriceTo";
            this.textBoxPriceTo.Size = new System.Drawing.Size(99, 20);
            this.textBoxPriceTo.TabIndex = 13;
            this.textBoxPriceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceTo_KeyPress);
            // 
            // labelPriceTo
            // 
            this.labelPriceTo.AutoSize = true;
            this.labelPriceTo.Location = new System.Drawing.Point(570, 35);
            this.labelPriceTo.Name = "labelPriceTo";
            this.labelPriceTo.Size = new System.Drawing.Size(19, 13);
            this.labelPriceTo.TabIndex = 14;
            this.labelPriceTo.Text = "до";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(713, 4);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 15;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(713, 29);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(713, 58);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 1000;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelPriceTo);
            this.Controls.Add(this.textBoxPriceTo);
            this.Controls.Add(this.textBoxPriceFrom);
            this.Controls.Add(this.labelPriceFrom);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelWarrantyUpTo);
            this.Controls.Add(this.comboBoxWarrantyUpTo);
            this.Controls.Add(this.labelShop);
            this.Controls.Add(this.comboBoxShop);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNameItem);
            this.Controls.Add(this.dataGridView);
            this.Name = "ItemsForm";
            this.Text = "Предметы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelNameItem;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxShop;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.Label labelWarrantyUpTo;
        private System.Windows.Forms.ComboBox comboBoxWarrantyUpTo;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelPriceFrom;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.TextBox textBoxPriceTo;
        private System.Windows.Forms.Label labelPriceTo;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button button1;
    }
}