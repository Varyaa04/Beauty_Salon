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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SalonDataSet1.Type_of_Service". При необходимости она может быть перемещена или удалена.
            this.type_of_ServiceTableAdapter.Fill(this.beauty_SalonDataSet1.Type_of_Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beauty_SalonDataSet1.Master_name". При необходимости она может быть перемещена или удалена.
            this.master_nameTableAdapter.Fill(this.beauty_SalonDataSet1.Master_name);
            SqlConnection myConnection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;");
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("Select idProvision_of_Service,concat(Master_name.Surname,' ' , Master_name.Name,' ', Master_name.Lastname) as FIOMaster, Type_of_Service.Name as TypeOfService, Date, Price, Discount, MasterShare from Provision_of_Service join Master_name on Provision_of_Service.Master_name = Master_name.idMaster_name join Type_of_Service on Provision_of_Service.Type_of_Service = Type_of_Service.idType_of_Service", myConnection);
                string selectquery = "Select idProvision_of_Service,concat(Master_name.Surname,' ', Master_name.Name,' ', Master_name.Lastname) as FIOMaster, Type_of_Service.Name as TypeOfService, Date, Price, Discount, MasterShare from Provision_of_Service join Master_name on Provision_of_Service.Master_name = Master_name.idMaster_name join Type_of_Service on Provision_of_Service.Type_of_Service = Type_of_Service.idType_of_Service";
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                DataTable table = new DataTable();
                adpt.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            string connectionString = "Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query1 = "SELECT concat(Master_name.Surname,' ' , Master_name.Name,' ', Master_name.Lastname) as FIOMaster FROM Master_name";
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox1.Items.Add(reader1["FIOMaster"].ToString());
            }
            reader1.Close();

            string query2 = "SELECT Name as name1 FROM Type_of_Service";
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2["name1"].ToString());
            }
            reader2.Close();

            connection.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Spravochniki spravochniki = new Spravochniki();
            spravochniki.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reguest reguest = new Reguest();
            reguest.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void directoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spravochniki spravochniki = new Spravochniki();
            spravochniki.Show();
            this.Hide();
        }

        private void reguestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reguest reguest = new Reguest();
            reguest.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addProvision addProvision = new addProvision();
            addProvision.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Вы точно хотите удалить выбранную строку?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    var primaryKeyValue = dataGridView1.Rows[selectedIndex].Cells["idProvision_of_Service"].Value;



                    using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("DELETE FROM Provision_of_Service WHERE  idProvision_of_Service = @idProvision_of_Service", connection))
                        {
                            command.Parameters.AddWithValue("@idProvision_of_Service", primaryKeyValue);


                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Вы ничего не выбрали!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Вы не выбрали тип услуги!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                    MessageBox.Show("Вы не выбрали мастера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string master = comboBox1.Text;
                string type = comboBox2.Text;
                DateTime date = dateTimePicker1.Value;

                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                string filter = "";
                if (!string.IsNullOrEmpty(master))
                {
                    filter += $"[FIOMaster] = '{master}'";
                }
                if (!string.IsNullOrEmpty(type))
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        filter += " AND ";
                    }
                    filter += $"[TypeOfService] = '{type}'";
                }
                if (!string.IsNullOrEmpty(filter))
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        filter += " AND ";
                    }
                    filter += $"[Date] >= '{date.ToString("yyyy-MM-dd")}' AND [Date] < '{date.AddDays(1).ToString("yyyy-MM-dd")}'";
                }
                 
                dataTable.DefaultView.RowFilter = filter;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            SqlConnection myConnection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;");
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("Select idProvision_of_Service, concat(Master_name.Surname,' ' , Master_name.Name,' ', Master_name.Lastname) as FIOMaster, TypeOfService.Name as TypeOfService, Date, Price, Discount, MasterShare from Provision_of_Service join Master_name on Provision_of_Service.Master_name = Master_name.idMaster_name join Type_of_Service on Provision_of_Service.Type_of_Service = Type_of_Service.idType_of_Service", myConnection);
                string selectquery = "Select idProvision_of_Service, concat(Master_name.Surname,' ', Master_name.Name,' ', Master_name.Lastname) as FIOMaster, Type_of_Service.Name as TypeOfService, Date, Price, Discount, MasterShare from Provision_of_Service join Master_name on Provision_of_Service.Master_name = Master_name.idMaster_name join Type_of_Service on Provision_of_Service.Type_of_Service = Type_of_Service.idType_of_Service";
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                DataTable table = new DataTable();
                adpt.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.Columns["idProvision_of_Service"].Visible = false;
        }
    }
}
