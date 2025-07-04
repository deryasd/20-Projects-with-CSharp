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

namespace Project10_PostgreSQLToDoListApp
{
    public partial class FrmToDoListApp : Form
    {
        public FrmToDoListApp()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=DbProject10ToDoApp;User ID=postgres;Password=admin");
        
        private void FrmToDoListApp_Load(object sender, EventArgs e)
        {

            connection.Open();
            string query = "SELECT * FROM MyTable1";

            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
