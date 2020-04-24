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
   

    class Validators
    {
        //This method checks if UPC is valid. UPC(5 digit integer; no leading zero)
        public bool validateUPC(int upc)
        {
            string upcString = upc.ToString(); //Convert int to string
            if (upcString.Length == 5) //Check string length
            {
                if (!upcString.StartsWith("0")) { return true; } //Valid
                else
                {
                    MessageBox.Show("Invalid upc");
                    return false;
                } //Invalid
            }
            MessageBox.Show("Invalid upc");
            return false; //Invalid UPC
        }
        //This method checks if Price is valid. Price(Decimal > 0, exactly 2 decimal places)
        public bool validatePrice(decimal price)
        {
            if (price > 0) //Check if price > 0
            {
                try
                {
                    string[] a = Convert.ToString(price).Split(new char[] { '.' });
                    int decimals = a[1].Length;
                    if (decimals == 2) //Check decimal places
                    {
                        return true;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid price");
                    return false; //failed
                }
            }
            MessageBox.Show("Invalid price");
            return false;
        }
        //validate title
        public bool validateTitle(string title)
        {
            if (title != "") { return true; }
            else
            {
                MessageBox.Show("Invalid Title");
                return false;
            }
        }
        //This method checks if quantity is valid. Quantity(integer > 0)
        public bool validateQuantity(int qty)
        {
            if (qty > 0) { return true; } //Valid
            else
            {
                MessageBox.Show("Invalid Quantity");
                return false;
            } //Not Valid
        }
        //validate ISBN
        public bool validateISBN(int isbn1, int isbn2)
        {
            String s1 = Convert.ToString(isbn1); //Convert to String
            String s2 = Convert.ToString(isbn2);//Convert to String
            s1 += s2;
            if (s1.Length == 6) //Check Length
            {
                return true;
            }
            MessageBox.Show("Invalid ISBN");
            return false;
        }
        //validate author
        public bool validateAuthor(string author)
        {
            if (author != "") { return true; }
            else
            {
                MessageBox.Show("Invalid author");
                return false;
            }
        }
        //validate pages
        public bool validatePages(int pages)
        {
            if (pages > 0) { return true; }
            else
            {
                MessageBox.Show("Invalid pages");
                return false;
            }
        }
        //validate area
        public bool validateCISArea(string area)
        {
            if (area != "") { return true; }
            else
            {
                MessageBox.Show("Invalid CISArea");
                return false;
            }
        }
        //Validate actor name
        public bool validateActor(string actor)
        {
            if (actor != "") { return true; }
            else
            {
                MessageBox.Show("Invalid actor");
                return false;
            }
        }

        //NEED TO DO Release Date(mm/dd/yyyy - must be after January 1, 1980 and before December 31, 2019)
        //validate runtime
        public bool validateRuntime(int runtime)
        {
            if (runtime > 0 && runtime <= 240) { return true; }
            else
            {
                MessageBox.Show("Invalid Runtime");
                return false;
            }
        }
        //validate label
        public bool validateLabel(string label)
        {
            if (label != "") { return true; }
            else
            {
                MessageBox.Show("Invalid label");
                return false;
            }
        }
        //validate artist
        public bool validateArtist(string artist)
        {
            if (artist != "") { return true; }
            else
            {
                MessageBox.Show("Invalid artist");
                return false;
            }
        }
        //Validate conductor
        public bool validateConductor(string conductor)
        {
            if (conductor != "") { return true; }
            else
            {
                MessageBox.Show("Invalid conductor");
                return false;
            }
        }
        //validate instrument
        public bool validateInstrument(string instrument)
        {
            if (instrument != "") { return true; }
            else
            {
                MessageBox.Show("Invalid instrument");
                return false;
            }
        }

    }
}
