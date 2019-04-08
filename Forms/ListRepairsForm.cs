using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepairPlanning.Forms;
using RepairPlanning.Models;
using RepairPlanning.Util;

namespace RepairPlanning
{
    public partial class Form1 : Form
    {
        private readonly Panel _parent;
        private int _xPositionPanel;
        private int _currentCountRepairs = 0;

        public Form1()
        {
            InitializeComponent();

            _parent = mainPanel;
            Load();
        }

        private void Load()
        {
            using (var db = new ModelsContext())
            {
                var repairs = db.Repairs.OrderByDescending(x => x.Id).ToList();
                if (_currentCountRepairs == repairs.Count)
                {
                    return;
                }

                _xPositionPanel = 10;
                _parent.Controls.Clear();
                foreach (var repair in repairs)
                {
                    LoadRepair(repair);
                }
            }
        }

        private void buttonCreateRepair_Click(object sender, EventArgs e)
        {
            var editRepairForm = new EditRepairForm(StartupTypeForm.Добавление);
            editRepairForm.ShowDialog(this);
            Load();
        }

        private void LoadRepair(Repair repair)
        {
            var newPanel = new Panel
            {
                Name = "panelRepair" + repair.Id
            };

            newPanel.Top += _xPositionPanel;
            newPanel.Left = 12;
            newPanel.Height = 63;
            newPanel.Width = 776;
            _xPositionPanel += 70;

            _parent.Controls.Add(newPanel);

            var labelText = new StringBuilder();
            labelText.Append(repair.NameRepair).Append(" (").Append(repair.StartDate.ToShortDateString()).Append(" - ")
                .Append(repair.ExpirationDate.ToShortDateString()).Append(")");

            var newLabel = new Label
            {
                Name = "labelRepairName" + repair.Id,
                Top = 25,
                Left = 12,
                Height = 13,
                Width = 335,
                Text = labelText.ToString()
            };
            newPanel.Controls.Add(newLabel);

            var workingDirectory = Environment.CurrentDirectory;
            var directoryInfo = Directory.GetParent(workingDirectory).Parent;
            if (directoryInfo != null)
            {
                var pathImgDetail = directoryInfo.FullName + "\\Images\\6.png";

                var newButtonRepairDetails = new Button
                {
                    Name = "buttonRepairDetails" + repair.Id,
                    Top = 3,
                    Left = 654,
                    Height = 57,
                    Width = 120,
                    Text = "Детали",
                    Image = Image.FromFile(pathImgDetail),
                    ForeColor = Color.AliceBlue,
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
                        GraphicsUnit.Point, ((byte) (204))),
                    Cursor = Cursors.Hand
                };
                newButtonRepairDetails.Click += ShowDetailRepair;
                newPanel.Controls.Add(newButtonRepairDetails);


                var pathEditImg = directoryInfo.FullName + "\\Images\\editIco.png";

                var newButtonEditRepair = new Button
                {
                    Name = "buttonEditRepair" + repair.Id,
                    Top = 3,
                    Left = 624,
                    Height = 30,
                    Width = 30,
                    Image = Image.FromFile(pathEditImg),
                    Cursor = Cursors.Hand
                };
                newButtonEditRepair.Click += EditRepair;
                newPanel.Controls.Add(newButtonEditRepair);

                var pathRemoveImg = directoryInfo.FullName + "\\Images\\removeIco.png";

                var newButtonRemoveRepair = new Button
                {
                    Name = "buttonRemoveRepair" + repair.Id,
                    Top = 30,
                    Left = 624,
                    Height = 30,
                    Width = 30,
                    Image = Image.FromFile(pathRemoveImg),
                    Cursor = Cursors.Hand
                };
                newButtonRemoveRepair.Click += RemoveRepair;
                newPanel.Controls.Add(newButtonRemoveRepair);
            }

            _currentCountRepairs++;
            _parent.Refresh();
        }

        private void EditRepair(object sender, EventArgs e)
        {
            var thisButton = (Button) sender;
            var idRepair = int.Parse(thisButton.Name.Replace("buttonEditRepair", ""));
            var editRepairForm = new EditRepairForm(StartupTypeForm.Редактирование, idRepair);
            editRepairForm.ShowDialog(this);
            Load();
        }

        private void ShowDetailRepair(object sender, EventArgs e)
        {
            var thisButton = (Button)sender;
            var idRepair = int.Parse(thisButton.Name.Replace("buttonRepairDetails", ""));

            using (var db = new ModelsContext())
            {
                db.TypeRepairs.ToList();
                var repair = db.Repairs.First(x => x.Id == idRepair);
                var editRepairForm = new RepairDetailForm(this, repair);
                Hide();
                editRepairForm.Show(this);
            }
        }

        private void RemoveRepair(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Действительно удалить ремонт?",
                    "Подтвердите действие", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (var db = new ModelsContext())
                {
                    var thisButton = (Button)sender;
                    var idRepair = int.Parse(thisButton.Name.Replace("buttonRemoveRepair", ""));

                    var repirItem = db.RepairItems.FirstOrDefault(x => x.RepairId == idRepair);
                    if (repirItem != null)
                    {
                        MessageBox.Show("В ремонт входят предметы, удаление невозможно.");
                        return;
                    }
                    var repirMaster = db.RepairMasters.FirstOrDefault(x => x.RepairId == idRepair);
                    if (repirMaster != null)
                    {
                        MessageBox.Show("В ремонт входят мастера, удаление невозможно.");
                        return;
                    }

                    var currentRepair = db.Repairs.FirstOrDefault(x => x.Id == idRepair);
                    if (currentRepair != null)
                    {
                        db.Repairs.Remove(currentRepair);
                        db.SaveChanges();
                        Load();
                        return;
                    }

                    MessageBox.Show("Удаление невозможно в силу непредвиденных обстоятельств.");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutProgram = new AboutProgram();
            aboutProgram.ShowDialog(this);
        }

        private void helperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.StartupHelper();
        }
    }
}
