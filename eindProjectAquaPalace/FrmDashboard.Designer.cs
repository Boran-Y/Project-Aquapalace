namespace eindProjectAquaPalace
{
    partial class FrmDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxAbonementAantal = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AbboBeheer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxIncheck = new System.Windows.Forms.ListBox();
            this.btnKlantToevoegen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAbboverlopen = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 640);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 63);
            this.button1.TabIndex = 13;
            this.button1.Text = "Terug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dashboard";
            // 
            // lbxAbonementAantal
            // 
            this.lbxAbonementAantal.FormattingEnabled = true;
            this.lbxAbonementAantal.ItemHeight = 16;
            this.lbxAbonementAantal.Location = new System.Drawing.Point(88, 85);
            this.lbxAbonementAantal.Name = "lbxAbonementAantal";
            this.lbxAbonementAantal.Size = new System.Drawing.Size(253, 228);
            this.lbxAbonementAantal.TabIndex = 1;
            this.lbxAbonementAantal.SelectedIndexChanged += new System.EventHandler(this.lbxAbonementAantal_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbxAbboverlopen);
            this.panel2.Controls.Add(this.AbboBeheer);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbxIncheck);
            this.panel2.Controls.Add(this.btnKlantToevoegen);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbxAbonementAantal);
            this.panel2.Location = new System.Drawing.Point(191, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 643);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AbboBeheer
            // 
            this.AbboBeheer.Location = new System.Drawing.Point(343, 423);
            this.AbboBeheer.Name = "AbboBeheer";
            this.AbboBeheer.Size = new System.Drawing.Size(323, 63);
            this.AbboBeheer.TabIndex = 14;
            this.AbboBeheer.Text = "abonnement koppelen";
            this.AbboBeheer.UseVisualStyleBackColor = true;
            this.AbboBeheer.Click += new System.EventHandler(this.AbboBeheer_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Abonnement geschiedenis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            // 
            // lbxIncheck
            // 
            this.lbxIncheck.FormattingEnabled = true;
            this.lbxIncheck.ItemHeight = 16;
            this.lbxIncheck.Location = new System.Drawing.Point(712, 423);
            this.lbxIncheck.Name = "lbxIncheck";
            this.lbxIncheck.Size = new System.Drawing.Size(250, 180);
            this.lbxIncheck.TabIndex = 10;
            this.lbxIncheck.SelectedIndexChanged += new System.EventHandler(this.lbxIncheck_SelectedIndexChanged);
            // 
            // btnKlantToevoegen
            // 
            this.btnKlantToevoegen.Location = new System.Drawing.Point(3, 423);
            this.btnKlantToevoegen.Name = "btnKlantToevoegen";
            this.btnKlantToevoegen.Size = new System.Drawing.Size(323, 63);
            this.btnKlantToevoegen.TabIndex = 8;
            this.btnKlantToevoegen.Text = "klant toevoegen";
            this.btnKlantToevoegen.UseVisualStyleBackColor = true;
            this.btnKlantToevoegen.Click += new System.EventHandler(this.btnKlantToevoegen_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 43);
            this.panel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Acties";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 43);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aquapalace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abonnement";
            // 
            // lbxAbboverlopen
            // 
            this.lbxAbboverlopen.FormattingEnabled = true;
            this.lbxAbboverlopen.ItemHeight = 16;
            this.lbxAbboverlopen.Location = new System.Drawing.Point(570, 85);
            this.lbxAbboverlopen.Name = "lbxAbboverlopen";
            this.lbxAbboverlopen.Size = new System.Drawing.Size(253, 228);
            this.lbxAbboverlopen.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "verloopt binnenkort";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxAbonementAantal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKlantToevoegen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxIncheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AbboBeheer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxAbboverlopen;
    }
}