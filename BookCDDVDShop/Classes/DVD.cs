using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

/* CIS 3309 Final Project
 * Eric Friedman & Andrew Larkins
 * 
 * This class is used to create a dvd object. It inherts 
 * from the the product class. The objects attributes are Leadactor,
 * ReleaseDate,Runtime.
 */

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class DVD : Product //DVD inherits from Product
    {
        private string hiddenLeadActor; //Lead Actor
        private DateTime hiddenReleaseDate; //Release Date
        private int hiddenRuntime; //Runtime

        public DVD()
        {
            hiddenLeadActor = ""; //default value
            hiddenReleaseDate = Convert.ToDateTime("05/01/1996");//default value
            hiddenRuntime = 0;//default value
        }
        public DVD(int UPC, decimal price, string title, int quantity,
                string actor, string date, int runtime) : base(UPC, price, title, quantity)
        {
            hiddenLeadActor = actor; //Store actor
            hiddenReleaseDate = Convert.ToDateTime(date); //store date
            hiddenRuntime = runtime; //store runtime
        }
        //this returns lead actor
        public string getLeadActor()
        {
            return hiddenLeadActor; //return actor
        }
        // this returns release date
        public DateTime getReleaseDate()
        {
            return hiddenReleaseDate; //return date
        }
        // this returns run time
        public int getRuntime()
        {
            return hiddenRuntime;//return time
        }
        //tostring converts to string
        public override string ToString()
        {
            string s = "Object Type      : " + base.ToString() + "\n";//object type
            s += "DVD Actor    : " + hiddenLeadActor + "\n"; //actor
            s += "DVD Release Date    : " + hiddenReleaseDate + "\n";//release date
            s += "DVD Runtime    : " + hiddenRuntime + "\n";//runtime
            return s;//return string
        }
    }
}
