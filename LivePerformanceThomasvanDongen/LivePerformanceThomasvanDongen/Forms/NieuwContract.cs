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
    public partial class NieuwContract : Form
    {
        private readonly List<Boot> _geselecteerdeBoten = new List<Boot>();
        private readonly List<Artikel> _geselecteerdeArtikelen = new List<Artikel>();
        private int dagen;
        

        public NieuwContract()
        {
            InitializeComponent();
            LoadControls();
        }

        public void LoadControls()
        {
            foreach (Artikel artikel in Administratie.HaalArtikelenOp(null))
            {
                lbArtikelen.Items.Add(artikel);
            }
            foreach (Huurder huurder in Administratie.HaalHuurdersOp())
            {
                cbHuurder.Items.Add(huurder);
            }
            foreach (Boot boot in Administratie.HaalBotenOp(null))
            {
                lbBoten.Items.Add(boot);
            }
        }

        private void btnBoot_Click(object sender, EventArgs e)
        {
            if (lbBoten.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een boot");
            }
            else
            {
                _geselecteerdeBoten.Add((Boot)lbBoten.SelectedItem);
            }
        }

        private void btnArtikel_Click(object sender, EventArgs e)
        {
            if (lbArtikelen.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een artikel");
            }
            else
            {
                _geselecteerdeArtikelen.Add((Artikel)lbArtikelen.SelectedItem);
            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            if (cbHuurder.SelectedItem == null)
            {
                MessageBox.Show("Vul een huurder in");
            }
            else if (_geselecteerdeBoten.Count == 0)
            {
                MessageBox.Show("Je hebt geen boot geselecteerd");
            }
            else if (dtpStartDatum.Value > dtpEindDatum.Value)
            {
                MessageBox.Show("De start datum mag niet na de eind datum zijn");
            }
            else
            {
                if (Administratie.NieuwContract(new Huurcontract(dtpStartDatum.Value, dtpEindDatum.Value,
                        (Huurder)cbHuurder.SelectedItem, _geselecteerdeArtikelen, _geselecteerdeBoten, Totaal())))
                {
                    MessageBox.Show("Contract toegevoegd");
                    Close();
                }

            }
        }

       
        public double Totaal()
        {
            double totaal = 0;
            dagen = Convert.ToInt32((dtpEindDatum.Value - dtpStartDatum.Value).TotalDays);
            foreach (Artikel artikel in _geselecteerdeArtikelen)
            {
                totaal = totaal + artikel.Prijsperdag;
            }
            foreach (Boot boot in _geselecteerdeBoten)
            {
                totaal = totaal + boot.Prijsperdag;
            }
            return totaal*dagen;

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            lblTotaal.Text = Totaal().ToString("N2");
        }
    }
}
