using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceThomasvanDongen.Models
{
    public class SpierkrachtaangedrevenBoot :Boot
    {
        public SpierkrachtaangedrevenBoot(string naam, double prijsperdag, bool sluisgeld, string merk, List<Vaargebied> vaargebieden) : base(naam, prijsperdag, sluisgeld, merk, vaargebieden)
        {
        }
        
    }
}
