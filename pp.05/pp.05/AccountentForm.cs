using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Npgsql;

namespace pp._05
{
    public partial class AccountantForm : Form
    {
        public AccountantForm(string name)
        {
            InitializeComponent();
            fioLabel.Text = name;
            roleLabel.Text = "Бухгалтер";
        }

        private void imgBox1_SizeChanged(object sender, EventArgs e)
        {
            if (mainPic.Image != null)
            {

            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: load data or do other initialization
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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=pp.05;User Id=postgres;Password=0000;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand($@"SELECT o.full_name, o.price 
                                                   FROM orders o
                                                   JOIN patients p ON o.patient_id = p.id 
                                                   WHERE p.insurance_name = '{innsuranceNameTextBox.Text}'", connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        Dictionary<string, decimal> pricesByFullName = new Dictionary<string, decimal>();
                        while (reader.Read())
                        {
                            string fullName = reader.GetString(0);
                            decimal price = reader.GetDecimal(1);

                            if (pricesByFullName.ContainsKey(fullName))
                            {
                                pricesByFullName[fullName] += price;
                            }
                            else
                            {
                                pricesByFullName[fullName] = price;
                            }
                        }

                        Document document = new Document();
                        PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream($"{innsuranceNameTextBox.Text}.pdf", FileMode.Create));
                        document.Open();

                        foreach (KeyValuePair<string, decimal> entry in pricesByFullName)
                        {
                            string fullName = entry.Key;
                            decimal total = entry.Value;

                            document.Add(new Paragraph($"Name: {fullName} - Total price: {total}"));
                        }

                        decimal overallTotal = pricesByFullName.Values.Sum();
                        document.Add(new Paragraph($"Overall total price: {overallTotal}"));

                        document.Close();

                        MessageBox.Show($"PDF file saved to: {Path.GetFullPath($"{innsuranceNameTextBox.Text}.pdf")}");
                    }
                }
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
