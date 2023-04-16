using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace pp._05
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void insuranceNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPatient_Load(object sender, EventArgs e)
        {

        }

        private void fioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            // Get input values
            string fio = fioTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string sPassport = sPassportTextBox.Text;
            string nPassport = nPassportTextBox.Text;
            string birthdate = birthdateTextBox.Text;
            string insuranceName = insuranceNameTextBox.Text;
            string insuranceP = insurancePTextBox.Text;

            // Check for empty fields
            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(sPassport) ||
                string.IsNullOrEmpty(nPassport) || string.IsNullOrEmpty(birthdate) || string.IsNullOrEmpty(insuranceName) || string.IsNullOrEmpty(insuranceP))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Insert into patient table
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            string query = "INSERT INTO patients (full_name, email, phone, passport_s, passport_n, birthdate_timestamp, insurance_name, insurance_p) " +
                    "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8) RETURNING id";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@p1", NpgsqlDbType.Varchar, fio);
                command.Parameters.AddWithValue("@p2", NpgsqlDbType.Varchar, email);
                command.Parameters.AddWithValue("@p3", NpgsqlDbType.Varchar, phone);
                command.Parameters.AddWithValue("@p4", NpgsqlDbType.Varchar, sPassport);
                command.Parameters.AddWithValue("@p5", NpgsqlDbType.Varchar, nPassport);
                command.Parameters.AddWithValue("@p6", NpgsqlDbType.Varchar, birthdate);
                command.Parameters.AddWithValue("@p7", NpgsqlDbType.Varchar, insuranceName);
                command.Parameters.AddWithValue("@p8", NpgsqlDbType.Varchar, insuranceP);

                connection.Open();
                int newId = Convert.ToInt32(command.ExecuteScalar());
                if (newId > 0)
                {
                    MessageBox.Show("User added successfully. New ID: " + newId);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add user.");
                }
            }
        }



        private void addPatient_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
