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
    /********/
    /* TODO */
    /********/
    // Control if name and firstname type are string, and number type is int
    // Format number with spaces
    // Modify fonction
    // Search fonction
    // Serialize data

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
            // Initialize default settings
            initDefault();
            // List box update
            updateListBox();
        }

        /*
         * Init default settings
         */
        private void initDefault()
        {
            // PictureBox items
            picBox.Enabled = false;
            picBox.Image = Resources.vide;
            lblAddImage.Visible = false;
            // Add contact group box items
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
            // Search group box items
            groupBoxSearch.Enabled = true;
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            listBox.Enabled = true;
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
            // Initialize default settings
            initDefault();
            // List box update
            updateListBox();
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
                    lblAddImage.Visible = false;
                }
                catch (Exception) { MessageBox.Show("Le fichier sélectionné doit être une image."); }
            }
        }

        /*
         * Click on label add image
         */
        private void lblAddImage_Click(object sender, EventArgs e)
        {
            picBox_Click(sender, e);
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
                // Initialize default settings
                initDefault();
                // List box update
                updateListBox();
            }
            // Add a "Professionnel" contact
            else if (rdBtnPro.Checked && textBoxName.Text != "" && textBoxAddNumber.Text != "")
            {
                // Create "Professionnel" object
                Professionnel professionnel = new Professionnel(textBoxName.Text, textBoxAddNumber.Text, picBox.Image);
                // Add object to Collection "lesContacts"
                lesContacts.Add(professionnel);
                // Initialize default settings
                initDefault();
                // List box update
                updateListBox();
            }
        }

        /*
         * Update listBox
         */
        private void updateListBox()
        {
            listBox.Items.Clear();
            // Shutdown the painting of the ListBox as items are added.
            listBox.BeginUpdate();
            // Get data from "lesContacts" collection
            foreach (Contact contact in lesContacts)
            {
                // Add to listBox
                listBox.Items.Add(contact.infosContact());
            }
            // Allow the ListBox to repaint and display the new items.
            listBox.EndUpdate();

            if (listBox.Items.Count > 0)
            {
                // Select first item of the listBox
                listBox.SetSelected(0, true);
                // Enable modify and delete buttons
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                // Disable modify and delete buttons
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        /*
         * Click on Delete button
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete contact from lesContact collection
            lesContacts.RemoveAt(listBox.SelectedIndex);
            // Initialize default settings
            initDefault();
            // List box update
            updateListBox();
        }
    }
}
