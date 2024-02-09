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
using System.Data.Common;
using System.Deployment.Application;
using System.Reflection.Emit;

namespace Kursach
{
    
    enum RowStateType
    {
        idType_of_Service,
        Name,
        Deleted,
        Modified
    }
    enum RowStateMaster
    {
        idMaster_name,
        Surname,
        Name,
        Last_name,
        Deleted,
        Modified
    }
    public partial class Spravochniki : Form
    {
        DataBase dire = new DataBase();

        public Spravochniki()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Master name")
            {
                SqlConnection myConnection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;");
                try
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand("Select * from Master_name", myConnection);
                    string selectquery = "Select * from Master_name ";
                    SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                    DataTable table = new DataTable();
                    adpt.Fill(table);
                    directory1.DataSource = table;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else if (comboBox1.Text == "Type of service")
            {
                SqlConnection myConnection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;");
                try
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand("Select * from Type_of_Service ", myConnection);
                    string selectquery = "Select * from Type_of_Service ";
                    SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                    DataTable table = new DataTable();
                    adpt.Fill(table);
                    directory.DataSource = table;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
       
        private void directory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }



        private void delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Master name")
            {
                if (directory1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Вы точно хотите удалить выбранную строку?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        int selectedIndex = directory1.SelectedRows[0].Index;

                        var primaryKeyValue = directory1.Rows[selectedIndex].Cells["idMaster_name"].Value;

                        using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("DELETE FROM Master_name WHERE idMaster_name = @idMaster_name", connection))
                            {
                                command.Parameters.AddWithValue("@idMaster_name", primaryKeyValue);
                                command.ExecuteNonQuery();
                            }

                            connection.Close();
                        }

                        directory1.Rows.RemoveAt(selectedIndex);

                    }
                    
                }
               
            }

            if (comboBox1.Text == "Type of service")
                {
                if (directory.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Вы точно хотите удалить выбранную строку?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int selectedIndex = directory.SelectedRows[0].Index;

                        var primaryKeyValue = directory.Rows[selectedIndex].Cells["idType_of_Service"].Value;

                        using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("DELETE FROM Type_of_Service WHERE idType_of_Service = @idType_of_Service", connection))
                            {
                                command.Parameters.AddWithValue("@idType_of_Service", primaryKeyValue);
                                command.ExecuteNonQuery();
                            }

                            connection.Close();
                        }

                        directory.Rows.RemoveAt(selectedIndex);
                    }
               
                }
                else
                {
                    MessageBox.Show("Выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Master name")
            {
                SqlConnection myConnection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;");
                try
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand("Select * from Master_name", myConnection);
                    string selectquery = "Select * from Master_name ";
                    SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                    DataTable table = new DataTable();
                    adpt.Fill(table);
                    directory1.DataSource = table;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                      
                label4Surname.Visible = true;
                Surname.Visible = true;
                lastname.Visible = true;
                textBoxlastname.Visible = true;
                NameMaster.Visible = true;
                labelNameMaster.Visible = true;
                NameType.Visible = false;
                labelNameType.Visible = false;
                directory1.Visible = true;
                directory.Visible = false;

            }

            else if (comboBox1.Text == "Type of service")
            {
                SqlConnection myConnection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;");
                try
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand("Select * from Type_of_Service ", myConnection);
                    string selectquery = "Select * from Type_of_Service ";
                    SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                    DataTable table = new DataTable();
                    adpt.Fill(table);
                    directory.DataSource = table;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                NameType.Visible = true;
                labelNameType.Visible = true;
                label4Surname.Visible = false;
                Surname.Visible = false;
                lastname.Visible = false;
                textBoxlastname.Visible = false;
                NameMaster.Visible = false;
                labelNameMaster.Visible = false;
                directory.Visible = true;
                directory1.Visible = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        private void Spravochniki_Load(object sender, EventArgs e)
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

        private void UpdateMaster()
        {
            string surname = Surname.Text;
            string name = NameMaster.Text;
            string lastname = textBoxlastname.Text;


            using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
            {
                using (SqlCommand command = new SqlCommand("UPDATE Master_name SET Surname = @newsurname, Name = @newname, Lastname = @newlastname WHERE idMaster_name = @idMaster_name", connection))
                {
                    command.Parameters.AddWithValue("@newsurname", surname);
                    command.Parameters.AddWithValue("@newname", name);
                    command.Parameters.AddWithValue("@newlastname", lastname);
                    command.Parameters.AddWithValue("@idMaster_name", directory1.SelectedRows[0].Cells["idMaster_name"].Value.ToString());


                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            directory1.SelectedRows[0].Cells["Surname"].Value = surname;
            directory1.SelectedRows[0].Cells["Name"].Value = name;
            directory1.SelectedRows[0].Cells["Lastname"].Value = lastname;
        }

        private void UpdateType()
        {

            string name = NameType.Text;

            string updateQuery = "UPDATE Type_of_Service SET  Name = @newname WHERE idType_of_Service = @id";

            using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@newname", name);
                    command.Parameters.AddWithValue("@id", directory.SelectedRows[0].Cells["idType_of_Service"].Value.ToString());

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            directory.SelectedRows[0].Cells["Name"].Value = name;
        }
        private void edit_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Master name")
            {
                UpdateMaster();
            }
            else if (comboBox1.Text == "Type of service")
            {
                UpdateType();
            }
        }

        private void directory_SelectionChanged(object sender, EventArgs e)
        {
           if(comboBox1.Text == "Type of service")
            {
                if (directory.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = directory.SelectedRows[0];
                    NameType.Text = selectedRow.Cells["Name"].Value.ToString();
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void directory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.directory.Columns["idType_of_Service"].Visible = false;
        }

        private void directory1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void directory1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.directory1.Columns["idMaster_name"].Visible = false;

        }

        private void directory1_SelectionChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Master name")
            {
                if (directory1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = directory1.SelectedRows[0];
                    Surname.Text = selectedRow.Cells["Surname"].Value.ToString();
                    NameMaster.Text = selectedRow.Cells["Name"].Value.ToString();
                    textBoxlastname.Text = selectedRow.Cells["Lastname"].Value.ToString();
                }
            }
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

        private void NameType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back )
            {
                MessageBox.Show("Неверный формат ввода!Ввведите буквы!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
