namespace Kursach
{
    partial class Spravochniki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spravochniki));
            this.label1 = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.lastname = new System.Windows.Forms.Label();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.label4Surname = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.labelNameMaster = new System.Windows.Forms.Label();
            this.NameMaster = new System.Windows.Forms.TextBox();
            this.labelNameType = new System.Windows.Forms.Label();
            this.NameType = new System.Windows.Forms.TextBox();
            this.directory1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.directory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directory1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Справочники☆";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // directory
            // 
            this.directory.AllowUserToAddRows = false;
            this.directory.AllowUserToDeleteRows = false;
            this.directory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(208)))), ((int)(((byte)(234)))));
            this.directory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directory.GridColor = System.Drawing.Color.LightBlue;
            this.directory.Location = new System.Drawing.Point(12, 114);
            this.directory.Name = "directory";
            this.directory.ReadOnly = true;
            this.directory.RowHeadersWidth = 51;
            this.directory.RowTemplate.Height = 24;
            this.directory.Size = new System.Drawing.Size(442, 437);
            this.directory.TabIndex = 1;
            this.directory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.directory_CellContentClick);
            this.directory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.directory_DataBindingComplete);
            this.directory.SelectionChanged += new System.EventHandler(this.directory_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(460, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите справочник";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Master name",
            "Type of service"});
            this.comboBox1.Location = new System.Drawing.Point(571, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 27);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.add.ForeColor = System.Drawing.Color.MidnightBlue;
            this.add.Location = new System.Drawing.Point(640, 182);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(158, 40);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.edit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.edit.Location = new System.Drawing.Point(553, 511);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(158, 40);
            this.edit.TabIndex = 8;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.delete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.delete.Location = new System.Drawing.Point(466, 182);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(158, 40);
            this.delete.TabIndex = 9;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.back.ForeColor = System.Drawing.Color.MidnightBlue;
            this.back.Location = new System.Drawing.Point(12, 9);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(133, 40);
            this.back.TabIndex = 11;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lastname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lastname.Location = new System.Drawing.Point(470, 393);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(126, 33);
            this.lastname.TabIndex = 23;
            this.lastname.Text = "Отчество";
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.textBoxlastname.Location = new System.Drawing.Point(606, 397);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(194, 25);
            this.textBoxlastname.TabIndex = 22;
            this.textBoxlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxlastname_KeyPress);
            // 
            // label4Surname
            // 
            this.label4Surname.AutoSize = true;
            this.label4Surname.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4Surname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4Surname.Location = new System.Drawing.Point(470, 312);
            this.label4Surname.Name = "label4Surname";
            this.label4Surname.Size = new System.Drawing.Size(124, 33);
            this.label4Surname.TabIndex = 21;
            this.label4Surname.Text = "Фамилия";
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.Surname.Location = new System.Drawing.Point(606, 316);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(194, 25);
            this.Surname.TabIndex = 20;
            this.Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Surname_KeyPress);
            // 
            // labelNameMaster
            // 
            this.labelNameMaster.AutoSize = true;
            this.labelNameMaster.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNameMaster.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelNameMaster.Location = new System.Drawing.Point(470, 354);
            this.labelNameMaster.Name = "labelNameMaster";
            this.labelNameMaster.Size = new System.Drawing.Size(68, 33);
            this.labelNameMaster.TabIndex = 19;
            this.labelNameMaster.Text = "Имя";
            // 
            // NameMaster
            // 
            this.NameMaster.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.NameMaster.Location = new System.Drawing.Point(604, 358);
            this.NameMaster.Name = "NameMaster";
            this.NameMaster.Size = new System.Drawing.Size(194, 25);
            this.NameMaster.TabIndex = 18;
            this.NameMaster.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameMaster_KeyPress);
            // 
            // labelNameType
            // 
            this.labelNameType.AutoSize = true;
            this.labelNameType.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNameType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelNameType.Location = new System.Drawing.Point(470, 312);
            this.labelNameType.Name = "labelNameType";
            this.labelNameType.Size = new System.Drawing.Size(116, 33);
            this.labelNameType.TabIndex = 17;
            this.labelNameType.Text = "Название";
            // 
            // NameType
            // 
            this.NameType.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.NameType.Location = new System.Drawing.Point(606, 316);
            this.NameType.Name = "NameType";
            this.NameType.Size = new System.Drawing.Size(194, 25);
            this.NameType.TabIndex = 16;
            this.NameType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameType_KeyPress);
            // 
            // directory1
            // 
            this.directory1.AllowUserToAddRows = false;
            this.directory1.AllowUserToDeleteRows = false;
            this.directory1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(208)))), ((int)(((byte)(234)))));
            this.directory1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directory1.GridColor = System.Drawing.Color.LightBlue;
            this.directory1.Location = new System.Drawing.Point(12, 114);
            this.directory1.Name = "directory1";
            this.directory1.ReadOnly = true;
            this.directory1.RowHeadersWidth = 51;
            this.directory1.RowTemplate.Height = 24;
            this.directory1.Size = new System.Drawing.Size(442, 437);
            this.directory1.TabIndex = 24;
            this.directory1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.directory1_CellContentClick);
            this.directory1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.directory1_DataBindingComplete);
            this.directory1.SelectionChanged += new System.EventHandler(this.directory1_SelectionChanged);
            // 
            // Spravochniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(208)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(821, 563);
            this.Controls.Add(this.directory1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.label4Surname);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.labelNameMaster);
            this.Controls.Add(this.NameMaster);
            this.Controls.Add(this.labelNameType);
            this.Controls.Add(this.NameType);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spravochniki";
            this.Text = "Directory";
            this.Load += new System.EventHandler(this.Spravochniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.directory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directory1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.Label label4Surname;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label labelNameMaster;
        private System.Windows.Forms.TextBox NameMaster;
        private System.Windows.Forms.Label labelNameType;
        private System.Windows.Forms.TextBox NameType;
        private System.Windows.Forms.DataGridView directory1;
    }
}