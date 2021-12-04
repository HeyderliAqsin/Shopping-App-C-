
namespace ShoppingFormApp
{
    partial class AdminProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.Categories = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmprice = new System.Windows.Forms.NumericUpDown();
            this.nmquantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dtgProductList = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // txtProductname
            // 
            this.txtProductname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductname.Location = new System.Drawing.Point(30, 158);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(227, 34);
            this.txtProductname.TabIndex = 1;
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Categories.Location = new System.Drawing.Point(30, 11);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(112, 28);
            this.Categories.TabIndex = 2;
            this.Categories.Text = "Categories";
            // 
            // cmbCategories
            // 
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(30, 55);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(227, 36);
            this.cmbCategories.TabIndex = 3;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // nmprice
            // 
            this.nmprice.DecimalPlaces = 2;
            this.nmprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmprice.Location = new System.Drawing.Point(30, 264);
            this.nmprice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmprice.Name = "nmprice";
            this.nmprice.Size = new System.Drawing.Size(227, 34);
            this.nmprice.TabIndex = 5;
            // 
            // nmquantity
            // 
            this.nmquantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmquantity.Location = new System.Drawing.Point(30, 354);
            this.nmquantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmquantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmquantity.Name = "nmquantity";
            this.nmquantity.Size = new System.Drawing.Size(227, 34);
            this.nmquantity.TabIndex = 7;
            this.nmquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(30, 438);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(227, 61);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dtgProductList
            // 
            this.dtgProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductList.Location = new System.Drawing.Point(400, 55);
            this.dtgProductList.Name = "dtgProductList";
            this.dtgProductList.RowHeadersWidth = 51;
            this.dtgProductList.RowTemplate.Height = 29;
            this.dtgProductList.Size = new System.Drawing.Size(765, 473);
            this.dtgProductList.TabIndex = 9;
            this.dtgProductList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgProductList_RowHeaderMouseDoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(30, 438);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 61);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(145, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 61);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 606);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtgProductList);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.nmquantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.txtProductname);
            this.Controls.Add(this.label1);
            this.Name = "AdminProductForm";
            this.Text = "AdminProductForm";
            this.Load += new System.EventHandler(this.AdminProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Label Categories;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmprice;
        private System.Windows.Forms.NumericUpDown nmquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dtgProductList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}