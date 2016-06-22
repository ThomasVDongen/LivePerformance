using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceThomasvanDongen.Models
{
    public class Huurder
    {
        /// <summary>
        /// properties
        /// </summary>
        public int ID { get; set; }
        public string Naam { get; set; }   
        public string Email { get; set; }
        /// <summary>
        /// Constructor van huurder
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        /// <param name="email"></param>
        public Huurder(int id, string naam, string email)
        {
            ID = id;
            Naam = naam;
            Email = email;
        }
    }
}
