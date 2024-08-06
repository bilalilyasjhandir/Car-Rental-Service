using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalService
{
    public partial class ViewCarsForm : Form
    {
        public ViewCarsForm()
        {
            InitializeComponent();
        }
        private void LoadCars()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT * FROM Cars";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable carsTable = new DataTable();
                adapter.Fill(carsTable);
                viewCarsDataGridView.DataSource = carsTable;
            }
        }

        private void ViewCarsForm_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void viewCarsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
