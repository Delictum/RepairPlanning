namespace RepairPlanning.Forms
{
    partial class RepairDetailForm
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
            this.labelRepairName = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.contextMenuStripItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelItem = new System.Windows.Forms.Label();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonEditItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonAddMaster = new System.Windows.Forms.Button();
            this.buttonEditMaster = new System.Windows.Forms.Button();
            this.buttonRemoveMaster = new System.Windows.Forms.Button();
            this.labelMaster = new System.Windows.Forms.Label();
            this.dataGridViewMasters = new System.Windows.Forms.DataGridView();
            this.contextMenuStripMasters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelItemUnityAmount = new System.Windows.Forms.Label();
            this.labelMasterUnityAmount = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.редактироватьРемонтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.mastersToolStripMenuItemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.mastersToolStripMenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.contextMenuStripItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).BeginInit();
            this.contextMenuStripMasters.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRepairName
            // 
            this.labelRepairName.AutoSize = true;
            this.labelRepairName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepairName.Location = new System.Drawing.Point(7, 24);
            this.labelRepairName.Name = "labelRepairName";
            this.labelRepairName.Size = new System.Drawing.Size(87, 29);
            this.labelRepairName.TabIndex = 0;
            this.labelRepairName.Text = "label1";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNotes.Location = new System.Drawing.Point(12, 56);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ReadOnly = true;
            this.textBoxNotes.Size = new System.Drawing.Size(652, 44);
            this.textBoxNotes.TabIndex = 1;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartDate.Location = new System.Drawing.Point(670, 56);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(35, 13);
            this.labelStartDate.TabIndex = 2;
            this.labelStartDate.Text = "label1";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpirationDate.Location = new System.Drawing.Point(670, 87);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(35, 13);
            this.labelExpirationDate.TabIndex = 3;
            this.labelExpirationDate.Text = "label1";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.ContextMenuStrip = this.contextMenuStripItems;
            this.dataGridViewItems.Location = new System.Drawing.Point(12, 132);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(776, 281);
            this.dataGridViewItems.TabIndex = 4;
            this.dataGridViewItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewItems_CellBeginEdit);
            this.dataGridViewItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellEndEdit);
            this.dataGridViewItems.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellEnter);
            this.dataGridViewItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewItems_EditingControlShowing);
            this.dataGridViewItems.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewItems_UserDeletingRow);
            // 
            // contextMenuStripItems
            // 
            this.contextMenuStripItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemsToolStripMenuItem,
            this.editItemsToolStripMenuItem,
            this.removeItemsToolStripMenuItem});
            this.contextMenuStripItems.Name = "contextMenuStripItems";
            this.contextMenuStripItems.Size = new System.Drawing.Size(129, 70);
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addItemsToolStripMenuItem.Text = "Добавить";
            this.addItemsToolStripMenuItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // editItemsToolStripMenuItem
            // 
            this.editItemsToolStripMenuItem.Name = "editItemsToolStripMenuItem";
            this.editItemsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editItemsToolStripMenuItem.Text = "Изменить";
            this.editItemsToolStripMenuItem.Click += new System.EventHandler(this.buttonEditItem_Click);
            // 
            // removeItemsToolStripMenuItem
            // 
            this.removeItemsToolStripMenuItem.Name = "removeItemsToolStripMenuItem";
            this.removeItemsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.removeItemsToolStripMenuItem.Text = "Удалить";
            this.removeItemsToolStripMenuItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItem.Location = new System.Drawing.Point(12, 109);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(98, 20);
            this.labelItem.TabIndex = 5;
            this.labelItem.Text = "Предметы";
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(713, 106);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveItem.TabIndex = 6;
            this.buttonRemoveItem.Text = "Удалить";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonEditItem
            // 
            this.buttonEditItem.Location = new System.Drawing.Point(632, 106);
            this.buttonEditItem.Name = "buttonEditItem";
            this.buttonEditItem.Size = new System.Drawing.Size(75, 23);
            this.buttonEditItem.TabIndex = 7;
            this.buttonEditItem.Text = "Изменить";
            this.buttonEditItem.UseVisualStyleBackColor = true;
            this.buttonEditItem.Click += new System.EventHandler(this.buttonEditItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(551, 106);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItem.TabIndex = 8;
            this.buttonAddItem.Text = "Добавить";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonAddMaster
            // 
            this.buttonAddMaster.Location = new System.Drawing.Point(551, 419);
            this.buttonAddMaster.Name = "buttonAddMaster";
            this.buttonAddMaster.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMaster.TabIndex = 13;
            this.buttonAddMaster.Text = "Добавить";
            this.buttonAddMaster.UseVisualStyleBackColor = true;
            this.buttonAddMaster.Click += new System.EventHandler(this.buttonAddMaster_Click);
            // 
            // buttonEditMaster
            // 
            this.buttonEditMaster.Location = new System.Drawing.Point(632, 419);
            this.buttonEditMaster.Name = "buttonEditMaster";
            this.buttonEditMaster.Size = new System.Drawing.Size(75, 23);
            this.buttonEditMaster.TabIndex = 12;
            this.buttonEditMaster.Text = "Изменить";
            this.buttonEditMaster.UseVisualStyleBackColor = true;
            this.buttonEditMaster.Click += new System.EventHandler(this.buttonEditMaster_Click);
            // 
            // buttonRemoveMaster
            // 
            this.buttonRemoveMaster.Location = new System.Drawing.Point(713, 419);
            this.buttonRemoveMaster.Name = "buttonRemoveMaster";
            this.buttonRemoveMaster.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveMaster.TabIndex = 11;
            this.buttonRemoveMaster.Text = "Удалить";
            this.buttonRemoveMaster.UseVisualStyleBackColor = true;
            this.buttonRemoveMaster.Click += new System.EventHandler(this.buttonRemoveMaster_Click);
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaster.Location = new System.Drawing.Point(12, 425);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(122, 20);
            this.labelMaster.TabIndex = 10;
            this.labelMaster.Text = "Специалисты";
            // 
            // dataGridViewMasters
            // 
            this.dataGridViewMasters.AllowUserToAddRows = false;
            this.dataGridViewMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasters.ContextMenuStrip = this.contextMenuStripMasters;
            this.dataGridViewMasters.Location = new System.Drawing.Point(12, 448);
            this.dataGridViewMasters.Name = "dataGridViewMasters";
            this.dataGridViewMasters.Size = new System.Drawing.Size(776, 141);
            this.dataGridViewMasters.TabIndex = 9;
            this.dataGridViewMasters.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewMasters_CellBeginEdit);
            this.dataGridViewMasters.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMasters_CellEndEdit);
            this.dataGridViewMasters.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewMasters_EditingControlShowing);
            this.dataGridViewMasters.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewMasters_UserDeletingRow);
            // 
            // contextMenuStripMasters
            // 
            this.contextMenuStripMasters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMastersToolStripMenuItem,
            this.editMastersToolStripMenuItem,
            this.removeMastersToolStripMenuItem});
            this.contextMenuStripMasters.Name = "contextMenuStripItems";
            this.contextMenuStripMasters.Size = new System.Drawing.Size(129, 70);
            // 
            // addMastersToolStripMenuItem
            // 
            this.addMastersToolStripMenuItem.Name = "addMastersToolStripMenuItem";
            this.addMastersToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addMastersToolStripMenuItem.Text = "Добавить";
            this.addMastersToolStripMenuItem.Click += new System.EventHandler(this.buttonAddMaster_Click);
            // 
            // editMastersToolStripMenuItem
            // 
            this.editMastersToolStripMenuItem.Name = "editMastersToolStripMenuItem";
            this.editMastersToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editMastersToolStripMenuItem.Text = "Изменить";
            this.editMastersToolStripMenuItem.Click += new System.EventHandler(this.buttonEditMaster_Click);
            // 
            // removeMastersToolStripMenuItem
            // 
            this.removeMastersToolStripMenuItem.Name = "removeMastersToolStripMenuItem";
            this.removeMastersToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.removeMastersToolStripMenuItem.Text = "Удалить";
            this.removeMastersToolStripMenuItem.Click += new System.EventHandler(this.buttonRemoveMaster_Click);
            // 
            // labelItemUnityAmount
            // 
            this.labelItemUnityAmount.AutoSize = true;
            this.labelItemUnityAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItemUnityAmount.Location = new System.Drawing.Point(170, 116);
            this.labelItemUnityAmount.Name = "labelItemUnityAmount";
            this.labelItemUnityAmount.Size = new System.Drawing.Size(35, 13);
            this.labelItemUnityAmount.TabIndex = 14;
            this.labelItemUnityAmount.Text = "label1";
            // 
            // labelMasterUnityAmount
            // 
            this.labelMasterUnityAmount.AutoSize = true;
            this.labelMasterUnityAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMasterUnityAmount.Location = new System.Drawing.Point(170, 432);
            this.labelMasterUnityAmount.Name = "labelMasterUnityAmount";
            this.labelMasterUnityAmount.Size = new System.Drawing.Size(35, 13);
            this.labelMasterUnityAmount.TabIndex = 15;
            this.labelMasterUnityAmount.Text = "label1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.toolStripSeparator1,
            this.редактироватьРемонтToolStripMenuItem,
            this.removeRepairToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.programToolStripMenuItem.Text = "Программа";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem,
            this.addNewMasterToolStripMenuItem});
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.addNewToolStripMenuItem.Text = "Добавить...";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addNewItemToolStripMenuItem.Text = "Предметы";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // addNewMasterToolStripMenuItem
            // 
            this.addNewMasterToolStripMenuItem.Name = "addNewMasterToolStripMenuItem";
            this.addNewMasterToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addNewMasterToolStripMenuItem.Text = "Мастеров";
            this.addNewMasterToolStripMenuItem.Click += new System.EventHandler(this.buttonAddMaster_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // редактироватьРемонтToolStripMenuItem
            // 
            this.редактироватьРемонтToolStripMenuItem.Name = "редактироватьРемонтToolStripMenuItem";
            this.редактироватьРемонтToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.редактироватьРемонтToolStripMenuItem.Text = "Редактировать ремонт";
            this.редактироватьРемонтToolStripMenuItem.Click += new System.EventHandler(this.редактироватьРемонтToolStripMenuItem_Click);
            // 
            // removeRepairToolStripMenuItem
            // 
            this.removeRepairToolStripMenuItem.Name = "removeRepairToolStripMenuItem";
            this.removeRepairToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.removeRepairToolStripMenuItem.Text = "Удалить ремонт";
            this.removeRepairToolStripMenuItem.Click += new System.EventHandler(this.removeRepairToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.exportToolStripMenuItem.Text = "Экспорт";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItemWord,
            this.mastersToolStripMenuItemWord});
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wordToolStripMenuItem.Text = "Word";
            // 
            // itemsToolStripMenuItemWord
            // 
            this.itemsToolStripMenuItemWord.Name = "itemsToolStripMenuItemWord";
            this.itemsToolStripMenuItemWord.Size = new System.Drawing.Size(144, 22);
            this.itemsToolStripMenuItemWord.Text = "Предметов...";
            this.itemsToolStripMenuItemWord.Click += new System.EventHandler(this.itemsToolStripMenuItemWord_Click);
            // 
            // mastersToolStripMenuItemWord
            // 
            this.mastersToolStripMenuItemWord.Name = "mastersToolStripMenuItemWord";
            this.mastersToolStripMenuItemWord.Size = new System.Drawing.Size(144, 22);
            this.mastersToolStripMenuItemWord.Text = "Мастеров...";
            this.mastersToolStripMenuItemWord.Click += new System.EventHandler(this.mastersToolStripMenuItemWord_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItemExcel,
            this.mastersToolStripMenuItemExcel});
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // itemsToolStripMenuItemExcel
            // 
            this.itemsToolStripMenuItemExcel.Name = "itemsToolStripMenuItemExcel";
            this.itemsToolStripMenuItemExcel.Size = new System.Drawing.Size(144, 22);
            this.itemsToolStripMenuItemExcel.Text = "Предметов...";
            this.itemsToolStripMenuItemExcel.Click += new System.EventHandler(this.itemsToolStripMenuItemExcel_Click);
            // 
            // mastersToolStripMenuItemExcel
            // 
            this.mastersToolStripMenuItemExcel.Name = "mastersToolStripMenuItemExcel";
            this.mastersToolStripMenuItemExcel.Size = new System.Drawing.Size(144, 22);
            this.mastersToolStripMenuItemExcel.Text = "Мастеров...";
            this.mastersToolStripMenuItemExcel.Click += new System.EventHandler(this.mastersToolStripMenuItemExcel_Click);
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
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 1000;
            // 
            // RepairDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.labelMasterUnityAmount);
            this.Controls.Add(this.labelItemUnityAmount);
            this.Controls.Add(this.buttonAddMaster);
            this.Controls.Add(this.buttonEditMaster);
            this.Controls.Add(this.buttonRemoveMaster);
            this.Controls.Add(this.labelMaster);
            this.Controls.Add(this.dataGridViewMasters);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonEditItem);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelRepairName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RepairDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детальная информация ремонта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RepairDetailForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.contextMenuStripItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).EndInit();
            this.contextMenuStripMasters.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRepairName;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonEditItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonAddMaster;
        private System.Windows.Forms.Button buttonEditMaster;
        private System.Windows.Forms.Button buttonRemoveMaster;
        private System.Windows.Forms.Label labelMaster;
        private System.Windows.Forms.DataGridView dataGridViewMasters;
        private System.Windows.Forms.Label labelItemUnityAmount;
        private System.Windows.Forms.Label labelMasterUnityAmount;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helperToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьРемонтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItemWord;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItemWord;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItemExcel;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItemExcel;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMasterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItems;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMasters;
        private System.Windows.Forms.ToolStripMenuItem addMastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMastersToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
    }
}