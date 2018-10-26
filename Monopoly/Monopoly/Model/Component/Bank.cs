using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Monopoly.Settings;

namespace Monopoly.Model.Component
{
    /// <summary>
    /// Banque principal du jeux
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// Instance de la banque
        /// </summary>
        private static Bank _instance = null;

        /// <summary>
        /// Compte en banque des joueurs
        /// </summary>
        private static Dictionary<int, int> bankAccount;

        /// <summary>
        /// Nombre de maison
        /// </summary>
        public int NbHouse { get; private set; }

        /// <summary>
        /// Nombre d'Hotel
        /// </summary>
        public int NbHotel { get; private set; }      

        
        /// <summary>
        /// Création d'une banque
        /// </summary>
        private Bank()
        {
            NbHotel = Config.NUMBER_OF_HOTEL;
            NbHouse = Config.NUMBER_OF_HOUSE;
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

        /// <summary>
        /// Verifi si le compte de l'utilisateur possède assez d'argent pour faire une transaction
        /// </summary>
        /// <param name="p">Joueur</param>
        /// <param name="amount">Montant à debité</param>
        /// <returns></returns>
        public bool checkIfAmountIsEnough(Player p, int amount)
        {
            int BankAccountAmount = GetBankAccount(p);
            return ((BankAccountAmount - amount) > 0);
            
        }

        /// <summary>
        /// Récupère le compte en bank d'un utilisateur
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private int GetBankAccount(Player p)
        {
            return bankAccount[p.Id];
        }

        /// <summary>
        /// Modifie le compte en banque d'un utilisateur
        /// </summary>
        /// <param name="p">Joueur</param>
        /// <param name="amount">Compte en banque</param>
        public void UpdateBankAccount(Player p, int amount)
        {
           //GetBankAccount(p)
        }
    }
}
