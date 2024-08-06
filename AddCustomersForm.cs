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
    public partial class AddCustomersForm : Form
    {
        public AddCustomersForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string driverLicenseNumber = driverLicenseTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(driverLicenseNumber))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "INSERT INTO Customers (FirstName, LastName, Email, PhoneNumber, DriverLicenseNumber) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @DriverLicenseNumber)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@DriverLicenseNumber", driverLicenseNumber);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName) && string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter at least one detail to load the customer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT TOP 1 * FROM Customers WHERE FirstName = @FirstName OR LastName = @LastName OR Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        firstNameTextBox.Text = reader["FirstName"].ToString();
                        lastNameTextBox.Text = reader["LastName"].ToString();
                        emailTextBox.Text = reader["Email"].ToString();
                        phoneNumberTextBox.Text = reader["PhoneNumber"].ToString();
                        driverLicenseTextBox.Text = reader["DriverLicenseNumber"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string driverLicenseNumber = driverLicenseTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(driverLicenseNumber))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, DriverLicenseNumber = @DriverLicenseNumber WHERE FirstName = @FirstName OR LastName = @LastName OR Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@DriverLicenseNumber", driverLicenseNumber);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No customer found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName) && string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter at least one detail to delete the customer information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "DELETE FROM Customers WHERE FirstName = @FirstName OR LastName = @LastName OR Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    firstNameTextBox.Clear();
                    lastNameTextBox.Clear();
                    emailTextBox.Clear();
                    phoneNumberTextBox.Clear();
                    driverLicenseTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("No customer found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void firstNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                lastNameTextBox.Focus();
            }
        }

        private void lastNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                emailTextBox.Focus();
            }
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                phoneNumberTextBox.Focus();
            }
        }

        private void phoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                driverLicenseTextBox.Focus();
            }
        }

        private void driverLicenseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                saveButton.Focus();
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
