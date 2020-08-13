using GestionDeContacts.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeContacts
{
    public partial class Form1 : Form
    {
        // Collection Liste de contacts
        private List<Contact> lesContacts = new List<Contact>();
 
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Program start
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            initDefault();
        }

        /*
         * Init default settings
         */
        private void initDefault()
        {
            // PictureBox
            picBox.Enabled = false;
            picBox.Image = Resources.vide;
            lblAddImage.Visible = false;
            // Add contact box items
            textBoxName.Enabled = false;
            lblFirstname.Visible = true;
            textBoxFirstname.Visible = true;
            textBoxFirstname.Enabled = false;
            textBoxAddNumber.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            textBoxName.Text = "";
            textBoxFirstname.Text = "";
            textBoxAddNumber.Text = "";
            rdBtnPart.Checked = false;
            rdBtnPro.Checked = false;
            // Search box items
            groupBoxSearch.Enabled = true;
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            listBox.Enabled = true;

            /* TODO */
            // PictureBox -> hide text (after adding contact)
            // If datas before : add previous items to List (the 1st item might be selected by default)

        }

        /*
         * Radio button "Particulier" checked
         */
        private void rdBtnPart_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPart.Checked)
            {
                rdBtnPro.Checked = false;
                lblFirstname.Visible = true;
                textBoxFirstname.Visible = true;
                textBoxFirstname.Enabled = true;
                picBox.Image = Resources.particulier;
                addContactItemsEnabling();


                /* TODO */
                // Group same things between rdBtnPart and rdBtnPro in method addContactItemsEnabling() below

            }
        }

        /*
         * Radio button "Professionnel" checked
         */
        private void rdBtnPro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPro.Checked)
            {
                rdBtnPart.Checked = false;
                lblFirstname.Visible = false;
                textBoxFirstname.Visible = false;
                picBox.Image = Resources.professionnel;
                addContactItemsEnabling();
            }
        }

        /*
         * Clic on radio button "Particulier" or "Professionnel"
         * Enable or disable items
         */
        private void addContactItemsEnabling()
        {
            // "AJOUT CONTACT" items enabled
            picBox.Enabled = true;
            textBoxName.Enabled = true;
            textBoxAddNumber.Enabled = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            // Show label Add image
            lblAddImage.Visible = true;
            // Others items disabled
            groupBoxSearch.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            listBox.Enabled = false;
            // Focus on text box Name
            textBoxName.Focus();
        }

        /*
         * Clic on Cancel button
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            initDefault();
        }

        /*
         * Click on pictureBox
         */
        private void picBox_Click(object sender, EventArgs e)
        {
            // Select file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            // If a file is selected
            if (dialogResult == DialogResult.OK)
            {
                // Get file path
                string fileName = openFileDialog.FileName;
                // show image in pictureBox if the selected file is an image
                try
                {
                    picBox.Image = Image.FromFile(fileName);
                }
                catch (Exception) { MessageBox.Show("Le fichier sélectionné doit être une image."); }
            }
        }

        /*
         * Click on add (+) button
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add a "Particulier" contact
            if (rdBtnPart.Checked && textBoxName.Text != "" && textBoxFirstname.Text != "" && textBoxAddNumber.Text != "")
            {
                // Create "Particulier" object
                Particulier particulier = new Particulier(textBoxName.Text, textBoxFirstname.Text, textBoxAddNumber.Text, picBox.Image);
                // Add object to Collection "lesContacts"
                lesContacts.Add(particulier);
                updateListBox();
            }
            // Add a "Professionnel" contact
            else if (rdBtnPro.Checked && textBoxName.Text != "" && textBoxAddNumber.Text != "")
            {
                // Create "Professionnel" object
                Professionnel professionnel = new Professionnel(textBoxName.Text, textBoxAddNumber.Text, picBox.Image);
                // Add object to Collection "lesContacts"
                lesContacts.Add(professionnel);
                updateListBox();
            }
        }

        /*
         * Update listBox
         */
        private void updateListBox()
        {
            initDefault();
            listBox.Items.Clear();
            // Shutdown the painting of the ListBox as items are added.
            listBox.BeginUpdate();
            // Get data from "lesContacts" collection
            foreach (Contact contact in lesContacts)
            {
                // Show the contact in listBox
                listBox.Items.Add(contact.getNom() + " (" + contact.getTel() + ")");
            }
            // Allow the ListBox to repaint and display the new items.
            listBox.EndUpdate();
            // Select first item of the listBox
            listBox.SetSelected(0, true);
        }
    }
}
