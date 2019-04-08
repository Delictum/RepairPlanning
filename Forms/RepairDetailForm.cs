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

                    dataGridViewMasters.Rows.Add(repairMaster.Id, repairMaster.Master.Specialization,
                        repairMaster.Master.PhoneNumber, repairMaster.Master.Price, repairMaster.DaysOfWork,
                        currentTotalAmount);
                }
            }

            dataGridViewMasters.Columns[0].Visible = false;

            dataGridViewMasters.Columns[1].Width = 250;
            dataGridViewMasters.Columns[1].HeaderText = "Специализация";

            dataGridViewMasters.Columns[2].Width = 150;
            dataGridViewMasters.Columns[2].HeaderText = "Телефон";

            dataGridViewMasters.Columns[3].Width = 100;
            dataGridViewMasters.Columns[3].HeaderText = "Цена за день";

            dataGridViewMasters.Columns[4].Width = 80;
            dataGridViewMasters.Columns[4].HeaderText = "Кол-во дней.";

            dataGridViewMasters.Columns[5].Width = 150;
            dataGridViewMasters.Columns[5].HeaderText = "Итоговая цена";

            labelMasterUnityAmount.Text = new StringBuilder().Append("Общая продолжительность работы: ").Append(_unityMastersAmount).Append(", общая цена: ").Append(_unityMastersPrice).ToString();
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
            var midContainerForm = new MidContainerForm(this, _repair, StartupTypeForm.Предметы);
            midContainerForm.ShowDialog(this);
        }

        private void removeRepairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Метод не реализован.");
        }

        private void buttonAddMaster_Click(object sender, System.EventArgs e)
        {
            var midContainerForm = new MidContainerForm(this, _repair, StartupTypeForm.Мастера);
            midContainerForm.ShowDialog(this);
        }

        private void detailToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Метод не реализован.");
        }

        private void buttonEditItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Метод не реализован.");
        }

        private void buttonRemoveItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Метод не реализован.");
        }

        private void buttonEditMaster_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Метод не реализован.");
        }

        private void buttonRemoveMaster_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Метод не реализован.");
        }
    }
}
