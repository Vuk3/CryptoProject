
namespace ZI_Projekat_18036.Forme
{
    partial class RailFence_Forma
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
            this.btnDekriptuj = new System.Windows.Forms.Button();
            this.btnEnkriptuj = new System.Windows.Forms.Button();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnKljuc = new System.Windows.Forms.Button();
            this.btnUlaz = new System.Windows.Forms.Button();
            this.numOffset = new System.Windows.Forms.NumericUpDown();
            this.lblOffset = new System.Windows.Forms.Label();
            this.lblDrugiFajl = new System.Windows.Forms.Label();
            this.lblPrviFajl = new System.Windows.Forms.Label();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.txtDrugiFajl = new System.Windows.Forms.TextBox();
            this.txtPrviFajl = new System.Windows.Forms.TextBox();
            this.numKljuc = new System.Windows.Forms.NumericUpDown();
            this.lblBrojRedova2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKljuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.Location = new System.Drawing.Point(271, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(143, 41);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "RailFence";
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(24, 49);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(42, 20);
            this.lblTekst.TabIndex = 17;
            this.lblTekst.Text = "Tekst";
            // 
            // lblKljuc
            // 
            this.lblKljuc.AutoSize = true;
            this.lblKljuc.Location = new System.Drawing.Point(139, 153);
            this.lblKljuc.Name = "lblKljuc";
            this.lblKljuc.Size = new System.Drawing.Size(41, 20);
            this.lblKljuc.TabIndex = 16;
            this.lblKljuc.Text = "Ključ";
            // 
            // btnDekriptuj
            // 
            this.btnDekriptuj.Location = new System.Drawing.Point(355, 409);
            this.btnDekriptuj.Name = "btnDekriptuj";
            this.btnDekriptuj.Size = new System.Drawing.Size(200, 59);
            this.btnDekriptuj.TabIndex = 14;
            this.btnDekriptuj.Text = "Dekriptuj";
            this.btnDekriptuj.UseVisualStyleBackColor = true;
            this.btnDekriptuj.Click += new System.EventHandler(this.btnDekriptuj_Click);
            // 
            // btnEnkriptuj
            // 
            this.btnEnkriptuj.Location = new System.Drawing.Point(106, 409);
            this.btnEnkriptuj.Name = "btnEnkriptuj";
            this.btnEnkriptuj.Size = new System.Drawing.Size(200, 59);
            this.btnEnkriptuj.TabIndex = 13;
            this.btnEnkriptuj.Text = "Enkriptuj";
            this.btnEnkriptuj.UseVisualStyleBackColor = true;
            this.btnEnkriptuj.Click += new System.EventHandler(this.btnEnkriptuj_Click);
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(24, 72);
            this.txtTekst.Multiline = true;
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTekst.Size = new System.Drawing.Size(379, 59);
            this.txtTekst.TabIndex = 12;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(444, 271);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(200, 59);
            this.btnIzlaz.TabIndex = 11;
            this.btnIzlaz.Text = "Izlazni folder";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnKljuc
            // 
            this.btnKljuc.Location = new System.Drawing.Point(444, 169);
            this.btnKljuc.Name = "btnKljuc";
            this.btnKljuc.Size = new System.Drawing.Size(200, 59);
            this.btnKljuc.TabIndex = 10;
            this.btnKljuc.Text = "Ključ";
            this.btnKljuc.UseVisualStyleBackColor = true;
            this.btnKljuc.Click += new System.EventHandler(this.btnKljuc_Click);
            // 
            // btnUlaz
            // 
            this.btnUlaz.Location = new System.Drawing.Point(444, 72);
            this.btnUlaz.Name = "btnUlaz";
            this.btnUlaz.Size = new System.Drawing.Size(200, 59);
            this.btnUlaz.TabIndex = 9;
            this.btnUlaz.Text = "Ulazni fajl";
            this.btnUlaz.UseVisualStyleBackColor = true;
            this.btnUlaz.Click += new System.EventHandler(this.btnUlaz_Click);
            // 
            // numOffset
            // 
            this.numOffset.Location = new System.Drawing.Point(271, 201);
            this.numOffset.Name = "numOffset";
            this.numOffset.Size = new System.Drawing.Size(65, 27);
            this.numOffset.TabIndex = 23;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(271, 172);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(49, 20);
            this.lblOffset.TabIndex = 24;
            this.lblOffset.Text = "Offset";
            // 
            // lblDrugiFajl
            // 
            this.lblDrugiFajl.AutoSize = true;
            this.lblDrugiFajl.Location = new System.Drawing.Point(24, 301);
            this.lblDrugiFajl.Name = "lblDrugiFajl";
            this.lblDrugiFajl.Size = new System.Drawing.Size(76, 20);
            this.lblDrugiFajl.TabIndex = 37;
            this.lblDrugiFajl.Text = "Krajnji fajl";
            // 
            // lblPrviFajl
            // 
            this.lblPrviFajl.AutoSize = true;
            this.lblPrviFajl.Location = new System.Drawing.Point(24, 248);
            this.lblPrviFajl.Name = "lblPrviFajl";
            this.lblPrviFajl.Size = new System.Drawing.Size(82, 20);
            this.lblPrviFajl.TabIndex = 36;
            this.lblPrviFajl.Text = "Pocetni fajl";
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(153, 352);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(136, 43);
            this.btnMD5.TabIndex = 35;
            this.btnMD5.Text = "Proveri MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // txtDrugiFajl
            // 
            this.txtDrugiFajl.Location = new System.Drawing.Point(24, 319);
            this.txtDrugiFajl.Name = "txtDrugiFajl";
            this.txtDrugiFajl.ReadOnly = true;
            this.txtDrugiFajl.Size = new System.Drawing.Size(379, 27);
            this.txtDrugiFajl.TabIndex = 34;
            // 
            // txtPrviFajl
            // 
            this.txtPrviFajl.Location = new System.Drawing.Point(24, 271);
            this.txtPrviFajl.Name = "txtPrviFajl";
            this.txtPrviFajl.ReadOnly = true;
            this.txtPrviFajl.Size = new System.Drawing.Size(380, 27);
            this.txtPrviFajl.TabIndex = 33;
            // 
            // numKljuc
            // 
            this.numKljuc.Location = new System.Drawing.Point(127, 201);
            this.numKljuc.Name = "numKljuc";
            this.numKljuc.Size = new System.Drawing.Size(65, 27);
            this.numKljuc.TabIndex = 38;
            // 
            // lblBrojRedova2
            // 
            this.lblBrojRedova2.AutoSize = true;
            this.lblBrojRedova2.Location = new System.Drawing.Point(116, 173);
            this.lblBrojRedova2.Name = "lblBrojRedova2";
            this.lblBrojRedova2.Size = new System.Drawing.Size(96, 20);
            this.lblBrojRedova2.TabIndex = 39;
            this.lblBrojRedova2.Text = "(broj redova)";
            // 
            // RailFence_Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 483);
            this.Controls.Add(this.lblBrojRedova2);
            this.Controls.Add(this.numKljuc);
            this.Controls.Add(this.lblDrugiFajl);
            this.Controls.Add(this.lblPrviFajl);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtDrugiFajl);
            this.Controls.Add(this.txtPrviFajl);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.numOffset);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.lblKljuc);
            this.Controls.Add(this.btnDekriptuj);
            this.Controls.Add(this.btnEnkriptuj);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnKljuc);
            this.Controls.Add(this.btnUlaz);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RailFence_Forma";
            this.Text = "RailFence_Forma";
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKljuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Label lblKljuc;
        private System.Windows.Forms.Button btnDekriptuj;
        private System.Windows.Forms.Button btnEnkriptuj;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnKljuc;
        private System.Windows.Forms.Button btnUlaz;
        private System.Windows.Forms.NumericUpDown numOffset;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.Label lblDrugiFajl;
        private System.Windows.Forms.Label lblPrviFajl;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.TextBox txtDrugiFajl;
        private System.Windows.Forms.TextBox txtPrviFajl;
        private System.Windows.Forms.NumericUpDown numKljuc;
        private System.Windows.Forms.Label lblBrojRedova2;
        public System.Windows.Forms.TextBox txtTekst;
    }
}