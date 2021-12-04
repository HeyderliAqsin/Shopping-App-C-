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
    public partial class AdminProductForm : Form
    {
        ShoppingDbContext db = new ShoppingDbContext();
        ProductId selectedProduct;
        public AdminProductForm()
        {
            InitializeComponent();
        }

        private void AdminProductForm_Load(object sender, EventArgs e)
        {
            FillProductGrid();
            FillCategoryCombo();
        }
        private void EnableEditDeletebtn(string text)
        {
            if (text == "ed")
            {
                btnAddProduct.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnAddProduct.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;

            }
        }
        private void FillCategoryCombo()
        {
            cmbCategories.Items.AddRange(db.Categories.Select(x => x.Name).ToArray());
        }
        private void FillProductGrid()
        {
            dtgProductList.DataSource = db.ProductIds.Where(x=>!x.IsDeleted).Select(x => new
            {
                x.ProductId1,
                ProductName = x.Name,
                x.Quantity,
                x.Price,
                CategoryName = x.Category.Name,

            }).ToList();
            dtgProductList.Columns[0].Visible = false;

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int catId = db.Categories.FirstOrDefault(x => x.Name == cmbCategories.Text).CategoryId;
            string productName = txtProductname.Text;
            decimal price = nmprice.Value;
            decimal quantity = nmquantity.Value;
            ProductId pr = new ProductId()
            {
                Name = productName,
                CategoryId = catId,
                Price=price,
                Quantity=(int)quantity

            };
            db.ProductIds.Add(pr);
            db.SaveChanges();
            MessageBox.Show("Product added successfuly!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillProductGrid();
        }

        private void dtgProductList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int productId = (int)dtgProductList.Rows[e.RowIndex].Cells[0].Value;
            selectedProduct = db.ProductIds.Include(x=>x.Category).FirstOrDefault(x => x.ProductId1 == productId);
            txtProductname.Text = selectedProduct.Name;
            cmbCategories.Text = selectedProduct.Category.Name;
            nmprice.Value =(decimal) selectedProduct.Price;
            nmquantity.Value =(decimal) selectedProduct.Quantity;
            EnableEditDeletebtn("ed");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEditDeletebtn("del");
            string ProductName = txtProductname.Text;
            int catId = db.Categories.FirstOrDefault(x => x.Name == cmbCategories.Text).CategoryId;
            decimal price = nmprice.Value;
            decimal quantity = nmquantity.Value;
            selectedProduct.Name = ProductName;
            selectedProduct.Price = price;
            selectedProduct.Quantity =(int) quantity;
            selectedProduct.CategoryId = catId;
            db.SaveChanges();

            FillProductGrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            EnableEditDeletebtn("del");
            DialogResult res = MessageBox.Show("Mehsulu silmek isteyirsiz?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res==DialogResult.Yes)
            {
                selectedProduct.IsDeleted = true;
                db.SaveChanges();
                FillProductGrid();
            }
        }
    }
}
