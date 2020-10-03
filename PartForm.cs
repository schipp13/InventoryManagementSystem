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
    public partial class PartForm : Form
    {
        // Global Variables
        Inhouse updatePart = new Inhouse();
        
        int _partIndex;

        public PartForm(string labelText, int partIndex)
        {
            InitializeComponent();
            labelTitle.Text = labelText;

            
            // Sets the background color of empty Textboxes
            if (String.IsNullOrEmpty(partName.Text))
            {
                partName.BackColor = Color.FromArgb(255, 255, 128, 128);
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
            
            if (String.IsNullOrEmpty(textBoxOption.Text))
            {
                textBoxOption.BackColor = Color.FromArgb(255, 255, 128, 128);
            }
           

            if (InHouse.Checked == true)
            {
                toolTip1.SetToolTip(this.textBoxOption, "Enter a String value");
                
            }
            else
            {
                toolTip1.SetToolTip(this.textBoxOption, "Enter a Integer value");
                
            }


            _partIndex = partIndex;

            // Makes the form modified
            if (labelTitle.Text == "Modify Part")
            {
                // Get selected part that is being modified properities
                try
                {
                   
                  updatePart = (Inhouse)Inventory.AllParts[partIndex];

                    InHouse.Checked = true;
                    // Inserts stored values into the text boxes
                    // When click the save button the items should be updated in the datagrid view
                    PartID.Text = updatePart.PartID.ToString();
                    partName.Text = updatePart.Name;
                    InStock.Text = updatePart.InStock.ToString();
                    Price.Text = updatePart.Price.ToString();
                    Max.Text = updatePart.Max.ToString();
                    Min.Text = updatePart.Min.ToString();
                    textBoxOption.Text = updatePart.MachineID.ToString();
                }
                catch (InvalidCastException)
                {
                    
                    var updatePart = new Outsourced();

                    updatePart = (Outsourced)Inventory.AllParts[partIndex];

                    OutSourced.Checked = true;
                    // Inserts stored values into the text boxes
                    // When click the save button the items should be updated in the datagrid view
                    PartID.Text = updatePart.PartID.ToString();
                    partName.Text = updatePart.Name;
                    InStock.Text = updatePart.InStock.ToString();
                    Price.Text = updatePart.Price.ToString();
                    Max.Text = updatePart.Max.ToString();
                    Min.Text = updatePart.Min.ToString();
                    textBoxOption.Text = updatePart.Company_Name.ToString();
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Goes back to the main screen with out saving
            this.Close();
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
          
        }

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
                // The form will add parts
                if (labelTitle.Text == "Add Part")
                {
                    // Checks to see if the Inhouse radio button was checked
                    if (InHouse.Checked == true)
                    {
                        // Creates instance of a new In-House Part
                        Inhouse InhousePart = new Inhouse();

                        PartID.Text = (Inventory.AllParts.Count()).ToString();

                        // Sets the objects attributes
                        InhousePart.PartID = int.Parse(PartID.Text);
                        InhousePart.Name = partName.Text;
                        InhousePart.InStock = int.Parse(InStock.Text);
                        InhousePart.Price = decimal.Parse(Price.Text);
                        InhousePart.Max = int.Parse(Max.Text);
                        InhousePart.Min = int.Parse(Min.Text);
                        InhousePart.MachineID = int.Parse(textBoxOption.Text);

                        // Adds InhousePart to the AllParts List
                        Inventory.addPart(InhousePart);

                    }
                    else
                    {
                        // Creates instance of a new Outsourced Part
                        Outsourced outsourcedPart = new Outsourced();

                        PartID.Text = (Inventory.AllParts.Count()).ToString();

                        // Sets the objects attributes
                        outsourcedPart.PartID = int.Parse(PartID.Text);
                        outsourcedPart.Name = partName.Text;
                        outsourcedPart.InStock = int.Parse(InStock.Text);
                        outsourcedPart.Price = decimal.Parse(Price.Text);
                        outsourcedPart.Max = int.Parse(Max.Text);
                        outsourcedPart.Min = int.Parse(Min.Text);
                        outsourcedPart.Company_Name = textBoxOption.Text;

                        // Adds OutsourcedPart to the AllParts List
                        Inventory.addPart(outsourcedPart);

                    }
                }
                else // Updates the changes to selected parts
                {

                    // Checks to see if the inhouse radio button was checked
                    if (InHouse.Checked == true)
                    {
                        Inhouse InhousePart = new Inhouse();

                        // reassigns the data to the new part
                        updatePart.PartID = int.Parse(PartID.Text);
                        updatePart.Name = partName.Text;
                        updatePart.InStock = int.Parse(InStock.Text);
                        updatePart.Price = decimal.Parse(Price.Text);
                        updatePart.Max = int.Parse(Max.Text);
                        updatePart.Min = int.Parse(Min.Text);
                        updatePart.MachineID = int.Parse(textBoxOption.Text);

                        // Passes the part index and the new part
                        Inventory.updatePart(_partIndex, updatePart);
                    }
                    else
                    {
                        Outsourced updatePart_Outsourced = new Outsourced();

                        // reassigns the data to the new part
                        updatePart_Outsourced.PartID = int.Parse(PartID.Text);
                        updatePart_Outsourced.Name = partName.Text;
                        updatePart_Outsourced.InStock = int.Parse(InStock.Text);
                        updatePart_Outsourced.Price = decimal.Parse(Price.Text);
                        updatePart_Outsourced.Max = int.Parse(Max.Text);
                        updatePart_Outsourced.Min = int.Parse(Min.Text);
                        updatePart_Outsourced.Company_Name = textBoxOption.Text;


                        // Passes the part index and the new part
                        Inventory.updatePart(_partIndex, updatePart_Outsourced);
                    }
                }

                // Checks to see if the min, max, and inventory values are within correct parameters
                if (int.Parse(Max.Text) < int.Parse(Min.Text))
                {
                    MessageBox.Show("The minimum value is greater than the max value.");

                }
                if (int.Parse(Max.Text) < int.Parse(InStock.Text) || int.Parse(Min.Text) > int.Parse(InStock.Text))
                {
                    MessageBox.Show("The Inventory value exceeds the max or minimum value.");
                }
            
            
            InHouse.Checked = false;
            OutSourced.Checked = false;

            // Goes back to the Main Screen
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Close();
        }

   
 // Tells the user what type of information is required in the textboxes
        private void partName_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.partName, "Enter a String");
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

        private void textBoxOption_Enter(object sender, EventArgs e)
        {
            if (InHouse.Checked == true)
            {
                toolTip1.SetToolTip(this.textBoxOption, "Enter a Integer value");
                
            }
            else
            {
                toolTip1.SetToolTip(this.textBoxOption, "Enter a String value");
            }


        }

        private void partName_TextChanged(object sender, EventArgs e)
        {
            partName.BackColor = Color.White;
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
        private void InHouse_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the label text 
            labelOption.Text = "Machine ID";
            if (InHouse.Checked == true && System.Text.RegularExpressions.Regex.IsMatch(textBoxOption.Text, "^[a-zA-Z ]"))
            {
                textBoxOption.BackColor = Color.FromArgb(255, 255, 128, 128);
                toolTip1.SetToolTip(this.textBoxOption, "Enter a Integer value");
            }
        }

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the label text 
            labelOption.Text = "Company Name";
            
        }
        private void textBoxOption_TextChanged(object sender, EventArgs e)
        {

            if (InHouse.Checked == true && System.Text.RegularExpressions.Regex.IsMatch(textBoxOption.Text, "^[a-zA-Z ]"))
            {
                textBoxOption.BackColor = Color.FromArgb(255, 255, 128, 128);
                toolTip1.SetToolTip(this.textBoxOption, "Enter a Integer value");
            }
            else
            {
                textBoxOption.BackColor = Color.White;
                toolTip1.SetToolTip(this.textBoxOption, "Enter a String value");
            }
        }
        private void InStock_TextChanged(object sender, EventArgs e)
        {
            InStock.BackColor = Color.White;
        }
    }
}
