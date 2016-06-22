using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceThomasvanDongen.Models
{
    public class Motorboot :Boot
    {
        /// <summary>
        /// properties
        /// </summary>
        public double Tank { get; set; }
        /// <summary>
        /// constructor met de base class
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="prijsperdag"></param>
        /// <param name="sluisgeld"></param>
        /// <param name="tank"></param>
        public Motorboot(string naam, double prijsperdag, double sluisgeld, double tank) : base(naam, prijsperdag, sluisgeld)
        {
            Tank = tank;
        }

        


    }
}
