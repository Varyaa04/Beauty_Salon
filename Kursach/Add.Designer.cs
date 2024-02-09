namespace Kursach
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeofService = new System.Windows.Forms.RadioButton();
            this.MasterName = new System.Windows.Forms.RadioButton();
            this.NameType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNameType = new System.Windows.Forms.Label();
            this.labelNameMaster = new System.Windows.Forms.Label();
            this.NameMaster = new System.Windows.Forms.TextBox();
            this.label4Surname = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление☆";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(326, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите справочник";
            // 
            // TypeofService
            // 
            this.TypeofService.AutoSize = true;
            this.TypeofService.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TypeofService.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TypeofService.Location = new System.Drawing.Point(410, 70);
            this.TypeofService.Name = "TypeofService";
            this.TypeofService.Size = new System.Drawing.Size(166, 37);
            this.TypeofService.TabIndex = 4;
            this.TypeofService.TabStop = true;
            this.TypeofService.Text = "Тип услуги";
            this.TypeofService.UseVisualStyleBackColor = true;
            this.TypeofService.CheckedChanged += new System.EventHandler(this.TypeofService_CheckedChanged);
            // 
            // MasterName
            // 
            this.MasterName.AutoSize = true;
            this.MasterName.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MasterName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MasterName.Location = new System.Drawing.Point(410, 113);
            this.MasterName.Name = "MasterName";
            this.MasterName.Size = new System.Drawing.Size(196, 37);
            this.MasterName.TabIndex = 5;
            this.MasterName.TabStop = true;
            this.MasterName.Text = "ФИО мастера";
            this.MasterName.UseVisualStyleBackColor = true;
            this.MasterName.CheckedChanged += new System.EventHandler(this.MasterName_CheckedChanged);
            // 
            // NameType
            // 
            this.NameType.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.NameType.Location = new System.Drawing.Point(272, 176);
            this.NameType.Name = "NameType";
            this.NameType.Size = new System.Drawing.Size(194, 25);
            this.NameType.TabIndex = 6;
            this.NameType.TextChanged += new System.EventHandler(this.NameType_TextChanged);
            this.NameType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameType_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(285, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNameType
            // 
            this.labelNameType.AutoSize = true;
            this.labelNameType.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNameType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelNameType.Location = new System.Drawing.Point(91, 172);
            this.labelNameType.Name = "labelNameType";
            this.labelNameType.Size = new System.Drawing.Size(175, 33);
            this.labelNameType.TabIndex = 9;
            this.labelNameType.Text = "Наименование";
            // 
            // labelNameMaster
            // 
            this.labelNameMaster.AutoSize = true;
            this.labelNameMaster.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNameMaster.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelNameMaster.Location = new System.Drawing.Point(136, 214);
            this.labelNameMaster.Name = "labelNameMaster";
            this.labelNameMaster.Size = new System.Drawing.Size(68, 33);
            this.labelNameMaster.TabIndex = 11;
            this.labelNameMaster.Text = "Имя";
            // 
            // NameMaster
            // 
            this.NameMaster.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.NameMaster.Location = new System.Drawing.Point(272, 218);
            this.NameMaster.Name = "NameMaster";
            this.NameMaster.Size = new System.Drawing.Size(194, 25);
            this.NameMaster.TabIndex = 10;
            this.NameMaster.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameMaster_KeyPress);
            // 
            // label4Surname
            // 
            this.label4Surname.AutoSize = true;
            this.label4Surname.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4Surname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4Surname.Location = new System.Drawing.Point(136, 172);
            this.label4Surname.Name = "label4Surname";
            this.label4Surname.Size = new System.Drawing.Size(124, 33);
            this.label4Surname.TabIndex = 13;
            this.label4Surname.Text = "Фамилия";
            this.label4Surname.Click += new System.EventHandler(this.label4Surname_Click);
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.Surname.Location = new System.Drawing.Point(272, 176);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(194, 25);
            this.Surname.TabIndex = 12;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            this.Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Surname_KeyPress);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lastname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lastname.Location = new System.Drawing.Point(136, 253);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(126, 33);
            this.lastname.TabIndex = 15;
            this.lastname.Text = "Отчество";
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.textBoxlastname.Location = new System.Drawing.Point(272, 257);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(194, 25);
            this.textBoxlastname.TabIndex = 14;
            this.textBoxlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxlastname_KeyPress);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(3, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(208)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(669, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.label4Surname);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.labelNameMaster);
            this.Controls.Add(this.NameMaster);
            this.Controls.Add(this.labelNameType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameType);
            this.Controls.Add(this.MasterName);
            this.Controls.Add(this.TypeofService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton TypeofService;
        private System.Windows.Forms.RadioButton MasterName;
        private System.Windows.Forms.TextBox NameType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNameType;
        private System.Windows.Forms.Label labelNameMaster;
        private System.Windows.Forms.TextBox NameMaster;
        private System.Windows.Forms.Label label4Surname;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.Button button2;
    }
}