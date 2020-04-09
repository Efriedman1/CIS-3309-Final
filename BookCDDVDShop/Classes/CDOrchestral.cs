using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

/* CIS 3309 Final Project
 * Eric Friedman & Andrew Larkins
 * 
 * This class is used to create a CDOrchestral object. It inherts 
 * from the the CDClassical class. The objects attributes are conductor.
 */

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class CDOrchestral : CDClassical //CDOrchestral inherits from CDClassical
    {
        private string hiddenConductor;

        public CDOrchestral()
        {
            hiddenConductor = ""; //default value
        }
        public CDOrchestral(int UPC, decimal price, string title, int quantity,
            string label, string artist, string conductor) : base(UPC, price, title, quantity, label, artist)
        {
            hiddenConductor = conductor; //store conductor
        }
        //this method gets conductor
        public string getConductor()
        {
            return hiddenConductor; //return conductor
        }
        //Tostring converts to string
        public override string ToString()
        {
            string s = "Object Type      : " + base.ToString() + "\n"; //Object type
            s += "CDOrchestral Conductor    : " + hiddenConductor + "\n"; // conductor
            return s; //return string
        }
    }
}
