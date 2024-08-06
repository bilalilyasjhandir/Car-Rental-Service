using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalService
{
    public partial class RentCarForm : Form
    {
        public RentCarForm()
        {
            InitializeComponent();
           
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            if (carsComboBox.SelectedItem == null || customersComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a car and a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedCar = carsComboBox.SelectedItem as Car;
            var selectedCustomer = customersComboBox.SelectedItem as Customer;
            DateTime rentalDate = rentalDateDateTimePicker.Value;
            DateTime returnDate = returnDateDateTimePicker.Value;
            decimal totalAmount = selectedCar.RentalPrice;


            if (!selectedCar.IsAvailable)
            {
                MessageBox.Show("This car is not available for rent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "INSERT INTO Rentals (CarID, CustomerID, RentalDate, ReturnDate, TotalAmount VALUES (@CarID, @CustomerID, @RentalDate, @ReturnDate, @TotalAmount)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CarID", selectedCar.CarID);
                cmd.Parameters.AddWithValue("@CustomerID", selectedCustomer.CustomerID);
                cmd.Parameters.AddWithValue("@RentalDate", rentalDate);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                conn.Open();
                cmd.ExecuteNonQuery();

                string updateCarQuery = "UPDATE Cars SET IsAvailable = 0 WHERE CarID = @CarID";
                SqlCommand updateCarCmd = new SqlCommand(updateCarQuery, conn);
                updateCarCmd.Parameters.AddWithValue("@CarID", selectedCar.CarID);
                updateCarCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Car rented successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentCarForm_Load(object sender, EventArgs e)
        {
            LoadAvailableCars();
            LoadCustomers();
        }
        private void LoadAvailableCars()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT CarID, Make, Model, Year, RentalPrice, IsAvailable, Picture FROM Cars";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable carsTable = new DataTable();
                adapter.Fill(carsTable);

                foreach (DataRow row in carsTable.Rows)
                {
                    var car = new Car
                    {
                        CarID = (int)row["CarID"],
                        Make = row["Make"].ToString(),
                        Model = row["Model"].ToString(),
                        Year = (int)row["Year"],
                        RentalPrice = (decimal)row["RentalPrice"],
                        IsAvailable = (bool)row["IsAvailable"],
                        Picture = row["Picture"] as byte[]
                    };
                    carsComboBox.Items.Add(car);
                }

                carsComboBox.DisplayMember = "DisplayName";
            }
        }
        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT CustomerID, FirstName, LastName FROM Customers";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable customersTable = new DataTable();
                adapter.Fill(customersTable);

                foreach (DataRow row in customersTable.Rows)
                {
                    var customer = new Customer
                    {
                        CustomerID = (int)row["CustomerID"],
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString()
                    };
                    customersComboBox.Items.Add(customer);
                }

                customersComboBox.DisplayMember = "FullName";
            }
        }

        private void carsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carsComboBox.SelectedItem is Car selectedCar)
            {
                totalAmountLabel.Text = selectedCar.RentalPrice.ToString("C");
                if (selectedCar.Picture != null)
                {
                    using (MemoryStream ms = new MemoryStream(selectedCar.Picture))
                    {
                        carPictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    carPictureBox.Image = null;
                }
            }

        }
        private class Car
        {
            public int CarID { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public decimal RentalPrice { get; set; }
            public bool IsAvailable { get; set; }
            public byte[] Picture { get; set; }
            public string DisplayName => $"{Make} {Model} ({Year})";
        }

        private class Customer
        {
            public int CustomerID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName => $"{FirstName} {LastName}";
        }

    }
}
