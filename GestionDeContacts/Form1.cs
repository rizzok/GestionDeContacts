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
    }
}
