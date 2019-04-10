using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepairPlanning.Models;
using RepairPlanning.Util;

namespace RepairPlanning.Forms
{
    public partial class ItemsForm : Form
    {
        private const int AmountOfColumns = 6;

        private readonly Repair _repair;
        private readonly Form _parent;
        private readonly Label _totaLabel;
        private readonly List<double> _totalPrice;
        private readonly List<int> _totalAmount;
        private int _currentPage = 0;

        public ItemsForm(Form parent, Repair repair, Label totaLabel, List<double> totalPrice, List<int> totalAmount)
        {
            InitializeComponent();

            _parent = parent;
            MdiParent = _parent;
            _repair = repair;
            LoadData();

            _totaLabel = totaLabel;
            _totalPrice = totalPrice;
            _totalAmount = totalAmount;
        }

        private void LoadData()
        {
            LoadFields();
            LoadDataGridView();
        }

        private void LoadFields()
        {
            using (var db = new ModelsContext())
            {
                var itemCategories = db.ItemCategories.ToList();
                itemCategories.Insert(0, new ItemCategory { ItemCategoryId = 0, Name = "Все" });

                comboBoxCategory.DataSource = itemCategories;
                comboBoxCategory.DisplayMember = "Name";
                comboBoxCategory.ValueMember = "ItemCategoryId";

                var shops = db.Shops.ToList();
                shops.Insert(0, new Shop { Id = 0, Name = "Все" });

                comboBoxShop.DataSource = shops;
                comboBoxShop.DisplayMember = "Name";
                comboBoxShop.ValueMember = "Id";

                comboBoxType.Text = "Все";
                comboBoxWarrantyUpTo.Text = "Любая";
            }
        }

        private void LoadDataGridView(IReadOnlyCollection<Item> itemList = null)
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
                db.ItemCategories.ToList();
                db.TypeItems.ToList();
                db.Shops.ToList();

                if (itemList == null)
                {
                    foreach (var item in db.Items)
                    {
                        dataGridView.Rows.Add(item.Id, item.Name, item.Shop.Name,
                            item.TypeItem.Name, item.WarrantyUpTo, item.Price);
                    }
                }
                else
                {
                    foreach (var item in itemList)
                    {
                        dataGridView.Rows.Add(item.Id, item.Name, item.Shop.Name,
                            item.TypeItem.Name, item.WarrantyUpTo, item.Price);
                    }
                }
            }

            dataGridView.Columns[0].Visible = false;

            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[1].HeaderText = "Предмет";

            dataGridView.Columns[2].Width = 120;
            dataGridView.Columns[2].HeaderText = "Магазин";

            dataGridView.Columns[3].Width = 170;
            dataGridView.Columns[3].HeaderText = "Тип предмета";

            dataGridView.Columns[4].Width = 80;
            dataGridView.Columns[4].HeaderText = "Гарантия (в месяцах)";

            dataGridView.Columns[5].Width = 120;
            dataGridView.Columns[5].HeaderText = "Цена";
        }

        private void comboBoxWarrantyUpTo_KeyPress(object sender, KeyPressEventArgs e) => 
            e.KeyChar = (char) Keys.None;

        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text.Contains("Все"))
            {
                comboBoxType.Enabled = false;
                return;
            }

            try
            {
                using (var db = new ModelsContext())
                {
                    db.ItemCategories.ToList();
                    var itemCategory = db.ItemCategories.First(x => x.Name == comboBoxCategory.Text);
                    var typeItems = db.TypeItems.Where(x => x.ItemCategory.ItemCategoryId == itemCategory.ItemCategoryId).ToList();

                    typeItems.Insert(0, new TypeItem { Id = 0, Name = "Все" });

                    comboBoxType.DataSource = typeItems;
                    comboBoxType.DisplayMember = "Name";
                    comboBoxType.ValueMember = "Id";
                }
                comboBoxType.Enabled = true;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxCategory.Text = "Все";
            comboBoxType.Enabled = false;
            comboBoxType.Text = "Все";
            comboBoxShop.Text = "Все";
            comboBoxWarrantyUpTo.Text = "Любая";
            textBoxName.Text = string.Empty;
            textBoxPriceFrom.Text = string.Empty;
            textBoxPriceTo.Text = string.Empty;
        }

        private void textBoxPriceFrom_KeyPress(object sender, KeyPressEventArgs e) => 
            Helpers.ValidPriceData(textBoxPriceFrom, e);

        private void textBoxPriceTo_KeyPress(object sender, KeyPressEventArgs e) =>
            Helpers.ValidPriceData(textBoxPriceTo, e);

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (!Helpers.CorrectionFilterPrice(textBoxPriceFrom, textBoxPriceTo))
            {
                return;
            }

            List<Item> itemList = null;

            using (var db = new ModelsContext())
            {
                IQueryable<Item> dbItems = db.Items;
                db.ItemCategories.ToList();
                db.TypeItems.ToList();
                db.Shops.ToList();

                if (!string.IsNullOrEmpty(textBoxName.Text))
                {
                    dbItems = dbItems.Where(x => x.Name.Contains(textBoxName.Text));
                }

                if (!comboBoxCategory.Text.Contains("Все"))
                {
                    dbItems = dbItems.Where(x => x.TypeItem.ItemCategory.Name == comboBoxCategory.Text);

                    if (!comboBoxType.Text.Contains("Все"))
                    {
                        dbItems = dbItems.Where(x => x.TypeItem.Name == comboBoxType.Text);
                    }
                }

                if (!comboBoxWarrantyUpTo.Text.Contains("Любая"))
                {
                    var warrantyUpTo = int.Parse(comboBoxWarrantyUpTo.Text);
                    dbItems = dbItems.Where(x => x.WarrantyUpTo >= warrantyUpTo);
                }

                if (!comboBoxShop.Text.Contains("Все"))
                {
                    var shop = comboBoxShop.Text;
                    dbItems = dbItems.Where(x => x.Shop.Name.Contains(shop));
                }

                if (!string.IsNullOrEmpty(textBoxPriceFrom.Text))
                {
                    var priceFrom = double.Parse(textBoxPriceFrom.Text);
                    dbItems = dbItems.Where(x => x.Price >= priceFrom);
                }

                if (!string.IsNullOrEmpty(textBoxPriceTo.Text))
                {
                    var priceTo = double.Parse(textBoxPriceTo.Text);
                    dbItems = dbItems.Where(x => x.Price <= priceTo);
                }

                itemList = dbItems.ToList();
            }

            if (itemList.ToList().Count == 0)
            {
                MessageBox.Show("Результаты не надены.");
                return;
            }

            LoadDataGridView(itemList);
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowToolTip(e);
        }

        private void ShowToolTip(DataGridViewCellEventArgs e)
        {
            switch (dataGridView.CurrentCell.ColumnIndex)
            {
                case 2:
                {
                    var cellDisplayRect = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    var shopName = dataGridView.CurrentCell.Value.ToString();
                    using (var db = new ModelsContext())
                    {
                        var shop = db.Shops.First(x => x.Name.Contains(shopName));

                        toolTip.Show(
                            new StringBuilder().Append("Адрес: ").Append(shop.Address).Append("\nТелефон: ")
                                .Append(shop.PhoneNumber).ToString(),
                            dataGridView,
                            cellDisplayRect.X + dataGridView.CurrentCell.Size.Width / 2,
                            cellDisplayRect.Y + dataGridView.CurrentCell.Size.Height / 2,
                            2000);
                        dataGridView.ShowCellToolTips = false;
                    }

                    break;
                }
                case 1:
                {
                    var cellDisplayRect = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    var nameItem = dataGridView.CurrentCell.Value.ToString();
                    using (var db = new ModelsContext())
                    {
                        var item = db.Items.First(x => x.Name.Contains(nameItem));

                        toolTip.Show(
                            new StringBuilder().Append("Описание: ").Append(item.Description).ToString(),
                            dataGridView,
                            cellDisplayRect.X + dataGridView.CurrentCell.Size.Width / 2,
                            cellDisplayRect.Y + dataGridView.CurrentCell.Size.Height / 2,
                            2000);
                        dataGridView.ShowCellToolTips = false;
                    }

                    break;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var inputBox = new InputBox.InputBox("Количество предметов", "Введите количество: ", string.Empty, true);

            var valueInputBox = inputBox.ToString();
            if (string.IsNullOrEmpty(valueInputBox) || int.Parse(valueInputBox) == 0)
            {
                return;
            }

            var currentItemId = dataGridView.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(currentItemId))
            {
                MessageBox.Show("Выделите строку для добавления предмета.");
            }

            using (var db = new ModelsContext())
            {
                var itemId = int.Parse(currentItemId);
                var amountItem = int.Parse(valueInputBox);

                var repairItem = db.RepairItems.FirstOrDefault(x => x.ItemId == itemId && x.RepairId == _repair.Id);
                if (repairItem == null)
                {
                    db.RepairItems.Add(new RepairItem
                    {
                        RepairId = _repair.Id,
                        AmountItem = amountItem,
                        ItemId = itemId
                    });
                }
                else
                {
                    repairItem.AmountItem += amountItem;
                }
                
                db.SaveChanges();

                var priceItem = db.Items.First(x => x.Id == itemId).Price;

                _totalPrice[0] += priceItem * amountItem;
                _totalAmount[0] += amountItem; 
                _totaLabel.Text = new StringBuilder().Append("Стоимость предметов: ").Append(_totalPrice[0])
                    .Append(", общее кол-во предметов: ").Append(_totalAmount[0]).Append(
                        "                                                                      стоимость работы мастеров: ")
                    .Append(_totalPrice[1]).Append(", общая продолжительность работы (в днях): ").Append(_totalAmount[1])
                    .ToString();
            }
        }
    }
}
