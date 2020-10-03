namespace Saige_Chipp
{
    partial class PartForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOption = new System.Windows.Forms.Label();
            this.textBoxOption = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.InStock = new System.Windows.Forms.TextBox();
            this.partName = new System.Windows.Forms.TextBox();
            this.PartID = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPartID = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInStock = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.InHouse = new System.Windows.Forms.RadioButton();
            this.OutSourced = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(260, 404);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(67, 41);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(358, 404);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(67, 41);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelOption);
            this.panel1.Controls.Add(this.textBoxOption);
            this.panel1.Controls.Add(this.Min);
            this.panel1.Controls.Add(this.Max);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.InStock);
            this.panel1.Controls.Add(this.partName);
            this.panel1.Controls.Add(this.PartID);
            this.panel1.Controls.Add(this.labelMin);
            this.panel1.Controls.Add(this.labelMax);
            this.panel1.Controls.Add(this.labelPartID);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelInStock);
            this.panel1.Location = new System.Drawing.Point(53, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 328);
            this.panel1.TabIndex = 3;
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption.Location = new System.Drawing.Point(3, 261);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(90, 20);
            this.labelOption.TabIndex = 12;
            this.labelOption.Text = "Machine ID";
            // 
            // textBoxOption
            // 
            this.textBoxOption.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOption.Location = new System.Drawing.Point(134, 255);
            this.textBoxOption.Name = "textBoxOption";
            this.textBoxOption.Size = new System.Drawing.Size(140, 26);
            this.textBoxOption.TabIndex = 13;
            this.textBoxOption.TextChanged += new System.EventHandler(this.textBoxOption_TextChanged);
            this.textBoxOption.Enter += new System.EventHandler(this.textBoxOption_Enter);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.SystemColors.Window;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(297, 214);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(96, 26);
            this.Min.TabIndex = 11;
            this.Min.TextChanged += new System.EventHandler(this.Min_TextChanged);
            this.Min.Enter += new System.EventHandler(this.Min_Enter);
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.SystemColors.Window;
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max.Location = new System.Drawing.Point(134, 214);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(96, 26);
            this.Max.TabIndex = 9;
            this.Max.TextChanged += new System.EventHandler(this.Max_TextChanged);
            this.Max.Enter += new System.EventHandler(this.Max_Enter);
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.Window;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(134, 162);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(140, 26);
            this.Price.TabIndex = 7;
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
            this.InStock.TabIndex = 5;
            this.InStock.TextChanged += new System.EventHandler(this.InStock_TextChanged);
            this.InStock.Enter += new System.EventHandler(this.InStock_Enter);
            // 
            // partName
            // 
            this.partName.BackColor = System.Drawing.SystemColors.Window;
            this.partName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partName.Location = new System.Drawing.Point(134, 74);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(140, 26);
            this.partName.TabIndex = 3;
            this.partName.TextChanged += new System.EventHandler(this.partName_TextChanged);
            this.partName.Enter += new System.EventHandler(this.partName_Enter);
            // 
            // PartID
            // 
            this.PartID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PartID.Enabled = false;
            this.PartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartID.Location = new System.Drawing.Point(134, 28);
            this.PartID.Name = "PartID";
            this.PartID.Size = new System.Drawing.Size(140, 26);
            this.PartID.TabIndex = 1;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(240, 217);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(34, 20);
            this.labelMin.TabIndex = 10;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(74, 217);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(38, 20);
            this.labelMax.TabIndex = 8;
            this.labelMax.Text = "Max";
            // 
            // labelPartID
            // 
            this.labelPartID.AutoSize = true;
            this.labelPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartID.Location = new System.Drawing.Point(86, 28);
            this.labelPartID.Name = "labelPartID";
            this.labelPartID.Size = new System.Drawing.Size(26, 20);
            this.labelPartID.TabIndex = 0;
            this.labelPartID.Text = "ID";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(31, 165);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(89, 20);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price / Cost";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(62, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelInStock
            // 
            this.labelInStock.AutoSize = true;
            this.labelInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInStock.Location = new System.Drawing.Point(45, 121);
            this.labelInStock.Name = "labelInStock";
            this.labelInStock.Size = new System.Drawing.Size(74, 20);
            this.labelInStock.TabIndex = 4;
            this.labelInStock.Text = "Inventory";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(13, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(71, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add Part";
            // 
            // InHouse
            // 
            this.InHouse.AutoSize = true;
            this.InHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouse.Location = new System.Drawing.Point(157, 13);
            this.InHouse.Name = "InHouse";
            this.InHouse.Size = new System.Drawing.Size(80, 20);
            this.InHouse.TabIndex = 1;
            this.InHouse.Text = "In-House";
            this.InHouse.UseVisualStyleBackColor = true;
            this.InHouse.CheckedChanged += new System.EventHandler(this.InHouse_CheckedChanged);
            // 
            // OutSourced
            // 
            this.OutSourced.AutoSize = true;
            this.OutSourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutSourced.Location = new System.Drawing.Point(273, 11);
            this.OutSourced.Name = "OutSourced";
            this.OutSourced.Size = new System.Drawing.Size(95, 20);
            this.OutSourced.TabIndex = 2;
            this.OutSourced.Text = "Outsourced";
            this.OutSourced.UseVisualStyleBackColor = true;
            this.OutSourced.CheckedChanged += new System.EventHandler(this.Outsourced_CheckedChanged);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 457);
            this.Controls.Add(this.OutSourced);
            this.Controls.Add(this.InHouse);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "PartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.TextBox textBoxOption;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox InStock;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox PartID;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelPartID;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInStock;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton InHouse;
        private System.Windows.Forms.RadioButton OutSourced;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}