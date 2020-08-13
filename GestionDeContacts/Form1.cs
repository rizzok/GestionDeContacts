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
            // Add contact box items
            textBoxName.Enabled = false;
            lblFirstname.Visible = true;
            textBoxFirstname.Visible = true;
            textBoxFirstname.Enabled = false;
            textBoxAddNumber.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            rdBtnPart.Checked = false;
            rdBtnPro.Checked = false;
            // Search box elements
            groupBoxSearch.Enabled = true;
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
            listBox.Enabled = true;
            // Focus
            listBox.Focus();

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
                // Add contact
                // PictureBox -> add text

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

                /* TODO */
                // Add contact
                // PictureBox -> add text

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
            textBoxName.Text = "";
            textBoxAddNumber.Text = "";
            if (rdBtnPart.Checked)
            {
                textBoxFirstname.Text = "";
            }
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
            }
            // Add a "Professionnel" contact
            else if (rdBtnPro.Checked && textBoxName.Text != "" && textBoxAddNumber.Text != "")
            {
                // Create "Professionnel" object
                Professionnel professionnel = new Professionnel(textBoxName.Text, textBoxAddNumber.Text, picBox.Image);
                // Add object to Collection "lesContacts"
                lesContacts.Add(professionnel);
            }
        }
    }
}
