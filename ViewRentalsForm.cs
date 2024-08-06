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
    public partial class ViewRentalsForm : Form
    {
        public ViewRentalsForm()
        {
            InitializeComponent();
        }
        private void LoadRentals()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT * FROM Rentals";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable rentalsTable = new DataTable();
                conn.Open(); 
                adapter.Fill(rentalsTable);
                viewRentalsDataGridView.DataSource = rentalsTable;
            }
        }

        private void ViewRentals_Load(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadRentals();
        }
    }
}
