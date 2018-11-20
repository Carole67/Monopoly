using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component;
using Monopoly.Model.Component.Bank;
using Monopoly.Model.Component.Cells;

namespace Monopoly.Handler.Entity
{
    /// <summary>
    /// Gestionnaire de joueurs
    /// </summary>
    public class PlayerHandler 
    {
        #region Variables
        /// <summary>
        /// Instance du gesitonnaire
        /// </summary>
        private static PlayerHandler _instance = null;
        /// <summary>
        /// Liste des joueurs
        /// </summary>
        public List<Player> ListOfPlayer { get; private set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Création du gesitonaire de joueurs
        /// </summary>
        private PlayerHandler()
        {
            ListOfPlayer = new List<Player>();
        }
        /// <summary>
        /// Récupère l'unique instance de la classe : HandlerPlayer
        /// </summary>
        public static PlayerHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PlayerHandler();
                }
                return _instance;
            }
        }
        #endregion

        #region Methodes privés
        /// <summary>
        /// Verifie que le joueur possède bien la propriété
        /// </summary>
        /// <param name="property">Propriete</param>
        /// <returns>Boolean</returns>
        private bool PlayerOwnProperty(Player player, Property property)
        {
            Predicate<Property> findProperty = (Property p) => { return p.Id == property.Id; };
            return (player.ListOfPoperties.Find(findProperty) != null);

        }
        /// <summary>
        /// Cherche le prochain joueur
        /// </summary>
        /// <param name="p">joueur précedent</param>
        /// <returns></returns>
        private Player findNextPlayer(Player p)
        {
            Predicate<Player> filterPlayer = (Player player) => { return player == p; };
            int index = (ListOfPlayer.FindIndex(filterPlayer)) % ListOfPlayer.Count;
            return ListOfPlayer[index + 1];

        }
        #endregion

        #region Methodes publiques
        /// <summary>
        /// Ajoute un joueur à la liste des joueurs
        /// </summary>
        /// <param name="p">Joueur</param>
        public void AddPlayer(Player p)
        {
            ListOfPlayer.Add(p);
        }

        /// <summary>
        /// Enlève un joueur à la liste des joueurs
        /// </summary>
        /// <param name="p"></param>
        public void RemovePlayer(Player p)
        {
            ListOfPlayer.Remove(p);
        }

        /// <summary>
        /// Récupère le joueur courant
        /// </summary>
        /// <returns></returns>
        public Player GetCurrentPlayer()
        {
            Predicate<Player> filtrePlayer = (Player p) => { return p.Status == Player.PLAYING; };
            return ListOfPlayer.Find(filtrePlayer);
        }

        /// <summary>
        /// Fin de tour
        /// </summary>
        /// <param name="p">Player</param>
        public void EndTurn(Player p)
        {
            p.Status = Player.WAITING;
            Player nextPlayer = findNextPlayer(p);
            nextPlayer.Status = Player.PLAYING;
        }
               
        /// <summary>
        /// Déplace le joueur à une position cible
        /// </summary>
        /// <param name="p">Joueur</param>
        /// <param name="position">Position</param>
        public void MoveTo(Player p, int position)
        {
            p.MoveTo(position);
        }

        /// <summary>
        /// Déplace le joueur sur une cellule cible
        /// </summary>
        /// <param name="p">Joueur</param>
        /// <param name="c">Cell</param>
        public void MoveTo(Player p, Cell c)
        {
            p.MoveTo(c);
        }

        /// <summary>
        /// Achete une propriété cible à la banque
        /// </summary>
        /// <param name="property">Propriété</param>
        public void BuyProperty(Player player, Property property)
        {
            // review

            if (property.status == Property.AVAILABLE_ON_SALE)
            {
                BankAccount account = Bank.Instance.GetBankAccount(player);
                account.BankTransfer(Bank.Instance.GetBankAccount(), property.PurchasePrice);

                player.AddPorperty(property);
            }
            else
            {
                Console.WriteLine("Property not available");
            }
           
        }

        /// <summary>
        /// Achète une propriete qui appartien à une autre personne
        /// </summary>
        /// <param name="player">joueur</param>
        /// <param name="toPlayer">joueur qui possède la propriété</param>
        /// <param name="property">propriété</param>
        public void BuyPropertyTo(Player player, Player toPlayer, Property property)
        {
            //TODO
        }

        private void CountTheNumberOfLandInLandGroup(LandGroup groupe)
        {
            /*
            if(property.GetType() == typeof(Land))
            {
                ((Land)property).LandGroup.IdGroup
            }
            */
        }
        public bool CheckIfPlayerOwnAllLandInLandGroup(Player player, Property property)
        {
            /*

            Func<Property, bool> filter = CountTheNumberOfLandInLandGroup();
            bank.find
            return false;
            */
            return false;
        }

        public void BuildHouse(Player player, Land land, int nbHouse)
        {
            //BankAccount account = Bank.Instance.GetBankAccount(player);
            //int LandRantal = ((land.NbHouse > 0) &&()) ? land.GetRental();
            //account.BankTransfer(Bank.Instance.GetBankAccount(), land.GetRental();

        }
        public void BuildHotel(Player player, Land land)
        {
            BankAccount account = Bank.Instance.GetBankAccount(player);


        }
        #endregion
    }
}
