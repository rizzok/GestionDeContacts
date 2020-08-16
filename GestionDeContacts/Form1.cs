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

/// <summary>
/// Contact management Windows program
/// Author : rizzok
/// Creation date : 13/08/2020
/// </summary>
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

        #region Initilize methods

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the window form
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize default settings
            initDefault();

            // Search entries in "lesContacts" library and updates the listBox
            updateListBox();
        }

        #endregion

        #region ListBox events

        /// <summary>
        /// Click on Delete button
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete contact from lesContact collection
            lesContacts.RemoveAt(listBox.SelectedIndex);

            // Initialize default settings
            initDefault();

            // Search entries in "lesContacts" library and updates the listBox
            updateListBox();
        }

        #endregion

        #region Add contact and pictureBox events

        /// <summary>
        /// PictureBox click
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
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

        /// <summary>
        /// PictureBox label click
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void lblAddImage_Click(object sender, EventArgs e)
        {
            picBox_Click(sender, e);
        }

        /// <summary>
        /// Radio button "Particulier" checked
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void rdBtnPart_CheckedChanged(object sender, EventArgs e)
        {
            // Show and enable the usefull items
            lblFirstname.Visible = true;
            textBoxFirstname.Visible = true;
            textBoxFirstname.Enabled = true;
            addContactItemsEnabling();

            // Show the default correcponding picture
            picBox.Image = Resources.particulier;
        }

        /// <summary>
        /// Radio button "Professionnel" checked
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void rdBtnPro_CheckedChanged(object sender, EventArgs e)
        {
            // Show and enable the usefull items
            lblFirstname.Visible = false;
            textBoxFirstname.Visible = false;
            addContactItemsEnabling();

            // Show the default correcponding picture
            picBox.Image = Resources.professionnel;
        }

        /// <summary>
        /// Click on add (+) button
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
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

                // Search entries in "lesContacts" library and updates the listBox
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

                // Search entries in "lesContacts" library and updates the listBox
                updateListBox();
            }
        }

        /// <summary>
        /// Clic on cancel (x) button
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Initialize default settings
            initDefault();

            // Search entries in "lesContacts" library and updates the listBox
            updateListBox();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Initialize default settings
        /// </summary>
        private void initDefault()
        {
            // PictureBox items
            picBox.Enabled = false;
            picBox.Image = Resources.vide;
            lblAddImage.Visible = false;

            // Add contact group box items
            rdBtnPart.Checked = false;
            rdBtnPro.Checked = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            textBoxName.Enabled = false;
            textBoxFirstname.Enabled = false;
            textBoxAddNumber.Enabled = false;
            lblFirstname.Visible = true;
            textBoxFirstname.Visible = true;
            // Empty text boxes
            textBoxName.Text = string.Empty;
            textBoxFirstname.Text = string.Empty;
            textBoxAddNumber.Text = string.Empty;

            // Search group box items
            groupBoxSearch.Enabled = true;
            listBox.Enabled = true;
        }

        /// <summary>
        /// Search entries in "lesContacts" library and updates the listBox
        /// </summary>
        private void updateListBox()
        {
            // Delete all listBox items before the update
            listBox.Items.Clear();

            // Shutdown the painting of the ListBox as items are added.
            listBox.BeginUpdate();

            // Get data from "lesContacts" collection
            foreach (Contact contact in lesContacts)
            {
                // Add item to listBox
                listBox.Items.Add(contact.infosContact());
            }

            // Allow the ListBox to repaint and display the new items
            listBox.EndUpdate();

            // If the listBox contains at least 1 item
            if (listBox.Items.Count > 0)
            {
                // Select first item of the listBox
                listBox.SetSelected(0, true);

                // Enable modify and delete buttons
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
            }
            // If the listBox contains no items
            else
            {
                // Disable modify and delete buttons
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Clic on radio button "Particulier" or "Professionnel"
        /// Enable or disable items
        /// </summary>
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

        #endregion
    }
}
