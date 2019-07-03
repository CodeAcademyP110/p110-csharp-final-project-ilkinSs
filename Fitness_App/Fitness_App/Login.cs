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
    public partial class Login : Form
    {

        private readonly FitnessEntities _context;
        public Login()
        {
            InitializeComponent();
            _context = new FitnessEntities();

           //txtUsername.Text = (GetHash("elcinhtml"));
        }


       

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();





            if (username == string.Empty || password == string.Empty)
            {
                ShowError("Error", "Username and password fields should be filled");
                return;
            }

            Employee employee = _context.Employees.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (employee == null)
            {
                ShowError("Error", "Username or password is invalid");
                return;
            }

            if (!CheckHash(employee.Password, password))
            {
                ShowError("Error", "Username or password is invalid");
                return;
            }


            //Authorization

            switch (employee.PositionId)
            {
                case 1:
                    new AdminForm().ShowDialog();
                    break;
                case 2:
                    if (employee.HasVerified == false)
                    {
                        new VerifyPasswordForm(employee).ShowDialog();
                    }
                    else
                    {
                        new CasierForm(employee).ShowDialog();
                    }
                    //new CasierForm(employee).ShowDialog();
                    break;

                default:
                    ShowError("Uknown login error", "Unknown error occured. Please contact Ilkin bey");
                        break;
            }


        }

        private void ShowError(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
