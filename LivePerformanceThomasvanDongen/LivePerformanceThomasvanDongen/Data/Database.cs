using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceThomasvanDongen.Models;
using Oracle.ManagedDataAccess.Client;

namespace LivePerformanceThomasvanDongen.Data
{
    public static class Database
    {
        private const string USER = "dbi323229";
        /// <summary>
        /// The password used to connect with the database.
        /// </summary>
        private const string PASSWORD = "wXkDxOdQUV";
        /// <summary>
        /// The oracle-specific string used to connect with the database.
        /// </summary>
        private const string CONNECTION_STRING = "User Id= " + USER + ";Password= " + PASSWORD + ";Data Source=" + @" //192.168.15.50:1521/fhictora" + ";";
        /// <summary>
        /// connection aangemaakt zodat deze gebruikt kan worden.
        /// </summary>
        private static readonly OracleConnection Conn;
        static Database()
        {
            try
            {
                Conn = new OracleConnection(CONNECTION_STRING);
            }
            catch (OracleException oEx)
            {
                throw oEx;
            }
        }
        public static bool OpenConnection()
        {
            Console.WriteLine(Conn.State == System.Data.ConnectionState.Open
                ? "Database Connection was already open"
                : "Opening Database Connection..");
            try
            {
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                return true;
            }
            catch (OracleException oEx)
            {
                throw oEx;
            }
        }
        /// <summary>
        /// Closes the connection with the database.
        /// </summary>
        /// <returns>A bool wether the connection was successfully closed</returns>
        public static bool CloseConnection()
        {
            Console.WriteLine(Conn.State == System.Data.ConnectionState.Closed
                ? "Database Connection was already closed"
                : "Closing Database Connection..");
            try
            {
                Conn.Close();
                return true;
            }
            catch (OracleException oEx)
            {
                return false;
            }
        }
        /// <summary>
        /// data lezen
        /// </summary>
        /// <param name="sqlC"></param>
        /// <returns></returns>
        private static OracleDataReader ReadData(OracleCommand sqlC)
        {
            if (!OpenConnection())
                return null;
            try
            {
                sqlC.Connection = Conn;
                return sqlC.ExecuteReader();
            }
            catch (OracleException oEx)
            {
                CloseConnection();
                return null;
            }
            catch (NullReferenceException exception)
            {
                return null;
            }
        }

        public static string Login(string login, string password)
        {
            string functie = "Geen medewerker gevonden";
            OracleCommand cmd =
                new OracleCommand("SELECT * FROM MEDEWERKER WHERE NAAM = :naam AND wachtwoord = :wachtwoord");
            cmd.Parameters
                .Add("naam", OracleDbType.Varchar2).Value = login;

            cmd.Parameters
                .Add("wachtwoord", OracleDbType.Varchar2).Value = password;

            try
            {
                OracleDataReader oraReader = ReadData(cmd);

                if (oraReader == null)
                    return functie;
                while (oraReader.Read())
                {
                    functie = Convert.ToString(oraReader["FUNCTIE"]);
                }


            }
            catch (InvalidOperationException ex)
            {
                CloseConnection();
                functie = "Er was een error";
                return functie;
            }
            CloseConnection();
            return functie;

        }

        public static bool NieuweHuurder(Huurder huurder)
        {
            string query = "INSERT INTO HUURDER(NAAM, EMAIL) VALUES(:naam, :email)";

            OracleCommand insert = new OracleCommand(query, Conn);
            insert.Parameters.Add(new OracleParameter("naam", huurder.Naam));
            insert.Parameters.Add(new OracleParameter("email", huurder.Email));
            OracleCommand commit = new OracleCommand("commit", Conn);


            try
            {
                if (!OpenConnection())
                    return false;
                insert.ExecuteNonQuery();
                commit.ExecuteNonQuery();
            }
            catch (OracleException)
            {
                return false;
            }
            catch (InvalidOperationException o)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return true;
        }

        public static List<Artikel> HaalArtikelenOp(int? id)
        {
            string query;
            if (id == null)
            {
                query = "Select * from Artikel";
            }
            else
            {
                query = "Select * from Artikel A " +
                        "Join Huurcontract_Artikel H on H.Artikel_Naam = A.Naam " +
                        "Where H.HUURCONTRACT_ID = " + id;
            }


            OracleCommand cmd = new OracleCommand(query);
            List<Artikel> artikelen = new List<Artikel>();

            try
            {
                OracleDataReader reader = ReadData(cmd);

                if (reader == null)
                    return artikelen;
                while (reader.Read())
                {
                    Artikel artikel = new Artikel
                        (
                        Convert.ToString(reader["NAAM"]),
                        Convert.ToDouble(reader["Prijsperdag"])
                        );
                    artikelen.Add(artikel);
                }
                return artikelen;
            }
            catch (OracleException)
            {
                CloseConnection();
                return artikelen;
            }

        }

        public static List<Huurder> HaalHuurdersOp()
        {
            string query = "Select * from Huurder";
            OracleCommand cmd = new OracleCommand(query);
            List<Huurder> huurders = new List<Huurder>();

            try
            {
                OracleDataReader reader = ReadData(cmd);

                if (reader == null)
                    return huurders;
                while (reader.Read())
                {
                    Huurder huurder = new Huurder
                        (
                        Convert.ToInt32(reader["ID"]),
                        Convert.ToString(reader["Naam"]),
                        Convert.ToString(reader["Email"])
                        );
                    huurders.Add(huurder);
                }
                return huurders;
            }
            catch (OracleException)
            {
                CloseConnection();
                return huurders;
            }
        }

        public static List<Boot> HaalBotenOp(int? id)
        {
            string query;
            if (id == null)
            {
                query = "Select * from Boot";
            }
            else
            {
                query = "Select * from Boot B Join Huurcontract_Boot HB on B.Naam = HB.Boot_Naam Where HB.Huurcontract_ID = " + id;
            }
            OracleCommand cmd = new OracleCommand(query);
            List<Boot> boten = new List<Boot>();
            try
            {
                OracleDataReader reader = ReadData(cmd);

                if (reader == null)
                    return boten;
                while (reader.Read())
                {
                    string naam = Convert.ToString(reader["NAAM"]);
                    bool sluisgeld = IntToBool(Convert.ToInt32(reader["SLUISGELD"]));
                    int tank = Convert.ToInt32(reader["TANK"]);
                    string merk = Convert.ToString(reader["MERK"]);
                    string type = Convert.ToString(reader["BOOT_TYPE"]);
                    List<Vaargebied> vaargebieden = HaalVaargebiedenOp(type);
                    if (type == "Motorboot")
                    {
                        boten.Add(new Motorboot(naam, HaalPrijsperdagOp(type), sluisgeld, merk, vaargebieden, tank));
                    }
                    if (type == "Spierkrachtaangedreven")
                    {
                        boten.Add(new SpierkrachtaangedrevenBoot(naam, HaalPrijsperdagOp(type), sluisgeld, merk, vaargebieden));
                    }

                }
                return boten;
            }
            catch (OracleException)
            {
                CloseConnection();
                return boten;
            }

        }

        public static List<Vaargebied> HaalVaargebiedenOp(string type)
        {
            string query = "SELECT * FROM VAARGEBIED V JOIN VAARGEBIED_TYPE VT ON V.NAAM = VT.VAARGEBIED_NAAM WHERE VT.TYPE_NAAM = :type";
            OracleCommand cmd = new OracleCommand(query);
            cmd.Parameters.Add("type", type);
            List<Vaargebied> vaargebieden = new List<Vaargebied>();
            try
            {
                OracleDataReader reader = ReadData(cmd);

                if (reader == null)
                    return vaargebieden;

                while (reader.Read())
                {
                    Vaargebied vaargebied = new Vaargebied
                        (
                        Convert.ToString(reader["NAAM"]),
                        Convert.ToDouble(reader["prijsperdag"])
                        );
                    vaargebieden.Add(vaargebied);
                }
            }
            catch (OracleException)
            {
                return vaargebieden;
            }
            return vaargebieden;
        }

        public static double HaalPrijsperdagOp(string type)
        {
            string query = "Select prijsperdag from Type where NAAM = :type";
            OracleCommand cmd = new OracleCommand(query);
            cmd.Parameters.Add("type", type);
            double prijsperdag = 0;

            try
            {
                OracleDataReader reader = ReadData(cmd);
                if (reader == null)
                    return prijsperdag;
                while (reader.Read())
                {
                    prijsperdag = Convert.ToDouble(reader["prijsperdag"]);
                }
                return prijsperdag;

            }
            catch (OracleException)
            {
                return prijsperdag;
            }

        }

        public static bool NieuwContract(Huurcontract contract)
        {
            #region queries
            //aanmaken van alle queries die ik nodig heb.
            int huurcontractId = 0;
            string querycontract = "INSERT INTO HUURCONTRACT(STARTDATUM, EINDDATUM, BEDRAG)VALUES(:startdatum, :einddatum, :bedrag)";
            string getnewID = "SELECT ID FROM HUURCONTRACT WHERE bedrag = :bedrag";
            string queryhuurder =
                "INSERT INTO HUURCONTRACT_HUURDER(HUURCONTRACT_ID, HUURDER_ID)VALUES(:huurcontractid,:huurderid)";
            string queryBoot =
                "INSERT INTO HUURCONTRACT_BOOT(HUURCONTRACT_ID, BOOT_NAAM)VALUES(:huurcontractid, :bootnaam)";
            string queryArtikel = "INSERT INTO HUURCONTRACT_ARTIKEL(HUURCONTRACT_ID, ARTIKEL_NAAM)VALUES(:huurcontractid, :artikelnaam)";
            #endregion
            //aanmaken van alle commands die ik nodig heb
            #region commands en paramaters 1
            OracleCommand contractcmd = new OracleCommand(querycontract, Conn);
            contractcmd.Parameters.Add("startdatum", contract.StartDatum);
            contractcmd.Parameters.Add("einddatum", contract.EindDatum);
            contractcmd.Parameters.Add("bedrag", contract.Bedrag);
            OracleCommand commit = new OracleCommand("commit", Conn);
            OracleCommand getCommand = new OracleCommand(getnewID);
            getCommand.Parameters.Add("bedrag", contract.Bedrag);
            #endregion

            try
            {
                if (!OpenConnection())
                {
                    return false;
                }
                contractcmd.ExecuteNonQuery();
                commit.ExecuteNonQuery();
                OracleDataReader reader = ReadData(getCommand);
                if (reader == null)
                    return false;
                while (reader.Read())
                {
                    huurcontractId = Convert.ToInt32(reader["ID"]);
                }

                #region commands en parameters2

                OracleCommand huurdercmd = new OracleCommand(queryhuurder, Conn);
                huurdercmd.Parameters.Add("huurcontractid", huurcontractId);
                Huurder huurder = HaalHuurderOp(contract.Huurder.Email);
                huurdercmd.Parameters.Add("huurderid", huurder.ID);
                huurdercmd.ExecuteNonQuery();
               #endregion

                foreach (Boot boot in contract.Boten)
                {
                    OracleCommand bootcmd = new OracleCommand(queryBoot, Conn);
                    bootcmd.Parameters.Add("huurcontractid", huurcontractId);
                    bootcmd.Parameters.Add("bootnaam", boot.Naam);
                    bootcmd.ExecuteNonQuery();
                }
                if (contract.Artikelen.Count != 0)
                {
                   
                    foreach (Artikel artikel in contract.Artikelen)
                    {
                        OracleCommand artikelcmd = new OracleCommand(queryArtikel, Conn);
                        artikelcmd.Parameters.Add("huurcontractid", huurcontractId);
                        artikelcmd.Parameters.Add("artikelnaam", artikel.Naam);
                        artikelcmd.ExecuteNonQuery();
                    }
                    commit.ExecuteNonQuery();
                }


            }
            catch (OracleException exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return true;
        }

        public static List<Huurcontract> LaadAlleContracten()
        {
            string query = "Select * from HUURCONTRACT";
            OracleCommand cmd = new OracleCommand(query);
            List<Huurcontract> contracten = new List<Huurcontract>();

            try
            {
                OracleDataReader reader = ReadData(cmd);
                if (reader == null)
                    return contracten;
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    DateTime startdatum = Convert.ToDateTime(reader["StartDatum"]);
                    DateTime einddatum = Convert.ToDateTime(reader["Einddatum"]);
                    Huurder huurder = HaalHuurderOp(id);
                    List<Artikel> artikelen = HaalArtikelenOp(id);
                    List<Boot> boten = HaalBotenOp(id);
                    double bedrag = Convert.ToDouble(reader["BEDRAG"]);

                    Huurcontract contract = new Huurcontract(id, startdatum, einddatum, huurder, artikelen, boten, bedrag);
                    contracten.Add(contract);

                }
                CloseConnection();
                return contracten;
                
            }
            catch (OracleException)
            {
                CloseConnection();
                return contracten;
            }
        }

        public static Huurder HaalHuurderOp(string email)
        {
            string query = "Select * from Huurder H where Email = :naam";

            OracleCommand cmd = new OracleCommand(query);
            cmd.Parameters.Add("naam", email);
            Huurder huurder = new Huurder();
            try
            {
                OracleDataReader reader = ReadData(cmd);

                if (reader == null)
                    return null;
                while (reader.Read())
                {
                    huurder = new Huurder
                       (
                       Convert.ToInt32(reader["ID"]),
                       Convert.ToString(reader["Naam"]),
                       Convert.ToString(reader["Email"])
                       );
                }
                return huurder;
            }
            catch (OracleException)
            {
                CloseConnection();
                return huurder;
            }
        }
        public static Huurder HaalHuurderOp(int id)
        {
            string query = "Select * from Huurder H Join Huurcontract_Huurder HH on H.ID = HH.HUURDER_ID where HH.HUURCONTRACT_ID =" + id;
            OracleCommand cmd = new OracleCommand(query);
            Huurder huurder = new Huurder();
            try
            {
                OracleDataReader reader = ReadData(cmd);

                if (reader == null)
                    return null;
                while (reader.Read())
                {
                     huurder = new Huurder
                        (
                        Convert.ToInt32(reader["ID"]),
                        Convert.ToString(reader["Naam"]),
                        Convert.ToString(reader["Email"])
                        );
                    }
                return huurder;
            }
            catch (OracleException)
            {
                CloseConnection();
                return huurder;
            }
        }
        /// <summary>
        /// Funcite die van een int een bool maakt omdat je geen bools in de database kunt zetten doe ik het met 1 en 0
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IntToBool(int value)
        {
            if (value == 1)
            {
                return true;
            }
            return false;

        }
    }
}
