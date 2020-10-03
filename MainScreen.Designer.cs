namespace Saige_Chipp
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookupPart = new System.Windows.Forms.Button();
            this.AllPartsView = new System.Windows.Forms.DataGridView();
            this.deletePart = new System.Windows.Forms.Button();
            this.updatePart = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.labelParts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lookupProduct = new System.Windows.Forms.Button();
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.updateProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.textBoxProducts = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lookupPart);
            this.panel1.Controls.Add(this.AllPartsView);
            this.panel1.Controls.Add(this.deletePart);
            this.panel1.Controls.Add(this.updatePart);
            this.panel1.Controls.Add(this.addPart);
            this.panel1.Controls.Add(this.textBoxParts);
            this.panel1.Controls.Add(this.labelParts);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 319);
            this.panel1.TabIndex = 0;
            // 
            // lookupPart
            // 
            this.lookupPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupPart.Location = new System.Drawing.Point(280, 1);
            this.lookupPart.Name = "lookupPart";
            this.lookupPart.Size = new System.Drawing.Size(65, 26);
            this.lookupPart.TabIndex = 5;
            this.lookupPart.Text = "Search";
            this.lookupPart.UseVisualStyleBackColor = true;
            this.lookupPart.Click += new System.EventHandler(this.lookupPart_Click);
            // 
            // AllPartsView
            // 
            this.AllPartsView.AllowUserToAddRows = false;
            this.AllPartsView.AllowUserToDeleteRows = false;
            this.AllPartsView.AllowUserToResizeColumns = false;
            this.AllPartsView.AllowUserToResizeRows = false;
            this.AllPartsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllPartsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AllPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllPartsView.DefaultCellStyle = dataGridViewCellStyle1;
            this.AllPartsView.Location = new System.Drawing.Point(7, 32);
            this.AllPartsView.MultiSelect = false;
            this.AllPartsView.Name = "AllPartsView";
            this.AllPartsView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.AllPartsView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllPartsView.RowHeadersVisible = false;
            this.AllPartsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AllPartsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AllPartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPartsView.Size = new System.Drawing.Size(587, 235);
            this.AllPartsView.TabIndex = 1;
            this.AllPartsView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AllPartsView_DataBindingComplete);
            // 
            // deletePart
            // 
            this.deletePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePart.Location = new System.Drawing.Point(529, 273);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(65, 33);
            this.deletePart.TabIndex = 6;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // updatePart
            // 
            this.updatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePart.Location = new System.Drawing.Point(458, 273);
            this.updatePart.Name = "updatePart";
            this.updatePart.Size = new System.Drawing.Size(65, 33);
            this.updatePart.TabIndex = 3;
            this.updatePart.Text = "Modify";
            this.updatePart.UseVisualStyleBackColor = true;
            this.updatePart.Click += new System.EventHandler(this.updatePart_Click);
            // 
            // addPart
            // 
            this.addPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart.Location = new System.Drawing.Point(381, 273);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(65, 33);
            this.addPart.TabIndex = 2;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // textBoxParts
            // 
            this.textBoxParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParts.Location = new System.Drawing.Point(351, 3);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(243, 26);
            this.textBoxParts.TabIndex = 4;
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParts.Location = new System.Drawing.Point(3, 0);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(51, 24);
            this.labelParts.TabIndex = 0;
            this.labelParts.Text = "Parts";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lookupProduct);
            this.panel2.Controls.Add(this.ProductsView);
            this.panel2.Controls.Add(this.deleteProduct);
            this.panel2.Controls.Add(this.updateProduct);
            this.panel2.Controls.Add(this.addProduct);
            this.panel2.Controls.Add(this.textBoxProducts);
            this.panel2.Controls.Add(this.labelProduct);
            this.panel2.Location = new System.Drawing.Point(627, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 319);
            this.panel2.TabIndex = 1;
            // 
            // lookupProduct
            // 
            this.lookupProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupProduct.Location = new System.Drawing.Point(279, 3);
            this.lookupProduct.Name = "lookupProduct";
            this.lookupProduct.Size = new System.Drawing.Size(65, 26);
            this.lookupProduct.TabIndex = 5;
            this.lookupProduct.Text = "Search";
            this.lookupProduct.UseVisualStyleBackColor = true;
            this.lookupProduct.Click += new System.EventHandler(this.lookupProduct_Click);
            // 
            // ProductsView
            // 
            this.ProductsView.AllowUserToAddRows = false;
            this.ProductsView.AllowUserToDeleteRows = false;
            this.ProductsView.AllowUserToResizeColumns = false;
            this.ProductsView.AllowUserToResizeRows = false;
            this.ProductsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.Location = new System.Drawing.Point(7, 32);
            this.ProductsView.MultiSelect = false;
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.ReadOnly = true;
            this.ProductsView.RowHeadersVisible = false;
            this.ProductsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.ProductsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsView.Size = new System.Drawing.Size(587, 235);
            this.ProductsView.TabIndex = 1;
            this.ProductsView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ProductsView_DataBindingComplete);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.Location = new System.Drawing.Point(528, 273);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(65, 33);
            this.deleteProduct.TabIndex = 6;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // updateProduct
            // 
            this.updateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProduct.Location = new System.Drawing.Point(457, 273);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(65, 33);
            this.updateProduct.TabIndex = 3;
            this.updateProduct.Text = "Modify";
            this.updateProduct.UseVisualStyleBackColor = true;
            this.updateProduct.Click += new System.EventHandler(this.updateProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Location = new System.Drawing.Point(381, 273);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(65, 33);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // textBoxProducts
            // 
            this.textBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProducts.Location = new System.Drawing.Point(350, 3);
            this.textBoxProducts.Name = "textBoxProducts";
            this.textBoxProducts.Size = new System.Drawing.Size(243, 26);
            this.textBoxProducts.TabIndex = 4;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(3, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(84, 24);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Products";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(268, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Inventory Management System";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1155, 391);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(65, 33);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 438);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button lookupPart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button updatePart;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.Button lookupProduct;
        private System.Windows.Forms.DataGridView ProductsView;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button updateProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.TextBox textBoxProducts;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView AllPartsView;
    }
}

