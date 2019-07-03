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
    public partial class CasierForm : Form
    {

        private readonly FitnessEntities _context;
        private readonly Employee _loggedEmployee;
        public CasierForm(Employee employee)
        {
            InitializeComponent();
            _context = new FitnessEntities();
            _loggedEmployee = employee;

        }

        private void CasierForm_Load(object sender, EventArgs e)
        {
            lbCasierName.Text = $"Dear {_loggedEmployee.Name} {_loggedEmployee.Surname}, Welcome.";

            //if (!(bool)_loggedEmployee.HasVerified)
            //{
            //    new VerifyPasswordForm().ShowDialog();
            //}
        }

        private async void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string customerSurname = txtCustomerSurname.Text.Trim();

            if (customerName == string.Empty || customerSurname == string.Empty)
            {
                ShowMessage("Error", "Please doldurun badeleri");
                return;
            }


          

            _context.Customers.Add(new Customer
            {
                Name = customerName,
                Surname = customerSurname,        
            });
            await _context.SaveChangesAsync();

            ShowMessage("Success", "New customer successfully added", false);
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
