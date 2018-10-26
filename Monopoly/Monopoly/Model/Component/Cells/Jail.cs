using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cells
{   
    [Serializable]
    [XmlRoot("Jail")]
    public class Jail : Cell
    {
        [XmlElement("Logo")]
        public string Logo;

        /// <summary>
        /// Création d'un case "Prison"
        /// </summary>
        public Jail() { }
    }
}
