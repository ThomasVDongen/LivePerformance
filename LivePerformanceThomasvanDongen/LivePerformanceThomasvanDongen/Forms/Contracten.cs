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
    public partial class Contracten : Form
    {
        public Contracten()
        {
            InitializeComponent();
            lbContracten.Items.AddRange(Administratie.HaalHuurcontractenOp().ToArray());
        }

        private void btnTekst_Click(object sender, EventArgs e)
        {
            if (lbContracten.SelectedItem != null)
            {
                Administratie.FileWriter(".txt", (Huurcontract)lbContracten.SelectedItem);
            }
            else
            {
                MessageBox.Show("Je moet eerst een contract aanklikken");
            }
        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            
            if (lbContracten.SelectedItem != null)
            {
                Administratie.FileWriter(".html", (Huurcontract)lbContracten.SelectedItem);
            }
            else
            {
                MessageBox.Show("Je moet eerst een contract aanklikken");
            }
        }

        
    }
}
