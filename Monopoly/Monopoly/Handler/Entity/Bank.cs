using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Handler
{
    /// <summary>
    /// Banque principal du jeux
    /// </summary>
    public class Bank
    {
        private static Bank _instance = null;
        private int _account { get; set; }
        private int _nbHouse { get; set; }
        private int _nbHotel { get; set; }
        
        /// <summary>
        /// Création d'une banque
        /// </summary>
        public Bank() { }


        /// <summary>
        /// Instance de la banque
        /// </summary>
        public static Bank Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Bank();
                }
                return _instance;
            }
        }

    }
}
