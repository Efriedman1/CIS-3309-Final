using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCDDVDShop
{
    public partial class BookCDDVD : Form
    {
        Classes.ProductDB productDB = new Classes.ProductDB();
        Validators val = new Validators();

        Classes.Product product = new Classes.Product();
        Classes.Book book = new Classes.Book();
        Classes.CDChamber chamber = new Classes.CDChamber();
        Classes.CDClassical classical = new Classes.CDClassical();
        Classes.CDOrchestral orchestral = new Classes.CDOrchestral();
        Classes.CISBook cisBook = new Classes.CISBook();
        Classes.DVD dvd = new Classes.DVD();

        string selected = "";
        string edit = "";

        public BookCDDVD()
        {
            InitializeComponent();
        }

        //This method disables all the textboxs on the form
        private void disableTextboxes()
        {
            txtUPC.Enabled = false; //Disable textbox
            txtPrice.Enabled = false; //Disable textbox
            txtTitle.Enabled = false; //Disable textbox
            txtQuanity.Enabled = false; //Disable textbox
            txtISBN1.Enabled = false; //Disable textbox
            txtISBN2.Enabled = false; //Disable textbox
            txtAuthor.Enabled = false; //Disable textbox
            txtPages.Enabled = false; //Disable textbox
            txtCISArea.Enabled = false; //Disable textbox
            txtLeadActor.Enabled = false; //Disable textbox
            txtReleaseDate.Enabled = false; //Disable textbox
            txtRunTime.Enabled = false; //Disable textbox
            txtCDLabel.Enabled = false; //Disable textbox
            txtCDArtists.Enabled = false; //Disable textbox
            txtConductor.Enabled = false; //Disable textbox
            txtInstruments.Enabled = false; //Disable textbox
        }

    }
}
