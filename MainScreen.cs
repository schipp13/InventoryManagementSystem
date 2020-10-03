using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saige_Chipp
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            AllPartsView.DataSource = Inventory.AllParts;
            ProductsView.DataSource = Inventory.Products;
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Closes out the application
            Application.Exit();
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            
            // Loads the Part Form
            this.Hide();
            PartForm partForm = new PartForm("Add Part", 1);
            partForm.Show();

        }

        private void updatePart_Click(object sender, EventArgs e)
        {
            try
            {
                // Loads the Part Form
                this.Hide();
                PartForm partForm = new PartForm("Modify Part", AllPartsView.CurrentRow.Index);    // Passes string to change the part form title label and the selected part row -> Part Form
                partForm.Show();
            }
            catch (ArgumentOutOfRangeException partNotSelected)
            {
                MessageBox.Show("Please select something first", partNotSelected.Message);
            }
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
          try
          { // Deletes the selected part from the Parts datagridview
                DialogResult = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    Inventory.removePart(AllPartsView.SelectedRows[0].Index);

                }
            }
           catch(ArgumentOutOfRangeException partNotSelected)
            {
                MessageBox.Show("Please select something first", partNotSelected.Message);
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            // Loads the Product Form
            this.Hide();
            ProductForm _productForm = new ProductForm("Add Product", 1);
            _productForm.Show();

        }

        private void updateProduct_Click(object sender, EventArgs e)
        {

            // Checkes to see if a row has been selected 
            if (ProductsView.CurrentRow.Selected != true) 
            {
                MessageBox.Show("Please Select something to modify.");

            }
            else
            {
                // Loads the Product Form
                this.Hide();
                ProductForm _productForm = new ProductForm("Modify Product", ProductsView.CurrentRow.Index);  // Passes string to change the part form title label and the selected product row -> Product Form
                _productForm.Show();

            }            
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            try
            { 
                Inventory.currentProduct = (Product)ProductsView.CurrentRow.DataBoundItem;
                if (Inventory.currentProduct.AssociatedParts.Count >= 1)
                {

                    MessageBox.Show("Product can not be deleted. Please remove all associated parts first.");
                    
                }
                else
                    {
                        // Deletes the selected product from the Products datagridview
                        DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo);
                        if (DialogResult == DialogResult.Yes)
                        {
                            Inventory.removeProduct(ProductsView.SelectedRows[0].Index);

                        }
                    } 
            }
            catch (NullReferenceException productNotSelected)
                {
                    MessageBox.Show("Please select something first", productNotSelected.Message);
                }
            catch (ArgumentOutOfRangeException partNotSelected)
            {
                MessageBox.Show("Please select something first", partNotSelected.Message);
            }
           
        }

        private void lookupProduct_Click(object sender, EventArgs e)
        {
            // Get search value
            String searchProduct = textBoxProducts.Text;

            // Looks for search value in the entire datagrid
            foreach (DataGridViewRow row in ProductsView.Rows)
            {
                if (row.Cells["ProductID"].Value.ToString().Contains(searchProduct) || row.Cells["Name"].Value.ToString().Contains(searchProduct))
                {
                    ProductsView.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void lookupPart_Click(object sender, EventArgs e)
        {
            // Get search value
            String searchPart = textBoxParts.Text;

            // Looks for search value in the entire datagrid
            foreach (DataGridViewRow row in AllPartsView.Rows)
            {
                if (row.Cells["PartID"].Value.ToString().Contains(searchPart) || row.Cells["Name"].Value.ToString().Contains(searchPart))
                {
                    AllPartsView.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void AllPartsView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AllPartsView.ClearSelection();
        }

        private void ProductsView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           ProductsView.ClearSelection();
        }
    }
}
