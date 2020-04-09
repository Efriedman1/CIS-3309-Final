using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

/* CIS 3309 Final Project
 * Eric Friedman & Andrew Larkins
 * 
 * This class is used to create a CDChamber object. It inherts 
 * from the the CDClassical class. The objects attributes are Instrument.
 */

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class CDChamber : CDClassical //CDChamber inherts from CDClassical
    {
        private string hiddenInstrument;
        public CDChamber()
        {
            hiddenInstrument = "";
        }
        public CDChamber(int UPC, decimal price, string title, int quantity,  // For Product Constructor
            string label, string artist, string instrument) : base(UPC, price, title, quantity, label, artist)
        {
            hiddenInstrument = instrument;//Store instrument
        }
        //This method gets insturment name
        public string getInstrument()
        {
            return hiddenInstrument; //return instrument
        }
        //Tostring creates a string
        public override string ToString()
        {
            string s = "Object Type      : " + base.ToString() + "\n"; //object type
            s += "CDChamber Instrument    : " + hiddenInstrument + "\n"; //instrument
            return s;//return string
        }
    }
}
