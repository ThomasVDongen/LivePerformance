using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceThomasvanDongen.Models
{
    public abstract class Boot
    {
        /// <summary>
        /// properties
        /// </summary>
        public string Naam  { get; set; }
        public double Prijsperdag { get; set; }
        public bool Sluisgeld { get; set; }
        public string Merk { get; set; }
        public List<Vaargebied> Vaargebieden { get; set; } 
        /// <summary>
        /// constructor van de base klasse
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="prijsperdag"></param>
        /// <param name="sluisgeld"></param>
        protected Boot(string naam, double prijsperdag, bool sluisgeld, string merk, List<Vaargebied> vaargebieden)
        {
            Naam = naam;
            Prijsperdag = prijsperdag;
            Sluisgeld = sluisgeld;
            Merk = merk;
            Vaargebieden = vaargebieden;
        }

        public override string ToString()
        {
            return $"Naam boot: {Naam} Kosten per dag: {Prijsperdag} Sluisgeld: {(Sluisgeld ? "Ja" : "Nee")} Merk: {Merk}";
        }
        
    }
}
