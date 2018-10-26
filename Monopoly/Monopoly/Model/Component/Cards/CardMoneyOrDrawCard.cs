using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("CardMoneyOrDrawCard")]
    public class CardMoneyOrDrawCard : Card
    {
        [XmlElement("CardTypeToDraw")]
        public int CardTypeToDraw { get; set; }
        [XmlElement("Amount")]
        public int Amount { get; set; }

        public const short EFFECT_DRAWCARD = 0;
        public const short EFFECT_PAY_FEES = 1;

        /// <summary>
        /// Création d'une carte (Choix : Amande ou pioche)
        /// </summary>
        public CardMoneyOrDrawCard() { }

       
    }
}
