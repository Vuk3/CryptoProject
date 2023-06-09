
namespace ZI_Projekat_18036
{
    partial class GlavnaForma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnA52 = new System.Windows.Forms.Button();
            this.btnRailFence = new System.Windows.Forms.Button();
            this.btnXTEA = new System.Windows.Forms.Button();
            this.btnOProjektu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImePrezime.Location = new System.Drawing.Point(350, 407);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(291, 41);
            this.lblImePrezime.TabIndex = 1;
            this.lblImePrezime.Text = "Vuk Cvetković 18036";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.Location = new System.Drawing.Point(160, 24);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(363, 57);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Zaštita informacija";
            this.lblNaslov.Click += new System.EventHandler(this.lblNaslov_Click);
            // 
            // btnA52
            // 
            this.btnA52.Location = new System.Drawing.Point(51, 140);
            this.btnA52.Name = "btnA52";
            this.btnA52.Size = new System.Drawing.Size(235, 75);
            this.btnA52.TabIndex = 2;
            this.btnA52.Text = "A5/2";
            this.btnA52.UseVisualStyleBackColor = true;
            this.btnA52.Click += new System.EventHandler(this.btnA5_2_Click);
            // 
            // btnRailFence
            // 
            this.btnRailFence.Location = new System.Drawing.Point(360, 140);
            this.btnRailFence.Name = "btnRailFence";
            this.btnRailFence.Size = new System.Drawing.Size(235, 75);
            this.btnRailFence.TabIndex = 3;
            this.btnRailFence.Text = "RailFence";
            this.btnRailFence.UseVisualStyleBackColor = true;
            this.btnRailFence.Click += new System.EventHandler(this.btnRailFence_Click);
            // 
            // btnXTEA
            // 
            this.btnXTEA.Location = new System.Drawing.Point(51, 281);
            this.btnXTEA.Name = "btnXTEA";
            this.btnXTEA.Size = new System.Drawing.Size(235, 75);
            this.btnXTEA.TabIndex = 4;
            this.btnXTEA.Text = "XTEA";
            this.btnXTEA.UseVisualStyleBackColor = true;
            this.btnXTEA.Click += new System.EventHandler(this.btnXTEA_Click);
            // 
            // btnOProjektu
            // 
            this.btnOProjektu.Location = new System.Drawing.Point(360, 281);
            this.btnOProjektu.Name = "btnOProjektu";
            this.btnOProjektu.Size = new System.Drawing.Size(235, 75);
            this.btnOProjektu.TabIndex = 5;
            this.btnOProjektu.Text = "O projektu";
            this.btnOProjektu.UseVisualStyleBackColor = true;
            this.btnOProjektu.Click += new System.EventHandler(this.btnPCBC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(194, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prvo pogledati \'O projektu\' !";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOProjektu);
            this.Controls.Add(this.btnXTEA);
            this.Controls.Add(this.btnRailFence);
            this.Controls.Add(this.btnA52);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GlavnaForma";
            this.Text = "Zaštita informacija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnA52;
        private System.Windows.Forms.Button btnRailFence;
        private System.Windows.Forms.Button btnXTEA;
        private System.Windows.Forms.Button btnOProjektu;
        private System.Windows.Forms.Label label1;
    }
}

