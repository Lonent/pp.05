using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Npgsql;

namespace pp._05
{
    public partial class LaborantForm : Form
    {

        private int elapsedSeconds = 0;
        public LaborantForm(string name)
        {
            InitializeComponent();
            fioLabel.Text = name;
            timerLogout.Start();
            roleLabel.Text = "Лаборант";
            timerLogout.Tag = 600;
            
        }



        private DataTable ordersTable;

        private void Laborant_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void fioLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("АНАЛИЗАТОР ОТРАБОТАЛ НОРМАЛЬНО");
        }


        
        private void timer1_Tick(object sender, EventArgs e)
        {

            elapsedSeconds++;
            int remainingSeconds = (int)timerLogout.Tag - elapsedSeconds;
            if (remainingSeconds == 300)
            {
                MessageBox.Show("Осталось 10 минут!");
            }
            else if (remainingSeconds < 0)
            {
                LoginForm mainForm = new LoginForm();
                mainForm.Show();
                this.Close();
            }
            else
            {
                labelCountdown.Text = $"Countdown: {remainingSeconds / 3600:D2}:{remainingSeconds / 60 % 10:D2}:{remainingSeconds % 60:D2}";
            }



            
        }

        

        

        

        private void LaborantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the timer when the form is closed
            timerLogout.Stop();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
            this.Close();
        }

        private void labelElapsedTime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try { 

                // считывание штрих кода с помощью reader 
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)pic.Image);

                // цикл отображения результата в случае успешного декодирования
                if (result != null)
                    txtDecode.Text = result.Text;
            }
            catch
            {
                MessageBox.Show("Отсутствует штрихкод.");
                return;
            }
        }

        private string GenerateUniqueCode(int orderDigit)
        {
            Random rnd = new Random();
            const string chars = "0123456789";
            string date = DateTime.Now.ToString("ddMMyyyy");
            string uniqueCode = new string(Enumerable.Repeat(chars, 6).Select(s => s[rnd.Next(s.Length)]).ToArray());
            return $"{orderDigit}{date}{uniqueCode}";
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            // генерация рандомного значения

            if (string.IsNullOrEmpty(txtEncode.Text))
            {
                MessageBox.Show("Поле кода пустое. Пожалуйста, введите значение.");
                return;
            }
            else { 
            Random rnd = new Random();
                int orderDigit = int.Parse(txtEncode.Text);

                // генерация уникального кода
                string barcodeText = GenerateUniqueCode(orderDigit);

                // Создание объекта записи штрих-кода
                BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                Bitmap barcodeBitmap = writer.Write(barcodeText);

                // Создание нового PDF-документа
                Document document = new Document();
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream("barcode.pdf", FileMode.Create));
                document.Open();
                //document.NewPage();

                // создание объекта изображения
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(barcodeBitmap, System.Drawing.Imaging.ImageFormat.Bmp);

                pdfImage.ScaleToFit(document.PageSize.Width, document.PageSize.Height);

                document.Add(pdfImage);

                document.Close();

                // установка изображения в пдф
                pic.Image = barcodeBitmap;
            }
            
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void fillBiomaterial_Click(object sender, EventArgs e)
        {
            // Check if patientFioTextBox is empty
            if (string.IsNullOrEmpty(patientFioTextBox.Text))
            {
                MessageBox.Show("Поле ФИО пациента не может быть пустым");
                return;
            }

            // Retrieve patient id from the database using their name
            string patientName = patientFioTextBox.Text;
            int patientId = 0;
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand($"SELECT id FROM patients WHERE full_name = '{patientName}'", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                patientId = reader.GetInt32(0);
                            }
                        }
                        else
                        {
                            // Patient not found in the database
                            DialogResult dialogResult = MessageBox.Show("Пациент не найден в базе данных. Хотите добавить нового пациента?", "Пациент не найден", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                // Redirect user to the AddPatientForm form
                                AddPatientForm addPatientForm = new AddPatientForm();
                                addPatientForm.Show();
                            }
                            return;
                        }
                    }
                }
            }

            // Check if txtEncode is empty
            if (string.IsNullOrEmpty(txtEncode.Text))
            {
                MessageBox.Show("Код штрих-кода не может быть пустым");
                return;
            }

            // Update the blood table with the patient id and barcode
            BarcodeReader brcreader = new BarcodeReader();
            var result = brcreader.Decode((Bitmap)pic.Image);
            string barcode = result.Text;
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand insertCommand = new NpgsqlCommand($"INSERT INTO blood (patient, barcode, date) VALUES ({patientId}, '{barcode}', CURRENT_DATE) RETURNING id", connection))
                {
                    int bloodId = (int)insertCommand.ExecuteScalar();
                    MessageBox.Show("Биоматериалы успешно добавлены");
                }
            }
        }

        private void patientFioTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void LoadOrders()
        {
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM orders", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (string.IsNullOrEmpty(orderSearchField.Text))
                        {
                            ordersGridView.DataSource = dataTable;
                        }
                        else
                        {
                            SearchOrders(orderSearchField.Text);
                        }

                        ordersGridView.Columns[0].HeaderText = "date";
                        ordersGridView.Columns[1].HeaderText = "service_id";
                        ordersGridView.Columns[2].HeaderText = "patient_id";
                        ordersGridView.Columns[3].HeaderText = "barcode";
                        ordersGridView.Columns[4].HeaderText = "insurance_p";
                        ordersGridView.Columns[5].HeaderText = "full_name";
                        ordersGridView.Columns[6].HeaderText = "b_date";
                        ordersGridView.Columns[7].HeaderText = "price";
                        ordersGridView.Columns[8].HeaderText = "id";
                    }
                }
            }
        }

        private void SearchOrders(string searchValue)
        {
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM orders WHERE date::text LIKE '%{searchValue}%' OR CAST(service_id AS TEXT) LIKE '%{searchValue}%' OR CAST(patient_id AS TEXT) LIKE '%{searchValue}%' OR CAST(barcode AS TEXT) LIKE '%{searchValue}%' OR insurance_p LIKE '%{searchValue}%' OR full_name LIKE '%{searchValue}%' OR b_date::text LIKE '%{searchValue}%' OR price LIKE '%{searchValue}%'", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        ordersGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void orderSearchField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (ordersGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            // Remember the selected row
            int index = ordersGridView.SelectedRows[0].Index;

            // Check if all fields are filled in
            if (string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[0].Value?.ToString())
                || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[1].Value?.ToString())
                || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[2].Value?.ToString())
                || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[3].Value?.ToString())
                || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[4].Value?.ToString())
                || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[5].Value?.ToString())
                || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[6].Value?.ToString())
                || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[7].Value?.ToString()))
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            // Read data
            string date = ordersGridView.Rows[index].Cells[0].Value.ToString();
            string service_id = ordersGridView.Rows[index].Cells[1].Value.ToString();
            string patient_id = ordersGridView.Rows[index].Cells[2].Value.ToString();
            string barcode = ordersGridView.Rows[index].Cells[3].Value.ToString();
            string insurance_p = ordersGridView.Rows[index].Cells[4].Value.ToString();
            string full_name = ordersGridView.Rows[index].Cells[5].Value.ToString();
            string b_date = ordersGridView.Rows[index].Cells[6].Value.ToString();
            string price = ordersGridView.Rows[index].Cells[7].Value.ToString();

            // Create a connection
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            using (NpgsqlConnection dbConnection = new NpgsqlConnection(connectionString))
            {
                // Execute the query
                dbConnection.Open();
                string query = $"INSERT INTO orders (date, service_id, patient_id, barcode, insurance_p, full_name, b_date, price) VALUES ('{date}', '{service_id}', '{patient_id}', '{barcode}', '{insurance_p}', '{full_name}', '{b_date}', '{price}')";
                using (NpgsqlCommand dbCommand = new NpgsqlCommand(query, dbConnection))
                {
                    if (dbCommand.ExecuteNonQuery() != 1)
                        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                    else
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                }
                dbConnection.Close();
            }
            LoadOrders();
        }

        private void changeOrderButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (ordersGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            // Remember the selected row
            int index = ordersGridView.SelectedRows[0].Index;

            // Check if all fields are filled in
            if (string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[0].Value?.ToString())
                || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[1].Value?.ToString())
    || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[2].Value?.ToString())
    || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[3].Value?.ToString())
    || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[4].Value?.ToString())
    || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[5].Value?.ToString())
    || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[6].Value?.ToString())
    || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[7].Value?.ToString())
    || string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[8].Value?.ToString()))
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            // Read data
            string date = ordersGridView.Rows[index].Cells[0].Value.ToString();
            string service_id = ordersGridView.Rows[index].Cells[1].Value.ToString();
            string patient_id = ordersGridView.Rows[index].Cells[2].Value.ToString();
            string barcode = ordersGridView.Rows[index].Cells[3].Value.ToString();
            string insurance_p = ordersGridView.Rows[index].Cells[4].Value.ToString();
            string full_name = ordersGridView.Rows[index].Cells[5].Value.ToString();
            string b_date = ordersGridView.Rows[index].Cells[6].Value.ToString();
            string price = ordersGridView.Rows[index].Cells[7].Value.ToString();
            string id = ordersGridView.Rows[index].Cells[8].Value.ToString();

            // Create a connection
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            using (NpgsqlConnection dbConnection = new NpgsqlConnection(connectionString))
            {
                // Execute the query
                dbConnection.Open();
                string query = $"UPDATE orders SET date = '{date}', service_id = '{service_id}', patient_id = '{patient_id}', barcode = '{barcode}', insurance_p = '{insurance_p}', full_name = '{full_name}', b_date = '{b_date}', price = '{price}' WHERE id = {id}";
                using (NpgsqlCommand dbCommand = new NpgsqlCommand(query, dbConnection))
                {
                    if (dbCommand.ExecuteNonQuery() != 1)
                        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                    else
                    {
                        MessageBox.Show("Данные изменены!", "Внимание!");
                        ordersGridView.Rows.RemoveAt(index);
                    }
                }
                dbConnection.Close();
            }
            LoadOrders();
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (ordersGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }
            // Remember the selected row
            int index = ordersGridView.SelectedRows[0].Index;

            // Check if all fields are filled in
            if (string.IsNullOrWhiteSpace(ordersGridView.Rows[index].Cells[8].Value?.ToString()))
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            // Read data
            string id = ordersGridView.Rows[index].Cells[8].Value.ToString();

            // Create a connection
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            using (NpgsqlConnection dbConnection = new NpgsqlConnection(connectionString))
            {
                // Execute the query
                dbConnection.Open();
                string query = $"DELETE FROM orders WHERE id = {id}";
                using (NpgsqlCommand dbCommand = new NpgsqlCommand(query, dbConnection))
                {
                    if (dbCommand.ExecuteNonQuery() != 1)
                        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                    else
                    {
                        MessageBox.Show("Данные удалены!", "Внимание!");
                        ordersGridView.Rows.RemoveAt(index);
                    }
                }
                dbConnection.Close();
            }
        }

        private void orderSearchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void orderSearchField_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderSearchField.Text))
            {
                LoadOrders();
            }
            else
            {
                SearchOrders(orderSearchField.Text);
            }
        }
    }
    }
