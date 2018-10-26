using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("CardMoney")]
    public class CardMoney : Card
    {
        [XmlElement("Amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Création d'une carte (Gain d'argent, Amande) 
        /// </summary>
        public CardMoney() { }

        
    }
}
