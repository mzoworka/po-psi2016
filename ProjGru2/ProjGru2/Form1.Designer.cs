namespace ProjGru2
{
    partial class frmSerwer
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
            this.txtWysylanie = new System.Windows.Forms.RichTextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOdbieranie
            // 
            this.txtOdbieranie.Location = new System.Drawing.Point(24, 32);
            this.txtOdbieranie.Name = "txtOdbieranie";
            this.txtOdbieranie.ReadOnly = true;
            this.txtOdbieranie.Size = new System.Drawing.Size(353, 194);
            this.txtOdbieranie.TabIndex = 0;
            this.txtOdbieranie.Text = "";
            // 
            // txtWysylanie
            // 
            this.txtWysylanie.Location = new System.Drawing.Point(24, 261);
            this.txtWysylanie.Name = "txtWysylanie";
            this.txtWysylanie.Size = new System.Drawing.Size(353, 99);
            this.txtWysylanie.TabIndex = 1;
            this.txtWysylanie.Text = "";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(24, 397);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(353, 34);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wysyłane:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Odebrane:";
            // 
            // frmSerwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(419, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtWysylanie);
            this.Controls.Add(this.txtOdbieranie);
            this.MaximizeBox = false;
            this.Name = "frmSerwer";
            this.Text = "Serwer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOdbieranie;
        private System.Windows.Forms.RichTextBox txtWysylanie;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

