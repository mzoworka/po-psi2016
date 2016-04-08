namespace ProjGru2
{
    partial class Dodaj_kontakt
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
            this.Dodaj_lEmail = new System.Windows.Forms.Label();
            this.Dodaj_lNick = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Dodaj_bDodaj = new System.Windows.Forms.Button();
            this.Dodaj_bAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodaj_lEmail
            // 
            this.Dodaj_lEmail.AutoSize = true;
            this.Dodaj_lEmail.Location = new System.Drawing.Point(21, 52);
            this.Dodaj_lEmail.Name = "Dodaj_lEmail";
            this.Dodaj_lEmail.Size = new System.Drawing.Size(34, 13);
            this.Dodaj_lEmail.TabIndex = 0;
            this.Dodaj_lEmail.Text = "e-mail";
            // 
            // Dodaj_lNick
            // 
            this.Dodaj_lNick.AutoSize = true;
            this.Dodaj_lNick.Location = new System.Drawing.Point(21, 82);
            this.Dodaj_lNick.Name = "Dodaj_lNick";
            this.Dodaj_lNick.Size = new System.Drawing.Size(29, 13);
            this.Dodaj_lNick.TabIndex = 2;
            this.Dodaj_lNick.Text = "Nick";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Dodaj_bDodaj
            // 
            this.Dodaj_bDodaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Dodaj_bDodaj.FlatAppearance.BorderSize = 2;
            this.Dodaj_bDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodaj_bDodaj.Location = new System.Drawing.Point(24, 139);
            this.Dodaj_bDodaj.Name = "Dodaj_bDodaj";
            this.Dodaj_bDodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj_bDodaj.TabIndex = 7;
            this.Dodaj_bDodaj.Text = "Dodaj";
            this.Dodaj_bDodaj.UseVisualStyleBackColor = true;
            // 
            // Dodaj_bAnuluj
            // 
            this.Dodaj_bAnuluj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Dodaj_bAnuluj.FlatAppearance.BorderSize = 2;
            this.Dodaj_bAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodaj_bAnuluj.Location = new System.Drawing.Point(105, 139);
            this.Dodaj_bAnuluj.Name = "Dodaj_bAnuluj";
            this.Dodaj_bAnuluj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj_bAnuluj.TabIndex = 8;
            this.Dodaj_bAnuluj.Text = "Anuluj";
            this.Dodaj_bAnuluj.UseVisualStyleBackColor = true;
            this.Dodaj_bAnuluj.Click += new System.EventHandler(this.Dodaj_bAnuluj_Click);
            // 
            // Dodaj_kontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(220, 186);
            this.Controls.Add(this.Dodaj_bAnuluj);
            this.Controls.Add(this.Dodaj_bDodaj);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dodaj_lNick);
            this.Controls.Add(this.Dodaj_lEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dodaj_kontakt";
            this.Text = "Dodaj_kontakt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dodaj_lEmail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Dodaj_lNick;
        private System.Windows.Forms.Button Dodaj_bDodaj;
        private System.Windows.Forms.Button Dodaj_bAnuluj;
    }
}