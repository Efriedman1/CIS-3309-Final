using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

/* CIS 3309 Final Project
 * Eric Friedman & Andrew Larkins
 * 
 * This is used to create a product object. The object
 * contains a upc, title, price, quantity.
 */

namespace BookCDDVDShop.Classes
{

    [Serializable()]

    class Product
    {
        private int hiddenUPC; //Product UPC
        private decimal hiddenPrice; //Product Price
        private string hiddenTitle; //Product Title
        private int hiddenQuantity; //Product Quantity
        public Product()
        {
            hiddenUPC = 0; //Default value
            hiddenPrice = 0.0m; //Default value
            hiddenTitle = ""; //Default value
            hiddenQuantity = 0; //Default value
        }
        public Product(int UPC, decimal price, string title, int quantity)
        {
            hiddenUPC = UPC; //Store UPC
            hiddenPrice = price; //Store price
            hiddenTitle = title; //Store title
            hiddenQuantity = quantity; //Store quantity 
        }

        //Get product upc
        public int getUPC()
        {
            return hiddenUPC; //Return upc
        }
        //Get product Price
        public decimal getPrice()
        {
            return hiddenPrice; //Return Price
        }
        //Get product Title
        public string getTitle()
        {
            return hiddenTitle; //Return Title
        }
        //Get product Quantity
        public int getQuantity()
        {
            return hiddenQuantity; //Return Quantity
        }



        //Create a string with product values
        public override string ToString()
        {
            string s = "Object Type      : " + base.ToString() + "\n"; //Object Type
            s += "Product UPC      : " + hiddenUPC + "\n"; // UPC
            s += "Product Title    : " + hiddenTitle + "\n"; //Title
            s += "Product Price    : " + Convert.ToDecimal(hiddenPrice) + "\n"; //Price
            s += "Product Quantity : " + Convert.ToInt32(hiddenQuantity); //Quantity
            return s;
        }
        //Display message box of product as a string
        public void displayProductAsString(Product p)
        {
            string s = " ";
            s += "Product UPC       : " + p.hiddenUPC + "\n";
            s += "Product Title       : " + p.hiddenTitle + "\n";
            s += "Product Price      : " + Convert.ToDecimal(p.hiddenPrice) + "\n";
            s += "Product Quantity : " + Convert.ToInt32(p.hiddenQuantity);
            MessageBox.Show(s, "Display a Single Product in Product List"); //Message box
        }
    }
}
