namespace RepairPlanning
{
    partial class ListRepairsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRepairsForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCreateRepair = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRepairToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.programToolStripMenuItem.Text = "Программа";
            // 
            // addNewRepairToolStripMenuItem
            // 
            this.addNewRepairToolStripMenuItem.Name = "addNewRepairToolStripMenuItem";
            this.addNewRepairToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewRepairToolStripMenuItem.Text = "Новый ремонт";
            this.addNewRepairToolStripMenuItem.Click += new System.EventHandler(this.buttonCreateRepair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helperToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutProgramToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aboutToolStripMenuItem.Text = "Справка";
            // 
            // helperToolStripMenuItem
            // 
            this.helperToolStripMenuItem.Name = "helperToolStripMenuItem";
            this.helperToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.helperToolStripMenuItem.Text = "Помощь";
            this.helperToolStripMenuItem.Click += new System.EventHandler(this.helperToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutProgramToolStripMenuItem.Text = "О программе...";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // buttonCreateRepair
            // 
            this.buttonCreateRepair.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonCreateRepair.AutoEllipsis = true;
            this.buttonCreateRepair.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonCreateRepair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCreateRepair.BackgroundImage")));
            this.buttonCreateRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateRepair.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateRepair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateRepair.Location = new System.Drawing.Point(12, 27);
            this.buttonCreateRepair.Name = "buttonCreateRepair";
            this.buttonCreateRepair.Size = new System.Drawing.Size(776, 46);
            this.buttonCreateRepair.TabIndex = 5;
            this.buttonCreateRepair.Text = "Создать новый ремонт";
            this.buttonCreateRepair.UseVisualStyleBackColor = false;
            this.buttonCreateRepair.Click += new System.EventHandler(this.buttonCreateRepair_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 79);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 371);
            this.mainPanel.TabIndex = 1;
            // 
            // ListRepairsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateRepair);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListRepairsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Планирование ремонта";
            this.VisibleChanged += new System.EventHandler(this.ListRepairsForm_VisibleChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button buttonCreateRepair;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helperToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}

