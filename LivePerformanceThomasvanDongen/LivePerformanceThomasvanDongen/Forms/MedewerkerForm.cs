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
    }
}
