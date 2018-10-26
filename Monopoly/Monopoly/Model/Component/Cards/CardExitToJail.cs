using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cards
{
    [Serializable]
    [XmlRoot("CardExitToJail")]
    public class CardExitToJail : Card
    {
        /// <summary>
        /// Création carte sortie de prison
        /// </summary>
        public CardExitToJail(){}

    }
}
