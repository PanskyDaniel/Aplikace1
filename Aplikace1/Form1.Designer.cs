﻿namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TextZpravy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MailOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MailKomu = new System.Windows.Forms.TextBox();
            this.SMTPhodnota = new System.Windows.Forms.TextBox();
            this.napisSMTP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Portnapis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "odeslat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextZpravy
            // 
            this.TextZpravy.Location = new System.Drawing.Point(131, 72);
            this.TextZpravy.Multiline = true;
            this.TextZpravy.Name = "TextZpravy";
            this.TextZpravy.Size = new System.Drawing.Size(392, 145);
            this.TextZpravy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text zprávy:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MailOd
            // 
            this.MailOd.Location = new System.Drawing.Point(131, 22);
            this.MailOd.Name = "MailOd";
            this.MailOd.Size = new System.Drawing.Size(392, 20);
            this.MailOd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odesílatel:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Komu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MailKomu
            // 
            this.MailKomu.Location = new System.Drawing.Point(131, 51);
            this.MailKomu.Name = "MailKomu";
            this.MailKomu.Size = new System.Drawing.Size(392, 20);
            this.MailKomu.TabIndex = 7;
            // 
            // SMTPhodnota
            // 
            this.SMTPhodnota.Location = new System.Drawing.Point(620, 21);
            this.SMTPhodnota.Name = "SMTPhodnota";
            this.SMTPhodnota.Size = new System.Drawing.Size(100, 20);
            this.SMTPhodnota.TabIndex = 8;
            // 
            // napisSMTP
            // 
            this.napisSMTP.AutoSize = true;
            this.napisSMTP.Location = new System.Drawing.Point(540, 24);
            this.napisSMTP.Name = "napisSMTP";
            this.napisSMTP.Size = new System.Drawing.Size(40, 13);
            this.napisSMTP.TabIndex = 9;
            this.napisSMTP.Text = "SMTP:";
            this.napisSMTP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Portnapis
            // 
            this.Portnapis.Location = new System.Drawing.Point(620, 51);
            this.Portnapis.Name = "Portnapis";
            this.Portnapis.Size = new System.Drawing.Size(100, 20);
            this.Portnapis.TabIndex = 11;
            this.Portnapis.TextChanged += new System.EventHandler(this.Portnapis_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Portnapis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.napisSMTP);
            this.Controls.Add(this.SMTPhodnota);
            this.Controls.Add(this.MailKomu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MailOd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextZpravy);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextZpravy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MailOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MailKomu;
        private System.Windows.Forms.TextBox SMTPhodnota;
        private System.Windows.Forms.Label napisSMTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Portnapis;
    }
}

