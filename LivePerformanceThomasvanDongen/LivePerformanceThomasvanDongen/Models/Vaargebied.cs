using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceThomasvanDongen.Models
{
    public class Vaargebied
    {
        /// <summary>
        /// properties
        /// </summary>
        public string Naam { get; set; }
        public double Prijsperdag { get; set; }
        /// <summary>
        /// constructor van vaargebied
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="prijsperdag"></param>
        public Vaargebied(string naam, double prijsperdag)
        {
            Naam = naam;
            Prijsperdag = prijsperdag;
        }

    }
}
