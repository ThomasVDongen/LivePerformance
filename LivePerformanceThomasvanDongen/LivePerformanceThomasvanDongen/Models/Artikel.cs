using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceThomasvanDongen.Models
{
    public class Artikel
    {
        /// <summary>
        /// properties
        /// </summary>
        public string Naam { get; set; }
        public double Prijsperdag { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="prijsperdag"></param>
        public Artikel(string naam, double prijsperdag)
        {
            Naam = naam;
            Prijsperdag = prijsperdag;
        }

        public override string ToString()
        {
            return $"Naam: {Naam} Prijs per dag: {Prijsperdag}";
        }
    }
}
