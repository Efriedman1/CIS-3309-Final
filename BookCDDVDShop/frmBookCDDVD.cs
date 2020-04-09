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

        //This method disables all the textboxes on the form
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

        //Resets the colors of the buttons back to their original state
        private void resetButtonColors()
        {
            //Top Buttons
            btnCreateBook.BackColor = Color.White;
            btnCreateBookCIS.BackColor = Color.White;
            btnCreateCDChamber.BackColor = Color.White;
            btnCreateCDOrchestral.BackColor = Color.White;
            btnCreateDVD.BackColor = Color.White;

            //Bottom Buttons
            btnAdd.BackColor = Color.LightGray;
            btnFindDisplay.BackColor = Color.LightGray;
            btnEdit.BackColor = Color.LightGray;
            btnSaveUpdates.BackColor = Color.LightGray;
            btnDelete.BackColor = Color.LightGray;
        }

        private void resetGroupBoxColors()
        {
            gbProduct.BackColor = Color.WhiteSmoke;
            gbBook.BackColor = Color.WhiteSmoke;
            gbCDOrchestral.BackColor = Color.WhiteSmoke;
            gbBookCIS.BackColor = Color.WhiteSmoke;
            gbCDChamber.BackColor = Color.WhiteSmoke;
            gbCDClassical.BackColor = Color.WhiteSmoke;
            gbDVD.BackColor = Color.WhiteSmoke;
        }

        private void disableDataProcessButtons()
        {
            btnAdd.Enabled = false;
            btnFindDisplay.Enabled = false;
            btnEdit.Enabled = false;
            btnSaveUpdates.Enabled = false;
            btnDelete.Enabled = false;
        }

        //Button click to create Book
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            selected = "book";
            disableTextboxes(); //Disables all textboxs
            txtUPC.Enabled = true;  //Enable textbox
            txtPrice.Enabled = true; //Enable textbox
            txtTitle.Enabled = true; //Enable textbox
            txtQuanity.Enabled = true; //Enable textbox
            txtISBN1.Enabled = true; //Enable textbox
            txtISBN2.Enabled = true; //Enable textbox
            txtAuthor.Enabled = true; //Enable textbox
            txtPages.Enabled = true; //Enable textbox
            btnAdd.Visible = true;

            //Set Focus to UPC Textbox
            txtUPC.Focus();

            //Set Button Colors
            resetButtonColors();
            btnCreateBook.BackColor = Color.LightGreen;

            //Set Group Box Colors
            gbProduct.BackColor = Color.LightGreen;
            gbBook.BackColor = Color.LightGreen;
            gbCDOrchestral.BackColor = Color.Salmon;
            gbBookCIS.BackColor = Color.Salmon;
            gbCDChamber.BackColor = Color.Salmon;
            gbCDClassical.BackColor = Color.Salmon;
            gbDVD.BackColor = Color.Salmon;

            //Enable Add Button
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.LightGreen;

        }

        //Button click to create CIS Book
        private void btnCreateBookCIS_Click(object sender, EventArgs e)
        {
            selected = "BookCIS";
            disableTextboxes(); //Disables all textboxs
            txtUPC.Enabled = true; //Enable textbox
            txtPrice.Enabled = true; //Enable textbox
            txtTitle.Enabled = true; //Enable textbox
            txtQuanity.Enabled = true; //Enable textbox
            txtISBN1.Enabled = true; //Enable textbox
            txtISBN2.Enabled = true; //Enable textbox
            txtAuthor.Enabled = true; //Enable textbox
            txtPages.Enabled = true; //Enable textbox
            txtCISArea.Enabled = true; //Enable textbox
            btnAdd.Visible = true;

            //Set Focus to UPC Textbox
            txtUPC.Focus();

            //Set Button Colors
            resetButtonColors();
            btnCreateBookCIS.BackColor = Color.LightGreen;

            //Set Group Box Colors
            gbProduct.BackColor = Color.LightGreen;
            gbBook.BackColor = Color.LightGreen;
            gbCDOrchestral.BackColor = Color.Salmon;
            gbBookCIS.BackColor = Color.LightGreen;
            gbCDChamber.BackColor = Color.Salmon;
            gbCDClassical.BackColor = Color.Salmon;
            gbDVD.BackColor = Color.Salmon;

            //Enable Add Button
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.LightGreen;
        }

        //Button click to create DVD
        private void btnCreateDVD_Click(object sender, EventArgs e)
        {
            selected = "dvd";
            disableTextboxes(); //Disables all textboxs
            txtUPC.Enabled = true; //Enable textbox
            txtPrice.Enabled = true; //Enable textbox
            txtTitle.Enabled = true; //Enable textbox
            txtQuanity.Enabled = true; //Enable textbox
            txtLeadActor.Enabled = true; //Enable textbox
            txtReleaseDate.Enabled = true; //Enable textbox
            txtRunTime.Enabled = true; //Enable textbox
            btnAdd.Visible = true;

            //Set Focus to UPC Textbox
            txtUPC.Focus();

            //Set Button Colors
            resetButtonColors();
            btnCreateDVD.BackColor = Color.LightGreen;

            //Set Group Box Colors
            gbProduct.BackColor = Color.LightGreen;
            gbBook.BackColor = Color.Salmon;
            gbCDOrchestral.BackColor = Color.Salmon;
            gbBookCIS.BackColor = Color.Salmon;
            gbCDChamber.BackColor = Color.Salmon;
            gbCDClassical.BackColor = Color.Salmon;
            gbDVD.BackColor = Color.LightGreen;

            //Enable Add Button
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.LightGreen;
        }

        //Button click to create Orchestral CD
        private void btnCreateCDOrchestral_Click(object sender, EventArgs e)
        {
            selected = "orchestral";
            disableTextboxes(); //Disables all textboxs
            txtUPC.Enabled = true; //Enable textbox
            txtPrice.Enabled = true; //Enable textbox
            txtTitle.Enabled = true; //Enable textbox
            txtQuanity.Enabled = true; //Enable textbox
            txtCDLabel.Enabled = true; //Enable textbox
            txtCDArtists.Enabled = true; //Enable textbox
            txtConductor.Enabled = true; //Enable textbox
            btnAdd.Visible = true;

            //Set Focus to UPC Textbox
            txtUPC.Focus();

            //Set Button Colors
            resetButtonColors();
            btnCreateCDOrchestral.BackColor = Color.LightGreen;

            //Set Group Box Colors
            gbProduct.BackColor = Color.LightGreen;
            gbBook.BackColor = Color.Salmon;
            gbCDOrchestral.BackColor = Color.LightGreen;
            gbBookCIS.BackColor = Color.Salmon;
            gbCDChamber.BackColor = Color.Salmon;
            gbCDClassical.BackColor = Color.LightGreen;
            gbDVD.BackColor = Color.Salmon;

            //Enable Add Button
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.LightGreen;

        }

        //Button click to create Chamber CD
        private void btnCreateCDChamber_Click(object sender, EventArgs e)
        {
            selected = "chamber";
            disableTextboxes(); //Disables all textboxs
            txtUPC.Enabled = true; //Enable textbox
            txtPrice.Enabled = true; //Enable textbox
            txtTitle.Enabled = true; //Enable textbox
            txtQuanity.Enabled = true; //Enable textbox
            txtCDLabel.Enabled = true; //Enable textbox
            txtCDArtists.Enabled = true; //Enable textbox
            txtInstruments.Enabled = true; //Enable textbox
            btnAdd.Visible = true;

            //Set Focus to UPC Textbox
            txtUPC.Focus();

            //Set Button Colors
            resetButtonColors();
            btnCreateCDChamber.BackColor = Color.LightGreen;

            //Set Group Box Colors
            gbProduct.BackColor = Color.LightGreen;
            gbBook.BackColor = Color.Salmon;
            gbCDOrchestral.BackColor = Color.Salmon;
            gbBookCIS.BackColor = Color.Salmon;
            gbCDChamber.BackColor = Color.LightGreen;
            gbCDClassical.BackColor = Color.Salmon;
            gbDVD.BackColor = Color.Salmon;

            //Enable Add Button
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.LightGreen;
        }

        //Button click to Clear Form
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtUPC.Text = ""; //Clear textbox
            txtPrice.Text = ""; //Clear textbox
            txtTitle.Text = ""; //Clear textbox
            txtQuanity.Text = ""; //Clear textbox
            txtISBN1.Text = ""; //Clear textbox
            txtISBN2.Text = ""; //Clear textbox
            txtAuthor.Text = ""; //Clear textbox
            txtPages.Text = ""; //Clear textbox
            txtCISArea.Text = ""; //Clear textbox
            txtLeadActor.Text = ""; //Clear textbox
            txtReleaseDate.Text = ""; //Clear textbox
            txtRunTime.Text = ""; //Clear textbox
            txtCDLabel.Text = ""; //Clear textbox
            txtCDArtists.Text = ""; //Clear textbox
            txtConductor.Text = ""; //Clear textbox
            txtInstruments.Text = ""; //Clear textbox

            //Set Focus to Search UPC Button
            btnSearchUPC.Focus();

            //Reset Colors and Buttons to original state
            resetButtonColors();
            resetGroupBoxColors();
            disableDataProcessButtons();
            disableTextboxes();
        }

        //Button click to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //Close the application
        }

        //Button click to Enter/Search UPC
        private void btnSearchUPC_Click(object sender, EventArgs e)
        {
            disableTextboxes(); //disable textboxes
            txtUPC.Enabled = true; //enable textbox
            txtUPC.Focus();
            btnFindDisplay.Enabled = true; //enable find/display button

            //Set Button Colors
            resetButtonColors();

            //Set Group Box Colors
            resetGroupBoxColors();

            //Disable Buttons
            disableDataProcessButtons();

            //Enable Find Button
            btnFindDisplay.Enabled = true;
            btnFindDisplay.BackColor = Color.LightGreen;
        }
    }
}
