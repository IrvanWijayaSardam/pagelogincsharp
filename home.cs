using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class home : Form
    {
        Form1 form1 = new Form1();
        String username = Form1.username;
        public home()
        {
            InitializeComponent();
            tampil();
        }
        private void tampil()
        {
            string username = form1.getUsername();
            label_nama.Text = username;
        }
    }
}
