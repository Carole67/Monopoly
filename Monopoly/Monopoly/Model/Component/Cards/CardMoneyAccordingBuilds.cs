using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("CardMoneyAccordingBuilds")]
    public class CardMoneyAccordingBuilds : Card
    {
        [XmlElement("CostHotel")]
        public int CostHotel { get; set; }
        [XmlElement("CostHouse")]
        public int CostHouse { get; set; }
        
        /// <summary>
        /// Création d'une carte (Réparation pour chaque hotel, maison d'un joueurs)
        /// </summary>
        public CardMoneyAccordingBuilds() { }
                
    }
}
