namespace ProjGru2
{
    partial class Lista
    {

        Dodaj_kontakt dodaj_kontakt_lista = new ProjGru2.Dodaj_kontakt();
        Kom kom = new Kom();
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("trolololo");
            this.button2 = new System.Windows.Forms.Button();
            this.Dodaj_kontakt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kto = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(189, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dodaj_kontakt
            // 
            this.Dodaj_kontakt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Dodaj_kontakt.FlatAppearance.BorderSize = 2;
            this.Dodaj_kontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodaj_kontakt.Location = new System.Drawing.Point(12, 37);
            this.Dodaj_kontakt.Name = "Dodaj_kontakt";
            this.Dodaj_kontakt.Size = new System.Drawing.Size(92, 25);
            this.Dodaj_kontakt.TabIndex = 14;
            this.Dodaj_kontakt.Text = "Dodaj kontakt";
            this.Dodaj_kontakt.UseVisualStyleBackColor = true;
            this.Dodaj_kontakt.Click += new System.EventHandler(this.Dodaj_kontakt_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(146, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "__";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // kto
            // 
            this.kto.AutoSize = true;
            this.kto.Location = new System.Drawing.Point(13, 9);
            this.kto.Name = "kto";
            this.kto.Size = new System.Drawing.Size(0, 13);
            this.kto.TabIndex = 17;
            // 
            // listView
            // 
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView.Location = new System.Drawing.Point(12, 68);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(203, 356);
            this.listView.TabIndex = 18;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(227, 436);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.kto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dodaj_kontakt);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Dodaj_kontakt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kto;
        private System.Windows.Forms.ListView listView;
    }
}