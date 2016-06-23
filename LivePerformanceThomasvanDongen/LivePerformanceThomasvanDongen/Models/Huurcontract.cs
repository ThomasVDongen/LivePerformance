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
        public double Bedrag { get; set; }

        public Huurcontract(DateTime startDatum, DateTime eindDatum, Huurder huurder, List<Artikel> artikelen, List<Boot> boten, double bedrag)
        {
            StartDatum = startDatum;
            EindDatum = eindDatum;
            Huurder = huurder;
            Artikelen = artikelen;
            Boten = boten;
            Bedrag = bedrag;
        }

        public Huurcontract(int id, DateTime startDatum, DateTime eindDatum, Huurder huurder, List<Artikel> artikelen, List<Boot> boten, double bedrag)
        {
            ID = id;
            StartDatum = startDatum;
            EindDatum = eindDatum;
            Huurder = huurder;
            Artikelen = artikelen;
            Boten = boten;
            Bedrag = bedrag;
        }

        public override string ToString()
        {
            int aantalBoten = Boten.Count;
            int aantaArtikelen = Artikelen.Count;
            return
                $"Contract van: {Huurder.Naam} Startdatum: {StartDatum.ToShortDateString()} Einddatum: {EindDatum.ToShortDateString()} aantal boten: {aantalBoten} aantal artikelen: {aantaArtikelen}";
        }

        public int Dagen()
        {
            return Convert.ToInt32((EindDatum - StartDatum).TotalDays);
        }

        
    }
}
