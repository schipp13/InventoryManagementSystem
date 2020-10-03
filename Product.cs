using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saige_Chipp
{
   public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();       
        public int ProductID { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }


        public void addAssociatedPart(Part part)
        {
            // Adds selected row elements into Associated Parts List
            AssociatedParts.Add(part);

        }
      
    }
}
