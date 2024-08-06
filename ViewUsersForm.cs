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
    public partial class ViewUsersForm : Form
    {
        public ViewUsersForm()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable usersTable = new DataTable();
                adapter.Fill(usersTable);
                viewUsersDataGridView.DataSource = usersTable;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
