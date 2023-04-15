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
            // считывание штрих кода с помощью reader 
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pic.Image);

            // цикл отображения результата в случае успешного декодирования
            if (result != null)
                txtDecode.Text = result.Text;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void fillBiomaterial_Click(object sender, EventArgs e)
        {
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
                        while (reader.Read())
                        {
                            patientId = reader.GetInt32(0);
                        }
                    }
                }
            }

            // Update the blood table with the patient id and barcode
            BarcodeReader brcreader = new BarcodeReader();
            var result = brcreader.Decode((Bitmap)pic.Image);
            string barcode = result.Text;
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO blood (patient, barcode) VALUES ({patientId}, '{barcode}') RETURNING id", connection))
                {
                    int bloodId = (int)command.ExecuteScalar();
                }
            }
        }
    }
}
