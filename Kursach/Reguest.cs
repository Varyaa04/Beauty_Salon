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
using System.Reflection;
using System.Diagnostics;

namespace Kursach
{
    public partial class Reguest : Form
    {
        public Reguest()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void directory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vurychka()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Number,Month,Date,Master,Price,TypeOfService as TypeOfService,Discount,Share_master as MasterShare,SalonRevenue FROM (SELECT ROW_NUMBER() OVER (ORDER BY Date) AS Number,CONVERT(VARCHAR(7), Date, 120) AS Month,Date, CONCAT(Master_name.Surname, ' ', Master_name.Name, ' ', Master_name.Lastname) AS Master,Price,Type_of_Service.Name AS TypeOfService,Discount,((Price - Price * Discount / 100) - Price * MasterShare / 100) AS Share_master,(Price - (Price * Discount / 100) - (Price * MasterShare / 100)) AS SalonRevenue FROM Provision_of_service INNER JOIN Master_name ON Provision_of_service.Master_name = Master_name.idMaster_name INNER JOIN Type_of_Service ON Provision_of_service.Type_of_Service = Type_of_Service.idType_of_Service) AS subquery ORDER BY Date", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            otchetzp.Visible = false;
            directory.Visible = true;
            directory3.Visible = false;
            directory.DataSource = dataTable;

        }

        private void VurychkaOtchet()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Number,Month,Date,Master,Price,TypeOfService as TypeOfService,Discount,Share_master as MasterShare,SalonRevenue FROM (SELECT ROW_NUMBER() OVER (ORDER BY Date) AS Number,CONVERT(VARCHAR(7), Date, 120) AS Month,Date, CONCAT(Master_name.Surname, ' ', Master_name.Name, ' ', Master_name.Lastname) AS Master,Price,Type_of_Service.Name AS TypeOfService,Discount,((Price - Price * Discount / 100) - Price * MasterShare / 100) AS Share_master,(Price - (Price * Discount / 100) - (Price * MasterShare / 100)) AS SalonRevenue FROM Provision_of_service INNER JOIN Master_name ON Provision_of_service.Master_name = Master_name.idMaster_name INNER JOIN Type_of_Service ON Provision_of_service.Type_of_Service = Type_of_Service.idType_of_Service) AS subquery ORDER BY Date", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            otchetzp.Visible = false;
            otchet.DataSource = dataTable;
            directory3.Visible=false;
        }
        private void Zarplata()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Month,Date,Master,MasterSalary FROM (SELECT MONTH(Provision_of_service.Date) AS Month,Provision_of_service.Date,CONCAT(Master_name.Surname, ' ', Master_name.Name, ' ', Master_name.Lastname) AS Master, (Provision_of_service.Price - (Provision_of_service.Price * Provision_of_service.Discount / 100) - (Provision_of_service.Price * Provision_of_service.MasterShare / 100)) AS MasterSalary, COUNT(*) OVER () AS Total_Count, SUM((Provision_of_service.Price - (Provision_of_service.Price * Provision_of_service.Discount / 100) - (Provision_of_service.Price * Provision_of_service.MasterShare / 100))) OVER () AS TotalMasterSalary FROM Provision_of_service JOIN Master_name ON Provision_of_service.Master_name = Master_name.idMaster_name JOIN Type_of_Service ON Provision_of_service.Type_Of_Service = Type_of_Service.idType_of_Service WHERE  MONTH(Provision_of_service.Date) = MONTH(CURRENT_TIMESTAMP) GROUP BY MONTH(Provision_of_service.Date),Provision_of_service.Date, Type_of_Service.Name, Master_name.Surname, Master_name.Name, Master_name.Lastname, Provision_of_service.MasterShare,Price, Discount) AS subquery UNION ALL SELECT NULL, NULL,'Total',TotalMasterSalary FROM (SELECT SUM((Provision_of_service.Price - (Provision_of_service.Price * Provision_of_service.Discount / 100) - (Provision_of_service.Price * Provision_of_service.MasterShare / 100))) AS TotalMasterSalary FROM  Provision_of_service JOIN Master_name ON Provision_of_service.Master_name = Master_name.idMaster_name JOIN Type_of_Service ON Provision_of_service.Type_Of_Service = Type_of_Service.idType_of_Service WHERE MONTH(Provision_of_service.Date) = MONTH(CURRENT_TIMESTAMP)) AS total_subquery", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            directory.Visible = false;
            otchetzp.Visible = true;
            directory3.Visible = true;
            directory3.DataSource = dataTable;
        }

        private void ZarplataOtchet()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Month,Date,Master,MasterSalary FROM (SELECT MONTH(Provision_of_service.Date) AS Month,Provision_of_service.Date,CONCAT(Master_name.Surname, ' ', Master_name.Name, ' ', Master_name.Lastname) AS Master, (Provision_of_service.Price - (Provision_of_service.Price * Provision_of_service.Discount / 100) - (Provision_of_service.Price * Provision_of_service.MasterShare / 100)) AS MasterSalary, COUNT(*) OVER () AS Total_Count, SUM((Provision_of_service.Price - (Provision_of_service.Price * Provision_of_service.Discount / 100) - (Provision_of_service.Price * Provision_of_service.MasterShare / 100))) OVER () AS TotalMasterSalary FROM Provision_of_service JOIN Master_name ON Provision_of_service.Master_name = Master_name.idMaster_name JOIN Type_of_Service ON Provision_of_service.Type_Of_Service = Type_of_Service.idType_of_Service WHERE  MONTH(Provision_of_service.Date) = MONTH(CURRENT_TIMESTAMP) GROUP BY MONTH(Provision_of_service.Date),Provision_of_service.Date, Type_of_Service.Name, Master_name.Surname, Master_name.Name, Master_name.Lastname, Provision_of_service.MasterShare,Price, Discount) AS subquery UNION ALL SELECT NULL, NULL,'Total',TotalMasterSalary FROM (SELECT SUM((Provision_of_service.Price - (Provision_of_service.Price * Provision_of_service.Discount / 100) - (Provision_of_service.Price * Provision_of_service.MasterShare / 100))) AS TotalMasterSalary FROM  Provision_of_service JOIN Master_name ON Provision_of_service.Master_name = Master_name.idMaster_name JOIN Type_of_Service ON Provision_of_service.Type_Of_Service = Type_of_Service.idType_of_Service WHERE MONTH(Provision_of_service.Date) = MONTH(CURRENT_TIMESTAMP)) AS total_subquery", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            directory.Visible = false;
            otchetzp.Visible = true;
            directory3.Visible = true;
            otchetzp.DataSource = dataTable;
        }

        private void KolvoYslyg()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server = LAPTOP-1JBH7IQQ\\SQLEXPRESS; database = Beauty_Salon; Integrated Security=True;"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Date,Type_of_Service.Name as TypeOfService,COUNT(*) AS ServiceCount FROM Provision_of_Service JOIN  Type_of_Service ON Provision_of_service.Type_of_Service = Type_of_Service.idType_of_Service WHERE MONTH(Date) = MONTH(CURRENT_TIMESTAMP) GROUP BY Date, Type_of_Service.Name UNION ALL SELECT NULL,'Itog',SUM(ServiceCount) FROM (SELECT COUNT(*) AS ServiceCount FROM Provision_of_Service JOIN  Type_of_Service ON Provision_of_service.Type_of_Service = Type_of_Service.idType_of_Service WHERE MONTH(Date) = MONTH(CURRENT_TIMESTAMP) GROUP BY Date, Type_of_Service.Name) AS subquery", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            directory3.Visible = true;
            otchetzp.Visible = false;
            directory.Visible = false;
            directory3.DataSource = dataTable;

        }

        private void show_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Выручка за каждый рабочий день месяца")
            {
                Vurychka();
                otchet.Visible = true;
                zapros1.Visible = true;
                zapros2.Visible = false;
                zapros2otchet.Visible = false;
                VurychkaOtchet();
            }
            else if(comboBox1.Text == "Зарплата каждого мастера за каждый день и за весь месяц")
            {
                otchet.Visible = false;
                zapros1.Visible = false;
                zapros2.Visible = true;
                zapros2otchet.Visible = true;
                Zarplata();
                ZarplataOtchet();
            }   
            else if (comboBox1.Text == "Количество оказанных услуг каждым мастером за каждый рабочий день")
            {
                otchet.Visible=false;
                zapros1.Visible = false;
                zapros2.Visible = false;
                zapros2otchet.Visible = false;
                KolvoYslyg();
            }
            else
            {
                MessageBox.Show("Вы не выбрали запрос!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                otchet.Visible = false;
                zapros1.Visible = false;
                zapros2.Visible = false;
                zapros2otchet.Visible = false;
            }

        }

        private void Reguest_Load(object sender, EventArgs e)
        {
            directory.Visible = false;
            otchet.Visible = false;
            directory3.Visible = false;
            otchetzp.Visible = false;
            zapros1.Visible = false;
            zapros2.Visible = false;
            zapros2otchet.Visible = false; 
        }

        private void otchet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

