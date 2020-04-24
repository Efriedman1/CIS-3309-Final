using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

/* CIS 3309 Final Project
 * Eric Friedman & Andrew Larkins
 * 
 * This class is used to create a CISBook object. It inherts 
 * from the the book class. The objects attributes are CISArea.
 */

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class CISBook : Book //CISBook inherits from book
    {
        private string hiddenCISArea;
    

        public CISBook()
        {
            hiddenCISArea = "";//Default value
        }

        public CISBook(int UPC, decimal price, string title, int quantity, int ISBN, string Author,
            int pages, string area) : base(UPC, price, title, quantity, ISBN, Author, pages)
        {
            hiddenCISArea = area; //store area
        }
        //this returns CISArea
        public string getCISArea()
        {
            return hiddenCISArea; //Return CISArea
        }
        //Tostring converts to string
        public override string ToString()
        {
            string s = "Object Type      : " + base.ToString() + "\n";//object type
            s += "Book CISArea    : " + hiddenCISArea + "\n";//CISArea
            return s; //Return string
        }
    }
}
