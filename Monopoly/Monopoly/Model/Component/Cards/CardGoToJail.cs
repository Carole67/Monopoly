using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("CardGoToJail")]
    public class CardGoToJail : Card
    {
        [XmlElement("CellPosition")]
        public int CellPosition { get; set; }

        /// <summary>
        /// Création de la carte Allez en prison
        /// </summary>
        public CardGoToJail() { }
               
    }
}
