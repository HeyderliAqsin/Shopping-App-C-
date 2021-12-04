using Microsoft.EntityFrameworkCore;
using ShoppingFormApp.models;
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
    public partial class Login : Form
    {
        ShoppingDbContext db = new ShoppingDbContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtpassword.Text;
            string[] IsArray = new string[] { username, password };

            User chooseLogin = db.Users.FirstOrDefault(x => x.UserName == username);

            if (Utility.IsEmpty(IsArray))
            {
                if (chooseLogin != null)
                {
                    if (chooseLogin.Password == password.HashMe())
                    {
                        string userRoleName = db.RolestoUsers.Include(x=>x.Role).FirstOrDefault(x => x.UserId == chooseLogin.UserId).Role.Name;
                        this.Close();

                        if (userRoleName == "Admin")
                        {
                            AdminDashboard adm = new AdminDashboard();
                            adm.ShowDialog();
                        }
                        else
                        {
                            WorkerDashboard wkd = new WorkerDashboard(chooseLogin);
                            wkd.ShowDialog();
                        }
                      
                    }
                    else
                    {
                        lblError.Text = "Password isn`t correct";
                        lblError.Visible = true;
                    }

                }
            }
            else
            {
                lblError.Text = "E-mail isn`t correct";
                lblError.Visible = true;

            }
               
           
        
        }
    }
}
