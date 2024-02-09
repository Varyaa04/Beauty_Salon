namespace Kursach
{
    partial class Reguest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reguest));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.otchet = new System.Windows.Forms.DataGridView();
            this.directory3 = new System.Windows.Forms.DataGridView();
            this.otchetzp = new System.Windows.Forms.DataGridView();
            this.zapros2 = new System.Windows.Forms.Label();
            this.zapros2otchet = new System.Windows.Forms.Label();
            this.zapros1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.directory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otchet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otchetzp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запросы☆";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Выручка за каждый рабочий день месяца",
            "Зарплата каждого мастера за каждый день и за весь месяц",
            "Количество оказанных услуг каждым мастером за каждый рабочий день"});
            this.comboBox1.Location = new System.Drawing.Point(440, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(319, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(194, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите запрос";
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.back.ForeColor = System.Drawing.Color.MidnightBlue;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(124, 40);
            this.back.TabIndex = 12;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // directory
            // 
            this.directory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(208)))), ((int)(((byte)(234)))));
            this.directory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directory.GridColor = System.Drawing.Color.LightBlue;
            this.directory.Location = new System.Drawing.Point(-3, 185);
            this.directory.Name = "directory";
            this.directory.RowHeadersWidth = 51;
            this.directory.RowTemplate.Height = 24;
            this.directory.Size = new System.Drawing.Size(1165, 349);
            this.directory.TabIndex = 13;
            this.directory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.directory_CellContentClick);
            // 
            // show
            // 
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.show.ForeColor = System.Drawing.Color.MidnightBlue;
            this.show.Location = new System.Drawing.Point(832, 97);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(143, 40);
            this.show.TabIndex = 14;
            this.show.Text = "Показать";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // otchet
            // 
            this.otchet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(208)))), ((int)(((byte)(234)))));
            this.otchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otchet.GridColor = System.Drawing.Color.LightBlue;
            this.otchet.Location = new System.Drawing.Point(771, 540);
            this.otchet.Name = "otchet";
            this.otchet.RowHeadersWidth = 51;
            this.otchet.RowTemplate.Height = 24;
            this.otchet.Size = new System.Drawing.Size(391, 76);
            this.otchet.TabIndex = 15;
            this.otchet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.otchet_CellContentClick);
            // 
            // directory3
            // 
            this.directory3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(208)))), ((int)(((byte)(234)))));
            this.directory3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directory3.GridColor = System.Drawing.Color.LightBlue;
            this.directory3.Location = new System.Drawing.Point(-3, 185);
            this.directory3.Name = "directory3";
            this.directory3.RowHeadersWidth = 51;
            this.directory3.RowTemplate.Height = 24;
            this.directory3.Size = new System.Drawing.Size(592, 232);
            this.directory3.TabIndex = 16;
            // 
            // otchetzp
            // 
            this.otchetzp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(208)))), ((int)(((byte)(234)))));
            this.otchetzp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otchetzp.GridColor = System.Drawing.Color.LightBlue;
            this.otchetzp.Location = new System.Drawing.Point(595, 185);
            this.otchetzp.Name = "otchetzp";
            this.otchetzp.RowHeadersWidth = 51;
            this.otchetzp.RowTemplate.Height = 24;
            this.otchetzp.Size = new System.Drawing.Size(558, 232);
            this.otchetzp.TabIndex = 17;
            // 
            // zapros2
            // 
            this.zapros2.AutoSize = true;
            this.zapros2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.zapros2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.zapros2.Location = new System.Drawing.Point(12, 149);
            this.zapros2.Name = "zapros2";
            this.zapros2.Size = new System.Drawing.Size(542, 33);
            this.zapros2.TabIndex = 18;
            this.zapros2.Text = "Кол-во оказанных услуг и зарплата за месяц";
            // 
            // zapros2otchet
            // 
            this.zapros2otchet.AutoSize = true;
            this.zapros2otchet.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.zapros2otchet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.zapros2otchet.Location = new System.Drawing.Point(736, 149);
            this.zapros2otchet.Name = "zapros2otchet";
            this.zapros2otchet.Size = new System.Drawing.Size(224, 33);
            this.zapros2otchet.TabIndex = 19;
            this.zapros2otchet.Text = "З/П всех мастеров";
            // 
            // zapros1
            // 
            this.zapros1.AutoSize = true;
            this.zapros1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.zapros1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.zapros1.Location = new System.Drawing.Point(285, 567);
            this.zapros1.Name = "zapros1";
            this.zapros1.Size = new System.Drawing.Size(455, 33);
            this.zapros1.TabIndex = 20;
            this.zapros1.Text = "Итог дохода салона и доходов мастера";
            // 
            // Reguest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(208)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1162, 620);
            this.Controls.Add(this.zapros1);
            this.Controls.Add(this.zapros2otchet);
            this.Controls.Add(this.zapros2);
            this.Controls.Add(this.otchetzp);
            this.Controls.Add(this.directory3);
            this.Controls.Add(this.otchet);
            this.Controls.Add(this.show);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reguest";
            this.Text = "Reguest";
            this.Load += new System.EventHandler(this.Reguest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.directory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otchet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otchetzp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView directory;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridView otchet;
        private System.Windows.Forms.DataGridView directory3;
        private System.Windows.Forms.DataGridView otchetzp;
        private System.Windows.Forms.Label zapros2;
        private System.Windows.Forms.Label zapros2otchet;
        private System.Windows.Forms.Label zapros1;
    }
}