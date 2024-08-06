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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;
            int year = int.Parse(yearTextBox.Text);
            decimal rentalPrice = rentalPriceNumericUpDown.Value;
            bool isAvailable = isAvailableCheckBox.Checked;

            byte[] imageBytes = null;
            if (carPictureBox.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        carPictureBox.Image.Save(ms, carPictureBox.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model) || year == 0 || rentalPrice == 0)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "INSERT INTO Cars (Make, Model, Year, RentalPrice, IsAvailable, Picture) VALUES (@Make, @Model, @Year, @RentalPrice, @IsAvailable, @Picture)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Make", make);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@RentalPrice", rentalPrice);
                cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);
                cmd.Parameters.AddWithValue("@Picture", imageBytes);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Car added successfully!");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    carPictureBox.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;

            if (string.IsNullOrWhiteSpace(make) && string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Please enter at least one detail to load the car information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT TOP 1 * FROM Cars WHERE Make = @Make OR Model = @Model";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Make", make);
                cmd.Parameters.AddWithValue("@Model", model);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        makeTextBox.Text = reader["Make"].ToString();
                        modelTextBox.Text = reader["Model"].ToString();
                        yearTextBox.Text = reader["Year"].ToString();
                        rentalPriceNumericUpDown.Value = (decimal)reader["RentalPrice"];
                        isAvailableCheckBox.Checked = (bool)reader["IsAvailable"];

                        byte[] imageBytes = reader["Picture"] as byte[];
                        if (imageBytes != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                carPictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            carPictureBox.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Car not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;
            string year = yearTextBox.Text;
            decimal rentalPrice = rentalPriceNumericUpDown.Value;
            bool isAvailable = isAvailableCheckBox.Checked;

            byte[] imageBytes = null;
            if (carPictureBox.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        carPictureBox.Image.Save(ms, carPictureBox.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(year) || rentalPrice == 0)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "UPDATE Cars SET Make = @Make, Model = @Model, Year = @Year, RentalPrice = @RentalPrice, IsAvailable = @IsAvailable, Picture = @Picture WHERE Make = @Make OR Model = @Model OR Year = @Year";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Make", make);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@RentalPrice", rentalPrice);
                cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);
                cmd.Parameters.AddWithValue("@Picture", imageBytes);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Car updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No car found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;

            if (string.IsNullOrWhiteSpace(make) && string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Please enter at least one detail to delete the car information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "DELETE FROM Cars WHERE Make = @Make OR Model = @Model";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Make", make);
                cmd.Parameters.AddWithValue("@Model", model);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Car deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makeTextBox.Clear();
                    modelTextBox.Clear();
                    yearTextBox.Clear();
                    rentalPriceNumericUpDown.Value = 0;
                    isAvailableCheckBox.Checked = false;
                    carPictureBox.Image = null;
                }
                else
                {
                    MessageBox.Show("No car found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void makeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                modelTextBox.Focus();
            }
        }

        private void modelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                yearTextBox.Focus();
            }
        }

        private void yearTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                rentalPriceNumericUpDown.Focus();
            }
        }

        private void rentalPriceNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                browseButton.Focus();
            }
        }

        private void isAvailableCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                saveButton.Focus();
            }
        }

        private void yearLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

