using Project12_JWTToken.JWT;
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

namespace Project12_JWTToken
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-FDKFGC2;initial catalog=Db12Project20;integrated security=true");
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TokenGenerator tokenGenerator = new TokenGenerator();

            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblUser Where Username=@username and Password=@password", connection);
            command.Parameters.AddWithValue("@username", txtUserName.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string token = tokenGenerator.GenerateJwtToken2(txtUserName.Text);
                //MessageBox.Show(token);
                FrmEmployee frm = new FrmEmployee();
                frm.tokenGet = token;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
                txtPassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }
            connection.Close();
        }
    }}

