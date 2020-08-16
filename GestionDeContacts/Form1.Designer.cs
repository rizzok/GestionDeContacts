namespace GestionDeContacts
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textBoxAddNumber = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.lblAddNumber = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.rdBtnPro = new System.Windows.Forms.RadioButton();
            this.rdBtnPart = new System.Windows.Forms.RadioButton();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearchNumber = new System.Windows.Forms.TextBox();
            this.lblSearchNumber = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblAddImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Image = global::GestionDeContacts.Properties.Resources.vide;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(170, 200);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(236, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(54, 54);
            this.btnModify.TabIndex = 1;
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(236, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 54);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(218, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 54);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(218, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 54);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(218, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 54);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.textBoxAddNumber);
            this.groupBoxAdd.Controls.Add(this.textBoxFirstname);
            this.groupBoxAdd.Controls.Add(this.lblAddNumber);
            this.groupBoxAdd.Controls.Add(this.lblFirstname);
            this.groupBoxAdd.Controls.Add(this.lblName);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Controls.Add(this.rdBtnPro);
            this.groupBoxAdd.Controls.Add(this.rdBtnPart);
            this.groupBoxAdd.Controls.Add(this.btnAdd);
            this.groupBoxAdd.Controls.Add(this.btnCancel);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 226);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(278, 152);
            this.groupBoxAdd.TabIndex = 6;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "AJOUT CONTACT";
            // 
            // textBoxAddNumber
            // 
            this.textBoxAddNumber.Location = new System.Drawing.Point(72, 122);
            this.textBoxAddNumber.Name = "textBoxAddNumber";
            this.textBoxAddNumber.Size = new System.Drawing.Size(138, 22);
            this.textBoxAddNumber.TabIndex = 12;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(72, 91);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(138, 22);
            this.textBoxFirstname.TabIndex = 11;
            // 
            // lblAddNumber
            // 
            this.lblAddNumber.AutoSize = true;
            this.lblAddNumber.Location = new System.Drawing.Point(6, 125);
            this.lblAddNumber.Name = "lblAddNumber";
            this.lblAddNumber.Size = new System.Drawing.Size(66, 17);
            this.lblAddNumber.TabIndex = 10;
            this.lblAddNumber.Text = "Numéro :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(6, 94);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(65, 17);
            this.lblFirstname.TabIndex = 9;
            this.lblFirstname.Text = "Prénom :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nom :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(72, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // rdBtnPro
            // 
            this.rdBtnPro.AutoSize = true;
            this.rdBtnPro.ForeColor = System.Drawing.Color.ForestGreen;
            this.rdBtnPro.Location = new System.Drawing.Point(101, 27);
            this.rdBtnPro.Name = "rdBtnPro";
            this.rdBtnPro.Size = new System.Drawing.Size(115, 21);
            this.rdBtnPro.TabIndex = 6;
            this.rdBtnPro.TabStop = true;
            this.rdBtnPro.Text = "Professionnel";
            this.rdBtnPro.UseVisualStyleBackColor = true;
            this.rdBtnPro.CheckedChanged += new System.EventHandler(this.rdBtnPro_CheckedChanged);
            // 
            // rdBtnPart
            // 
            this.rdBtnPart.AutoSize = true;
            this.rdBtnPart.ForeColor = System.Drawing.Color.Blue;
            this.rdBtnPart.Location = new System.Drawing.Point(9, 27);
            this.rdBtnPart.Name = "rdBtnPart";
            this.rdBtnPart.Size = new System.Drawing.Size(92, 21);
            this.rdBtnPart.TabIndex = 5;
            this.rdBtnPart.TabStop = true;
            this.rdBtnPart.Text = "Particulier";
            this.rdBtnPart.UseVisualStyleBackColor = true;
            this.rdBtnPart.CheckedChanged += new System.EventHandler(this.rdBtnPart_CheckedChanged);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearchNumber);
            this.groupBoxSearch.Controls.Add(this.lblSearchNumber);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 393);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(278, 87);
            this.groupBoxSearch.TabIndex = 7;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "RECHERCHE";
            // 
            // textBoxSearchNumber
            // 
            this.textBoxSearchNumber.Location = new System.Drawing.Point(72, 35);
            this.textBoxSearchNumber.Name = "textBoxSearchNumber";
            this.textBoxSearchNumber.Size = new System.Drawing.Size(138, 22);
            this.textBoxSearchNumber.TabIndex = 13;
            // 
            // lblSearchNumber
            // 
            this.lblSearchNumber.AutoSize = true;
            this.lblSearchNumber.Location = new System.Drawing.Point(6, 38);
            this.lblSearchNumber.Name = "lblSearchNumber";
            this.lblSearchNumber.Size = new System.Drawing.Size(66, 17);
            this.lblSearchNumber.TabIndex = 11;
            this.lblSearchNumber.Text = "Numéro :";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(296, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(355, 468);
            this.listBox.TabIndex = 8;
            // 
            // lblAddImage
            // 
            this.lblAddImage.AutoSize = true;
            this.lblAddImage.Location = new System.Drawing.Point(35, 159);
            this.lblAddImage.Name = "lblAddImage";
            this.lblAddImage.Size = new System.Drawing.Size(122, 34);
            this.lblAddImage.TabIndex = 9;
            this.lblAddImage.Text = "Cliquez ici pour \r\najouter une image";
            this.lblAddImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddImage.Click += new System.EventHandler(this.lblAddImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 491);
            this.Controls.Add(this.lblAddImage);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RadioButton rdBtnPro;
        private System.Windows.Forms.RadioButton rdBtnPart;
        private System.Windows.Forms.TextBox textBoxAddNumber;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label lblAddNumber;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSearchNumber;
        private System.Windows.Forms.Label lblSearchNumber;
        private System.Windows.Forms.Label lblAddImage;
    }
}

