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

        private void Laborant_Load(object sender, EventArgs e)
        {

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
    }
}
