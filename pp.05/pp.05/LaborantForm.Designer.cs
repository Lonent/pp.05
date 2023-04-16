
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaborantForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.roleStatic = new System.Windows.Forms.Label();
            this.fioStatic = new System.Windows.Forms.Label();
            this.fioLabel = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.fillBiomaterial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientFioTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.Decode = new System.Windows.Forms.Label();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.Encode = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.orderSearchButton = new System.Windows.Forms.Button();
            this.orderSearchField = new System.Windows.Forms.TextBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.changeOrderButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.analizerButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerLogout = new System.Windows.Forms.Timer(this.components);
            this.labelCountdown = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
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
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.fillBiomaterial);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.patientFioTextBox);
            this.tabPage5.Controls.Add(this.pictureBox2);
            this.tabPage5.Controls.Add(this.txtDecode);
            this.tabPage5.Controls.Add(this.Decode);
            this.tabPage5.Controls.Add(this.txtEncode);
            this.tabPage5.Controls.Add(this.Encode);
            this.tabPage5.Controls.Add(this.btnDecode);
            this.tabPage5.Controls.Add(this.btnEncode);
            this.tabPage5.Controls.Add(this.pic);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(570, 486);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Прием биоматериала";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // fillBiomaterial
            // 
            this.fillBiomaterial.Location = new System.Drawing.Point(331, 340);
            this.fillBiomaterial.Name = "fillBiomaterial";
            this.fillBiomaterial.Size = new System.Drawing.Size(130, 29);
            this.fillBiomaterial.TabIndex = 18;
            this.fillBiomaterial.Text = "Загрузить данные";
            this.fillBiomaterial.UseVisualStyleBackColor = true;
            this.fillBiomaterial.Click += new System.EventHandler(this.fillBiomaterial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "ФИО пациента";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите номер услуги";
            // 
            // patientFioTextBox
            // 
            this.patientFioTextBox.Location = new System.Drawing.Point(123, 344);
            this.patientFioTextBox.Name = "patientFioTextBox";
            this.patientFioTextBox.Size = new System.Drawing.Size(186, 23);
            this.patientFioTextBox.TabIndex = 15;
            this.patientFioTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.patientFioTextBox_MaskInputRejected);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pp._05.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(6, 380);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(202, 278);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(146, 23);
            this.txtDecode.TabIndex = 12;
            // 
            // Decode
            // 
            this.Decode.AutoSize = true;
            this.Decode.Location = new System.Drawing.Point(120, 285);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(44, 15);
            this.Decode.TabIndex = 11;
            this.Decode.Text = "Раскод";
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(202, 245);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(146, 23);
            this.txtEncode.TabIndex = 10;
            // 
            // Encode
            // 
            this.Encode.AutoSize = true;
            this.Encode.Location = new System.Drawing.Point(120, 252);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(39, 15);
            this.Encode.TabIndex = 9;
            this.Encode.Text = "Закод";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(367, 275);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(95, 23);
            this.btnDecode.TabIndex = 8;
            this.btnDecode.Text = "Раскодировать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(367, 242);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(95, 23);
            this.btnEncode.TabIndex = 7;
            this.btnEncode.Text = "Закодировать";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic.Location = new System.Drawing.Point(96, 31);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(382, 169);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.orderSearchButton);
            this.tabPage2.Controls.Add(this.orderSearchField);
            this.tabPage2.Controls.Add(this.deleteOrderButton);
            this.tabPage2.Controls.Add(this.changeOrderButton);
            this.tabPage2.Controls.Add(this.addOrderButton);
            this.tabPage2.Controls.Add(this.ordersGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(570, 486);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // orderSearchButton
            // 
            this.orderSearchButton.Location = new System.Drawing.Point(211, 4);
            this.orderSearchButton.Name = "orderSearchButton";
            this.orderSearchButton.Size = new System.Drawing.Size(90, 23);
            this.orderSearchButton.TabIndex = 5;
            this.orderSearchButton.Text = "Найти";
            this.orderSearchButton.UseVisualStyleBackColor = true;
            this.orderSearchButton.Click += new System.EventHandler(this.orderSearchButton_Click);
            // 
            // orderSearchField
            // 
            this.orderSearchField.Location = new System.Drawing.Point(20, 4);
            this.orderSearchField.Name = "orderSearchField";
            this.orderSearchField.Size = new System.Drawing.Size(185, 23);
            this.orderSearchField.TabIndex = 4;
            this.orderSearchField.TextChanged += new System.EventHandler(this.orderSearchField_TextChanged_1);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(442, 456);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(125, 26);
            this.deleteOrderButton.TabIndex = 3;
            this.deleteOrderButton.Text = "Удалить";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // changeOrderButton
            // 
            this.changeOrderButton.Location = new System.Drawing.Point(160, 456);
            this.changeOrderButton.Name = "changeOrderButton";
            this.changeOrderButton.Size = new System.Drawing.Size(125, 26);
            this.changeOrderButton.TabIndex = 2;
            this.changeOrderButton.Text = "Изменить";
            this.changeOrderButton.UseVisualStyleBackColor = true;
            this.changeOrderButton.Click += new System.EventHandler(this.changeOrderButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(9, 456);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(125, 26);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "Добавить";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // ordersGridView
            // 
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Location = new System.Drawing.Point(2, 33);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.Size = new System.Drawing.Size(567, 417);
            this.ordersGridView.TabIndex = 0;
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
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.pictureBox3);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(570, 486);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Создать отчет";
            this.tabPage6.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button analizerButton;
        private System.Windows.Forms.Timer timerLogout;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Label Decode;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Label Encode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox patientFioTextBox;
        private System.Windows.Forms.Button fillBiomaterial;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button changeOrderButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button orderSearchButton;
        private System.Windows.Forms.TextBox orderSearchField;
    }
}