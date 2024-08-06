using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            menuStrip.ForeColor = Color.DodgerBlue;
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.ShowDialog();
        }

        private void viewCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCarsForm viewCarsForm = new ViewCarsForm();
            viewCarsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rentCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentCarForm rentCarForm = new RentCarForm();
            rentCarForm.Show();
        }

        private void viewRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRentalsForm viewRentalsForm = new ViewRentalsForm();
            viewRentalsForm.Show();
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm();
            addCustomersForm.ShowDialog();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomersForm viewCustomersForm = new ViewCustomersForm();
            viewCustomersForm.ShowDialog();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsersForm viewUsersForm = new ViewUsersForm();
            viewUsersForm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
