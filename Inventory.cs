using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saige_Chipp
{
  class Inventory
    {
        
      public static BindingList<Part> AllParts = new BindingList<Part>();
      public static BindingList<Product> Products = new BindingList<Product>();
      public static Product currentProduct;
        public static void addProduct(Product product)
        {
            // Adds a product to the Products list
            Products.Add(product);
           
        } 
        public static bool removeProduct(int ProductIndex)
        {
            Products.RemoveAt(ProductIndex);

            return true ;
            
        }
      
        public static void  updateProduct(int ProductIndex, Product newproduct)
        {
            // Removes old part
            Products.RemoveAt(ProductIndex);

            // Add parts back to the AllParts list at the part index
            Products.Insert(ProductIndex, newproduct);

        }
        public static void addPart(Part part)
        {
            // Adds a part to the AllParts list
            AllParts.Add(part);

        }
        public static bool removePart(int PartIndex)
        {
            AllParts.RemoveAt(PartIndex);
            return true;
        }
      
        public static void updatePart(int PartIndex, Part newpart)
        {
            // Removes old part
            AllParts.RemoveAt(PartIndex);

            // Add parts back to the AllParts list at the part index
            AllParts.Insert(PartIndex, newpart);

        }

    }
    
}  
