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

namespace LoginForm
{
    public partial class Form1 : Form
    {
        config con = new config(); //Meng Inisialisasi Kelas Config 
        SqlCommand cmd;
        SqlDataReader reader;
        public static string password,username;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM [dbo].[user] WHERE username ='" + txtUsername.Text + "'", con.buka()); // Query Untuk Mengambil Username
                reader = cmd.ExecuteReader(); // Untuk Meng Execute Query
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        username = reader["username"].ToString();
                        password = reader["password"].ToString();
                    }
                    if (password == txtPassword.Text)
                    {
                        home home = new home(); // Inisialisasi Form Home 
                        home.Show(); // Untuk Menampilkan Form Home
                        this.Hide(); // Untuk Menutup FormLogin
                    }
                    else
                    {
                        MessageBox.Show("Password Salah !");
                    }
                }
                else
                {
                    MessageBox.Show("Username Tidak Terdaftar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string getUsername()
        {
            return username;
        }
    }
}
