using System.Windows.Forms;
using RepairPlanning.Models;
using RepairPlanning.Util;

namespace RepairPlanning.Forms
{
    public partial class MidContainerForm : Form
    {
        private readonly Form _repairDetailForm;
        private readonly Repair _repair;

        public MidContainerForm(Form repairDetailForm, Repair repair, StartupTypeForm startupTypeForm)
        {
            InitializeComponent();

            _repair = repair;
            _repairDetailForm = repairDetailForm;

            if (startupTypeForm == StartupTypeForm.Предметы)
            {
                var childItemsForm = new ItemsForm(this, _repair);
                childItemsForm.Show();
            }
            else if (startupTypeForm == StartupTypeForm.Мастера)
            {
                var childMastersForm = new MastersForm(this, _repair);
                childMastersForm.Show();
            }
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
            var childItemsForm = new ItemsForm(this, _repair);
            childItemsForm.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            LayoutMdi(MdiLayout.TileVertical);

        private void tileHorizontalToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            LayoutMdi(MdiLayout.TileHorizontal);

        private void withMastersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var childMastersForm = new MastersForm(this, _repair);
            childMastersForm.Show();
        }
    }
}
