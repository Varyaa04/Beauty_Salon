namespace Kursach
{
    partial class addProvision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProvision));
            this.lastname = new System.Windows.Forms.Label();
            this.label4Surname = new System.Windows.Forms.Label();
            this.labelNameMaster = new System.Windows.Forms.Label();
            this.labelNameType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.masternameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.beauty_SalonDataSet1 = new Kursach.Beauty_SalonDataSet1();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.typeofServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Price = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.TextBox();
            this.Master_share = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Datee = new System.Windows.Forms.DateTimePicker();
            this.beauty_SalonDataSet = new Kursach.Beauty_SalonDataSet();
            this.beautySalonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masternameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_nameTableAdapter = new Kursach.Beauty_SalonDataSetTableAdapters.Master_nameTableAdapter();
            this.typeofServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_of_ServiceTableAdapter = new Kursach.Beauty_SalonDataSetTableAdapters.Type_of_ServiceTableAdapter();
            this.master_nameTableAdapter1 = new Kursach.Beauty_SalonDataSet1TableAdapters.Master_nameTableAdapter();
            this.type_of_ServiceTableAdapter1 = new Kursach.Beauty_SalonDataSet1TableAdapters.Type_of_ServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.masternameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SalonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofServiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masternameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lastname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lastname.Location = new System.Drawing.Point(31, 239);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(70, 33);
            this.lastname.TabIndex = 28;
            this.lastname.Text = "Цена";
            // 
            // label4Surname
            // 
            this.label4Surname.AutoSize = true;
            this.label4Surname.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4Surname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4Surname.Location = new System.Drawing.Point(12, 87);
            this.label4Surname.Name = "label4Surname";
            this.label4Surname.Size = new System.Drawing.Size(230, 33);
            this.label4Surname.TabIndex = 26;
            this.label4Surname.Text = "Выберите мастера";
            this.label4Surname.Click += new System.EventHandler(this.label4Surname_Click);
            // 
            // labelNameMaster
            // 
            this.labelNameMaster.AutoSize = true;
            this.labelNameMaster.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNameMaster.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelNameMaster.Location = new System.Drawing.Point(24, 195);
            this.labelNameMaster.Name = "labelNameMaster";
            this.labelNameMaster.Size = new System.Drawing.Size(77, 33);
            this.labelNameMaster.TabIndex = 24;
            this.labelNameMaster.Text = "Дата";
            // 
            // labelNameType
            // 
            this.labelNameType.AutoSize = true;
            this.labelNameType.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNameType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelNameType.Location = new System.Drawing.Point(12, 143);
            this.labelNameType.Name = "labelNameType";
            this.labelNameType.Size = new System.Drawing.Size(265, 33);
            this.labelNameType.TabIndex = 22;
            this.labelNameType.Text = "Выберите тип услуги";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(251, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(212, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 67);
            this.label1.TabIndex = 16;
            this.label1.Text = "Добавление☆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(24, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "Доля мастера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(24, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "Скидка";
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.DataSource = this.masternameBindingSource1;
            this.comboBoxMaster.DisplayMember = "Surname";
            this.comboBoxMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaster.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(295, 87);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(379, 27);
            this.comboBoxMaster.TabIndex = 36;
            this.comboBoxMaster.ValueMember = "idMaster_name";
            // 
            // masternameBindingSource1
            // 
            this.masternameBindingSource1.DataMember = "Master_name";
            this.masternameBindingSource1.DataSource = this.beauty_SalonDataSet1;
            // 
            // beauty_SalonDataSet1
            // 
            this.beauty_SalonDataSet1.DataSetName = "Beauty_SalonDataSet1";
            this.beauty_SalonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.typeofServiceBindingSource1;
            this.comboBoxType.DisplayMember = "name";
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(295, 148);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(194, 27);
            this.comboBoxType.TabIndex = 37;
            this.comboBoxType.ValueMember = "idType_of_Service";
            // 
            // typeofServiceBindingSource1
            // 
            this.typeofServiceBindingSource1.DataMember = "Type_of_Service";
            this.typeofServiceBindingSource1.DataSource = this.beauty_SalonDataSet1;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.Price.Location = new System.Drawing.Point(295, 239);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(194, 25);
            this.Price.TabIndex = 38;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress_1);
            // 
            // Discount
            // 
            this.Discount.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.Discount.Location = new System.Drawing.Point(295, 281);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(194, 25);
            this.Discount.TabIndex = 39;
            this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
            this.Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Discount_KeyPress);
            // 
            // Master_share
            // 
            this.Master_share.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.Master_share.Location = new System.Drawing.Point(295, 325);
            this.Master_share.Name = "Master_share";
            this.Master_share.Size = new System.Drawing.Size(194, 25);
            this.Master_share.TabIndex = 40;
            this.Master_share.TextChanged += new System.EventHandler(this.Master_share_TextChanged);
            this.Master_share.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Master_share_KeyPress);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 40);
            this.button2.TabIndex = 41;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Datee
            // 
            this.Datee.Location = new System.Drawing.Point(295, 195);
            this.Datee.Name = "Datee";
            this.Datee.Size = new System.Drawing.Size(194, 22);
            this.Datee.TabIndex = 42;
            this.Datee.ValueChanged += new System.EventHandler(this.Datee_ValueChanged);
            // 
            // beauty_SalonDataSet
            // 
            this.beauty_SalonDataSet.DataSetName = "Beauty_SalonDataSet";
            this.beauty_SalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beautySalonDataSetBindingSource
            // 
            this.beautySalonDataSetBindingSource.DataSource = this.beauty_SalonDataSet;
            this.beautySalonDataSetBindingSource.Position = 0;
            // 
            // masternameBindingSource
            // 
            this.masternameBindingSource.DataMember = "Master_name";
            this.masternameBindingSource.DataSource = this.beautySalonDataSetBindingSource;
            // 
            // master_nameTableAdapter
            // 
            this.master_nameTableAdapter.ClearBeforeFill = true;
            // 
            // typeofServiceBindingSource
            // 
            this.typeofServiceBindingSource.DataMember = "Type_of_Service";
            this.typeofServiceBindingSource.DataSource = this.beauty_SalonDataSet;
            // 
            // type_of_ServiceTableAdapter
            // 
            this.type_of_ServiceTableAdapter.ClearBeforeFill = true;
            // 
            // master_nameTableAdapter1
            // 
            this.master_nameTableAdapter1.ClearBeforeFill = true;
            // 
            // type_of_ServiceTableAdapter1
            // 
            this.type_of_ServiceTableAdapter1.ClearBeforeFill = true;
            // 
            // addProvision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(208)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(696, 473);
            this.Controls.Add(this.Datee);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Master_share);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label4Surname);
            this.Controls.Add(this.labelNameMaster);
            this.Controls.Add(this.labelNameType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addProvision";
            this.Text = "addProvision";
            this.Load += new System.EventHandler(this.addProvision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masternameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SalonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofServiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_SalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masternameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label label4Surname;
        private System.Windows.Forms.Label labelNameMaster;
        private System.Windows.Forms.Label labelNameType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.TextBox Master_share;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker Datee;
        private System.Windows.Forms.BindingSource beautySalonDataSetBindingSource;
        private Beauty_SalonDataSet beauty_SalonDataSet;
        private System.Windows.Forms.BindingSource masternameBindingSource;
        private Beauty_SalonDataSetTableAdapters.Master_nameTableAdapter master_nameTableAdapter;
        private System.Windows.Forms.BindingSource typeofServiceBindingSource;
        private Beauty_SalonDataSetTableAdapters.Type_of_ServiceTableAdapter type_of_ServiceTableAdapter;
        private Beauty_SalonDataSet1 beauty_SalonDataSet1;
        private System.Windows.Forms.BindingSource masternameBindingSource1;
        private Beauty_SalonDataSet1TableAdapters.Master_nameTableAdapter master_nameTableAdapter1;
        private System.Windows.Forms.BindingSource typeofServiceBindingSource1;
        private Beauty_SalonDataSet1TableAdapters.Type_of_ServiceTableAdapter type_of_ServiceTableAdapter1;
    }
}