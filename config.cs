using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    class config
    {
        SqlConnection con;
        string strkoneksi;

        public SqlConnection buka()
        {
            try
            {
                strkoneksi = "Server = .\\SQLEXPRESS; Database = FormLogin; Integrated Security = SSPI";
                con = new SqlConnection(strkoneksi);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return con;
        }

    }

}
