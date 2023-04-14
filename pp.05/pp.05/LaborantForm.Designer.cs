
namespace pp._05
{
    partial class LaborantForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.roleStatic = new System.Windows.Forms.Label();
            this.fioStatic = new System.Windows.Forms.Label();
            this.fioLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.analizerButton = new System.Windows.Forms.Button();
            this.timerLogout = new System.Windows.Forms.Timer(this.components);
            this.labelCountdown = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 514);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.mainPic);
            this.tabPage1.Controls.Add(this.roleLabel);
            this.tabPage1.Controls.Add(this.exitButton);
            this.tabPage1.Controls.Add(this.roleStatic);
            this.tabPage1.Controls.Add(this.fioStatic);
            this.tabPage1.Controls.Add(this.fioLabel);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личный кабинет";
            // 
            // mainPic
            // 
            this.mainPic.Location = new System.Drawing.Point(20, 17);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(100, 100);
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.Location = new System.Drawing.Point(208, 53);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(27, 15);
            this.roleLabel.TabIndex = 4;
            this.roleLabel.Text = "role";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(472, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 22);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // roleStatic
            // 
            this.roleStatic.AutoSize = true;
            this.roleStatic.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleStatic.Location = new System.Drawing.Point(159, 53);
            this.roleStatic.Name = "roleStatic";
            this.roleStatic.Size = new System.Drawing.Size(35, 15);
            this.roleStatic.TabIndex = 3;
            this.roleStatic.Text = "Роль:";
            // 
            // fioStatic
            // 
            this.fioStatic.AutoSize = true;
            this.fioStatic.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioStatic.Location = new System.Drawing.Point(159, 30);
            this.fioStatic.Name = "fioStatic";
            this.fioStatic.Size = new System.Drawing.Size(40, 15);
            this.fioStatic.TabIndex = 2;
            this.fioStatic.Text = "Ф.И.О:";
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(208, 30);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(23, 15);
            this.fioLabel.TabIndex = 1;
            this.fioLabel.Text = "fio";
            this.fioLabel.Click += new System.EventHandler(this.fioLabel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Истории входа";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(570, 486);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Материалы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.analizerButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(570, 486);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Анализатор";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // analizerButton
            // 
            this.analizerButton.Location = new System.Drawing.Point(52, 42);
            this.analizerButton.Name = "analizerButton";
            this.analizerButton.Size = new System.Drawing.Size(425, 71);
            this.analizerButton.TabIndex = 7;
            this.analizerButton.Text = "РАБОТАТЬ!";
            this.analizerButton.UseVisualStyleBackColor = true;
            this.analizerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerLogout
            // 
            this.timerLogout.Interval = 1000;
            this.timerLogout.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Location = new System.Drawing.Point(20, 531);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(30, 13);
            this.labelCountdown.TabIndex = 10;
            this.labelCountdown.Text = "Time";
            this.labelCountdown.Click += new System.EventHandler(this.labelElapsedTime_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pp._05.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pp._05.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(6, 380);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::pp._05.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(6, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::pp._05.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(6, 380);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // LaborantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 553);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.tabControl1);
            this.Name = "LaborantForm";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.Laborant_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label roleStatic;
        private System.Windows.Forms.Label fioStatic;
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button analizerButton;
        private System.Windows.Forms.Timer timerLogout;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}