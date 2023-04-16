using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Npgsql;

namespace pp._05
{
    public partial class AdminForm : Form
    {
        public AdminForm(string name)
        {
            InitializeComponent();
            fioLabel.Text =  name ;

                roleLabel.Text = "Адмитнистратор";
            
        }

        private void imgBox1_SizeChanged(object sender, EventArgs e)
        {
            if (mainPic.Image != null)
            {
                
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=pp05;User Id=postgres;Password=1432;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT id, full_name, login, pwd, guid, email, social_sec_number, ein, social_type, phone, passport_s, passport_n, birthdate_timestamp, country, insurance_name, insurance_address, insurance_inn, ipadress, insurance_p, insurance_bik, ua FROM patients", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        patientsGridView.DataSource = dataTable;
                        patientsGridView.Columns[0].HeaderText = "id";
                        patientsGridView.Columns[1].HeaderText = "full_name";
                        patientsGridView.Columns[2].HeaderText = "login";
                        patientsGridView.Columns[3].HeaderText = "pwd";
                        patientsGridView.Columns[4].HeaderText = "guid";
                        patientsGridView.Columns[5].HeaderText = "email";
                        patientsGridView.Columns[6].HeaderText = "social_sec_number";
                        patientsGridView.Columns[7].HeaderText = "ein";
                        patientsGridView.Columns[8].HeaderText = "social_type";
                        patientsGridView.Columns[9].HeaderText = "phone";
                        patientsGridView.Columns[10].HeaderText = "passport_s";
                        patientsGridView.Columns[11].HeaderText = "passport_n";
                        patientsGridView.Columns[12].HeaderText = "birthdate_timestamp";
                        patientsGridView.Columns[13].HeaderText = "country";
                        patientsGridView.Columns[14].HeaderText = "insurance_name";
                        patientsGridView.Columns[15].HeaderText = "insurance_address";
                        patientsGridView.Columns[16].HeaderText = "insurance_inn";
                        patientsGridView.Columns[17].HeaderText = "ipadress";
                        patientsGridView.Columns[18].HeaderText = "insurance_p";
                        patientsGridView.Columns[19].HeaderText = "insurance_bik";
                        patientsGridView.Columns[20].HeaderText = "ua";
                    }
                }
            }
     
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT name, price, id, count FROM materials", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        materialsGridView.DataSource = dataTable;
                        
                        materialsGridView.Columns[0].HeaderText = "name";
                        materialsGridView.Columns[1].HeaderText = "price";
                        materialsGridView.Columns[2].HeaderText = "id";
                        materialsGridView.Columns[3].HeaderText = "count";
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }

        private void fioStatic_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void patientsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddPatientForm mainForm = new AddPatientForm();
            mainForm.Show();
        }

        private void materialsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadMaterials()
        {
            string connectionString = "Server=localhost;Port=5432;Database=pp05;User Id=postgres;Password=1432;";
            using (NpgsqlConnection dbConnection = new NpgsqlConnection(connectionString))
            {
                dbConnection.Open();
                string query = "SELECT * FROM materials";
                using (NpgsqlCommand dbCommand = new NpgsqlCommand(query, dbConnection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(dbCommand);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    materialsGridView.DataSource = table;
                }
                dbConnection.Close();
            }
        }

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (materialsGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            // Remember the selected row
            int index = materialsGridView.SelectedRows[0].Index;

            // Check if all fields are filled in
            if (string.IsNullOrWhiteSpace(materialsGridView.Rows[index].Cells[0].Value?.ToString())
                || string.IsNullOrWhiteSpace(materialsGridView.Rows[index].Cells[1].Value?.ToString())
                || string.IsNullOrWhiteSpace(materialsGridView.Rows[index].Cells[3].Value?.ToString()))
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            // Read data
            string name = materialsGridView.Rows[index].Cells[0].Value.ToString();
            string price = materialsGridView.Rows[index].Cells[1].Value.ToString();
            string id = materialsGridView.Rows[index].Cells[2].Value.ToString();
            string count = materialsGridView.Rows[index].Cells[3].Value.ToString();

            // Create a connection
            string connectionString = "Server=localhost;Port=5432;Database=pp05;User Id=postgres;Password=1432;";
            using (NpgsqlConnection dbConnection = new NpgsqlConnection(connectionString))
            {
                // Execute the query
                dbConnection.Open();
                string query = $"INSERT INTO materials (name, price, count) VALUES ('{name}', '{price}', '{count}')";
                using (NpgsqlCommand dbCommand = new NpgsqlCommand(query, dbConnection))
                {
                    if (dbCommand.ExecuteNonQuery() != 1)
                        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                    else
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                }
                dbConnection.Close();

            }
            LoadMaterials();

        }







        private void changeMaterialButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (materialsGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            // Remember the selected row
            int index = materialsGridView.SelectedRows[0].Index;

            // Check if all fields are filled in
            if (string.IsNullOrWhiteSpace(materialsGridView.Rows[index].Cells[0].Value?.ToString())
                || string.IsNullOrWhiteSpace(materialsGridView.Rows[index].Cells[1].Value?.ToString())
                || string.IsNullOrWhiteSpace(materialsGridView.Rows[index].Cells[3].Value?.ToString()))
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            // Read data
            string name = materialsGridView.Rows[index].Cells[0].Value.ToString();
            string price = materialsGridView.Rows[index].Cells[1].Value.ToString();
            string id = materialsGridView.Rows[index].Cells[2].Value.ToString();
            string count = materialsGridView.Rows[index].Cells[3].Value.ToString();

            // Create a connection
            string connectionString = "Server=localhost;Port=5432;Database=pp05;User Id=postgres;Password=1432;";
            using (NpgsqlConnection dbConnection = new NpgsqlConnection(connectionString))
            {
                // Execute the query
                dbConnection.Open();
                string query = $"UPDATE materials SET name = '{name}', price = '{price}', count = '{count}' WHERE id = {id}";
                using (NpgsqlCommand dbCommand = new NpgsqlCommand(query, dbConnection))
                {
                    if (dbCommand.ExecuteNonQuery() != 1)
                        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                    else
                        MessageBox.Show("Данные изменены!", "Внимание!");
                        materialsGridView.Rows.RemoveAt(index);
                }
                dbConnection.Close();
            }
            LoadMaterials();
        }

        private void deleteMaterialButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (materialsGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            // Remember the selected row
            int index = materialsGridView.SelectedRows[0].Index;

            // Check if all fields are filled in
            if (string.IsNullOrWhiteSpace(materialsGridView.Rows[index].Cells[2].Value?.ToString()))
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            // Read data
            string id = materialsGridView.Rows[index].Cells[2].Value.ToString();

            // Create a connection
            string connectionString = "Server=localhost;Port=5432;Database=pp05;User Id=postgres;Password=1432;";
            using (NpgsqlConnection dbConnection = new NpgsqlConnection(connectionString))
            {
                // Execute the query
                dbConnection.Open();
                string query = $"DELETE FROM materials WHERE id = {id}";
                using (NpgsqlCommand dbCommand = new NpgsqlCommand(query, dbConnection))
                {
                    if (dbCommand.ExecuteNonQuery() != 1)
                        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                    else
                        MessageBox.Show("Данные удалены!", "Внимание!");
                        materialsGridView.Rows.RemoveAt(index);
                }
                dbConnection.Close();

            }

        }
    }
}
