using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cells
{
    [Serializable]
    [XmlRoot("Tax")]
    public class Tax : Cell
    {
        [XmlElement("Logo")]
        public string Logo { get; set; }
        [XmlElement("Amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Création d'une case "Taxe"
        /// </summary>
        public Tax() { }
    }
}
