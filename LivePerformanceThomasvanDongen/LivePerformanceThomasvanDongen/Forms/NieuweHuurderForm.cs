using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformanceThomasvanDongen.Data;
using LivePerformanceThomasvanDongen.Models;

namespace LivePerformanceThomasvanDongen.Forms
{
    public partial class NieuweHuurderForm : Form
    {
        public NieuweHuurderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text != null && tbEmail.Text != null)
            {
                if (Administratie.NieuweHuurder(new Huurder(tbNaam.Text, tbEmail.Text)))
                {
                    MessageBox.Show("Huurder toegevoegd");
                    Close();
                }
                else
                {
                    MessageBox.Show("Er ging iets fout probeer het opnieuw");
                }
               
            }
            else
            {
                MessageBox.Show("Je bent iets vergeten in te vullen");
            }
        }
    }
}
