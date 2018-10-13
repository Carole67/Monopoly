using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component.Card;
using Monopoly.Model.Component.Entity;

namespace Monopoly.Handler.Entity
{
    public class CardHandler
    {
        private static CardHandler _instance = null;
        private List<CommunityCard> _listCommunityCard;
        private List<ChanceCard> _listChanceCard;

        /// <summary>
        /// Cration du gestionnaire de carte
        /// </summary>
        private CardHandler()
        {
            _listCommunityCard = Service.XmlDataAccess.XMLDeserializeListOf<CommunityCard>(Config.filePath_XmlCommunityCard);
            _listChanceCard = Service.XmlDataAccess.XMLDeserializeListOf<ChanceCard>(Config.filePath_XmlChanceCard);
        }

        /// <summary>
        /// Instance du gestionnaire de cartes
        /// </summary>
        public static CardHandler Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new CardHandler();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Récupère la liste des carte "Chances"
        /// </summary>
        public List<ChanceCard> ListChanceCard
        {
            get { return _listChanceCard; }
        }
        /// <summary>
        /// Récupère la liste des carte "Communauté"
        /// </summary>
        public List<CommunityCard> ListCommunityCard
        {
            get { return _listCommunityCard; }
        }

        /// <summary>
        /// Affiche la liste des cartes "Chance" et "Communauté"
        /// </summary>
        public void DisplayCards()
        {
            Console.WriteLine("---- CARTE CHANCE ----");
            foreach (ChanceCard chanceCard in _listChanceCard)
            {
                Console.WriteLine(chanceCard.ToString());
            }

            Console.WriteLine("---- CARTE DE COMMUNAUTE ----");
            foreach (CommunityCard CommunityCard in _listCommunityCard)
            {
                Console.WriteLine(CommunityCard.ToString());
            }
        }
        
    }
}
