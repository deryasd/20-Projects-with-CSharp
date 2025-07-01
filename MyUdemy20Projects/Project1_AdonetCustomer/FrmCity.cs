using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomer
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-FDKFGC2;initial catalog=DbCustomer;integrated security=true");
        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblCity (CityName,CityCountry) values (@cityName,@cityCountry)", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
          command.Parameters.AddWithValue("@cityCountry",txtCityCountry.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarıyla eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From TblCity Where CityId=@cityId",sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde silindi.","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCity Set CityName=@cityName, CityCountry=@cityCountry where CityId=@cityId",sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde güncellendi.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCity Where CityName=@cityName",sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void txtCityId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCityCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
