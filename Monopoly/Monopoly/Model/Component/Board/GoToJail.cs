using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Board
{
    [Serializable]
    [XmlRoot("GoToJail")]
    public class GoToJail : Cell
    {
        [XmlElement("Logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Création d'un case "Allez en prison"
        /// </summary>
        public GoToJail() { }
    }
}
