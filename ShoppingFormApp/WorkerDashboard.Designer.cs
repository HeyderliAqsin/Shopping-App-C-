
namespace ShoppingFormApp
{
    partial class WorkerDashboard
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnsell = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgProductList = new System.Windows.Forms.DataGridView();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblnostock = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.nmMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.nmMinPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(47, 53);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(254, 28);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(47, 145);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(254, 28);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Enabled = false;
            this.nmQuantity.Location = new System.Drawing.Point(47, 259);
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(127, 27);
            this.nmQuantity.TabIndex = 5;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.ValueChanged += new System.EventHandler(this.nmQuantity_ValueChanged);
            // 
            // btnsell
            // 
            this.btnsell.BackColor = System.Drawing.Color.SkyBlue;
            this.btnsell.Enabled = false;
            this.btnsell.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsell.Location = new System.Drawing.Point(46, 380);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(249, 58);
            this.btnsell.TabIndex = 6;
            this.btnsell.Text = "Sell";
            this.btnsell.UseVisualStyleBackColor = false;
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblPrice.Location = new System.Drawing.Point(47, 326);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 31);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(162, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            this.label5.Visible = false;
            // 
            // dtgProductList
            // 
            this.dtgProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductList.Location = new System.Drawing.Point(374, 134);
            this.dtgProductList.Name = "dtgProductList";
            this.dtgProductList.RowHeadersWidth = 51;
            this.dtgProductList.RowTemplate.Height = 29;
            this.dtgProductList.Size = new System.Drawing.Size(766, 443);
            this.dtgProductList.TabIndex = 9;
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbluser.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbluser.Location = new System.Drawing.Point(1081, 9);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(59, 31);
            this.lbluser.TabIndex = 10;
            this.lbluser.Text = "user";
            // 
            // lblnostock
            // 
            this.lblnostock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblnostock.AutoSize = true;
            this.lblnostock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnostock.ForeColor = System.Drawing.Color.Red;
            this.lblnostock.Location = new System.Drawing.Point(51, 332);
            this.lblnostock.Name = "lblnostock";
            this.lblnostock.Size = new System.Drawing.Size(71, 31);
            this.lblnostock.TabIndex = 11;
            this.lblnostock.Text = "stock";
            this.lblnostock.Visible = false;
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblstock.Location = new System.Drawing.Point(161, 295);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(0, 31);
            this.lblstock.TabIndex = 12;
            this.lblstock.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(386, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category";
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Location = new System.Drawing.Point(375, 91);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(254, 28);
            this.cmbFilterCategory.TabIndex = 14;
            this.cmbFilterCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbFilterCategory_KeyUp);
            // 
            // nmMaxPrice
            // 
            this.nmMaxPrice.Location = new System.Drawing.Point(824, 91);
            this.nmMaxPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMaxPrice.Name = "nmMaxPrice";
            this.nmMaxPrice.Size = new System.Drawing.Size(122, 27);
            this.nmMaxPrice.TabIndex = 15;
            this.nmMaxPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmMinPrice
            // 
            this.nmMinPrice.Location = new System.Drawing.Point(660, 91);
            this.nmMinPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMinPrice.Name = "nmMinPrice";
            this.nmMinPrice.Size = new System.Drawing.Size(122, 27);
            this.nmMinPrice.TabIndex = 16;
            this.nmMinPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(824, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max Price";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(660, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Min Price";
            this.label7.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Orange;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(978, 74);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(144, 45);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // WorkerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 524);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmMinPrice);
            this.Controls.Add(this.nmMaxPrice);
            this.Controls.Add(this.cmbFilterCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.lblnostock);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.dtgProductList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnsell);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label1);
            this.Name = "WorkerDashboard";
            this.Text = "WorkerDashboard";
            this.Load += new System.EventHandler(this.WorkerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgProductList;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblnostock;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.NumericUpDown nmMaxPrice;
        private System.Windows.Forms.NumericUpDown nmMinPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFilter;
    }
}