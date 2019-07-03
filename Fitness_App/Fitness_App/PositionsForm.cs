using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness_App.Model;

namespace Fitness_App
{
    public partial class PositionsForm : Form
    {
        private readonly FitnessEntities _context;
        public PositionsForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {

           
            dgwPositions.DataSource = _context.Positions.ToArray();
            cmbDeletePosition.Items.AddRange(_context.Positions.ToArray());
        }

        private async void BtnAddPosition_Click(object sender, EventArgs e)
        {
            string positionName = txtAddPosition.Text.Trim();

            if (positionName == string.Empty)
            {
                ShowMessage("Error", "Doldurun badeleri");
                return;
            }

            if (_context.Positions.Any(p => p.Name.ToLower() == positionName.ToLower()))
            {
                ShowMessage("Error", "Duplicate position");
                return;
            }

            _context.Positions.Add(new Position
            {
                Name = positionName
            });

            

            await _context.SaveChangesAsync();

            dgwPositions.DataSource = _context.Positions.ToArray();
            cmbDeletePosition.Items.Clear();
            cmbDeletePosition.Items.AddRange(_context.Positions.ToArray());
        }
        private void ShowMessage(string title, string content, bool isError = true)
        {
            MessageBox.Show(
                content,
                title,
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);

        }

        private async void BtnDeletePosition_Click(object sender, EventArgs e)
        {
            Position deletePosition = cmbDeletePosition.SelectedItem as Position;

            _context.Positions.Remove(deletePosition);

            await _context.SaveChangesAsync();

            dgwPositions.DataSource = _context.Positions.ToArray();


        }
    }
}
