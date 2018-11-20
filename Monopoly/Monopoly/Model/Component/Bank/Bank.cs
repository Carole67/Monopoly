using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Monopoly.Model.Component.Cells;
using Monopoly.Settings;

namespace Monopoly.Model.Component.Bank
{
    /// <summary>
    /// Banque principal du jeux
    /// </summary>
    public class Bank
    {
        #region Constantes
        public static int GLOBAL_BANK_ACCOUNT = 0;
        #endregion

        #region Variables
        /// <summary>
        /// Instance de la banque
        /// </summary>
        private static Bank _instance = null;

        /// <summary>
        /// Compte en banque des joueurs
        /// </summary>
        private Dictionary<int,BankAccount> DictionayOfBankAcount;

        /// <summary>
        /// Liste de propriété
        /// </summary>
        /// <returns></returns>
        public List<Property> ListOfProperties { get; private set; }

        /// <summary>
        /// Nombre de maison
        /// </summary>
        public int NbHouse { get; private set; }

        /// <summary>
        /// Nombre d'hotel
        /// </summary>
        public int NbHotel { get; private set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Création d'une banque
        /// </summary>
        private Bank()
        {
            NbHotel = Config.NUMBER_MAX_OF_HOUSE;
            NbHouse = Config.NUMBER_MAX_OF_HOTEL;
            DictionayOfBankAcount = new Dictionary<int, BankAccount>();
            ListOfProperties = new List<Property>();
            DictionayOfBankAcount.Add(GLOBAL_BANK_ACCOUNT, new BankAccount());
        }

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
        #endregion

        #region Methodes publique
        /// <summary>
        /// Récupère le compte en bank d'un utilisateur
        /// </summary>
        /// <param name="p">Player</param>
        /// <returns></returns>
        public BankAccount GetBankAccount(Player player)
        {
            return DictionayOfBankAcount[player.Id];
        }

        /// <summary>
        /// Récupère le compte en bank princiaple
        /// </summary>
        /// <returns></returns>
        public BankAccount GetBankAccount()
        {
            return DictionayOfBankAcount[GLOBAL_BANK_ACCOUNT];
        }

        /// <summary>
        /// Crée un compte en banque spécifique pour un Joueur
        /// </summary>
        /// <param name="p">Joueur</param>
        public void CreateBankAccount(Player p)
        {
            if(!this.DictionayOfBankAcount.ContainsKey(p.Id))
            {
                this.DictionayOfBankAcount.Add(p.Id, new BankAccount(Config.INITIAL_BANCK_BALANCE));
            }
            else
            {
                Console.WriteLine("Le joueur posède déjà un compte en banque");
            }
            
        }
        #endregion
    }
}
