namespace Saige_Chipp
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Max = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.InStock = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInStock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AllPartsView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addAssociatedPart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AssociatedPartsView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.removeAssociatedPart = new System.Windows.Forms.Button();
            this.textBoxAssociatedPart = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.lookupAssociatedPart = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Max);
            this.panel1.Controls.Add(this.Min);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.InStock);
            this.panel1.Controls.Add(this.productName);
            this.panel1.Controls.Add(this.ProductID);
            this.panel1.Controls.Add(this.labelMin);
            this.panel1.Controls.Add(this.labelMax);
            this.panel1.Controls.Add(this.labelProductID);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelInStock);
            this.panel1.Location = new System.Drawing.Point(12, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 263);
            this.panel1.TabIndex = 1;
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.SystemColors.Window;
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max.Location = new System.Drawing.Point(85, 214);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(96, 26);
            this.Max.TabIndex = 10;
            this.Max.TextChanged += new System.EventHandler(this.Max_TextChanged);
            this.Max.Enter += new System.EventHandler(this.Max_Enter);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.SystemColors.Window;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(248, 214);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(96, 26);
            this.Min.TabIndex = 0;
            this.Min.TextChanged += new System.EventHandler(this.Min_TextChanged);
            this.Min.Enter += new System.EventHandler(this.Min_Enter);
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.Window;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(134, 162);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(140, 26);
            this.Price.TabIndex = 8;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            this.Price.Enter += new System.EventHandler(this.Price_Enter);
            // 
            // InStock
            // 
            this.InStock.BackColor = System.Drawing.SystemColors.Window;
            this.InStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InStock.Location = new System.Drawing.Point(134, 118);
            this.InStock.Name = "InStock";
            this.InStock.Size = new System.Drawing.Size(140, 26);
            this.InStock.TabIndex = 6;
            this.InStock.TextChanged += new System.EventHandler(this.InStock_TextChanged);
            this.InStock.Enter += new System.EventHandler(this.InStock_Enter);
            // 
            // productName
            // 
            this.productName.BackColor = System.Drawing.SystemColors.Window;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(134, 74);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(140, 26);
            this.productName.TabIndex = 4;
            this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
            this.productName.Enter += new System.EventHandler(this.productName_Enter);
            // 
            // ProductID
            // 
            this.ProductID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProductID.Enabled = false;
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(134, 28);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(140, 26);
            this.ProductID.TabIndex = 2;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(208, 217);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(34, 20);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(25, 220);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(38, 20);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "Max";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(25, 31);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(26, 20);
            this.labelProductID.TabIndex = 1;
            this.labelProductID.Text = "ID";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(25, 168);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(89, 20);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price / Cost";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(25, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelInStock
            // 
            this.labelInStock.AutoSize = true;
            this.labelInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInStock.Location = new System.Drawing.Point(25, 124);
            this.labelInStock.Name = "labelInStock";
            this.labelInStock.Size = new System.Drawing.Size(74, 20);
            this.labelInStock.TabIndex = 5;
            this.labelInStock.Text = "Inventory";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AllPartsView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addAssociatedPart);
            this.panel2.Location = new System.Drawing.Point(378, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 271);
            this.panel2.TabIndex = 4;
            // 
            // AllPartsView
            // 
            this.AllPartsView.AllowUserToAddRows = false;
            this.AllPartsView.AllowUserToDeleteRows = false;
            this.AllPartsView.AllowUserToResizeColumns = false;
            this.AllPartsView.AllowUserToResizeRows = false;
            this.AllPartsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsView.Location = new System.Drawing.Point(3, 19);
            this.AllPartsView.MultiSelect = false;
            this.AllPartsView.Name = "AllPartsView";
            this.AllPartsView.ReadOnly = true;
            this.AllPartsView.RowHeadersVisible = false;
            this.AllPartsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AllPartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPartsView.Size = new System.Drawing.Size(563, 209);
            this.AllPartsView.TabIndex = 1;
            this.AllPartsView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AllPartsView_DataBindingComplete);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "All Candidate Parts";
            // 
            // addAssociatedPart
            // 
            this.addAssociatedPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAssociatedPart.Location = new System.Drawing.Point(473, 234);
            this.addAssociatedPart.Name = "addAssociatedPart";
            this.addAssociatedPart.Size = new System.Drawing.Size(63, 31);
            this.addAssociatedPart.TabIndex = 2;
            this.addAssociatedPart.Text = "Add";
            this.addAssociatedPart.UseVisualStyleBackColor = true;
            this.addAssociatedPart.Click += new System.EventHandler(this.addAssociatedPart_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AssociatedPartsView);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.removeAssociatedPart);
            this.panel3.Location = new System.Drawing.Point(378, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 271);
            this.panel3.TabIndex = 5;
            // 
            // AssociatedPartsView
            // 
            this.AssociatedPartsView.AllowUserToAddRows = false;
            this.AssociatedPartsView.AllowUserToDeleteRows = false;
            this.AssociatedPartsView.AllowUserToResizeColumns = false;
            this.AssociatedPartsView.AllowUserToResizeRows = false;
            this.AssociatedPartsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssociatedPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsView.Location = new System.Drawing.Point(3, 22);
            this.AssociatedPartsView.Name = "AssociatedPartsView";
            this.AssociatedPartsView.ReadOnly = true;
            this.AssociatedPartsView.RowHeadersVisible = false;
            this.AssociatedPartsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AssociatedPartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsView.Size = new System.Drawing.Size(563, 209);
            this.AssociatedPartsView.TabIndex = 1;
            this.AssociatedPartsView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AssociatedPartsView_DataBindingComplete);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // removeAssociatedPart
            // 
            this.removeAssociatedPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAssociatedPart.Location = new System.Drawing.Point(473, 240);
            this.removeAssociatedPart.Name = "removeAssociatedPart";
            this.removeAssociatedPart.Size = new System.Drawing.Size(63, 31);
            this.removeAssociatedPart.TabIndex = 2;
            this.removeAssociatedPart.Text = "Delete";
            this.removeAssociatedPart.UseVisualStyleBackColor = true;
            this.removeAssociatedPart.Click += new System.EventHandler(this.removeAssociatedPart_Click);
            // 
            // textBoxAssociatedPart
            // 
            this.textBoxAssociatedPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAssociatedPart.Location = new System.Drawing.Point(672, 54);
            this.textBoxAssociatedPart.Name = "textBoxAssociatedPart";
            this.textBoxAssociatedPart.Size = new System.Drawing.Size(275, 26);
            this.textBoxAssociatedPart.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(851, 656);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(63, 31);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Cancel";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(760, 656);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 31);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // lookupAssociatedPart
            // 
            this.lookupAssociatedPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupAssociatedPart.Location = new System.Drawing.Point(598, 54);
            this.lookupAssociatedPart.Name = "lookupAssociatedPart";
            this.lookupAssociatedPart.Size = new System.Drawing.Size(59, 26);
            this.lookupAssociatedPart.TabIndex = 2;
            this.lookupAssociatedPart.Text = "Search";
            this.lookupAssociatedPart.UseVisualStyleBackColor = true;
            this.lookupAssociatedPart.Click += new System.EventHandler(this.lookupAssociatedPart_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(9, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add Product";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Saige_Chipp.Part);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 708);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.lookupAssociatedPart);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAssociatedPart);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox InStock;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView AllPartsView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAssociatedPart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView AssociatedPartsView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeAssociatedPart;
        private System.Windows.Forms.TextBox textBoxAssociatedPart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button lookupAssociatedPart;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}