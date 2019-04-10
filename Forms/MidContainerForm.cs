using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RepairPlanning.Models;
using RepairPlanning.Util;

namespace RepairPlanning.Forms
{
    public partial class MidContainerForm : Form
    {
        private readonly Form _repairDetailForm;
        private readonly Repair _repair;
        private readonly List<double> _totalPrice;
        private readonly List<int> _totalAmount;

        public MidContainerForm(Form repairDetailForm, Repair repair, StartupTypeForm startupTypeForm, List<double> totalPrice, List<int> totalAmount)
        {
            InitializeComponent();

            _repair = repair;
            _repairDetailForm = repairDetailForm;

            if (startupTypeForm == StartupTypeForm.Предметы)
            {
                var childItemsForm = new ItemsForm(this, _repair, labelTotal, totalPrice, totalAmount);
                childItemsForm.Show();
            }
            else if (startupTypeForm == StartupTypeForm.Мастера)
            {
                var childMastersForm = new MastersForm(this, _repair, labelTotal, totalPrice, totalAmount);
                childMastersForm.Show();
            }

            _totalPrice = totalPrice;
            _totalAmount = totalAmount;
            labelTotal.Text = new StringBuilder().Append("Стоимость предметов: ").Append(_totalPrice[0])
                .Append(", общее кол-во предметов: ").Append(_totalAmount[0]).Append(
                    "                                                                      стоимость работы мастеров: ")
                .Append(_totalPrice[1]).Append(", общая продолжительность работы (в днях): ").Append(_totalAmount[1])
                .ToString();
        }

        private void cascadeToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            LayoutMdi(MdiLayout.Cascade);

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            Application.Exit();

        private void helperToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            Helpers.StartupHelper();

        private void aboutProgramToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var aboutProgram = new AboutProgram();
            aboutProgram.ShowDialog(this);
        }

        private void withItemsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var childItemsForm = new ItemsForm(this, _repair, labelTotal, _totalPrice, _totalAmount);
            childItemsForm.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            LayoutMdi(MdiLayout.TileVertical);

        private void tileHorizontalToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            LayoutMdi(MdiLayout.TileHorizontal);

        private void withMastersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var childMastersForm = new MastersForm(this, _repair, labelTotal, _totalPrice, _totalAmount);
            childMastersForm.Show();
        }
    }
}
