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
using Npgsql;

namespace pp._05
{
    public partial class LoginForm : Form
    {
        
        private string captchaValue = "";
        public LoginForm()
        {
            InitializeComponent();
            passwordField.UseSystemPasswordChar = true;
            GenerateCaptcha();
            buttonRestockCaptcha.Click += button1_Click;
        }
        private bool captchaVisible = false;

        private void GenerateCaptcha()
        {
            if (!captchaVisible)
            {
                // Hide the captcha control and restock button
                pictureBoxCaptcha.Visible = false;
                textBoxCaptcha.Visible = false;
                buttonRestockCaptcha.Visible = false;
                buttonRestockCaptcha.Visible = false;
            }
            else
            {
                // Show the captcha control and restock button
                pictureBoxCaptcha.Visible = true;
                textBoxCaptcha.Visible = true;
                buttonRestockCaptcha.Visible = true;
                buttonRestockCaptcha.Visible = true;

                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                Random random = new Random();
                captchaValue = new string(Enumerable.Repeat(chars, 4)
                  .Select(s => s[random.Next(s.Length)]).ToArray());

                Bitmap bitmap = new Bitmap(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                Font font = new Font("Arial", 20, FontStyle.Bold);
                Brush brush = new SolidBrush(Color.Black);
                graphics.DrawString(captchaValue, font, brush, 10, 10);
                pictureBoxCaptcha.Image = bitmap;
            }
        }





        private bool isFirstLoginAttempt = true;
        private DateTime lastFailedCaptchaTime = DateTime.MinValue;
        private void ButtonLogin_Click(object sender, EventArgs e)
        {

           
            if (!isFirstLoginAttempt && textBoxCaptcha.Text != captchaValue)
            {
                if (DateTime.Now.Subtract(lastFailedCaptchaTime).TotalSeconds < 10)
                {
                    MessageBox.Show("Too many attempts. Try again later.");
                    return;
                }
                else
                {
                    lastFailedCaptchaTime = DateTime.Now;
                    MessageBox.Show("Wrong captcha!");
                    GenerateCaptcha();
                    return;
                }
            }

            else
            {
                // Authenticate the user
                string name = AuthenticateUser(loginField.Text, passwordField.Text);
                if (name != null)
                {
                    // Get the user's type from the database
                    string userType = GetUserType(loginField.Text);

                    // Grant the user access to the application
                    if (userType == "1")
                    {

                        AdminForm mainForm = new AdminForm(name);
                        mainForm.Show();
                        this.Hide();
                    }
                    else if (userType == "2")
                    {
                        LaborantForm mainForm = new LaborantForm(name);
                        mainForm.Show();
                        this.Hide();
                    }
                    else if (userType == "3")
                    {
                        AccountantForm mainForm = new AccountantForm(name);
                        mainForm.Show();
                        this.Hide();
                    }
                        // else if (userType == "4")
                        // {


                        // }

                    }
            }
            if (isFirstLoginAttempt)
            {
                isFirstLoginAttempt = false;
                captchaVisible = true; // Set the flag to show the captcha
                GenerateCaptcha();
                return;
            }

            GenerateCaptcha();
        }

        private string GetUserType(string login)
        {
            string userType = null;
            string connectionString = "Server=localhost;Port=5432;Database=pp05;User Id=postgres;Password=1432;";
            string sql = "SELECT type FROM Users WHERE Login=@Login;";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            userType = result.ToString();
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }

            return userType;
        }

        // DB connection
        private string AuthenticateUser(string login, string password)
        {
            string name = null;
            string connectionString = "Server=localhost;Port=5432;Database=pp05;User Id=postgres;Password=1432;";
            string sql = "SELECT name FROM Users WHERE Login=@Login AND Password=@Password;";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            name = result.ToString();

                            // Update the lastenter column with the current date and time
                            sql = "UPDATE Users SET lastenter = @LastEnter WHERE Login = @Login";
                            using (NpgsqlCommand updateCommand = new NpgsqlCommand(sql, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@LastEnter", DateTime.Now);
                                updateCommand.Parameters.AddWithValue("@Login", login);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }

            return name;
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordField.UseSystemPasswordChar = false;
            }
            else
            {
                passwordField.UseSystemPasswordChar = true;
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}