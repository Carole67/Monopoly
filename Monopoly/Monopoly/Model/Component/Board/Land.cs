using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Board
{
    [Serializable]
    [XmlRoot("Land")]
    public class Land : Property
    {
        [XmlElement("LandGroup")]
        public LandGroup LandGroup { get; set; }
        [XmlArray("RantalList")]
        [XmlArrayItem("Rantal")]
        public List<int> RantalList { get; set; }

        /// <summary>
        /// Création d'une case "Terrain"
        /// </summary>
        public Land() { }
    }
}
