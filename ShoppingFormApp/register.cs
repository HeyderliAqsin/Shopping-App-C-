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
    public partial class register : Form
    {
        ShoppingDbContext db = new ShoppingDbContext();
        public register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            string fullname = txtfullname.Text;
            string username = txtUsername.Text;
            string password = txtpassword.Text;
            string confirmPas = txtConfirm.Text;
            var myEmpty = new string[] { fullname, username, password, confirmPas };

            if (Utility.IsEmpty(myEmpty))
            {
                User selectedUser = db.Users.FirstOrDefault(x => x.UserName == username);
                if (selectedUser == null)
                {
                    if (password == confirmPas)
                    {
                        User newUser = new User()
                        {
                            Fullname = fullname,
                            UserName = username,
                            Password = password.HashMe(),
                            CreateDate = DateTime.Now

                        };
                        int roleId = db.Roles.FirstOrDefault(x => x.Name == "Worker").RoleId;
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        RolestoUser rtu = new()
                        {
                            UserId = newUser.UserId,
                            RoleId = roleId
                                
                        };
                        db.RolestoUsers.Add(rtu);
                        db.SaveChanges();

                        MessageBox.Show("User created successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Login lg = new Login();
                        lg.ShowDialog();
                    }
                    else
                    {
                        lbllError.Text = "Password and confirm password isn`t same";
                        lbllError.Visible = true;
                    }
                }
                else
                {
                    lbllError.Text = "User already exist!";
                    lbllError.Visible = true;
                }
            }
            else{
                lbllError.Text = "Please all the fill";
                lbllError.Visible = true;
            }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
