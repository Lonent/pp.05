
namespace pp._05
{
    partial class AddPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.nPassportTextBox = new System.Windows.Forms.TextBox();
            this.sPassportTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.birthdateTextBox = new System.Windows.Forms.TextBox();
            this.addPatientlabel = new System.Windows.Forms.Label();
            this.fullNamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.insurancePTextBox = new System.Windows.Forms.TextBox();
            this.insuranceNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(95, 63);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(198, 20);
            this.fioTextBox.TabIndex = 0;
            // 
            // nPassportTextBox
            // 
            this.nPassportTextBox.Location = new System.Drawing.Point(149, 147);
            this.nPassportTextBox.Name = "nPassportTextBox";
            this.nPassportTextBox.Size = new System.Drawing.Size(144, 20);
            this.nPassportTextBox.TabIndex = 2;
            // 
            // sPassportTextBox
            // 
            this.sPassportTextBox.Location = new System.Drawing.Point(95, 147);
            this.sPassportTextBox.Name = "sPassportTextBox";
            this.sPassportTextBox.Size = new System.Drawing.Size(48, 20);
            this.sPassportTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(95, 189);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(198, 20);
            this.phoneTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(95, 105);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(198, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // birthdateTextBox
            // 
            this.birthdateTextBox.Location = new System.Drawing.Point(95, 309);
            this.birthdateTextBox.Name = "birthdateTextBox";
            this.birthdateTextBox.Size = new System.Drawing.Size(198, 20);
            this.birthdateTextBox.TabIndex = 10;
            // 
            // addPatientlabel
            // 
            this.addPatientlabel.AutoSize = true;
            this.addPatientlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPatientlabel.Location = new System.Drawing.Point(7, 9);
            this.addPatientlabel.Name = "addPatientlabel";
            this.addPatientlabel.Size = new System.Drawing.Size(395, 24);
            this.addPatientlabel.TabIndex = 11;
            this.addPatientlabel.Text = "Введите данные нового пользователя";
            this.addPatientlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // fullNamelabel
            // 
            this.fullNamelabel.AutoSize = true;
            this.fullNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNamelabel.Location = new System.Drawing.Point(101, 44);
            this.fullNamelabel.Name = "fullNamelabel";
            this.fullNamelabel.Size = new System.Drawing.Size(42, 16);
            this.fullNamelabel.TabIndex = 12;
            this.fullNamelabel.Text = "ФИО ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "email";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(92, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Телефон ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(92, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Серия и номер паспорта ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(104, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Дата рождения";
            // 
            // insurancePTextBox
            // 
            this.insurancePTextBox.Location = new System.Drawing.Point(95, 231);
            this.insurancePTextBox.Name = "insurancePTextBox";
            this.insurancePTextBox.Size = new System.Drawing.Size(198, 20);
            this.insurancePTextBox.TabIndex = 29;
            // 
            // insuranceNameTextBox
            // 
            this.insuranceNameTextBox.Location = new System.Drawing.Point(95, 273);
            this.insuranceNameTextBox.Name = "insuranceNameTextBox";
            this.insuranceNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.insuranceNameTextBox.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(92, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Название страховой компании";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(92, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Номер страхового полиса";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserButton.Location = new System.Drawing.Point(104, 356);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(173, 24);
            this.addUserButton.TabIndex = 38;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 461);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.insuranceNameTextBox);
            this.Controls.Add(this.insurancePTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullNamelabel);
            this.Controls.Add(this.addPatientlabel);
            this.Controls.Add(this.birthdateTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.sPassportTextBox);
            this.Controls.Add(this.nPassportTextBox);
            this.Controls.Add(this.fioTextBox);
            this.Name = "AddPatientForm";
            this.Text = "Добавление пользователя";
            this.Load += new System.EventHandler(this.addPatient_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox nPassportTextBox;
        private System.Windows.Forms.TextBox sPassportTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox birthdateTextBox;
        private System.Windows.Forms.Label addPatientlabel;
        private System.Windows.Forms.Label fullNamelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox insurancePTextBox;
        private System.Windows.Forms.TextBox insuranceNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addUserButton;
    }
}