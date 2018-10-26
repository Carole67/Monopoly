using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Monopoly.Model.Component.Cards;

namespace Monopoly.Model.Component
{
    /// <summary>
    /// Paquet de cartes
    /// </summary>
    [Serializable]
    [XmlRoot("Deck")]
    public class Deck
    {
        /// <summary>
        /// Liste de cartes
        /// </summary>
        [XmlElement("Card")]
        public List<Card> Cards { get; set; }
        [XmlIgnore]
        private int _index;

        /// <summary>
        /// Création d'un paquet de cartes
        /// </summary>
        public Deck()
        {
            this.Cards = new List<Card>();
            _index = Cards.Count - 1;
        }

        /// <summary>
        /// Récupère la prochaine carte du packet
        /// </summary>
        /// <returns>Carte</returns>
        public Card GetNextCard()
        {
            _index = (_index + 1) % Cards.Count;
            return Cards[_index];
        }

        /// <summary>
        /// Mélange le packet de carte de façon aléatoire
        /// </summary>
        /// <param name="pList">Paquet de carte</param>
        public static void Shuffle(List<Card> pList)
        {
            Random rand = new Random();

            int nbMotion = pList.Count;
            while (nbMotion > 1)
            {
                nbMotion--;
                int randomIndex = rand.Next(nbMotion + 1);
                Card obj = pList[randomIndex];
                pList[randomIndex] = pList[nbMotion];
                pList[nbMotion] = obj;
            }
        }

        public void DisplayCards()
        {
            foreach(Card c in Cards)
            {
                Console.WriteLine("Carte de type " + c.GetType().Name);
            }
        }

    }
}
