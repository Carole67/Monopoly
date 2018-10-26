using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Handler;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("Card")]
    [XmlInclude(typeof(CardMoneyPlayers))]
    [XmlInclude(typeof(CardMoneyOrDrawCard))]
    [XmlInclude(typeof(CardMove))]
    [XmlInclude(typeof(CardMoveTo))]
    [XmlInclude(typeof(CardMoney))]
    [XmlInclude(typeof(CardMoneyAccordingBuilds))]
    [XmlInclude(typeof(CardGoToJail))]
    [XmlInclude(typeof(CardExitToJail))]
    public class Card
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("Type")]
        public int Type { get; set; }
        [XmlElement("EventType")]
        public int EventType { get; set; }

        
        /// <summary>
        /// Création d'une carte
        /// </summary>
        public Card() { }


        /// <summary>
        /// Description de la classe
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Card [Id:{0}, Title:{1}, Description:{2}]", Id, Title, Description);
        }
    }
}
