using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

/* CIS 3309 Final Project
 * Eric Friedman & Andrew Larkins
 * 
 * This class is used to create a book object. It inherts 
 * from the the product class. The objects attributes are ISBN,
 * Author, pages.
 */

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class Book : Product //Book inherits from Product
    {
        private int hiddenISBN; //Book ISBN
        private string hiddenAuthor; //Book Author
        private int hiddenPages; //Book Pages
        public Book()
        {
            hiddenISBN = 000000; //Default value
            hiddenAuthor = "";//Default value
            hiddenPages = 0;//Default value
        }
        public Book(int UPC, decimal price, string title, int quantity,
                int ISBN, string Author, int pages) : base(UPC, price, title, quantity)
        {
            hiddenISBN = ISBN; //Store ISBN
            hiddenAuthor = Author; //Store Author
            hiddenPages = pages; //Store pages
        }
        //This method gets ISBN
        public int getISBN()
        {
            return hiddenISBN; //Return ISBN
        }
        //This method returns author
        public string getAuthor()
        {
            return hiddenAuthor; //Return Author
        }
        //This method returns pages
        public int getPages()
        {
            return hiddenPages; //Return pages
        }
        //Tostring method creates string
        public override string ToString()
        {
            string s = "Object Type      : " + base.ToString() + "\n"; //Object type
            s += "Book ISBN      : " + hiddenISBN + "\n"; //ISBN
            s += "Book Author    : " + hiddenAuthor + "\n";//Arthor
            s += "Book Pages    : " + Convert.ToDecimal(hiddenPages) + "\n"; //pages
            return s; //return string
        }
    }
}
