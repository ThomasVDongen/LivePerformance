using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                new OracleCommand("SELECT Functie FROM MEDEWERKER WHERE NAAM = :naam AND wachtwoord = :wachtwoord");
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
                functie = "Er was een error";
                return functie;
            }
            return functie;

        }

    }
}
