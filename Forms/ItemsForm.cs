using System;
using System.Collections.Generic;
using System.Linq;
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

        public ItemsForm(Form parent, Repair repair)
        {
            InitializeComponent();

            _parent = parent;
            MdiParent = _parent;
            _repair = repair;
            LoadData();
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

                comboBoxShop.DataSource = itemCategories;
                comboBoxShop.DisplayMember = "Name";
                comboBoxShop.ValueMember = "Id";
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
            Helpers.CorrectionFilterPrice(textBoxPriceFrom, textBoxPriceTo);

            List<Item> itemList = null;

            using (var db = new ModelsContext())
            {
                IQueryable<Item> dbItems = db.Items;
                db.ItemCategories.ToList();
                db.TypeItems.ToList();

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

                if (!comboBoxType.Text.Contains("Любая"))
                {
                    var warrantyUpTo = int.Parse(comboBoxWarrantyUpTo.Text);
                    dbItems = dbItems.Where(x => x.WarrantyUpTo >= warrantyUpTo);
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
    }
}
