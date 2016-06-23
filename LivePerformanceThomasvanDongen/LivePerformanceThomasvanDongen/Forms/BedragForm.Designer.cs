namespace LivePerformanceThomasvanDongen.Forms
{
    partial class BedragForm
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
            this.tbBedrag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNoordzee = new System.Windows.Forms.CheckBox();
            this.cbIJsselmeer = new System.Windows.Forms.CheckBox();
            this.lbContract = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBedrag
            // 
            this.tbBedrag.Location = new System.Drawing.Point(24, 38);
            this.tbBedrag.Name = "tbBedrag";
            this.tbBedrag.Size = new System.Drawing.Size(172, 22);
            this.tbBedrag.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bedrag:";
            // 
            // cbNoordzee
            // 
            this.cbNoordzee.AutoSize = true;
            this.cbNoordzee.Location = new System.Drawing.Point(24, 217);
            this.cbNoordzee.Name = "cbNoordzee";
            this.cbNoordzee.Size = new System.Drawing.Size(99, 21);
            this.cbNoordzee.TabIndex = 2;
            this.cbNoordzee.Text = "Noord-Zee";
            this.cbNoordzee.UseVisualStyleBackColor = true;
            // 
            // cbIJsselmeer
            // 
            this.cbIJsselmeer.AutoSize = true;
            this.cbIJsselmeer.Location = new System.Drawing.Point(24, 244);
            this.cbIJsselmeer.Name = "cbIJsselmeer";
            this.cbIJsselmeer.Size = new System.Drawing.Size(97, 21);
            this.cbIJsselmeer.TabIndex = 3;
            this.cbIJsselmeer.Text = "IJsselmeer";
            this.cbIJsselmeer.UseVisualStyleBackColor = true;
            // 
            // lbContract
            // 
            this.lbContract.FormattingEnabled = true;
            this.lbContract.ItemHeight = 16;
            this.lbContract.Location = new System.Drawing.Point(24, 67);
            this.lbContract.Name = "lbContract";
            this.lbContract.Size = new System.Drawing.Size(420, 132);
            this.lbContract.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aantal meren:";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(138, 337);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(0, 17);
            this.lblAantal.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(27, 288);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(417, 36);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // BedragForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 544);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbContract);
            this.Controls.Add(this.cbIJsselmeer);
            this.Controls.Add(this.cbNoordzee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBedrag);
            this.Name = "BedragForm";
            this.Text = "BedragForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBedrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNoordzee;
        private System.Windows.Forms.CheckBox cbIJsselmeer;
        private System.Windows.Forms.ListBox lbContract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button btnBereken;
    }
}