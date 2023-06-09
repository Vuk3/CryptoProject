
namespace ZI_Projekat_18036.Forme
{
    partial class A52_Forma
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
            this.btnUlaz = new System.Windows.Forms.Button();
            this.btnKljuc = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.btnEnkriptuj = new System.Windows.Forms.Button();
            this.btnDekriptuj = new System.Windows.Forms.Button();
            this.txtKljuc1 = new System.Windows.Forms.TextBox();
            this.lblKljuc1 = new System.Windows.Forms.Label();
            this.lblTekst = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.txtKljuc2 = new System.Windows.Forms.TextBox();
            this.lblKljuc2 = new System.Windows.Forms.Label();
            this.btnKljuc2 = new System.Windows.Forms.Button();
            this.lblDrugiFajl = new System.Windows.Forms.Label();
            this.lblPrviFajl = new System.Windows.Forms.Label();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.txtDrugiFajl = new System.Windows.Forms.TextBox();
            this.txtPrviFajl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUlaz
            // 
            this.btnUlaz.Location = new System.Drawing.Point(442, 63);
            this.btnUlaz.Name = "btnUlaz";
            this.btnUlaz.Size = new System.Drawing.Size(200, 59);
            this.btnUlaz.TabIndex = 0;
            this.btnUlaz.Text = "Ulazni fajl";
            this.btnUlaz.UseVisualStyleBackColor = true;
            this.btnUlaz.Click += new System.EventHandler(this.btnUlaz_Click);
            // 
            // btnKljuc
            // 
            this.btnKljuc.Location = new System.Drawing.Point(442, 244);
            this.btnKljuc.Name = "btnKljuc";
            this.btnKljuc.Size = new System.Drawing.Size(90, 59);
            this.btnKljuc.TabIndex = 1;
            this.btnKljuc.Text = "Ključ 1";
            this.btnKljuc.UseVisualStyleBackColor = true;
            this.btnKljuc.Click += new System.EventHandler(this.btnKljuc_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(442, 157);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(200, 59);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlazni folder";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(22, 63);
            this.txtTekst.Multiline = true;
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTekst.Size = new System.Drawing.Size(379, 59);
            this.txtTekst.TabIndex = 3;
            // 
            // btnEnkriptuj
            // 
            this.btnEnkriptuj.Location = new System.Drawing.Point(433, 336);
            this.btnEnkriptuj.Name = "btnEnkriptuj";
            this.btnEnkriptuj.Size = new System.Drawing.Size(200, 59);
            this.btnEnkriptuj.TabIndex = 4;
            this.btnEnkriptuj.Text = "Enkriptuj";
            this.btnEnkriptuj.UseVisualStyleBackColor = true;
            this.btnEnkriptuj.Click += new System.EventHandler(this.btnEnkriptuj_Click);
            // 
            // btnDekriptuj
            // 
            this.btnDekriptuj.Location = new System.Drawing.Point(433, 409);
            this.btnDekriptuj.Name = "btnDekriptuj";
            this.btnDekriptuj.Size = new System.Drawing.Size(200, 59);
            this.btnDekriptuj.TabIndex = 5;
            this.btnDekriptuj.Text = "Dekriptuj";
            this.btnDekriptuj.UseVisualStyleBackColor = true;
            this.btnDekriptuj.Click += new System.EventHandler(this.btnDekriptuj_Click);
            // 
            // txtKljuc1
            // 
            this.txtKljuc1.Location = new System.Drawing.Point(22, 157);
            this.txtKljuc1.MaxLength = 64;
            this.txtKljuc1.Multiline = true;
            this.txtKljuc1.Name = "txtKljuc1";
            this.txtKljuc1.Size = new System.Drawing.Size(379, 59);
            this.txtKljuc1.TabIndex = 6;
            // 
            // lblKljuc1
            // 
            this.lblKljuc1.AutoSize = true;
            this.lblKljuc1.Location = new System.Drawing.Point(22, 134);
            this.lblKljuc1.Name = "lblKljuc1";
            this.lblKljuc1.Size = new System.Drawing.Size(105, 20);
            this.lblKljuc1.TabIndex = 7;
            this.lblKljuc1.Text = "Ključ 1 (64 bit)";
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(22, 40);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(42, 20);
            this.lblTekst.TabIndex = 8;
            this.lblTekst.Text = "Tekst";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.Location = new System.Drawing.Point(299, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(81, 41);
            this.lblNaslov.TabIndex = 9;
            this.lblNaslov.Text = "A5/2";
            // 
            // txtKljuc2
            // 
            this.txtKljuc2.Location = new System.Drawing.Point(22, 244);
            this.txtKljuc2.MaxLength = 22;
            this.txtKljuc2.Multiline = true;
            this.txtKljuc2.Name = "txtKljuc2";
            this.txtKljuc2.Size = new System.Drawing.Size(379, 59);
            this.txtKljuc2.TabIndex = 11;
            // 
            // lblKljuc2
            // 
            this.lblKljuc2.AutoSize = true;
            this.lblKljuc2.Location = new System.Drawing.Point(23, 221);
            this.lblKljuc2.Name = "lblKljuc2";
            this.lblKljuc2.Size = new System.Drawing.Size(105, 20);
            this.lblKljuc2.TabIndex = 12;
            this.lblKljuc2.Text = "Ključ 2 (22 bit)";
            // 
            // btnKljuc2
            // 
            this.btnKljuc2.Location = new System.Drawing.Point(552, 244);
            this.btnKljuc2.Name = "btnKljuc2";
            this.btnKljuc2.Size = new System.Drawing.Size(90, 59);
            this.btnKljuc2.TabIndex = 13;
            this.btnKljuc2.Text = "Ključ 2";
            this.btnKljuc2.UseVisualStyleBackColor = true;
            this.btnKljuc2.Click += new System.EventHandler(this.btnKljuc2_Click);
            // 
            // lblDrugiFajl
            // 
            this.lblDrugiFajl.AutoSize = true;
            this.lblDrugiFajl.Location = new System.Drawing.Point(22, 366);
            this.lblDrugiFajl.Name = "lblDrugiFajl";
            this.lblDrugiFajl.Size = new System.Drawing.Size(76, 20);
            this.lblDrugiFajl.TabIndex = 42;
            this.lblDrugiFajl.Text = "Krajnji fajl";
            // 
            // lblPrviFajl
            // 
            this.lblPrviFajl.AutoSize = true;
            this.lblPrviFajl.Location = new System.Drawing.Point(22, 313);
            this.lblPrviFajl.Name = "lblPrviFajl";
            this.lblPrviFajl.Size = new System.Drawing.Size(82, 20);
            this.lblPrviFajl.TabIndex = 41;
            this.lblPrviFajl.Text = "Pocetni fajl";
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(147, 425);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(136, 43);
            this.btnMD5.TabIndex = 40;
            this.btnMD5.Text = "Proveri MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // txtDrugiFajl
            // 
            this.txtDrugiFajl.Location = new System.Drawing.Point(22, 384);
            this.txtDrugiFajl.Name = "txtDrugiFajl";
            this.txtDrugiFajl.ReadOnly = true;
            this.txtDrugiFajl.Size = new System.Drawing.Size(379, 27);
            this.txtDrugiFajl.TabIndex = 39;
            // 
            // txtPrviFajl
            // 
            this.txtPrviFajl.Location = new System.Drawing.Point(22, 336);
            this.txtPrviFajl.Name = "txtPrviFajl";
            this.txtPrviFajl.ReadOnly = true;
            this.txtPrviFajl.Size = new System.Drawing.Size(380, 27);
            this.txtPrviFajl.TabIndex = 38;
            // 
            // A52_Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 483);
            this.Controls.Add(this.lblDrugiFajl);
            this.Controls.Add(this.lblPrviFajl);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtDrugiFajl);
            this.Controls.Add(this.txtPrviFajl);
            this.Controls.Add(this.btnKljuc2);
            this.Controls.Add(this.lblKljuc2);
            this.Controls.Add(this.txtKljuc2);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.lblKljuc1);
            this.Controls.Add(this.txtKljuc1);
            this.Controls.Add(this.btnDekriptuj);
            this.Controls.Add(this.btnEnkriptuj);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnKljuc);
            this.Controls.Add(this.btnUlaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "A52_Forma";
            this.Text = "A52_Forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUlaz;
        private System.Windows.Forms.Button btnKljuc;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.Button btnEnkriptuj;
        private System.Windows.Forms.Button btnDekriptuj;
        private System.Windows.Forms.TextBox txtKljuc1;
        private System.Windows.Forms.Label lblKljuc1;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtKljuc2;
        private System.Windows.Forms.Label lblKljuc2;
        private System.Windows.Forms.Button btnKljuc2;
        private System.Windows.Forms.Label lblDrugiFajl;
        private System.Windows.Forms.Label lblPrviFajl;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.TextBox txtDrugiFajl;
        private System.Windows.Forms.TextBox txtPrviFajl;
    }
}