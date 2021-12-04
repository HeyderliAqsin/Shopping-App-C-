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
    public partial class WorkerDashboard : Form
    {
        ShoppingDbContext db = new ShoppingDbContext();
        ProductId selectedProduct;
        User activeUser;
        public WorkerDashboard(User us)
        {
            activeUser = us;
            InitializeComponent();
        }

        private void WorkerDashboard_Load(object sender, EventArgs e)
        {
            lbluser.Text = "Welcome " + activeUser.Fullname;
            FillCategoryCombo();
            FillFilterCategoryCombo();
            EnableFilter();
            FillProductGrid();
        }

        public void FillProductGrid()
        {
    
            dtgProductList.DataSource = db.Orders.Where(x=>x.UserId==activeUser.UserId && 
            x.Product.Category.Name.StartsWith(cmbFilterCategory.Text)
            && x.Product.Price>=nmMinPrice.Value && x.Product.Price<=nmMaxPrice.Value
            ).Select(x => new
            {
               ProductName= x.Product.Name,
               x.Quantity,
               x.Product.Price,
               TotalPrice=x.Product.Price*x.Quantity,
               x.PurchaseDate
            }).ToList();
        }

        public void FillCategoryCombo()
        {
            cmbCategory.Items.AddRange(db.Categories.Select(x => x.Name).ToArray());
        }

        public void FillFilterCategoryCombo()
        {
            cmbFilterCategory.Items.AddRange(db.Categories.Select(x => x.Name).ToArray());
        }


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProduct.Text = "";
            nmQuantity.Enabled = false;
            string categoryName = cmbCategory.Text;
            int catId = db.Categories.FirstOrDefault(x => x.Name == categoryName).CategoryId;
            cmbProduct.Items.Clear();
            cmbProduct.Items.AddRange(db.ProductIds.Where(x => x.CategoryId == catId).Select(x => x.Name).ToArray());
            btnsell.Enabled = false;
            lblPrice.Visible = false;
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmQuantity.Value = 1;
            string productName = cmbProduct.Text;
            selectedProduct = db.ProductIds.FirstOrDefault(p => p.Name == productName);
            nmQuantity.Maximum = (int)selectedProduct.Quantity;
            nmQuantity.Enabled = true;
            btnsell.Enabled = true;
            lblPrice.Text = (decimal)(selectedProduct.Price * nmQuantity.Value) + "Azn";
            lblPrice.Visible = true;
            if (selectedProduct.Quantity > 0)
            {
                lblstock.Text = nmQuantity.Maximum + " eded qalib";
                lblstock.Visible = true;
                lblstock.ForeColor = Color.Green;

            }
            else
            {
                lblstock.Text =nmQuantity.Minimum + " Mehsul bitib";
                lblstock.Visible = true;
                lblstock.ForeColor = Color.Red;
                btnsell.Enabled = false;

            }

        }

        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblPrice.Text = (int)(selectedProduct.Price * nmQuantity.Value) + " Azn";
        }

        private void dtgGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            Order newOrder = new()
            {
                ProductId = selectedProduct.ProductId1,
                UserId = activeUser.UserId,
                PurchaseDate = DateTime.Now,
                TotalPrice =(decimal) selectedProduct.Price * nmQuantity.Value,
                Quantity = (int)nmQuantity.Value
            };
            selectedProduct.Quantity -= (int)nmQuantity.Value;

            db.Orders.Add(newOrder);
            db.SaveChanges();
            MessageBox.Show("Product sale successfuly!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbProduct.Text = "";
            cmbCategory.Text = "";
            cmbProduct.Items.Clear();
            nmQuantity.Value = 1;
            nmQuantity.Enabled = false;
            btnsell.Enabled = false;
            lblPrice.Visible = false;
            FillProductGrid();
            EnableFilter();
        }


        private void cmbFilterCategory_KeyUp(object sender, KeyEventArgs e)
        {
            FillProductGrid();  
        }

        private void EnableFilter()
        {
            var orderList = db.Orders.Include(x => x.Product).Where(x => x.UserId == activeUser.UserId).ToList();
            if (orderList != null && orderList.Count > 0)
            {
                decimal maxPrice = (decimal)orderList.Max(x => x.Product.Price);
                nmMaxPrice.Maximum = maxPrice;
                nmMinPrice.Maximum = maxPrice;

                nmMinPrice.Visible = true;
                nmMaxPrice.Visible = true;
                btnFilter.Visible = true;
                cmbFilterCategory.Visible = true;

            }
            else
            {
                nmMinPrice.Visible = false;
                nmMaxPrice.Visible = false;
                btnFilter.Visible = false;
                cmbFilterCategory.Visible = false;
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            FillProductGrid();
        }
    }
}
