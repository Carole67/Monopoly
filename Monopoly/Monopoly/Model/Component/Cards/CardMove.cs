using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("CardMove")]
    public class CardMove : Card
    {
        [XmlElement("NbMove")]
        public int NbMove { get; set; }

        /// <summary>
        /// Création d'une carte (Deplacement de N case)
        /// </summary>
        public CardMove() { }

    }
}
