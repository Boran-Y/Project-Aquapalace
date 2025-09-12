namespace eindProjectAquaPalace
{
    partial class Frmklantenoverzicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxoverzicht = new System.Windows.Forms.ListBox();
            this.overzichtbtn = new System.Windows.Forms.Button();
            this.verwijderbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.stadtxt = new System.Windows.Forms.TextBox();
            this.postcodetxt = new System.Windows.Forms.TextBox();
            this.adresstxt = new System.Windows.Forms.TextBox();
            this.achternaamtxt = new System.Windows.Forms.TextBox();
            this.voornaamtxt = new System.Windows.Forms.TextBox();
            this.pasaanbtx = new System.Windows.Forms.Button();
            this.toevoegbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxoverzicht
            // 
            this.lbxoverzicht.FormattingEnabled = true;
            this.lbxoverzicht.ItemHeight = 16;
            this.lbxoverzicht.Location = new System.Drawing.Point(28, 48);
            this.lbxoverzicht.Name = "lbxoverzicht";
            this.lbxoverzicht.Size = new System.Drawing.Size(288, 292);
            this.lbxoverzicht.TabIndex = 0;
            // 
            // overzichtbtn
            // 
            this.overzichtbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.overzichtbtn.Location = new System.Drawing.Point(28, 354);
            this.overzichtbtn.Name = "overzichtbtn";
            this.overzichtbtn.Size = new System.Drawing.Size(287, 58);
            this.overzichtbtn.TabIndex = 1;
            this.overzichtbtn.Text = "Toon overzicht";
            this.overzichtbtn.UseVisualStyleBackColor = false;
            this.overzichtbtn.Click += new System.EventHandler(this.overzichtbtn_Click);
            // 
            // verwijderbtn
            // 
            this.verwijderbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.verwijderbtn.Location = new System.Drawing.Point(368, 354);
            this.verwijderbtn.Name = "verwijderbtn";
            this.verwijderbtn.Size = new System.Drawing.Size(199, 58);
            this.verwijderbtn.TabIndex = 2;
            this.verwijderbtn.Text = "verwijderen";
            this.verwijderbtn.UseVisualStyleBackColor = false;
            this.verwijderbtn.Click += new System.EventHandler(this.verwijderbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Postcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.stadtxt);
            this.groupBox1.Controls.Add(this.postcodetxt);
            this.groupBox1.Controls.Add(this.adresstxt);
            this.groupBox1.Controls.Add(this.achternaamtxt);
            this.groupBox1.Controls.Add(this.voornaamtxt);
            this.groupBox1.Controls.Add(this.pasaanbtx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(368, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 214);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aanpassen";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(159, 155);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(152, 22);
            this.emailtxt.TabIndex = 15;
            // 
            // stadtxt
            // 
            this.stadtxt.Location = new System.Drawing.Point(159, 130);
            this.stadtxt.Name = "stadtxt";
            this.stadtxt.Size = new System.Drawing.Size(152, 22);
            this.stadtxt.TabIndex = 14;
            // 
            // postcodetxt
            // 
            this.postcodetxt.Location = new System.Drawing.Point(159, 104);
            this.postcodetxt.Name = "postcodetxt";
            this.postcodetxt.Size = new System.Drawing.Size(152, 22);
            this.postcodetxt.TabIndex = 13;
            // 
            // adresstxt
            // 
            this.adresstxt.Location = new System.Drawing.Point(159, 78);
            this.adresstxt.Name = "adresstxt";
            this.adresstxt.Size = new System.Drawing.Size(152, 22);
            this.adresstxt.TabIndex = 12;
            // 
            // achternaamtxt
            // 
            this.achternaamtxt.Location = new System.Drawing.Point(159, 52);
            this.achternaamtxt.Name = "achternaamtxt";
            this.achternaamtxt.Size = new System.Drawing.Size(152, 22);
            this.achternaamtxt.TabIndex = 11;
            // 
            // voornaamtxt
            // 
            this.voornaamtxt.Location = new System.Drawing.Point(159, 26);
            this.voornaamtxt.Name = "voornaamtxt";
            this.voornaamtxt.Size = new System.Drawing.Size(152, 22);
            this.voornaamtxt.TabIndex = 10;
            // 
            // pasaanbtx
            // 
            this.pasaanbtx.BackColor = System.Drawing.Color.SteelBlue;
            this.pasaanbtx.Location = new System.Drawing.Point(172, 179);
            this.pasaanbtx.Name = "pasaanbtx";
            this.pasaanbtx.Size = new System.Drawing.Size(102, 29);
            this.pasaanbtx.TabIndex = 9;
            this.pasaanbtx.Text = "pas aan";
            this.pasaanbtx.UseVisualStyleBackColor = false;
            this.pasaanbtx.Click += new System.EventHandler(this.pasaanbtx_Click);
            // 
            // toevoegbtn
            // 
            this.toevoegbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.toevoegbtn.Location = new System.Drawing.Point(589, 354);
            this.toevoegbtn.Name = "toevoegbtn";
            this.toevoegbtn.Size = new System.Drawing.Size(199, 58);
            this.toevoegbtn.TabIndex = 10;
            this.toevoegbtn.Text = "voeg klant toe";
            this.toevoegbtn.UseVisualStyleBackColor = false;
            this.toevoegbtn.Click += new System.EventHandler(this.toevoegbtn_Click);
            // 
            // Frmklantenoverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toevoegbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.verwijderbtn);
            this.Controls.Add(this.overzichtbtn);
            this.Controls.Add(this.lbxoverzicht);
            this.Name = "Frmklantenoverzicht";
            this.Text = "Frmklantenoverzicht";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxoverzicht;
        private System.Windows.Forms.Button overzichtbtn;
        private System.Windows.Forms.Button verwijderbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox stadtxt;
        private System.Windows.Forms.TextBox postcodetxt;
        private System.Windows.Forms.TextBox adresstxt;
        private System.Windows.Forms.TextBox achternaamtxt;
        private System.Windows.Forms.TextBox voornaamtxt;
        private System.Windows.Forms.Button pasaanbtx;
        private System.Windows.Forms.Button toevoegbtn;
    }
}