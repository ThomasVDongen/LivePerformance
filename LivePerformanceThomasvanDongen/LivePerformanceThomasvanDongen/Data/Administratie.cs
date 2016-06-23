using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceThomasvanDongen.Models;

namespace LivePerformanceThomasvanDongen.Data
{
    public static class Administratie
    {
        private static readonly List<Huurcontract> huurcontracten = new List<Huurcontract>();
        private static readonly List<Boot> boten = new List<Boot>();
        private static readonly List<Huurder> huurders = new List<Huurder>();
        private static readonly List<Artikel> artikelen = new List<Artikel>();   
         
        
        public static string Login(string login, string password)
        {
            ClearDatabase();
            LaadDatabase();
            return Database.Login(login, password);
        }

        public static bool NieuweHuurder(Huurder huurder)
        {
            huurders.Add(huurder);
            return Database.NieuweHuurder(huurder);
        }

        public static List<Artikel> HaalArtikelenOp(int? id)
        {
            return artikelen;
        }

        public static List<Huurder> HaalHuurdersOp()
        {
            return huurders;
        }

        public static List<Boot> HaalBotenOp(int? id)
        {
            return boten;
        }

        public static bool NieuwContract(Huurcontract huurcontract)
        {
            huurcontracten.Add(huurcontract);
            return Database.NieuwContract(huurcontract);
        }

        public static List<Huurcontract> HaalHuurcontractenOp()
        {
            return huurcontracten;
        }

        public static void LaadDatabase()
        {
            huurcontracten.AddRange(Database.LaadAlleContracten());
            huurders.AddRange(Database.HaalHuurdersOp());
            boten.AddRange(Database.HaalBotenOp(null));
            artikelen.AddRange(Database.HaalArtikelenOp(null));
        }

        public static void ClearDatabase()
        {
            huurcontracten.Clear();
            boten.Clear();
            artikelen.Clear();
            huurders.Clear();
        }
        public static bool FileWriter(string ext, Huurcontract huurcontract)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Huurcontract" + ext))
                {
                    writer.Write("Naam huurder: ");
                    writer.WriteLine(huurcontract);
                }
                return true;
            }
            catch (IOException)
            {
                return false;
            }

        }

    
    }
}
