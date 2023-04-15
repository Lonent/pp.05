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
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;
            string socialSecNumber = socialSecNumberTextBox.Text;
            string socialType = socialTypeComboBox.Text;
            string phone = phoneTextBox.Text;
            string sPassport = sPassportTextBox.Text;
            string nPassport = nPassportTextBox.Text;
            string birthdate = birthdateTextBox.Text;
            string country = countryTextBox.Text;
            string insuranceName = insuranceNameTextBox.Text;
            string insuranceAddress = insuranceAddressTextBox.Text;
            string insuranceInn = insuranceInnTextBox.Text;
            string insuranceP = insurancePTextBox.Text;
            string insuranceBik = insuranceBikTextBox.Text;

            // Check for empty fields
            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(socialSecNumber) || string.IsNullOrEmpty(socialType) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(sPassport) ||
                string.IsNullOrEmpty(nPassport) || string.IsNullOrEmpty(birthdate) || string.IsNullOrEmpty(country) || string.IsNullOrEmpty(insuranceName) ||
                string.IsNullOrEmpty(insuranceAddress) || string.IsNullOrEmpty(insuranceInn) || string.IsNullOrEmpty(insuranceP) || string.IsNullOrEmpty(insuranceBik))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Insert into patient table
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            string query = "INSERT INTO patients (full_name, login, pwd, email, social_sec_number, social_type, phone, passport_s, passport_n, birthdate_timestamp, country, insurance_name, insurance_address, insurance_inn, insurance_p, insurance_bik) " +
                    "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16) RETURNING id";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@p1", NpgsqlDbType.Varchar, fio);
                command.Parameters.AddWithValue("@p2", NpgsqlDbType.Varchar, login);
                command.Parameters.AddWithValue("@p3", NpgsqlDbType.Varchar, password);
                command.Parameters.AddWithValue("@p4", NpgsqlDbType.Varchar, email);
                command.Parameters.AddWithValue("@p5", NpgsqlDbType.Varchar, socialSecNumber);
                command.Parameters.AddWithValue("@p6", NpgsqlDbType.Varchar, socialType);
                command.Parameters.AddWithValue("@p7", NpgsqlDbType.Varchar, phone);
                command.Parameters.AddWithValue("@p8", NpgsqlDbType.Varchar, sPassport);
                command.Parameters.AddWithValue("@p9", NpgsqlDbType.Varchar, nPassport);
                command.Parameters.AddWithValue("@p10", NpgsqlDbType.Varchar, birthdate);
                command.Parameters.AddWithValue("@p11", NpgsqlDbType.Varchar, country);
                command.Parameters.AddWithValue("@p12", NpgsqlDbType.Varchar, insuranceName);
                command.Parameters.AddWithValue("@p13", NpgsqlDbType.Varchar, insuranceAddress);
                command.Parameters.AddWithValue("@p14", NpgsqlDbType.Varchar, insuranceInn);
                command.Parameters.AddWithValue("@p15", NpgsqlDbType.Varchar, insuranceP);
                command.Parameters.AddWithValue("@p16", NpgsqlDbType.Varchar, insuranceBik);

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
