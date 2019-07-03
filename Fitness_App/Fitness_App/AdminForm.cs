using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_App
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeesForm().ShowDialog();
        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PositionsForm().ShowDialog();
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Services().ShowDialog();
        }

        private void PackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Packages().ShowDialog();
        }
    }
}
