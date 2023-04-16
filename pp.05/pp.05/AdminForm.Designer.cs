
namespace pp._05
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.roleStatic = new System.Windows.Forms.Label();
            this.fioStatic = new System.Windows.Forms.Label();
            this.fioLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addUserButton = new System.Windows.Forms.Button();
            this.patientsGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.deleteMaterialButton = new System.Windows.Forms.Button();
            this.changeMaterialButton = new System.Windows.Forms.Button();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.materialsGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 556);
            this.tabControl1.TabIndex = 8;
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
            this.tabPage1.Size = new System.Drawing.Size(570, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личный кабинет";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pp._05.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mainPic
            // 
            this.mainPic.Image = ((System.Drawing.Image)(resources.GetObject("mainPic.Image")));
            this.mainPic.Location = new System.Drawing.Point(20, 17);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(100, 100);
            this.mainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
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
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addUserButton);
            this.tabPage3.Controls.Add(this.patientsGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(570, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пользователи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserButton.Location = new System.Drawing.Point(387, 496);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(173, 24);
            this.addUserButton.TabIndex = 39;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // patientsGridView
            // 
            this.patientsGridView.AllowUserToOrderColumns = true;
            this.patientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsGridView.Location = new System.Drawing.Point(3, 3);
            this.patientsGridView.Name = "patientsGridView";
            this.patientsGridView.Size = new System.Drawing.Size(564, 487);
            this.patientsGridView.TabIndex = 0;
            this.patientsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsGridView_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deleteMaterialButton);
            this.tabPage4.Controls.Add(this.changeMaterialButton);
            this.tabPage4.Controls.Add(this.addMaterialButton);
            this.tabPage4.Controls.Add(this.materialsGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(570, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Материалы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // deleteMaterialButton
            // 
            this.deleteMaterialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteMaterialButton.Location = new System.Drawing.Point(448, 452);
            this.deleteMaterialButton.Name = "deleteMaterialButton";
            this.deleteMaterialButton.Size = new System.Drawing.Size(112, 35);
            this.deleteMaterialButton.TabIndex = 42;
            this.deleteMaterialButton.Text = "Удалить материал";
            this.deleteMaterialButton.UseVisualStyleBackColor = true;
            this.deleteMaterialButton.Click += new System.EventHandler(this.deleteMaterialButton_Click);
            // 
            // changeMaterialButton
            // 
            this.changeMaterialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeMaterialButton.Location = new System.Drawing.Point(448, 86);
            this.changeMaterialButton.Name = "changeMaterialButton";
            this.changeMaterialButton.Size = new System.Drawing.Size(112, 35);
            this.changeMaterialButton.TabIndex = 41;
            this.changeMaterialButton.Text = "Изменить материал";
            this.changeMaterialButton.UseVisualStyleBackColor = true;
            this.changeMaterialButton.Click += new System.EventHandler(this.changeMaterialButton_Click);
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMaterialButton.Location = new System.Drawing.Point(448, 25);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(112, 35);
            this.addMaterialButton.TabIndex = 40;
            this.addMaterialButton.Text = "Добавить материал";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            // 
            // materialsGridView
            // 
            this.materialsGridView.AllowUserToOrderColumns = true;
            this.materialsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsGridView.Location = new System.Drawing.Point(3, 0);
            this.materialsGridView.Name = "materialsGridView";
            this.materialsGridView.Size = new System.Drawing.Size(439, 528);
            this.materialsGridView.TabIndex = 1;
            this.materialsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialsGridView_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Создать отчет";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pp._05.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(6, 420);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label roleStatic;
        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.Label fioStatic;
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView patientsGridView;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.DataGridView materialsGridView;
        private System.Windows.Forms.Button changeMaterialButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button deleteMaterialButton;
    }
}