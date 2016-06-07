namespace ProjGru2
{
    partial class Rozmowa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rozmowa));
            this.DoWyslania = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Rozmowa_bWyslij = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Rozmowa_bZdjecie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoWyslania
            // 
            this.DoWyslania.Location = new System.Drawing.Point(12, 257);
            this.DoWyslania.Multiline = true;
            this.DoWyslania.Name = "DoWyslania";
            this.DoWyslania.Size = new System.Drawing.Size(389, 69);
            this.DoWyslania.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 44);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(389, 207);
            this.textBox2.TabIndex = 1;
            // 
            // Rozmowa_bWyslij
            // 
            this.Rozmowa_bWyslij.Location = new System.Drawing.Point(168, 332);
            this.Rozmowa_bWyslij.Name = "Rozmowa_bWyslij";
            this.Rozmowa_bWyslij.Size = new System.Drawing.Size(75, 23);
            this.Rozmowa_bWyslij.TabIndex = 2;
            this.Rozmowa_bWyslij.Text = "Wyślij";
            this.Rozmowa_bWyslij.UseVisualStyleBackColor = true;
            this.Rozmowa_bWyslij.Click += new System.EventHandler(this.Rozmowa_bWyslij_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(376, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 26);
            this.button2.TabIndex = 14;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(333, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "__";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rozmowa_bZdjecie
            // 
            this.Rozmowa_bZdjecie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rozmowa_bZdjecie.BackgroundImage")));
            this.Rozmowa_bZdjecie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rozmowa_bZdjecie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Rozmowa_bZdjecie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Rozmowa_bZdjecie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Rozmowa_bZdjecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rozmowa_bZdjecie.Location = new System.Drawing.Point(12, 330);
            this.Rozmowa_bZdjecie.Name = "Rozmowa_bZdjecie";
            this.Rozmowa_bZdjecie.Size = new System.Drawing.Size(53, 26);
            this.Rozmowa_bZdjecie.TabIndex = 16;
            this.Rozmowa_bZdjecie.UseVisualStyleBackColor = true;
            this.Rozmowa_bZdjecie.Click += new System.EventHandler(this.Rozmowa_bZdjecie_Click);
            // 
            // Rozmowa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(413, 358);
            this.Controls.Add(this.Rozmowa_bZdjecie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Rozmowa_bWyslij);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DoWyslania);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rozmowa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rozmowa";
            this.Load += new System.EventHandler(this.Rozmowa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DoWyslania;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Rozmowa_bWyslij;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Rozmowa_bZdjecie;
    }
}