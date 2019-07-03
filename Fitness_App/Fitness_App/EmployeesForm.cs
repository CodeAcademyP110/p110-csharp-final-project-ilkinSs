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
using static Fitness_App.Utilities.Hash;
namespace Fitness_App
{
    public partial class EmployeesForm : Form
    {

        private readonly FitnessEntities _context;
        public EmployeesForm()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            UpdateEmployees();
            cmbUpdateEmployee.Items.Clear();
            cmbPositions.Items.Clear();
            cmbDeleteEmployee.Items.Clear();

            cmbPositions.Items.AddRange(_context.Positions.ToArray());
            cmbPositions.SelectedIndex = 0;

            cmbUpdateEmployee.Items.AddRange(_context.Employees.ToArray());
            cmbUpdatePosition.Items.AddRange(_context.Positions.ToArray());

            cmbDeleteEmployee.Items.AddRange(_context.Employees.ToArray());
        }

        private async void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string defaultPassword = txtDefaulPassword.Text.Trim();
            Position position = cmbPositions.SelectedItem as Position;

            if (name == string.Empty || surname == string.Empty || username == string.Empty || defaultPassword == string.Empty)
            {
                ShowMessage("Error", "Please doldurun badeleri");
                return;
            }


            if (_context.Employees.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                ShowMessage("Error", "Duplicate username");
                return;
            }

            _context.Employees.Add(new Employee
            {
                Name = name,
                Surname = surname,
                Username = username,
                Password = GetHash(defaultPassword),
                PositionId = position.id
            });
            await _context.SaveChangesAsync();

            ShowMessage("Success", "New employee successfully added", false);

            UpdateEmployees();
            cmbUpdateEmployee.Items.Clear();
            cmbUpdateEmployee.Items.AddRange(_context.Employees.ToArray());

            cmbDeleteEmployee.Items.Clear();
            cmbDeleteEmployee.Items.AddRange(_context.Employees.ToArray());

        }
        private void ShowMessage(string title, string content, bool isError = true)
        {
            MessageBox.Show(
                content,
                title,
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);

        }

        private void UpdateEmployees()
        {
            dgwEmployees.DataSource = _context.Employees.Where(u => u.PositionId != 1)
                .Select(u => new
                {
                    Fullname = string.Concat(u.Name, " ", u.Surname),
                    Username = u.Username,
                    Position = u.Position.Name
                }).ToList();
        }

        private async void BtnUpdateEmployee_Click(object sender, EventArgs e)
        {
            
            Employee updateEmployee = cmbUpdateEmployee.SelectedItem as Employee;
            string updateName = txtUpdateName.Text.Trim();
            string updateSurname = txtUpdateSurname.Text.Trim();
            Position updatePosition = cmbUpdatePosition.SelectedItem as Position;

            if (updateName == string.Empty || updateSurname == string.Empty)
            {
                ShowMessage("Error", "Please doldurun badeleri");
                return;
            }

            updateEmployee.Name = updateName;
            updateEmployee.PositionId = updatePosition.id;

            await _context.SaveChangesAsync();
            UpdateEmployees();
            cmbUpdateEmployee.Text = " ";
            cmbUpdateEmployee.Items.Clear();
            cmbUpdateEmployee.Items.AddRange(_context.Employees.ToArray());

        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            Employee deleteEmployee = cmbDeleteEmployee.SelectedItem as Employee;

            _context.Employees.Remove(deleteEmployee);

            await _context.SaveChangesAsync();
            UpdateEmployees();
            cmbUpdateEmployee.Items.Clear();
            cmbUpdateEmployee.Items.AddRange(_context.Employees.ToArray());

            cmbDeleteEmployee.Items.Clear();
            cmbDeleteEmployee.Items.AddRange(_context.Employees.ToArray());
        }
    }
}
