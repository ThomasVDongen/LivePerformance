namespace LivePerformanceThomasvanDongen.Forms
{
    partial class Contracten
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
            this.lbContracten = new System.Windows.Forms.ListBox();
            this.btnTekst = new System.Windows.Forms.Button();
            this.btnHtml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbContracten
            // 
            this.lbContracten.FormattingEnabled = true;
            this.lbContracten.ItemHeight = 16;
            this.lbContracten.Location = new System.Drawing.Point(12, 12);
            this.lbContracten.Name = "lbContracten";
            this.lbContracten.Size = new System.Drawing.Size(903, 484);
            this.lbContracten.TabIndex = 0;
            // 
            // btnTekst
            // 
            this.btnTekst.Location = new System.Drawing.Point(13, 513);
            this.btnTekst.Name = "btnTekst";
            this.btnTekst.Size = new System.Drawing.Size(191, 37);
            this.btnTekst.TabIndex = 1;
            this.btnTekst.Text = "Exporteer naar Tekst";
            this.btnTekst.UseVisualStyleBackColor = true;
            this.btnTekst.Click += new System.EventHandler(this.btnTekst_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.Location = new System.Drawing.Point(220, 513);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(191, 37);
            this.btnHtml.TabIndex = 2;
            this.btnHtml.Text = "Exporteer naar Html";
            this.btnHtml.UseVisualStyleBackColor = true;
            this.btnHtml.Click += new System.EventHandler(this.btnHtml_Click);
            // 
            // Contracten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 594);
            this.Controls.Add(this.btnHtml);
            this.Controls.Add(this.btnTekst);
            this.Controls.Add(this.lbContracten);
            this.Name = "Contracten";
            this.Text = "Contracten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbContracten;
        private System.Windows.Forms.Button btnTekst;
        private System.Windows.Forms.Button btnHtml;
    }
}