namespace LivePerformanceThomasvanDongen.Forms
{
    partial class NieuwContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBoten = new System.Windows.Forms.ListBox();
            this.lbArtikelen = new System.Windows.Forms.ListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnArtikel = new System.Windows.Forms.Button();
            this.btnBoot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHuurder = new System.Windows.Forms.ComboBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Startdatum:";
            // 
            // dtpStartDatum
            // 
            this.dtpStartDatum.Location = new System.Drawing.Point(12, 39);
            this.dtpStartDatum.Name = "dtpStartDatum";
            this.dtpStartDatum.Size = new System.Drawing.Size(232, 22);
            this.dtpStartDatum.TabIndex = 3;
            // 
            // dtpEindDatum
            // 
            this.dtpEindDatum.Location = new System.Drawing.Point(12, 88);
            this.dtpEindDatum.Name = "dtpEindDatum";
            this.dtpEindDatum.Size = new System.Drawing.Size(232, 22);
            this.dtpEindDatum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Einddatum:";
            // 
            // lbBoten
            // 
            this.lbBoten.FormattingEnabled = true;
            this.lbBoten.ItemHeight = 16;
            this.lbBoten.Location = new System.Drawing.Point(12, 143);
            this.lbBoten.Name = "lbBoten";
            this.lbBoten.Size = new System.Drawing.Size(855, 148);
            this.lbBoten.TabIndex = 6;
            // 
            // lbArtikelen
            // 
            this.lbArtikelen.FormattingEnabled = true;
            this.lbArtikelen.ItemHeight = 16;
            this.lbArtikelen.Location = new System.Drawing.Point(12, 322);
            this.lbArtikelen.Name = "lbArtikelen";
            this.lbArtikelen.Size = new System.Drawing.Size(855, 148);
            this.lbArtikelen.TabIndex = 7;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(14, 533);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(853, 43);
            this.btnVoegToe.TabIndex = 8;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // btnArtikel
            // 
            this.btnArtikel.Location = new System.Drawing.Point(889, 394);
            this.btnArtikel.Name = "btnArtikel";
            this.btnArtikel.Size = new System.Drawing.Size(129, 41);
            this.btnArtikel.TabIndex = 9;
            this.btnArtikel.Text = "Voeg Artikel toe";
            this.btnArtikel.UseVisualStyleBackColor = true;
            this.btnArtikel.Click += new System.EventHandler(this.btnArtikel_Click);
            // 
            // btnBoot
            // 
            this.btnBoot.Location = new System.Drawing.Point(889, 216);
            this.btnBoot.Name = "btnBoot";
            this.btnBoot.Size = new System.Drawing.Size(129, 41);
            this.btnBoot.TabIndex = 10;
            this.btnBoot.Text = "Voeg Boot toe";
            this.btnBoot.UseVisualStyleBackColor = true;
            this.btnBoot.Click += new System.EventHandler(this.btnBoot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selecteer de boten:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selecteer de Artikelen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selecteer de Huurder:";
            // 
            // cbHuurder
            // 
            this.cbHuurder.FormattingEnabled = true;
            this.cbHuurder.Location = new System.Drawing.Point(15, 494);
            this.cbHuurder.Name = "cbHuurder";
            this.cbHuurder.Size = new System.Drawing.Size(852, 24);
            this.cbHuurder.TabIndex = 14;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(938, 558);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(0, 17);
            this.lblTotaal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(874, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bedrag:";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(889, 515);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(129, 30);
            this.btnBereken.TabIndex = 17;
            this.btnBereken.Text = "Bereken totaal:";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // NieuwContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 596);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.cbHuurder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBoot);
            this.Controls.Add(this.btnArtikel);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lbArtikelen);
            this.Controls.Add(this.lbBoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEindDatum);
            this.Controls.Add(this.dtpStartDatum);
            this.Controls.Add(this.label1);
            this.Name = "NieuwContract";
            this.Text = "Huurcontract maken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDatum;
        private System.Windows.Forms.DateTimePicker dtpEindDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbBoten;
        private System.Windows.Forms.ListBox lbArtikelen;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnArtikel;
        private System.Windows.Forms.Button btnBoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHuurder;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBereken;
    }
}