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
    public partial class Packages : Form
    {

        private readonly FitnessEntities _context;
        public Packages()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void Packages_Load(object sender, EventArgs e)
        {
            cmbAddPackageTime.Items.AddRange(_context.Times.ToArray());
            cmbUpdatePackages.Items.AddRange(_context.Packages.ToArray());
            cmbUpdatePackageTime.Items.AddRange(_context.Times.ToArray());
            cmbDeletePackage.Items.AddRange(_context.Packages.ToArray());

            foreach (var ser in _context.Services)
            {
                CheckBox checkbox = new CheckBox();
                checkbox.Text = ser.Name;
                checkbox.Tag = ser.id;
                flowLayoutPanel1.Controls.Add(checkbox);
            }
            _context.SaveChangesAsync();

        }

        private async void BtnAddPackage_Click(object sender, EventArgs e)
        {
            string packageName = txtAddPackageName.Text.Trim();

            decimal packagePrice = nmrAddPackagePrice.Value;
            Time packageTime = (Time)cmbAddPackageTime.SelectedItem;
            Package package = new Package
            {
                Name = packageName,
                Price__per_month_ = packagePrice,
                TimeId = packageTime.id,


            };
            _context.Packages.Add(package);

             _context.SaveChangesAsync().Wait();

            foreach (var ser in flowLayoutPanel1.Controls)
            {
                CheckBox checkbox = (CheckBox)ser;
                if (checkbox.Checked)
                {

                    _context.ServicesToPackages.Add(new ServicesToPackage
                    {
                        ServiceId = Convert.ToInt32(checkbox.Tag),
                        PackageId = package.id
                    });

                    
                }
            }
            await _context.SaveChangesAsync();
            MessageBox.Show("Yeni paket əlavə olundu");

            txtAddPackageName.Text = "";
            nmrAddPackagePrice.Value = 0;
          

            cmbUpdatePackages.Items.Clear();
            cmbUpdatePackages.Items.AddRange(_context.Packages.ToArray());

            cmbDeletePackage.Items.Clear();
            cmbDeletePackage.Items.AddRange(_context.Packages.ToArray());
        }

        private async void BtnUpdatePackage_Click(object sender, EventArgs e)
        {
            Package updatePackage = (Package)cmbUpdatePackages.SelectedItem;
            string updatePackageName = txtUpdatePackageName.Text.Trim();
            decimal updatePackagePrice = nmrUpdatePackagePrice.Value;
            Time updatePackageTime = (Time)cmbUpdatePackageTime.SelectedItem;

            updatePackage.Name = updatePackageName;
            updatePackage.Price__per_month_ = updatePackagePrice;
            updatePackage.TimeId = updatePackageTime.id;

            await _context.SaveChangesAsync();


            //service update

            cmbDeletePackage.Items.Clear();
            cmbDeletePackage.Items.AddRange(_context.Packages.ToArray());
        }

       

        private  async void BtnDeletePackage_Click(object sender, EventArgs e)
        {
            Package deletePackage = (Package)cmbDeletePackage.SelectedItem;

            _context.Packages.Remove(deletePackage);

            await _context.SaveChangesAsync();

            cmbUpdatePackages.Items.Clear();
            cmbUpdatePackages.Items.AddRange(_context.Packages.ToArray());
        }

        private void CmbUpdatePackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var ser in flowLayoutPanel1.Controls)
            {
                var checkbox = (CheckBox)ser;
                checkbox.Checked = false;
            }

            Package package = (Package)cmbUpdatePackages.SelectedItem;
            txtUpdatePackageName.Text = package.Name;


            List<ServicesToPackage> listofpackage = _context.ServicesToPackages.Where(x => x.PackageId == package.id).ToList();

            foreach (var ser in flowLayoutPanel1.Controls)
            {
                var checkBox = (CheckBox)ser;

                foreach (var row in listofpackage)
                {
                    if (row.ServiceId == Convert.ToInt32(checkBox.Tag))
                    {
                        checkBox.Checked = true;
                    }
                }
            }
            cmbUpdatePackageTime.SelectedItem = package.Time;
        }
    }
}
