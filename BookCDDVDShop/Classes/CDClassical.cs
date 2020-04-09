using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

/* CIS 3309 Final Project
 * Eric Friedman & Andrew Larkins
 * 
 * This class is used to create a CDClassical object. It inherts 
 * from the the Product class. The objects attributes are label, artist.
 */

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class CDClassical : Product //CDClassical inherits from Product
    {
        private string hiddenLabel;
        private string hiddenArtist;

        public CDClassical()
        {
            hiddenLabel = ""; //default value
            hiddenArtist = ""; //default value
        }

        public CDClassical(int UPC, decimal price, string title, int quantity, string label,
            string artist) : base(UPC, price, title, quantity)
        {
            hiddenLabel = label; //store label
            hiddenArtist = artist; //store artist
        }
        //this method gets the label
        public string getLabel()
        {
            return hiddenLabel; //return label
        }
        //this method returns artist
        public string getArtist()
        {
            return hiddenArtist; //return artist
        }
        //Tostring creates a string
        public override string ToString()
        {
            string s = "Object Type      : " + base.ToString() + "\n"; //objest type
            s += "CDClassical Label    : " + hiddenLabel + "\n"; //label
            s += "CDClassical Artist    : " + hiddenArtist + "\n"; //artist
            return s;//return string
        }
    }
}
