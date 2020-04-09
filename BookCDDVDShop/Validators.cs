// Validators Class
// Responsible for all validation processing.  Includes validators that are part of VB but not CSHarp 
// Written in CSharp by Frank Friedman     Spring 2016

// Revised: June 16, 2017
// Revised: June 27, 2018

// This class contains "static" methods to handle required data validations for this Temple Owl project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;


namespace BookCDDVDShop
{
    // This class cannot be instantiated
    // It contains a collection of methods called to validate all input data from our Form

    class Validators
    {
        // Validate Form data for a Product
        public static bool ValidateProduct
           (string UPC, string price, string title, string quantity)
        {
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity))
                return true;
            else
                return false;
        }  // end ValidateProduct


        // Validate Product UPC
        public static bool ValidateProductUPC(string UPC)    // IN: Product's UPC (must be a 5 digit value with no preceding 0)
        {
            if (UPC == "" || UPC.Length != 5)
            {
                MessageBox.Show("Product UPC was blank or not exactly 5 characters. Re-enter.", "Product UPC Error");
                return false;
            }  // end Product UP blank

            if (UPC[0] == '0')
            {
                MessageBox.Show("Product UPC was began with a 0. Re-enter.", "Product UPC Error");
                return false;
            }

            // Using Regex to validate the Product UPC text box to contain exactly 5 digits 
            if (!System.Text.RegularExpressions.Regex.IsMatch(UPC, @"^[0-9]{5}$"))
            {
                MessageBox.Show("Product UPC must be a 5 digit value with no leading zeros. Reenter.",
                    "Regex Product UPC Error");
                return false;
            }  // end Product UPC Regex test
            return true;   // Passed all tests
        }  // end Validate ProductUPC

    }
}
