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
    public partial class VerifyPasswordForm : Form
    {
        private readonly FitnessEntities _context;
        private readonly Employee _loggedEmployee;

        public VerifyPasswordForm(Employee employee)
        {
            InitializeComponent();
            _loggedEmployee = employee;
            _context = new FitnessEntities();
        }

        private async void BtnVerify_Click(object sender, EventArgs e)
        {
            string currentPassword = txtVerifyPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (currentPassword == string.Empty || newPassword == string.Empty || confirmPassword == string.Empty)
            {
                ShowMessage("Error", "Fill all fields");
                return;
            }

            if (!CheckHash(_loggedEmployee.Password, currentPassword))
            {
                ShowMessage("Error", "Password is invalid");
                return;
            }

            if (newPassword != confirmPassword)
            {
                ShowMessage("Error", "Password not same");
                return;
            }

            Employee updateEmployee = await _context.Employees.FindAsync(_loggedEmployee.id);
            updateEmployee.Password = GetHash(newPassword);
            updateEmployee.HasVerified = true;
            await _context.SaveChangesAsync();

            if(updateEmployee.Position.Name == "Casier")
            {
                new CasierForm(updateEmployee).ShowDialog();
            }
        }
        private void ShowMessage(string title, string content, bool isError = true)
        {
            MessageBox.Show(
                content,
                title,
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);

        }
    }
}
