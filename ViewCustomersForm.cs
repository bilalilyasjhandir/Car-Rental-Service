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
    public partial class ViewCustomersForm : Form
    {
        public ViewCustomersForm()
        {
            InitializeComponent();
        }

        private void ViewCustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT * FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable customersTable = new DataTable();
                adapter.Fill(customersTable);

                customersDataGridView.DataSource = customersTable;
            }
        }
    }
}

