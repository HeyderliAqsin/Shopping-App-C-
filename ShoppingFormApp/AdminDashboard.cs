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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProductForm admP = new AdminProductForm();
            admP.ShowDialog();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminWorkerForm adw = new AdminWorkerForm();
            adw.ShowDialog();
        }
    }
}
