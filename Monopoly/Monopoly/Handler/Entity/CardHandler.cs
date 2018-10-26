using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Model.Component;
using Monopoly.Model.Component.Cards;
using Monopoly.Model.Component.Cells;
using Monopoly.Settings;
using Monopoly.Service.Xml;

namespace Monopoly.Handler.Entity
{
    /// <summary>
    /// Gestionnaire de carte
    /// </summary>
    public class CardHandler
    {
        /// <summary>
        /// Instance du gestionnaire
        /// </summary>
        private static CardHandler _instance = null;

        /// <summary>
        /// Pioche : Carte de communiauté
        /// </summary>
        public Deck DeckCommunity { get; private set; }
        
        /// <summary>
        /// Pioche : Carte de chance
        /// </summary>
        public Deck DeckChance { get; private set; }

        /// <summary>
        /// Cration du gestionnaire de carte
        /// </summary>
        private CardHandler()
        {
            DeckCommunity = XmlDataAccess.XMLDeserializeObject<Deck>(Config.filePath_XmlCommunityCard);
            DeckChance = XmlDataAccess.XMLDeserializeObject<Deck>(Config.filePath_XmlChanceCard);
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
        /// Récupère la prochaine carte du paquet : Communauté
        /// </summary>
        /// <returns></returns>
        public Card GetNextCommunityCard()
        {
            return DeckCommunity.GetNextCard();
        }

        /// <summary>
        /// Récupère la prochaine carte du paquet : Chance
        /// </summary>
        /// <returns></returns>
        public Card GetNextChanceCard()
        {
            return DeckChance.GetNextCard();
        }

        
    }
}
