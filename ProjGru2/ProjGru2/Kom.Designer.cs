﻿namespace ProjGru2
{
    partial class frmLogowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOdbieranie = new System.Windows.Forms.RichTextBox();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bZal = new System.Windows.Forms.Button();
            this.bRej = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOdbieranie
            // 
            this.txtOdbieranie.BackColor = System.Drawing.Color.Azure;
            this.txtOdbieranie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOdbieranie.Location = new System.Drawing.Point(24, 32);
            this.txtOdbieranie.Name = "txtOdbieranie";
            this.txtOdbieranie.Size = new System.Drawing.Size(353, 31);
            this.txtOdbieranie.TabIndex = 0;
            this.txtOdbieranie.Text = "";
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.Azure;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt.Location = new System.Drawing.Point(24, 99);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(353, 31);
            this.txt.TabIndex = 1;
            this.txt.Text = "";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Azure;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLog.ForeColor = System.Drawing.Color.Red;
            this.txtLog.Location = new System.Drawing.Point(24, 254);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(353, 34);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Haslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login:";
            // 
            // bZal
            // 
            this.bZal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bZal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bZal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bZal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZal.Location = new System.Drawing.Point(43, 153);
            this.bZal.Name = "bZal";
            this.bZal.Size = new System.Drawing.Size(109, 36);
            this.bZal.TabIndex = 8;
            this.bZal.Text = "Zaloguj się";
            this.bZal.UseVisualStyleBackColor = true;
            this.bZal.Click += new System.EventHandler(this.button1_Click);
            // 
            // bRej
            // 
            this.bRej.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bRej.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bRej.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bRej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRej.Location = new System.Drawing.Point(234, 153);
            this.bRej.Name = "bRej";
            this.bRej.Size = new System.Drawing.Size(109, 36);
            this.bRej.TabIndex = 9;
            this.bRej.Text = "Zarejestruj się";
            this.bRej.UseVisualStyleBackColor = true;
            this.bRej.Click += new System.EventHandler(this.bRej_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(330, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "__";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(373, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLogowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(419, 305);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bRej);
            this.Controls.Add(this.bZal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtOdbieranie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLogowanie";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOdbieranie;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bZal;
        private System.Windows.Forms.Button bRej;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

