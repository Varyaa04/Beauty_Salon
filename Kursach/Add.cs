using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace Kursach
{
    public partial class Add : Form
    {
        DataBase database = new DataBase();
        public Add()
        {
            InitializeComponent();
        }

        private void label4Surname_Click(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
            NameType.Visible = false;
            labelNameType.Visible = false;
            label4Surname.Visible = false;
            Surname.Visible = false;
            lastname.Visible = false;
            textBoxlastname.Visible = false;
            NameMaster.Visible = false;
            labelNameMaster.Visible = false;
        }

        private void TypeofService_CheckedChanged(object sender, EventArgs e)
        {
            NameType.Visible = true;
            labelNameType.Visible = true;
            label4Surname.Visible = false;
            Surname.Visible = false;
            lastname.Visible = false;
            textBoxlastname.Visible = false;
            NameMaster.Visible = false;
            labelNameMaster.Visible = false;
        }

        private void MasterName_CheckedChanged(object sender, EventArgs e)
        {
            label4Surname.Visible = true;
            Surname.Visible = true;
            lastname.Visible = true;
            textBoxlastname.Visible = true;
            NameMaster.Visible = true;
            labelNameMaster.Visible = true;
            NameType.Visible = false;
            labelNameType.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openconection();

            var nameType = NameType.Text;
            var SurnameMaster = Surname.Text;
            var nameMaster = NameMaster.Text;
            var LastnameMaster = textBoxlastname.Text;

            if (TypeofService.Checked == true)
            {

                var addType = $"insert into Type_of_Service (Name) values ('{nameType}')";
                var command = new SqlCommand(addType, database.getconnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана","Успех!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MasterName.Checked == true)
            {
                var addMaster = $"insert into Master_name (Surname, Name, Lastname) values ('{SurnameMaster}','{nameMaster}','{LastnameMaster}')";
                var command = new SqlCommand(addMaster, database.getconnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            database.closeconection();

            Spravochniki spravochniki = new Spravochniki();
            spravochniki.Show();
            this.Close();


        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void NameMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void textBoxlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void NameType_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back )
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spravochniki form1 = new Spravochniki();
            form1.Show();
            this.Hide();
        }
    }
}
