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
    public partial class AccountantForm : Form
    {
        public AccountantForm(string name)
        {
            InitializeComponent();
            fioLabel.Text =  name ;
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
    }
}
