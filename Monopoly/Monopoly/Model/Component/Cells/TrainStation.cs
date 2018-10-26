using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cells
{
    [Serializable]
    [XmlRoot("TrainStation")]
    public class TrainStation : Property
    {
        [XmlElement("Logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Création d'une case "Gare"
        /// </summary>
        public TrainStation() { }
    }
}
