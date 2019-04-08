using System.Linq;
using System.Windows.Forms;
using RepairPlanning.Models;
using RepairPlanning.Util;

namespace RepairPlanning.Forms
{
    public partial class EditRepairForm : Form
    {
        private StartupTypeForm _startupTypeForm;
        private int _repairId = 0;

        public EditRepairForm(StartupTypeForm startupTypeForm, int id = 0)
        {
            InitializeComponent();

            _startupTypeForm = startupTypeForm;
            Text = _startupTypeForm.ToString();

            using (var db = new ModelsContext())
            {
                comboBoxTypeRepair.DataSource = db.TypeRepairs.ToList();
                comboBoxTypeRepair.DisplayMember = "Name";
                comboBoxTypeRepair.ValueMember = "Name";
            }

            if (id != 0)
            {
                using (var db = new ModelsContext())
                {
                    var repair = db.Repairs.First(x => x.Id == id);
                    db.TypeRepairs.ToList();

                    _repairId = repair.Id;
                    textBoxNameRepair.Text = repair.NameRepair;
                    richTextBoxNotes.Text = repair.Notes;
                    comboBoxTypeRepair.Text = repair.TypeRepair.Name;
                    dateTimePickerStartDate.Value = repair.StartDate;
                    dateTimePickerExpirationDate.Value = repair.ExpirationDate;
                }
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            switch (_startupTypeForm)
            {
                case StartupTypeForm.Добавление:
                    if (MessageBox.Show("Действительно сохранить ремонт?",
                            "Подтвердите действие", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        using (var db = new ModelsContext())
                        {
                            var typeRepair = db.TypeRepairs.First(x => x.Name == comboBoxTypeRepair.Text);

                            var repair = new Repair
                            {
                                ExpirationDate = dateTimePickerExpirationDate.Value,
                                StartDate = dateTimePickerStartDate.Value,
                                NameRepair = textBoxNameRepair.Text,
                                Notes = richTextBoxNotes.Text,
                                TypeRepair = typeRepair,
                                TypeRepairId = typeRepair.Id
                            };

                            db.Repairs.Add(repair);
                            db.SaveChanges();

                            _repairId = db.Repairs.First(x => x.NameRepair == textBoxNameRepair.Text).Id;
                            _startupTypeForm = StartupTypeForm.Редактирование;
                            Text = _startupTypeForm.ToString();
                        }
                        
                    }
                    break;
                case StartupTypeForm.Редактирование:
                    if (MessageBox.Show("Действительно редактировать ремонт?",
                            "Подтвердите действие", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        using (var db = new ModelsContext())
                        {
                            var typeRepair = db.TypeRepairs.First(x => x.Name == comboBoxTypeRepair.Text);

                            var repair = db.Repairs.First(x => x.Id == _repairId);
                            repair.ExpirationDate = dateTimePickerExpirationDate.Value;
                            repair.StartDate = dateTimePickerStartDate.Value;
                            repair.NameRepair = textBoxNameRepair.Text;
                            repair.Notes = richTextBoxNotes.Text;
                            repair.TypeRepair = typeRepair;
                            repair.TypeRepairId = typeRepair.Id;

                            db.SaveChanges();

                            _repairId = db.Repairs.First(x => x.NameRepair == textBoxNameRepair.Text).Id;
                            _startupTypeForm = StartupTypeForm.Редактирование;
                            Text = _startupTypeForm.ToString();
                        }
                    }
                    break;
                case StartupTypeForm.Удаление:
                    break;
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(textBoxNameRepair.Text))
            {
                MessageBox.Show("Введите название ремонта.");
                return false;
            }

            if (dateTimePickerExpirationDate.Value < dateTimePickerStartDate.Value)
            {
                MessageBox.Show("Дата окончания не может быть меньше начальной.");
                return false;
            }

            return true;
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, System.EventArgs e)
        {
            if (_startupTypeForm == StartupTypeForm.Добавление)
            {
                dateTimePickerExpirationDate.Value = dateTimePickerStartDate.Value.AddMonths(3);
            }
        }

        private void comboBoxTypeRepair_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
    }
}
