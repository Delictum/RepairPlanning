using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepairPlanning.Models;
using RepairPlanning.Util;

namespace RepairPlanning.Forms
{
    public partial class MastersForm : Form
    {
        private const int AmountOfColumns = 5;

        private readonly Repair _repair;
        private readonly Form _parent;
        private readonly Label _totaLabel;
        private readonly List<double> _totalPrice;
        private readonly List<int> _totalAmount;

        public MastersForm(Form parent, Repair repair, Label totaLabel, List<double> totalPrice, List<int> totalAmount)
        {
            InitializeComponent();

            _parent = parent;
            MdiParent = _parent;
            _repair = repair;
            LoadData();
            comboBoxExpiarence.Text = "Любой";

            _totaLabel = totaLabel;
            _totalPrice = totalPrice;
            _totalAmount = totalAmount;
        }

        private void LoadData(IReadOnlyCollection<Master> masterList = null)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (var x = 0; x < AmountOfColumns; x++)
            {
                var column = new DataGridViewTextBoxColumn();
                dataGridView.Columns.Add(column);
            }

            using (var db = new ModelsContext())
            {
                if (masterList == null)
                {
                    foreach (var master in db.Masters)
                    {
                        dataGridView.Rows.Add(master.MasterId, master.Name, master.PhoneNumber,
                            master.Expiarence, master.Price);
                    }
                }
                else
                {
                    foreach (var master in masterList)
                    {
                        dataGridView.Rows.Add(master.MasterId, master.Name, master.PhoneNumber,
                            master.Expiarence, master.Price);
                    }
                }
            }

            dataGridView.Columns[0].Visible = false;

            dataGridView.Columns[1].Width = 180;
            dataGridView.Columns[1].HeaderText = "Название";

            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[2].HeaderText = "Телефонный номер";

            dataGridView.Columns[3].Width = 50;
            dataGridView.Columns[3].HeaderText = "Стаж работы (в годах)";

            dataGridView.Columns[4].Width = 80;
            dataGridView.Columns[4].HeaderText = "Цена";
        }

        private void comboBoxExpiarence_KeyPress(object sender, KeyPressEventArgs e) => 
            e.KeyChar = (char) Keys.None;

        private void buttonReset_Click(object sender, System.EventArgs e)
        {
            comboBoxExpiarence.Text = "Любой";
            textBoxPriceFrom.Text = string.Empty;
            textBoxPriceTo.Text = string.Empty;
            textBoxSpecialization.Text = string.Empty;
        }

        private void textBoxPriceTo_KeyPress(object sender, KeyPressEventArgs e) =>
            Helpers.ValidPriceData(textBoxPriceTo, e);

        private void buttonApply_Click(object sender, System.EventArgs e)
        {
            if (!Helpers.CorrectionFilterPrice(textBoxPriceFrom, textBoxPriceTo))
            {
                return;
            }

            List<Master> masterList = null;

            using (var db = new ModelsContext())
            {
                IQueryable<Master> dbMasters = db.Masters;
                db.ItemCategories.ToList();
                db.TypeItems.ToList();

                if (!string.IsNullOrEmpty(textBoxSpecialization.Text))
                {
                    dbMasters = dbMasters.Where(x => x.Name.Contains(textBoxSpecialization.Text));
                }

                if (!comboBoxExpiarence.Text.Contains("Любой"))
                {
                    var expiarence = int.Parse(comboBoxExpiarence.Text);
                    dbMasters = dbMasters.Where(x => x.Expiarence >= expiarence);
                }

                if (!string.IsNullOrEmpty(textBoxPriceFrom.Text))
                {
                    var priceFrom = double.Parse(textBoxPriceFrom.Text);
                    dbMasters = dbMasters.Where(x => x.Price >= priceFrom);
                }

                if (!string.IsNullOrEmpty(textBoxPriceTo.Text))
                {
                    var priceTo = double.Parse(textBoxPriceTo.Text);
                    dbMasters = dbMasters.Where(x => x.Price <= priceTo);
                }

                masterList = dbMasters.ToList();
            }

            if (masterList.ToList().Count == 0)
            {
                MessageBox.Show("Результаты не надены.");
                return;
            }

            LoadData(masterList);
        }

        private void textBoxPriceFrom_KeyPress(object sender, KeyPressEventArgs e) =>
            Helpers.ValidPriceData(textBoxPriceFrom, e);

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            var inputBox = new InputBox.InputBox("Количество дней работы", "Введите дни: ", string.Empty, true);

            var valueInputBox = inputBox.ToString();
            if (string.IsNullOrEmpty(valueInputBox) || int.Parse(valueInputBox) == 0)
            {
                return;
            }

            var currentMasterId = dataGridView.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(currentMasterId))
            {
                MessageBox.Show("Выделите строку для добавления мастера.");
            }

            using (var db = new ModelsContext())
            {
                var masterId = int.Parse(currentMasterId);
                var amountDayOfWorks = int.Parse(valueInputBox);

                var repairMaster = db.RepairMasters.FirstOrDefault(x => x.MasterId == masterId && x.RepairId == _repair.Id);
                if (repairMaster == null)
                {
                    db.RepairMasters.Add(new RepairMaster
                    {
                        RepairId = _repair.Id,
                        DaysOfWork = amountDayOfWorks,
                        MasterId = masterId
                    });
                }
                else
                {
                    repairMaster.DaysOfWork += amountDayOfWorks;
                }

                db.SaveChanges();

                var priceMaster = db.Masters.First(x => x.MasterId == masterId).Price;

                _totalPrice[1] += priceMaster * amountDayOfWorks;
                _totalAmount[1] += amountDayOfWorks;
                _totaLabel.Text = new StringBuilder().Append("Стоимость предметов: ").Append(_totalPrice[0])
                    .Append(", общее кол-во предметов: ").Append(_totalAmount[0]).Append(
                        "                                                                      стоимость работы мастеров: ")
                    .Append(_totalPrice[1]).Append(", общая продолжительность работы (в днях): ").Append(_totalAmount[1])
                    .ToString();
            }
        }
    }
}
