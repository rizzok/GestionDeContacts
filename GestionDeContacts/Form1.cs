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
        List<Contact> lesContacts = new List<Contact>();
 
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Program start
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            picBox.Enabled = false;
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

            /* TODO */
            // If datas before : add previous items to List (the 1st item might be selected by default)

        }

        /*
         * Radio button "Particulier" checked
         */
        private void rdBtnPart_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPart.Checked == true)
            {
                rdBtnPro.Checked = false;
                lblFirstname.Visible = true;
                textBoxFirstname.Visible = true;
                textBoxFirstname.Enabled = true;
                addContactItemsEnabling();

                /* TODO */
                // Add contact

            }
        }

        /*
         * Radio button "Professionnel" checked
         */
        private void rdBtnPro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPro.Checked == true)
            {
                rdBtnPart.Checked = false;
                lblFirstname.Visible = false;
                textBoxFirstname.Visible = false;
                addContactItemsEnabling();

                /* TODO */
                // Add contact

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
        }
    }
}
