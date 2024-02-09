using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach
{
    public partial class addProvision : Form
    {
        DataBase database = new DataBase();
        public string connectionString = @"Server = LAPTOP-1JBH7IQQ\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;";

        public addProvision()
        {
            InitializeComponent();
        }

        //private void LoadComboBox()
        //{
        //    string sql = "SELECT concat(Master_name.Surname,' ' , Master_name.Name,' ', Master_name.Lastname) as name FROM [dbo].[Master_name]";
        //    using (SqlCommand cmd =new SqlCommand(sql, connectionString))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //        DataTable table = new DataTable();
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(table);
        //        comboBoxMaster.DisplayMember = "Master_name";
        //        comboBoxMaster.ValueMember = "name";
        //        comboBoxMaster.DataSource = table;
        //    }
        //}
        private void label4Surname_Click(object sender, EventArgs e)
        {

        }

        private void addProvision_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SalonDataSet1.Type_of_Service". При необходимости она может быть перемещена или удалена.
            this.type_of_ServiceTableAdapter1.Fill(this.beauty_SalonDataSet1.Type_of_Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SalonDataSet1.Master_name". При необходимости она может быть перемещена или удалена.
            this.master_nameTableAdapter1.Fill(this.beauty_SalonDataSet1.Master_name);

            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //string query1 = "SELECT concat(Master_name.Surname,' ' , Master_name.Name,' ', Master_name.Lastname) as name,idMaster_name as id FROM Master_name";
            //SqlCommand command1 = new SqlCommand(query1, connection);
            //SqlDataReader reader1 = command1.ExecuteReader();
            //while (reader1.Read())
            //{
            //    comboBoxMaster.Items.Add(reader1["name"].ToString());
            //    comboBoxMaster.SelectedValue.ToString();
            //}
            //reader1.Close();

            //string query2 = "SELECT Name as name1, idType_of_Service as idt FROM Type_of_Service";
            //SqlCommand command2 = new SqlCommand(query2, connection);
            //SqlDataReader reader2 = command2.ExecuteReader();
            //while (reader2.Read())
            //{
            //    comboBoxType.Items.Add(reader2["name1"].ToString());
            //    comboBoxType.Items.Add(reader2["idt"].ToString());

            //}
            //reader2.Close();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            database.openconection();

            string Master = comboBoxMaster.SelectedValue.ToString();
            string Type = comboBoxType.SelectedValue.ToString();
            DateTime Date = Datee.Value;
            string PriceProv = Price.Text;
            string DiscountProv = Discount.Text;
            string Master_shareProv = Master_share.Text;


            if (string.IsNullOrEmpty(Master))
            {
                MessageBox.Show("Вы не выбрали мастера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Type))
            {
                MessageBox.Show("Вы не выбрали тип услуги!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Datee.Value == null)
            {
                MessageBox.Show("Вы не указали дату!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(DiscountProv))
            {
                MessageBox.Show("Вы не указали скидку.Если ее нет, впишитe значение '0'!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(PriceProv))
            {
                MessageBox.Show("Вы не указали цену!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Master_shareProv))
            {
                MessageBox.Show("Вы не указали долю мастера!Если ее нет, впишитe значение '0'!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Price.Text == "0")
            {
                MessageBox.Show("Цена не можеть быть 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double ms = Convert.ToDouble(Master_share.Text);
                double pr = Convert.ToDouble(Price.Text);
                double ds = Convert.ToDouble(Discount.Text);
                if (ms < 0 || ms > 100)
                {
                    MessageBox.Show("Доля мастера должна находиться в диапозоне от 0 до 100!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ds < 0 || ds > 100)
                {
                    MessageBox.Show("Скидка должна находиться в диапозоне от 0 до 100!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pr < 0)
                {
                    MessageBox.Show("Цена не может быть отрицательной!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ms1 = Master_share.Text.Replace(',', '.');
                    string pr1 = Price.Text.Replace(',', '.');
                    string ds1 = Discount.Text.Replace(',', '.');
                    SqlConnection connect = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;");
                    connect.Open();

                    var addType = $"insert into Provision_of_Service (Master_name,Type_of_Service,Date,Price,Discount,MasterShare) values ('{Master}','{Type}','{Date.ToString("yyyy-MM-dd HH:mm:ss")}',{pr1},{ds1},{ms1})";
                    var command = new SqlCommand(addType, connect);
                    command.ExecuteNonQuery();
                    connect.Close();

                    database.closeconection();
                    MessageBox.Show("Запись успешно создана", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }

            }
        }
    





        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        

        private void Price_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите цифры!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
           
        }

        private void Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите цифры!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Master_share_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                MessageBox.Show("Неверный формат ввода!Ввведите цифры!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            if (Price.Text.StartsWith("."))
            {
                Price.Text = "";
                MessageBox.Show("Цена не может начинаться со спец. символа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Datee_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            if (Discount.Text.StartsWith("."))
            {
                Discount.Text = "";
                MessageBox.Show("Скидка не может начинаться со спец. символа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Master_share_TextChanged(object sender, EventArgs e)
        {
            if (Master_share.Text.StartsWith("."))
            {
                Master_share.Text = "";
                MessageBox.Show("Доля мастера не может начинаться со спец. символа!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

}