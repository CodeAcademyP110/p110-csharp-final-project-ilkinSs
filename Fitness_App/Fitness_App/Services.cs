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
    public partial class Services : Form
    {
        private readonly FitnessEntities _context;

        public Services()
        {
            InitializeComponent();
            _context = new FitnessEntities();

        }

        private void Services_Load(object sender, EventArgs e)
        {
            dgwService.DataSource = _context.Services.ToArray();
            cmbTime.Items.AddRange(_context.Times.ToArray());


            cmbUpdateService.Items.Clear();
            cmbUpdateService.Items.AddRange(_context.Services.ToArray());
            nmrUpdateTime.Items.AddRange(_context.Times.ToArray());


            cmbDeleteService.Items.Clear();
            cmbDeleteService.Items.AddRange(_context.Services.ToArray());
        }

        private async void BtnAddService_Click(object sender, EventArgs e)
        {
            string newServiceName = txtServiceName.Text.Trim();
            decimal perHour = nmrPerHour.Value;
            Time time = cmbTime.SelectedItem as Time;

            _context.Services.Add(new Service
            {
                Name = newServiceName,
                Price__per_hour_ = perHour,
                TimeId = time.id
            });

            await _context.SaveChangesAsync();
            dgwService.DataSource = _context.Services.ToArray();

            cmbDeleteService.Items.Clear();
            cmbDeleteService.Items.AddRange(_context.Services.ToArray());
            cmbUpdateService.Items.Clear();
            cmbUpdateService.Items.AddRange(_context.Services.ToArray());
        }

        private async void BtnDeleteService_Click(object sender, EventArgs e)
        {
            Service deleteService = (Service)cmbDeleteService.SelectedItem;

            _context.Services.Remove(deleteService);
            await _context.SaveChangesAsync();

            dgwService.DataSource = _context.Services.ToArray();
            cmbDeleteService.Items.Clear();
            cmbDeleteService.Items.AddRange(_context.Services.ToArray());

            cmbUpdateService.Items.Clear();
            cmbUpdateService.Items.AddRange(_context.Services.ToArray());
        }

        private async void BtnUpdateService_Click(object sender, EventArgs e)
        {
            Service updateService = (Service)cmbUpdateService.SelectedItem;
            decimal updatePerHour = nmrUpdateHour.Value;
            string updateName = txtUpdateName.Text.Trim();
            Time updateTime = (Time)nmrUpdateTime.SelectedItem;


            updateService.Price__per_hour_ = updatePerHour;
            updateService.TimeId = updateTime.id;
            updateService.Name = updateName;

            await _context.SaveChangesAsync();
            dgwService.DataSource = _context.Services.ToArray();

            cmbDeleteService.Items.Clear();
            cmbDeleteService.Items.AddRange(_context.Services.ToArray());
        }
    }
}
