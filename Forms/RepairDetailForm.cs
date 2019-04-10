using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepairPlanning.Models;
using RepairPlanning.Util;

namespace RepairPlanning.Forms
{
    public partial class RepairDetailForm : Form
    {
        private const int ItemsAmountOfColumns = 7;
        private const int MastersAmountOfColumns = 6;

        private readonly Form _listRepairsForm;
        private readonly Repair _repair;

        private double _unityItemsPrice;
        private int _unityItemsAmount;
        private double _unityMastersPrice;
        private int _unityMastersAmount;

        private int _currentAmountItems;
        private int _currentAmountMasters;
        private Tuple<double, int> totalItems;
        private Tuple<double, int> totalMasters;

        public RepairDetailForm(Form listRepairsForm, Repair repair)
        {
            InitializeComponent();

            _listRepairsForm = listRepairsForm;
            _repair = repair;
            LoadRepairData();
            LoadRepairItems();
            LoadRepairMasters();
        }

        private void LoadRepairData()
        {
            textBoxNotes.Text = _repair.Notes;
            labelRepairName.Text = new StringBuilder().Append(_repair.NameRepair).Append(" (").Append(_repair.TypeRepair.Name).Append(")").ToString();
            labelStartDate.Text = new StringBuilder().Append("От ").Append(_repair.StartDate.ToShortDateString()).ToString();
            labelExpirationDate.Text = new StringBuilder().Append("До ").Append(_repair.ExpirationDate.ToShortDateString()).ToString();
        }

        private void LoadRepairItems()
        {
            dataGridViewItems.Rows.Clear();
            dataGridViewItems.Columns.Clear();

            for (var x = 0; x < ItemsAmountOfColumns; x++)
            {
                var column = new DataGridViewTextBoxColumn();
                dataGridViewItems.Columns.Add(column);
            }

            _unityItemsPrice = 0;
            _unityItemsAmount = 0;

            using (var db = new ModelsContext())
            {
                db.Items.ToList();
                db.Shops.ToList();
                db.TypeItems.ToList();

                foreach (var repairItem in db.RepairItems.Where(x => x.RepairId == _repair.Id))
                {
                    var currentTotalAmount = repairItem.Item.Price * repairItem.AmountItem;
                    _unityItemsPrice += currentTotalAmount;
                    _unityItemsAmount += repairItem.AmountItem;

                    dataGridViewItems.Rows.Add(repairItem.Id, repairItem.Item.Name,
                        repairItem.Item.Shop.Name, repairItem.Item.TypeItem.Name, repairItem.Item.Price,
                        repairItem.AmountItem, currentTotalAmount);
                }
            }

            dataGridViewItems.Columns[0].Visible = false;

            dataGridViewItems.Columns[1].Width = 200;
            dataGridViewItems.Columns[1].HeaderText = "Предмет";

            dataGridViewItems.Columns[2].Width = 130;
            dataGridViewItems.Columns[2].HeaderText = "Магазин";

            dataGridViewItems.Columns[3].Width = 130;
            dataGridViewItems.Columns[3].HeaderText = "Тип предмета";

            dataGridViewItems.Columns[4].Width = 100;
            dataGridViewItems.Columns[4].HeaderText = "Цена за 1 шт.";

            dataGridViewItems.Columns[5].Width = 50;
            dataGridViewItems.Columns[5].HeaderText = "Кол-во";

            dataGridViewItems.Columns[6].Width = 120;
            dataGridViewItems.Columns[6].HeaderText = "Итоговая цена";

            labelItemUnityAmount.Text = new StringBuilder().Append("Общее кол-во предметов: ").Append(_unityItemsAmount).Append(", общая цена: ").Append(_unityItemsPrice).ToString();
        }

        private void LoadRepairMasters()
        {
            dataGridViewMasters.Rows.Clear();
            dataGridViewMasters.Columns.Clear();

            for (var x = 0; x < MastersAmountOfColumns; x++)
            {
                var column = new DataGridViewTextBoxColumn();
                dataGridViewMasters.Columns.Add(column);
            }

            _unityMastersPrice = 0;
            _unityMastersAmount = 0;

            using (var db = new ModelsContext())
            {
                db.Masters.ToList();

                foreach (var repairMaster in db.RepairMasters.Where(x => x.RepairId == _repair.Id))
                {
                    var currentTotalAmount = repairMaster.Master.Price * repairMaster.DaysOfWork;
                    _unityMastersPrice += currentTotalAmount;
                    _unityMastersAmount += repairMaster.DaysOfWork;

                    dataGridViewMasters.Rows.Add(repairMaster.Id, repairMaster.Master.Name,
                        repairMaster.Master.PhoneNumber, repairMaster.Master.Price, repairMaster.DaysOfWork,
                        currentTotalAmount);
                }
            }

            dataGridViewMasters.Columns[0].Visible = false;

            dataGridViewMasters.Columns[1].Width = 250;
            dataGridViewMasters.Columns[1].HeaderText = "Название";

            dataGridViewMasters.Columns[2].Width = 150;
            dataGridViewMasters.Columns[2].HeaderText = "Телефон";

            dataGridViewMasters.Columns[3].Width = 100;
            dataGridViewMasters.Columns[3].HeaderText = "Цена за день";

            dataGridViewMasters.Columns[4].Width = 80;
            dataGridViewMasters.Columns[4].HeaderText = "Кол-во дней.";

            dataGridViewMasters.Columns[5].Width = 150;
            dataGridViewMasters.Columns[5].HeaderText = "Итоговая цена";

            labelMasterUnityAmount.Text = new StringBuilder().Append("Общая продолжительность работы (в днях): ").Append(_unityMastersAmount).Append(", общая цена: ").Append(_unityMastersPrice).ToString();
        }

        private void RepairDetailForm_FormClosing(object sender, FormClosingEventArgs e) => 
            _listRepairsForm.Show();

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            Application.Exit();

        private void helperToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            Helpers.StartupHelper();

        private void aboutProgramToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var aboutProgram = new AboutProgram();
            aboutProgram.ShowDialog(this);
        }

        private void редактироватьРемонтToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var editRepairForm = new EditRepairForm(StartupTypeForm.Редактирование, _repair.Id);
            editRepairForm.ShowDialog(this);
            LoadRepairData();
        }

        private void itemsToolStripMenuItemExcel_Click(object sender, System.EventArgs e) => 
            Export.ToExcel(dataGridViewItems);

        private void mastersToolStripMenuItemExcel_Click(object sender, System.EventArgs e) => 
            Export.ToExcel(dataGridViewMasters);

        private void itemsToolStripMenuItemWord_Click(object sender, System.EventArgs e) => 
            Export.ToWord(dataGridViewItems);

        private void mastersToolStripMenuItemWord_Click(object sender, System.EventArgs e) => 
            Export.ToWord(dataGridViewMasters);

        private void buttonAddItem_Click(object sender, System.EventArgs e)
        {
            var midContainerForm = new MidContainerForm(this, _repair, StartupTypeForm.Предметы,
                new List<double> {_unityItemsPrice, _unityMastersPrice},
                    new List<int> {_unityItemsAmount, _unityMastersAmount});
            midContainerForm.ShowDialog(this);
            LoadRepairItems();
            LoadRepairMasters();
        }

        private void removeRepairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(
                    "Удалить ремонт?",
                    "Подтвердите действие", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (var db = new ModelsContext())
                {
                    var idRepair = _repair.Id;

                    var repirItem = db.RepairItems.FirstOrDefault(x => x.RepairId == idRepair);
                    var repirMaster = db.RepairMasters.FirstOrDefault(x => x.RepairId == idRepair);
                    if (repirItem != null || repirMaster != null)
                    {
                        if (MessageBox.Show(
                                "Ремонт заполнен предметами и/или местерами. Все равно удалить?",
                                "Действительно удалить?", MessageBoxButtons.OKCancel) != DialogResult.OK)
                        {
                            return;
                        }
                    }

                    var currentRepair = db.Repairs.FirstOrDefault(x => x.Id == idRepair);
                    if (currentRepair != null)
                    {
                        db.Repairs.Remove(currentRepair);
                        db.SaveChanges();
                        Close();
                        return;
                    }

                    MessageBox.Show("Удаление невозможно в силу непредвиденных обстоятельств.");
                }
            }
        }

        private void buttonAddMaster_Click(object sender, System.EventArgs e)
        {
            var midContainerForm = new MidContainerForm(this, _repair, StartupTypeForm.Мастера,
                new List<double> { _unityItemsPrice, _unityMastersPrice },
                    new List<int> { _unityItemsAmount, _unityMastersAmount });
            midContainerForm.ShowDialog(this);
            LoadRepairItems();
            LoadRepairMasters();
        }

        private void buttonEditItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                var currentItemRepairId = dataGridViewItems.CurrentRow.Cells[0].Value.ToString();

                var inputBox = new InputBox.InputBox("Количество предметов", "Введите количество: ", dataGridViewItems.CurrentRow.Cells[5].Value.ToString(), true);

                var valueInputBox = inputBox.ToString();
                if (string.IsNullOrEmpty(valueInputBox) || int.Parse(valueInputBox) == 0)
                {
                    buttonRemoveItem_Click(sender, e);
                    return;
                }

                using (var db = new ModelsContext())
                {
                    var itemRepairId = int.Parse(currentItemRepairId);
                    var amountItem = int.Parse(valueInputBox);

                    var repairItem = db.RepairItems.FirstOrDefault(x => x.Id == itemRepairId);
                    repairItem.AmountItem = amountItem;

                    db.SaveChanges();
                }

                LoadRepairItems();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выделите строку для редактирования предмета.");
            }
        }

        private void buttonRemoveItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dataGridViewItems.SelectedRows.Count > 1)
                {
                    DeleteItemRows();
                    return;
                }

                var currentItemRepairId = dataGridViewItems.CurrentRow.Cells[0].Value.ToString();
                var repairItemId = int.Parse(currentItemRepairId);
                if (MessageBox.Show("Действительно удалить предметы?",
                        "Подтвердите действие", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                using (var db = new ModelsContext())
                {
                    var repairItem = db.RepairItems.First(x => x.Id == repairItemId);
                    db.RepairItems.Remove(repairItem);
                    db.SaveChanges();
                }

                LoadRepairItems();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выделите строку для редактирования предмета.");
            }
        }

        private void buttonEditMaster_Click(object sender, System.EventArgs e)
        {
            try
            {
                var currentMasterRepairId = dataGridViewMasters.CurrentRow.Cells[0].Value.ToString();

                var inputBox = new InputBox.InputBox("Количество дней работы", "Введите количество: ", dataGridViewMasters.CurrentRow.Cells[4].Value.ToString(), true);

                var valueInputBox = inputBox.ToString();
                if (string.IsNullOrEmpty(valueInputBox) || int.Parse(valueInputBox) == 0)
                {
                    buttonRemoveMaster_Click(sender, e);
                    return;
                }

                using (var db = new ModelsContext())
                {
                    var masterRepairId = int.Parse(currentMasterRepairId);
                    var dayOfWorks = int.Parse(valueInputBox);

                    var repairMaster = db.RepairMasters.FirstOrDefault(x => x.Id == masterRepairId);
                    repairMaster.DaysOfWork = dayOfWorks;

                    db.SaveChanges();
                }

                LoadRepairMasters();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выделите строку для редактирования предмета.");
            }
        }

        private void buttonRemoveMaster_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dataGridViewMasters.SelectedRows.Count > 1)
                {
                    DeleteMasterRows();
                    return;
                }

                var currentMasterRepairId = dataGridViewMasters.CurrentRow.Cells[0].Value.ToString();
                var masterRepairId = int.Parse(currentMasterRepairId);
                if (MessageBox.Show("Действительно удалить мастеров?",
                        "Подтвердите действие", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                using (var db = new ModelsContext())
                {
                    var repairMaster = db.RepairMasters.First(x => x.Id == masterRepairId);
                    db.RepairMasters.Remove(repairMaster);
                    db.SaveChanges();
                }

                LoadRepairMasters();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выделите строку для редактирования предмета.");
            }
        }

        private void dataGridViewItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (dataGridViewItems.SelectedRows.Count > 1)
                {
                    DeleteItemRows();
                    e.Cancel = true;
                    return;
                }

                var currentItemRepairId = dataGridViewItems.CurrentRow.Cells[0].Value.ToString();

                var repairItemId = int.Parse(currentItemRepairId);
                if (MessageBox.Show("Действительно удалить предметы?",
                        "Подтвердите действие", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }

                using (var db = new ModelsContext())
                {
                    var repairItem = db.RepairItems.First(x => x.Id == repairItemId);
                    db.RepairItems.Remove(repairItem);
                    db.SaveChanges();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выделите строку для редактирования предмета.");
            }
        }

        private void dataGridViewItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 5)
            {
                e.Cancel = true;
            }

            _currentAmountItems = int.Parse(dataGridViewItems.CurrentRow.Cells[5].Value.ToString());
        }

        private void dataGridViewItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentCellValue = dataGridViewItems.CurrentCell.Value;
            if (currentCellValue == null || string.IsNullOrEmpty(currentCellValue.ToString()) || int.Parse(currentCellValue.ToString()) == 0)
            {
                dataGridViewItems.CurrentCell.Value = _currentAmountItems;
                return;
            }

            using (var db = new ModelsContext())
            {
                var repairItemId = int.Parse(dataGridViewItems.CurrentRow.Cells[0].Value.ToString());
                var repairItem = db.RepairItems.First(x => x.Id == repairItemId);

                var newAmount = int.Parse(dataGridViewItems.CurrentCell.Value.ToString());
                
                repairItem.AmountItem = newAmount;

                db.SaveChanges();
            }

            LoadRepairItems();
        }

        private void dataGridViewItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= Column_KeyPress;
            if (dataGridViewItems.CurrentCell.ColumnIndex == 5) 
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress += Column_KeyPress;
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewMasters_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                e.Cancel = true;
            }

            _currentAmountMasters = int.Parse(dataGridViewMasters.CurrentRow.Cells[4].Value.ToString());
        }

        private void dataGridViewMasters_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentCellValue = dataGridViewMasters.CurrentCell.Value;
            if (currentCellValue == null || string.IsNullOrEmpty(currentCellValue.ToString()) || int.Parse(currentCellValue.ToString()) == 0)
            {
                dataGridViewMasters.CurrentCell.Value = _currentAmountMasters;
                return;
            }

            using (var db = new ModelsContext())
            {
                var repairMasterId = int.Parse(dataGridViewMasters.CurrentRow.Cells[0].Value.ToString());
                var repairMaster = db.RepairMasters.First(x => x.Id == repairMasterId);

                var newDayOfWorks = int.Parse(dataGridViewMasters.CurrentCell.Value.ToString());

                repairMaster.DaysOfWork = newDayOfWorks;

                db.SaveChanges();
            }

            LoadRepairMasters();
        }

        private void dataGridViewMasters_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= Column_KeyPress;
            if (dataGridViewMasters.CurrentCell.ColumnIndex == 4)
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress += Column_KeyPress;
                }
            }
        }

        private void dataGridViewItems_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowToolTipItem(e);
        }

        private void ShowToolTipItem(DataGridViewCellEventArgs e)
        {
            switch (dataGridViewItems.CurrentCell.ColumnIndex)
            {
                case 2:
                {
                    var cellDisplayRect = dataGridViewItems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    var shopName = dataGridViewItems.CurrentCell.Value.ToString();
                    using (var db = new ModelsContext())
                    {
                        var shop = db.Shops.First(x => x.Name.Contains(shopName));

                        toolTip.Show(
                            new StringBuilder().Append("Адрес: ").Append(shop.Address).Append("\nТелефон: ")
                                .Append(shop.PhoneNumber).ToString(),
                            dataGridViewItems,
                            cellDisplayRect.X + dataGridViewItems.CurrentCell.Size.Width / 2,
                            cellDisplayRect.Y + dataGridViewItems.CurrentCell.Size.Height / 2,
                            2000);
                        dataGridViewItems.ShowCellToolTips = false;
                    }

                    break;
                }
                case 1:
                {
                    var cellDisplayRect = dataGridViewItems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    var nameItem = dataGridViewItems.CurrentCell.Value.ToString();
                    using (var db = new ModelsContext())
                    {
                        var item = db.Items.First(x => x.Name.Contains(nameItem));

                        toolTip.Show(
                            new StringBuilder().Append("Описание: ").Append(item.Description).ToString(),
                            dataGridViewItems,
                            cellDisplayRect.X + dataGridViewItems.CurrentCell.Size.Width / 2,
                            cellDisplayRect.Y + dataGridViewItems.CurrentCell.Size.Height / 2,
                            2000);
                        dataGridViewItems.ShowCellToolTips = false;
                    }

                    break;
                }
            }
        }

        private void dataGridViewMasters_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (dataGridViewMasters.SelectedRows.Count > 1)
                {
                    DeleteMasterRows();
                    e.Cancel = true;
                    return;
                }

                var currentMasterRepairId = dataGridViewMasters.CurrentRow.Cells[0].Value.ToString();

                var repairMasterId = int.Parse(currentMasterRepairId);
                if (MessageBox.Show("Действительно удалить мастера?",
                        "Подтвердите действие", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
                
                using (var db = new ModelsContext())
                {
                    var repairMaster = db.RepairMasters.First(x => x.Id == repairMasterId);
                    db.RepairMasters.Remove(repairMaster);
                    db.SaveChanges();

                    LoadRepairMasters();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выделите строку для редактирования предмета.");
            }
        }

        private void DeleteMasterRows()
        {
            if (MessageBox.Show("Действительно удалить выделенных мастеров?",
                    "Подтвердите действие", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            try
            {
                foreach (DataGridViewRow dataGridViewRow in dataGridViewMasters.SelectedRows)
                {
                    var currentMasterRepairId = dataGridViewRow.Cells[0].Value.ToString();

                    var repairMasterId = int.Parse(currentMasterRepairId);

                    using (var db = new ModelsContext())
                    {
                        var repairMaster = db.RepairMasters.First(x => x.Id == repairMasterId);
                        db.RepairMasters.Remove(repairMaster);
                        db.SaveChanges();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }

            LoadRepairMasters();
        }

        private void DeleteItemRows()
        {
            if (MessageBox.Show("Действительно удалить выделенные предметы?",
                    "Подтвердите действие", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            try
            {
                foreach (DataGridViewRow dataGridViewRow in dataGridViewItems.SelectedRows)
                {
                    var currentItemRepairId = dataGridViewRow.Cells[0].Value.ToString();

                    var repairItemId = int.Parse(currentItemRepairId);

                    using (var db = new ModelsContext())
                    {
                        var repairItem = db.RepairItems.First(x => x.Id == repairItemId);
                        db.RepairItems.Remove(repairItem);
                        db.SaveChanges();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }

            LoadRepairItems();
        }
    }
}
