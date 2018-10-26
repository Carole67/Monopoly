using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monopoly.Model.Component.Cells
{
    [Serializable]
    [XmlRoot("Property")]
    [XmlInclude(typeof(Land))]
    [XmlInclude(typeof(PublicService))]
    [XmlInclude(typeof(TrainStation))]
    public class Property : Cell
    {
        [XmlElement("PurchasePrice")]
        public int PurchasePrice { get; set; }
        [XmlElement("MortgagePrice")]
        public int MortgagePrice { get; set; }
        [XmlElement("Status")]
        public int Status { get; set; }
        
        [XmlIgnore]
        public const int STATUS_SOLD = 1;
        [XmlIgnore]
        public const int STATUS_MONTAGAGE = 2;
        [XmlIgnore]
        public const int STATUS_AVAILABLE = 3;
        
        /// <summary>
        /// Création d'une case "Propriete"
        /// </summary>
        public Property()
        {
           Status = STATUS_AVAILABLE;
        }


    }
}
