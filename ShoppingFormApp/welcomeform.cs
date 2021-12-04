using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingFormApp
{
    public partial class welcomeform : Form
    {
        public welcomeform()
        {
            InitializeComponent();
        }

        private void welcomeform_Load(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
