using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceThomasvanDongen.Models;

namespace LivePerformanceThomasvanDongen.Data
{
    public static class Administratie
    {
        public static string Login(string login, string password)
        {
            return Database.Login(login, password);
        }

        public static bool NieuweHuurder(Huurder huurder)
        {
            return Database.NieuweHuurder(huurder);
        }
    }
}
