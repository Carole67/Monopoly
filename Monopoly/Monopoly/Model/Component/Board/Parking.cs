using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Board
{
    [Serializable]
    [XmlRoot("Parking")]
    public class Parking : Cell
    {
        [XmlElement("Logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Création d'une case "Parking"
        /// </summary>
        public Parking() { }
    }
}
