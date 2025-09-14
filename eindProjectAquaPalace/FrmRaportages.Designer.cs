namespace eindProjectAquaPalace
{
    partial class FrmRaportages
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxActief = new System.Windows.Forms.ListBox();
            this.lbxverloopt = new System.Windows.Forms.ListBox();
            this.lbxInchecks = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTerug = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(2, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 533);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raportages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1114, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aquapalace";
            // 
            // lbxActief
            // 
            this.lbxActief.FormattingEnabled = true;
            this.lbxActief.ItemHeight = 16;
            this.lbxActief.Location = new System.Drawing.Point(176, 117);
            this.lbxActief.Name = "lbxActief";
            this.lbxActief.Size = new System.Drawing.Size(246, 132);
            this.lbxActief.TabIndex = 2;
            // 
            // lbxverloopt
            // 
            this.lbxverloopt.FormattingEnabled = true;
            this.lbxverloopt.ItemHeight = 16;
            this.lbxverloopt.Location = new System.Drawing.Point(518, 117);
            this.lbxverloopt.Name = "lbxverloopt";
            this.lbxverloopt.Size = new System.Drawing.Size(246, 132);
            this.lbxverloopt.TabIndex = 3;
            // 
            // lbxInchecks
            // 
            this.lbxInchecks.FormattingEnabled = true;
            this.lbxInchecks.ItemHeight = 16;
            this.lbxInchecks.Location = new System.Drawing.Point(908, 117);
            this.lbxInchecks.Name = "lbxInchecks";
            this.lbxInchecks.Size = new System.Drawing.Size(246, 132);
            this.lbxInchecks.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(967, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(1148, 507);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(73, 86);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // FrmRaportages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 605);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbxInchecks);
            this.Controls.Add(this.lbxverloopt);
            this.Controls.Add(this.lbxActief);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRaportages";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmRaportages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbxActief;
        private System.Windows.Forms.ListBox lbxverloopt;
        private System.Windows.Forms.ListBox lbxInchecks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTerug;
    }
}