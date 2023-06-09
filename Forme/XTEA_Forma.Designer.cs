
namespace ZI_Projekat_18036.Forme
{
    partial class XTEA_Forma
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblTekst = new System.Windows.Forms.Label();
            this.lblKljuc = new System.Windows.Forms.Label();
            this.txtKljuc = new System.Windows.Forms.TextBox();
            this.btnDekriptuj = new System.Windows.Forms.Button();
            this.btnEnkriptuj = new System.Windows.Forms.Button();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnKljuc = new System.Windows.Forms.Button();
            this.btnUlazTxt = new System.Windows.Forms.Button();
            this.rb32 = new System.Windows.Forms.RadioButton();
            this.rb64 = new System.Windows.Forms.RadioButton();
            this.lblBrojRundi = new System.Windows.Forms.Label();
            this.panelRunde = new System.Windows.Forms.Panel();
            this.cbPCBC = new System.Windows.Forms.CheckBox();
            this.txtPrviFajl = new System.Windows.Forms.TextBox();
            this.txtDrugiFajl = new System.Windows.Forms.TextBox();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.lblPrviFajl = new System.Windows.Forms.Label();
            this.lblDrugiFajl = new System.Windows.Forms.Label();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.lblIV = new System.Windows.Forms.Label();
            this.cbPar = new System.Windows.Forms.CheckBox();
            this.panelRunde.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.Location = new System.Drawing.Point(295, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(86, 41);
            this.lblNaslov.TabIndex = 20;
            this.lblNaslov.Text = "XTEA";
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(19, 51);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(42, 20);
            this.lblTekst.TabIndex = 19;
            this.lblTekst.Text = "Tekst";
            // 
            // lblKljuc
            // 
            this.lblKljuc.AutoSize = true;
            this.lblKljuc.Location = new System.Drawing.Point(19, 145);
            this.lblKljuc.Name = "lblKljuc";
            this.lblKljuc.Size = new System.Drawing.Size(136, 20);
            this.lblKljuc.TabIndex = 18;
            this.lblKljuc.Text = "Ključ (16 karaktera)";
            // 
            // txtKljuc
            // 
            this.txtKljuc.Location = new System.Drawing.Point(19, 168);
            this.txtKljuc.MaxLength = 16;
            this.txtKljuc.Multiline = true;
            this.txtKljuc.Name = "txtKljuc";
            this.txtKljuc.Size = new System.Drawing.Size(379, 59);
            this.txtKljuc.TabIndex = 17;
            // 
            // btnDekriptuj
            // 
            this.btnDekriptuj.Location = new System.Drawing.Point(353, 412);
            this.btnDekriptuj.Name = "btnDekriptuj";
            this.btnDekriptuj.Size = new System.Drawing.Size(200, 59);
            this.btnDekriptuj.TabIndex = 16;
            this.btnDekriptuj.Text = "Dekriptuj";
            this.btnDekriptuj.UseVisualStyleBackColor = true;
            this.btnDekriptuj.Click += new System.EventHandler(this.btnDekriptuj_Click);
            // 
            // btnEnkriptuj
            // 
            this.btnEnkriptuj.Location = new System.Drawing.Point(102, 412);
            this.btnEnkriptuj.Name = "btnEnkriptuj";
            this.btnEnkriptuj.Size = new System.Drawing.Size(200, 59);
            this.btnEnkriptuj.TabIndex = 15;
            this.btnEnkriptuj.Text = "Enkriptuj";
            this.btnEnkriptuj.UseVisualStyleBackColor = true;
            this.btnEnkriptuj.Click += new System.EventHandler(this.btnEnkriptuj_Click);
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(19, 74);
            this.txtTekst.Multiline = true;
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTekst.Size = new System.Drawing.Size(379, 59);
            this.txtTekst.TabIndex = 14;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(439, 268);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(200, 59);
            this.btnIzlaz.TabIndex = 13;
            this.btnIzlaz.Text = "Izlazni folder";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnKljuc
            // 
            this.btnKljuc.Location = new System.Drawing.Point(439, 168);
            this.btnKljuc.Name = "btnKljuc";
            this.btnKljuc.Size = new System.Drawing.Size(200, 59);
            this.btnKljuc.TabIndex = 12;
            this.btnKljuc.Text = "Ključ";
            this.btnKljuc.UseVisualStyleBackColor = true;
            this.btnKljuc.Click += new System.EventHandler(this.btnKljuc_Click);
            // 
            // btnUlazTxt
            // 
            this.btnUlazTxt.Location = new System.Drawing.Point(439, 74);
            this.btnUlazTxt.Name = "btnUlazTxt";
            this.btnUlazTxt.Size = new System.Drawing.Size(200, 59);
            this.btnUlazTxt.TabIndex = 11;
            this.btnUlazTxt.Text = "Ulazni fajl";
            this.btnUlazTxt.UseVisualStyleBackColor = true;
            this.btnUlazTxt.Click += new System.EventHandler(this.btnUlaz_Click);
            // 
            // rb32
            // 
            this.rb32.AutoSize = true;
            this.rb32.Checked = true;
            this.rb32.Location = new System.Drawing.Point(14, 29);
            this.rb32.Name = "rb32";
            this.rb32.Size = new System.Drawing.Size(46, 24);
            this.rb32.TabIndex = 22;
            this.rb32.TabStop = true;
            this.rb32.Text = "32";
            this.rb32.UseVisualStyleBackColor = true;
            // 
            // rb64
            // 
            this.rb64.AutoSize = true;
            this.rb64.Location = new System.Drawing.Point(111, 29);
            this.rb64.Name = "rb64";
            this.rb64.Size = new System.Drawing.Size(46, 24);
            this.rb64.TabIndex = 23;
            this.rb64.Text = "64";
            this.rb64.UseVisualStyleBackColor = true;
            // 
            // lblBrojRundi
            // 
            this.lblBrojRundi.AutoSize = true;
            this.lblBrojRundi.Location = new System.Drawing.Point(295, 350);
            this.lblBrojRundi.Name = "lblBrojRundi";
            this.lblBrojRundi.Size = new System.Drawing.Size(74, 20);
            this.lblBrojRundi.TabIndex = 24;
            this.lblBrojRundi.Text = "Broj rundi";
            // 
            // panelRunde
            // 
            this.panelRunde.Controls.Add(this.rb64);
            this.panelRunde.Controls.Add(this.rb32);
            this.panelRunde.Location = new System.Drawing.Point(242, 350);
            this.panelRunde.Name = "panelRunde";
            this.panelRunde.Size = new System.Drawing.Size(179, 56);
            this.panelRunde.TabIndex = 24;
            // 
            // cbPCBC
            // 
            this.cbPCBC.AutoSize = true;
            this.cbPCBC.Location = new System.Drawing.Point(452, 368);
            this.cbPCBC.Name = "cbPCBC";
            this.cbPCBC.Size = new System.Drawing.Size(66, 24);
            this.cbPCBC.TabIndex = 25;
            this.cbPCBC.Text = "PCBC";
            this.cbPCBC.UseVisualStyleBackColor = true;
            this.cbPCBC.CheckedChanged += new System.EventHandler(this.cbPCBC_CheckedChanged);
            // 
            // txtPrviFajl
            // 
            this.txtPrviFajl.Location = new System.Drawing.Point(19, 257);
            this.txtPrviFajl.Name = "txtPrviFajl";
            this.txtPrviFajl.ReadOnly = true;
            this.txtPrviFajl.Size = new System.Drawing.Size(380, 27);
            this.txtPrviFajl.TabIndex = 27;
            // 
            // txtDrugiFajl
            // 
            this.txtDrugiFajl.Location = new System.Drawing.Point(19, 305);
            this.txtDrugiFajl.Name = "txtDrugiFajl";
            this.txtDrugiFajl.ReadOnly = true;
            this.txtDrugiFajl.Size = new System.Drawing.Size(379, 27);
            this.txtDrugiFajl.TabIndex = 28;
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(42, 358);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(136, 43);
            this.btnMD5.TabIndex = 29;
            this.btnMD5.Text = "Proveri MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // lblPrviFajl
            // 
            this.lblPrviFajl.AutoSize = true;
            this.lblPrviFajl.Location = new System.Drawing.Point(19, 234);
            this.lblPrviFajl.Name = "lblPrviFajl";
            this.lblPrviFajl.Size = new System.Drawing.Size(82, 20);
            this.lblPrviFajl.TabIndex = 30;
            this.lblPrviFajl.Text = "Pocetni fajl";
            // 
            // lblDrugiFajl
            // 
            this.lblDrugiFajl.AutoSize = true;
            this.lblDrugiFajl.Location = new System.Drawing.Point(19, 287);
            this.lblDrugiFajl.Name = "lblDrugiFajl";
            this.lblDrugiFajl.Size = new System.Drawing.Size(76, 20);
            this.lblDrugiFajl.TabIndex = 31;
            this.lblDrugiFajl.Text = "Krajnji fajl";
            // 
            // txtIV
            // 
            this.txtIV.Enabled = false;
            this.txtIV.Location = new System.Drawing.Point(524, 368);
            this.txtIV.MaxLength = 8;
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(125, 27);
            this.txtIV.TabIndex = 32;
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Location = new System.Drawing.Point(530, 345);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(109, 20);
            this.lblIV.TabIndex = 33;
            this.lblIV.Text = "IV (8 karaktera)";
            // 
            // cbPar
            // 
            this.cbPar.AutoSize = true;
            this.cbPar.Location = new System.Drawing.Point(485, 26);
            this.cbPar.Name = "cbPar";
            this.cbPar.Size = new System.Drawing.Size(117, 24);
            this.cbPar.TabIndex = 34;
            this.cbPar.Text = "Paralelizacija";
            this.cbPar.UseVisualStyleBackColor = true;
            // 
            // XTEA_Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 483);
            this.Controls.Add(this.cbPar);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.lblDrugiFajl);
            this.Controls.Add(this.lblPrviFajl);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtDrugiFajl);
            this.Controls.Add(this.txtPrviFajl);
            this.Controls.Add(this.cbPCBC);
            this.Controls.Add(this.lblBrojRundi);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.lblKljuc);
            this.Controls.Add(this.txtKljuc);
            this.Controls.Add(this.btnDekriptuj);
            this.Controls.Add(this.btnEnkriptuj);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnKljuc);
            this.Controls.Add(this.btnUlazTxt);
            this.Controls.Add(this.panelRunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "XTEA_Forma";
            this.Text = "XTEA_Forma";
            this.panelRunde.ResumeLayout(false);
            this.panelRunde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Label lblKljuc;
        private System.Windows.Forms.TextBox txtKljuc;
        private System.Windows.Forms.Button btnDekriptuj;
        private System.Windows.Forms.Button btnEnkriptuj;
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnKljuc;
        private System.Windows.Forms.Button btnUlazTxt;
        private System.Windows.Forms.RadioButton rb32;
        private System.Windows.Forms.RadioButton rb64;
        private System.Windows.Forms.Label lblBrojRundi;
        private System.Windows.Forms.Panel panelRunde;
        private System.Windows.Forms.CheckBox cbPCBC;
        private System.Windows.Forms.TextBox txtPrviFajl;
        private System.Windows.Forms.TextBox txtDrugiFajl;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Label lblPrviFajl;
        private System.Windows.Forms.Label lblDrugiFajl;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.CheckBox cbPar;
    }
}