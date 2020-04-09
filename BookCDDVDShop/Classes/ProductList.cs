using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* CIS 3309 Final Project
 * Eric Friedman & Andrew Larkins
 * 
 * This Class Used to manipulate the productlist
 */

namespace BookCDDVDShop.Classes
{
    class ProductList
    {
        private ArrayList productList = new ArrayList();

        public ProductList()
        {

        }
        //This method adds product to the list
        public void AddProduct(Product p)
        {
            productList.Add(p); //Add p to the productlist
        }
        //This method remove product to the list
        public void RemoveProduct(Product p)
        {
            productList.Remove(p); //Remove p from the porductlist
        }
    }
}
