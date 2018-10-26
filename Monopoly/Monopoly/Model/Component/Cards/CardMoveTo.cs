using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("CardMoveTo")]
    public class CardMoveTo : Card
    {
        [XmlElement("CellPosition")]
        public int CellPosition { get; set; }

        /// <summary>
        /// Création d'une case (Deplacement à une position précis)
        /// </summary>
        public CardMoveTo() { }
    }
}
