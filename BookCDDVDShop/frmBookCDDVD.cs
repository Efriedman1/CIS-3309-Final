/* 
 * Eric Friedman
 * Andrew Larkins
 * CIS-3309
 * Final Project
 */

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

        private void clearAll()
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
            btnUpdate.BackColor = Color.LightGray;
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
            btnUpdate.Enabled = false;
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
            gbCDClassical.BackColor = Color.LightGreen;
            gbDVD.BackColor = Color.Salmon;

            //Enable Add Button
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.LightGreen;
        }

        //Button click to Clear Form
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            //clear the form
            clearAll();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selected == "book")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                     val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                     val.validateISBN(Convert.ToInt32(txtISBN1.Text), Convert.ToInt32(txtISBN2.Text)) &&
                     val.validateAuthor(txtAuthor.Text) && val.validatePages(Convert.ToInt32(txtPages.Text)))
                {
                    //Insert into database
                    productDB.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuanity.Text), "Book"); //Product
                    productDB.InsertBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(Convert.ToString(txtISBN1.Text) +
                        Convert.ToString(txtISBN2.Text)), txtAuthor.Text, Convert.ToInt32(txtPages.Text));  //Book
                    MessageBox.Show("Product has been added to the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be added to the database");//Show Message
                }
            }
            if (selected == "BookCIS")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                   val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                    val.validateISBN(Convert.ToInt32(txtISBN1.Text), Convert.ToInt32(txtISBN2.Text)) &&
                    val.validateAuthor(txtAuthor.Text) && val.validatePages(Convert.ToInt32(txtPages.Text)))
                {
                    //Insert into database
                    productDB.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuanity.Text), "BookCIS"); //Product
                    productDB.InsertBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(Convert.ToString(txtISBN1.Text) +
                         Convert.ToString(txtISBN2.Text)), txtAuthor.Text, Convert.ToInt32(txtPages.Text));  //Book
                    productDB.InsertBookCIS(Convert.ToInt32(txtUPC.Text), txtCISArea.Text); //CIS AREA
                    MessageBox.Show("Product has been added to the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be added to the database");//Show Message
                }
            }
            if (selected == "dvd")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                   val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                   val.validateActor(txtLeadActor.Text) && val.validateRuntime(Convert.ToInt32(txtRunTime.Text)))
                {
                    //Insert into database
                    productDB.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                     txtTitle.Text, Convert.ToInt32(txtQuanity.Text), "Dvd"); //Product
                    productDB.InsertDVD(Convert.ToInt32(txtUPC.Text), txtLeadActor.Text, Convert.ToDateTime(txtReleaseDate.Text),
                        Convert.ToInt32(txtRunTime.Text)); //DVD
                    MessageBox.Show("Product has been added to the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be added to the database");//Show Message
                }
            }
            if (selected == "orchestral")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                   val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                   val.validateLabel(txtCDLabel.Text) && val.validateConductor(txtConductor.Text))
                {
                    //Insert into database
                    productDB.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuanity.Text), "CDOrchestral");//Product
                    productDB.InsertCDClassical(Convert.ToInt32(txtUPC.Text), txtCDLabel.Text, txtCDArtists.Text);//CDClassical
                    productDB.InsertCDOrchestra(Convert.ToInt32(txtUPC.Text), txtConductor.Text); //CDOrchestra
                    MessageBox.Show("Product has been added to the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be added to the database");//Show Message
                }
            }
            if (selected == "chamber")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                   val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                   val.validateLabel(txtCDLabel.Text) && val.validateArtist(txtCDArtists.Text) &&
                   val.validateInstrument(txtInstruments.Text))
                {
                    //Insert into database
                    productDB.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuanity.Text), "CDChamber"); //Product
                    productDB.InsertCDClassical(Convert.ToInt32(txtUPC.Text), txtCDLabel.Text, txtCDArtists.Text);//CDClassical
                    productDB.InsertCDChamber(Convert.ToInt32(txtUPC.Text), txtInstruments.Text);//CDChamber
                    MessageBox.Show("Product has been added to the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be added to the database");//Show Message
                }
            }
        }

        private void btnFindDisplay_Click(object sender, EventArgs e)
        {
            if (txtUPC.Text != "")
            {
                bool found = false;
                String s1 = "";

                productDB.SelectProductFromProduct(Convert.ToInt32(txtUPC.Text), out found, out s1);

                string[] lines = s1.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 0; i < lines.Length - 1; i++)
                    //MessageBox.Show(i + ") " + lines[i]);
                if (found)
                {
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.BackColor = Color.LightGreen;
                        btnDelete.BackColor = Color.LightGreen;
                        btnFindDisplay.BackColor = Color.LightGray;

                        if (lines[4] == "Book") //Checks Product type
                    {
                        edit = "Book";
                        txtPrice.Text = lines[1]; //Store value in textbox
                        txtTitle.Text = lines[2]; //Store value in textbox
                        txtQuanity.Text = lines[3]; //Store value in textbox
                        txtISBN1.Text = lines[5].Substring(0, 3); //Store value in textbox
                        txtISBN2.Text = lines[5].Substring(3, 3); //Store value in textbox
                        txtAuthor.Text = lines[6]; //Store value in textbox
                        txtPages.Text = lines[7]; //Store value in textbox
                        btnEdit.Visible = true;
                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;
                    }
                    if (lines[4] == "BookCIS") //Checks Product type
                    {
                        edit = "BookCIS";
                        txtPrice.Text = lines[1]; //Store value in textbox
                        txtTitle.Text = lines[2]; //Store value in textbox
                        txtQuanity.Text = lines[3]; //Store value in textbox
                        txtISBN1.Text = lines[5].Substring(0, 3); //Store value in textbox
                        txtISBN2.Text = lines[5].Substring(3, 3); //Store value in textbox
                        txtAuthor.Text = lines[6]; //Store value in textbox
                        txtPages.Text = lines[7]; //Store value in textbox
                        txtCISArea.Text = lines[8]; //Store value in textbox
                        btnEdit.Visible = true; //Show button
                        btnUpdate.Visible = true; //Show button
                        btnDelete.Visible = true; //Show button
                    }
                    if (lines[4] == "DVD") //Checks Product type
                    {
                        edit = "DVD";
                        txtPrice.Text = lines[1]; //Store value in textbox
                        txtTitle.Text = lines[2]; //Store value in textbox
                        txtQuanity.Text = lines[3]; //Store value in textbox
                        txtLeadActor.Text = lines[5]; //Store value in textbox
                        txtReleaseDate.Text = lines[6]; //Store value in textbox
                        txtRunTime.Text = lines[7]; //Store value in textbox
                        btnEdit.Visible = true; //Show button
                        btnUpdate.Visible = true; //Show button
                        btnDelete.Visible = true; //Show button
                    }
                    if (lines[4] == "CDOrchestra")  //Checks Product type
                    {
                        edit = "CDOrchestra";
                        txtPrice.Text = lines[1]; //Store value in textbox
                        txtTitle.Text = lines[2]; //Store value in textbox
                        txtQuanity.Text = lines[3]; //Store value in textbox
                        txtCDLabel.Text = lines[5]; //Store value in textbox
                        txtCDArtists.Text = lines[6]; //Store value in textbox
                        txtConductor.Text = lines[7]; //Store value in textbox
                        btnEdit.Visible = true; //Show button
                        btnUpdate.Visible = true; //Show button
                        btnDelete.Visible = true; //Show button
                    }
                    if (lines[4] == "CDChamber") //Checks Product type
                    {
                        edit = "CDChamber";
                        txtPrice.Text = lines[1]; //Store value in textbox
                        txtTitle.Text = lines[2]; //Store value in textbox
                        txtQuanity.Text = lines[3]; //Store value in textbox
                        txtCDLabel.Text = lines[5]; //Store value in textbox
                        txtCDArtists.Text = lines[6]; //Store value in textbox
                        txtInstruments.Text = lines[7]; //Store value in textbox
                        btnEdit.Visible = true; //Show button
                        btnUpdate.Visible = true; //Show button
                        btnDelete.Visible = true; //Show button
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnFindDisplay.Enabled = false;
            btnUpdate.Enabled = true;
            if (edit == "Book")
            {
                txtUPC.Enabled = false;
                txtPrice.Enabled = true;
                txtTitle.Enabled = true;
                txtQuanity.Enabled = true;
                txtISBN1.Enabled = true;
                txtISBN2.Enabled = true;
                txtAuthor.Enabled = true;
                txtPages.Enabled = true;

            }
            if (edit == "BookCIS")
            {
                txtPrice.Enabled = true;
                txtTitle.Enabled = true;
                txtQuanity.Enabled = true;
                txtISBN1.Enabled = true;
                txtISBN2.Enabled = true;
                txtAuthor.Enabled = true;
                txtPages.Enabled = true;
                txtCISArea.Enabled = true;

            }
            if (edit == "DVD")
            {
                txtPrice.Enabled = true;
                txtTitle.Enabled = true;
                txtQuanity.Enabled = true;
                txtLeadActor.Enabled = true;
                txtReleaseDate.Enabled = true;
                txtRunTime.Enabled = true;

            }
            if (edit == "CDOrchestra")
            {
                txtPrice.Enabled = true;
                txtTitle.Enabled = true;
                txtQuanity.Enabled = true;
                txtCDLabel.Enabled = true;
                txtCDArtists.Enabled = true;
                txtConductor.Enabled = true;

            }
            if (edit == "CDChamber")
            {
                txtPrice.Enabled = true;
                txtTitle.Enabled = true;
                txtQuanity.Enabled = true;
                txtCDLabel.Enabled = true;
                txtCDArtists.Enabled = true;
                txtInstruments.Enabled = true;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (edit == "Book")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                     val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                     val.validateISBN(Convert.ToInt32(txtISBN1.Text), Convert.ToInt32(txtISBN2.Text)) &&
                     val.validateAuthor(txtAuthor.Text) && val.validatePages(Convert.ToInt32(txtPages.Text)))
                {
                    //Update in database
                    productDB.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuanity.Text)); //Product
                    productDB.UpdateBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(Convert.ToString(txtISBN1.Text) +
                        Convert.ToString(txtISBN2.Text)), txtAuthor.Text, Convert.ToInt32(txtPages.Text));  //Book
                    MessageBox.Show("Product has been updated in the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be updated");//Show Message
                }
            }
            if (edit == "BookCIS")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                   val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                    val.validateISBN(Convert.ToInt32(txtISBN1.Text), Convert.ToInt32(txtISBN2.Text)) &&
                    val.validateAuthor(txtAuthor.Text) && val.validatePages(Convert.ToInt32(txtPages.Text)))
                {
                    //Update in database
                    productDB.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuanity.Text)); //Product
                    productDB.UpdateBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(Convert.ToString(txtISBN1.Text) +
                         Convert.ToString(txtISBN2.Text)), txtAuthor.Text, Convert.ToInt32(txtPages.Text));  //Book
                    productDB.UpdateBookCIS(Convert.ToInt32(txtUPC.Text), txtCISArea.Text); //CIS AREA
                    MessageBox.Show("Product has been updated in the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be updated");//Show Message
                }
            }
            if (edit == "DVD")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                   val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                   val.validateActor(txtLeadActor.Text) && val.validateRuntime(Convert.ToInt32(txtRunTime.Text)))
                {
                    //Update in database
                    productDB.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                     txtTitle.Text, Convert.ToInt32(txtQuanity.Text)); //Product
                    productDB.UpdateDVD(Convert.ToInt32(txtUPC.Text), txtLeadActor.Text, Convert.ToDateTime(txtReleaseDate.Text),
                        Convert.ToInt32(txtRunTime.Text)); //DVD
                    MessageBox.Show("Product has been updated in the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be updated");//Show Message
                }
            }
            if (edit == "CDOrchestra")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                   val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                   val.validateLabel(txtCDLabel.Text) && val.validateConductor(txtConductor.Text))
                {
                    //IUpdate in database
                    productDB.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuanity.Text));//Product
                    productDB.UpdateCDClassical(Convert.ToInt32(txtUPC.Text), txtCDLabel.Text, txtCDArtists.Text);//CDClassical
                    productDB.UpdateCDOrchestra(Convert.ToInt32(txtUPC.Text), txtConductor.Text); //CDOrchestra
                    MessageBox.Show("Product has been updated in the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be updated");//Show Message
                }
            }
            if (edit == "CDChamber")
            {
                //Validate
                if (val.validateUPC(Convert.ToInt32(txtUPC.Text)) && val.validatePrice(Convert.ToDecimal(txtPrice.Text)) &&
                   val.validateTitle(txtTitle.Text) && val.validateQuantity(Convert.ToInt32(txtQuanity.Text)) &&
                   val.validateLabel(txtCDLabel.Text) && val.validateArtist(txtCDArtists.Text) &&
                   val.validateInstrument(txtInstruments.Text))
                {
                    //Insert into database
                    productDB.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuanity.Text)); //Product
                    productDB.UpdateCDClassical(Convert.ToInt32(txtUPC.Text), txtCDLabel.Text, txtCDArtists.Text);//CDClassical
                    productDB.UpdateCDChamber(Convert.ToInt32(txtUPC.Text), txtInstruments.Text);//CDChamber
                    MessageBox.Show("Product has been updated in the database");//Show Message
                }
                else
                {
                    MessageBox.Show("Product couldnt be updated");//Show Message
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            productDB.Delete(Convert.ToInt32(txtUPC.Text)); //Delete from database
            MessageBox.Show("Product has been deleted from the database");
            
            //clear the form
            clearAll();
            //Set Focus to Search UPC Button
            btnSearchUPC.Focus();

            //Reset Colors and Buttons to original state
            resetButtonColors();
            resetGroupBoxColors();
            disableDataProcessButtons();
            disableTextboxes();
        }
    }
}
