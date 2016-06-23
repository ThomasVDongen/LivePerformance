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
        public int Tank { get; set; }
       /// <summary>
       /// constructor met de base class
       /// </summary>
       /// <param name="naam"></param>
       /// <param name="prijsperdag"></param>
       /// <param name="sluisgeld"></param>
       /// <param name="merk"></param>
       /// <param name="vaargebieden"></param>
       /// <param name="tank"></param>
        public Motorboot(string naam, double prijsperdag, bool sluisgeld, string merk, List<Vaargebied> vaargebieden, int tank) : base(naam, prijsperdag, sluisgeld, merk, vaargebieden)
        {
            Tank = tank;
        }

        public override string ToString()
        {
            return base.ToString() + $" Tank inhoud: {Tank}L Actieradius:{ActieRadius()}";
        }

        public int ActieRadius()
        {
            return Tank*15;
        }
    }
}
