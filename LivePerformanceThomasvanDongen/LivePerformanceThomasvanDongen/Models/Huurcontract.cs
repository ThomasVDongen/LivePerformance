using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceThomasvanDongen.Models
{
    public class Huurcontract
    {
        public int ID { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public Huurder Huurder { get; set; }
        public List<Artikel> Artikelen { get; set; } 
        public List<Boot> Boten { get; set; }

        public Huurcontract(DateTime startDatum, DateTime eindDatum, Huurder huurder, List<Artikel> artikelen, List<Boot> boten)
        {
            StartDatum = startDatum;
            EindDatum = eindDatum;
            Huurder = huurder;
            Artikelen = artikelen;
            Boten = boten;
        }
    }
}
