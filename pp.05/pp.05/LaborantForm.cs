using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            mainPic.ImageLocation = @"C:\Users\mlkvm\Desktop\sharaga\Resources\laborant_1.jpeg";
            mainPic.ImageLocation = @"C:\Users\mlkvm\Desktop\sharaga\Resources\laborant_1.jpeg";
            mainPic.SizeMode = PictureBoxSizeMode.Zoom;
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
    }
}
