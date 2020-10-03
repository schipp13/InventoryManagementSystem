using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Saige_Chipp
{
    public partial class ProductForm : Form
    {
        // Global Variables
        Product updateProduct = new Product();
        // Creates instance of a new Product
        Product _Product = new Product();

        int _productIndex;

        public ProductForm(String labelText, int productIndex)
        {
            InitializeComponent();
            labelTitle.Text = labelText;
            _productIndex = productIndex;

            AllPartsView.DataSource = Inventory.AllParts;
           // AssociatedPartsView.DataSource = _Product.AssociatedParts;

            // Sets the background color of empty Textboxes
            if (String.IsNullOrEmpty(productName.Text))
            {
                productName.BackColor = Color.FromArgb(255, 255, 128, 128);
            }

            if (String.IsNullOrEmpty(InStock.Text))
            {
                InStock.BackColor = Color.FromArgb(255, 255, 128, 128);
            }

            if (String.IsNullOrEmpty(Price.Text))
            {
                Price.BackColor = Color.FromArgb(255, 255, 128, 128);
            }

            if (String.IsNullOrEmpty(Max.Text))
            {
                Max.BackColor = Color.FromArgb(255, 255, 128, 128);
            }

            if (String.IsNullOrEmpty(Min.Text))
            {
                Min.BackColor = Color.FromArgb(255, 255, 128, 128);
            }

            // Informs the user on what needs to be inputed
            toolTip1.SetToolTip(this.productName, "Enter a Name");
            toolTip1.SetToolTip(this.InStock, "Enter a Integer value");
            toolTip1.SetToolTip(this.Price, "Enter a Decimal Value");
            toolTip1.SetToolTip(this.Max, "Enter a Integer value");
            toolTip1.SetToolTip(this.Min, "Enter a Integer value");

            if (labelTitle.Text == "Modify Product")
            {
                // Creates an instance of an alread created product
                updateProduct = Inventory.Products[_productIndex];

                // Inserts stored values into the text boxes
                // When click the save button the items should be updated in the datagrid view
                ProductID.Text = updateProduct.ProductID.ToString();
                productName.Text = updateProduct.Name;
                InStock.Text = updateProduct.InStock.ToString();
                Price.Text = updateProduct.Price.ToString();
                Max.Text = updateProduct.Max.ToString();
                Min.Text = updateProduct.Min.ToString();
                // Gets the associated parts and populates the datagridview
                AssociatedPartsView.DataSource = updateProduct.AssociatedParts;
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Goes back to the main screen
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Close();
        }

        public void addAssociatedPart_Click(object sender, EventArgs e)
        {
             // Get selected parts row elements
             Part _AssociatedPart = (Part)AllPartsView.CurrentRow.DataBoundItem;

             // Pass selected parts row elements to be added to the AssociatedParts list
            _Product.addAssociatedPart(_AssociatedPart);

            // Populates datagridview with associated parts
            AssociatedPartsView.DataSource = _Product.AssociatedParts;
        }

        private void lookupAssociatedPart_Click(object sender, EventArgs e)
        {
            // Get search value
           String searchPart = textBoxAssociatedPart.Text;

            foreach(DataGridViewRow row in AllPartsView.Rows)
            {
                if(row.Cells["PartID"].Value.ToString().Contains(searchPart) || row.Cells["Name"].Value.ToString().Contains(searchPart))
                {
                    AllPartsView.Rows[row.Index].Selected = true;
                    break;
                }
            }

        }

        private void removeAssociatedPart_Click(object sender, EventArgs e)
        {
            // Removes selected part from bottom grid
            if (AssociatedPartsView.CurrentRow.Selected)
            {
                AssociatedPartsView.Rows.Remove(AssociatedPartsView.CurrentRow);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            if (labelTitle.Text == "Add Product")
          {
              ProductID.Text = (Inventory.Products.Count()).ToString();

              // Sets the objects attributes
                _Product.ProductID = int.Parse(ProductID.Text);
                _Product.Name = productName.Text;
                _Product.InStock = int.Parse(InStock.Text);
                _Product.Price = decimal.Parse(Price.Text);
                _Product.Max = int.Parse(Max.Text);
                _Product.Min = int.Parse(Min.Text);
                
             // Adds product to the Product List
              Inventory.addProduct(_Product);
          }
         else
          {
                // reassigns the data to the new part
                updateProduct.ProductID = int.Parse(ProductID.Text);
                updateProduct.Name = productName.Text;
                updateProduct.InStock = int.Parse(InStock.Text);
                updateProduct.Price = decimal.Parse(Price.Text);
                updateProduct.Max = int.Parse(Max.Text);
                updateProduct.Min = int.Parse(Min.Text);

                // Passes the part index and the new part
                Inventory.updateProduct(_productIndex, updateProduct);
          }
              // Makes sure the Min, Max, and inventory values are in the correct parameters.
            if(int.Parse(Max.Text) < int.Parse(Min.Text))
            {
                MessageBox.Show("The minimum value is greater than the max value.");
            }
            if(int.Parse(Max.Text) < int.Parse(InStock.Text) || int.Parse(Min.Text) > int.Parse(InStock.Text))
            {
                MessageBox.Show("The Inventory value exceeds the max or minimum value.");
            }
                       
            // Go back to main screen
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Close();

        }

        private void AllPartsView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AllPartsView.ClearSelection();
        }

        private void AssociatedPartsView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AssociatedPartsView.ClearSelection();
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {
            productName.BackColor = Color.White;
        }

        private void InStock_TextChanged(object sender, EventArgs e)
        {
            InStock.BackColor = Color.White;
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            Price.BackColor = Color.White;
        }

        private void Max_TextChanged(object sender, EventArgs e)
        {
            Max.BackColor = Color.White;
        }

        private void Min_TextChanged(object sender, EventArgs e)
        {
            Min.BackColor = Color.White;
        }
        // Tells the user what type of information is required in the textboxes
        private void productName_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.productName, "Enter a String");
        }

        private void InStock_Enter(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(this.InStock, "Enter a Integer value");

        }

        private void Price_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.Price, "Enter a Decimal Value");

        }

        private void Max_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.Max, "Enter a Integer value");

        }

        private void Min_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.Min, "Enter a Integer value");
        }

    }
}
