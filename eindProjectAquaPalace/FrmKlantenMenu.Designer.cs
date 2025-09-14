namespace eindProjectAquaPalace
{
    partial class FrmKlantenMenu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTerug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.btnAbbo = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnTerug);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(245, -35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 490);
            this.panel2.TabIndex = 7;
            // 
            // btnTerug
            // 
            this.btnTerug.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(585, 66);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(82, 388);
            this.btnTerug.TabIndex = 1;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = false;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom bij het Hoofdmenu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnKlanten);
            this.panel1.Controls.Add(this.btnAbbo);
            this.panel1.Location = new System.Drawing.Point(-57, -35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 521);
            this.panel1.TabIndex = 6;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(69, 85);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(218, 46);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnKlanten
            // 
            this.btnKlanten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKlanten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlanten.Location = new System.Drawing.Point(69, 181);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(218, 46);
            this.btnKlanten.TabIndex = 1;
            this.btnKlanten.Text = "klanten";
            this.btnKlanten.UseVisualStyleBackColor = false;
            this.btnKlanten.Click += new System.EventHandler(this.btnKlanten_Click);
            // 
            // btnAbbo
            // 
            this.btnAbbo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbo.Location = new System.Drawing.Point(69, 276);
            this.btnAbbo.Name = "btnAbbo";
            this.btnAbbo.Size = new System.Drawing.Size(218, 46);
            this.btnAbbo.TabIndex = 2;
            this.btnAbbo.Text = "abonnementen";
            this.btnAbbo.UseVisualStyleBackColor = false;
            this.btnAbbo.Click += new System.EventHandler(this.btnAbbo_Click);
            // 
            // FrmKlantenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKlantenMenu";
            this.Text = "FrmKlantenMenu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Button btnAbbo;
    }
}