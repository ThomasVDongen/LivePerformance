using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformanceThomasvanDongen.Forms
{
    public partial class MedewerkerForm : Form
    {
        public MedewerkerForm()
        {
            InitializeComponent();
        }

        private void btnNewVerhuurder_Click(object sender, EventArgs e)
        {
            NieuweHuurderForm nhForm = new NieuweHuurderForm();
            nhForm.Closed += (s, args) => Show();
            nhForm.Show();
        }

        private void btnNewContract_Click(object sender, EventArgs e)
        {
            NieuwContract ncForm = new NieuwContract();
            ncForm.Closed += (s, args) => Show();
            ncForm.Show();
        }

        private void btnContracten_Click(object sender, EventArgs e)
        {
            Contracten contracten = new Contracten();
            contracten.Closed += (s, args) => Show();
            contracten.Show();
        }

        private void btnBedrag_Click(object sender, EventArgs e)
        {
            BedragForm bedrag = new BedragForm();
            bedrag.Closed += (s, args) => Show();
            bedrag.Show();
        }
    }
}
