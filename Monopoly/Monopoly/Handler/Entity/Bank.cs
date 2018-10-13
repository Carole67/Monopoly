using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Handler
{
    /// <summary>
    /// Banque principal du jeux
    /// </summary>
    [Serializable]
    [XmlRoot("Bank")]
    public class Bank
    {
        [XmlIgnore]
        private static Bank _instance = null;
        [XmlElement("BankAccount")]
        private int _account;
        [XmlElement("PlayersAmount")]
        private int _playerAmount;
        [XmlElement("NbHouse")]
        private int _nbHouse;
        [XmlElement("NbHotel")]
        private int _nbHotel;
        
        /// <summary>
        /// Création d'une banque
        /// </summary>
        public Bank(){ }


        /// <summary>
        /// Instance de la banque
        /// </summary>
        public static Bank Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = Service.XmlDataAccess.XMLDeserializeObject<Bank>(Config.filePath_XmlBank);
                }
                return _instance;
            }
        }

        public int Account { get { return _account; } set { _account = value; } }
        public int PlayerAmount { get { return _playerAmount; } set { _playerAmount = value; } }
        public int NbHouse { get { return _nbHouse; } set { _nbHouse = value; } }
        public int NbHotel { get { return _nbHotel; } set { _nbHotel = value; } }

        public override string ToString()
        {
            return string.Format("BANK => {0} : {1} : {2} : {3}", new object[] { Account, PlayerAmount, NbHouse, NbHotel } );
        }

    }
}
