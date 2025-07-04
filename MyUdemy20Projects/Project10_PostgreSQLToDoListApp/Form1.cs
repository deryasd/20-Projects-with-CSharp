using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project10_PostgreSQLToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Port=5432;Database=DbProject10ToDoApp;User ID=postgres;Password=admin";
        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }
        void ToDoList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM ToDoLists";

            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Categories";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = dataTable;
            connection.Close();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ToDoList();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            ToDoList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToDoList();
            CategoryList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string priority = txtPriority.Text;
            string description = txtDescription.Text;
            //string status = "B'0'";

            //if (rdbCompleted.Checked)
            //{
            //    status = "B'1'";
            //}
            //if (rdbContinue.Checked)
            //{
            //    status = "B'0'";
            //}

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into ToDoLists (title,description,status,priority,categoryid) values (@title,@description,B'1',@priority,@categoryid)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                // command.Parameters.AddWithValue("@status", "B'1'");
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@categoryid", categoryId);
                command.ExecuteNonQuery();
                MessageBox.Show("Yapılacak İşlem Eklendi");
                ToDoList();
            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From ToDoLists Where todolistsid=@todolistsid";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@todolistsid", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Veri başarıyla silindi");
                CategoryList();
            }
            connection.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string priority = txtPriority.Text;
            string description = txtDescription.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update ToDoLists Set Title=@title,Description=@description,priority=@priority,categoryid=@categoryid where todolistsid=@todolistsid";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@todolistsid", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@categoryid", categoryId);
                command.ExecuteNonQuery();
                MessageBox.Show("İşlem başarıyla güncellendi");
                CategoryList();
            }
            connection.Close();
        }

        private void btnCheckedList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From ToDoLists Where Status='1'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnContinueList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From ToDoLists Where Status='0'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
