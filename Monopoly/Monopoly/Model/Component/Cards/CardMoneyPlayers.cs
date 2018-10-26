using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Monopoly.Model.Component;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("CardMoneyPlayers")]
    public class CardMoneyPlayers : Card
    {
        [XmlElement("Amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Création d'une carte (Chaque joueur verse un montant à un autre joueur)
        /// </summary>
        public CardMoneyPlayers() { }
        
    }
}
