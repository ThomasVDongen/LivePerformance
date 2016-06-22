namespace LivePerformanceThomasvanDongen.Forms
{
    partial class MedewerkerForm
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
            this.btnNewVerhuurder = new System.Windows.Forms.Button();
            this.btnNewContract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewVerhuurder
            // 
            this.btnNewVerhuurder.Location = new System.Drawing.Point(12, 12);
            this.btnNewVerhuurder.Name = "btnNewVerhuurder";
            this.btnNewVerhuurder.Size = new System.Drawing.Size(158, 148);
            this.btnNewVerhuurder.TabIndex = 0;
            this.btnNewVerhuurder.Text = "Nieuwe verhuurder";
            this.btnNewVerhuurder.UseVisualStyleBackColor = true;
            this.btnNewVerhuurder.Click += new System.EventHandler(this.btnNewVerhuurder_Click);
            // 
            // btnNewContract
            // 
            this.btnNewContract.Location = new System.Drawing.Point(176, 12);
            this.btnNewContract.Name = "btnNewContract";
            this.btnNewContract.Size = new System.Drawing.Size(158, 148);
            this.btnNewContract.TabIndex = 1;
            this.btnNewContract.Text = "Nieuw huurcontract";
            this.btnNewContract.UseVisualStyleBackColor = true;
            // 
            // MedewerkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.btnNewContract);
            this.Controls.Add(this.btnNewVerhuurder);
            this.Name = "MedewerkerForm";
            this.Text = "MedewerkerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewVerhuurder;
        private System.Windows.Forms.Button btnNewContract;
    }
}